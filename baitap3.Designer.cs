namespace baitap_lab2
{
    partial class baitap3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baitap3));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSunny = new System.Windows.Forms.RadioButton();
            this.radSnowy = new System.Windows.Forms.RadioButton();
            this.radRainy = new System.Windows.Forms.RadioButton();
            this.radCloudy = new System.Windows.Forms.RadioButton();
            this.picCloudy = new System.Windows.Forms.PictureBox();
            this.picRain = new System.Windows.Forms.PictureBox();
            this.picSnowy = new System.Windows.Forms.PictureBox();
            this.picSunny = new System.Windows.Forms.PictureBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name here ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(351, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(376, 44);
            this.txtName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSunny);
            this.groupBox1.Controls.Add(this.radSnowy);
            this.groupBox1.Controls.Add(this.radRainy);
            this.groupBox1.Controls.Add(this.radCloudy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(28, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // radSunny
            // 
            this.radSunny.AutoSize = true;
            this.radSunny.Location = new System.Drawing.Point(13, 199);
            this.radSunny.Name = "radSunny";
            this.radSunny.Size = new System.Drawing.Size(104, 33);
            this.radSunny.TabIndex = 0;
            this.radSunny.TabStop = true;
            this.radSunny.Text = "Sunny";
            this.radSunny.UseVisualStyleBackColor = true;
            this.radSunny.CheckedChanged += new System.EventHandler(this.radSunny_CheckedChanged);
            // 
            // radSnowy
            // 
            this.radSnowy.AutoSize = true;
            this.radSnowy.ForeColor = System.Drawing.Color.Blue;
            this.radSnowy.Location = new System.Drawing.Point(13, 144);
            this.radSnowy.Name = "radSnowy";
            this.radSnowy.Size = new System.Drawing.Size(110, 33);
            this.radSnowy.TabIndex = 0;
            this.radSnowy.TabStop = true;
            this.radSnowy.Text = "Snowy";
            this.radSnowy.UseVisualStyleBackColor = true;
            this.radSnowy.CheckedChanged += new System.EventHandler(this.radSnowy_CheckedChanged);
            // 
            // radRainy
            // 
            this.radRainy.AutoSize = true;
            this.radRainy.ForeColor = System.Drawing.Color.Fuchsia;
            this.radRainy.Location = new System.Drawing.Point(13, 89);
            this.radRainy.Name = "radRainy";
            this.radRainy.Size = new System.Drawing.Size(98, 33);
            this.radRainy.TabIndex = 0;
            this.radRainy.TabStop = true;
            this.radRainy.Text = "Rainy";
            this.radRainy.UseVisualStyleBackColor = true;
            this.radRainy.CheckedChanged += new System.EventHandler(this.radRainy_CheckedChanged);
            // 
            // radCloudy
            // 
            this.radCloudy.AutoSize = true;
            this.radCloudy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radCloudy.Location = new System.Drawing.Point(13, 34);
            this.radCloudy.Name = "radCloudy";
            this.radCloudy.Size = new System.Drawing.Size(113, 33);
            this.radCloudy.TabIndex = 0;
            this.radCloudy.TabStop = true;
            this.radCloudy.Text = "Cloudy";
            this.radCloudy.UseVisualStyleBackColor = true;
            this.radCloudy.CheckedChanged += new System.EventHandler(this.radCloudy_CheckedChanged);
            // 
            // picCloudy
            // 
            this.picCloudy.Image = ((System.Drawing.Image)(resources.GetObject("picCloudy.Image")));
            this.picCloudy.Location = new System.Drawing.Point(351, 139);
            this.picCloudy.Name = "picCloudy";
            this.picCloudy.Size = new System.Drawing.Size(150, 105);
            this.picCloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCloudy.TabIndex = 3;
            this.picCloudy.TabStop = false;
            this.picCloudy.Visible = false;
            // 
            // picRain
            // 
            this.picRain.Image = ((System.Drawing.Image)(resources.GetObject("picRain.Image")));
            this.picRain.Location = new System.Drawing.Point(618, 139);
            this.picRain.Name = "picRain";
            this.picRain.Size = new System.Drawing.Size(150, 105);
            this.picRain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRain.TabIndex = 3;
            this.picRain.TabStop = false;
            this.picRain.Visible = false;
            // 
            // picSnowy
            // 
            this.picSnowy.Image = ((System.Drawing.Image)(resources.GetObject("picSnowy.Image")));
            this.picSnowy.Location = new System.Drawing.Point(351, 301);
            this.picSnowy.Name = "picSnowy";
            this.picSnowy.Size = new System.Drawing.Size(150, 105);
            this.picSnowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSnowy.TabIndex = 3;
            this.picSnowy.TabStop = false;
            this.picSnowy.Visible = false;
            // 
            // picSunny
            // 
            this.picSunny.Image = ((System.Drawing.Image)(resources.GetObject("picSunny.Image")));
            this.picSunny.Location = new System.Drawing.Point(618, 301);
            this.picSunny.Name = "picSunny";
            this.picSunny.Size = new System.Drawing.Size(150, 105);
            this.picSunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSunny.TabIndex = 3;
            this.picSunny.TabStop = false;
            this.picSunny.Visible = false;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblDisplay.Location = new System.Drawing.Point(29, 476);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(567, 160);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(631, 476);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 64);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(630, 572);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 64);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // baitap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.picSunny);
            this.Controls.Add(this.picSnowy);
            this.Controls.Add(this.picRain);
            this.Controls.Add(this.picCloudy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "baitap2";
            this.Text = "Weather Report";
            this.Load += new System.EventHandler(this.baitap2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.baitap2_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCloudy;
        private System.Windows.Forms.RadioButton radSunny;
        private System.Windows.Forms.RadioButton radSnowy;
        private System.Windows.Forms.RadioButton radRainy;
        private System.Windows.Forms.PictureBox picCloudy;
        private System.Windows.Forms.PictureBox picRain;
        private System.Windows.Forms.PictureBox picSnowy;
        private System.Windows.Forms.PictureBox picSunny;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
    }
}