---
uid: services86-list-getticketcategories
title: Services86.ListAgent.GetTicketCategories SOAP
Generated: true
---

# Services86 List GetTicketCategories SOAP

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.GetTicketCategories">SuperOffice.Services86.IListAgent.GetTicketCategories</see> method.

## GetTicketCategories






[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicketCategories Request

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
   <List:GetTicketCategories>
   </List:GetTicketCategories>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTicketCategories Response

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
  <List:GetTicketCategoriesResponse>
   <List:Response xsi:type="List:ArrayOfTicketCategoryEntity">
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
     <List:ExtraFields xsi:type="List:StringDictionary">
      <List:StringKeyValuePair>
       <List:Key xsi:type="xsd:string"></List:Key>
       <List:Value xsi:type="xsd:string"></List:Value>
      </List:StringKeyValuePair>
     </List:ExtraFields>
    </List:TicketCategoryEntity>
   </List:Response>
  </List:GetTicketCategoriesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

