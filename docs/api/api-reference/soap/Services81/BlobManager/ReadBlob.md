---
uid: services81-blobmanager-readblob
title: Services81.BlobManagerAgent.ReadBlob SOAP
Generated: true
---

# Services81 BlobManager ReadBlob SOAP

SOAP request and response examples **Remote/Services81/BlobManager.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IBlobManagerAgent.ReadBlob">SuperOffice.Services81.IBlobManagerAgent.ReadBlob</see> method.

## ReadBlob





[WSDL file for Services81/BlobManager](../Services81-BlobManager.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ReadBlob Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BlobManager="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <BlobManager:ApplicationToken>1234567-1234-9876</BlobManager:ApplicationToken>
  <BlobManager:Credentials>
    <BlobManager:Ticket>7T:1234abcxyzExample==</BlobManager:Ticket>
  </BlobManager:Credentials>
 <SOAP-ENV:Body>
   <BlobManager:ReadBlob>
    <BlobManager:BlobId xsi:type="xsd:int">0</BlobManager:BlobId>
   </BlobManager:ReadBlob>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ReadBlob Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BlobManager="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <BlobManager:ReadBlobResponse>
   <BlobManager:Length xsi:type="xsd:int">0</BlobManager:Length>
   <BlobManager:Response xsi:type="xsd:string"></BlobManager:Response>
  </BlobManager:ReadBlobResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

