---
title: Services88.EMailAgent.MoveToFolder SOAP
generated: 1
uid: Services88-EMail-MoveToFolder
---

# Services88 EMail MoveToFolder

SOAP request and response examples **Remote/Services88/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IEMailAgent.MoveToFolder">SuperOffice.Services88.IEMailAgent.MoveToFolder</see> method.

## MoveToFolder

Moved specified items from current folder to targetFolder
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **connectionInfo:** All information needed to connect to the mailserver
* **messageServerIds:** The e-mails to handle
* **targetFolder:** Name of folder to move items to



[WSDL file for Services88/EMail](../Services88-EMail.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## MoveToFolder Request

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
   <EMail:MoveToFolder>
    <EMail:ConnectionInfo xsi:type="EMail:EMailConnectionInfo">
     <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
     <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
     <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
     <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
    </EMail:ConnectionInfo>
    <EMail:MessageServerIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </EMail:MessageServerIds>
    <EMail:TargetFolder xsi:type="xsd:string"></EMail:TargetFolder>
   </EMail:MoveToFolder>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## MoveToFolder Response

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
  <EMail:MoveToFolderResponse>
  </EMail:MoveToFolderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

