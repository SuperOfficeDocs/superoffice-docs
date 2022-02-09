---
title: Services87.EMailAgent.LatestItemIdByFolder SOAP
generated: 1
uid: Services87-EMail-LatestItemIdByFolder
---

# Services87 EMail LatestItemIdByFolder

SOAP request and response examples **Remote/Services87/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IEMailAgent.LatestItemIdByFolder">SuperOffice.Services87.IEMailAgent.LatestItemIdByFolder</see> method.

## LatestItemIdByFolder

Returns the latest id of the mail item by folder
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **folderId:** The folderId for the folder to check for the latest mail id

**Returns:** Mail Item id


[WSDL file for Services87/EMail](../Services87-EMail.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## LatestItemIdByFolder Request

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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <EMail:LatestItemIdByFolderResponse>
   <EMail:Response xsi:type="xsd:int">0</EMail:Response>
  </EMail:LatestItemIdByFolderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

