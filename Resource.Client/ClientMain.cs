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

        public ClientMain() => _ = Init();
        private async Task Init()
        {
            // example code
            await Delay(100);
            Print.Log("Booting...");
            Lib.SendNuiMessage(JsonConvert.SerializeObject(new { type = "init" }));
        }

        // example command
        [Command("test1")]
        public static void Test() => Print.Log("Hello From Test");

        // example tick
        [Tick]
        public static async Task OnTick()
        {
            await Delay(0);
        }

    }
}
