---
uid: services85-email-latestitemidbyfolder
title: Services85.EMailAgent.LatestItemIdByFolder SOAP
Generated: true
---

# Services85 EMail LatestItemIdByFolder SOAP

SOAP request and response examples **Remote/Services85/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IEMailAgent.LatestItemIdByFolder">SuperOffice.Services85.IEMailAgent.LatestItemIdByFolder</see> method.

## LatestItemIdByFolder

Returns the latest id of the mail item by folder

* **folderId:** The folderId for the folder to check for the lastest mail id

**Returns:** Mail Item id


[WSDL file for Services85/EMail](../Services85-EMail.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## LatestItemIdByFolder Request

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
   <EMail:LatestItemIdByFolder>
    <EMail:FolderId xsi:type="xsd:int">0</EMail:FolderId>
   </EMail:LatestItemIdByFolder>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## LatestItemIdByFolder Response

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
  <EMail:LatestItemIdByFolderResponse>
   <EMail:Response xsi:type="xsd:int">0</EMail:Response>
  </EMail:LatestItemIdByFolderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

