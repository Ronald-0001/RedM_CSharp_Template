// PLEASE DO NOT CHANGE

Nui = {};
// send messages to the script
Nui.Send = (_call, _object, _cb) => {
    try {
        var body = "";
        if (typeof (_object) == "object") {
            _object["call"] = _call;
            body = JSON.stringify(_object);
        } else { body = JSON.stringify({ call: _call, data: _object }) }
        fetch(`https://${GetParentResourceName()}/message`, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json; charset=UTF-8', },
            body: body,
        }).then(_json => _json.json()).then(_object => { if (typeof (_cb) == "function") _cb(_object); });
    } catch (error) {
        console.log(`failed to send call: ${_call}`);
    }
}
Nui.Calls = [];
// handle incomming messages from the script
window.addEventListener('message', (event) => {
    const call = event.data.call;
    if (typeof (call) == "string") {
        for (var key in Nui.Calls) {
            if (key == call) Nui.Calls[key](event);
        }
    }
});
// tell the script the nui is ready
$('document').ready(function () {
    Nui.Send("ready", { calltype: "ready" }, _object => console.log("ready cb", JSON.stringify(_object)));
});



/* Nui examples

// example script > nui call
Nui.Calls["Test"] = (_event) => { console.log("Test call triggered:", JSON.stringify(_event)); };

// example nui > scropt call
Nui.Send("Test", { test: "Test sendt from the nui" }, _cb_event => { console.log("Test cb", JSON.stringify(_cb_event)); });

*/