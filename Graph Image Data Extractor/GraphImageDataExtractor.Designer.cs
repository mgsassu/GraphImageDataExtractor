namespace Graph_Image_Data_Extractor
{
    partial class formGraphImageDataExtractor
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
            this.pbGraphImage = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.GraphImagePanel = new System.Windows.Forms.Panel();
            this.dgvScrollData = new System.Windows.Forms.DataGridView();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbIntegerValues = new System.Windows.Forms.CheckBox();
            this.tbOutputFileName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnExtractData = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbYdatamax = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbYdatamin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbXdatamax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbXdatamin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbYpixelmax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbYpixelmin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbXpixelmax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbXpixelmin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDataB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDataG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDataR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZoomPositive = new System.Windows.Forms.Button();
            this.btnZoomNegative = new System.Windows.Forms.Button();
            this.btnOpenDataFolder = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphImage)).BeginInit();
            this.GraphImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScrollData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGraphImage
            // 
            this.pbGraphImage.BackColor = System.Drawing.Color.White;
            this.pbGraphImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbGraphImage.Location = new System.Drawing.Point(4, 5);
            this.pbGraphImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbGraphImage.Name = "pbGraphImage";
            this.pbGraphImage.Size = new System.Drawing.Size(1528, 1046);
            this.pbGraphImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGraphImage.TabIndex = 0;
            this.pbGraphImage.TabStop = false;
            this.pbGraphImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGraphImage_MouseMove);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.Lime;
            this.btnLoadImage.Location = new System.Drawing.Point(18, 18);
            this.btnLoadImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(134, 35);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // GraphImagePanel
            // 
            this.GraphImagePanel.AutoScroll = true;
            this.GraphImagePanel.BackColor = System.Drawing.Color.Black;
            this.GraphImagePanel.Controls.Add(this.pbGraphImage);
            this.GraphImagePanel.Location = new System.Drawing.Point(18, 229);
            this.GraphImagePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GraphImagePanel.Name = "GraphImagePanel";
            this.GraphImagePanel.Size = new System.Drawing.Size(1538, 1055);
            this.GraphImagePanel.TabIndex = 2;
            // 
            // dgvScrollData
            // 
            this.dgvScrollData.AllowUserToAddRows = false;
            this.dgvScrollData.AllowUserToDeleteRows = false;
            this.dgvScrollData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScrollData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataType,
            this.ImageData});
            this.dgvScrollData.Location = new System.Drawing.Point(160, 14);
            this.dgvScrollData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvScrollData.Name = "dgvScrollData";
            this.dgvScrollData.Size = new System.Drawing.Size(368, 206);
            this.dgvScrollData.TabIndex = 8;
            // 
            // DataType
            // 
            this.DataType.HeaderText = "Data Type";
            this.DataType.Name = "DataType";
            // 
            // ImageData
            // 
            this.ImageData.HeaderText = "Data";
            this.ImageData.Name = "ImageData";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.cbIntegerValues);
            this.panel1.Controls.Add(this.tbOutputFileName);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.btnExtractData);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.tbYdatamax);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tbYdatamin);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tbXdatamax);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbXdatamin);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbYpixelmax);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbYpixelmin);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbXpixelmax);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbXpixelmin);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbDataB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbDataG);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbDataR);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(536, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 206);
            this.panel1.TabIndex = 9;
            // 
            // cbIntegerValues
            // 
            this.cbIntegerValues.AutoSize = true;
            this.cbIntegerValues.Checked = true;
            this.cbIntegerValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIntegerValues.Location = new System.Drawing.Point(693, 145);
            this.cbIntegerValues.Name = "cbIntegerValues";
            this.cbIntegerValues.Size = new System.Drawing.Size(192, 24);
            this.cbIntegerValues.TabIndex = 36;
            this.cbIntegerValues.Text = "Output Integer Values";
            this.cbIntegerValues.UseVisualStyleBackColor = true;
            // 
            // tbOutputFileName
            // 
            this.tbOutputFileName.Location = new System.Drawing.Point(693, 111);
            this.tbOutputFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOutputFileName.Name = "tbOutputFileName";
            this.tbOutputFileName.Size = new System.Drawing.Size(308, 26);
            this.tbOutputFileName.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(689, 86);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 20);
            this.label19.TabIndex = 34;
            this.label19.Text = "Output File Name:";
            // 
            // btnExtractData
            // 
            this.btnExtractData.Location = new System.Drawing.Point(693, 46);
            this.btnExtractData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExtractData.Name = "btnExtractData";
            this.btnExtractData.Size = new System.Drawing.Size(310, 35);
            this.btnExtractData.TabIndex = 33;
            this.btnExtractData.Text = "Extract Data";
            this.btnExtractData.UseVisualStyleBackColor = true;
            this.btnExtractData.Click += new System.EventHandler(this.btnExtractData_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(441, 126);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Data Range";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(441, 46);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 20);
            this.label18.TabIndex = 31;
            this.label18.Text = "Pixel Range";
            // 
            // tbYdatamax
            // 
            this.tbYdatamax.Location = new System.Drawing.Point(599, 162);
            this.tbYdatamax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYdatamax.Name = "tbYdatamax";
            this.tbYdatamax.Size = new System.Drawing.Size(72, 26);
            this.tbYdatamax.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(535, 166);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Y Max:";
            // 
            // tbYdatamin
            // 
            this.tbYdatamin.Location = new System.Drawing.Point(599, 122);
            this.tbYdatamin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYdatamin.Name = "tbYdatamin";
            this.tbYdatamin.Size = new System.Drawing.Size(72, 26);
            this.tbYdatamin.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(541, 126);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Y min:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(189, 126);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Data Range";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(189, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Pixel Range";
            // 
            // tbXdatamax
            // 
            this.tbXdatamax.Location = new System.Drawing.Point(345, 162);
            this.tbXdatamax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbXdatamax.Name = "tbXdatamax";
            this.tbXdatamax.Size = new System.Drawing.Size(73, 26);
            this.tbXdatamax.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "X Max:";
            // 
            // tbXdatamin
            // 
            this.tbXdatamin.Location = new System.Drawing.Point(345, 122);
            this.tbXdatamin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbXdatamin.Name = "tbXdatamin";
            this.tbXdatamin.Size = new System.Drawing.Size(73, 26);
            this.tbXdatamin.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "X min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(441, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Y Axis Range";
            // 
            // tbYpixelmax
            // 
            this.tbYpixelmax.Location = new System.Drawing.Point(599, 82);
            this.tbYpixelmax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYpixelmax.Name = "tbYpixelmax";
            this.tbYpixelmax.Size = new System.Drawing.Size(72, 26);
            this.tbYpixelmax.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(535, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Y Max:";
            // 
            // tbYpixelmin
            // 
            this.tbYpixelmin.Location = new System.Drawing.Point(599, 42);
            this.tbYpixelmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYpixelmin.Name = "tbYpixelmin";
            this.tbYpixelmin.Size = new System.Drawing.Size(72, 26);
            this.tbYpixelmin.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(541, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Y min:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "X Axis Range";
            // 
            // tbXpixelmax
            // 
            this.tbXpixelmax.Location = new System.Drawing.Point(345, 82);
            this.tbXpixelmax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbXpixelmax.Name = "tbXpixelmax";
            this.tbXpixelmax.Size = new System.Drawing.Size(73, 26);
            this.tbXpixelmax.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "X Max:";
            // 
            // tbXpixelmin
            // 
            this.tbXpixelmin.Location = new System.Drawing.Point(345, 42);
            this.tbXpixelmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbXpixelmin.Name = "tbXpixelmin";
            this.tbXpixelmin.Size = new System.Drawing.Size(73, 26);
            this.tbXpixelmin.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "X min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data RGB Values";
            // 
            // tbDataB
            // 
            this.tbDataB.Location = new System.Drawing.Point(50, 130);
            this.tbDataB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDataB.Name = "tbDataB";
            this.tbDataB.Size = new System.Drawing.Size(112, 26);
            this.tbDataB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "B:";
            // 
            // tbDataG
            // 
            this.tbDataG.Location = new System.Drawing.Point(50, 90);
            this.tbDataG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDataG.Name = "tbDataG";
            this.tbDataG.Size = new System.Drawing.Size(112, 26);
            this.tbDataG.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "G:";
            // 
            // tbDataR
            // 
            this.tbDataR.Location = new System.Drawing.Point(50, 50);
            this.tbDataR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDataR.Name = "tbDataR";
            this.tbDataR.Size = new System.Drawing.Size(112, 26);
            this.tbDataR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "R:";
            // 
            // btnZoomPositive
            // 
            this.btnZoomPositive.BackColor = System.Drawing.Color.Cyan;
            this.btnZoomPositive.Location = new System.Drawing.Point(18, 140);
            this.btnZoomPositive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZoomPositive.Name = "btnZoomPositive";
            this.btnZoomPositive.Size = new System.Drawing.Size(134, 35);
            this.btnZoomPositive.TabIndex = 11;
            this.btnZoomPositive.Text = "Zoom +2x";
            this.btnZoomPositive.UseVisualStyleBackColor = false;
            this.btnZoomPositive.Click += new System.EventHandler(this.btnZoomPositive_Click);
            // 
            // btnZoomNegative
            // 
            this.btnZoomNegative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnZoomNegative.Location = new System.Drawing.Point(18, 185);
            this.btnZoomNegative.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZoomNegative.Name = "btnZoomNegative";
            this.btnZoomNegative.Size = new System.Drawing.Size(134, 35);
            this.btnZoomNegative.TabIndex = 12;
            this.btnZoomNegative.Text = "Zoom -2x";
            this.btnZoomNegative.UseVisualStyleBackColor = false;
            this.btnZoomNegative.Click += new System.EventHandler(this.btnZoomNegative_Click);
            // 
            // btnOpenDataFolder
            // 
            this.btnOpenDataFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOpenDataFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDataFolder.Location = new System.Drawing.Point(18, 60);
            this.btnOpenDataFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenDataFolder.Name = "btnOpenDataFolder";
            this.btnOpenDataFolder.Size = new System.Drawing.Size(134, 35);
            this.btnOpenDataFolder.TabIndex = 13;
            this.btnOpenDataFolder.Text = "Data Folder";
            this.btnOpenDataFolder.UseVisualStyleBackColor = false;
            this.btnOpenDataFolder.Click += new System.EventHandler(this.btnOpenDataFolder_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClearAll.Location = new System.Drawing.Point(50, 164);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(112, 39);
            this.btnClearAll.TabIndex = 37;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // formGraphImageDataExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1303);
            this.Controls.Add(this.btnOpenDataFolder);
            this.Controls.Add(this.btnZoomNegative);
            this.Controls.Add(this.btnZoomPositive);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvScrollData);
            this.Controls.Add(this.GraphImagePanel);
            this.Controls.Add(this.btnLoadImage);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formGraphImageDataExtractor";
            this.Text = "Graph Image Data Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphImage)).EndInit();
            this.GraphImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScrollData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGraphImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Panel GraphImagePanel;
        private System.Windows.Forms.DataGridView dgvScrollData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDataB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDataG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDataR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbYpixelmax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbYpixelmin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbXpixelmax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbXpixelmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbYdatamax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbYdatamin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbXdatamax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbXdatamin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbOutputFileName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnExtractData;
        private System.Windows.Forms.Button btnZoomPositive;
        private System.Windows.Forms.Button btnZoomNegative;
        private System.Windows.Forms.Button btnOpenDataFolder;
        private System.Windows.Forms.CheckBox cbIntegerValues;
        private System.Windows.Forms.Button btnClearAll;
    }
}

