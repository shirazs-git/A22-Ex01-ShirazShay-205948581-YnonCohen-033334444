
namespace BasicFacebookFeatures
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LikedPageByType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.albumsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.postsByType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.postsTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.LikedPageByType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsByType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsTrend)).BeginInit();
            this.SuspendLayout();
            // 
            // LikedPageByType
            // 
            this.LikedPageByType.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            chartArea1.Name = "ChartArea1";
            this.LikedPageByType.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.LikedPageByType.Legends.Add(legend1);
            this.LikedPageByType.Location = new System.Drawing.Point(11, 366);
            this.LikedPageByType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LikedPageByType.Name = "LikedPageByType";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.LikedPageByType.Series.Add(series1);
            this.LikedPageByType.Size = new System.Drawing.Size(259, 188);
            this.LikedPageByType.TabIndex = 0;
            this.LikedPageByType.Text = "chart1";
            // 
            // albumsChart
            // 
            this.albumsChart.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            chartArea2.Name = "ChartArea1";
            this.albumsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.albumsChart.Legends.Add(legend2);
            this.albumsChart.Location = new System.Drawing.Point(8, 8);
            this.albumsChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.albumsChart.Name = "albumsChart";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Indigo;
            series3.Legend = "Legend1";
            series3.MarkerSize = 8;
            series3.Name = "Series2";
            this.albumsChart.Series.Add(series2);
            this.albumsChart.Series.Add(series3);
            this.albumsChart.Size = new System.Drawing.Size(730, 152);
            this.albumsChart.TabIndex = 1;
            this.albumsChart.Text = "chahfjhdfrt2";
            // 
            // postsByType
            // 
            chartArea3.Name = "ChartArea1";
            this.postsByType.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.postsByType.Legends.Add(legend3);
            this.postsByType.Location = new System.Drawing.Point(300, 366);
            this.postsByType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.postsByType.Name = "postsByType";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.postsByType.Series.Add(series4);
            this.postsByType.Size = new System.Drawing.Size(438, 188);
            this.postsByType.TabIndex = 2;
            this.postsByType.Text = "chart3";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(778, 11);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(148, 123);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // postsTrend
            // 
            this.postsTrend.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            chartArea4.Name = "ChartArea1";
            this.postsTrend.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.postsTrend.Legends.Add(legend4);
            this.postsTrend.Location = new System.Drawing.Point(8, 187);
            this.postsTrend.Margin = new System.Windows.Forms.Padding(2);
            this.postsTrend.Name = "postsTrend";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series6.BorderWidth = 4;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Indigo;
            series6.Legend = "Legend1";
            series6.MarkerSize = 8;
            series6.Name = "Series2";
            this.postsTrend.Series.Add(series5);
            this.postsTrend.Series.Add(series6);
            this.postsTrend.Size = new System.Drawing.Size(730, 152);
            this.postsTrend.TabIndex = 4;
            this.postsTrend.Text = "chahfjhdfrt2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 574);
            this.Controls.Add(this.postsTrend);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.postsByType);
            this.Controls.Add(this.albumsChart);
            this.Controls.Add(this.LikedPageByType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LikedPageByType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsByType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsTrend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart albumsChart;
        public System.Windows.Forms.DataVisualization.Charting.Chart LikedPageByType;
        private System.Windows.Forms.DataVisualization.Charting.Chart postsByType;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart postsTrend;
    }
}