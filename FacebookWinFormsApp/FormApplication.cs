using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace BasicFacebookFeatures
{
    public partial class FormApplication : Form
    {
        private StatisticsCalcManager m_UserStatisticsCalcManager;
        private User m_LoggedInUser;
        private Chart m_ChartPhotoTrend;
        private Chart m_ChartPostsTrend;
        private Chart m_ChartLikedPage;
        private Chart m_ChartPostsByType;
        private ComboBox m_ComboBoxGroupByDate;
        private string[] m_GroupByOptions = { "Day","Month","Year"};
        private string m_GroupByDateFormat = "yyyy";


        public FormApplication()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 5;
            this.m_UserStatisticsCalcManager = new StatisticsCalcManager();
            
            initializeComponent();
            //

        }


        private void initChartPostsTrend()
        {
           
            this.m_ChartPostsTrend = new Chart();
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Upload Date";
            chartArea.AxisY.Title = "# Posts";
            Legend legend = new Legend();
            
            this.m_ChartPostsTrend.ChartAreas.Add(chartArea);
            this.m_ChartPostsTrend.Legends.Add(legend);
            this.m_ChartPostsTrend.Location = new System.Drawing.Point(8, 187);

            Series totalPostsTrendSeries = new Series();
            totalPostsTrendSeries.Name = "Total Posts";
            totalPostsTrendSeries.IsXValueIndexed = true;
            totalPostsTrendSeries.Color = Color.MidnightBlue;
            this.m_ChartPostsTrend.Series.Add(totalPostsTrendSeries);
            this.initSeriesPostsTrend();
          
            this.m_ChartPostsTrend.Size = new System.Drawing.Size(730, 152);

            this.m_ChartPostsTrend.Titles.Add("Posts Trend");
            this.Controls.Add(this.m_ChartPostsTrend);


        }



        private void initChartAlbumsAndPhotosTrend()
        {

            this.m_ChartPhotoTrend = new Chart();
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Upload Date";
            chartArea.AxisY.Title = "# Photos / Albums";
            Legend legend = new Legend();
            Series totalPhotosTrendSeries = new Series();
            Series totalAlbumsTrendSeries = new Series();


            chartArea.AxisX.IsMarginVisible = false;
         

            this.m_ChartPhotoTrend.ChartAreas.Add(chartArea);
            this.m_ChartPhotoTrend.Legends.Add(legend);
            this.m_ChartPhotoTrend.Location = new System.Drawing.Point(8, 8);

            totalPhotosTrendSeries.Name = "Total Photos";
            totalPhotosTrendSeries.IsXValueIndexed = true;
            
            totalPhotosTrendSeries.AxisLabel = "Upload Date";

            totalAlbumsTrendSeries.Name = "Total Albums";
            totalAlbumsTrendSeries.IsXValueIndexed = true;
            totalAlbumsTrendSeries.AxisLabel = "Upload Date";


            this.m_ChartPhotoTrend.Series.Add(totalPhotosTrendSeries);
            this.m_ChartPhotoTrend.Series.Add(totalAlbumsTrendSeries);
            this.initSeriesAlbumsAndPhotosTrend();


            this.m_ChartPhotoTrend.Size = new System.Drawing.Size(730, 152);
            this.m_ChartPhotoTrend.Titles.Add("Album and Album's Photos Trend");
            this.Controls.Add(this.m_ChartPhotoTrend);

        }


        private void initChartLikedPageByCategory()
        {
            //Dictionary<string,int> likedPagesByCategoryResults = this.m_UserStatisticsCalcManager.LikedPagesStatisticsCalc.TotalPagesByCategory;

            Dictionary<string, int> likedPagesByCategoryResults =
                this.m_UserStatisticsCalcManager.GetLikedPageByCategoryResults();

            this.m_ChartLikedPage = new Chart();

            ChartArea chartArea = new ChartArea();
            Legend legend = new Legend();
            Series likedPageByCategorySeries = new Series();
            likedPageByCategorySeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartArea.AxisX.IsMarginVisible = false;


            this.m_ChartLikedPage.ChartAreas.Add(chartArea);
            this.m_ChartLikedPage.Legends.Add(legend);
            this.m_ChartLikedPage.Location = new System.Drawing.Point(11, 366);
            this.m_ChartLikedPage.Size = new System.Drawing.Size(259, 188);
            this.m_ChartLikedPage.Titles.Add("Liked Pages by Page Category");
          
            likedPageByCategorySeries.IsXValueIndexed = true;
            likedPageByCategorySeries.IsValueShownAsLabel = true;
            likedPageByCategorySeries.Points.DataBindXY(likedPagesByCategoryResults.Keys,likedPagesByCategoryResults.Values);
            likedPageByCategorySeries.Palette = ChartColorPalette.SeaGreen;
            this.m_ChartLikedPage.Series.Add(likedPageByCategorySeries);

            this.Controls.Add(this.m_ChartLikedPage);


        }


        private void initChartPostsByPostType()
        {
            //Dictionary<string,int> totalPostByPostTypeResults = this.m_UserStatisticsCalcManager.PostsStatisticsCalc.TotalPostsByTypeResults;
            Dictionary<string, int> totalPostByPostTypeResults =
                this.m_UserStatisticsCalcManager.GetPostsByPostTypeResults();

            this.m_ChartPostsByType = new Chart();
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Post Type";
            chartArea.AxisY.Title = "# Posts";
            Legend legend = new Legend();
            Series totalPostByTypeSeries = new Series();
            chartArea.AxisX.IsMarginVisible = false;


            this.m_ChartPostsByType.ChartAreas.Add(chartArea);
            this.m_ChartPostsByType.Legends.Add(legend);
            this.m_ChartPostsByType.Location = new System.Drawing.Point(300, 366);

            totalPostByTypeSeries.Name = "Total Posts";
            totalPostByTypeSeries.IsXValueIndexed = true;
            totalPostByTypeSeries.Points.DataBindXY(totalPostByPostTypeResults.Keys, totalPostByPostTypeResults.Values);
            totalPostByTypeSeries.Color = Color.IndianRed;
            

            this.m_ChartPostsByType.Series.Add(totalPostByTypeSeries);
            
            this.m_ChartPostsByType.AlignDataPointsByAxisLabel(PointSortOrder.Ascending);
            this.m_ChartPostsByType.Size = new System.Drawing.Size(438, 188);
            this.m_ChartPostsByType.Titles.Add("Total Posts by Post Type");
            this.Controls.Add(this.m_ChartPostsByType);
        }


        private void initComboBox()
        {
            this.m_ComboBoxGroupByDate = new ComboBox();
            this.m_ComboBoxGroupByDate.DropDownStyle = ComboBoxStyle.DropDown;
            this.m_ComboBoxGroupByDate.Location = new System.Drawing.Point(778, 11);
            this.m_ComboBoxGroupByDate.Size = new System.Drawing.Size(148, 123);
            
            this.m_ComboBoxGroupByDate.Items.AddRange(this.m_GroupByOptions);
            this.m_ComboBoxGroupByDate.SelectedItem = "Year";
            this.m_ComboBoxGroupByDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroupByDate_SelectedIndexChanged);

            this.Controls.Add(this.m_ComboBoxGroupByDate);
          
        }

        private void comboBoxGroupByDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFormat = (string)this.m_ComboBoxGroupByDate.SelectedItem; 
            switch (selectedFormat)
            {
                case "Day":
                    this.m_GroupByDateFormat = "yyyy-MM-dd";
                    break;
                case "Month":
                    this.m_GroupByDateFormat = "yyyy-MM";
                    break;
                case "Year":
                    this.m_GroupByDateFormat = "yyyy";
                    break;
                default:
                    this.m_GroupByDateFormat = "yyyy";
                    break;
            }
            //his.m_UserStatisticsCalcManager.AlbumsStatisticsCalc.FetchDynamicResults(this.m_GroupByDateFormat);
            //this.m_UserStatisticsCalcManager.PostsStatisticsCalc.FetchDynamicResults(this.m_GroupByDateFormat);
            this.m_UserStatisticsCalcManager.ReFetchDynamicData(this.m_GroupByDateFormat);
            this.initSeriesAlbumsAndPhotosTrend();
            this.initSeriesPostsTrend();


        }

        private void initSeriesAlbumsAndPhotosTrend()
        {
            //AlbumsStatisticsCalc albumsStatisticsCalc = this.m_UserStatisticsCalcManager.AlbumsStatisticsCalc;

            Dictionary<string, int> totalPhotosByDateResults =
                this.m_UserStatisticsCalcManager.GetAlbumsPhotosByDateResults();

            Dictionary<string, int> totalAlbumsByDateResults =
                this.m_UserStatisticsCalcManager.GetAlbumsByDateResults();

            this.m_ChartPhotoTrend.Series["Total Photos"].Points.Clear();

            this.m_ChartPhotoTrend.Series["Total Photos"].Points.DataBindXY(totalPhotosByDateResults.Keys, totalPhotosByDateResults.Values);

            this.m_ChartPhotoTrend.Series["Total Albums"].Points.Clear();

            this.m_ChartPhotoTrend.Series["Total Albums"].Points.DataBindXY(totalAlbumsByDateResults.Keys, totalAlbumsByDateResults.Values);
            
            
            this.m_ChartPhotoTrend.AlignDataPointsByAxisLabel(PointSortOrder.Ascending);
            
            this.m_ChartPhotoTrend.Update();
            this.m_ChartPhotoTrend.Refresh();
        }

        private void initSeriesPostsTrend()
        {
            //Dictionary<string, int> postsTrendResults = this.m_UserStatisticsCalcManager.PostsStatisticsCalc.TotalPostsByDateResults;
            Dictionary<string, int> postsTrendResults = this.m_UserStatisticsCalcManager.GetPostsByDateResults();

            this.m_ChartPostsTrend.Series["Total Posts"].Points.Clear();

            this.m_ChartPostsTrend.Series["Total Posts"].Points.DataBindXY(postsTrendResults.Keys, postsTrendResults.Values);

            this.m_ChartPostsTrend.AlignDataPointsByAxisLabel(PointSortOrder.Ascending);

            this.m_ChartPhotoTrend.Update();
            this.m_ChartPhotoTrend.Refresh();

        }


        private void initializeComponent()
        { 
            this.initChartAlbumsAndPhotosTrend();
            this.initChartLikedPageByCategory();
            this.initChartPostsByPostType();
            this.initChartPostsTrend();
            this.initComboBox();
            // this.m_Calc.pages();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 574);

            this.Name = "FacebookDesktop";
            this.Text = "FacebookDesktop";
           // ((System.ComponentModel.ISupportInitialize)(this.m_ChartPhotoTrend)).EndInit();
            //this.ResumeLayout(false);

        }

    }
}
