---
title: Services84.EMailAgent.CreateDefaultEMailFolder SOAP
generated: 1
uid: Services84-EMail-CreateDefaultEMailFolder
---

# Services84 EMail CreateDefaultEMailFolder

SOAP request and response examples **Remote/Services84/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IEMailAgent.CreateDefaultEMailFolder">SuperOffice.Services84.IEMailAgent.CreateDefaultEMailFolder</see> method.

## CreateDefaultEMailFolder

Loading default values into a new EMailFolder.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New EMailFolder with default values


[WSDL file for Services84/EMail](../Services84-EMail.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultEMailFolder Request

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
   <EMail:CreateDefaultEMailFolder>
   </EMail:CreateDefaultEMailFolder>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultEMailFolder Response

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
  <EMail:CreateDefaultEMailFolderResponse>
   <EMail:Response xsi:type="EMail:EMailFolder">
    <EMail:Name xsi:type="xsd:string"></EMail:Name>
    <EMail:Delimiter xsi:type="xsd:string"></EMail:Delimiter>
    <EMail:Flags xsi:type="xsd:string"></EMail:Flags>
    <EMail:TotalItems xsi:type="xsd:int">0</EMail:TotalItems>
    <EMail:UnreadItems xsi:type="xsd:int">0</EMail:UnreadItems>
    <EMail:Subscribed xsi:type="xsd:boolean">false</EMail:Subscribed>
    <EMail:EmailFolderId xsi:type="xsd:int">0</EMail:EmailFolderId>
   </EMail:Response>
  </EMail:CreateDefaultEMailFolderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

