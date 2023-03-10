using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using RedLib;

namespace Resource.Server
{
    public class ServerMain : BaseScript
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
        public static void Test() => Print.Log("Hello From Test");

    }
}
