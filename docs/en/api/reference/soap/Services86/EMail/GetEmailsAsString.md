---
title: Services86.EMailAgent.GetEmailsAsString SOAP
generated: 1
uid: Services86-EMail-GetEmailsAsString
---

# Services86 EMail GetEmailsAsString

SOAP request and response examples **Remote/Services86/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IEMailAgent.GetEmailsAsString">SuperOffice.Services86.IEMailAgent.GetEmailsAsString</see> method.

## GetEmailsAsString

<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **connectionInfoExtended:**
* **messageIds:**

[WSDL file for Services86/EMail](../Services86-EMail.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetEmailsAsString Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetEmailsAsString>
    <EMail:ConnectionInfoExtended xsi:type="EMail:EMailConnectionInfoExtended">
     <EMail:Port xsi:type="xsd:int">0</EMail:Port>
     <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
     <EMail:Protocol xsi:type="xsd:string"></EMail:Protocol>
     <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
     <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
     <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
    </EMail:ConnectionInfoExtended>
    <EMail:MessageIds xsi:type="NetServerServices862:ArrayOfstring">
     <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
    </EMail:MessageIds>
   </EMail:GetEmailsAsString>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetEmailsAsString Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <EMail:GetEmailsAsStringResponse>
   <EMail:Response xsi:type="NetServerServices862:ArrayOfstring">
    <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
   </EMail:Response>
  </EMail:GetEmailsAsStringResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```