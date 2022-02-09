---
title: Services86.ListAgent.GetListItemsForUserGroup SOAP
generated: 1
uid: Services86-List-GetListItemsForUserGroup
---

# Services86 List GetListItemsForUserGroup

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.GetListItemsForUserGroup">SuperOffice.Services86.IListAgent.GetListItemsForUserGroup</see> method.

## GetListItemsForUserGroup

List of list items that is visible in the usergroup

* **udListDefinitionId:** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
* **groupId:** The id of the usergroup

**Returns:** Array of selectable list items


[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetListItemsForUserGroup Request

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
   <List:GetListItemsForUserGroup>
    <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
    <List:GroupId xsi:type="xsd:int">0</List:GroupId>
   </List:GetListItemsForUserGroup>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetListItemsForUserGroup Response

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
  <List:GetListItemsForUserGroupResponse>
   <List:Response xsi:type="List:ArrayOfSelectableMDOListItem">
    <List:SelectableMDOListItem xsi:type="List:SelectableMDOListItem">
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:ToolTip xsi:type="xsd:string"></List:ToolTip>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:Rank xsi:type="xsd:int">0</List:Rank>
     <List:Type xsi:type="xsd:string"></List:Type>
     <List:ColorBlock xsi:type="xsd:int">0</List:ColorBlock>
     <List:IconHint xsi:type="xsd:string"></List:IconHint>
     <List:Selected xsi:type="xsd:boolean">false</List:Selected>
     <List:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:56Z</List:LastChanged>
     <List:ChildItems xsi:type="List:ArrayOfSelectableMDOListItem">
      <List:SelectableMDOListItem xsi:type="List:SelectableMDOListItem">
       <List:Id xsi:type="xsd:int">0</List:Id>
       <List:Name xsi:type="xsd:string"></List:Name>
       <List:ToolTip xsi:type="xsd:string"></List:ToolTip>
       <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
       <List:Rank xsi:type="xsd:int">0</List:Rank>
       <List:Type xsi:type="xsd:string"></List:Type>
       <List:ColorBlock xsi:type="xsd:int">0</List:ColorBlock>
       <List:IconHint xsi:type="xsd:string"></List:IconHint>
       <List:Selected xsi:type="xsd:boolean">false</List:Selected>
       <List:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:56Z</List:LastChanged>
       <List:ChildItems xsi:type="List:ArrayOfSelectableMDOListItem">
        <List:SelectableMDOListItem xsi:type="List:SelectableMDOListItem">
         <List:Id xsi:type="xsd:int">0</List:Id>
         <List:Name xsi:type="xsd:string"></List:Name>
         <List:ToolTip xsi:type="xsd:string"></List:ToolTip>
         <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
         <List:Rank xsi:type="xsd:int">0</List:Rank>
         <List:Type xsi:type="xsd:string"></List:Type>
         <List:ColorBlock xsi:type="xsd:int">0</List:ColorBlock>
         <List:IconHint xsi:type="xsd:string"></List:IconHint>
         <List:Selected xsi:type="xsd:boolean">false</List:Selected>
         <List:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:56Z</List:LastChanged>
         <List:ChildItems xsi:type="List:ArrayOfSelectableMDOListItem">
          <List:SelectableMDOListItem xsi:nil="true"></List:SelectableMDOListItem>
         </List:ChildItems>
         <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
         <List:StyleHint xsi:type="xsd:string"></List:StyleHint>
         <List:Hidden xsi:type="xsd:boolean">false</List:Hidden>
         <List:FullName xsi:type="xsd:string"></List:FullName>
        </List:SelectableMDOListItem>
       </List:ChildItems>
       <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
       <List:StyleHint xsi:type="xsd:string"></List:StyleHint>
       <List:Hidden xsi:type="xsd:boolean">false</List:Hidden>
       <List:FullName xsi:type="xsd:string"></List:FullName>
      </List:SelectableMDOListItem>
     </List:ChildItems>
     <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
     <List:StyleHint xsi:type="xsd:string"></List:StyleHint>
     <List:Hidden xsi:type="xsd:boolean">false</List:Hidden>
     <List:FullName xsi:type="xsd:string"></List:FullName>
    </List:SelectableMDOListItem>
   </List:Response>
  </List:GetListItemsForUserGroupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

