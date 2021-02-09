---
title: ns_config_messaging
description: NetServer Messaging element
so.date: 06.06.2018
author: {github-id}
keywords: config
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

| Name | Description |
|---|---|
| MessagingSoAuthentication | False will indicate the process being authenticated with NetServer or Anonymous user. |
| MessagingSoUser | SuperOffice user to authenticate with. |
| MessagingSoPassword | Password for MessagingSoUser. |
| BrokerBroadcastAddress | Broadcast address for the message broker to send to other machines.<br>Default: 255.255.255.255 |
| BrokerExternalListeningAddress | Address the message broker is listening on for external messages.<br>Default: 0.0.0.0 (any IP address) |
| BrokerInternalListeningAddress | Address the message broker is listening on for internal messages.<br>Default: 127.0.0.1 (loopback adapter) |
| ClientBroadcastAddress | Address their message clients (normally sending messages through the message broker) is broadcasting on.<br>Default: 127.0.0.1 (loopback adapter) |
| ClientListeningAddress | Address the message clients (normally receiving messages from the message broker) is listening on.<br>Default: 0.0.0.0 (any IP address) |
| BrokerBroadcastPort | The port the message broker is sending messages on to other machines.<br>Default: port 19107 |
| BrokerExternalListeningPort | The port the message broker is listening for messages from other machines.<br>Default: port 19107 |
| BrokerInternalListeningPort | The port the message broker is listening for messages from internal clients.<br>Default: port 19108 |
| ClientBroadcastPort | The port the message client is broadcasting messages on (normally to the message broker).<br>Default: port 19108 |
| ClientListeningPortStart | The start of the range clients listen to messages on (normally from the message broker).<br>Default: 19109 |
| ClientListeningPortEnd | The end of the range clients listen to messages on (normally from the message broker).<br>Default: 19999 |
| ClientAutoCreateBroker | Should the message client automatically create a local message broker if one does not exist? <br>Default: true |
| BrokerAutoAliveMessage | Should the message broker automatically send alive messages? <br>Default: true |
| ClientAutoAliveMessage | Should the message client automatically send alive messages?<br>Default: true |
| BrokerAutoAliveMessageInterval |  Interval for the message broker to send alive messages.<br>Default: 60 (sec) |
| ClientAutoAliveMessageInterval | Interval for the message client to send alive messages.<br>Default: 60 (sec) |
