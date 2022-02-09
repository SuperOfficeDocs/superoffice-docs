---
title: Services86.ListAgent.MoveListItem SOAP
generated: 1
uid: Services86-List-MoveListItem
---

# Services86 List MoveListItem

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.MoveListItem">SuperOffice.Services86.IListAgent.MoveListItem</see> method.

## MoveListItem

Move a list item up or down in the list based on rank

* **udListDefinitionId:** Id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
* **listItemId:** Id of the list item
* **direction:** -1 moves the item up one position, 1 moves the item down one position



[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## MoveListItem Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:MoveListItem>
    <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
    <List:ListItemId xsi:type="xsd:int">0</List:ListItemId>
    <List:Direction xsi:type="xsd:int">0</List:Direction>
   </List:MoveListItem>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## MoveListItem Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <List:MoveListItemResponse>
  </List:MoveListItemResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

