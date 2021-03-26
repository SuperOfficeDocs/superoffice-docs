---
uid: services87-webhook-getlasterror
title: Services87.WebhookAgent.GetLastError SOAP
Generated: true
---

# Services87 Webhook GetLastError SOAP

SOAP request and response examples **Remote/Services87/Webhook.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IWebhookAgent.GetLastError">SuperOffice.Services87.IWebhookAgent.GetLastError</see> method.

## GetLastError

Return the most recent error message received when calling this webhook.
<para /><b>Online Restricted:</b> The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.

* **webhookId:** Webhook to get error message for.

**Returns:** Error message, or empty string if no errors received


[WSDL file for Services87/Webhook](../Services87-Webhook.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLastError Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Webhook:ApplicationToken>1234567-1234-9876</Webhook:ApplicationToken>
  <Webhook:Credentials>
    <Webhook:Ticket>7T:1234abcxyzExample==</Webhook:Ticket>
  </Webhook:Credentials>
 <SOAP-ENV:Body>
   <Webhook:GetLastError>
    <Webhook:WebhookId xsi:type="xsd:int">0</Webhook:WebhookId>
   </Webhook:GetLastError>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLastError Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Webhook:GetLastErrorResponse>
   <Webhook:Response xsi:type="xsd:string"></Webhook:Response>
  </Webhook:GetLastErrorResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

