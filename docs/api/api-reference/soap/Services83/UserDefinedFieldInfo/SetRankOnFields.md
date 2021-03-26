---
uid: services83-userdefinedfieldinfo-setrankonfields
title: Services83.UserDefinedFieldInfoAgent.SetRankOnFields SOAP
Generated: true
---

# Services83 UserDefinedFieldInfo SetRankOnFields SOAP

SOAP request and response examples **Remote/Services83/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IUserDefinedFieldInfoAgent.SetRankOnFields">SuperOffice.Services83.IUserDefinedFieldInfoAgent.SetRankOnFields</see> method.

## SetRankOnFields

Change rank of user defined fields

* **ownerType:** The user-defined field owner-entity.
* **rankedFieldsIds:** All IDs of this owner-entity in desired rank order



[WSDL file for Services83/UserDefinedFieldInfo](../Services83-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetRankOnFields Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <UserDefinedFieldInfo:ApplicationToken>1234567-1234-9876</UserDefinedFieldInfo:ApplicationToken>
  <UserDefinedFieldInfo:Credentials>
    <UserDefinedFieldInfo:Ticket>7T:1234abcxyzExample==</UserDefinedFieldInfo:Ticket>
  </UserDefinedFieldInfo:Credentials>
 <SOAP-ENV:Body>
   <UserDefinedFieldInfo:SetRankOnFields>
    <UserDefinedFieldInfo:OwnerType xsi:type="UserDefinedFieldInfo:UDefType">Invalid</UserDefinedFieldInfo:OwnerType>
    <UserDefinedFieldInfo:RankedFieldsIds xsi:type="NetServerServices832:ArrayOfint">
     <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
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
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <UserDefinedFieldInfo:SetRankOnFieldsResponse>
  </UserDefinedFieldInfo:SetRankOnFieldsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

