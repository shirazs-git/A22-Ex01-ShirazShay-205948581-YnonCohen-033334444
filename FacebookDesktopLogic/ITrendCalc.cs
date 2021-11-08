using System.Drawing;
using System.Drawing.Text;

namespace BasicFacebookFeatures
{

    public interface ITrendCalc
    {
        void FetchTrend(string i_GroupByDateFormat);
    }
}