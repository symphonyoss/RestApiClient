@rem  Licensed to the Symphony Software Foundation (SSF) under one
@rem  or more contributor license agreements.  See the NOTICE file
@rem  distributed with this work for additional information
@rem  regarding copyright ownership.  The SSF licenses this file
@rem  to you under the Apache License, Version 2.0 (the
@rem  "License"); you may not use this file except in compliance
@rem  with the License.  You may obtain a copy of the License at
@rem  
@rem  http://www.apache.org/licenses/LICENSE-2.0
@rem  
@rem  Unless required by applicable law or agreed to in writing,
@rem  software distributed under the License is distributed on an
@rem  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
@rem  KIND, either express or implied.  See the License for the
@rem  specific language governing permissions and limitations
@rem  under the License.

rmdir /s /q temp

mkdir temp

@rem Our code generator, nswag, requires the JSON representation of the Swagger definition
@rem so we are coverting the YAML to Json using:
@rem https://github.com/LucyBot-Inc/api-spec-converter
@rem this can be installed by running:
@rem         npm install -g api-spec-converter
call api-spec-converter Yaml\1.46\agentAPI.yaml --from=swagger_2 --to=swagger_2 --syntax=json >temp\agentAPI.json
call api-spec-converter Yaml\1.46\authenticatorAPI.yaml --from=swagger_2 --to=swagger_2 --syntax=json >temp\authenticatorAPI.json
call api-spec-converter Yaml\1.46\podAPI.yaml --from=swagger_2 --to=swagger_2 --syntax=json >temp\podAPI.json

@rem How nswag interprets the paths does not work well with how Symphony has defined their paths, so 
@rem we will manually create operationIds that will force nswag to create the class and method names
@rem that we want

msbuild ..\..\..\..\tools\tools.sln
dotnet ..\..\..\..\tools\SwaggerOperationIdGenerator\SwaggerOperationIdGenerator\bin\Debug\netcoreapp1.1\SwaggerOperationIdGenerator.dll temp\agentAPI.json >temp\agentAPI.operations.json
dotnet ..\..\..\..\tools\SwaggerOperationIdGenerator\SwaggerOperationIdGenerator\bin\Debug\netcoreapp1.1\SwaggerOperationIdGenerator.dll temp\authenticatorAPI.json >temp\authenticatorAPI.operations.json
dotnet ..\..\..\..\tools\SwaggerOperationIdGenerator\SwaggerOperationIdGenerator\bin\Debug\netcoreapp1.1\SwaggerOperationIdGenerator.dll temp\podAPI.json >temp\podAPI.operations.json

rmdir /s /q AgentApi
rmdir /s /q AuthenticatorApi
rmdir /s /q PodApi

call ..\..\..\..\..\NSwagBinary\net461\NSwag.exe run Config\agentAPI.nswag
call ..\..\..\..\..\NSwagBinary\net461\NSwag.exe run Config\authenticatorAPI.nswag
call ..\..\..\..\..\NSwagBinary\net461\NSwag.exe run Config\podAPI.nswag

@rem When a request has an empty post body, nswag sets the content-type to text/plain, but Symphony
@rem still enforces that it be application/json. Here, we simply add the mimetype to the StringContent
powershell -Command "(gc AgentApi/AgentApi.cs) -replace 'System.Net.Http.StringContent\(string.Empty\);', 'System.Net.Http.StringContent(string.Empty, System.Text.Encoding.UTF8, \"application/json\");' | Out-File AgentApi/AgentApi.cs"
powershell -Command "(gc PodApi/PodApi.cs) -replace 'System.Net.Http.StringContent\(string.Empty\);', 'System.Net.Http.StringContent(string.Empty, System.Text.Encoding.UTF8, \"application/json\");' | Out-File PodApi/PodApi.cs"
powershell -Command "(gc AuthenticatorApi/AuthenticatorApi.cs) -replace 'System.Net.Http.StringContent\(string.Empty\);', 'System.Net.Http.StringContent(string.Empty, System.Text.Encoding.UTF8, \"application/json\");' | Out-File AuthenticatorApi/AuthenticatorApi.cs"

rmdir /s /q Temp

call prepend_license.bat

@rem apply patch to support content-type header for attachments
@rem the delay here is to allow something from above to release
@rem the write lock on AgentApi.cs
timeout 5
git apply patches\attachment.patch