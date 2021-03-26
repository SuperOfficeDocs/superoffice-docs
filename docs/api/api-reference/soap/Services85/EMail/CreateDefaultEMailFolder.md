---
uid: services85-email-createdefaultemailfolder
title: Services85.EMailAgent.CreateDefaultEMailFolder SOAP
Generated: true
---

# Services85 EMail CreateDefaultEMailFolder SOAP

SOAP request and response examples **Remote/Services85/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IEMailAgent.CreateDefaultEMailFolder">SuperOffice.Services85.IEMailAgent.CreateDefaultEMailFolder</see> method.

## CreateDefaultEMailFolder

Loading default values into a new EMailFolder.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New EMailFolder with default values


[WSDL file for Services85/EMail](../Services85-EMail.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultEMailFolder Request

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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services85">
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

