---
title: Services87.ListAgent.GetTicketCategoriesForUserGroups SOAP
generated: 1
uid: Services87-List-GetTicketCategoriesForUserGroups
---

# Services87 List GetTicketCategoriesForUserGroups

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.GetTicketCategoriesForUserGroups">SuperOffice.Services87.IListAgent.GetTicketCategoriesForUserGroups</see> method.

## GetTicketCategoriesForUserGroups

Ticket categories for user groups

* **userGroupIds:** The ids of the user groups we want tickets categories from



[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicketCategoriesForUserGroups Request

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
   <List:GetTicketCategoriesForUserGroups>
    <List:UserGroupIds xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
    </List:UserGroupIds>
   </List:GetTicketCategoriesForUserGroups>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTicketCategoriesForUserGroups Response

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
  <List:GetTicketCategoriesForUserGroupsResponse>
   <List:Response xsi:type="List:ArrayOfMDOListItem">
    <List:MDOListItem xsi:type="List:MDOListItem">
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:ToolTip xsi:type="xsd:string"></List:ToolTip>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:Rank xsi:type="xsd:int">0</List:Rank>
     <List:Type xsi:type="xsd:string"></List:Type>
     <List:ChildItems xsi:type="List:ArrayOfMDOListItem">
      <List:MDOListItem xsi:type="List:MDOListItem">
       <List:Id xsi:type="xsd:int">0</List:Id>
       <List:Name xsi:type="xsd:string"></List:Name>
       <List:ToolTip xsi:type="xsd:string"></List:ToolTip>
       <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
       <List:Rank xsi:type="xsd:int">0</List:Rank>
       <List:Type xsi:type="xsd:string"></List:Type>
       <List:ChildItems xsi:type="List:ArrayOfMDOListItem">
        <List:MDOListItem xsi:type="List:MDOListItem">
         <List:Id xsi:type="xsd:int">0</List:Id>
         <List:Name xsi:type="xsd:string"></List:Name>
         <List:ToolTip xsi:type="xsd:string"></List:ToolTip>
         <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
         <List:Rank xsi:type="xsd:int">0</List:Rank>
         <List:Type xsi:type="xsd:string"></List:Type>
         <List:ChildItems xsi:type="List:ArrayOfMDOListItem">
          <List:MDOListItem xsi:nil="true"></List:MDOListItem>
         </List:ChildItems>
         <List:IconHint xsi:type="xsd:string"></List:IconHint>
         <List:ColorBlock xsi:type="xsd:int">0</List:ColorBlock>
         <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
         <List:StyleHint xsi:type="xsd:string"></List:StyleHint>
         <List:FullName xsi:type="xsd:string"></List:FullName>
        </List:MDOListItem>
       </List:ChildItems>
       <List:IconHint xsi:type="xsd:string"></List:IconHint>
       <List:ColorBlock xsi:type="xsd:int">0</List:ColorBlock>
       <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
       <List:StyleHint xsi:type="xsd:string"></List:StyleHint>
       <List:FullName xsi:type="xsd:string"></List:FullName>
      </List:MDOListItem>
     </List:ChildItems>
     <List:IconHint xsi:type="xsd:string"></List:IconHint>
     <List:ColorBlock xsi:type="xsd:int">0</List:ColorBlock>
     <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
     <List:StyleHint xsi:type="xsd:string"></List:StyleHint>
     <List:FullName xsi:type="xsd:string"></List:FullName>
    </List:MDOListItem>
   </List:Response>
  </List:GetTicketCategoriesForUserGroupsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

