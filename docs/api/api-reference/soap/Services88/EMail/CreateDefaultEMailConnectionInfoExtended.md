---
title: Services88.EMailAgent.CreateDefaultEMailConnectionInfoExtended SOAP
generated: 1
uid: Services88-EMail-CreateDefaultEMailConnectionInfoExtended
---

# Services88 EMail CreateDefaultEMailConnectionInfoExtended

SOAP request and response examples **Remote/Services88/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IEMailAgent.CreateDefaultEMailConnectionInfoExtended">SuperOffice.Services88.IEMailAgent.CreateDefaultEMailConnectionInfoExtended</see> method.

## CreateDefaultEMailConnectionInfoExtended

Loading default values into a new EMailConnectionInfoExtended.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.


**Returns:** New EMailConnectionInfoExtended with default values


[WSDL file for Services88/EMail](../Services88-EMail.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultEMailConnectionInfoExtended Request

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
   <EMail:CreateDefaultEMailConnectionInfoExtended>
   </EMail:CreateDefaultEMailConnectionInfoExtended>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultEMailConnectionInfoExtended Response

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
  <EMail:CreateDefaultEMailConnectionInfoExtendedResponse>
   <EMail:Response xsi:type="EMail:EMailConnectionInfoExtended">
    <EMail:Port xsi:type="xsd:int">0</EMail:Port>
    <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
    <EMail:Protocol xsi:type="xsd:string"></EMail:Protocol>
    <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
    <EMail:Password xsi:type="xsd:string"></EMail:Password>
    <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
    <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
   </EMail:Response>
  </EMail:CreateDefaultEMailConnectionInfoExtendedResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

