using System.Windows;
using System.Windows.Media;

namespace PhoneCommon
{
    public static class ThemeResources
    {
        #region Brush Resources

        public static SolidColorBrush PhoneForegroundBrush
        {
            get { return GetResource<SolidColorBrush>("PhoneForegroundBrush"); }
        }

        public static SolidColorBrush PhoneBackgroundBrush
        {
            get { return GetResource<SolidColorBrush>("PhoneBackgroundBrush"); }
        }

        public static SolidColorBrush PhoneAccentBrush
        {
            get { return GetResource<SolidColorBrush>("PhoneAccentBrush"); }
        }

        public static SolidColorBrush PhoneDisabledBrush
        {
            get { return GetResource<SolidColorBrush>("PhoneDisabledBrush"); }
        }

        public static SolidColorBrush PhoneSubtleBrush
        {
            get { return GetResource<SolidColorBrush>("PhoneSubtleBrush"); }
        }

        public static SolidColorBrush PhoneSemitransparentBrush
        {
            get { return GetResource<SolidColorBrush>("PhoneSemitransparentBrush"); }
        }

        public static SolidColorBrush PhoneChromeBrush
        {
            get { return GetResource<SolidColorBrush>("PhoneChromeBrush"); }
        }

        #endregion

        #region Color Resources

        public static Color PhoneBackgroundColor
        {
            get { return GetResource<Color>("PhoneBackgroundColor"); }
        }

        public static Color PhoneAccentColor
        {
            get { return GetResource<Color>("PhoneAccentColor"); }
        }

        public static Color PhoneChromeColor
        {
            get { return GetResource<Color>("PhoneChromeColor"); }
        }

        #endregion

        #region Font Names

        public static FontFamily PhoneFontFamilySemiBold
        {
            get { return GetResource<FontFamily>("PhoneFontFamilySemiBold"); }
        }

        public static FontFamily PhoneFontFamilySemiLight
        {
            get { return GetResource<FontFamily>("PhoneFontFamilySemiLight"); }
        }

        #endregion

        #region Font Sizes

        public static double PhoneFontSizeSmall
        {
            get { return GetResource<double>("PhoneFontSizeSmall"); }
        }

        public static double PhoneFontSizeNormal
        {
            get { return GetResource<double>("PhoneFontSizeNormal"); }
        }

        public static double PhoneFontSizeMedium
        {
            get { return GetResource<double>("PhoneFontSizeMedium"); }
        }

        public static double PhoneFontSizeMediumLarge
        {
            get { return GetResource<double>("PhoneFontSizeMediumLarge"); }
        }

        public static double PhoneFontSizeLarge
        {
            get { return GetResource<double>("PhoneFontSizeLarge"); }
        }

        public static double PhoneFontSizeExtraLarge
        {
            get { return GetResource<double>("PhoneFontSizeExtraLarge"); }
        }

        public static double PhoneFontSizeExtraExtraLarge
        {
            get { return GetResource<double>("PhoneFontSizeExtraExtraLarge"); }
        }

        public static double PhoneFontSizeHuge
        {
            get { return GetResource<double>("PhoneFontSizeHuge"); }
        }

        #endregion

        #region Text Styles

        public static Style PhoneTextBlockBase
        {
            get { return GetResource<Style>("PhoneTextBlockBase"); }
        }

        public static Style PhoneTextNormalStyle
        {
            get { return GetResource<Style>("PhoneTextNormalStyle"); }
        }

        public static Style PhoneTextSubtleStyle
        {
            get { return GetResource<Style>("PhoneTextSubtleStyle"); }
        }

        public static Style PhoneTextTitle1Style
        {
            get { return GetResource<Style>("PhoneTextTitle1Style"); }
        }

        public static Style PhoneTextTitle2Style
        {
            get { return GetResource<Style>("PhoneTextTitle2Style"); }
        }

        public static Style PhoneTextTitle3Style
        {
            get { return GetResource<Style>("PhoneTextTitle3Style"); }
        }

        public static Style PhoneTextSmallStyle
        {
            get { return GetResource<Style>("PhoneTextSmallStyle"); }
        }

        public static Style PhoneTextLargeStyle
        {
            get { return GetResource<Style>("PhoneTextLargeStyle"); }
        }

        public static Style PhoneTextExtraLargeStyle
        {
            get { return GetResource<Style>("PhoneTextExtraLargeStyle"); }
        }

        public static Style PhoneTextGroupHeaderStyle
        {
            get { return GetResource<Style>("PhoneTextGroupHeaderStyle"); }
        }

        public static Style PhoneTextContrastStyle
        {
            get { return GetResource<Style>("PhoneTextContrastStyle"); }
        }

        public static Style PhoneTextAccentStyle
        {
            get { return GetResource<Style>("PhoneTextAccentStyle"); }
        }

        public static Style PhoneTextHugeStyle
        {
            get { return GetResource<Style>("PhoneTextHugeStyle"); }
        }

        #endregion

        #region Theme Visibility and Opacity

        public static Visibility PhoneDarkThemeVisibility
        {
            get { return GetResource<Visibility>("PhoneDarkThemeVisibility"); }
        }

        public static bool IsDarkTheme
        {
            get { return PhoneDarkThemeVisibility == Visibility.Visible; }
        }

        #endregion

        #region Additional Resources

        private static readonly SolidColorBrush BlackBrush = new SolidColorBrush(Colors.Black);
        private static readonly SolidColorBrush WhiteBrush = new SolidColorBrush(Colors.White);

        public static SolidColorBrush PhoneContextMenuBackgroundBrush
        {
            get { return IsDarkTheme ? WhiteBrush : BlackBrush; }
        }

        #endregion

        private static T GetResource<T>(string key)
        {
            return (T)Application.Current.Resources[key];
        }
    }
}
