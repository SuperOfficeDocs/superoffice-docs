---
title: Services87.ListAgent.GetTicketCategoryEntity SOAP
generated: 1
uid: Services87-List-GetTicketCategoryEntity
---

# Services87 List GetTicketCategoryEntity

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.GetTicketCategoryEntity">SuperOffice.Services87.IListAgent.GetTicketCategoryEntity</see> method.

## GetTicketCategoryEntity

Gets a TicketCategoryEntity object.

* **ticketCategoryEntityId:** The identifier of the TicketCategoryEntity object

**Returns:** TicketCategoryEntity


[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicketCategoryEntity Request

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
   <List:GetTicketCategoryEntity>
    <List:TicketCategoryEntityId xsi:type="xsd:int">0</List:TicketCategoryEntityId>
   </List:GetTicketCategoryEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTicketCategoryEntity Response

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
  <List:GetTicketCategoryEntityResponse>
   <List:Response xsi:type="List:TicketCategoryEntity">
    <List:TicketCategoryId xsi:type="xsd:int">0</List:TicketCategoryId>
    <List:ParentId xsi:type="xsd:int">0</List:ParentId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Fullname xsi:type="xsd:string"></List:Fullname>
    <List:CategoryMaster xsi:type="xsd:int">0</List:CategoryMaster>
    <List:Flags xsi:type="List:TicketCategoryFlags">Internal</List:Flags>
    <List:DelegateMethod xsi:type="List:TicketCategoryDelegateMethod">Unknown</List:DelegateMethod>
    <List:ExternalName xsi:type="xsd:string"></List:ExternalName>
    <List:ClosingStatus xsi:type="List:TicketCategoryClosingStatus">UserDefined</List:ClosingStatus>
    <List:MsgClosingStatus xsi:type="List:TicketCategoryClosingStatus">UserDefined</List:MsgClosingStatus>
    <List:AssignmentLag xsi:type="xsd:int">0</List:AssignmentLag>
    <List:ReplyTemplate xsi:type="xsd:int">0</List:ReplyTemplate>
    <List:NotificationEmail xsi:type="xsd:string"></List:NotificationEmail>
    <List:ExtraFields xsi:type="List:StringDictionary">
     <List:StringKeyValuePair>
      <List:Key xsi:type="xsd:string"></List:Key>
      <List:Value xsi:type="xsd:string"></List:Value>
     </List:StringKeyValuePair>
    </List:ExtraFields>
    <List:CustomFields xsi:type="List:StringDictionary">
     <List:StringKeyValuePair>
      <List:Key xsi:type="xsd:string"></List:Key>
      <List:Value xsi:type="xsd:string"></List:Value>
     </List:StringKeyValuePair>
    </List:CustomFields>
   </List:Response>
  </List:GetTicketCategoryEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

