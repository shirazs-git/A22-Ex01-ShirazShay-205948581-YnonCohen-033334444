using System.Drawing;
using System.Drawing.Text;

namespace BasicFacebookFeatures
{

    public interface IDynamicStatisticsResults
    {
        void FetchDynamicResults(string i_GroupByDateFormat);
    }
}