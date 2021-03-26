---
uid: services81-email-getfolderlist
title: Services81.EMailAgent.GetFolderList SOAP
Generated: true
---

# Services81 EMail GetFolderList SOAP

SOAP request and response examples **Remote/Services81/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IEMailAgent.GetFolderList">SuperOffice.Services81.IEMailAgent.GetFolderList</see> method.

## GetFolderList

Retrieve all folders for the mail account. String is separated in sections by the paragraph character.  First section contains the folder delimeter char. Next is folder name. Additional sections may be unread and total items.

* **connectionInfo:** All information needed to connect to the mailserver
* **includeItemCount:** If true, unread and total items are added to the foldername separated by a comma

**Returns:** List of available folders as a string array


[WSDL file for Services81/EMail](../Services81-EMail.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFolderList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetFolderList>
    <EMail:ConnectionInfo xsi:type="EMail:EMailConnectionInfo">
     <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
     <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
     <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
     <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
    </EMail:ConnectionInfo>
    <EMail:IncludeItemCount xsi:type="xsd:boolean">false</EMail:IncludeItemCount>
   </EMail:GetFolderList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFolderList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <EMail:GetFolderListResponse>
   <EMail:Response xsi:type="NetServerServices812:ArrayOfstring">
    <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
   </EMail:Response>
  </EMail:GetFolderListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

