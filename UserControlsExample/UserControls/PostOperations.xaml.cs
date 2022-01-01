using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace UserControlsExample.UserControls
{
    /// <summary>
    /// Interaction logic for PostOperations.xaml
    /// </summary>
    public partial class PostOperations : UserControl
    {
        public PostOperations()
        {
            InitializeComponent();
        }

        public bool IsPostLiked { get; set; }

        private void Heart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(!IsPostLiked)
            {
                LikePost();
            }
            else
            {
                UnLikePost();
            }
        }

        public void LikePost()
        {
            Heart.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\..\..\Icons\like.png", UriKind.RelativeOrAbsolute));
            IsPostLiked = true;
        }

        public void UnLikePost()
        {
            Heart.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\..\..\Icons\nolike.png", UriKind.RelativeOrAbsolute));
            IsPostLiked = false;
        }


    }
}
