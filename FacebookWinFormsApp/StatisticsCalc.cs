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
        private AlbumStatisticsCalc m_AlbumStatisticsCalc;
        private LikedPagesStatisticsCalc m_LikedPagesStatisticsCalc;
        private PostsStatisticsCalc m_PostsStatisticsCalc;
        
        
    

        public LikedPagesStatisticsCalc LikedPagesStatisticsCalc
        {
            get
            {
                return m_LikedPagesStatisticsCalc;
            }
        }

        public AlbumStatisticsCalc AlbumStatisticsCalc
        {
            get
            {
                return m_AlbumStatisticsCalc;
            }
        }

        public PostsStatisticsCalc PostsStatisticsCalc
        {
            get
            {
                return m_PostsStatisticsCalc;
            }
        }



        public StatisticsCalc(string i_GroupByDateFormat="yyyy")
        {
            this.m_DateGroupFormat = i_GroupByDateFormat;
            //FormLogin formLogin = new FormLogin();
           
            string token = "EAAEFuZBc7ZCo4BACZBax6pMzzZB6kjra9QQYfC9M4DnuemXgZAmdTFCiKvKajN7TrdB4nr1gnU7XZAEgCW86a7ZAKeKvXglZBRXZAVySXVH12Xv1wSZBPM9AUW7w44xT1oY9X0beAeweDkCLhZCg5mynOu6IcMxOuD5HXF7foIlHZCwZCnyJLb26Nh7zquHUPjavqMKUkfj3amBTf5vsVImE1Rtklr7MxNeGy7ZCgZD";
            LoginResult result = FacebookWrapper.FacebookService.Connect(token);
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                this.m_LoggedInUser = result.LoggedInUser;
                this.m_AlbumStatisticsCalc = new AlbumStatisticsCalc(this.m_LoggedInUser.Albums, this.m_DateGroupFormat);
            }
            //this.m_LoggedInUser = formLogin.LoggedInUser;
            this.m_PostsStatisticsCalc = new PostsStatisticsCalc(this.m_LoggedInUser.Posts, this.m_DateGroupFormat);
            this.m_AlbumStatisticsCalc = new AlbumStatisticsCalc(this.m_LoggedInUser.Albums, this.m_DateGroupFormat);
            this.m_LikedPagesStatisticsCalc = new LikedPagesStatisticsCalc(m_LoggedInUser.LikedPages);


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