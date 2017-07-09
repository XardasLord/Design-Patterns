using System;

namespace Composite
{
    abstract class SongComponent
    {
        public virtual void Add(SongComponent newSongComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(SongComponent newSongComponent)
        {
            throw new NotSupportedException();
        }

        public virtual SongComponent GetComponent(int componentIndex)
        {
            throw new NotSupportedException();
        }

        public string GetSongName()
        {
            throw new NotSupportedException();
        }

        public string GetBandName()
        {
            throw new NotSupportedException();
        }

        public int GetReleaseYear()
        {
            throw new NotSupportedException();
        }

        public abstract void DisplaySongInfo();
    }
}
