---
uid: services80-blob-changepersonimage
title: Services80.BLOBAgent.ChangePersonImage SOAP
Generated: true
---

# Services80 BLOB ChangePersonImage SOAP

SOAP request and response examples **Remote/Services80/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IBLOBAgent.ChangePersonImage">SuperOffice.Services80.IBLOBAgent.ChangePersonImage</see> method.

## ChangePersonImage



* **personId:** The person the image is linked to
* **blobId:** The Binary object id. If the Binary object id is 0, any image link is removed from the person.



[WSDL file for Services80/BLOB](../Services80-BLOB.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangePersonImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:ChangePersonImage>
    <BLOB:PersonId xsi:type="xsd:int">0</BLOB:PersonId>
    <BLOB:BlobId xsi:type="xsd:int">0</BLOB:BlobId>
   </BLOB:ChangePersonImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChangePersonImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <BLOB:ChangePersonImageResponse>
  </BLOB:ChangePersonImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

