---
title: Messaging element
uid: ns_config_messaging
description: NetServer configuration values for SuperOffice.CRM.Messaging and the SoMessaging.dll.
so.date: 12.07.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, SuperOffice.CRM.Messaging, SoMessaging.dll, Messaging, BrokerAutoAliveMessage, BrokerBroadcastAddress, BrokerBroadcastPort, BrokerExternalListening, BrokerInternalListening, ClientAutoAliveMessage, ClientAutoCreateBroker, ClientBroadcastAddress, ClientBroadcastPort, ClientListening, MessagingSoAuthentication, MessagingSoPassword, MessagingSoUser
so.topic: reference
so.envir: onsite
---

# NetServer Messaging element

Configuration values for `SuperOffice.CRM.Messaging` and the *SoMessaging.dll*.

```XML
<Messaging>
  <add key="MessagingSoAuthentication" value="" />
  <add key="MessagingSoUser" value="" />
  <add key="MessagingSoPassword" value="" />
  <add key="BrokerBroadcastAddress" value="" />
</Messaging>
```

| Name | Description | Default |
|---|---|---|
| BrokerAutoAliveMessage | Should the message broker automatically send alive messages?  | true |
| BrokerAutoAliveMessageInterval |  Interval for the message broker to send alive messages. | 60 (sec) |
| BrokerBroadcastAddress | Broadcast address for the message broker to send to other machines. | 255.255.255.255 |
| BrokerBroadcastPort | The port the message broker is sending messages on to other machines. | port 19107 |
| BrokerExternalListeningAddress | Address the message broker is listening on for external messages. | 0.0.0.0 (any IP address) |
| BrokerExternalListeningPort | The port the message broker is listening for messages from other machines. | port 19107 |
| BrokerInternalListeningAddress | Address the message broker is listening on for internal messages. | 127.0.0.1 (loopback adapter) |
| BrokerInternalListeningPort | The port the message broker is listening for messages from internal clients. | port 19108 |
| ClientAutoAliveMessage | Should the message client automatically send alive messages? | true |
| ClientAutoAliveMessageInterval | Interval for the message client to send alive messages. | 60 (sec) |
| ClientAutoCreateBroker | Should the message client automatically create a local message broker if one does not exist?  | true |
| ClientBroadcastAddress | Address their message clients (normally sending messages through the message broker) is broadcasting on. | 127.0.0.1 (loopback adapter) |
| ClientBroadcastPort | The port the message client is broadcasting messages on (normally to the message broker). | port 19108 |
| ClientListeningAddress | Address the message clients (normally receiving messages from the message broker) is listening on. | 0.0.0.0 (any IP address) |
| ClientListeningPortEnd | The end of the range clients listen to messages on (normally from the message broker). | 19999 |
| ClientListeningPortStart | The start of the range clients listen to messages on (normally from the message broker). | 19109 |
| MessagingSoAuthentication | False will indicate the process being authenticated with NetServer or Anonymous user. | |
| MessagingSoPassword | Password for MessagingSoUser. | |
| MessagingSoUser | SuperOffice user to authenticate with. | |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Messaging>
