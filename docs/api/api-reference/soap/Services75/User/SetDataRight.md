---
uid: services75-user-setdataright
title: Services75.UserAgent.SetDataRight SOAP
Generated: true
---

# Services75 User SetDataRight SOAP

SOAP request and response examples **Remote/Services75/User.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IUserAgent.SetDataRight">SuperOffice.Services75.IUserAgent.SetDataRight</see> method.

## SetDataRight

This method will set one specific data right at the given position. An exception will be thrown if non existing position is specified.

* **roleId:** The role id to set the data right for
* **tableName:** The name of the entity/table
* **relationToOwner:** The id of the relation to owner
* **dataRightValue:** The data right value to set at the specified position (CRUD)



[WSDL file for Services75/User](../Services75-User.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetDataRight Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services75">
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
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <User:SetDataRightResponse>
  </User:SetDataRightResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

