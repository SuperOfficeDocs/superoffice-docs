---
title: Services87.BLOBAgent.DeleteBlobEntity SOAP
generated: 1
uid: Services87-BLOB-DeleteBlobEntity
---

# Services87 BLOB DeleteBlobEntity

SOAP request and response examples **Remote/Services87/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IBLOBAgent.DeleteBlobEntity">SuperOffice.Services87.IBLOBAgent.DeleteBlobEntity</see> method.

## DeleteBlobEntity

Deletes the BlobEntity

* **blobEntityId:** The identity of the BlobEntity



[WSDL file for Services87/BLOB](../Services87-BLOB.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteBlobEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:DeleteBlobEntity>
    <BLOB:BlobEntityId xsi:type="xsd:int">0</BLOB:BlobEntityId>
   </BLOB:DeleteBlobEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteBlobEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <BLOB:DeleteBlobEntityResponse>
  </BLOB:DeleteBlobEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

