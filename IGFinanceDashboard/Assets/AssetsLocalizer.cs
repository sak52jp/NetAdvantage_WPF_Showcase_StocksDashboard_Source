using IGExtensions.Common.Assets;
using IGExtensions.Common.Assets.Resources;
using IGShowcase.FinanceDashboard.Assets.Resources;

namespace IGShowcase.FinanceDashboard.Assets
{
    /// <summary>
    /// Represents an assets localizer that provides access to the application <see cref="Strings"/> 
    /// as well as to the <see cref="CommonStrings"/> 
    /// </summary>
    public class AssetsLocalizer : CommonLocalizer // provides access to CommonStrings
    {
        private static readonly Strings StringAssets = new Strings(); 
         
        //public AssetsLocalizer()
        //{
        //}

        public Strings Strings
        {
            get { return StringAssets; }
        }

      
    }
}