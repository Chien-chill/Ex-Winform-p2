namespace baitap_lab2
{
    partial class baitap19
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnBP = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnXoa2 = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số: ";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(302, 27);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(284, 39);
            this.txtInput.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(621, 24);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(167, 44);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lstLopA
            // 
            this.lstLopA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 29;
            this.lstLopA.Location = new System.Drawing.Point(28, 34);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLopA.Size = new System.Drawing.Size(359, 410);
            this.lstLopA.TabIndex = 3;
            this.lstLopA.SelectedIndexChanged += new System.EventHandler(this.lstLopA_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChan);
            this.groupBox1.Controls.Add(this.btnBP);
            this.groupBox1.Controls.Add(this.btnTang);
            this.groupBox1.Controls.Add(this.btnLe);
            this.groupBox1.Controls.Add(this.btnXoa2);
            this.groupBox1.Controls.Add(this.btnXoa1);
            this.groupBox1.Controls.Add(this.btnTong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(524, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 469);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các chức năng";
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(36, 344);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(358, 50);
            this.btnChan.TabIndex = 2;
            this.btnChan.Text = "Chọn số chẵn";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnBP
            // 
            this.btnBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBP.Location = new System.Drawing.Point(36, 282);
            this.btnBP.Name = "btnBP";
            this.btnBP.Size = new System.Drawing.Size(358, 50);
            this.btnBP.TabIndex = 2;
            this.btnBP.Text = "Thay bằng bình phương";
            this.btnBP.UseVisualStyleBackColor = true;
            this.btnBP.Click += new System.EventHandler(this.btnBP_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(36, 220);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(358, 50);
            this.btnTang.TabIndex = 2;
            this.btnTang.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnLe
            // 
            this.btnLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLe.Location = new System.Drawing.Point(36, 406);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(358, 50);
            this.btnLe.TabIndex = 2;
            this.btnLe.Text = "Chọn số lẻ";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btnXoa2
            // 
            this.btnXoa2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa2.Location = new System.Drawing.Point(36, 158);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(358, 50);
            this.btnXoa2.TabIndex = 2;
            this.btnXoa2.Text = "Xóa phần tử đang chọn";
            this.btnXoa2.UseVisualStyleBackColor = true;
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Location = new System.Drawing.Point(36, 96);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(358, 50);
            this.btnXoa1.TabIndex = 2;
            this.btnXoa1.Text = "Xóa phần tử đầu và cuối ";
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(36, 34);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(358, 50);
            this.btnTong.TabIndex = 2;
            this.btnTong.Text = "Tổng của danh sách";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(93, 601);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(825, 50);
            this.btnKetThuc.TabIndex = 2;
            this.btnKetThuc.Text = "KẾT THÚC";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLopA);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 477);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp A";
            // 
            // baitap19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 672);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "baitap19";
            this.Text = "Bài Tập ListBox";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.baitap19_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnXoa2;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnBP;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}