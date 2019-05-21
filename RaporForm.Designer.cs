namespace v._02
{
    partial class RaporForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporForm));
            this.cmbxSecim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chrtAylık = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtYıllık = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAylık)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtYıllık)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxSecim
            // 
            this.cmbxSecim.FormattingEnabled = true;
            this.cmbxSecim.Items.AddRange(new object[] {
            "Aylık",
            "Yıllık",
            "Seçim Yap"});
            this.cmbxSecim.Location = new System.Drawing.Point(27, 64);
            this.cmbxSecim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbxSecim.Name = "cmbxSecim";
            this.cmbxSecim.Size = new System.Drawing.Size(180, 29);
            this.cmbxSecim.TabIndex = 0;
            this.cmbxSecim.SelectedIndexChanged += new System.EventHandler(this.cmbxSecim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rapor türünü seçiniz.";
            // 
            // chrtAylık
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtAylık.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtAylık.Legends.Add(legend1);
            this.chrtAylık.Location = new System.Drawing.Point(27, 122);
            this.chrtAylık.Name = "chrtAylık";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylar";
            this.chrtAylık.Series.Add(series1);
            this.chrtAylık.Size = new System.Drawing.Size(600, 300);
            this.chrtAylık.TabIndex = 2;
            this.chrtAylık.Text = "chart1";
            // 
            // chrtYıllık
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtYıllık.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtYıllık.Legends.Add(legend2);
            this.chrtYıllık.Location = new System.Drawing.Point(27, 122);
            this.chrtYıllık.Name = "chrtYıllık";
            this.chrtYıllık.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Yıllık";
            this.chrtYıllık.Series.Add(series2);
            this.chrtYıllık.Size = new System.Drawing.Size(600, 300);
            this.chrtYıllık.TabIndex = 3;
            this.chrtYıllık.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chrtYıllık);
            this.Controls.Add(this.chrtAylık);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxSecim);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Görüntüleme Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RaporForm_FormClosed);
            this.Load += new System.EventHandler(this.RaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtAylık)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtYıllık)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxSecim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAylık;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtYıllık;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
    }
}