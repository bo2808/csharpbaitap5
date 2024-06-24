namespace csharpbaitap5
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radred = new System.Windows.Forms.RadioButton();
            this.radgreen = new System.Windows.Forms.RadioButton();
            this.radblue = new System.Windows.Forms.RadioButton();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.Grupbox2 = new System.Windows.Forms.GroupBox();
            this.chkdambold = new System.Windows.Forms.CheckBox();
            this.chknghienItalic = new System.Windows.Forms.CheckBox();
            this.chkgachchan = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbllaptrinh = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Grupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên";
            // 
            // txtnhapten
            // 
            this.txtnhapten.Location = new System.Drawing.Point(275, 73);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(218, 20);
            this.txtnhapten.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.radblack);
            this.groupBox1.Controls.Add(this.radblue);
            this.groupBox1.Controls.Add(this.radgreen);
            this.groupBox1.Controls.Add(this.radred);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(46, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COLOR";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radred
            // 
            this.radred.AutoSize = true;
            this.radred.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radred.Location = new System.Drawing.Point(17, 36);
            this.radred.Name = "radred";
            this.radred.Size = new System.Drawing.Size(48, 17);
            this.radred.TabIndex = 0;
            this.radred.TabStop = true;
            this.radred.Text = "Red";
            this.radred.UseVisualStyleBackColor = true;
            // 
            // radgreen
            // 
            this.radgreen.AutoSize = true;
            this.radgreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radgreen.Location = new System.Drawing.Point(17, 71);
            this.radgreen.Name = "radgreen";
            this.radgreen.Size = new System.Drawing.Size(67, 20);
            this.radgreen.TabIndex = 1;
            this.radgreen.TabStop = true;
            this.radgreen.Text = "Green";
            this.radgreen.UseVisualStyleBackColor = true;
            // 
            // radblue
            // 
            this.radblue.AutoSize = true;
            this.radblue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblue.ForeColor = System.Drawing.Color.Blue;
            this.radblue.Location = new System.Drawing.Point(17, 107);
            this.radblue.Name = "radblue";
            this.radblue.Size = new System.Drawing.Size(56, 20);
            this.radblue.TabIndex = 2;
            this.radblue.TabStop = true;
            this.radblue.Text = "Blue";
            this.radblue.UseVisualStyleBackColor = true;
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblack.Location = new System.Drawing.Point(17, 142);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(64, 20);
            this.radblack.TabIndex = 3;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            // 
            // Grupbox2
            // 
            this.Grupbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Grupbox2.Controls.Add(this.chkgachchan);
            this.Grupbox2.Controls.Add(this.chknghienItalic);
            this.Grupbox2.Controls.Add(this.chkdambold);
            this.Grupbox2.Location = new System.Drawing.Point(459, 130);
            this.Grupbox2.Name = "Grupbox2";
            this.Grupbox2.Size = new System.Drawing.Size(200, 222);
            this.Grupbox2.TabIndex = 3;
            this.Grupbox2.TabStop = false;
            this.Grupbox2.Text = "FONT";
            // 
            // chkdambold
            // 
            this.chkdambold.AutoSize = true;
            this.chkdambold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdambold.ForeColor = System.Drawing.Color.Navy;
            this.chkdambold.Location = new System.Drawing.Point(33, 57);
            this.chkdambold.Name = "chkdambold";
            this.chkdambold.Size = new System.Drawing.Size(93, 20);
            this.chkdambold.TabIndex = 0;
            this.chkdambold.Text = "Đậm Bold";
            this.chkdambold.UseVisualStyleBackColor = true;
            this.chkdambold.CheckedChanged += new System.EventHandler(this.chkdambold_CheckedChanged);
            // 
            // chknghienItalic
            // 
            this.chknghienItalic.AutoSize = true;
            this.chknghienItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chknghienItalic.ForeColor = System.Drawing.Color.Navy;
            this.chknghienItalic.Location = new System.Drawing.Point(33, 93);
            this.chknghienItalic.Name = "chknghienItalic";
            this.chknghienItalic.Size = new System.Drawing.Size(112, 20);
            this.chknghienItalic.TabIndex = 1;
            this.chknghienItalic.Text = "Nghiên Italic";
            this.chknghienItalic.UseVisualStyleBackColor = true;
            // 
            // chkgachchan
            // 
            this.chkgachchan.AutoSize = true;
            this.chkgachchan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgachchan.ForeColor = System.Drawing.Color.Navy;
            this.chkgachchan.Location = new System.Drawing.Point(33, 131);
            this.chkgachchan.Name = "chkgachchan";
            this.chkgachchan.Size = new System.Drawing.Size(99, 20);
            this.chkgachchan.TabIndex = 2;
            this.chkgachchan.Text = "Gạch chân";
            this.chkgachchan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lập Trình Bởi";
            // 
            // lbllaptrinh
            // 
            this.lbllaptrinh.AutoSize = true;
            this.lbllaptrinh.Location = new System.Drawing.Point(263, 370);
            this.lbllaptrinh.Name = "lbllaptrinh";
            this.lbllaptrinh.Size = new System.Drawing.Size(53, 13);
            this.lbllaptrinh.TabIndex = 5;
            this.lbllaptrinh.Text = "Tèo 2011";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(547, 370);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.lbllaptrinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Grupbox2.ResumeLayout(false);
            this.Grupbox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.RadioButton radblue;
        private System.Windows.Forms.RadioButton radgreen;
        private System.Windows.Forms.RadioButton radred;
        private System.Windows.Forms.GroupBox Grupbox2;
        private System.Windows.Forms.CheckBox chkgachchan;
        private System.Windows.Forms.CheckBox chknghienItalic;
        private System.Windows.Forms.CheckBox chkdambold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbllaptrinh;
        private System.Windows.Forms.Button btnthoat;
    }
}

