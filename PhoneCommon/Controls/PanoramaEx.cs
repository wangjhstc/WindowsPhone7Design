using System.Windows;
using Microsoft.Phone.Controls;

namespace PhoneCommon.Controls
{
    public class PanoramaEx : Panorama
    {
        public PanoramaEx()
        {
            this.DefaultStyleKey = typeof(PanoramaEx);
        }

        #region public Thickness TitleMargin

        public Thickness TitleMargin
        {
            get { return (Thickness)GetValue(TitleMarginProperty); }
            set { SetValue(TitleMarginProperty, value); }
        }

        public static readonly DependencyProperty TitleMarginProperty = DependencyProperty.Register(
            "TitleMargin",
            typeof(Thickness),
            typeof(PanoramaEx),
            null);

        #endregion

        protected override DependencyObject GetContainerForItemOverride()
        {
            var container = new PanoramaItem();
            ApplyItemContainerStyle(container);
            return container;
        }
    }
}
