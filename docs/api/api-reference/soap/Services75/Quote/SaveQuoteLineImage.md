---
uid: services75-quote-savequotelineimage
title: Services75.QuoteAgent.SaveQuoteLineImage SOAP
Generated: true
---

# Services75 Quote SaveQuoteLineImage SOAP

SOAP request and response examples **Remote/Services75/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IQuoteAgent.SaveQuoteLineImage">SuperOffice.Services75.IQuoteAgent.SaveQuoteLineImage</see> method.

## SaveQuoteLineImage

Saves the image connected to a quoteline in the SuperOffice database

* **quoteLineId:** Primary key of the quoteline
* **image:** The image.
* **rank:** The rank of the image.

**Returns:** Nothing


[WSDL file for Services75/Quote](../Services75-Quote.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveQuoteLineImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:SaveQuoteLineImage>
    <Quote:QuoteLineId xsi:type="xsd:int">0</Quote:QuoteLineId>
    <Quote:Image xsi:type="xsd:base64Binary"></Quote:Image>
    <Quote:Rank xsi:type="xsd:int">0</Quote:Rank>
   </Quote:SaveQuoteLineImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveQuoteLineImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Quote:SaveQuoteLineImageResponse>
  </Quote:SaveQuoteLineImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

