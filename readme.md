#setup!
// step 1
create a new repository using the template via github...

// step 2
open visual studio and clone the new repository

// step 3
validate & update references

// step 4 "optional"
rename the redm_template.sln

// step 5 "optional"
update build event

#info!
// references
- CitizenFX.Core.dll, RedLib & Newtonsoft.Json

// add RedLIB
- fetch latest RedLib.dll either go to https://github.com/Ronald-0001/RedM_LIB
- or if you are using git you can update submodules using "git submodule update --init --recursive" / "git submodule update --remote --merge"
- add refrence to RedLib.dll found in "external/Red_Lib/include/RedLib.dll" or where you downloaded it to

// create dynamic refrence using linker.cmd
* to create a dynamic link
- create a folder on your main drive
* ex C:\Users\User\Desktop\RedM_References
- place linker.cmd into the new folder
- drag CitizenFX.Core.dll onto linker.cmd
* CitizenFX.Core.dll can be found at
* %localappdata%\RedM\RedM.app\citizen\clr2\lib\mono\4.5

// auto build resource folder on build event
- Resource.Client & Resource.Server - properties -> build events -> post build event
- set "Resource" to the new resource's name
* a backup of the build event code can be found inside onbuild.cmd