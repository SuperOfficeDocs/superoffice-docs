---
title: Services85.ListAgent.GetListDefinitions SOAP
generated: 1
uid: Services85-List-GetListDefinitions
---

# Services85 List GetListDefinitions

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.GetListDefinitions">SuperOffice.Services85.IListAgent.GetListDefinitions</see> method.

## GetListDefinitions

Get a list of the lists - built-in and user-defined.

* **includeDeleted:** Include deleted items in result?

**Returns:** The list definitions


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetListDefinitions Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetListDefinitions>
    <List:IncludeDeleted xsi:type="xsd:boolean">false</List:IncludeDeleted>
   </List:GetListDefinitions>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetListDefinitions Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <List:GetListDefinitionsResponse>
   <List:Response xsi:type="List:ArrayOfListEntity">
    <List:ListEntity xsi:type="List:ListEntity">
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
    </List:ListEntity>
   </List:Response>
  </List:GetListDefinitionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

