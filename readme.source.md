# <img src="/src/icon.png" height="30px"> NServiceBus.ProtoBufGoogle

[![Build status](https://ci.appveyor.com/api/projects/status/ad7ibwiqio3ocso4/branch/master?svg=true)](https://ci.appveyor.com/project/SimonCropp/nservicebus-ProtoBufGoogle)
[![NuGet Status](https://img.shields.io/nuget/v/NServiceBus.ProtoBufGoogle.svg?cacheSeconds=86400)](https://www.nuget.org/packages/NServiceBus.ProtoBufGoogle/)

Add support for [NServiceBus](https://docs.particular.net/nservicebus/) message serialization via [Google ProtoBuf](https://github.com/google/protobuf).

toc

<!--- StartOpenCollectiveBackers -->

[Already a Patron? skip past this section](#endofbacking)


## Community backed

**It is expected that all developers [become a Patron](https://opencollective.com/nservicebusextensions/order/6976) to use any of these libraries. [Go to licensing FAQ](https://github.com/NServiceBusExtensions/Home/blob/master/readme.md#licensingpatron-faq)**


### Sponsors

Support this project by [becoming a Sponsors](https://opencollective.com/nservicebusextensions/order/6972). The company avatar will show up here with a link to your website. The avatar will also be added to all GitHub repositories under this organization.


### Patrons

Thanks to all the backing developers! Support this project by [becoming a patron](https://opencollective.com/nservicebusextensions/order/6976).

<img src="https://opencollective.com/nservicebusextensions/tiers/patron.svg?width=890&avatarHeight=60&button=false">

<!--- EndOpenCollectiveBackers -->

<a href="#" id="endofbacking"></a>


## Usage

snippet: ProtobufSerialization

This serializer does not support [messages defined as interfaces](https://docs.particular.net/nservicebus/messaging/messages-as-interfaces). If an explicit interface is sent, an exception will be thrown with the following message:

```
Interface based message are not supported.
Create a class that implements the desired interface
```

Instead, use a public class with the same contract as the interface. The class can optionally implement any required interfaces.


### Custom Settings

Customizes the instance of `SerializerOptions` used for serialization.


### Custom content key

When using [additional deserializers](https://docs.particular.net/nservicebus/serialization/#specifying-additional-deserializers) or transitioning between different versions of the same serializer it can be helpful to take explicit control over the content type a serializer passes to NServiceBus (to be used for the [ContentType header](https://docs.particular.net/nservicebus/messaging/headers#serialization-headers-nservicebus-contenttype)).

snippet: ProtoBufContentTypeKey


## More Info

For more information on Google Protocol Buffers see

 * [C# Tutorial](https://developers.google.com/protocol-buffers/docs/csharptutorial)
 * [Language Guide](https://developers.google.com/protocol-buffers/docs/proto3)
 * [Generated Code](https://developers.google.com/protocol-buffers/docs/reference/csharp-generated)


## Release Notes

See [closed milestones](../../milestones?state=closed).


## Icon

[Robot](https://thenounproject.com/term/robot/826086/) designed by [Oksana Latysheva](https://thenounproject.com/latyshevaoksana/) from [The Noun Project](https://thenounproject.com).