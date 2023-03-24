using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CitizenFX.Core;
using RedLib;

namespace Resource.Client
{
    public class ClientMain : ClientScript
    {
        public static ClientMain Instance { get; private set; }
        public static EventHandlerDictionary EventRegistry => Instance.EventHandlers;
        public static ExportDictionary ExportRegistry => Instance.Exports;
        public ClientMain()
        {
            Instance = this;
            //
            _ = Init();
        }
        private async Task Init()
        {
            await Nui.Init();
            //await Delay(100);
        }

        // example command
        [Command("test1")]
        public static void Test(/*int src, List<object> args, string raw*/) => Print.Log("Hello From Test");

        // example tick
        [Tick]
        public static async Task OnTick()
        {
            await Delay(0);
        }

    }
}
