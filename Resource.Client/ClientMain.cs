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

        public ClientMain()
        {
            // nui setup
            Lib.RegisterNuiCallbackType("message");
            EventHandlers["__cfx_nui:message"] += new Action<IDictionary<string, object>, CallbackDelegate>(Nui.On_Message);
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
