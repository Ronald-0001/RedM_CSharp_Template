// before coding
- update refrence to CitizenFX.Core.dll

// create dynamic refrence using linker.cmd
* to create a dynamic link
- create a folder on your main drive
* ex C:\Users\User\Desktop\RedM_References
- place linker.cmd into the new folder
- drag CitizenFX.Core.dll onto linker.cmd
* CitizenFX.Core.dll can be found at
* %localappdata%\RedM\RedM.app\citizen\clr2\lib\mono\4.5

// auto build resource folder on build event
* add code from on onbuild.cmd to "post build events"
- Resource.Client & Resource.Server - properties -> build events -> post build event
- replace "MagicSauce" with the new resources name

// rename resource prefix
* rename all places
- Resource.Client & Resource.Server - project name
- Resource.Client & Resource.Server - properties -> assembly name & default namespace
- ClientMain.cs & ServerMain.cs - namespaces