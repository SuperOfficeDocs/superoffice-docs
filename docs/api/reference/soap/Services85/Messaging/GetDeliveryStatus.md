---
title: Services85.MessagingAgent.GetDeliveryStatus SOAP
generated: 1
uid: Services85-Messaging-GetDeliveryStatus
---

# Services85 Messaging GetDeliveryStatus

SOAP request and response examples **Remote/Services85/Messaging.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IMessagingAgent.GetDeliveryStatus">SuperOffice.Services85.IMessagingAgent.GetDeliveryStatus</see> method.

## GetDeliveryStatus

Get delivery status

* **messagingIds:** Array of messaging ids.



[WSDL file for Services85/Messaging](../Services85-Messaging.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDeliveryStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Messaging:ApplicationToken>1234567-1234-9876</Messaging:ApplicationToken>
  <Messaging:Credentials>
    <Messaging:Ticket>7T:1234abcxyzExample==</Messaging:Ticket>
  </Messaging:Credentials>
 <SOAP-ENV:Body>
   <Messaging:GetDeliveryStatus>
    <Messaging:MessagingIds xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
    </Messaging:MessagingIds>
   </Messaging:GetDeliveryStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDeliveryStatus Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Messaging:GetDeliveryStatusResponse>
   <Messaging:Response xsi:type="Messaging:ArrayOfMessageDeliveryStatus">
    <Messaging:MessageDeliveryStatus xsi:type="Messaging:MessageDeliveryStatus">
     <Messaging:Status xsi:type="xsd:int">0</Messaging:Status>
     <Messaging:StatusDescription xsi:type="xsd:string"></Messaging:StatusDescription>
     <Messaging:MessagingId xsi:type="xsd:int">0</Messaging:MessagingId>
    </Messaging:MessageDeliveryStatus>
   </Messaging:Response>
  </Messaging:GetDeliveryStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

