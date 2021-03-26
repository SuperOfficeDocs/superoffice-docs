---
uid: services81-messaging-getdeliverystatus
title: Services81.MessagingAgent.GetDeliveryStatus SOAP
Generated: true
---

# Services81 Messaging GetDeliveryStatus SOAP

SOAP request and response examples **Remote/Services81/Messaging.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IMessagingAgent.GetDeliveryStatus">SuperOffice.Services81.IMessagingAgent.GetDeliveryStatus</see> method.

## GetDeliveryStatus

Get delivery status

* **messagingIds:** Array of messaging ids.



[WSDL file for Services81/Messaging](../Services81-Messaging.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDeliveryStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Messaging:ApplicationToken>1234567-1234-9876</Messaging:ApplicationToken>
  <Messaging:Credentials>
    <Messaging:Ticket>7T:1234abcxyzExample==</Messaging:Ticket>
  </Messaging:Credentials>
 <SOAP-ENV:Body>
   <Messaging:GetDeliveryStatus>
    <Messaging:MessagingIds xsi:type="NetServerServices812:ArrayOfint">
     <NetServerServices812:int xsi:type="xsd:int">0</NetServerServices812:int>
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
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services81">
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

