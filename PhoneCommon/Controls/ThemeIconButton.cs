using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PhoneCommon.Controls
{
    public class ThemeIconButton : HyperlinkButton
    {
        public ThemeIconButton()
        {
            this.DefaultStyleKey = typeof(ThemeIconButton);
        }

        #region public ImageSource DarkImageSource

        public ImageSource DarkImageSource
        {
            get { return (ImageSource)GetValue(DarkImageSourceProperty); }
            set { SetValue(DarkImageSourceProperty, value); }
        }

        public static readonly DependencyProperty DarkImageSourceProperty = DependencyProperty.Register(
            "DarkImageSource",
            typeof(ImageSource),
            typeof(ThemeIconButton),
            null);

        #endregion

        #region public ImageSource LightImageSource

        public ImageSource LightImageSource
        {
            get { return (ImageSource)GetValue(LightImageSourceProperty); }
            set { SetValue(LightImageSourceProperty, value); }
        }

        public static readonly DependencyProperty LightImageSourceProperty = DependencyProperty.Register(
            "LightImageSource",
            typeof(ImageSource),
            typeof(ThemeIconButton),
            null);

        #endregion
    }
}
