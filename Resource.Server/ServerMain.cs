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

        public ServerMain() => _ = Init();
        private async Task Init()
        {
            // example code
            await Delay(100);
            Print.Log("Booting...");
        }

        // example command
        [Command("test2")]
        public static void Test(/*int src, List<object> args, string raw*/) => Print.Log("Hello From Test");

    }
}
