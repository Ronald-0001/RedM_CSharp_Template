// main script

// example script > nui call
Nui.Calls["Test"] = (_object) => { console.log(JSON.stringify(_object)); };

// example nui > scropt call
Nui.Send("Test", { test: "Test sendt from the nui" }, _object => { console.log("Test cb", JSON.stringify(_object)); });