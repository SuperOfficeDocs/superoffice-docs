---
uid: services80-list-createdefaultlistentity
title: Services80.ListAgent.CreateDefaultListEntity SOAP
Generated: true
---

# Services80 List CreateDefaultListEntity SOAP

SOAP request and response examples **Remote/Services80/List.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IListAgent.CreateDefaultListEntity">SuperOffice.Services80.IListAgent.CreateDefaultListEntity</see> method.

## CreateDefaultListEntity

Loading default values into a new ListEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New ListEntity with default values


[WSDL file for Services80/List](../Services80-List.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultListEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:CreateDefaultListEntity>
   </List:CreateDefaultListEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultListEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <List:CreateDefaultListEntityResponse>
   <List:Response xsi:type="List:ListEntity">
    <List:Id xsi:type="xsd:int">0</List:Id>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:Rank xsi:type="xsd:int">0</List:Rank>
    <List:IsCustomList xsi:type="xsd:boolean">false</List:IsCustomList>
    <List:IsMDOList xsi:type="xsd:boolean">false</List:IsMDOList>
    <List:UseGroupsAndHeadings xsi:type="xsd:boolean">false</List:UseGroupsAndHeadings>
    <List:ListType xsi:type="xsd:string"></List:ListType>
    <List:InUseByUserDefinedFields xsi:type="xsd:boolean">false</List:InUseByUserDefinedFields>
   </List:Response>
  </List:CreateDefaultListEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

