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
    public static class Nui
    {
        public static bool Ready { get; private set; } = false;
        public static readonly Dictionary<string, Func<IDictionary<string, object>, CallbackDelegate, bool>> Calls = new Dictionary<string, Func<IDictionary<string, object>, CallbackDelegate, bool>>
        {
            ["ready"] = (IDictionary<string, object> _data, CallbackDelegate _cb) => { Ready = true; _cb(new { result = "Recived;" }); return true; },
            ["defocus"] = (IDictionary<string, object> _data, CallbackDelegate _cb) => { Lib.SetNuiFocus(false, false); _cb(new { result = "Recived;" }); return true; },
        };
        /// <summary>
        /// On nui message event
        /// </summary>
        /// <param name="_data">The message from the nui</param>
        /// <param name="_cb">The nui's callback event</param>
        public static void On_Message(IDictionary<string, object> _data, CallbackDelegate _cb)
        {
            // if no call type return error...
            if (!_data.TryGetValue("call", out object calltype)) { Print.Error("Nui message > Missing call!"); _cb(new { error = "Missing call!" }); return; }
            // cast away
            string call = (calltype as string) ?? "";
            // call
            if (Calls.ContainsKey(call))
            {
                // invoke call with data and _cb with the result
                Calls[call].Invoke(_data, _cb); return;
            }
            // unknown type?
            _cb(new { error = $"Unknown call {call}" });
        }
        /// <summary>
        /// Sends object as Json to the nui
        /// </summary>
        /// <param name="_data">object that can be converted to Json</param>
        /// <returns>If sent it will return true else it returns false</returns>
        public static async void Send(object _data)
        {
            // await ready state
            while (!Ready)
            {
                await BaseScript.Delay(500);
                Print.Warn("awaiting nui!");
            }
            // send
            Lib.SendNuiMessage(JsonConvert.SerializeObject(_data));
        }
    }
}
