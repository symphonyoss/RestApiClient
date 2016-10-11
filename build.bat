@echo Off
set config=%1
if "%config%" == "" (
  set config=Release
)

set version=
if not "%PackageVersion%" == "" (
  set version=-Version %PackageVersion%
)

set nuget=
if "%nuget%" == "" (
  set nuget=nuget.exe
)

REM Build
"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" RestApiClient.sln /p:Configuration="%config%" /m /v:M /nr:false /t:Rebuild

REM Package
call %nuget% pack "src\SymphonyOSS.RestApiClient\SymphonyOSS.RestApiClient.csproj" -symbols -p Configuration=%config% %version%
