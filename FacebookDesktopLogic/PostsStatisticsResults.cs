using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms.VisualStyles;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PostsStatisticsResults : ITrendCalc
    {
        private  Dictionary<string, int> m_TotalPostsByDateResults;
        private  Dictionary<string, int> m_TotalPostsByTypeResults;
        
        private string m_GroupByDateFormat;
        
        private readonly FacebookObjectCollection<Post> r_PostsCollection;

        public Dictionary<string, int> TotalPostsByDateResults
        {
            get
            {
                return m_TotalPostsByDateResults;
            }
        }

        public Dictionary<string, int> TotalPostsByTypeResults
        {
            get
            {
                return m_TotalPostsByTypeResults;
            }
        }

        public PostsStatisticsResults(FacebookObjectCollection<Post> i_PostCollection, string i_GroupByDateFormat)
        {

            this.m_GroupByDateFormat = i_GroupByDateFormat;
            this.r_PostsCollection = i_PostCollection;

            this.m_TotalPostsByDateResults = new Dictionary<string, int>();
            this.m_TotalPostsByTypeResults = new Dictionary<string, int>();

            this.fetchTotalPostsByDate();
            this.fetchTotalPostsByType();
           
            

            ;
        }

        private void fetchTotalPostsByType()
        {
            this.m_TotalPostsByTypeResults.Clear();

            var queryPostsByType = from post in this.r_PostsCollection
                                   group post by post.Type
                                   into groupByType
                                   orderby groupByType.Key
                                   select new
                                              {
                                                  postTypeGroup = groupByType.Key.ToString(),
                                                  totalPosts = groupByType.Count()

                                              };

            foreach (var group in queryPostsByType)
            {
                StatisticsCalc.InsertIntoDictionaryWithIntValue(this.m_TotalPostsByTypeResults, group.postTypeGroup, group.totalPosts);
            }
        }

        private void fetchTotalPostsByDate()
        {
            this.TotalPostsByDateResults.Clear();

            var queryPostsTrend = from post in this.r_PostsCollection
                                  group post by post.CreatedTime.Value.ToString(this.m_GroupByDateFormat)
                                  into groupByDate
                                  orderby groupByDate.Key
                                  select new
                                             {
                                                 dateGroup = groupByDate.Key,
                                                 totalPosts = groupByDate.Count()

                                             };

            foreach (var group in queryPostsTrend)
            {
                StatisticsCalc.InsertIntoDictionaryWithIntValue(this.m_TotalPostsByDateResults, group.dateGroup, group.totalPosts);
            }

        }

        public void FetchTrend(string i_GroupByDateFormat)
        {
            this.m_GroupByDateFormat = i_GroupByDateFormat;
            fetchTotalPostsByDate();
        }
    }

}