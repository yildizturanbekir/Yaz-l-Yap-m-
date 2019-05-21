namespace v._02
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnCevapla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCıkıs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LightGray;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(53, 152);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(150, 70);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Yeni Kelime Ekle";
            this.toolTip1.SetToolTip(this.btnEkle, "Yeni kelime girmek için tıkla");
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.LightGray;
            this.btnRapor.FlatAppearance.BorderSize = 0;
            this.btnRapor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRapor.ForeColor = System.Drawing.Color.Black;
            this.btnRapor.Location = new System.Drawing.Point(53, 243);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(150, 70);
            this.btnRapor.TabIndex = 1;
            this.btnRapor.Text = "Rapor Görüntüleme";
            this.toolTip1.SetToolTip(this.btnRapor, "Raporları görüntülemek için tıkla");
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCevapla
            // 
            this.btnCevapla.BackColor = System.Drawing.Color.LightGray;
            this.btnCevapla.FlatAppearance.BorderSize = 0;
            this.btnCevapla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCevapla.ForeColor = System.Drawing.Color.Black;
            this.btnCevapla.Location = new System.Drawing.Point(53, 61);
            this.btnCevapla.Name = "btnCevapla";
            this.btnCevapla.Size = new System.Drawing.Size(150, 70);
            this.btnCevapla.TabIndex = 2;
            this.btnCevapla.Text = "Kelime Cevapla";
            this.toolTip1.SetToolTip(this.btnCevapla, "Kelime cevaplamak için tıkla");
            this.btnCevapla.UseVisualStyleBackColor = false;
            this.btnCevapla.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 343);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.LightGray;
            this.btnCıkıs.FlatAppearance.BorderSize = 0;
            this.btnCıkıs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCıkıs.ForeColor = System.Drawing.Color.Black;
            this.btnCıkıs.Location = new System.Drawing.Point(53, 334);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(150, 70);
            this.btnCıkıs.TabIndex = 3;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnCevapla);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Öğrenme Programı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnCevapla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCıkıs;
    }
}

