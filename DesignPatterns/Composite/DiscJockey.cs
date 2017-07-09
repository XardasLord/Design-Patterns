using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class DiscJockey
    {
        private SongComponent _songList;

        public DiscJockey(SongComponent songList)
        {
            _songList = songList;
        }

        public void GetSongList()
        {
            _songList.DisplaySongInfo();
        }
    }
}
