namespace ImageBot
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
            this.components = new System.ComponentModel.Container();
            this.previewPictureBox1 = new System.Windows.Forms.PictureBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.locatePictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgLocateOfd = new System.Windows.Forms.OpenFileDialog();
            this.lastActiveWindowTimer = new System.Windows.Forms.Timer(this.components);
            this.wComboBox1 = new System.Windows.Forms.ComboBox();
            this.loadImageBTN = new System.Windows.Forms.Button();
            this.locImageOfd = new System.Windows.Forms.OpenFileDialog();
            this.processLabel = new System.Windows.Forms.Label();
            this.locateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPictureBox1
            // 
            this.previewPictureBox1.BackColor = System.Drawing.Color.Silver;
            this.previewPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previewPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewPictureBox1.Location = new System.Drawing.Point(6, 6);
            this.previewPictureBox1.Name = "previewPictureBox1";
            this.previewPictureBox1.Size = new System.Drawing.Size(418, 254);
            this.previewPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewPictureBox1.TabIndex = 0;
            this.previewPictureBox1.TabStop = false;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(3, 263);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(37, 13);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "X: 0/0";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(362, 263);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(37, 13);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Y: 0/0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image To Locate";
            // 
            // locatePictureBox1
            // 
            this.locatePictureBox1.BackColor = System.Drawing.Color.Silver;
            this.locatePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.locatePictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locatePictureBox1.Location = new System.Drawing.Point(179, 279);
            this.locatePictureBox1.Name = "locatePictureBox1";
            this.locatePictureBox1.Size = new System.Drawing.Size(57, 41);
            this.locatePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.locatePictureBox1.TabIndex = 4;
            this.locatePictureBox1.TabStop = false;
            this.locatePictureBox1.DoubleClick += new System.EventHandler(this.locatePictureBox1_DoubleClick);
            // 
            // imgLocateOfd
            // 
            this.imgLocateOfd.RestoreDirectory = true;
            this.imgLocateOfd.Title = "Browse Image Files";
            // 
            // lastActiveWindowTimer
            // 
            this.lastActiveWindowTimer.Enabled = true;
            this.lastActiveWindowTimer.Interval = 50;
            this.lastActiveWindowTimer.Tick += new System.EventHandler(this.lastActiveWindowTimer_Tick);
            // 
            // wComboBox1
            // 
            this.wComboBox1.CausesValidation = false;
            this.wComboBox1.FormattingEnabled = true;
            this.wComboBox1.Items.AddRange(new object[] {
            "Active Window",
            "Local Image",
            "Desktop",
            "Window"});
            this.wComboBox1.Location = new System.Drawing.Point(6, 290);
            this.wComboBox1.Name = "wComboBox1";
            this.wComboBox1.Size = new System.Drawing.Size(97, 21);
            this.wComboBox1.TabIndex = 5;
            // 
            // loadImageBTN
            // 
            this.loadImageBTN.Location = new System.Drawing.Point(6, 344);
            this.loadImageBTN.Name = "loadImageBTN";
            this.loadImageBTN.Size = new System.Drawing.Size(77, 33);
            this.loadImageBTN.TabIndex = 6;
            this.loadImageBTN.Text = "Load Image";
            this.loadImageBTN.UseVisualStyleBackColor = true;
            this.loadImageBTN.Click += new System.EventHandler(this.loadImageBTN_Click);
            // 
            // locImageOfd
            // 
            this.locImageOfd.FileName = "openFileDialog1";
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processLabel.Location = new System.Drawing.Point(3, 314);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(0, 13);
            this.processLabel.TabIndex = 7;
            // 
            // locateButton
            // 
            this.locateButton.Location = new System.Drawing.Point(309, 317);
            this.locateButton.Name = "locateButton";
            this.locateButton.Size = new System.Drawing.Size(110, 50);
            this.locateButton.TabIndex = 8;
            this.locateButton.Text = "Locate";
            this.locateButton.UseVisualStyleBackColor = true;
            this.locateButton.Click += new System.EventHandler(this.locateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 379);
            this.Controls.Add(this.locateButton);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.loadImageBTN);
            this.Controls.Add(this.wComboBox1);
            this.Controls.Add(this.locatePictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.previewPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Image Bot";
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPictureBox1;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox locatePictureBox1;
        private System.Windows.Forms.OpenFileDialog imgLocateOfd;
        private System.Windows.Forms.Timer lastActiveWindowTimer;
        private System.Windows.Forms.ComboBox wComboBox1;
        private System.Windows.Forms.Button loadImageBTN;
        private System.Windows.Forms.OpenFileDialog locImageOfd;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Button locateButton;
    }
}

