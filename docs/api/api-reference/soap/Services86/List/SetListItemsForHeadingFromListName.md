---
uid: services86-list-setlistitemsforheadingfromlistname
title: Services86.ListAgent.SetListItemsForHeadingFromListName SOAP
Generated: true
---

# Services86 List SetListItemsForHeadingFromListName SOAP

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.SetListItemsForHeadingFromListName">SuperOffice.Services86.IListAgent.SetListItemsForHeadingFromListName</see> method.

## SetListItemsForHeadingFromListName

Update listItems under this heading

* **udListDefinitionName:** The name of the list definition.
* **headingId:** The id of the heading
* **listItemIds:** The ids of the list items.
* **enable:** True to enable, false to disable



[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetListItemsForHeadingFromListName Request

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
   <List:SetListItemsForHeadingFromListName>
    <List:UdListDefinitionName xsi:type="xsd:string"></List:UdListDefinitionName>
    <List:HeadingId xsi:type="xsd:int">0</List:HeadingId>
    <List:ListItemIds xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
    </List:ListItemIds>
    <List:Enable xsi:type="xsd:boolean">false</List:Enable>
   </List:SetListItemsForHeadingFromListName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetListItemsForHeadingFromListName Response

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
  <List:SetListItemsForHeadingFromListNameResponse>
  </List:SetListItemsForHeadingFromListNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

