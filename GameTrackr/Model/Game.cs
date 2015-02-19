using GameTrackr.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrackr.Model
{
    class Game
    {

        public Game()
        {
            images = new List<GameImage>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string releaseDate { get; set; }
        public int platformId { get; set; }
        public string platform { get; set; }
        public string publisher { get; set; }
        public string developer { get; set; }
        public string overview { get; set; }
        public string coop { get; set; }
        public string esrb { get; set; }

        public List<GameImage> images { get; set; }

        public GameImage GetFrontBox()
        {
            if (images != null)
                return images.Where(x => x.side == "front").FirstOrDefault();
            else
                return null;
        }

        public GameImage GetBackBox()
        {
            if (images != null)
                return images.Where(x => x.side == "back").FirstOrDefault();
            else
                return null;
        }

        public void GetInfo()
        {
            try
            {
                Game gm = Wrapper.GetGame(this.id);
                this.id = gm.id;
                this.name = gm.name;
                this.releaseDate = gm.releaseDate;
                this.platformId = gm.platformId;
                this.platform = gm.platform;
                this.publisher = gm.publisher;
                this.developer = gm.developer;
                this.overview = gm.overview;
                this.coop = gm.coop;
                this.esrb = gm.esrb;
                this.images = gm.images;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

    class GameImage
    {
        public string original { get; set; }
        public string thumb { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string side { get; set; }
        public string type { get; set; }
    }

}
