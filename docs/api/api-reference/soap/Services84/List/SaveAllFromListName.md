---
title: Services84.ListAgent.SaveAllFromListName SOAP
generated: 1
uid: Services84-List-SaveAllFromListName
---

# Services84 List SaveAllFromListName

SOAP request and response examples **Remote/Services84/List.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IListAgent.SaveAllFromListName">SuperOffice.Services84.IListAgent.SaveAllFromListName</see> method.

## SaveAllFromListName

Save all list items for the specified list defintion

* **udListDefinitionName:** The name of the list definition, indicating which list to save the items to.
* **items:** The list items

**Returns:** The list items


[WSDL file for Services84/List](../Services84-List.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveAllFromListName Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SaveAllFromListName>
    <List:UdListDefinitionName xsi:type="xsd:string"></List:UdListDefinitionName>
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
   </List:SaveAllFromListName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveAllFromListName Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <List:SaveAllFromListNameResponse>
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
  </List:SaveAllFromListNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

