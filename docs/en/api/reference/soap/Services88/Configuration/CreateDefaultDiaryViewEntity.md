---
title: Services88.ConfigurationAgent.CreateDefaultDiaryViewEntity SOAP
generated: true
uid: Services88-Configuration-CreateDefaultDiaryViewEntity
---

# Services88 Configuration CreateDefaultDiaryViewEntity

SOAP request and response examples **Remote/Services88/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IConfigurationAgent.CreateDefaultDiaryViewEntity">SuperOffice.Services88.IConfigurationAgent.CreateDefaultDiaryViewEntity</see> method.

## CreateDefaultDiaryViewEntity





[WSDL file for Services88/Configuration](../Services88-Configuration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultDiaryViewEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:CreateDefaultDiaryViewEntity>
   </Configuration:CreateDefaultDiaryViewEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultDiaryViewEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Configuration:CreateDefaultDiaryViewEntityResponse>
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
      <Configuration:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:43:08Z</Configuration:LastChanged>
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
        <Configuration:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:43:08Z</Configuration:LastChanged>
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
  </Configuration:CreateDefaultDiaryViewEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

