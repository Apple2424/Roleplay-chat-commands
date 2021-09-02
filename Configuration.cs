﻿using Rocket.API;

namespace RoleplayCommands
{
    public class Configuration : IRocketPluginConfiguration

    {

        public string MeImgUrl;
        public string MeFormat;
        public string DoImgUrl;
        public string DoFormat;
        public string TweetImgUrl;
        public string TweetFormat;
        public string OocImgUrl;
        public string OocFormat;
        public string AnonImgUrl;
        public string AnonFormat;

        public void LoadDefaults()
        {
            MeImgUrl = "IMAGEURL";
            MeFormat = "{color=red}[{/color}ME{color=red}]{/color} !playerName!: !text!";
            DoImgUrl = "IMAGEURL";
            DoFormat = "{color=red}[{/color}DO{color=red}]{/color} !playerName!: !text!";
            TweetImgUrl = "IMAGEURL";
            TweetFormat = "{color=red}[{/color}Tweet{color=red}]{/color} !playerName!: !text!";
            OocImgUrl = "IMAGEURL";
            OocFormat = "{color=red}[{/color}OOC{color=red}]{/color} !playerName!: !text!";
            AnnonImgUrl = "IMAGEURL";
            AnnonFormat = "{color=red}[{/color}OOC{color=red}]{/color} !playerName!: !text!";
        }
    }
}