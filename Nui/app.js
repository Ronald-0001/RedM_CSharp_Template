// main script

// example script > nui call
Nui.Calls["Test"] = (_object) => { console.log(_object); };

// example nui > scropt call
Nui.Send("Test", { test = "Test sendt from the nui" }, (_object) => { console.log(_object); });