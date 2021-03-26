---
uid: services82-blob-changeproductimage
title: Services82.BLOBAgent.ChangeProductImage SOAP
Generated: true
---

# Services82 BLOB ChangeProductImage SOAP

SOAP request and response examples **Remote/Services82/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IBLOBAgent.ChangeProductImage">SuperOffice.Services82.IBLOBAgent.ChangeProductImage</see> method.

## ChangeProductImage



* **productId:** The product the image is linked to
* **blobId:** The Binary object id. If the Binary object id is 0, any image link is removed from the product.



[WSDL file for Services82/BLOB](../Services82-BLOB.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangeProductImage Request

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
   <BLOB:ChangeProductImage>
    <BLOB:ProductId xsi:type="xsd:int">0</BLOB:ProductId>
    <BLOB:BlobId xsi:type="xsd:int">0</BLOB:BlobId>
   </BLOB:ChangeProductImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChangeProductImage Response

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
  <BLOB:ChangeProductImageResponse>
  </BLOB:ChangeProductImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

