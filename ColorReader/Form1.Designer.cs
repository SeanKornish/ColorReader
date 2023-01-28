namespace ColorReader
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
            this.dlgFindColor = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgSetColor = new System.Windows.Forms.ColorDialog();
            this.pnlFindColor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSetColor = new System.Windows.Forms.Panel();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.btnPicker = new System.Windows.Forms.Button();
            this.picRender = new System.Windows.Forms.PictureBox();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picRender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgFindColor
            // 
            this.dlgFindColor.AnyColor = true;
            this.dlgFindColor.FullOpen = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color to Find:";
            // 
            // dlgSetColor
            // 
            this.dlgSetColor.AnyColor = true;
            this.dlgSetColor.Color = System.Drawing.Color.Red;
            this.dlgSetColor.FullOpen = true;
            // 
            // pnlFindColor
            // 
            this.pnlFindColor.BackColor = System.Drawing.Color.Black;
            this.pnlFindColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFindColor.Location = new System.Drawing.Point(84, 331);
            this.pnlFindColor.Name = "pnlFindColor";
            this.pnlFindColor.Size = new System.Drawing.Size(29, 24);
            this.pnlFindColor.TabIndex = 2;
            this.pnlFindColor.DoubleClick += new System.EventHandler(this.pnlFindColor_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color to Set:";
            // 
            // pnlSetColor
            // 
            this.pnlSetColor.BackColor = System.Drawing.Color.Red;
            this.pnlSetColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSetColor.Location = new System.Drawing.Point(228, 331);
            this.pnlSetColor.Name = "pnlSetColor";
            this.pnlSetColor.Size = new System.Drawing.Size(29, 24);
            this.pnlSetColor.TabIndex = 2;
            this.pnlSetColor.DoubleClick += new System.EventHandler(this.pnlSetColor_DoubleClick);
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(398, 332);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(75, 23);
            this.btnSetColor.TabIndex = 3;
            this.btnSetColor.Text = "Set Color";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // btnPicker
            // 
            this.btnPicker.Image = global::ColorReader.Properties.Resources.ColorHS;
            this.btnPicker.Location = new System.Drawing.Point(119, 331);
            this.btnPicker.Name = "btnPicker";
            this.btnPicker.Size = new System.Drawing.Size(32, 23);
            this.btnPicker.TabIndex = 4;
            this.btnPicker.UseVisualStyleBackColor = true;
            this.btnPicker.Click += new System.EventHandler(this.btnPicker_Click);
            // 
            // picRender
            // 
            this.picRender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRender.Location = new System.Drawing.Point(479, 12);
            this.picRender.Name = "picRender";
            this.picRender.Size = new System.Drawing.Size(461, 300);
            this.picRender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRender.TabIndex = 0;
            this.picRender.TabStop = false;
            // 
            // picOriginal
            // 
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginal.Image = global::ColorReader.Properties.Resources.frog;
            this.picOriginal.Location = new System.Drawing.Point(12, 12);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(461, 300);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            this.picOriginal.DoubleClick += new System.EventHandler(this.picOriginal_DoubleClick);
            this.picOriginal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOriginal_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fuzz:";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(301, 335);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(67, 20);
            this.num.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 367);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPicker);
            this.Controls.Add(this.btnSetColor);
            this.Controls.Add(this.pnlSetColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlFindColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picRender);
            this.Controls.Add(this.picOriginal);
            this.Name = "Form1";
            this.Text = "Color Reset";
            ((System.ComponentModel.ISupportInitialize)(this.picRender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picRender;
        private System.Windows.Forms.ColorDialog dlgFindColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog dlgSetColor;
        private System.Windows.Forms.Panel pnlFindColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSetColor;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Button btnPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num;
    }
}

