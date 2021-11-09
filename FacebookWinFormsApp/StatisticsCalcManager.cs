using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{

    public class StatisticsCalcManager
    {
        private User m_LoggedInUser;
        private string m_DateGroupFormat;
        private FormLogin m_FormLogin;
        //private AlbumsStatisticsCalc m_AlbumsStatisticsCalc;
        //private LikedPagesStatisticsCalc m_LikedPagesStatisticsCalc;
        //private PostsStatisticsCalc m_PostsStatisticsCalc;

        private List<StatisticsCalculator> m_StatisticsCalculators;

        public Dictionary<string, int> GetLikedPageByCategoryResults()
        {


            return ((LikedPagesStatisticsCalc)this.m_StatisticsCalculators[0]).TotalPagesByCategory;

        }

        public Dictionary<string, int> GetAlbumsByDateResults()
        {
            return ((AlbumsStatisticsCalc)this.m_StatisticsCalculators[1]).TotalAlbumsByDateResults;
        }

        public Dictionary<string, int> GetAlbumsPhotosByDateResults()
        {
            return ((AlbumsStatisticsCalc)this.m_StatisticsCalculators[1]).TotalPhotosByDateResults;
        }

        public Dictionary<string, int> GetPostsByDateResults()
        {
            return ((PostsStatisticsCalc)this.m_StatisticsCalculators[2]).TotalPostsByDateResults;
        }

        public Dictionary<string, int> GetPostsByPostTypeResults()
        {
            return ((PostsStatisticsCalc)this.m_StatisticsCalculators[2]).TotalPostsByTypeResults;
        }

        



        public StatisticsCalcManager(string i_GroupByDateFormat = "yyyy")
        {
            this.m_DateGroupFormat = i_GroupByDateFormat;
            //FormLogin formLogin = new FormLogin();

            string token = "EAAEFuZBc7ZCo4BACZBax6pMzzZB6kjra9QQYfC9M4DnuemXgZAmdTFCiKvKajN7TrdB4nr1gnU7XZAEgCW86a7ZAKeKvXglZBRXZAVySXVH12Xv1wSZBPM9AUW7w44xT1oY9X0beAeweDkCLhZCg5mynOu6IcMxOuD5HXF7foIlHZCwZCnyJLb26Nh7zquHUPjavqMKUkfj3amBTf5vsVImE1Rtklr7MxNeGy7ZCgZD";
            LoginResult result = FacebookWrapper.FacebookService.Connect(token);
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                this.m_LoggedInUser = result.LoggedInUser;
                //this.m_AlbumsStatisticsCalc = new AlbumsStatisticsCalc(this.m_LoggedInUser.Albums, this.m_DateGroupFormat);
            }
            //this.m_LoggedInUser = formLogin.LoggedInUser;
            //this.m_PostsStatisticsCalc = new PostsStatisticsCalc(this.m_LoggedInUser.Posts, this.m_DateGroupFormat);
            //this.m_AlbumsStatisticsCalc = new AlbumsStatisticsCalc(this.m_LoggedInUser.Albums, this.m_DateGroupFormat);
            //this.m_LikedPagesStatisticsCalc = new LikedPagesStatisticsCalc(m_LoggedInUser.LikedPages);

            this.m_StatisticsCalculators = new List<StatisticsCalculator>
                                               {
                                                   new LikedPagesStatisticsCalc(m_LoggedInUser.LikedPages),
                                                   new AlbumsStatisticsCalc(
                                                       this.m_LoggedInUser.Albums,
                                                       this.m_DateGroupFormat),
                                                   new PostsStatisticsCalc(this.m_LoggedInUser.Posts, this.m_DateGroupFormat)
                                               };
        }

        public void ReFetchDynamicData(string i_GroupByDateFormat)
        {
            this.m_DateGroupFormat = i_GroupByDateFormat;
            foreach (var calculator in this.m_StatisticsCalculators)
            {
                if (calculator is IDynamicStatisticsResults results)
                {
                    results.FetchDynamicResults(this.m_DateGroupFormat);
                }
            }
        }


        public static
            void InsertIntoDictionaryWithIntValue<T>(Dictionary<T, int> i_Dictionary, T i_Key, int i_Value)
        {
            if (i_Dictionary.ContainsKey(i_Key))

            {
                i_Dictionary[i_Key] += i_Value;
            }
            else
            {
                i_Dictionary.Add(i_Key, i_Value);
            }

        }
    }


}