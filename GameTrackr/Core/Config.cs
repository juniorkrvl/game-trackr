using GameTrackr.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GameTrackr.Core
{
    class Configuration
    {
        public static Model.Config config;

        public static void LoadConfig()
        {
            if (!File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\config.gtkr"))
            {
                config = new Model.Config();
                config.platforms.Add(new Platform("Sony PSP",Platform.Type.PSP));
                config.platforms.Add(new Platform("Sony Playstation",Platform.Type.PSOne));
                config.platforms.Add(new Platform("Nintendo Game Boy Advance",Platform.Type.GBA));
                Serialize(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\config.gtkr", config);
            }
            else
            {
                config = Deserialize(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\config.gtkr");
            }
        }

        public static void SaveConfig()
        {
            Serialize(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\config.gtkr", config);
        }

        private static void Serialize(string path, GameTrackr.Model.Config config)
        {
            byte[] obj = ObjToByteArray(config);
            File.WriteAllBytes(path, obj);
        }

        private static GameTrackr.Model.Config Deserialize(string path)
        {
            object obj = File.ReadAllBytes(path);
            return (GameTrackr.Model.Config)ByteArrayToObj((byte[])obj);
        }

        private static byte[] ObjToByteArray(object obj)
        {
            try
            {
                if ((obj == null))
                    return null;
                BinaryFormatter bf = new BinaryFormatter();
                MemoryStream ms = new MemoryStream();
                bf.Serialize(ms, obj);
                return ms.ToArray();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private static object ByteArrayToObj(byte[] obj)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            ms.Write(obj, 0, obj.Length);
            ms.Seek(0, SeekOrigin.Begin);
            object o = bf.Deserialize(ms);
            return o;
        }




    }
}
