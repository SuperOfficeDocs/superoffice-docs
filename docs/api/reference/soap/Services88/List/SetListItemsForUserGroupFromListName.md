---
title: Services88.ListAgent.SetListItemsForUserGroupFromListName SOAP
generated: 1
uid: Services88-List-SetListItemsForUserGroupFromListName
---

# Services88 List SetListItemsForUserGroupFromListName

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SetListItemsForUserGroupFromListName">SuperOffice.Services88.IListAgent.SetListItemsForUserGroupFromListName</see> method.

## SetListItemsForUserGroupFromListName

Update listItems that will be visible for this usergroup

* **udListDefinitionName:** The name of the list definition.
* **usergroupId:** The id of the userGroup
* **listItemsID:** The id of the list items.
* **enable:** True to enable, false to disable



[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetListItemsForUserGroupFromListName Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SetListItemsForUserGroupFromListName>
    <List:UdListDefinitionName xsi:type="xsd:string"></List:UdListDefinitionName>
    <List:UsergroupId xsi:type="xsd:int">0</List:UsergroupId>
    <List:ListItemsID xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:SetListItemsForUserGroupFromListNameResponse>
  </List:SetListItemsForUserGroupFromListNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

