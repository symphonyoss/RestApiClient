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

java -jar swagger-codegen-cli.jar generate -i Yaml/AgentApi/1.38.0-20160812/agentAPI.yaml -l csharp -o Temp -c Config/agentApi.json
java -jar swagger-codegen-cli.jar generate -i Yaml/AuthenticatorApi/1.0-20160812/authenticatorAPI.yaml -l csharp -o Temp -c Config/authenticatorApi.json
java -jar swagger-codegen-cli.jar generate -i Yaml/PodApi/1.40.0-20160711/podAPI.yaml -l csharp -o Temp -c Config/podApi.json
rmdir /s /q AgentApi
rmdir /s /q AuthenticatorApi
rmdir /s /q PodApi
mkdir Temp
cd Temp
ren SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi AgentApi
ren SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi AuthenticatorApi
ren SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi PodApi
move AgentApi ..
move AuthenticatorApi ..
move PodApi ..
cd ..
rmdir /s /q Temp

call prepend_license.bat