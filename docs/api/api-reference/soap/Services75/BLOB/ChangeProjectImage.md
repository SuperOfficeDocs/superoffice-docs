---
uid: services75-blob-changeprojectimage
title: Services75.BLOBAgent.ChangeProjectImage SOAP
Generated: true
---

# Services75 BLOB ChangeProjectImage SOAP

SOAP request and response examples **Remote/Services75/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IBLOBAgent.ChangeProjectImage">SuperOffice.Services75.IBLOBAgent.ChangeProjectImage</see> method.

## ChangeProjectImage

Changes the project image link. If the Binary object id is 0, any image link is removed from the project.

* **projectId:** The project the image is linked to
* **blobId:** The Binary object id. If the Binary object id is 0, any image link is removed from the project.



[WSDL file for Services75/BLOB](../Services75-BLOB.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangeProjectImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:ChangeProjectImage>
    <BLOB:ProjectId xsi:type="xsd:int">0</BLOB:ProjectId>
    <BLOB:BlobId xsi:type="xsd:int">0</BLOB:BlobId>
   </BLOB:ChangeProjectImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChangeProjectImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <BLOB:ChangeProjectImageResponse>
  </BLOB:ChangeProjectImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

