using MusicStore_blazor.Models;
using System;

namespace MusicStore_blazor.Stores.AlbumStore
{
    public class AlbumListState
    {
        public Album[] AlbumList { get; set; }

        public AlbumListState()
        {

        }

        public AlbumListState(Album[] albumList)
        {
            AlbumList = albumList;
        }
    }

    public class AlbumListStore
    {
        private AlbumListState _state;
        private Action _listeners;

        public AlbumListStore()
        {
            _state = new AlbumListState();
        }

        public AlbumListState GetAlbumStateList()
        {
            return _state;
        }

        public void GetList(Album[] albumList)
        {
            _state = new AlbumListState(albumList);
            _listeners?.Invoke();
        }

        public void AddStateChangeListeners(Action listener)
        {
            _listeners += listener;
        }

        public void RemoveStateChangeListeners(Action listener)
        {
            _listeners -= listener;
        }
    }
}
