namespace Sieć
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelNorth = new System.Windows.Forms.Panel();
            this.labelNorth = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.groupBoxNorth = new System.Windows.Forms.GroupBox();
            this.buttonConfig1 = new System.Windows.Forms.Button();
            this.labelConfig = new System.Windows.Forms.Label();
            this.textBoxNeuron = new System.Windows.Forms.TextBox();
            this.labelNeuron = new System.Windows.Forms.Label();
            this.buttonConfig0 = new System.Windows.Forms.Button();
            this.textBoxMomentum = new System.Windows.Forms.TextBox();
            this.labelMomentum = new System.Windows.Forms.Label();
            this.labelLearnRate = new System.Windows.Forms.Label();
            this.labelIterations = new System.Windows.Forms.Label();
            this.textBoxLearnRate = new System.Windows.Forms.TextBox();
            this.numericUpDownLayerNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.labelLayerNumber = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBoxSouth = new System.Windows.Forms.GroupBox();
            this.panelSouth = new System.Windows.Forms.Panel();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelRecognition = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.buttonRecognize = new System.Windows.Forms.Button();
            this.textBoxLoadFile = new System.Windows.Forms.TextBox();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogCFG = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogWAV = new System.Windows.Forms.OpenFileDialog();
            this.buttonLearnAll = new System.Windows.Forms.Button();
            this.groupBoxCenter = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelConfigShow = new System.Windows.Forms.Label();
            this.panelNorth.SuspendLayout();
            this.groupBoxNorth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLayerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            this.groupBoxSouth.SuspendLayout();
            this.panelSouth.SuspendLayout();
            this.groupBoxCenter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNorth
            // 
            this.panelNorth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNorth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNorth.Controls.Add(this.labelNorth);
            this.panelNorth.Location = new System.Drawing.Point(14, 12);
            this.panelNorth.Name = "panelNorth";
            this.panelNorth.Size = new System.Drawing.Size(537, 48);
            this.panelNorth.TabIndex = 0;
            // 
            // labelNorth
            // 
            this.labelNorth.AutoSize = true;
            this.labelNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNorth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNorth.Location = new System.Drawing.Point(12, 11);
            this.labelNorth.Name = "labelNorth";
            this.labelNorth.Size = new System.Drawing.Size(353, 24);
            this.labelNorth.TabIndex = 0;
            this.labelNorth.Text = "Witaj w programie do rozpoznawania cyfr";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Katalog z próbkami";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Location = new System.Drawing.Point(106, 29);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(201, 20);
            this.textBox.TabIndex = 4;
            this.textBox.Text = "C:\\Uczący";
            // 
            // groupBoxNorth
            // 
            this.groupBoxNorth.Controls.Add(this.buttonConfig1);
            this.groupBoxNorth.Controls.Add(this.labelConfig);
            this.groupBoxNorth.Controls.Add(this.textBoxNeuron);
            this.groupBoxNorth.Controls.Add(this.labelNeuron);
            this.groupBoxNorth.Controls.Add(this.buttonConfig0);
            this.groupBoxNorth.Controls.Add(this.textBoxMomentum);
            this.groupBoxNorth.Controls.Add(this.labelMomentum);
            this.groupBoxNorth.Controls.Add(this.textBox);
            this.groupBoxNorth.Controls.Add(this.button1);
            this.groupBoxNorth.Controls.Add(this.labelLearnRate);
            this.groupBoxNorth.Controls.Add(this.labelIterations);
            this.groupBoxNorth.Controls.Add(this.textBoxLearnRate);
            this.groupBoxNorth.Controls.Add(this.numericUpDownLayerNumber);
            this.groupBoxNorth.Controls.Add(this.numericUpDownIterations);
            this.groupBoxNorth.Controls.Add(this.labelLayerNumber);
            this.groupBoxNorth.Location = new System.Drawing.Point(12, 67);
            this.groupBoxNorth.Name = "groupBoxNorth";
            this.groupBoxNorth.Size = new System.Drawing.Size(318, 199);
            this.groupBoxNorth.TabIndex = 5;
            this.groupBoxNorth.TabStop = false;
            this.groupBoxNorth.Text = "Ustawienia Programu";
            // 
            // buttonConfig1
            // 
            this.buttonConfig1.Location = new System.Drawing.Point(198, 140);
            this.buttonConfig1.Name = "buttonConfig1";
            this.buttonConfig1.Size = new System.Drawing.Size(109, 45);
            this.buttonConfig1.TabIndex = 52;
            this.buttonConfig1.Text = "1 sieć z 10 wyjściami";
            this.buttonConfig1.UseVisualStyleBackColor = true;
            this.buttonConfig1.Click += new System.EventHandler(this.buttonConfig1_Click);
            this.buttonConfig1.MouseHover += new System.EventHandler(this.buttonConfig1_MouseHover);
            // 
            // labelConfig
            // 
            this.labelConfig.AutoSize = true;
            this.labelConfig.Location = new System.Drawing.Point(195, 67);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(93, 13);
            this.labelConfig.TabIndex = 51;
            this.labelConfig.Text = "Konfiguracja sieci:";
            // 
            // textBoxNeuron
            // 
            this.textBoxNeuron.Location = new System.Drawing.Point(106, 165);
            this.textBoxNeuron.Name = "textBoxNeuron";
            this.textBoxNeuron.Size = new System.Drawing.Size(83, 20);
            this.textBoxNeuron.TabIndex = 50;
            this.textBoxNeuron.Text = "20";
            // 
            // labelNeuron
            // 
            this.labelNeuron.AutoSize = true;
            this.labelNeuron.Location = new System.Drawing.Point(7, 168);
            this.labelNeuron.Name = "labelNeuron";
            this.labelNeuron.Size = new System.Drawing.Size(84, 13);
            this.labelNeuron.TabIndex = 49;
            this.labelNeuron.Text = "Ilość Neuronów:";
            // 
            // buttonConfig0
            // 
            this.buttonConfig0.Location = new System.Drawing.Point(198, 90);
            this.buttonConfig0.Name = "buttonConfig0";
            this.buttonConfig0.Size = new System.Drawing.Size(109, 45);
            this.buttonConfig0.TabIndex = 48;
            this.buttonConfig0.Text = "10 sieci z 1 wyjściem";
            this.buttonConfig0.UseVisualStyleBackColor = true;
            this.buttonConfig0.Click += new System.EventHandler(this.buttonConfig0_Click);
            this.buttonConfig0.MouseHover += new System.EventHandler(this.buttonConfig0_MouseHover);
            // 
            // textBoxMomentum
            // 
            this.textBoxMomentum.Location = new System.Drawing.Point(106, 140);
            this.textBoxMomentum.Name = "textBoxMomentum";
            this.textBoxMomentum.Size = new System.Drawing.Size(83, 20);
            this.textBoxMomentum.TabIndex = 42;
            this.textBoxMomentum.Text = "0,40";
            // 
            // labelMomentum
            // 
            this.labelMomentum.AutoSize = true;
            this.labelMomentum.Location = new System.Drawing.Point(7, 143);
            this.labelMomentum.Name = "labelMomentum";
            this.labelMomentum.Size = new System.Drawing.Size(62, 13);
            this.labelMomentum.TabIndex = 43;
            this.labelMomentum.Text = "Momentum:";
            // 
            // labelLearnRate
            // 
            this.labelLearnRate.AutoSize = true;
            this.labelLearnRate.Location = new System.Drawing.Point(7, 118);
            this.labelLearnRate.Name = "labelLearnRate";
            this.labelLearnRate.Size = new System.Drawing.Size(78, 13);
            this.labelLearnRate.TabIndex = 9;
            this.labelLearnRate.Text = "Współczynnik:";
            // 
            // labelIterations
            // 
            this.labelIterations.AutoSize = true;
            this.labelIterations.Location = new System.Drawing.Point(7, 67);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(66, 13);
            this.labelIterations.TabIndex = 5;
            this.labelIterations.Text = "Ilość Iteracji:";
            // 
            // textBoxLearnRate
            // 
            this.textBoxLearnRate.Location = new System.Drawing.Point(106, 115);
            this.textBoxLearnRate.Name = "textBoxLearnRate";
            this.textBoxLearnRate.Size = new System.Drawing.Size(83, 20);
            this.textBoxLearnRate.TabIndex = 33;
            this.textBoxLearnRate.Text = "0,1";
            // 
            // numericUpDownLayerNumber
            // 
            this.numericUpDownLayerNumber.Location = new System.Drawing.Point(106, 90);
            this.numericUpDownLayerNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownLayerNumber.Name = "numericUpDownLayerNumber";
            this.numericUpDownLayerNumber.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownLayerNumber.TabIndex = 35;
            this.numericUpDownLayerNumber.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDownIterations
            // 
            this.numericUpDownIterations.Location = new System.Drawing.Point(106, 65);
            this.numericUpDownIterations.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownIterations.Name = "numericUpDownIterations";
            this.numericUpDownIterations.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownIterations.TabIndex = 8;
            this.numericUpDownIterations.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // labelLayerNumber
            // 
            this.labelLayerNumber.AutoSize = true;
            this.labelLayerNumber.Location = new System.Drawing.Point(7, 92);
            this.labelLayerNumber.Name = "labelLayerNumber";
            this.labelLayerNumber.Size = new System.Drawing.Size(51, 13);
            this.labelLayerNumber.TabIndex = 34;
            this.labelLayerNumber.Text = "Podziały:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 90);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(205, 28);
            this.progressBar.TabIndex = 12;
            // 
            // groupBoxSouth
            // 
            this.groupBoxSouth.Controls.Add(this.panelSouth);
            this.groupBoxSouth.Controls.Add(this.textBox9);
            this.groupBoxSouth.Controls.Add(this.label9);
            this.groupBoxSouth.Controls.Add(this.textBox8);
            this.groupBoxSouth.Controls.Add(this.label8);
            this.groupBoxSouth.Controls.Add(this.textBox7);
            this.groupBoxSouth.Controls.Add(this.label7);
            this.groupBoxSouth.Controls.Add(this.textBox6);
            this.groupBoxSouth.Controls.Add(this.label6);
            this.groupBoxSouth.Controls.Add(this.textBox5);
            this.groupBoxSouth.Controls.Add(this.label5);
            this.groupBoxSouth.Controls.Add(this.textBox4);
            this.groupBoxSouth.Controls.Add(this.label4);
            this.groupBoxSouth.Controls.Add(this.textBox3);
            this.groupBoxSouth.Controls.Add(this.label3);
            this.groupBoxSouth.Controls.Add(this.textBox2);
            this.groupBoxSouth.Controls.Add(this.label2);
            this.groupBoxSouth.Controls.Add(this.textBox1);
            this.groupBoxSouth.Controls.Add(this.label1);
            this.groupBoxSouth.Controls.Add(this.textBox0);
            this.groupBoxSouth.Controls.Add(this.label0);
            this.groupBoxSouth.Controls.Add(this.buttonRecognize);
            this.groupBoxSouth.Controls.Add(this.textBoxLoadFile);
            this.groupBoxSouth.Controls.Add(this.buttonLoadFile);
            this.groupBoxSouth.Location = new System.Drawing.Point(12, 272);
            this.groupBoxSouth.Name = "groupBoxSouth";
            this.groupBoxSouth.Size = new System.Drawing.Size(541, 199);
            this.groupBoxSouth.TabIndex = 6;
            this.groupBoxSouth.TabStop = false;
            this.groupBoxSouth.Text = "Efekt uczenia sieci";
            // 
            // panelSouth
            // 
            this.panelSouth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSouth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSouth.Controls.Add(this.labelNumber);
            this.panelSouth.Controls.Add(this.labelRecognition);
            this.panelSouth.Location = new System.Drawing.Point(188, 84);
            this.panelSouth.Name = "panelSouth";
            this.panelSouth.Size = new System.Drawing.Size(328, 83);
            this.panelSouth.TabIndex = 32;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNumber.Location = new System.Drawing.Point(234, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(74, 78);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "0";
            this.labelNumber.Visible = false;
            // 
            // labelRecognition
            // 
            this.labelRecognition.AutoSize = true;
            this.labelRecognition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRecognition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRecognition.Location = new System.Drawing.Point(34, 27);
            this.labelRecognition.Name = "labelRecognition";
            this.labelRecognition.Size = new System.Drawing.Size(190, 24);
            this.labelRecognition.TabIndex = 1;
            this.labelRecognition.Text = "Rozpoznana cyfra to: ";
            this.labelRecognition.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(123, 170);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(51, 20);
            this.textBox9.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "9:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(123, 144);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(51, 20);
            this.textBox8.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "8:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(123, 118);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(51, 20);
            this.textBox7.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "7:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(123, 92);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(51, 20);
            this.textBox6.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "6:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(123, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(51, 20);
            this.textBox5.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "5:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(37, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 20);
            this.textBox4.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "4:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(37, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 20);
            this.textBox3.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "3:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "2:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "1:";
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(37, 66);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(51, 20);
            this.textBox0.TabIndex = 15;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(15, 69);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(16, 13);
            this.label0.TabIndex = 14;
            this.label0.Text = "0:";
            // 
            // buttonRecognize
            // 
            this.buttonRecognize.Location = new System.Drawing.Point(8, 19);
            this.buttonRecognize.Name = "buttonRecognize";
            this.buttonRecognize.Size = new System.Drawing.Size(166, 35);
            this.buttonRecognize.TabIndex = 14;
            this.buttonRecognize.Text = "Rozpoznaj próbkę";
            this.buttonRecognize.UseVisualStyleBackColor = true;
            this.buttonRecognize.Click += new System.EventHandler(this.buttonRecognize_Click);
            this.buttonRecognize.MouseHover += new System.EventHandler(this.buttonRecognize_MouseHover);
            // 
            // textBoxLoadFile
            // 
            this.textBoxLoadFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoadFile.Location = new System.Drawing.Point(266, 28);
            this.textBoxLoadFile.Name = "textBoxLoadFile";
            this.textBoxLoadFile.Size = new System.Drawing.Size(267, 20);
            this.textBoxLoadFile.TabIndex = 14;
            this.textBoxLoadFile.TextChanged += new System.EventHandler(this.textBoxLoadFile_TextChanged);
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(180, 19);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(80, 35);
            this.buttonLoadFile.TabIndex = 14;
            this.buttonLoadFile.Text = "Wybierz plik";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.button2_Click);
            this.buttonLoadFile.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.SelectedPath = "C:\\cyfry_0-9\\";
            // 
            // openFileDialogCFG
            // 
            this.openFileDialogCFG.FileName = "konfiguracja.cfg";
            this.openFileDialogCFG.Filter = "Plik konfiguracyjny|*.cfg|Wszystkie pliki|*.*";
            this.openFileDialogCFG.InitialDirectory = "C:\\";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "konfiguracja.cfg";
            this.saveFileDialog.Filter = "Plik konfiguracyjny|*.cfg";
            this.saveFileDialog.InitialDirectory = "C:\\";
            // 
            // openFileDialogWAV
            // 
            this.openFileDialogWAV.FileName = "plik dźwiękowy.wav";
            this.openFileDialogWAV.Filter = "Plik dźwiękowy|*.wav|Wszystkie pliki|*.*";
            this.openFileDialogWAV.InitialDirectory = "C:\\";
            // 
            // buttonLearnAll
            // 
            this.buttonLearnAll.Location = new System.Drawing.Point(6, 22);
            this.buttonLearnAll.Name = "buttonLearnAll";
            this.buttonLearnAll.Size = new System.Drawing.Size(205, 60);
            this.buttonLearnAll.TabIndex = 47;
            this.buttonLearnAll.Text = "Rozpocznij naukę sieci";
            this.buttonLearnAll.UseVisualStyleBackColor = true;
            this.buttonLearnAll.Click += new System.EventHandler(this.buttonLearnAll_Click);
            this.buttonLearnAll.MouseHover += new System.EventHandler(this.buttonLearnAll_MouseHover);
            // 
            // groupBoxCenter
            // 
            this.groupBoxCenter.Controls.Add(this.panel1);
            this.groupBoxCenter.Controls.Add(this.buttonLearnAll);
            this.groupBoxCenter.Controls.Add(this.progressBar);
            this.groupBoxCenter.Location = new System.Drawing.Point(336, 67);
            this.groupBoxCenter.Name = "groupBoxCenter";
            this.groupBoxCenter.Size = new System.Drawing.Size(217, 199);
            this.groupBoxCenter.TabIndex = 8;
            this.groupBoxCenter.TabStop = false;
            this.groupBoxCenter.Text = "Nauka sieci";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelConfigShow);
            this.panel1.Location = new System.Drawing.Point(5, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 61);
            this.panel1.TabIndex = 48;
            // 
            // labelConfigShow
            // 
            this.labelConfigShow.AutoSize = true;
            this.labelConfigShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelConfigShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelConfigShow.Location = new System.Drawing.Point(10, 18);
            this.labelConfigShow.Name = "labelConfigShow";
            this.labelConfigShow.Size = new System.Drawing.Size(184, 24);
            this.labelConfigShow.TabIndex = 0;
            this.labelConfigShow.Text = "10 sieci z 1 wyjściem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 479);
            this.Controls.Add(this.groupBoxCenter);
            this.Controls.Add(this.groupBoxSouth);
            this.Controls.Add(this.groupBoxNorth);
            this.Controls.Add(this.panelNorth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rozpoznawanie cyfr - Autor: Radosław Sala 33TE";
            this.panelNorth.ResumeLayout(false);
            this.panelNorth.PerformLayout();
            this.groupBoxNorth.ResumeLayout(false);
            this.groupBoxNorth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLayerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
            this.groupBoxSouth.ResumeLayout(false);
            this.groupBoxSouth.PerformLayout();
            this.panelSouth.ResumeLayout(false);
            this.panelSouth.PerformLayout();
            this.groupBoxCenter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNorth;
        private System.Windows.Forms.Label labelNorth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.GroupBox groupBoxNorth;
        private System.Windows.Forms.Label labelLearnRate;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBoxSouth;
        private System.Windows.Forms.Button buttonRecognize;
        private System.Windows.Forms.TextBox textBoxLoadFile;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Panel panelSouth;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelRecognition;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialogCFG;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labelLayerNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownLayerNumber;
        private System.Windows.Forms.TextBox textBoxLearnRate;
        private System.Windows.Forms.NumericUpDown numericUpDownIterations;
        private System.Windows.Forms.OpenFileDialog openFileDialogWAV;
        private System.Windows.Forms.GroupBox groupBoxCenter;
        private System.Windows.Forms.TextBox textBoxMomentum;
        private System.Windows.Forms.Label labelMomentum;
        private System.Windows.Forms.Button buttonLearnAll;
        private System.Windows.Forms.Button buttonConfig0;
        private System.Windows.Forms.TextBox textBoxNeuron;
        private System.Windows.Forms.Label labelNeuron;
        private System.Windows.Forms.Label labelConfig;
        private System.Windows.Forms.Button buttonConfig1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelConfigShow;

    }
}

