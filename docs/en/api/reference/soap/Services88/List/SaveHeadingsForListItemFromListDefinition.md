---
title: Services88.ListAgent.SaveHeadingsForListItemFromListDefinition SOAP
generated: true
uid: Services88-List-SaveHeadingsForListItemFromListDefinition
---

# Services88 List SaveHeadingsForListItemFromListDefinition

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SaveHeadingsForListItemFromListDefinition">SuperOffice.Services88.IListAgent.SaveHeadingsForListItemFromListDefinition</see> method.

## SaveHeadingsForListItemFromListDefinition





[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveHeadingsForListItemFromListDefinition Request

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
   <List:SaveHeadingsForListItemFromListDefinition>
    <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
    <List:ListItemId xsi:type="xsd:int">0</List:ListItemId>
    <List:Headings xsi:type="List:ArrayOfSelectableMDOListItem">
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
      <List:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:44:14Z</List:LastChanged>
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
        <List:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:44:14Z</List:LastChanged>
        <List:ChildItems xsi:type="List:ArrayOfSelectableMDOListItem">
         <List:SelectableMDOListItem xsi:type="List:SelectableMDOListItem">
          <List:Id xsi:nil="true"></List:Id>
          <List:Name xsi:type="xsd:string"></List:Name>
          <List:ToolTip xsi:type="xsd:string"></List:ToolTip>
          <List:Deleted xsi:nil="true"></List:Deleted>
          <List:Rank xsi:nil="true"></List:Rank>
          <List:Type xsi:type="xsd:string"></List:Type>
          <List:ColorBlock xsi:nil="true"></List:ColorBlock>
          <List:IconHint xsi:type="xsd:string"></List:IconHint>
          <List:Selected xsi:nil="true"></List:Selected>
          <List:LastChanged xsi:nil="true"></List:LastChanged>
          <List:ChildItems xsi:nil="true"></List:ChildItems>
          <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
          <List:StyleHint xsi:type="xsd:string"></List:StyleHint>
          <List:Hidden xsi:nil="true"></List:Hidden>
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
    </List:Headings>
   </List:SaveHeadingsForListItemFromListDefinition>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveHeadingsForListItemFromListDefinition Response

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
  <List:SaveHeadingsForListItemFromListDefinitionResponse>
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
     <List:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:44:14Z</List:LastChanged>
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
       <List:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:44:14Z</List:LastChanged>
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
         <List:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:44:14Z</List:LastChanged>
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
  </List:SaveHeadingsForListItemFromListDefinitionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

