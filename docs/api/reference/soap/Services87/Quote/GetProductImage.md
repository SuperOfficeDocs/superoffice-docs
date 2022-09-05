---
title: Services87.QuoteAgent.GetProductImage SOAP
generated: 1
uid: Services87-Quote-GetProductImage
---

# Services87 Quote GetProductImage

SOAP request and response examples **Remote/Services87/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IQuoteAgent.GetProductImage">SuperOffice.Services87.IQuoteAgent.GetProductImage</see> method.

## GetProductImage

Gets an image connected to a product, from the ProductProvider

* **quoteConnectionId:** The connection this product comes from.
* **eRPProductKey:** Primary key of the Product in the ProductProvider
* **rank:** The rank of the image.

**Returns:** The base64 encoded image as a string.


[WSDL file for Services87/Quote](../Services87-Quote.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProductImage Request

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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Quote:GetProductImageResponse>
   <Quote:Response xsi:type="xsd:string"></Quote:Response>
  </Quote:GetProductImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

