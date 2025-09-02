---
title: Services88.AssociateAgent.GetEncryptionKey SOAP
generated: true
uid: Services88-Associate-GetEncryptionKey
content_type: reference
---

# Services88 Associate GetEncryptionKey

SOAP request and response examples **Remote/Services88/Associate.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAssociateAgent.GetEncryptionKey">SuperOffice.Services88.IAssociateAgent.GetEncryptionKey</see> method.

## GetEncryptionKey





[WSDL file for Services88/Associate](../Services88-Associate.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetEncryptionKey Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Associate:ApplicationToken>1234567-1234-9876</Associate:ApplicationToken>
  <Associate:Credentials>
    <Associate:Ticket>7T:1234abcxyzExample==</Associate:Ticket>
  </Associate:Credentials>
 <SOAP-ENV:Body>
   <Associate:GetEncryptionKey>
   </Associate:GetEncryptionKey>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetEncryptionKey Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Associate:GetEncryptionKeyResponse>
   <Associate:Response xsi:type="xsd:string"></Associate:Response>
  </Associate:GetEncryptionKeyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

