---
uid: services81-configuration-createdefaultdiaryviewentity
title: Services81.ConfigurationAgent.CreateDefaultDiaryViewEntity SOAP
Generated: true
---

# Services81 Configuration CreateDefaultDiaryViewEntity SOAP

SOAP request and response examples **Remote/Services81/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IConfigurationAgent.CreateDefaultDiaryViewEntity">SuperOffice.Services81.IConfigurationAgent.CreateDefaultDiaryViewEntity</see> method.

## CreateDefaultDiaryViewEntity

Loading default values into a new DiaryViewEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New DiaryViewEntity with default values


[WSDL file for Services81/Configuration](../Services81-Configuration.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultDiaryViewEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
      <Configuration:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:34:25Z</Configuration:LastChanged>
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
        <Configuration:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:34:25Z</Configuration:LastChanged>
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
         </Configuration:SelectableMDOListItem>
        </Configuration:ChildItems>
        <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
        <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
        <Configuration:Hidden xsi:type="xsd:boolean">false</Configuration:Hidden>
       </Configuration:SelectableMDOListItem>
      </Configuration:ChildItems>
      <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
      <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
      <Configuration:Hidden xsi:type="xsd:boolean">false</Configuration:Hidden>
     </Configuration:SelectableMDOListItem>
    </Configuration:AssociateList>
    <Configuration:TzLocationId xsi:type="xsd:int">0</Configuration:TzLocationId>
   </Configuration:Response>
  </Configuration:CreateDefaultDiaryViewEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

