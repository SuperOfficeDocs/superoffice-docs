---
title: Services87.ListAgent.SetListItemsForUserGroupFromListName SOAP
generated: 1
uid: Services87-List-SetListItemsForUserGroupFromListName
---

# Services87 List SetListItemsForUserGroupFromListName

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.SetListItemsForUserGroupFromListName">SuperOffice.Services87.IListAgent.SetListItemsForUserGroupFromListName</see> method.

## SetListItemsForUserGroupFromListName

Update listItems that will be visible for this usergroup

* **udListDefinitionName:** The name of the list definition.
* **usergroupId:** The id of the userGroup
* **listItemsID:** The id of the list items.
* **enable:** True to enable, false to disable



[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetListItemsForUserGroupFromListName Request

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
   <List:SetListItemsForUserGroupFromListName>
    <List:UdListDefinitionName xsi:type="xsd:string"></List:UdListDefinitionName>
    <List:UsergroupId xsi:type="xsd:int">0</List:UsergroupId>
    <List:ListItemsID xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
    </List:ListItemsID>
    <List:Enable xsi:type="xsd:boolean">false</List:Enable>
   </List:SetListItemsForUserGroupFromListName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetListItemsForUserGroupFromListName Response

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
  <List:SetListItemsForUserGroupFromListNameResponse>
  </List:SetListItemsForUserGroupFromListNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

