set dir=%~p1
echo %dir%
mklink/h "%~dp0CitizenFX.Core.dll" "%~1"