namespace Clinic_Management_System.Zoom_Chart
{
    partial class Married_Status
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Married_Status));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportMarriedStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.married_Status_DataSet = new Clinic_Management_System.Married_Status_DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.report_MarriedStatusTableAdapter = new Clinic_Management_System.Married_Status_DataSetTableAdapters.Report_MarriedStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMarriedStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.married_Status_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.reportMarriedStatusBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, -1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(717, 691);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // reportMarriedStatusBindingSource
            // 
            this.reportMarriedStatusBindingSource.DataMember = "Report_MarriedStatus";
            this.reportMarriedStatusBindingSource.DataSource = this.married_Status_DataSet;
            // 
            // married_Status_DataSet
            // 
            this.married_Status_DataSet.DataSetName = "Married_Status_DataSet";
            this.married_Status_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Patient Distribute By Married Status";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // report_MarriedStatusTableAdapter
            // 
            this.report_MarriedStatusTableAdapter.ClearBeforeFill = true;
            // 
            // Married_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 684);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Married_Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Married_Status";
            this.Load += new System.EventHandler(this.Married_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMarriedStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.married_Status_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Married_Status_DataSet married_Status_DataSet;
        private System.Windows.Forms.BindingSource reportMarriedStatusBindingSource;
        private Married_Status_DataSetTableAdapters.Report_MarriedStatusTableAdapter report_MarriedStatusTableAdapter;
    }
}