---
title: Services84.EMailAgent.Authenticate SOAP
generated: 1
uid: Services84-EMail-Authenticate
---

# Services84 EMail Authenticate

SOAP request and response examples **Remote/Services84/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IEMailAgent.Authenticate">SuperOffice.Services84.IEMailAgent.Authenticate</see> method.

## Authenticate



* **connectionInfoExtended:** 



[WSDL file for Services84/EMail](../Services84-EMail.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Authenticate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:Authenticate>
    <EMail:ConnectionInfoExtended xsi:type="EMail:EMailConnectionInfoExtended">
     <EMail:Port xsi:type="xsd:int">0</EMail:Port>
     <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
     <EMail:Protocol xsi:type="xsd:string"></EMail:Protocol>
     <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
     <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
     <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
    </EMail:ConnectionInfoExtended>
   </EMail:Authenticate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Authenticate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <EMail:AuthenticateResponse>
   <EMail:Response xsi:type="xsd:boolean">false</EMail:Response>
  </EMail:AuthenticateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

