using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using PhoneCommon;
using System.Collections.ObjectModel;

namespace MusicAndVideo.ViewModels
{
    public class MusicViewModel
    {
        private const string WindowsPhoneArtist = "Windows Phone Artist";

        public MusicViewModel()
        {
            Artists = new ObservableCollection<Grouping<string>>();
            Artists.Add(new Grouping<string>("#"));
            for (char c = 'a'; c <= 'z'; c++)
            {
                Artists.Add(new Grouping<string>(c.ToString()));
            }
            Artists[23].Add(WindowsPhoneArtist);
            Artists[3].Add("陳奕迅");
            Artists[26].Add("张雨生");

            Albums = new ObservableCollection<Grouping<Album>>();
            Albums.Add(new Grouping<Album>("#"));
            for (char c = 'a'; c <= 'z'; c++)
            {
                Albums.Add(new Grouping<Album>(c.ToString()));
            }
            Albums[4].Add(new Album { Title = "大海", Artist = "张雨生" });
            Albums[8].Add(new Album { Title = "Sample Music", Artist = WindowsPhoneArtist });

            Songs = new ObservableCollection<Grouping<Song>>();
            Songs.Add(new Grouping<Song>("#"));
            for (char c = 'a'; c <= 'z'; c++)
            {
                Songs.Add(new Grouping<Song>(c.ToString()));
            }
            Songs[1].Add(new Song { Title = "Another Melody Song", Artist = WindowsPhoneArtist });
            Songs[13].Add(new Song { Title = "Melody Song", Artist = WindowsPhoneArtist });
            Songs[18].Add(new Song { Title = "Rhythm Variation", Artist = WindowsPhoneArtist });

            Genres = new ObservableCollection<string>
            {
                "pop", "r&b", "rock"
            };
        }

        public ObservableCollection<Grouping<string>> Artists { get; private set; }

        public ObservableCollection<Grouping<Album>> Albums { get; private set; }

        public ObservableCollection<Grouping<Song>> Songs { get; private set; }

        public ObservableCollection<string> Genres { get; private set; }
    }
}
