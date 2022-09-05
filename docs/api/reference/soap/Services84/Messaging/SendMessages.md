---
title: Services84.MessagingAgent.SendMessages SOAP
generated: 1
uid: Services84-Messaging-SendMessages
---

# Services84 Messaging SendMessages

SOAP request and response examples **Remote/Services84/Messaging.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IMessagingAgent.SendMessages">SuperOffice.Services84.IMessagingAgent.SendMessages</see> method.

## SendMessages

Send an array of messages

* **plugin:** Name of plugin to use.
* **outgoingMessages:** Array of outgoing messages you want to send.

**Returns:** Array of MessageDeliveryStatus. Length of the array is equal to the number of outgoing messages.


[WSDL file for Services84/Messaging](../Services84-Messaging.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SendMessages Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Messaging:ApplicationToken>1234567-1234-9876</Messaging:ApplicationToken>
  <Messaging:Credentials>
    <Messaging:Ticket>7T:1234abcxyzExample==</Messaging:Ticket>
  </Messaging:Credentials>
 <SOAP-ENV:Body>
   <Messaging:SendMessages>
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
   </Messaging:SendMessages>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SendMessages Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Messaging:SendMessagesResponse>
   <Messaging:Response xsi:type="Messaging:ArrayOfMessageDeliveryStatus">
    <Messaging:MessageDeliveryStatus xsi:type="Messaging:MessageDeliveryStatus">
     <Messaging:Status xsi:type="xsd:int">0</Messaging:Status>
     <Messaging:StatusDescription xsi:type="xsd:string"></Messaging:StatusDescription>
     <Messaging:MessagingId xsi:type="xsd:int">0</Messaging:MessagingId>
    </Messaging:MessageDeliveryStatus>
   </Messaging:Response>
  </Messaging:SendMessagesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

