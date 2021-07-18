namespace Clinic_Management_System.form
{
    partial class Report_Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Chart));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportChartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gender_Chart_DataSet = new Clinic_Management_System.Gender_Chart_DataSet();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportMarriedStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.married_Status_DataSet = new Clinic_Management_System.Married_Status_DataSet();
            this.report_ChartTableAdapter = new Clinic_Management_System.Gender_Chart_DataSetTableAdapters.Report_ChartTableAdapter();
            this.report_MarriedStatusTableAdapter = new Clinic_Management_System.Married_Status_DataSetTableAdapters.Report_MarriedStatusTableAdapter();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportColumChartSpaceAgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ageBetween_DataSet = new Clinic_Management_System.AgeBetween_DataSet();
            this.report_ColumChart_SpaceAgeTableAdapter = new Clinic_Management_System.AgeBetween_DataSetTableAdapters.Report_ColumChart_SpaceAgeTableAdapter();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.diseaseChartReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diseaseC_DataSet = new Clinic_Management_System.DiseaseC_DataSet();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bloodGroupChartReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boold_DataSet = new Clinic_Management_System.Boold_DataSet();
            this.disease_ChartReportTableAdapter = new Clinic_Management_System.DiseaseC_DataSetTableAdapters.Disease_ChartReportTableAdapter();
            this.blood_Group_ChartReportTableAdapter = new Clinic_Management_System.Boold_DataSetTableAdapters.Blood_Group_ChartReportTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gender_Chart_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMarriedStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.married_Status_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportColumChartSpaceAgeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBetween_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseChartReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseC_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroupChartReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boold_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chart1.DataSource = this.reportChartBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 7);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(367, 350);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // reportChartBindingSource
            // 
            this.reportChartBindingSource.DataMember = "Report_Chart";
            this.reportChartBindingSource.DataSource = this.gender_Chart_DataSet;
            // 
            // gender_Chart_DataSet
            // 
            this.gender_Chart_DataSet.DataSetName = "Gender_Chart_DataSet";
            this.gender_Chart_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart2
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chart2.DataSource = this.reportMarriedStatusBindingSource;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(4, 363);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(367, 337);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
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
            // report_ChartTableAdapter
            // 
            this.report_ChartTableAdapter.ClearBeforeFill = true;
            // 
            // report_MarriedStatusTableAdapter
            // 
            this.report_MarriedStatusTableAdapter.ClearBeforeFill = true;
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
            this.chart3.Location = new System.Drawing.Point(757, 7);
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
            this.chart3.Size = new System.Drawing.Size(604, 692);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
            // 
            // reportColumChartSpaceAgeBindingSource
            // 
            this.reportColumChartSpaceAgeBindingSource.DataMember = "Report_ColumChart_SpaceAge";
            this.reportColumChartSpaceAgeBindingSource.DataSource = this.ageBetween_DataSet;
            // 
            // ageBetween_DataSet
            // 
            this.ageBetween_DataSet.DataSetName = "AgeBetween_DataSet";
            this.ageBetween_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_ColumChart_SpaceAgeTableAdapter
            // 
            this.report_ColumChart_SpaceAgeTableAdapter.ClearBeforeFill = true;
            // 
            // chart4
            // 
            this.chart4.BorderlineColor = System.Drawing.Color.Black;
            chartArea4.Area3DStyle.Enable3D = true;
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            this.chart4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chart4.DataSource = this.diseaseChartReportBindingSource;
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(377, 363);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 2;
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(374, 337);
            this.chart4.TabIndex = 3;
            this.chart4.Text = "chart4";
            this.chart4.Click += new System.EventHandler(this.chart4_Click);
            // 
            // diseaseChartReportBindingSource
            // 
            this.diseaseChartReportBindingSource.DataMember = "Disease_ChartReport";
            this.diseaseChartReportBindingSource.DataSource = this.diseaseC_DataSet;
            // 
            // diseaseC_DataSet
            // 
            this.diseaseC_DataSet.DataSetName = "DiseaseC_DataSet";
            this.diseaseC_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart5
            // 
            this.chart5.BorderlineColor = System.Drawing.Color.Black;
            chartArea5.Area3DStyle.Enable3D = true;
            chartArea5.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea5);
            this.chart5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chart5.DataSource = this.bloodGroupChartReportBindingSource;
            legend5.Name = "Legend1";
            this.chart5.Legends.Add(legend5);
            this.chart5.Location = new System.Drawing.Point(377, 7);
            this.chart5.Name = "chart5";
            this.chart5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart5.Series.Add(series5);
            this.chart5.Size = new System.Drawing.Size(374, 350);
            this.chart5.TabIndex = 4;
            this.chart5.Text = "chart5";
            this.chart5.Click += new System.EventHandler(this.chart5_Click);
            // 
            // bloodGroupChartReportBindingSource
            // 
            this.bloodGroupChartReportBindingSource.DataMember = "Blood_Group_ChartReport";
            this.bloodGroupChartReportBindingSource.DataSource = this.boold_DataSet;
            // 
            // boold_DataSet
            // 
            this.boold_DataSet.DataSetName = "Boold_DataSet";
            this.boold_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disease_ChartReportTableAdapter
            // 
            this.disease_ChartReportTableAdapter.ClearBeforeFill = true;
            // 
            // blood_Group_ChartReportTableAdapter
            // 
            this.blood_Group_ChartReportTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patient Distribute By Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patient Distribute By Blood Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Patient Distribute By Married Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patient Distribute By Disease";
            // 
            // Report_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart5);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gender_Chart_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMarriedStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.married_Status_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportColumChartSpaceAgeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBetween_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseChartReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseC_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroupChartReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boold_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Gender_Chart_DataSet gender_Chart_DataSet;
        private System.Windows.Forms.BindingSource reportChartBindingSource;
        private Gender_Chart_DataSetTableAdapters.Report_ChartTableAdapter report_ChartTableAdapter;
        private Married_Status_DataSet married_Status_DataSet;
        private System.Windows.Forms.BindingSource reportMarriedStatusBindingSource;
        private Married_Status_DataSetTableAdapters.Report_MarriedStatusTableAdapter report_MarriedStatusTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private AgeBetween_DataSet ageBetween_DataSet;
        private System.Windows.Forms.BindingSource reportColumChartSpaceAgeBindingSource;
        private AgeBetween_DataSetTableAdapters.Report_ColumChart_SpaceAgeTableAdapter report_ColumChart_SpaceAgeTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private DiseaseC_DataSet diseaseC_DataSet;
        private System.Windows.Forms.BindingSource diseaseChartReportBindingSource;
        private DiseaseC_DataSetTableAdapters.Disease_ChartReportTableAdapter disease_ChartReportTableAdapter;
        private Boold_DataSet boold_DataSet;
        private System.Windows.Forms.BindingSource bloodGroupChartReportBindingSource;
        private Boold_DataSetTableAdapters.Blood_Group_ChartReportTableAdapter blood_Group_ChartReportTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}