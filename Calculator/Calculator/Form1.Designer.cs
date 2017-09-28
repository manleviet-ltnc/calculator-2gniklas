namespace Calculator
{
    partial class frmMain
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnbang = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnThapphan = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnDoidau = new System.Windows.Forms.Button();
            this.btnNho = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnPhantram = new System.Windows.Forms.Button();
            this.btnCang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 28);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(195, 28);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0.";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(53, 223);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(35, 35);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 182);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 35);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(56, 182);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 35);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(94, 182);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 35);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(56, 141);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 35);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 141);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 35);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Nhapso);
            // 
            // btnbang
            // 
            this.btnbang.Location = new System.Drawing.Point(172, 183);
            this.btnbang.Name = "btnbang";
            this.btnbang.Size = new System.Drawing.Size(35, 76);
            this.btnbang.TabIndex = 7;
            this.btnbang.Text = "=";
            this.btnbang.UseVisualStyleBackColor = true;
            this.btnbang.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 100);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 35);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Nhapso);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(135, 100);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(35, 35);
            this.btnCong.TabIndex = 9;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(135, 141);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(35, 35);
            this.btnTru.TabIndex = 10;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(135, 223);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(35, 35);
            this.btnChia.TabIndex = 11;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(94, 100);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(35, 35);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(53, 100);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(35, 35);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Nhapso);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(94, 141);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(38, 35);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Nhapso);
            // 
            // btnThapphan
            // 
            this.btnThapphan.Location = new System.Drawing.Point(94, 223);
            this.btnThapphan.Name = "btnThapphan";
            this.btnThapphan.Size = new System.Drawing.Size(35, 35);
            this.btnThapphan.TabIndex = 15;
            this.btnThapphan.Text = ".";
            this.btnThapphan.UseVisualStyleBackColor = true;
            this.btnThapphan.Click += new System.EventHandler(this.Nhapso);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(135, 182);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(35, 35);
            this.btnNhan.TabIndex = 16;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnDoidau
            // 
            this.btnDoidau.Location = new System.Drawing.Point(12, 223);
            this.btnDoidau.Name = "btnDoidau";
            this.btnDoidau.Size = new System.Drawing.Size(35, 35);
            this.btnDoidau.TabIndex = 17;
            this.btnDoidau.Text = "-/+";
            this.btnDoidau.UseVisualStyleBackColor = true;
            // 
            // btnNho
            // 
            this.btnNho.Location = new System.Drawing.Point(12, 59);
            this.btnNho.Name = "btnNho";
            this.btnNho.Size = new System.Drawing.Size(76, 35);
            this.btnNho.TabIndex = 18;
            this.btnNho.Text = "C";
            this.btnNho.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(94, 59);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 35);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Backspace";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnPhantram
            // 
            this.btnPhantram.Location = new System.Drawing.Point(172, 100);
            this.btnPhantram.Name = "btnPhantram";
            this.btnPhantram.Size = new System.Drawing.Size(35, 35);
            this.btnPhantram.TabIndex = 20;
            this.btnPhantram.Text = "%";
            this.btnPhantram.UseVisualStyleBackColor = true;
            // 
            // btnCang
            // 
            this.btnCang.Location = new System.Drawing.Point(172, 141);
            this.btnCang.Name = "btnCang";
            this.btnCang.Size = new System.Drawing.Size(35, 35);
            this.btnCang.TabIndex = 21;
            this.btnCang.Text = "√";
            this.btnCang.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 272);
            this.Controls.Add(this.btnCang);
            this.Controls.Add(this.btnPhantram);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnNho);
            this.Controls.Add(this.btnDoidau);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnThapphan);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnbang);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.lblDisplay);
            this.Name = "frmMain";
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.frmMain_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnbang;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnThapphan;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnDoidau;
        private System.Windows.Forms.Button btnNho;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnPhantram;
        private System.Windows.Forms.Button btnCang;
    }
}

