namespace Clinic_Management_System.Zoom_Chart
{
    partial class Age
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Age));
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ageBetween_DataSet = new Clinic_Management_System.AgeBetween_DataSet();
            this.reportColumChartSpaceAgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report_ColumChart_SpaceAgeTableAdapter = new Clinic_Management_System.AgeBetween_DataSetTableAdapters.Report_ColumChart_SpaceAgeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBetween_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportColumChartSpaceAgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart3
            // 
            chartArea3.Area3DStyle.Inclination = 1;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chart3.DataSource = this.reportColumChartSpaceAgeBindingSource;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(1, 26);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Count";
            series3.ShadowOffset = 5;
            series3.XValueMember = "AgeRange";
            series3.YValueMembers = "count";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(920, 618);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chart3";
            // 
            // ageBetween_DataSet
            // 
            this.ageBetween_DataSet.DataSetName = "AgeBetween_DataSet";
            this.ageBetween_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportColumChartSpaceAgeBindingSource
            // 
            this.reportColumChartSpaceAgeBindingSource.DataMember = "Report_ColumChart_SpaceAge";
            this.reportColumChartSpaceAgeBindingSource.DataSource = this.ageBetween_DataSet;
            // 
            // report_ColumChart_SpaceAgeTableAdapter
            // 
            this.report_ColumChart_SpaceAgeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(2, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Patient Distribute By Blood Age";
            // 
            // Age
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Age";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age";
            this.Load += new System.EventHandler(this.Age_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBetween_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportColumChartSpaceAgeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private AgeBetween_DataSet ageBetween_DataSet;
        private System.Windows.Forms.BindingSource reportColumChartSpaceAgeBindingSource;
        private AgeBetween_DataSetTableAdapters.Report_ColumChart_SpaceAgeTableAdapter report_ColumChart_SpaceAgeTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}