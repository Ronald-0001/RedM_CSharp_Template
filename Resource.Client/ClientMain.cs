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
            
            
            // example nui > script call
            Nui.Calls.Add("Test", (object _data, CallbackDelegate _cb) => {
                // handle data
                Print.Log(JsonConvert.SerializeObject(_data));
                // return result to nui
                _cb(new { result = "Recived;" });
                // end CallbackDelegate
                return true;
            });


            // example script > nui call
            Nui.Send(new { call = "Test", data = "Test sendt from the script" });
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
