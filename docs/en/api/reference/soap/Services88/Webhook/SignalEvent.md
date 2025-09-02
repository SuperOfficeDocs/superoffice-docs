---
title: Services88.WebhookAgent.SignalEvent SOAP
generated: true
uid: Services88-Webhook-SignalEvent
content_type: reference
---

# Services88 Webhook SignalEvent

SOAP request and response examples **Remote/Services88/Webhook.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IWebhookAgent.SignalEvent">SuperOffice.Services88.IWebhookAgent.SignalEvent</see> method.

## SignalEvent





[WSDL file for Services88/Webhook](../Services88-Webhook.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SignalEvent Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Webhook:ApplicationToken>1234567-1234-9876</Webhook:ApplicationToken>
  <Webhook:Credentials>
    <Webhook:Ticket>7T:1234abcxyzExample==</Webhook:Ticket>
  </Webhook:Credentials>
 <SOAP-ENV:Body>
   <Webhook:SignalEvent>
    <Webhook:EventName xsi:type="xsd:string"></Webhook:EventName>
    <Webhook:PrimaryKey xsi:type="xsd:int">0</Webhook:PrimaryKey>
    <Webhook:Data xsi:type="Webhook:StringObjectDictionary">
     <Webhook:StringObjectKeyValuePair>
      <Webhook:Key xsi:type="xsd:string"></Webhook:Key>
      <Webhook:Value xsi:type="xsd:anyType"></Webhook:Value>
     </Webhook:StringObjectKeyValuePair>
    </Webhook:Data>
   </Webhook:SignalEvent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SignalEvent Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Webhook:SignalEventResponse>
  </Webhook:SignalEventResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

