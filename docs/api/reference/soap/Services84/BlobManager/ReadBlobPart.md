---
title: Services84.BlobManagerAgent.ReadBlobPart SOAP
generated: 1
uid: Services84-BlobManager-ReadBlobPart
---

# Services84 BlobManager ReadBlobPart

SOAP request and response examples **Remote/Services84/BlobManager.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IBlobManagerAgent.ReadBlobPart">SuperOffice.Services84.IBlobManagerAgent.ReadBlobPart</see> method.

## ReadBlobPart





[WSDL file for Services84/BlobManager](../Services84-BlobManager.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ReadBlobPart Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BlobManager="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <BlobManager:ApplicationToken>1234567-1234-9876</BlobManager:ApplicationToken>
  <BlobManager:Credentials>
    <BlobManager:Ticket>7T:1234abcxyzExample==</BlobManager:Ticket>
  </BlobManager:Credentials>
 <SOAP-ENV:Body>
   <BlobManager:ReadBlobPart>
    <BlobManager:BlobId xsi:type="xsd:int">0</BlobManager:BlobId>
    <BlobManager:BlobPosition xsi:type="xsd:long">0</BlobManager:BlobPosition>
    <BlobManager:Length xsi:type="xsd:int">0</BlobManager:Length>
   </BlobManager:ReadBlobPart>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ReadBlobPart Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BlobManager="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <BlobManager:ReadBlobPartResponse>
   <BlobManager:Response xsi:type="xsd:string"></BlobManager:Response>
   <BlobManager:Length xsi:type="xsd:int">0</BlobManager:Length>
  </BlobManager:ReadBlobPartResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

