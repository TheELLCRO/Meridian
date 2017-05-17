﻿using System;
using EchonestApi;
using LastFmLib;
using Meridian.Services;
using Meridian.ViewModel.Main;
using VkLib;
using Meridian.Domain;

namespace Meridian.ViewModel
{
    public class ViewModelLocator
    {
        private static Lazy<MainViewModel> _main = new Lazy<MainViewModel>(() => new MainViewModel());
        private static Lazy<NowPlayingViewModel> _nowPlaying = new Lazy<NowPlayingViewModel>(() => new NowPlayingViewModel());
        private static readonly Vkontakte _vkontakte = new Vkontakte("3697615", "AlVXZFMUqyrnABp8ncuU", "5.28");//new Vkontakte("2635307", "aNq5ZwcnrfE8qhhMxkJf", "5.28");
        private static readonly LastFm _lastFm = new LastFm("a012acc1e5f8a61bc7e58238ce3021d8", "86776d4f43a72633fb37fb28713a7798");
        private static readonly Echonest _echonest = new Echonest("RSKOILYE1AHENGSO8");
        private static readonly UpdateService _updateService = new UpdateService();

        public static MainViewModel Main
        {
            get { return _main.Value; }
        }

        public static NowPlayingViewModel NowPlaying
        {
            get { return _nowPlaying.Value; }
        }

        public static Vkontakte Vkontakte
        {
            get { return _vkontakte; }
        }

        public static LastFm LastFm
        {
            get { return _lastFm; }
        }

        public static Echonest Echonest
        {
            get { return _echonest; }
        }

        public static UpdateService UpdateService
        {
            get { return _updateService; }
        }

        public ViewModelLocator()
        {

        }
    }
}
