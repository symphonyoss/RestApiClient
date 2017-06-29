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

@echo Off

set config=%1
if "%config%" == "" (
  set config=Release
)

REM Version currently ignored
set version=
if not "%PackageVersion%" == "" (
  set version=-Version %PackageVersion%
)

if "%nuget%" == "" (
  set nuget=nuget.exe
)

call %nuget% restore

REM Build
"%programfiles(x86)%\MSBuild\15.0\Bin\MSBuild.exe" RestApiClient.sln /p:Configuration="%config%" /m /v:M /nr:false /t:Rebuild

REM Package
rem call %nuget% pack "src\SymphonyOSS.RestApiClient\SymphonyOSS.RestApiClient.csproj" -symbols -p Configuration=%config%
"%programfiles(x86)%\MSBuild\15.0\Bin\MSBuild.exe" "src\SymphonyOSS.RestApiClient\SymphonyOSS.RestApiClient.csproj" /p:Configuration="%config%" /p:IncludeSymbols="true" /p:IncludeSource="true" /m /v:M /nr:false /t:Pack
