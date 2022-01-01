using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserControlsExample.Models;

namespace UserControlsExample.UserControls
{
    /// <summary>
    /// Interaction logic for VideoPost.xaml
    /// </summary>
    public partial class VideoPost : UserControl
    {
        public VideoPost(VideoPostModel videoModel)
        {
            InitializeComponent();
            VideoPlayer.Source = videoModel.VideoPlayersSource;
        }

        private void ContentControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (!PostsOp.IsPostLiked)
                PostsOp.LikePost();
            else
                PostsOp.UnLikePost();
        }
    }
}
