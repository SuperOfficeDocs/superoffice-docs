---
uid: services83-blobmanager-writeblob
title: Services83.BlobManagerAgent.WriteBlob SOAP
Generated: true
---

# Services83 BlobManager WriteBlob SOAP

SOAP request and response examples **Remote/Services83/BlobManager.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IBlobManagerAgent.WriteBlob">SuperOffice.Services83.IBlobManagerAgent.WriteBlob</see> method.

## WriteBlob





[WSDL file for Services83/BlobManager](../Services83-BlobManager.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## WriteBlob Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BlobManager="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <BlobManager:ApplicationToken>1234567-1234-9876</BlobManager:ApplicationToken>
  <BlobManager:Credentials>
    <BlobManager:Ticket>7T:1234abcxyzExample==</BlobManager:Ticket>
  </BlobManager:Credentials>
 <SOAP-ENV:Body>
   <BlobManager:WriteBlob>
    <BlobManager:BlobId xsi:type="xsd:int">0</BlobManager:BlobId>
    <BlobManager:Blob xsi:type="xsd:string"></BlobManager:Blob>
   </BlobManager:WriteBlob>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## WriteBlob Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BlobManager="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <BlobManager:WriteBlobResponse>
  </BlobManager:WriteBlobResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

