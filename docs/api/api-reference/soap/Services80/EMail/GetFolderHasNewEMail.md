---
uid: services80-email-getfolderhasnewemail
title: Services80.EMailAgent.GetFolderHasNewEMail SOAP
Generated: true
---

# Services80 EMail GetFolderHasNewEMail SOAP

SOAP request and response examples **Remote/Services80/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IEMailAgent.GetFolderHasNewEMail">SuperOffice.Services80.IEMailAgent.GetFolderHasNewEMail</see> method.

## GetFolderHasNewEMail

Check if folder has received new items since previous access.

* **connectionInfo:** All information needed to connect to the mailserver

**Returns:** True if new mail is available.


[WSDL file for Services80/EMail](../Services80-EMail.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFolderHasNewEMail Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetFolderHasNewEMail>
    <EMail:ConnectionInfo xsi:type="EMail:EMailConnectionInfo">
     <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
     <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
     <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
     <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
    </EMail:ConnectionInfo>
   </EMail:GetFolderHasNewEMail>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFolderHasNewEMail Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <EMail:GetFolderHasNewEMailResponse>
   <EMail:Response xsi:type="xsd:boolean">false</EMail:Response>
  </EMail:GetFolderHasNewEMailResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

