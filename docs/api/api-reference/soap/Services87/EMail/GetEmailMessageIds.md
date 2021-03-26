---
uid: services87-email-getemailmessageids
title: Services87.EMailAgent.GetEmailMessageIds SOAP
Generated: true
---

# Services87 EMail GetEmailMessageIds SOAP

SOAP request and response examples **Remote/Services87/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IEMailAgent.GetEmailMessageIds">SuperOffice.Services87.IEMailAgent.GetEmailMessageIds</see> method.

## GetEmailMessageIds

<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **connectionInfoExtended:** 



[WSDL file for Services87/EMail](../Services87-EMail.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetEmailMessageIds Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetEmailMessageIds>
    <EMail:ConnectionInfoExtended xsi:type="EMail:EMailConnectionInfoExtended">
     <EMail:Port xsi:type="xsd:int">0</EMail:Port>
     <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
     <EMail:Protocol xsi:type="xsd:string"></EMail:Protocol>
     <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
     <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
     <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
    </EMail:ConnectionInfoExtended>
   </EMail:GetEmailMessageIds>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetEmailMessageIds Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <EMail:GetEmailMessageIdsResponse>
   <EMail:Response xsi:type="NetServerServices872:ArrayOfstring">
    <NetServerServices872:string xsi:type="xsd:string"></NetServerServices872:string>
   </EMail:Response>
  </EMail:GetEmailMessageIdsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

