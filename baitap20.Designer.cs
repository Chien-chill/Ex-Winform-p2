namespace baitap_lab2
{
    partial class baitap20
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbNhom = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstNhom1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstNhom2 = new System.Windows.Forms.ListBox();
            this.btnQua2 = new System.Windows.Forms.Button();
            this.btnQua1 = new System.Windows.Forms.Button();
            this.btnQuaAll2 = new System.Windows.Forms.Button();
            this.btnQuaAll1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblSumNhom1 = new System.Windows.Forms.Label();
            this.lblSumNhom2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn Nhóm";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(224, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 39);
            this.txtName.TabIndex = 2;
            // 
            // cbNhom
            // 
            this.cbNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Items.AddRange(new object[] {
            "Nhóm 1",
            "Nhóm 2"});
            this.cbNhom.Location = new System.Drawing.Point(224, 93);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(274, 40);
            this.cbNhom.TabIndex = 3;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(526, 27);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(272, 40);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(526, 93);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(272, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát Chương Trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstNhom1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 329);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm 1";
            // 
            // lstNhom1
            // 
            this.lstNhom1.FormattingEnabled = true;
            this.lstNhom1.ItemHeight = 29;
            this.lstNhom1.Location = new System.Drawing.Point(20, 28);
            this.lstNhom1.Name = "lstNhom1";
            this.lstNhom1.Size = new System.Drawing.Size(231, 294);
            this.lstNhom1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstNhom2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(501, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 329);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhóm 2";
            // 
            // lstNhom2
            // 
            this.lstNhom2.FormattingEnabled = true;
            this.lstNhom2.ItemHeight = 29;
            this.lstNhom2.Location = new System.Drawing.Point(25, 28);
            this.lstNhom2.Name = "lstNhom2";
            this.lstNhom2.Size = new System.Drawing.Size(231, 294);
            this.lstNhom2.TabIndex = 0;
            // 
            // btnQua2
            // 
            this.btnQua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQua2.Location = new System.Drawing.Point(320, 222);
            this.btnQua2.Name = "btnQua2";
            this.btnQua2.Size = new System.Drawing.Size(56, 51);
            this.btnQua2.TabIndex = 7;
            this.btnQua2.Text = ">";
            this.btnQua2.UseVisualStyleBackColor = true;
            this.btnQua2.Click += new System.EventHandler(this.btnQua2_Click);
            // 
            // btnQua1
            // 
            this.btnQua1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQua1.Location = new System.Drawing.Point(428, 222);
            this.btnQua1.Name = "btnQua1";
            this.btnQua1.Size = new System.Drawing.Size(56, 51);
            this.btnQua1.TabIndex = 7;
            this.btnQua1.Text = "<";
            this.btnQua1.UseVisualStyleBackColor = true;
            this.btnQua1.Click += new System.EventHandler(this.btnQua1_Click);
            // 
            // btnQuaAll2
            // 
            this.btnQuaAll2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaAll2.Location = new System.Drawing.Point(307, 302);
            this.btnQuaAll2.Name = "btnQuaAll2";
            this.btnQuaAll2.Size = new System.Drawing.Size(82, 51);
            this.btnQuaAll2.TabIndex = 7;
            this.btnQuaAll2.Text = ">>";
            this.btnQuaAll2.UseVisualStyleBackColor = true;
            this.btnQuaAll2.Click += new System.EventHandler(this.btnQuaAll2_Click);
            // 
            // btnQuaAll1
            // 
            this.btnQuaAll1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaAll1.Location = new System.Drawing.Point(418, 302);
            this.btnQuaAll1.Name = "btnQuaAll1";
            this.btnQuaAll1.Size = new System.Drawing.Size(77, 51);
            this.btnQuaAll1.TabIndex = 7;
            this.btnQuaAll1.Text = "<<";
            this.btnQuaAll1.UseVisualStyleBackColor = true;
            this.btnQuaAll1.Click += new System.EventHandler(this.btnQuaAll1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(358, 397);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 66);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblSumNhom1
            // 
            this.lblSumNhom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSumNhom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumNhom1.Location = new System.Drawing.Point(42, 528);
            this.lblSumNhom1.Name = "lblSumNhom1";
            this.lblSumNhom1.Size = new System.Drawing.Size(259, 38);
            this.lblSumNhom1.TabIndex = 9;
            // 
            // lblSumNhom2
            // 
            this.lblSumNhom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSumNhom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumNhom2.Location = new System.Drawing.Point(506, 528);
            this.lblSumNhom2.Name = "lblSumNhom2";
            this.lblSumNhom2.Size = new System.Drawing.Size(260, 38);
            this.lblSumNhom2.TabIndex = 9;
            // 
            // baitap20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 631);
            this.Controls.Add(this.lblSumNhom2);
            this.Controls.Add(this.lblSumNhom1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnQuaAll1);
            this.Controls.Add(this.btnQuaAll2);
            this.Controls.Add(this.btnQua1);
            this.Controls.Add(this.btnQua2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.cbNhom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "baitap20";
            this.Text = "Quản Lý Ca Học";
            this.Load += new System.EventHandler(this.baitap20_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbNhom;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstNhom1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstNhom2;
        private System.Windows.Forms.Button btnQua2;
        private System.Windows.Forms.Button btnQua1;
        private System.Windows.Forms.Button btnQuaAll2;
        private System.Windows.Forms.Button btnQuaAll1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblSumNhom1;
        private System.Windows.Forms.Label lblSumNhom2;
    }
}