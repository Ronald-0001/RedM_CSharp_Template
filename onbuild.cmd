if $(ConfigurationName) == Debug (
  cd $(SolutionDir)
  rmdir /s /q ..\server-data\resources\[local]\MagicSauce
  mkdir ..\server-data\resources\[local]\MagicSauce
  copy /y fxmanifest.lua ..\server-data\resources\[local]\MagicSauce
  xcopy /y /e Client\bin\Debug\ ..\server-data\resources\[local]\MagicSauce\Client\bin\publish\
  xcopy /y /e Server\bin\Debug\ ..\server-data\resources\[local]\MagicSauce\Server\bin\publish\
) else (
  cd $(SolutionDir)
  rmdir /s /q ..\server-data\resources\[local]\MagicSauce
  mkdir ..\server-data\resources\[local]\MagicSauce
  copy /y fxmanifest.lua ..\server-data\resources\[local]\MagicSauce
  xcopy /y /e Client\bin\Release\ ..\server-data\resources\[local]\MagicSauce\Client\bin\publish\
  xcopy /y /e Server\bin\Release\ ..\server-data\resources\[local]\MagicSauce\Server\bin\publish\
)