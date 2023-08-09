using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobPhone.Custom
{
    class CustomEditText : Frame
    {
        public static readonly BindableProperty LabelTextData = BindableProperty.Create(nameof(LabelText), typeof(string), typeof(CustomEditText), "default");
        public static readonly BindableProperty LabelFontSize = BindableProperty.Create(nameof(LabelTextSize), typeof(int), typeof(CustomEditText), 16);
        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(ImageSource), typeof(CustomEditText), default(ImageSource));
        public static readonly BindableProperty isRequiredProperty = BindableProperty.Create(nameof(isRequired), typeof(bool), typeof(CustomEditText), defaultValue: false);
        public static readonly BindableProperty iconVisibleProperty = BindableProperty.Create(nameof(iconVisible), typeof(bool), typeof(CustomEditText), true);
        public CustomEditText()
        {

            var label = new Label();
            label.SetBinding(Label.TextProperty, new Binding(nameof(LabelText), source: this));
            label.SetBinding(Label.FontSizeProperty, new Binding(nameof(LabelTextSize), source: this));
            label.Style = (Style)App.Current.Resources["RegularText"];
            label.VerticalOptions = LayoutOptions.Center;

            var icon = new Image();
            icon.SetBinding(Image.SourceProperty, new Binding(nameof(ImageSource), source: this));
            icon.SetBinding(Image.IsVisibleProperty, new Binding(nameof(iconVisible), source: this));
            icon.HorizontalOptions = LayoutOptions.Start;

            var star = new Image();
            //icon.SetBinding(Image.SourceProperty, new Binding(nameof(ImageSource), source: this));
            star.Source = "star";
            star.SetBinding(Image.IsVisibleProperty, new Binding(nameof(isRequired), source: this));
            star.HorizontalOptions = LayoutOptions.EndAndExpand;
                                       
            var stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Children = { icon, label, star },
                BackgroundColor = Color.Transparent,
            };

            var mainFrame = new Frame();
            mainFrame.BackgroundColor = Color.FromHex("E6E4FF");
            mainFrame.Content = stackLayout;
            mainFrame.CornerRadius = 12;
            mainFrame.HasShadow = false;
            
            Content = mainFrame;
        }

        public bool iconVisible
        {
            get { return (bool)GetValue(iconVisibleProperty); }
            set { SetValue(iconVisibleProperty, value); }
        }

        public bool isRequired
        {
            get { return (bool)GetValue(isRequiredProperty); }
            set { SetValue(isRequiredProperty, value); }
        }
        public string LabelText
        {
            get { return (string)GetValue(LabelTextData); }
            set { SetValue(LabelTextData, value); }
        }

        public int LabelTextSize
        {
            get { return (int)GetValue(LabelFontSize); }
            set { SetValue(LabelFontSize, value); }
        }

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

    }
}
