---
title: Services86.UserAgent.GetDataRights SOAP
generated: 1
uid: Services86-User-GetDataRights
---

# Services86 User GetDataRights

SOAP request and response examples **Remote/Services86/User.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IUserAgent.GetDataRights">SuperOffice.Services86.IUserAgent.GetDataRights</see> method.

## GetDataRights

Read specific a set of data rights at the given row in the rights matrix. An exception will be thrown if non existing position is specified.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **roleId:** The role id to set the data right for
* **tableName:** The name of the entity/table

**Returns:** The data right values for all the defined relationships (C, CR, CRU, or CRUD)


[WSDL file for Services86/User](../Services86-User.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDataRights Request

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
   <User:GetDataRights>
    <User:RoleId xsi:type="xsd:int">0</User:RoleId>
    <User:TableName xsi:type="xsd:string"></User:TableName>
   </User:GetDataRights>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDataRights Response

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
  <User:GetDataRightsResponse>
   <User:Response xsi:type="User:StringDictionary">
    <User:StringKeyValuePair>
     <User:Key xsi:type="xsd:string"></User:Key>
     <User:Value xsi:type="xsd:string"></User:Value>
    </User:StringKeyValuePair>
   </User:Response>
  </User:GetDataRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

