---
title: Services86.UserAgent.SetDataRight SOAP
generated: 1
uid: Services86-User-SetDataRight
---

# Services86 User SetDataRight

SOAP request and response examples **Remote/Services86/User.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IUserAgent.SetDataRight">SuperOffice.Services86.IUserAgent.SetDataRight</see> method.

## SetDataRight

[WSDL file for Services86/User](../Services86-User.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetDataRight Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:SetDataRight>
    <User:RoleId xsi:type="xsd:int">0</User:RoleId>
    <User:TableName xsi:type="xsd:string"></User:TableName>
    <User:RelationToOwner xsi:type="User:RoleRelationToOwner">MyOwn</User:RelationToOwner>
    <User:DataRightValue xsi:type="xsd:string"></User:DataRightValue>
   </User:SetDataRight>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## SetDataRight Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <User:SetDataRightResponse>
  </User:SetDataRightResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
