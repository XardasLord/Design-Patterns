using System;
using System.Collections;
using System.Collections.Generic;
namespace Composite
{
    class SongGroup : SongComponent
    {
        private ArrayList _songComponents = new ArrayList();

        public string GroupName { get; private set; }
        public string GroupDescripton { get; private set; }

        public SongGroup(string groupName, string groupDescription)
        {
            GroupName = groupName;
            GroupDescripton = groupDescription;
        }

        public override void Add(SongComponent newSongComponent)
        {
            _songComponents.Add(newSongComponent);
        }

        public override void Remove(SongComponent newSongComponent)
        {
            _songComponents.Remove(newSongComponent);
        }

        public override SongComponent GetComponent(int componenIndex)
        {
            return (SongComponent)_songComponents[componenIndex];
        }

        public override void DisplaySongInfo()
        {
            Console.WriteLine($"{GroupName} {GroupDescripton} ");
            Console.WriteLine();

            foreach (var songComponent in _songComponents)
            {
                SongComponent songInfo = (SongComponent)songComponent;
                songInfo.DisplaySongInfo();
            }
        }
    }
}
