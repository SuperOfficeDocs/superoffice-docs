---
uid: services88-list-setticketcategoriesforusergroup
title: Services88.ListAgent.SetTicketCategoriesForUserGroup SOAP
Generated: true
---

# Services88 List SetTicketCategoriesForUserGroup SOAP

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SetTicketCategoriesForUserGroup">SuperOffice.Services88.IListAgent.SetTicketCategoriesForUserGroup</see> method.

## SetTicketCategoriesForUserGroup

Set ticket categories for one user group

* **userGroupId:** The ids of the user groups we want tickets categories from
* **categoryIds:** The ids of the user groups we want tickets categories from

**Returns:** This method has no return value


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetTicketCategoriesForUserGroup Request

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
   <List:SetTicketCategoriesForUserGroup>
    <List:UserGroupId xsi:type="xsd:int">0</List:UserGroupId>
    <List:CategoryIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </List:CategoryIds>
   </List:SetTicketCategoriesForUserGroup>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetTicketCategoriesForUserGroup Response

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
  <List:SetTicketCategoriesForUserGroupResponse>
  </List:SetTicketCategoriesForUserGroupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

