﻿using SongRedirector.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongRedirector.Models
{
    public class ConfigModel
    {

        public ConfigModel(ILinkConfig linkConfig)
        {
            Config = linkConfig;
            Links = Config.Links.Select(x => new LinkModel(Name, x)).ToList();
        }

        public string Name => Config.Name;

        public IList<LinkModel> Links { get; }

        public ILinkConfig Config {get;}

    }
}
