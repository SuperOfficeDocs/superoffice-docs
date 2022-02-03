---
title: Services88.BLOBAgent.ChangeContactImage SOAP
generated: 1
uid: Services88-BLOB-ChangeContactImage
---

# Services88 BLOB ChangeContactImage

SOAP request and response examples **Remote/Services88/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IBLOBAgent.ChangeContactImage">SuperOffice.Services88.IBLOBAgent.ChangeContactImage</see> method.

## ChangeContactImage

Changes the contact image link. If the Binary object id is 0, any image link is removed from the contact.

* **contactId:** The Contact the image is linked to
* **blobId:** The Binary object id. If the Binary object id is 0, any image link is removed from the Contact.



[WSDL file for Services88/BLOB](../Services88-BLOB.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangeContactImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:ChangeContactImage>
    <BLOB:ContactId xsi:type="xsd:int">0</BLOB:ContactId>
    <BLOB:BlobId xsi:type="xsd:int">0</BLOB:BlobId>
   </BLOB:ChangeContactImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChangeContactImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <BLOB:ChangeContactImageResponse>
  </BLOB:ChangeContactImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

