// main script

// example script > nui call
Nui.Calls["Test"] = (_event) => { console.log("Test call triggered:", JSON.stringify(_event)); };

// example nui > scropt call
Nui.Send("Test", { test: "Test sendt from the nui" }, _cb_event => { console.log("Test cb", JSON.stringify(_cb_event)); });