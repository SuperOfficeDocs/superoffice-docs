---
uid: services75-email-getfolderemailcount
title: Services75.EMailAgent.GetFolderEMailCount SOAP
Generated: true
---

# Services75 EMail GetFolderEMailCount SOAP

SOAP request and response examples **Remote/Services75/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IEMailAgent.GetFolderEMailCount">SuperOffice.Services75.IEMailAgent.GetFolderEMailCount</see> method.

## GetFolderEMailCount

Retrieve total/unread mail items in current folder

* **connectionInfo:** All information needed to connect to the mailserver
* **onlyUnread:** If true, only unread items are counted

**Returns:** Number of mail items


[WSDL file for Services75/EMail](../Services75-EMail.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFolderEMailCount Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetFolderEMailCount>
    <EMail:ConnectionInfo xsi:type="EMail:EMailConnectionInfo">
     <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
     <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
     <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
     <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
    </EMail:ConnectionInfo>
    <EMail:OnlyUnread xsi:type="xsd:boolean">false</EMail:OnlyUnread>
   </EMail:GetFolderEMailCount>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFolderEMailCount Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <EMail:GetFolderEMailCountResponse>
   <EMail:Response xsi:type="xsd:int">0</EMail:Response>
  </EMail:GetFolderEMailCountResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

