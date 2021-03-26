---
uid: services81-quote-getquotelineimage
title: Services81.QuoteAgent.GetQuoteLineImage SOAP
Generated: true
---

# Services81 Quote GetQuoteLineImage SOAP

SOAP request and response examples **Remote/Services81/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IQuoteAgent.GetQuoteLineImage">SuperOffice.Services81.IQuoteAgent.GetQuoteLineImage</see> method.

## GetQuoteLineImage

Gets an image connected to a quoteline, either from the ERPProvider or from the SuperOffice database

* **quoteLineId:** Primary key of the quoteline
* **rank:** The rank of the image.

**Returns:** The image. Returns null if no image available.


[WSDL file for Services81/Quote](../Services81-Quote.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetQuoteLineImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetQuoteLineImage>
    <Quote:QuoteLineId xsi:type="xsd:int">0</Quote:QuoteLineId>
    <Quote:Rank xsi:type="xsd:int">0</Quote:Rank>
   </Quote:GetQuoteLineImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetQuoteLineImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Quote:GetQuoteLineImageResponse>
   <Quote:Response xsi:type="xsd:base64Binary"></Quote:Response>
  </Quote:GetQuoteLineImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

