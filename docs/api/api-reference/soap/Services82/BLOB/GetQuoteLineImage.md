---
uid: services82-blob-getquotelineimage
title: Services82.BLOBAgent.GetQuoteLineImage SOAP
Generated: true
---

# Services82 BLOB GetQuoteLineImage SOAP

SOAP request and response examples **Remote/Services82/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IBLOBAgent.GetQuoteLineImage">SuperOffice.Services82.IBLOBAgent.GetQuoteLineImage</see> method.

## GetQuoteLineImage

Returns the quoteline image (rank=1) that is displayed in the CRM application.

* **quoteLineId:** The product id of the quoteline the image belongs to.

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)


[WSDL file for Services82/BLOB](../Services82-BLOB.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetQuoteLineImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:GetQuoteLineImage>
    <BLOB:QuoteLineId xsi:type="xsd:int">0</BLOB:QuoteLineId>
   </BLOB:GetQuoteLineImage>

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
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <BLOB:GetQuoteLineImageResponse>
   <BLOB:Response xsi:type="xsd:base64Binary"></BLOB:Response>
  </BLOB:GetQuoteLineImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

