﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediaManager.Media;
using MediaManager.Playback;
using MediaManager.Video;

namespace MediaManager.Platforms.Android.Video
{
    public class VideoPlayer : Java.Lang.Object, IVideoPlayer
    {
        public Dictionary<string, string> RequestHeaders { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MediaPlayerState State => throw new NotImplementedException();

        public TimeSpan Position => throw new NotImplementedException();

        public TimeSpan Duration => throw new NotImplementedException();

        public TimeSpan Buffered => throw new NotImplementedException();

        public event BeforePlayingEventHandler BeforePlaying;
        public event AfterPlayingEventHandler AfterPlaying;

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public Task Pause()
        {
            throw new NotImplementedException();
        }

        public Task Play(string Url)
        {
            throw new NotImplementedException();
        }

        public Task Play()
        {
            throw new NotImplementedException();
        }

        public Task Seek(TimeSpan position)
        {
            throw new NotImplementedException();
        }

        public Task Stop()
        {
            throw new NotImplementedException();
        }
    }
}
