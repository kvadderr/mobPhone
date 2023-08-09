using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using Xamarin.CommunityToolkit.Effects;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace MobPhone.Custom
{
    public class CustomMenuButton : Frame
    {
        private Frame frame = new Frame();
        private Label label = new Label();
        private Frame mainFrame = new Frame();
        private Image icon = new Image();
        private Frame notificationFrame = new Frame();

        public event EventHandler Pressed;
        public event EventHandler Released;

        public Action PressedAction { get; set; }
        
        public static readonly BindableProperty LabelTextProperty = BindableProperty.Create(nameof(LabelText), typeof(string), typeof(CustomEditText), "default");
        public static readonly BindableProperty LabelFontSizeProperty = BindableProperty.Create(nameof(LabelFontSize), typeof(int), typeof(CustomEditText), 14);
        public static readonly BindableProperty FrameSizeProperty = BindableProperty.Create(nameof(FrameSize), typeof(int), typeof(CustomEditText), 16);
        public static readonly BindableProperty ImageSourceNormalProperty = BindableProperty.Create(nameof(ImageSourceNormal), typeof(ImageSource), typeof(CustomEditText), default(ImageSource));
        public static readonly BindableProperty ImageSourceActiveProperty = BindableProperty.Create(nameof(ImageSourceActive), typeof(ImageSource), typeof(CustomEditText), default(ImageSource));
        public static readonly BindableProperty ParentFrameProperty = BindableProperty.Create(nameof(ParentFrame), typeof(Frame), typeof(CustomEditText), default(Frame));
        public static readonly BindableProperty ViewContentProperty = BindableProperty.Create(nameof(ViewContent), typeof(View), typeof(CustomEditText), default(View));
        public static readonly BindableProperty IsNotificationProperty = BindableProperty.Create(nameof(IsNotification), typeof(bool), typeof(CustomEditText), false);

        public virtual void OnPressed()
        {
            Pressed?.Invoke(this, EventArgs.Empty);
            frame.BackgroundColor = Color.FromHex("#9c93fd");
            label.TextColor = Color.White;
            mainFrame.Background = (Brush)App.Current.Resources["blueGradient"];
            icon.SetBinding(Image.SourceProperty, new Binding(nameof(ImageSourceActive), source: this));
        }

        public virtual void OnReleased()
        {
            Released?.Invoke(this, EventArgs.Empty);
            PressedAction?.Invoke();
            frame.BackgroundColor = Color.FromHex("#dedcff");
            label.TextColor = Color.FromHex("#524E7D");
            icon.SetBinding(Image.SourceProperty, new Binding(nameof(ImageSourceNormal), source: this));
            mainFrame.Background = null;
        }

        private void goToFrame()
        {
            
        }

        public CustomMenuButton()
        {
            Padding = 0;
            Margin = 0;
            BackgroundColor = Color.Transparent;
            TouchEffect touchEffect = new TouchEffect();

            frame.CornerRadius = 12; 
            frame.SetBinding(Frame.WidthRequestProperty, new Binding(nameof(FrameSize), source: this));
            frame.SetBinding(Frame.HeightRequestProperty, new Binding(nameof(FrameSize), source: this));
            frame.BackgroundColor = Color.FromHex("#dedcff");
            frame.HasShadow = false;
            frame.Padding = 0;

            icon.SetBinding(Image.SourceProperty, new Binding(nameof(ImageSourceNormal), source: this));
            icon.HorizontalOptions = LayoutOptions.Center;
            icon.VerticalOptions = LayoutOptions.Center;

            frame.Content = icon;

            //frame.BackgroundColor = Color.FromHex("#7265FB1A");

            label.SetBinding(Label.TextProperty, new Binding(nameof(LabelText), source: this));
            label.SetBinding(Label.FontSizeProperty, new Binding(nameof(LabelFontSize), source: this));
            label.Style = (Style)App.Current.Resources["RegularText"];
            label.VerticalTextAlignment = TextAlignment.Center;

            notificationFrame.CornerRadius = 100;
            notificationFrame.Background = (Brush)App.Current.Resources["redGradient"];
            notificationFrame.HorizontalOptions = LayoutOptions.EndAndExpand;
            notificationFrame.VerticalOptions = LayoutOptions.Center;
            notificationFrame.WidthRequest = 18;
            notificationFrame.HeightRequest = 18;
            notificationFrame.Padding = 0;
            notificationFrame.HasShadow = false;
            notificationFrame.SetBinding(Frame.IsVisibleProperty, new Binding(nameof(IsNotification), source: this));

            Label labelNotofication = new Label();
            labelNotofication.Text = "1";
            labelNotofication.TextColor = Color.White;
            labelNotofication.FontSize = 9;
            labelNotofication.HorizontalTextAlignment = TextAlignment.Center;
            labelNotofication.VerticalTextAlignment = TextAlignment.Center;
            labelNotofication.Style = (Style)App.Current.Resources["MediumText"];

            notificationFrame.Content = labelNotofication;

            var stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Spacing = 12,
                Children = { frame, label, notificationFrame},
                BackgroundColor = Color.Transparent,
            };

            mainFrame.BackgroundColor = Color.FromHex("E6E4FF");
            mainFrame.Content = stackLayout;
            mainFrame.CornerRadius = 12;
            mainFrame.HasShadow = false;
            mainFrame.Padding = new Thickness(7, 7, 20, 7);
            Content = mainFrame;

        }

        public Frame ParentFrame
        {
            get { return (Frame)GetValue(ParentFrameProperty); }
            set { SetValue(ParentFrameProperty, value); }
        }

        public View ViewContent
        {
            get { return (View)GetValue(ViewContentProperty); }
            set { SetValue(ViewContentProperty, value); }
        }

        public ImageSource ImageSourceNormal
        {
            get { return (ImageSource)GetValue(ImageSourceNormalProperty); }
            set { SetValue(ImageSourceNormalProperty, value); }
        }

        public ImageSource ImageSourceActive
        {
            get { return (ImageSource)GetValue(ImageSourceActiveProperty); }
            set { SetValue(ImageSourceActiveProperty, value); }
        }

        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        public int LabelFontSize
        {
            get { return (int)GetValue(LabelFontSizeProperty); }
            set { SetValue(LabelFontSizeProperty, value); }
        }

        public bool IsNotification
        {
            get { return (bool)GetValue(IsNotificationProperty); }
            set { SetValue(IsNotificationProperty, value); }
        }

        public int FrameSize
        {
            get { return (int)GetValue(FrameSizeProperty); }
            set { SetValue(FrameSizeProperty, value); }
        }

    }
}
