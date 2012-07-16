using System.Windows;
using System.Windows.Controls;

namespace PhoneCommon.Controls
{
    public class Tile : HyperlinkButton
    {
        public Tile()
        {
            this.DefaultStyleKey = typeof(Tile);
        }

        #region public string Title

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            "Title",
            typeof(string),
            typeof(Tile),
            new PropertyMetadata(string.Empty));

        #endregion
    }
}
