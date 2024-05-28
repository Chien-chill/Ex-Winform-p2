namespace baitap_lab2
{
    partial class baitap15
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnCN1 = new System.Windows.Forms.Button();
            this.btnCN2 = new System.Windows.Forms.Button();
            this.btnCN3 = new System.Windows.Forms.Button();
            this.btnCN4 = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "N=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết Quả";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(269, 31);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(272, 39);
            this.txtN.TabIndex = 2;
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(269, 101);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(272, 39);
            this.txtKQ.TabIndex = 2;
            // 
            // btnCN1
            // 
            this.btnCN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN1.Location = new System.Drawing.Point(103, 200);
            this.btnCN1.Name = "btnCN1";
            this.btnCN1.Size = new System.Drawing.Size(450, 40);
            this.btnCN1.TabIndex = 3;
            this.btnCN1.Text = "Tính 1+2+3+...+N";
            this.btnCN1.UseVisualStyleBackColor = true;
            this.btnCN1.Click += new System.EventHandler(this.btnCN1_Click);
            // 
            // btnCN2
            // 
            this.btnCN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN2.Location = new System.Drawing.Point(103, 266);
            this.btnCN2.Name = "btnCN2";
            this.btnCN2.Size = new System.Drawing.Size(450, 40);
            this.btnCN2.TabIndex = 3;
            this.btnCN2.Text = "Tính (1+2+3+...+N) Bình Phương";
            this.btnCN2.UseVisualStyleBackColor = true;
            this.btnCN2.Click += new System.EventHandler(this.btnCN2_Click);
            // 
            // btnCN3
            // 
            this.btnCN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN3.Location = new System.Drawing.Point(103, 332);
            this.btnCN3.Name = "btnCN3";
            this.btnCN3.Size = new System.Drawing.Size(450, 40);
            this.btnCN3.TabIndex = 3;
            this.btnCN3.Text = "Tính 1^2+2^3+...+N^(N+1)";
            this.btnCN3.UseVisualStyleBackColor = true;
            this.btnCN3.Click += new System.EventHandler(this.btnCN3_Click);
            // 
            // btnCN4
            // 
            this.btnCN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN4.Location = new System.Drawing.Point(103, 408);
            this.btnCN4.Name = "btnCN4";
            this.btnCN4.Size = new System.Drawing.Size(450, 40);
            this.btnCN4.TabIndex = 3;
            this.btnCN4.Text = "Tính (1+2+...+N)/(1^2+2^3+...+N^(N+1))";
            this.btnCN4.UseVisualStyleBackColor = true;
            this.btnCN4.Click += new System.EventHandler(this.btnCN4_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(103, 477);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(450, 40);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // baitap15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 552);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnCN4);
            this.Controls.Add(this.btnCN3);
            this.Controls.Add(this.btnCN2);
            this.Controls.Add(this.btnCN1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "baitap15";
            this.Text = "Tính Giá Trị Theo Hàm";
            this.Load += new System.EventHandler(this.baitap15_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnCN1;
        private System.Windows.Forms.Button btnCN2;
        private System.Windows.Forms.Button btnCN3;
        private System.Windows.Forms.Button btnCN4;
        private System.Windows.Forms.Button btnKetThuc;
    }
}