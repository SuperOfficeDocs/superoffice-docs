---
title: Services88.UserAgent.GetAllDataRights SOAP
generated: true
uid: Services88-User-GetAllDataRights
content_type: reference
---

# Services88 User GetAllDataRights

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.GetAllDataRights">SuperOffice.Services88.IUserAgent.GetAllDataRights</see> method.

## GetAllDataRights





[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllDataRights Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:GetAllDataRights>
    <User:RoleId xsi:type="xsd:int">0</User:RoleId>
    <User:RelationToOwner xsi:type="User:RoleRelationToOwner">MyOwn</User:RelationToOwner>
   </User:GetAllDataRights>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllDataRights Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <User:GetAllDataRightsResponse>
   <User:Response xsi:type="User:StringDictionary">
    <User:StringKeyValuePair>
     <User:Key xsi:type="xsd:string"></User:Key>
     <User:Value xsi:type="xsd:string"></User:Value>
    </User:StringKeyValuePair>
   </User:Response>
  </User:GetAllDataRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

