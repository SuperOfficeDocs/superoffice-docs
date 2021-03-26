---
uid: services82-userdefinedfieldinfo-setpageonefieldgrouping
title: Services82.UserDefinedFieldInfoAgent.SetPageOneFieldGrouping SOAP
Generated: true
---

# Services82 UserDefinedFieldInfo SetPageOneFieldGrouping SOAP

SOAP request and response examples **Remote/Services82/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IUserDefinedFieldInfoAgent.SetPageOneFieldGrouping">SuperOffice.Services82.IUserDefinedFieldInfoAgent.SetPageOneFieldGrouping</see> method.

## SetPageOneFieldGrouping

Sets the Page One Field grouping for a specific entity

* **ownerType:** The user-defined field owner-entity.
* **active:** If true, use grouping



[WSDL file for Services82/UserDefinedFieldInfo](../Services82-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetPageOneFieldGrouping Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <UserDefinedFieldInfo:ApplicationToken>1234567-1234-9876</UserDefinedFieldInfo:ApplicationToken>
  <UserDefinedFieldInfo:Credentials>
    <UserDefinedFieldInfo:Ticket>7T:1234abcxyzExample==</UserDefinedFieldInfo:Ticket>
  </UserDefinedFieldInfo:Credentials>
 <SOAP-ENV:Body>
   <UserDefinedFieldInfo:SetPageOneFieldGrouping>
    <UserDefinedFieldInfo:OwnerType xsi:type="UserDefinedFieldInfo:UDefType">Invalid</UserDefinedFieldInfo:OwnerType>
    <UserDefinedFieldInfo:Active xsi:type="xsd:boolean">false</UserDefinedFieldInfo:Active>
   </UserDefinedFieldInfo:SetPageOneFieldGrouping>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetPageOneFieldGrouping Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <UserDefinedFieldInfo:SetPageOneFieldGroupingResponse>
  </UserDefinedFieldInfo:SetPageOneFieldGroupingResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

