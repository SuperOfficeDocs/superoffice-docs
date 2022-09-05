---
title: Services86.ListAgent.SetListItemsForHeading SOAP
generated: 1
uid: Services86-List-SetListItemsForHeading
---

# Services86 List SetListItemsForHeading

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.SetListItemsForHeading">SuperOffice.Services86.IListAgent.SetListItemsForHeading</see> method.

## SetListItemsForHeading

Update listItems that will be visible for this usergroup

* **udListDefinitionId:** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
* **headingId:** The id of the heading
* **listItemIds:** The ids of the list items.
* **enable:** True to enable, false to disable



[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetListItemsForHeading Request

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
   <List:SetListItemsForHeading>
    <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
    <List:HeadingId xsi:type="xsd:int">0</List:HeadingId>
    <List:ListItemIds xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
    </List:ListItemIds>
    <List:Enable xsi:type="xsd:boolean">false</List:Enable>
   </List:SetListItemsForHeading>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetListItemsForHeading Response

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
  <List:SetListItemsForHeadingResponse>
  </List:SetListItemsForHeadingResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

