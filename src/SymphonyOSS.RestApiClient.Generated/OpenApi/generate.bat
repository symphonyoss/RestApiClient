java -jar swagger-codegen-cli.jar generate -i Yaml/AgentApi/1.38.0/agentAPI.yaml -l csharp -o Temp -c Config/agentApi.json
java -jar swagger-codegen-cli.jar generate -i Yaml/AuthenticatorApi/1.0/authenticatorAPI.yaml -l csharp -o Temp -c Config/authenticatorApi.json
java -jar swagger-codegen-cli.jar generate -i Yaml/PodApi/1.38.0/podAPI.yaml -l csharp -o Temp -c Config/podApi.json
rmdir /s /q AgentApi
rmdir /s /q AuthenticatorApi
rmdir /s /q PodApi
cd Temp
ren SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi AgentApi
ren SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi AuthenticatorApi
ren SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi PodApi
move AgentApi ..
move AuthenticatorApi ..
move PodApi ..
cd ..
rmdir /s /q Temp
