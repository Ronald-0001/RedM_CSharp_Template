using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using RedLib;

namespace Resource.Server
{
    public class ServerMain : ServerScript
    {
        public static ServerMain Instance { get; private set; }
        public static PlayerList PlayerList;
        public static EventHandlerDictionary EventRegistry => Instance.EventHandlers;
        public static ExportDictionary ExportRegistry => Instance.Exports;
        public ServerMain()
        {
            Instance = this;
            PlayerList = Players;
            //
            _ = Init();
        }
        private async Task Init()
        {
            //await Oxsql.Init();
            await Delay(100);
        }

        // example command
        [Command("test2")]
        public static void Test(/*int src, List<object> args, string raw*/) => Print.Log("Hello From Test");

    }
}
