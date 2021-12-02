---
title: Services88.WebhookAgent.DeleteWebhook SOAP
generated: 1
uid: Services88-Webhook-DeleteWebhook
---

# Services88 Webhook DeleteWebhook

SOAP request and response examples **Remote/Services88/Webhook.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IWebhookAgent.DeleteWebhook">SuperOffice.Services88.IWebhookAgent.DeleteWebhook</see> method.

## DeleteWebhook

Deletes the Webhook
<para /><b>Online Restricted:</b> The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.

* **webhookId:** The identity of the Webhook



[WSDL file for Services88/Webhook](../Services88-Webhook.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteWebhook Request

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
   <Webhook:DeleteWebhook>
    <Webhook:WebhookId xsi:type="xsd:int">0</Webhook:WebhookId>
   </Webhook:DeleteWebhook>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteWebhook Response

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
  <Webhook:DeleteWebhookResponse>
  </Webhook:DeleteWebhookResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

