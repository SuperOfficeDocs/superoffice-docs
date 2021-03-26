---
uid: services82-quote-getproductimage
title: Services82.QuoteAgent.GetProductImage SOAP
Generated: true
---

# Services82 Quote GetProductImage SOAP

SOAP request and response examples **Remote/Services82/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IQuoteAgent.GetProductImage">SuperOffice.Services82.IQuoteAgent.GetProductImage</see> method.

## GetProductImage

Gets an image connected to a product, from the ProductProvider

* **quoteConnectionId:** The connection this product comes from.
* **eRPProductKey:** Primary key of the Product in the ProductProvider
* **rank:** The rank of the image.

**Returns:** The base64 encoded image as a string.


[WSDL file for Services82/Quote](../Services82-Quote.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProductImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetProductImage>
    <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
    <Quote:ERPProductKey xsi:type="xsd:string"></Quote:ERPProductKey>
    <Quote:Rank xsi:type="xsd:int">0</Quote:Rank>
   </Quote:GetProductImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProductImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Quote:GetProductImageResponse>
   <Quote:Response xsi:type="xsd:string"></Quote:Response>
  </Quote:GetProductImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

