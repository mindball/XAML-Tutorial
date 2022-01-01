﻿using System;
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
    /// Interaction logic for PicturePost.xaml
    /// </summary>
    public partial class PicturePost : UserControl
    {
        public PicturePost(PicturePostModel picModel)
        {
            InitializeComponent();

            ImageOfPost.Source = picModel.PostImage;
        }

        private void ContentControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (!PostOps.IsPostLiked) 
                PostOps.LikePost();
            else 
                PostOps.UnLikePost();
        }
    }
}
