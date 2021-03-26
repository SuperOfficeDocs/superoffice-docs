---
uid: services88-quote-savequoteversionnumber
title: Services88.QuoteAgent.SaveQuoteVersionNumber SOAP
Generated: true
---

# Services88 Quote SaveQuoteVersionNumber SOAP

SOAP request and response examples **Remote/Services88/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IQuoteAgent.SaveQuoteVersionNumber">SuperOffice.Services88.IQuoteAgent.SaveQuoteVersionNumber</see> method.

## SaveQuoteVersionNumber

Save the quote version number if it is valid

* **quoteVersionId:** VersionId of the quote version
* **number:** The number to save

**Returns:** True if the number was valid and then saved


[WSDL file for Services88/Quote](../Services88-Quote.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveQuoteVersionNumber Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:SaveQuoteVersionNumber>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
    <Quote:Number xsi:type="xsd:string"></Quote:Number>
   </Quote:SaveQuoteVersionNumber>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveQuoteVersionNumber Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Quote:SaveQuoteVersionNumberResponse>
   <Quote:Response xsi:type="xsd:boolean">false</Quote:Response>
  </Quote:SaveQuoteVersionNumberResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

