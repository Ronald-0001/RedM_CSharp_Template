# nui setup
```c#
Lib.RegisterNuiCallbackType("message");
EventHandlers["__cfx_nui:message"] += new Action<IDictionary<string, object>, CallbackDelegate>(Nui.On_Message);
```

# example nui > script call
```c#
Nui.Calls.Add("Test", (IDictionary<string, object> _data, CallbackDelegate _cb) => {
    // handle data
    Print.Log(JsonConvert.SerializeObject(_data));
    // return result to nui
    _cb(new { result = "Recived;" });
    // end CallbackDelegate
    return true;
});
```

# example script > nui call
```c#
Nui.Send(new { call = "Test", data = "Test sendt from the script" });
```