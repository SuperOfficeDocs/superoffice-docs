---
uid: services84-list-deletefromlistname
title: Services84.ListAgent.DeleteFromListName SOAP
Generated: true
---

# Services84 List DeleteFromListName SOAP

SOAP request and response examples **Remote/Services84/List.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IListAgent.DeleteFromListName">SuperOffice.Services84.IListAgent.DeleteFromListName</see> method.

## DeleteFromListName

Delete a list item from the specified list defintion

* **id:** The identity of the list item to delete
* **udListDefinitionName:** The name of the list definition, indicating which list to delete the items from.

**Returns:** This method has no return value


[WSDL file for Services84/List](../Services84-List.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteFromListName Request

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
   <List:DeleteFromListName>
    <List:Id xsi:type="xsd:int">0</List:Id>
    <List:UdListDefinitionName xsi:type="xsd:string"></List:UdListDefinitionName>
   </List:DeleteFromListName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteFromListName Response

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
  <List:DeleteFromListNameResponse>
  </List:DeleteFromListNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

