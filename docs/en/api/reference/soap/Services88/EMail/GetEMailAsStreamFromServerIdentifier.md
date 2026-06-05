---
title: Services88.EMailAgent.GetEMailAsStreamFromServerIdentifier SOAP
generated: true
uid: Services88-EMail-GetEMailAsStreamFromServerIdentifier
content_type: reference
---

# Services88 EMail GetEMailAsStreamFromServerIdentifier

SOAP request and response examples **Remote/Services88/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IEMailAgent.GetEMailAsStreamFromServerIdentifier">SuperOffice.Services88.IEMailAgent.GetEMailAsStreamFromServerIdentifier</see> method.

## GetEMailAsStreamFromServerIdentifier





[WSDL file for Services88/EMail](../Services88-EMail.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetEMailAsStreamFromServerIdentifier Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetEMailAsStreamFromServerIdentifier>
    <EMail:ConnectionInfo xsi:type="EMail:EMailConnectionInfo">
     <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
     <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
     <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
     <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
     <EMail:UseGraphApi xsi:type="xsd:boolean">false</EMail:UseGraphApi>
    </EMail:ConnectionInfo>
    <EMail:MessageServerId xsi:type="xsd:string"></EMail:MessageServerId>
    <EMail:StripAttachments xsi:type="xsd:boolean">false</EMail:StripAttachments>
   </EMail:GetEMailAsStreamFromServerIdentifier>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetEMailAsStreamFromServerIdentifier Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <EMail:GetEMailAsStreamFromServerIdentifierResponse>
   <EMail:Response xsi:type="xsd:base64Binary"></EMail:Response>
  </EMail:GetEMailAsStreamFromServerIdentifierResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

