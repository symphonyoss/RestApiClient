rem  Licensed to the Symphony Software Foundation (SSF) under one
rem  or more contributor license agreements.  See the NOTICE file
rem  distributed with this work for additional information
rem  regarding copyright ownership.  The SSF licenses this file
rem  to you under the Apache License, Version 2.0 (the
rem  "License"); you may not use this file except in compliance
rem  with the License.  You may obtain a copy of the License at
rem  
rem  http://www.apache.org/licenses/LICENSE-2.0
rem  
rem  Unless required by applicable law or agreed to in writing,
rem  software distributed under the License is distributed on an
rem  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
rem  KIND, either express or implied.  See the License for the
rem  specific language governing permissions and limitations
rem  under the License.


type src\SymphonyOSS.RestApiClient\SymphonyOSS.RestApiClient.csproj

set config=%1
if "%config%" == "" (
  set config=Release
)

set version=
if not "%PackageVersion%" == "" (
  set version=-Version %PackageVersion%
)

if "%nuget%" == "" (
  set nuget=nuget.exe
)

call %nuget% restore
if %ERRORLEVEL% NEQ 0 (exit /b %ERRORLEVEL%)


REM lets see what's installed
REM dir "%programfiles(x86)%\MSBuild"

REM Build
"%programfiles(x86)%\Microsoft Visual Studio\2017\Community\MSBuild\15.0\bin\MSBuild.exe" RestApiClient.sln /p:Configuration="%config%" /m /v:M /nr:false /t:Rebuild
if %ERRORLEVEL% NEQ 0 (exit /b %ERRORLEVEL%)

REM Package
rem call %nuget% pack "src\SymphonyOSS.RestApiClient\SymphonyOSS.RestApiClient.csproj" -symbols -p Configuration=%config%
"%programfiles(x86)%\Microsoft Visual Studio\2017\Community\MSBuild\15.0\bin\MSBuild.exe" "src\SymphonyOSS.RestApiClient\SymphonyOSS.RestApiClient.csproj" /p:Configuration="%config%" /p:IncludeSymbols="true" /p:IncludeSource="true" /p:Version="%version%" /m /v:M /nr:false /t:Pack
if %ERRORLEVEL% NEQ 0 (exit /b %ERRORLEVEL%)
