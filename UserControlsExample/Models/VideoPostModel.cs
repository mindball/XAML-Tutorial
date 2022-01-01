using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControlsExample.MockDB;

namespace UserControlsExample.Models
{
    public class VideoPostModel
    {
        private Uri _videoPlayersSource;

        public Uri VideoPlayersSource
        {
            get
            {
                if (_videoPlayersSource == null)
                    return MockDb.GetPostVideo();
                else
                    return _videoPlayersSource;
            }
            set
            {
                _videoPlayersSource = value;
            }
        }
    }
}
