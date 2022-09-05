---
title: Services88.ListAgent.SaveTicketCategoryEntity SOAP
generated: 1
uid: Services88-List-SaveTicketCategoryEntity
---

# Services88 List SaveTicketCategoryEntity

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SaveTicketCategoryEntity">SuperOffice.Services88.IListAgent.SaveTicketCategoryEntity</see> method.

## SaveTicketCategoryEntity

Updates the existing TicketCategoryEntity or creates a new TicketCategoryEntity if the id parameter is 0.

* **ticketCategoryEntity:** The TicketCategoryEntity that is saved.

**Returns:** New or updated TicketCategoryEntity


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveTicketCategoryEntity Request

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
   <List:SaveTicketCategoryEntity>
    <List:TicketCategoryEntity xsi:type="List:TicketCategoryEntity">
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
     <List:DefaultTicketStatus xsi:type="List:TicketStatusEntity">
      <List:TicketStatusId xsi:type="xsd:int">0</List:TicketStatusId>
      <List:Name xsi:type="xsd:string"></List:Name>
      <List:Status xsi:type="List:TicketBaseStatus">Unknown</List:Status>
      <List:TimeCounter xsi:type="List:TicketStatusTimeCounter">None</List:TimeCounter>
      <List:NoEmailReopen xsi:type="xsd:boolean">false</List:NoEmailReopen>
      <List:IsDefault xsi:type="xsd:boolean">false</List:IsDefault>
      <List:UsedInQueue xsi:type="xsd:boolean">false</List:UsedInQueue>
     </List:DefaultTicketStatus>
     <List:DefaultMessageStatus xsi:type="List:TicketStatusEntity">
      <List:TicketStatusId xsi:type="xsd:int">0</List:TicketStatusId>
      <List:Name xsi:type="xsd:string"></List:Name>
      <List:Status xsi:type="List:TicketBaseStatus">Unknown</List:Status>
      <List:TimeCounter xsi:type="List:TicketStatusTimeCounter">None</List:TimeCounter>
      <List:NoEmailReopen xsi:type="xsd:boolean">false</List:NoEmailReopen>
      <List:IsDefault xsi:type="xsd:boolean">false</List:IsDefault>
      <List:UsedInQueue xsi:type="xsd:boolean">false</List:UsedInQueue>
     </List:DefaultMessageStatus>
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
    </List:TicketCategoryEntity>
   </List:SaveTicketCategoryEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveTicketCategoryEntity Response

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
  <List:SaveTicketCategoryEntityResponse>
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
    <List:DefaultTicketStatus xsi:type="List:TicketStatusEntity">
     <List:TicketStatusId xsi:type="xsd:int">0</List:TicketStatusId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Status xsi:type="List:TicketBaseStatus">Unknown</List:Status>
     <List:TimeCounter xsi:type="List:TicketStatusTimeCounter">None</List:TimeCounter>
     <List:NoEmailReopen xsi:type="xsd:boolean">false</List:NoEmailReopen>
     <List:IsDefault xsi:type="xsd:boolean">false</List:IsDefault>
     <List:UsedInQueue xsi:type="xsd:boolean">false</List:UsedInQueue>
    </List:DefaultTicketStatus>
    <List:DefaultMessageStatus xsi:type="List:TicketStatusEntity">
     <List:TicketStatusId xsi:type="xsd:int">0</List:TicketStatusId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Status xsi:type="List:TicketBaseStatus">Unknown</List:Status>
     <List:TimeCounter xsi:type="List:TicketStatusTimeCounter">None</List:TimeCounter>
     <List:NoEmailReopen xsi:type="xsd:boolean">false</List:NoEmailReopen>
     <List:IsDefault xsi:type="xsd:boolean">false</List:IsDefault>
     <List:UsedInQueue xsi:type="xsd:boolean">false</List:UsedInQueue>
    </List:DefaultMessageStatus>
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
  </List:SaveTicketCategoryEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

