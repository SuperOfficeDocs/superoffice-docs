---
title: Services88.QuoteAgent.DeleteQuoteLine SOAP
generated: 1
uid: Services88-Quote-DeleteQuoteLine
---

# Services88 Quote DeleteQuoteLine

SOAP request and response examples **Remote/Services88/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IQuoteAgent.DeleteQuoteLine">SuperOffice.Services88.IQuoteAgent.DeleteQuoteLine</see> method.

## DeleteQuoteLine

Deletes the QuoteLine in the SuperOffice database

* **quoteLineId:** Primary key of the quoteline to delete

**Returns:** Nothing


[WSDL file for Services88/Quote](../Services88-Quote.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteQuoteLine Request

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
   <Quote:DeleteQuoteLine>
    <Quote:QuoteLineId xsi:type="xsd:int">0</Quote:QuoteLineId>
   </Quote:DeleteQuoteLine>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteQuoteLine Response

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
  <Quote:DeleteQuoteLineResponse>
  </Quote:DeleteQuoteLineResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

