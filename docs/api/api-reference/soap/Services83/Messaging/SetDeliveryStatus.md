---
uid: services83-messaging-setdeliverystatus
title: Services83.MessagingAgent.SetDeliveryStatus SOAP
Generated: true
---

# Services83 Messaging SetDeliveryStatus SOAP

SOAP request and response examples **Remote/Services83/Messaging.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IMessagingAgent.SetDeliveryStatus">SuperOffice.Services83.IMessagingAgent.SetDeliveryStatus</see> method.

## SetDeliveryStatus

Set or change the delivery status on an outgoing messsage.

* **plugin:** Name of plugin
* **externalMessageId:** External message id known to plugin.
* **status:** Delivery status
* **statusDescription:** String describing delivery status.



[WSDL file for Services83/Messaging](../Services83-Messaging.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetDeliveryStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Messaging:ApplicationToken>1234567-1234-9876</Messaging:ApplicationToken>
  <Messaging:Credentials>
    <Messaging:Ticket>7T:1234abcxyzExample==</Messaging:Ticket>
  </Messaging:Credentials>
 <SOAP-ENV:Body>
   <Messaging:SetDeliveryStatus>
    <Messaging:Plugin xsi:type="xsd:string"></Messaging:Plugin>
    <Messaging:ExternalMessageId xsi:type="xsd:string"></Messaging:ExternalMessageId>
    <Messaging:Status xsi:type="xsd:int">0</Messaging:Status>
    <Messaging:StatusDescription xsi:type="xsd:string"></Messaging:StatusDescription>
   </Messaging:SetDeliveryStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetDeliveryStatus Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Messaging="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Messaging:SetDeliveryStatusResponse>
  </Messaging:SetDeliveryStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

