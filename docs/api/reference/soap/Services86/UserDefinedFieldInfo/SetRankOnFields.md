---
title: Services86.UserDefinedFieldInfoAgent.SetRankOnFields SOAP
generated: 1
uid: Services86-UserDefinedFieldInfo-SetRankOnFields
---

# Services86 UserDefinedFieldInfo SetRankOnFields

SOAP request and response examples **Remote/Services86/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IUserDefinedFieldInfoAgent.SetRankOnFields">SuperOffice.Services86.IUserDefinedFieldInfoAgent.SetRankOnFields</see> method.

## SetRankOnFields

Change rank of user defined fields

* **ownerType:** The user-defined field owner-entity.
* **rankedFieldsIds:** All IDs of this owner-entity in desired rank order



[WSDL file for Services86/UserDefinedFieldInfo](../Services86-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetRankOnFields Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <UserDefinedFieldInfo:ApplicationToken>1234567-1234-9876</UserDefinedFieldInfo:ApplicationToken>
  <UserDefinedFieldInfo:Credentials>
    <UserDefinedFieldInfo:Ticket>7T:1234abcxyzExample==</UserDefinedFieldInfo:Ticket>
  </UserDefinedFieldInfo:Credentials>
 <SOAP-ENV:Body>
   <UserDefinedFieldInfo:SetRankOnFields>
    <UserDefinedFieldInfo:OwnerType xsi:type="UserDefinedFieldInfo:UDefType">Invalid</UserDefinedFieldInfo:OwnerType>
    <UserDefinedFieldInfo:RankedFieldsIds xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <UserDefinedFieldInfo:SetRankOnFieldsResponse>
  </UserDefinedFieldInfo:SetRankOnFieldsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

