---
uid: services80-blobmanager-writeblob
title: Services80.BlobManagerAgent.WriteBlob SOAP
Generated: true
---

# Services80 BlobManager WriteBlob SOAP

SOAP request and response examples **Remote/Services80/BlobManager.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IBlobManagerAgent.WriteBlob">SuperOffice.Services80.IBlobManagerAgent.WriteBlob</see> method.

## WriteBlob





[WSDL file for Services80/BlobManager](../Services80-BlobManager.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## WriteBlob Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BlobManager="http://www.superoffice.net/ws/crm/NetServer/Services80">
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
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BlobManager="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <BlobManager:WriteBlobResponse>
  </BlobManager:WriteBlobResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

