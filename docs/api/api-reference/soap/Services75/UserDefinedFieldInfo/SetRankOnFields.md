---
uid: services75-userdefinedfieldinfo-setrankonfields
title: Services75.UserDefinedFieldInfoAgent.SetRankOnFields SOAP
Generated: true
---

# Services75 UserDefinedFieldInfo SetRankOnFields SOAP

SOAP request and response examples **Remote/Services75/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IUserDefinedFieldInfoAgent.SetRankOnFields">SuperOffice.Services75.IUserDefinedFieldInfoAgent.SetRankOnFields</see> method.

## SetRankOnFields

Change rank of user defined fields

* **ownerType:** The user-defined field owner-entity.
* **rankedFieldsIds:** All IDs of this owner-entity in desired rank order



[WSDL file for Services75/UserDefinedFieldInfo](../Services75-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetRankOnFields Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <UserDefinedFieldInfo:ApplicationToken>1234567-1234-9876</UserDefinedFieldInfo:ApplicationToken>
  <UserDefinedFieldInfo:Credentials>
    <UserDefinedFieldInfo:Ticket>7T:1234abcxyzExample==</UserDefinedFieldInfo:Ticket>
  </UserDefinedFieldInfo:Credentials>
 <SOAP-ENV:Body>
   <UserDefinedFieldInfo:SetRankOnFields>
    <UserDefinedFieldInfo:OwnerType xsi:type="UserDefinedFieldInfo:UDefType">Invalid</UserDefinedFieldInfo:OwnerType>
    <UserDefinedFieldInfo:RankedFieldsIds xsi:type="NetServerServices752:ArrayOfint">
     <NetServerServices752:int xsi:type="xsd:int">0</NetServerServices752:int>
    </UserDefinedFieldInfo:RankedFieldsIds>
   </UserDefinedFieldInfo:SetRankOnFields>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetRankOnFields Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <UserDefinedFieldInfo:SetRankOnFieldsResponse>
  </UserDefinedFieldInfo:SetRankOnFieldsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

