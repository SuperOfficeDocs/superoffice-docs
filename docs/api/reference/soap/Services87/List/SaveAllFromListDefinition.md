---
title: Services87.ListAgent.SaveAllFromListDefinition SOAP
generated: 1
uid: Services87-List-SaveAllFromListDefinition
---

# Services87 List SaveAllFromListDefinition

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.SaveAllFromListDefinition">SuperOffice.Services87.IListAgent.SaveAllFromListDefinition</see> method.

## SaveAllFromListDefinition

Save all list items for the specified list defintion

* **udListDefinitionId:** The id of the list definition, indicating which list to save the items to. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
* **items:** The list items

**Returns:** The list items


[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveAllFromListDefinition Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SaveAllFromListDefinition>
    <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
    <List:Items xsi:type="List:ArrayOfListItemEntity">
     <List:ListItemEntity xsi:type="List:ListItemEntity">
      <List:Id xsi:type="xsd:int">0</List:Id>
      <List:Name xsi:type="xsd:string"></List:Name>
      <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
      <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
      <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
      <List:Rank xsi:type="xsd:int">0</List:Rank>
     </List:ListItemEntity>
    </List:Items>
   </List:SaveAllFromListDefinition>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveAllFromListDefinition Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <List:SaveAllFromListDefinitionResponse>
   <List:Response xsi:type="List:ArrayOfListItemEntity">
    <List:ListItemEntity xsi:type="List:ListItemEntity">
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
     <List:Rank xsi:type="xsd:int">0</List:Rank>
    </List:ListItemEntity>
   </List:Response>
  </List:SaveAllFromListDefinitionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

