using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using FacebookWrapper;

namespace BasicFacebookFeatures
{

    public class StatisticsCalc
    {
        private User m_LoggedInUser;
        private string m_DateGroupFormat;
        private FormLogin m_FormLogin;
        private AlbumStatisticsResults m_AlbumStatisticsResults;
        private LikedPagesStatisticsResult m_LikedPagesStatisticsResults;
        private PostsStatisticsResults m_PostsStatisticsResults;
        
        public enum eGroupByDate
        {
            Date,
            Month,
            Year
        }

        public LikedPagesStatisticsResults LikedPagesStatisticsResults
        {
            get
            {
                return m_LikedPagesStatisticsResult;
            }
        }

        public AlbumStatisticsResults AlbumStatisticsResult
        {
            get
            {
                return m_AlbumStatisticsResults;
            }
        }

        public PostsStatisticsResults PostsStatisticsResults
        {
            get
            {
                return m_PostsStatisticsResults;
            }
        }

        public StatisticsCalc(eGroupByDate i_DateGroup = eGroupByDate.Year)
        {

            switch (i_DateGroup)
            {
                case eGroupByDate.Date:
                    this.m_DateGroupFormat = "yyyy-MM-dd";
                    break;
                case eGroupByDate.Month:
                    this.m_DateGroupFormat = "yyyy-MM";
                    break;
                default:
                    this.m_DateGroupFormat = "yyyy";
                    break;
            }

            //FormLogin formLogin = new FormLogin();
           
            string token = "EAAEFuZBc7ZCo4BACZBax6pMzzZB6kjra9QQYfC9M4DnuemXgZAmdTFCiKvKajN7TrdB4nr1gnU7XZAEgCW86a7ZAKeKvXglZBRXZAVySXVH12Xv1wSZBPM9AUW7w44xT1oY9X0beAeweDkCLhZCg5mynOu6IcMxOuD5HXF7foIlHZCwZCnyJLb26Nh7zquHUPjavqMKUkfj3amBTf5vsVImE1Rtklr7MxNeGy7ZCgZD";
            LoginResult result = FacebookWrapper.FacebookService.Connect(token);
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                this.m_LoggedInUser = result.LoggedInUser;
                this.m_AlbumStatisticsResults = new AlbumStatisticsResults(this.m_LoggedInUser.Albums, this.m_DateGroupFormat);
            }
            //this.m_LoggedInUser = formLogin.LoggedInUser;
            this.m_PostsStatisticsResults = new PostsStatisticsResults(this.m_LoggedInUser.Posts, this.m_DateGroupFormat);
            this.m_AlbumStatisticsResults = new AlbumStatisticsResults(this.m_LoggedInUser.Albums, this.m_DateGroupFormat);
            this.m_LikedPagesStatisticsResult = new LikedPagesStatisticsResult(m_LoggedInUser.LikedPages, this.m_DateGroupFormat);


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