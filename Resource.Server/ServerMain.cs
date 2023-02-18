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

        public ServerMain()
        {
            // example code
            _ = Init();
            Print.Log("Booting...");
            return;
        }

        private async Task Init()
        {
            // example code
            await Delay(100);
            return;
        }

        [Command("test2")]
        public void Test()
        {
            // example code
            // Debug.WriteLine("HELLO WORLD!");
            return;
        }

        [Tick]
        private static async Task OnTick()
        {
            // example code
            // Debug.WriteLine("HELLO WORLD!");
            return;
        }

    }
}
