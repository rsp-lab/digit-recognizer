using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sieć
{
    class BPNN
    {
        protected int input_n;                  /* number of input units */
        protected int hidden_n;                 /* number of hidden units */
        protected int output_n;                 /* number of output units */

        protected double[] input_units;          /* the input units */
        protected double[] hidden_units;         /* the hidden units */
        protected double[] output_units;         /* the output units */

        protected double[] hidden_delta;         /* storage for hidden unit error */
        protected double[] output_delta;         /* storage for output unit error */

        protected double[] target;               /* storage for target vector */

        protected double[][] input_weights;       /* weights from input to hidden layer */
        protected double[][] hidden_weights;      /* weights from hidden to output layer */

        /*** The next two are for momentum ***/
        protected double[][] input_prev_weights;  /* previous change on input to hidden wgt */
        protected double[][] hidden_prev_weights; /* previous change on hidden to output wgt */

        private double lastResponse;
        public double outError;
        public double hiddenError;

        public BPNN(int n_in, int n_hidden, int n_out)
        {
            this.input_n = n_in;
            this.hidden_n = n_hidden;
            this.output_n = n_out;
            this.input_units = new double[n_in + 1]; // alloc_1d_dbl(n_in + 1);
            this.hidden_units = new double[n_hidden + 1]; // alloc_1d_dbl(n_hidden + 1);
            this.output_units = new double[n_out + 1]; // alloc_1d_dbl(n_out + 1);

            this.hidden_delta = new double[n_hidden + 1];// alloc_1d_dbl(n_hidden + 1);
            this.output_delta = new double[n_out + 1]; // alloc_1d_dbl(n_out + 1);
            this.target = new double[n_out + 1]; // alloc_1d_dbl(n_out + 1);

            this.input_weights = new double[n_in + 1][];// alloc_2d_dbl(n_in + 1, n_hidden + 1);
            for (int i = 0; i < (n_in + 1); i++)
                input_weights[i] = new double[n_hidden + 1];
            this.hidden_weights = new double[n_hidden + 1][]; //alloc_2d_dbl(n_hidden + 1, n_out + 1);
            for (int i = 0; i < (n_hidden) + 1; i++)
                hidden_weights[i] = new double[n_out + 1];

            this.input_prev_weights = new double[n_in + 1][];// alloc_2d_dbl(n_in + 1, n_hidden + 1);
            for (int i = 0; i < (n_in + 1); i++)
                input_prev_weights[i] = new double[n_hidden + 1];
            this.hidden_prev_weights = new double[n_hidden + 1][];// alloc_2d_dbl(n_hidden + 1, n_out + 1);
            for (int i = 0; i < (n_hidden + 1); i++)
                hidden_prev_weights[i] = new double[n_out + 1];


            bpnn_randomize_weights(ref input_weights, n_in, n_hidden);
            bpnn_randomize_weights(ref hidden_weights, n_hidden, n_out);
            bpnn_zero_weights(ref input_prev_weights, n_in, n_hidden);
            bpnn_zero_weights(ref hidden_prev_weights, n_hidden, n_out);
        }

        public double trainNetwork(double[] wektorCech, double poprawnaOdp, double wspUczenia, double momentum)
        {
            for (int i = 1; i < input_units.Length; i++)
                input_units[i] = wektorCech[i - 1];
            target[1] = poprawnaOdp;

            bpnn_train(wspUczenia, momentum);

            lastResponse = output_units[1];
            return outError;
        }

        public double trainNetwork(double[] wektorCech, double[] poprawnaOdp, double wspUczenia, double momentum)
        {
            for (int i = 1; i < input_units.Length; i++)
                input_units[i] = wektorCech[i - 1];
            for (int i = 0; i < poprawnaOdp.Length; i++)
            {
                target[i + 1] = poprawnaOdp[i];
            }
            //target[1] = poprawnaOdp;

            bpnn_train(wspUczenia, momentum);

            lastResponse = output_units[1];
            return outError;
        }

        public double Response(double[] wektorCech)
        {
            for (int i = 1; i < input_units.Length; i++)
                input_units[i] = wektorCech[i - 1];

            bpnn_feedforward();
            lastResponse = output_units[1];
            return lastResponse;
        }

        public double[] ResponseTab(double[] wektorCech)
        {
            double[] outtemp = new double[output_units.Length - 1];

            for (int i = 1; i < input_units.Length; i++)
                input_units[i] = wektorCech[i - 1];

            bpnn_feedforward();

            //lastResponse = output_units[1];
            //return lastResponse;
            for (int i = 0; i < outtemp.Length; i++)
            {
                outtemp[i] = output_units[i + 1];
            }
            return outtemp;
        }

        public double getLastResponse()
        {
            return lastResponse;
        }

        private void bpnn_feedforward()
        {
            int inn, hid, outt;

            inn = input_n;
            hid = hidden_n;
            outt = output_n;

            /*** Feed forward input activations. ***/
            bpnn_layerforward(ref input_units, ref hidden_units, ref input_weights, inn, hid);
            bpnn_layerforward(ref hidden_units, ref output_units, ref hidden_weights, hid, outt);

        }

        private void bpnn_train(double eta, double momentum)//, ref double eo, ref double eh)
        {
            int inn, hid, outt;
            double out_err = 0.0;
            double hid_err = 0.0;

            inn = input_n;
            hid = hidden_n;
            outt = output_n;

            /*** Feed forward input activations. ***/
            bpnn_layerforward(ref input_units, ref hidden_units, ref input_weights, inn, hid);
            bpnn_layerforward(ref hidden_units, ref output_units, ref hidden_weights, hid, outt);

            /*** Compute error on output and hidden units. ***/
            bpnn_output_error(ref output_delta, ref target, ref output_units, outt, ref out_err);
            bpnn_hidden_error(ref hidden_delta, hid, ref output_delta, outt, ref hidden_weights, ref hidden_units, ref hid_err);
            outError = out_err;
            hiddenError = hid_err;

            /*** Adjust input and hidden weights. ***/
            bpnn_adjust_weights(ref output_delta, outt, ref hidden_units, hid, ref hidden_weights, ref hidden_prev_weights, eta, momentum);
            bpnn_adjust_weights(ref hidden_delta, hid, ref input_units, inn, ref input_weights, ref input_prev_weights, eta, momentum);

        }

        public static double squash(double x)  //funkcja aktywacji
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        private static void bpnn_randomize_weights(ref double[][] w, int m, int n)
        {
            int i, j;
            Random r = new Random((int)DateTime.Now.Ticks);

            for (i = 0; i <= m; i++)
            {
                for (j = 0; j <= n; j++)
                    w[i][j] = (r.NextDouble() * 2.0) - 1.0;
            }
        }

        private static void bpnn_zero_weights(ref double[][] w, int m, int n)
        {
            int i, j;

            for (i = 0; i <= m; i++)
            {
                for (j = 0; j <= n; j++)
                {
                    w[i][j] = 0.0;
                }
            }
        }

        private static void bpnn_layerforward(ref double[] layer1, ref double[] layer2, ref double[][] conn, int n1, int n2)
        {
            double sum;
            int j, k;

            /*** Set up thresholding unit ***/
            layer1[0] = 1.0;

            /*** For each unit in second layer ***/
            for (j = 1; j <= n2; j++)
            {

                /*** Compute weighted sum of its inputs ***/
                sum = 0.0;
                for (k = 0; k <= n1; k++)
                {
                    sum += conn[k][j] * layer1[k];
                }
                layer2[j] = squash(sum);	//skuash to wartośc f aktywacji KU
            }

        }

        private static void bpnn_output_error(ref double[] delta, ref double[] target, ref double[] output, int nj, ref double err)
        {
            int j;
            double o, t, errsum;

            errsum = 0.0;
            for (j = 1; j <= nj; j++)
            {
                o = output[j];
                t = target[j];
                delta[j] = o * (1.0 - o) * (t - o);		//(t-o) == delta	//(1-o) == pochodna f sigmoidalnej
                errsum += Math.Abs(delta[j]);
            }
            err = errsum;
        }

        private static void bpnn_hidden_error(ref double[] delta_h, int nh, ref double[] delta_o, int no, ref double[][] who, ref double[] hidden, ref double err)
        {
            int j, k;
            double h, sum, errsum;

            errsum = 0.0;
            for (j = 1; j <= nh; j++)
            {
                h = hidden[j];
                sum = 0.0;
                for (k = 1; k <= no; k++)
                {
                    sum += delta_o[k] * who[j][k];
                }
                delta_h[j] = h * (1.0 - h) * sum;
                errsum += Math.Abs(delta_h[j]);
            }
            err = errsum;
        }

        private static void bpnn_adjust_weights(ref double[] delta, int ndelta, ref double[] ly, int nly, ref double[][] w, ref double[][] oldw, double eta, double momentum)
        {
            double new_dw;
            int k, j;

            ly[0] = 1.0;
            for (j = 1; j <= ndelta; j++)
            {
                for (k = 0; k <= nly; k++)
                {
                    new_dw = ((eta * delta[j] * ly[k]) + (momentum * oldw[k][j]));
                    w[k][j] += new_dw;
                    oldw[k][j] = new_dw;
                }
            }
        }
    }
}
