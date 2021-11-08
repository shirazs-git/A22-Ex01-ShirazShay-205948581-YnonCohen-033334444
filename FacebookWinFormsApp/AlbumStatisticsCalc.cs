using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AlbumStatisticsCalc : ITrendCalc
    {
        private  string m_GroupByDateFormat;

        private  Dictionary<string, int> m_TotalAlbumsByDateResults;
        private  Dictionary<string, int> m_TotalPhotosByDateResults;

        private readonly FacebookObjectCollection<Album> r_AlbumsCollection;

        public Dictionary<string, int> TotalPhotosByDateResults
        {
            get
            {
                return m_TotalPhotosByDateResults;
            }
        }

        public Dictionary<string, int> TotalAlbumsByDateResults
        {
            get
            {
                return m_TotalAlbumsByDateResults;
            }
        }
        
        public AlbumStatisticsCalc(FacebookObjectCollection<Album> i_Albums, string i_GroupByDateFormat)
        {
            this.m_GroupByDateFormat = i_GroupByDateFormat;

            this.r_AlbumsCollection = i_Albums;

            this.m_TotalPhotosByDateResults = new Dictionary<string, int>();
            this.m_TotalAlbumsByDateResults = new Dictionary<string, int>();
            this.FetchTrend(i_GroupByDateFormat);

        }


        private void fetchTotalAlbumsByDate()
        {
            
            this.m_TotalAlbumsByDateResults.Clear();
            
            var queryAlbumsTrend = from album in this.r_AlbumsCollection

                                   group album by album.CreatedTime.Value.ToString(this.m_GroupByDateFormat)
                                   into groupByDate
                                   orderby groupByDate.Key
                                   select new
                                              {
                                                  date = groupByDate.Key
                                                  ,totalAlbums = groupByDate.Count()
                                              };




            foreach (var dateGroup in queryAlbumsTrend)
            {
                
                StatisticsCalc.InsertIntoDictionaryWithIntValue(this.m_TotalAlbumsByDateResults, dateGroup.date, dateGroup.totalAlbums);

            }
        }

        private void fetchTotalPhotosByDate()
        {
            this.TotalPhotosByDateResults.Clear();

            foreach (Album album in this.r_AlbumsCollection)
            {

                var queryPhotosAlbum = from photo in album.Photos

                                       group photo by photo.CreatedTime.Value.ToString(this.m_GroupByDateFormat)
                                       into groupByDate
                                       orderby groupByDate.Key
                                       select new
                                                  {
                                                      date = groupByDate.Key
                                                      ,totalPhotos = groupByDate.Count()
                                                  };




                foreach (var dateGroup in queryPhotosAlbum)
                {
                    StatisticsCalc.InsertIntoDictionaryWithIntValue(this.m_TotalPhotosByDateResults,dateGroup.date,dateGroup.totalPhotos);

                }
            }
        }


        public bool TryAccessCollection<T>(FacebookObjectCollection<T> i_Collection)
        {
            try
            {
                int facebookObjectCollection = i_Collection.Count;
                return true;

            }
            catch (Facebook.FacebookOAuthException e)
            {
                return false;

            }

        }


        public void FetchTrend(string i_GroupByDateFormat)
        {
            this.m_GroupByDateFormat = i_GroupByDateFormat;
            this.fetchTotalAlbumsByDate();
            this.fetchTotalPhotosByDate();

        }
    }
}