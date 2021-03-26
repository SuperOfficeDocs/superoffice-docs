---
uid: services83-quote-getquoteversionworkflowimagestate
title: Services83.QuoteAgent.GetQuoteVersionWorkflowImageState SOAP
Generated: true
---

# Services83 Quote GetQuoteVersionWorkflowImageState SOAP

SOAP request and response examples **Remote/Services83/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IQuoteAgent.GetQuoteVersionWorkflowImageState">SuperOffice.Services83.IQuoteAgent.GetQuoteVersionWorkflowImageState</see> method.

## GetQuoteVersionWorkflowImageState

Get state icon and name for the Quote version dialog header.

* **quoteVersionId:** Id of the quote version to get the version state for.

**Returns:** Image and state name information


[WSDL file for Services83/Quote](../Services83-Quote.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetQuoteVersionWorkflowImageState Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetQuoteVersionWorkflowImageState>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
   </Quote:GetQuoteVersionWorkflowImageState>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetQuoteVersionWorkflowImageState Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Quote:GetQuoteVersionWorkflowImageStateResponse>
   <Quote:Response xsi:type="Quote:QuoteVersionButtonState">
    <Quote:Action xsi:type="Quote:QuoteVersionButtonAction">None</Quote:Action>
    <Quote:ImageHint xsi:type="xsd:string"></Quote:ImageHint>
    <Quote:DisplayText xsi:type="xsd:string"></Quote:DisplayText>
    <Quote:TooltipText xsi:type="xsd:string"></Quote:TooltipText>
    <Quote:Enabled xsi:type="xsd:boolean">false</Quote:Enabled>
   </Quote:Response>
  </Quote:GetQuoteVersionWorkflowImageStateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

