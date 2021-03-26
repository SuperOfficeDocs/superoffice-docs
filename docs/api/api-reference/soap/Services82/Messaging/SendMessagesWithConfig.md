---
uid: services82-messaging-sendmessageswithconfig
title: Services82.MessagingAgent.SendMessagesWithConfig SOAP
Generated: true
---

# Services82 Messaging SendMessagesWithConfig SOAP

SOAP request and response examples **Remote/Services82/Messaging.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IMessagingAgent.SendMessagesWithConfig">SuperOffice.Services82.IMessagingAgent.SendMessagesWithConfig</see> method.

## SendMessagesWithConfig

Send an array of messages using given config

* **plugin:** Name of plugin to use.
* **outgoingMessages:** Array of outgoing messages you want to send.
* **config:** Config values used by the plugin.

**Returns:** Array of MessageDeliveryStatus. Length of the array is equal to the number of outgoing messages.


[WSDL file for Services82/Messaging](../Services82-Messaging.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SendMessagesWithConfig Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Messaging:ApplicationToken>1234567-1234-9876</Messaging:ApplicationToken>
  <Messaging:Credentials>
    <Messaging:Ticket>7T:1234abcxyzExample==</Messaging:Ticket>
  </Messaging:Credentials>
 <SOAP-ENV:Body>
   <Messaging:SendMessagesWithConfig>
    <Messaging:Plugin xsi:type="xsd:string"></Messaging:Plugin>
    <Messaging:OutgoingMessages xsi:type="Messaging:ArrayOfOutgoingMessage">
     <Messaging:OutgoingMessage xsi:type="Messaging:OutgoingMessage">
      <Messaging:From xsi:type="xsd:string"></Messaging:From>
      <Messaging:To xsi:type="xsd:string"></Messaging:To>
      <Messaging:Content xsi:type="xsd:string"></Messaging:Content>
      <Messaging:Format xsi:type="xsd:string"></Messaging:Format>
      <Messaging:ParentMessagingId xsi:type="xsd:int">0</Messaging:ParentMessagingId>
      <Messaging:SuggestedSessionKey xsi:type="xsd:string"></Messaging:SuggestedSessionKey>
     </Messaging:OutgoingMessage>
    </Messaging:OutgoingMessages>
    <Messaging:Config xsi:type="Messaging:StringDictionary">
     <Messaging:StringKeyValuePair>
      <Messaging:Key xsi:type="xsd:string"></Messaging:Key>
      <Messaging:Value xsi:type="xsd:string"></Messaging:Value>
     </Messaging:StringKeyValuePair>
    </Messaging:Config>
   </Messaging:SendMessagesWithConfig>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SendMessagesWithConfig Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Messaging:SendMessagesWithConfigResponse>
   <Messaging:Response xsi:type="Messaging:ArrayOfMessageDeliveryStatus">
    <Messaging:MessageDeliveryStatus xsi:type="Messaging:MessageDeliveryStatus">
     <Messaging:Status xsi:type="xsd:int">0</Messaging:Status>
     <Messaging:StatusDescription xsi:type="xsd:string"></Messaging:StatusDescription>
     <Messaging:MessagingId xsi:type="xsd:int">0</Messaging:MessagingId>
    </Messaging:MessageDeliveryStatus>
   </Messaging:Response>
  </Messaging:SendMessagesWithConfigResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

