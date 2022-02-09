---
title: Services86.ConfigurationAgent.SaveDiaryViewEntity SOAP
generated: 1
uid: Services86-Configuration-SaveDiaryViewEntity
---

# Services86 Configuration SaveDiaryViewEntity

SOAP request and response examples **Remote/Services86/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IConfigurationAgent.SaveDiaryViewEntity">SuperOffice.Services86.IConfigurationAgent.SaveDiaryViewEntity</see> method.

## SaveDiaryViewEntity

Updates the existing DiaryViewEntity or creates a new DiaryViewEntity if the id parameter is 0.

* **diaryViewEntity:** The DiaryViewEntity that is saved.

**Returns:** New or updated DiaryViewEntity


[WSDL file for Services86/Configuration](../Services86-Configuration.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveDiaryViewEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:SaveDiaryViewEntity>
    <Configuration:DiaryViewEntity xsi:type="Configuration:DiaryViewEntity">
     <Configuration:DiaryViewId xsi:type="xsd:int">0</Configuration:DiaryViewId>
     <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
     <Configuration:Tooltip xsi:type="xsd:string"></Configuration:Tooltip>
     <Configuration:VisibleColumns xsi:type="xsd:short">0</Configuration:VisibleColumns>
     <Configuration:Rank xsi:type="xsd:short">0</Configuration:Rank>
     <Configuration:AssocId xsi:type="xsd:int">0</Configuration:AssocId>
     <Configuration:AssociateList xsi:type="Configuration:ArrayOfSelectableMDOListItem">
      <Configuration:SelectableMDOListItem xsi:type="Configuration:SelectableMDOListItem">
       <Configuration:Id xsi:type="xsd:int">0</Configuration:Id>
       <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
       <Configuration:ToolTip xsi:type="xsd:string"></Configuration:ToolTip>
       <Configuration:Deleted xsi:type="xsd:boolean">false</Configuration:Deleted>
       <Configuration:Rank xsi:type="xsd:int">0</Configuration:Rank>
       <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
       <Configuration:ColorBlock xsi:type="xsd:int">0</Configuration:ColorBlock>
       <Configuration:IconHint xsi:type="xsd:string"></Configuration:IconHint>
       <Configuration:Selected xsi:type="xsd:boolean">false</Configuration:Selected>
       <Configuration:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:48Z</Configuration:LastChanged>
       <Configuration:ChildItems xsi:type="Configuration:ArrayOfSelectableMDOListItem">
        <Configuration:SelectableMDOListItem xsi:type="Configuration:SelectableMDOListItem">
         <Configuration:Id xsi:type="xsd:int">0</Configuration:Id>
         <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
         <Configuration:ToolTip xsi:type="xsd:string"></Configuration:ToolTip>
         <Configuration:Deleted xsi:type="xsd:boolean">false</Configuration:Deleted>
         <Configuration:Rank xsi:type="xsd:int">0</Configuration:Rank>
         <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
         <Configuration:ColorBlock xsi:type="xsd:int">0</Configuration:ColorBlock>
         <Configuration:IconHint xsi:type="xsd:string"></Configuration:IconHint>
         <Configuration:Selected xsi:type="xsd:boolean">false</Configuration:Selected>
         <Configuration:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:48Z</Configuration:LastChanged>
         <Configuration:ChildItems xsi:type="Configuration:ArrayOfSelectableMDOListItem">
          <Configuration:SelectableMDOListItem xsi:nil="true"></Configuration:SelectableMDOListItem>
         </Configuration:ChildItems>
         <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
         <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
         <Configuration:Hidden xsi:type="xsd:boolean">false</Configuration:Hidden>
         <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
        </Configuration:SelectableMDOListItem>
       </Configuration:ChildItems>
       <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
       <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
       <Configuration:Hidden xsi:type="xsd:boolean">false</Configuration:Hidden>
       <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
      </Configuration:SelectableMDOListItem>
     </Configuration:AssociateList>
     <Configuration:TzLocationId xsi:type="xsd:int">0</Configuration:TzLocationId>
    </Configuration:DiaryViewEntity>
   </Configuration:SaveDiaryViewEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveDiaryViewEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Configuration:SaveDiaryViewEntityResponse>
   <Configuration:Response xsi:type="Configuration:DiaryViewEntity">
    <Configuration:DiaryViewId xsi:type="xsd:int">0</Configuration:DiaryViewId>
    <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
    <Configuration:Tooltip xsi:type="xsd:string"></Configuration:Tooltip>
    <Configuration:VisibleColumns xsi:type="xsd:short">0</Configuration:VisibleColumns>
    <Configuration:Rank xsi:type="xsd:short">0</Configuration:Rank>
    <Configuration:AssocId xsi:type="xsd:int">0</Configuration:AssocId>
    <Configuration:AssociateList xsi:type="Configuration:ArrayOfSelectableMDOListItem">
     <Configuration:SelectableMDOListItem xsi:type="Configuration:SelectableMDOListItem">
      <Configuration:Id xsi:type="xsd:int">0</Configuration:Id>
      <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
      <Configuration:ToolTip xsi:type="xsd:string"></Configuration:ToolTip>
      <Configuration:Deleted xsi:type="xsd:boolean">false</Configuration:Deleted>
      <Configuration:Rank xsi:type="xsd:int">0</Configuration:Rank>
      <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
      <Configuration:ColorBlock xsi:type="xsd:int">0</Configuration:ColorBlock>
      <Configuration:IconHint xsi:type="xsd:string"></Configuration:IconHint>
      <Configuration:Selected xsi:type="xsd:boolean">false</Configuration:Selected>
      <Configuration:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:48Z</Configuration:LastChanged>
      <Configuration:ChildItems xsi:type="Configuration:ArrayOfSelectableMDOListItem">
       <Configuration:SelectableMDOListItem xsi:type="Configuration:SelectableMDOListItem">
        <Configuration:Id xsi:type="xsd:int">0</Configuration:Id>
        <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
        <Configuration:ToolTip xsi:type="xsd:string"></Configuration:ToolTip>
        <Configuration:Deleted xsi:type="xsd:boolean">false</Configuration:Deleted>
        <Configuration:Rank xsi:type="xsd:int">0</Configuration:Rank>
        <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
        <Configuration:ColorBlock xsi:type="xsd:int">0</Configuration:ColorBlock>
        <Configuration:IconHint xsi:type="xsd:string"></Configuration:IconHint>
        <Configuration:Selected xsi:type="xsd:boolean">false</Configuration:Selected>
        <Configuration:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:48Z</Configuration:LastChanged>
        <Configuration:ChildItems xsi:type="Configuration:ArrayOfSelectableMDOListItem">
         <Configuration:SelectableMDOListItem xsi:type="Configuration:SelectableMDOListItem">
          <Configuration:Id xsi:nil="true"></Configuration:Id>
          <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
          <Configuration:ToolTip xsi:type="xsd:string"></Configuration:ToolTip>
          <Configuration:Deleted xsi:nil="true"></Configuration:Deleted>
          <Configuration:Rank xsi:nil="true"></Configuration:Rank>
          <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
          <Configuration:ColorBlock xsi:nil="true"></Configuration:ColorBlock>
          <Configuration:IconHint xsi:type="xsd:string"></Configuration:IconHint>
          <Configuration:Selected xsi:nil="true"></Configuration:Selected>
          <Configuration:LastChanged xsi:nil="true"></Configuration:LastChanged>
          <Configuration:ChildItems xsi:nil="true"></Configuration:ChildItems>
          <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
          <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
          <Configuration:Hidden xsi:nil="true"></Configuration:Hidden>
          <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
         </Configuration:SelectableMDOListItem>
        </Configuration:ChildItems>
        <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
        <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
        <Configuration:Hidden xsi:type="xsd:boolean">false</Configuration:Hidden>
        <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
       </Configuration:SelectableMDOListItem>
      </Configuration:ChildItems>
      <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
      <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
      <Configuration:Hidden xsi:type="xsd:boolean">false</Configuration:Hidden>
      <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
     </Configuration:SelectableMDOListItem>
    </Configuration:AssociateList>
    <Configuration:TzLocationId xsi:type="xsd:int">0</Configuration:TzLocationId>
   </Configuration:Response>
  </Configuration:SaveDiaryViewEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

