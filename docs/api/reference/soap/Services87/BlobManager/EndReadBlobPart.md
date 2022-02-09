---
title: Services87.BlobManagerAgent.EndReadBlobPart SOAP
generated: 1
uid: Services87-BlobManager-EndReadBlobPart
---

# Services87 BlobManager EndReadBlobPart

SOAP request and response examples **Remote/Services87/BlobManager.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IBlobManagerAgent.EndReadBlobPart">SuperOffice.Services87.IBlobManagerAgent.EndReadBlobPart</see> method.

## EndReadBlobPart





[WSDL file for Services87/BlobManager](../Services87-BlobManager.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## EndReadBlobPart Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BlobManager="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <BlobManager:ApplicationToken>1234567-1234-9876</BlobManager:ApplicationToken>
  <BlobManager:Credentials>
    <BlobManager:Ticket>7T:1234abcxyzExample==</BlobManager:Ticket>
  </BlobManager:Credentials>
 <SOAP-ENV:Body>
   <BlobManager:EndReadBlobPart>
    <BlobManager:BlobId xsi:type="xsd:int">0</BlobManager:BlobId>
   </BlobManager:EndReadBlobPart>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## EndReadBlobPart Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BlobManager="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <BlobManager:EndReadBlobPartResponse>
  </BlobManager:EndReadBlobPartResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

