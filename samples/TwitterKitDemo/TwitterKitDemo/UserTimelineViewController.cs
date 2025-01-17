﻿using System;
using Foundation;
using MonoTouch.Fabric.TwitterCore;
using MonoTouch.Fabric.TwitterKit;

namespace TwitteKitDemo
{
    public class UserTimelineViewController: TWTRTimelineViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var twitter = MonoTouch.Fabric.TwitterKit.Twitter.SharedInstance;
            twitter.LogInGuestWithCompletion((TWTRGuestSession session, NSError error) =>
                {
                    this.DataSource = new MonoTouch.Fabric.TwitterKit.TWTRUserTimelineDataSource("fabric", twitter.APIClient);
                });

            this.ShowTweetActions = true;
        }
    }
}

