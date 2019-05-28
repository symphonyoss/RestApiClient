[![NuGet Packages Status](https://img.shields.io/nuget/v/SymphonyOSS.RestApiClient.svg?maxAge=2592000)](https://www.nuget.org/packages/SymphonyOSS.RestApiClient/)
[![MyGet Pre Release](https://img.shields.io/myget/symphonyoss/v/SymphonyOSS.RestApiClient.svg)](https://www.myget.org/feed/symphonyoss/package/nuget/SymphonyOSS.RestApiClient)
[![MyGet Build Status](https://www.myget.org/BuildSource/Badge/symphonyoss?identifier=5ec51fa6-f346-402c-af7f-3f30c9f40a28)](https://www.myget.org/feed/symphonyoss/package/nuget/SymphonyOSS.RestApiClient)
[![Dependencies](https://www.versioneye.com/user/projects/57b73c371dcdc900430c0b37/badge.svg?style=flat-square)](https://www.versioneye.com/user/projects/57b73c371dcdc900430c0b37?child=summary)
[![Travis Build Status](https://travis-ci.org/symphonyoss/RestApiClient.svg)](https://travis-ci.org/symphonyoss/RestApiClient)

Symphony REST API Client Library for .NET
=========================================

This is a .NET client library for the Symphony REST API, the technology used to create integrated bots on the Symphony platform. Detailed documentation of the Symphony REST API can be found at [developers.symphony.com](https://developers.symphony.com/).

## Features

 * Client code and model objects for all API endpoints.
 * Automatic token management for authentication.
 * Event-based data feed for processing inbound messages.
 * Builder for constructing formatted messages (MessageML).

## Supported Platforms

This project targets .NET Standard 1.3 which is supported by .NET Framework 4.6 and .NET Core 1.0, more details [here](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

## Getting Started

Symphony's REST API have been logically divided into sub-APIs. To use the client library, a SessionManager is first created to handle authentication for a bot user, and relevant instances of the sub-APIs are created depending on what functions the bot user requires.

This example shows how to subscribe to a bot user's incoming messages using the DatafeedAPI:

```
var certificate = new X509Certificate2(@"botuser.p12", "password");
var sessionManager = new UserSessionManager("https://keymanager:8444/sessionauth/", "https://keymanager:8444/keyauth/", certificate);
var agentApiFactory = new AgentApiFactory("https://agentapi:8446/agent");
var datafeedApi = agentApiFactory.CreateDatafeedApi(sessionManager);
datafeedApi.OnMessage += (sender, event) =>
{
    var message = e.Message;
    Console.WriteLine(message.Body);

    // Write any attachments to disk.
    foreach (var attachmentInfo in message.Attachments)
    {
        var bytes = attachmentsApi.DownloadAttachment(message.StreamId, message.Id, attachmentInfo.Id);
        File.WriteAllBytes(attachmentInfo.Name, bytes);
    }
};
datafeedApi.Listen();
```

The following code snippet shows how to find a user by email address and send a formatted message:

```
var podApiFactory = new PodApiFactory("https://agentapi:8446/pod");
var usersApi = podApiFactory.CreateUsersApi(sessionManager);
var streamsApi = podApiFactory.CreateStreamsApi(sessionManager);
var userId = usersApi.GetUserId("jforsell@factset.com");
var streamId = streamsApi.CreateStream(new List<long> {userId});
var body = new MessageBuilder().Text("hello ").Bold("world").ToString();
messagesApi.PostMessage(new MessageSubmit(streamId, body));
```

## Building

After cloning or downloading the source, it can be built in Visual Studio or with MSBuild.    

### Generated Code

The library depends on code that has been generated from Symphony's YAML spec files using nswag. The generated files live under the src/SymphonyOSS.RestClientApi/Generated folder.

In case there is a need to regenerate the code from Symphony's YAML specs:

 1. Make sure Node Package Manager is installed
 2. Install nswag via command line:  `npm install nswag -g`
 3. Install api-spec-converter via command line: `npm install api-spec-converter -g`
 4. Run SymphonyOSS.RestApiClient\Generated\OpenApi\generate.bat

The details of the generation process are outlined in generate.bat

## Contribute

This project was initiated at [FactSet](https://www.factset.com) and has been developed as open-source from the very beginning.

1. Fork it (<https://github.com/symphonyoss/SFE-DesktopClient-pgx/fork>)
2. Create your feature branch (`git checkout -b feature/fooBar`)
3. Read our [contribution guidelines](.github/CONTRIBUTING.md) and [Community Code of Conduct](https://www.finos.org/code-of-conduct)
4. Commit your changes (`git commit -am 'Add some fooBar'`)
5. Push to the branch (`git push origin feature/fooBar`)
6. Create a new Pull Request

Contributions are accepted via GitHub pull requests. All contributors must be covered by contributor license agreements to comply with the [Code Contribution Process](https://symphonyoss.atlassian.net/wiki/display/FM/Code+Contribution+Process).

## Release Notes

Release 0.5.0 (October 2017):
* Support for .NET Core
* Switched to using NSwag for Swagger code generation due to direct use of System.Net.Http.HttpClient; Swagger codegen uses FubarCoder's RestSharp library which is not thread safe
* All generated classes are no longer exposed externally
* App Authentication APIs now available

Release 0.4.0 (November 22, 2016):
 * New entity classes have been introduced: Attachment, Connection, Message, Presence, User, Room, and Stream
   replace their generated counterparts (eg V2Message, UserV2, etc).
 * SessionApi method GetUserId replaces GetSessionInfo.
 * StreamsApi method CreateStream returns stream ID instead of Stream object.
 * UsersApi GetUserId method replaces GetUser method (which returned a userId wrapped in a simple class).
 * UtilApi methods return string instead of SimpleMessage.

Release 0.3.4 (October 10, 2016):

 * Added a new framework dependency to the nuspec file.

Release 0.3.3 (October 10, 2016):

 * Regenerated classes using latest swagger-codegen to fix bugs with optional parameters.
 * Updated dependencies to latest versions.

Release 0.3.2 (September 27, 2016):

 * Support for sending messages using both normal and on-behalf-of authentication.

Release 0.3.1 (September 19, 2016):

 * Support for on-behalf-of operations,
 * Method to get user details by user ID,
 * Small fixes.

Release 0.3.0 (September 6, 2016):

 * New APIs.
 * New session management to support app sessions (breaking change).
 * Improved datafeed error handling.
 * MessageML to plain text parsing.
 * And more...

Release 0.2.0 (June 28, 2016)

 * New APIs added: attachments, room membership, security, user admin, and util.
 * Support for attachments when sending and receiving messages (breaking change).

Release 0.1.0 (June 6, 2016)

 * Initial release. Code generated from agentAPI v1.38.0, authenticatorAPI v1.0, and podAPI v1.38.0, found in agent-sdk-1.38.0-2016-05-27.tar.gz.

## License

Copyright 2016-2019 Symphony LLC

The code in this repository is distributed under the [Apache License, Version 2.0](http://www.apache.org/licenses/LICENSE-2.0).

