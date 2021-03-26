---
uid: services84-email-getfolderinfo
title: Services84.EMailAgent.GetFolderInfo SOAP
Generated: true
---

# Services84 EMail GetFolderInfo SOAP

SOAP request and response examples **Remote/Services84/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IEMailAgent.GetFolderInfo">SuperOffice.Services84.IEMailAgent.GetFolderInfo</see> method.

## GetFolderInfo

Retrieve information about folders.  If folders parameter is not specified(null), information about all subscribed folders will be returned.

* **connectionInfo:** All information needed to connect to the mailserver
* **folders:** Folders to get information about.

**Returns:** Folder information


[WSDL file for Services84/EMail](../Services84-EMail.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFolderInfo Request

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
   <EMail:GetFolderInfo>
    <EMail:ConnectionInfo xsi:type="EMail:EMailConnectionInfo">
     <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
     <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
     <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
     <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
    </EMail:ConnectionInfo>
    <EMail:Folders xsi:type="NetServerServices842:ArrayOfstring">
     <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
    </EMail:Folders>
   </EMail:GetFolderInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFolderInfo Response

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
  <EMail:GetFolderInfoResponse>
   <EMail:Response xsi:type="EMail:ArrayOfEMailFolder">
    <EMail:EMailFolder xsi:type="EMail:EMailFolder">
     <EMail:Name xsi:type="xsd:string"></EMail:Name>
     <EMail:Delimiter xsi:type="xsd:string"></EMail:Delimiter>
     <EMail:Flags xsi:type="xsd:string"></EMail:Flags>
     <EMail:TotalItems xsi:type="xsd:int">0</EMail:TotalItems>
     <EMail:UnreadItems xsi:type="xsd:int">0</EMail:UnreadItems>
     <EMail:Subscribed xsi:type="xsd:boolean">false</EMail:Subscribed>
     <EMail:EmailFolderId xsi:type="xsd:int">0</EMail:EmailFolderId>
    </EMail:EMailFolder>
   </EMail:Response>
  </EMail:GetFolderInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

