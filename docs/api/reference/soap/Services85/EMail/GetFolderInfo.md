---
title: Services85.EMailAgent.GetFolderInfo SOAP
generated: 1
uid: Services85-EMail-GetFolderInfo
---

# Services85 EMail GetFolderInfo

SOAP request and response examples **Remote/Services85/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IEMailAgent.GetFolderInfo">SuperOffice.Services85.IEMailAgent.GetFolderInfo</see> method.

## GetFolderInfo

Retrieve information about folders.  If folders parameter is not specified(null), information about all subscribed folders will be returned.

* **connectionInfo:** All information needed to connect to the mailserver
* **folders:** Folders to get information about.

**Returns:** Folder information


[WSDL file for Services85/EMail](../Services85-EMail.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFolderInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services85">
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
    <EMail:Folders xsi:type="NetServerServices852:ArrayOfstring">
     <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services85">
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

