---
uid: services88-webhook-signalevent
title: Services88.WebhookAgent.SignalEvent SOAP
Generated: true
---

# Services88 Webhook SignalEvent SOAP

SOAP request and response examples **Remote/Services88/Webhook.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IWebhookAgent.SignalEvent">SuperOffice.Services88.IWebhookAgent.SignalEvent</see> method.

## SignalEvent

Signal webhooks that an event has occurred. All webhooks listening for the event will be notified.
<para /><b>Online Restricted:</b> The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.

* **eventName:** Name of event to fire. 'entity.verb' For example: 'window.closed', 'button.clicked'.
* **primaryKey:** (Optional) Id of entity that is firing event. Can be 0 if not used.
* **data:** Event data. Not all the data values may be posted to the webhook, depending in webhook type: { 'windowName': 'foo', 'widgets': 123 }

**Returns:** This method has no return value


[WSDL file for Services88/Webhook](../Services88-Webhook.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

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

