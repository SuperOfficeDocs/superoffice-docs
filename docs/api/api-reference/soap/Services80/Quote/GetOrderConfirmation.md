---
uid: services80-quote-getorderconfirmation
title: Services80.QuoteAgent.GetOrderConfirmation SOAP
Generated: true
---

# Services80 Quote GetOrderConfirmation SOAP

SOAP request and response examples **Remote/Services80/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IQuoteAgent.GetOrderConfirmation">SuperOffice.Services80.IQuoteAgent.GetOrderConfirmation</see> method.

## GetOrderConfirmation

Get a base64-encoded data stream that is just the order confirmation document, for the given quote version; no permanent document is created or stored anywhere; the result is a PDF

* **quoteVersionId:** VersionId of the quote to be sent; the status of the version will not be changed by calling this method
* **confirmationTemplateId:** Id of the template for the order confirmation lines document

**Returns:** Base64-encoded binary data, that is in fact a PDF document that should be shown to the user


[WSDL file for Services80/Quote](../Services80-Quote.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetOrderConfirmation Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetOrderConfirmation>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
    <Quote:ConfirmationTemplateId xsi:type="xsd:int">0</Quote:ConfirmationTemplateId>
   </Quote:GetOrderConfirmation>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetOrderConfirmation Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Quote:GetOrderConfirmationResponse>
   <Quote:Response xsi:type="xsd:string"></Quote:Response>
  </Quote:GetOrderConfirmationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

