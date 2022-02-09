---
title: Services84.EMailAgent.RefreshFolderForAssociate SOAP
generated: 1
uid: Services84-EMail-RefreshFolderForAssociate
---

# Services84 EMail RefreshFolderForAssociate

SOAP request and response examples **Remote/Services84/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IEMailAgent.RefreshFolderForAssociate">SuperOffice.Services84.IEMailAgent.RefreshFolderForAssociate</see> method.

## RefreshFolderForAssociate

Get all emails in folder(s) from current associate

* **folders:** List of folder names to refresh

**Returns:** JSON serialized string containing array of data about each folder


[WSDL file for Services84/EMail](../Services84-EMail.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RefreshFolderForAssociate Request

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
   <EMail:RefreshFolderForAssociate>
    <EMail:Folders xsi:type="NetServerServices842:ArrayOfstring">
     <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
    </EMail:Folders>
   </EMail:RefreshFolderForAssociate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RefreshFolderForAssociate Response

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
  <EMail:RefreshFolderForAssociateResponse>
   <EMail:Response xsi:type="xsd:string"></EMail:Response>
  </EMail:RefreshFolderForAssociateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

