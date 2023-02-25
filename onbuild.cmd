set Resource=thisResourceName
set Dir=..\server-data\resources\[local]

if %Resource% == thisResourceName (
  echo "avoiding resource creation please set the resource name inside build events"
) else (
  cd $(SolutionDir)
  rmdir /s /q "%dir%\%Resource%"
  mkdir "%dir%\%Resource%"
  copy /y "Manifest\fxmanifest.lua" "%dir%\%Resource%"
  xcopy /y /e "Nui\" "%dir%\%Resource%\Client\nui\"
  if $(ConfigurationName) == Debug (
    xcopy /y /e "Resource.Client\bin\Debug\" "%dir%\%Resource%\Client\bin\publish\"
    xcopy /y /e "Resource.Server\bin\Debug\" "%dir%\%Resource%\Server\bin\publish\"
  ) else (
    xcopy /y /e "Resource.Client\bin\Release\" "%dir%\%Resource%\Client\bin\publish\"
    xcopy /y /e "Resource.Server\bin\Release\" "%dir%\%Resource%\Server\bin\publish\"
  )
)