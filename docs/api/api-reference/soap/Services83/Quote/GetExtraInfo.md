---
uid: services83-quote-getextrainfo
title: Services83.QuoteAgent.GetExtraInfo SOAP
Generated: true
---

# Services83 Quote GetExtraInfo SOAP

SOAP request and response examples **Remote/Services83/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IQuoteAgent.GetExtraInfo">SuperOffice.Services83.IQuoteAgent.GetExtraInfo</see> method.

## GetExtraInfo

Converts an xml string into an object representation.

* **quoteLineExtraData:** The extra data as xml.

**Returns:** An object representation on the xml


[WSDL file for Services83/Quote](../Services83-Quote.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetExtraInfo Request

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
   <Quote:GetExtraInfo>
    <Quote:QuoteLineExtraData xsi:type="xsd:string"></Quote:QuoteLineExtraData>
   </Quote:GetExtraInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetExtraInfo Response

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
  <Quote:GetExtraInfoResponse>
   <Quote:Response xsi:type="Quote:ArrayOfProductExtraDataField">
    <Quote:ProductExtraDataField xsi:type="Quote:ProductExtraDataField">
     <Quote:Name xsi:type="xsd:string"></Quote:Name>
     <Quote:Value xsi:type="xsd:string"></Quote:Value>
     <Quote:Type xsi:type="Quote:ExtraDataFieldType">String</Quote:Type>
    </Quote:ProductExtraDataField>
   </Quote:Response>
  </Quote:GetExtraInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

