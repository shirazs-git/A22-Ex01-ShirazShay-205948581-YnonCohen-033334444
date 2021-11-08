using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class LikedPagesStatisticsResults
    {
        private Dictionary<string, int> m_TotalPagesByCategory;

        private readonly FacebookObjectCollection<Page> r_LikedPagesCollection;

        public Dictionary<string, int> TotalPagesByCategory
        {
            get
            {
                return m_TotalPagesByCategory;
            }
        }

        private void fetchTotalLikedPagesByCategory()
        {
            this.TotalPagesByCategory.Clear();

            var queryLikedPagesByCategory = from page in this.r_LikedPagesCollection

                                            group page by page.Category
                                            into groupByCategory
                                            select new
                                                       {
                                                           category = (groupByCategory.Key ?? "null")
                                                           ,totalPages = groupByCategory.Count()

                                                       };
            foreach (var categoryGroup in queryLikedPagesByCategory)
            {
                this.m_TotalPagesByCategory.Clear();
                StatisticsCalc.InsertIntoDictionaryWithIntValue(this.m_TotalPagesByCategory, categoryGroup.category, categoryGroup.totalPages);
            }

        }

        public LikedPagesStatisticsResults(FacebookObjectCollection<Page> i_LikedPageses)
        {
            this.m_TotalPagesByCategory = new Dictionary<string, int>();
            this.r_LikedPagesCollection = i_LikedPageses;

            this.fetchTotalLikedPagesByCategory();

        }


    }
}