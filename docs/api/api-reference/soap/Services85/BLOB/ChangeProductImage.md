---
title: Services85.BLOBAgent.ChangeProductImage SOAP
generated: 1
uid: Services85-BLOB-ChangeProductImage
---

# Services85 BLOB ChangeProductImage

SOAP request and response examples **Remote/Services85/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IBLOBAgent.ChangeProductImage">SuperOffice.Services85.IBLOBAgent.ChangeProductImage</see> method.

## ChangeProductImage



* **productId:** The product the image is linked to
* **blobId:** The Binary object id. If the Binary object id is 0, any image link is removed from the product.



[WSDL file for Services85/BLOB](../Services85-BLOB.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangeProductImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services85">
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
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <BLOB:ChangeProductImageResponse>
  </BLOB:ChangeProductImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

