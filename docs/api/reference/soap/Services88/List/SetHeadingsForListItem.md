---
title: Services88.ListAgent.SetHeadingsForListItem SOAP
generated: 1
uid: Services88-List-SetHeadingsForListItem
---

# Services88 List SetHeadingsForListItem

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SetHeadingsForListItem">SuperOffice.Services88.IListAgent.SetHeadingsForListItem</see> method.

## SetHeadingsForListItem

Set headings which this list item should be listed under

* **udListDefinitionId:** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
* **listItemId:** The id of the list item
* **headingIds:** The ids of the headings to set for this list item
* **enable:** Set to true to enable, false to disable



[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetHeadingsForListItem Request

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
   <List:SetHeadingsForListItem>
    <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
    <List:ListItemId xsi:type="xsd:int">0</List:ListItemId>
    <List:HeadingIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </List:HeadingIds>
    <List:Enable xsi:type="xsd:boolean">false</List:Enable>
   </List:SetHeadingsForListItem>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetHeadingsForListItem Response

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
  <List:SetHeadingsForListItemResponse>
  </List:SetHeadingsForListItemResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

