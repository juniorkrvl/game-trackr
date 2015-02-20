using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrackr.Model
{
    [Serializable]
    class Config
    {

        public Config()
        {
            platforms = new List<Platform>();
        }

        public List<Platform> platforms { get; set; }

        public Platform GetPlatform(Platform.Type type)
        {
            return platforms.Where(x => x.type == type).FirstOrDefault();
        }

    }
}
