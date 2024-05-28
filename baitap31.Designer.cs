namespace baitap_lab2
{
    partial class baitap31
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
            this.lblSoMayMan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMay = new System.Windows.Forms.TextBox();
            this.txtNguoiChoi = new System.Windows.Forms.TextBox();
            this.btnQuaySo = new System.Windows.Forms.Button();
            this.btnGameMoi = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoMayMan
            // 
            this.lblSoMayMan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSoMayMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoMayMan.Location = new System.Drawing.Point(209, 20);
            this.lblSoMayMan.Name = "lblSoMayMan";
            this.lblSoMayMan.Size = new System.Drawing.Size(167, 121);
            this.lblSoMayMan.TabIndex = 0;
            this.lblSoMayMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiền Máy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tiền Người Chơi:";
            // 
            // txtMay
            // 
            this.txtMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMay.Location = new System.Drawing.Point(289, 182);
            this.txtMay.Name = "txtMay";
            this.txtMay.ReadOnly = true;
            this.txtMay.Size = new System.Drawing.Size(202, 48);
            this.txtMay.TabIndex = 2;
            this.txtMay.Text = "10";
            this.txtMay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNguoiChoi
            // 
            this.txtNguoiChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiChoi.Location = new System.Drawing.Point(289, 262);
            this.txtNguoiChoi.Name = "txtNguoiChoi";
            this.txtNguoiChoi.Size = new System.Drawing.Size(202, 48);
            this.txtNguoiChoi.TabIndex = 2;
            this.txtNguoiChoi.Text = "0";
            this.txtNguoiChoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQuaySo
            // 
            this.btnQuaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaySo.Location = new System.Drawing.Point(111, 357);
            this.btnQuaySo.Name = "btnQuaySo";
            this.btnQuaySo.Size = new System.Drawing.Size(176, 57);
            this.btnQuaySo.TabIndex = 3;
            this.btnQuaySo.Text = "Quay Số";
            this.btnQuaySo.UseVisualStyleBackColor = true;
            this.btnQuaySo.Click += new System.EventHandler(this.btnQuaySo_Click);
            // 
            // btnGameMoi
            // 
            this.btnGameMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameMoi.Location = new System.Drawing.Point(340, 357);
            this.btnGameMoi.Name = "btnGameMoi";
            this.btnGameMoi.Size = new System.Drawing.Size(176, 57);
            this.btnGameMoi.TabIndex = 3;
            this.btnGameMoi.Text = "Game Mới";
            this.btnGameMoi.UseVisualStyleBackColor = true;
            this.btnGameMoi.Click += new System.EventHandler(this.btnGameMoi_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(227, 446);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(176, 57);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // baitap31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 515);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnGameMoi);
            this.Controls.Add(this.btnQuaySo);
            this.Controls.Add(this.txtNguoiChoi);
            this.Controls.Add(this.txtMay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSoMayMan);
            this.Name = "baitap31";
            this.Text = "baitap31";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoMayMan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMay;
        private System.Windows.Forms.TextBox txtNguoiChoi;
        private System.Windows.Forms.Button btnQuaySo;
        private System.Windows.Forms.Button btnGameMoi;
        private System.Windows.Forms.Button btnKetThuc;
    }
}