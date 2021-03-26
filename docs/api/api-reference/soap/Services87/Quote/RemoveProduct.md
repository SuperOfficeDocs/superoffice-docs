---
uid: services87-quote-removeproduct
title: Services87.QuoteAgent.RemoveProduct SOAP
Generated: true
---

# Services87 Quote RemoveProduct SOAP

SOAP request and response examples **Remote/Services87/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IQuoteAgent.RemoveProduct">SuperOffice.Services87.IQuoteAgent.RemoveProduct</see> method.

## RemoveProduct

Removes a product from the database

* **productId:** The database id of the product to remove



[WSDL file for Services87/Quote](../Services87-Quote.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveProduct Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:RemoveProduct>
    <Quote:ProductId xsi:type="xsd:int">0</Quote:ProductId>
   </Quote:RemoveProduct>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveProduct Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Quote:RemoveProductResponse>
  </Quote:RemoveProductResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

