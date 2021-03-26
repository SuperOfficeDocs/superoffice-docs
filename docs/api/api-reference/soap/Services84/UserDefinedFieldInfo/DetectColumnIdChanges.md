---
uid: services84-userdefinedfieldinfo-detectcolumnidchanges
title: Services84.UserDefinedFieldInfoAgent.DetectColumnIdChanges SOAP
Generated: true
---

# Services84 UserDefinedFieldInfo DetectColumnIdChanges SOAP

SOAP request and response examples **Remote/Services84/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IUserDefinedFieldInfoAgent.DetectColumnIdChanges">SuperOffice.Services84.IUserDefinedFieldInfoAgent.DetectColumnIdChanges</see> method.

## DetectColumnIdChanges

Detect columnid changes to the admin version (for determining publish warning)

* **ownerType:** The owner type

**Returns:** Returns true if columnid changes where found. i.e. if data needs to be moved during publishing.


[WSDL file for Services84/UserDefinedFieldInfo](../Services84-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DetectColumnIdChanges Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <UserDefinedFieldInfo:ApplicationToken>1234567-1234-9876</UserDefinedFieldInfo:ApplicationToken>
  <UserDefinedFieldInfo:Credentials>
    <UserDefinedFieldInfo:Ticket>7T:1234abcxyzExample==</UserDefinedFieldInfo:Ticket>
  </UserDefinedFieldInfo:Credentials>
 <SOAP-ENV:Body>
   <UserDefinedFieldInfo:DetectColumnIdChanges>
    <UserDefinedFieldInfo:OwnerType xsi:type="UserDefinedFieldInfo:UDefType">Invalid</UserDefinedFieldInfo:OwnerType>
   </UserDefinedFieldInfo:DetectColumnIdChanges>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DetectColumnIdChanges Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <UserDefinedFieldInfo:DetectColumnIdChangesResponse>
   <UserDefinedFieldInfo:Response xsi:type="xsd:boolean">false</UserDefinedFieldInfo:Response>
  </UserDefinedFieldInfo:DetectColumnIdChangesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

