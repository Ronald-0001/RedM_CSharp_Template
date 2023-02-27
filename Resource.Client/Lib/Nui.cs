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
        public static readonly Dictionary<string, Func<object, CallbackDelegate, bool>> Calls = new Dictionary<string, Func<object, CallbackDelegate, bool>>
        {
            ["ready"] = (object _data, CallbackDelegate _cb) => { Nui.Ready = true; _cb(new { result = "Recived;" }); return true; }
        };
        /// <summary>
        /// On nui message event
        /// </summary>
        /// <param name="_data">The message from the nui</param>
        /// <param name="_cb">The nui's callback event</param>
        public static void On_Message(IDictionary<string, object> _data, CallbackDelegate _cb)
        {
            // if no call type return error...
            if (!_data.TryGetValue("call", out var calltype)) { Print.Error("Nui message > Missing call!"); _cb(new { error = "Missing call!" }); return; }
            // cast away
            string call = (calltype as string) ?? "";
            // call
            if (Calls.ContainsKey(call))
            {
                // ensure data
                if (!_data.TryGetValue("data", out var data)) { Print.Error($"Nui call {call} > Missing data!"); _cb(new { error = "Missing data!" }); return; }
                // invoke call with data and _cb with the result
                Calls[call].Invoke(data, _cb); return;
            }
            // unknown type?
            _cb(new { error = $"Unknown call {call}" });
        }
        /// <summary>
        /// Sends object as Json to the nui
        /// </summary>
        /// <param name="_data">object that can be converted to Json</param>
        /// <returns>If sent it will return true else it returns false</returns>
        public static async Task<bool> Send(object _data)
        {
            // await ready state
            int i = 0;
            while (!Nui.Ready && i < 500) { i++; await BaseScript.Delay(500); }
            // error out
            if (!Nui.Ready) { Print.Error("Nui never got ready!"); return false; }
            // send
            Lib.SendNuiMessage(JsonConvert.SerializeObject(_data));
            return true;
        }
    }
}
