---
title: Services88.ConfigurationAgent.CreateDefaultLandingPageEntity SOAP
generated: true
uid: Services88-Configuration-CreateDefaultLandingPageEntity
content_type: reference
---

# Services88 Configuration CreateDefaultLandingPageEntity

SOAP request and response examples **Remote/Services88/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IConfigurationAgent.CreateDefaultLandingPageEntity">SuperOffice.Services88.IConfigurationAgent.CreateDefaultLandingPageEntity</see> method.

## CreateDefaultLandingPageEntity





[WSDL file for Services88/Configuration](../Services88-Configuration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultLandingPageEntity Request

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
   <Configuration:CreateDefaultLandingPageEntity>
   </Configuration:CreateDefaultLandingPageEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultLandingPageEntity Response

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
  <Configuration:CreateDefaultLandingPageEntityResponse>
   <Configuration:Response xsi:type="Configuration:LandingPageEntity">
    <Configuration:LandingPageId xsi:type="xsd:int">0</Configuration:LandingPageId>
    <Configuration:AssociateId xsi:type="xsd:int">0</Configuration:AssociateId>
    <Configuration:EntityTableName xsi:type="xsd:string"></Configuration:EntityTableName>
    <Configuration:SelectionId xsi:type="xsd:int">0</Configuration:SelectionId>
    <Configuration:PinnedSelections xsi:type="Configuration:ArrayOfMDOListItem">
     <Configuration:MDOListItem xsi:type="Configuration:MDOListItem">
      <Configuration:Id xsi:type="xsd:int">0</Configuration:Id>
      <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
      <Configuration:ToolTip xsi:type="xsd:string"></Configuration:ToolTip>
      <Configuration:Deleted xsi:type="xsd:boolean">false</Configuration:Deleted>
      <Configuration:Rank xsi:type="xsd:int">0</Configuration:Rank>
      <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
      <Configuration:ChildItems xsi:type="Configuration:ArrayOfMDOListItem">
       <Configuration:MDOListItem xsi:type="Configuration:MDOListItem">
        <Configuration:Id xsi:type="xsd:int">0</Configuration:Id>
        <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
        <Configuration:ToolTip xsi:type="xsd:string"></Configuration:ToolTip>
        <Configuration:Deleted xsi:type="xsd:boolean">false</Configuration:Deleted>
        <Configuration:Rank xsi:type="xsd:int">0</Configuration:Rank>
        <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
        <Configuration:ChildItems xsi:type="Configuration:ArrayOfMDOListItem">
         <Configuration:MDOListItem xsi:type="Configuration:MDOListItem">
          <Configuration:Id xsi:nil="true"></Configuration:Id>
          <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
          <Configuration:ToolTip xsi:type="xsd:string"></Configuration:ToolTip>
          <Configuration:Deleted xsi:nil="true"></Configuration:Deleted>
          <Configuration:Rank xsi:nil="true"></Configuration:Rank>
          <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
          <Configuration:ChildItems xsi:nil="true"></Configuration:ChildItems>
          <Configuration:IconHint xsi:type="xsd:string"></Configuration:IconHint>
          <Configuration:ColorBlock xsi:nil="true"></Configuration:ColorBlock>
          <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
          <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
          <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
         </Configuration:MDOListItem>
        </Configuration:ChildItems>
        <Configuration:IconHint xsi:type="xsd:string"></Configuration:IconHint>
        <Configuration:ColorBlock xsi:type="xsd:int">0</Configuration:ColorBlock>
        <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
        <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
        <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
       </Configuration:MDOListItem>
      </Configuration:ChildItems>
      <Configuration:IconHint xsi:type="xsd:string"></Configuration:IconHint>
      <Configuration:ColorBlock xsi:type="xsd:int">0</Configuration:ColorBlock>
      <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
      <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
      <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
     </Configuration:MDOListItem>
    </Configuration:PinnedSelections>
    <Configuration:PinnedEntities xsi:type="Configuration:ArrayOfMDOListItem">
     <Configuration:MDOListItem xsi:type="Configuration:MDOListItem">
      <Configuration:Id xsi:type="xsd:int">0</Configuration:Id>
      <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
      <Configuration:ToolTip xsi:type="xsd:string"></Configuration:ToolTip>
      <Configuration:Deleted xsi:type="xsd:boolean">false</Configuration:Deleted>
      <Configuration:Rank xsi:type="xsd:int">0</Configuration:Rank>
      <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
      <Configuration:ChildItems xsi:type="Configuration:ArrayOfMDOListItem">
       <Configuration:MDOListItem xsi:type="Configuration:MDOListItem">
        <Configuration:Id xsi:type="xsd:int">0</Configuration:Id>
        <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
        <Configuration:ToolTip xsi:type="xsd:string"></Configuration:ToolTip>
        <Configuration:Deleted xsi:type="xsd:boolean">false</Configuration:Deleted>
        <Configuration:Rank xsi:type="xsd:int">0</Configuration:Rank>
        <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
        <Configuration:ChildItems xsi:type="Configuration:ArrayOfMDOListItem">
         <Configuration:MDOListItem xsi:type="Configuration:MDOListItem">
          <Configuration:Id xsi:nil="true"></Configuration:Id>
          <Configuration:Name xsi:type="xsd:string"></Configuration:Name>
          <Configuration:ToolTip xsi:type="xsd:string"></Configuration:ToolTip>
          <Configuration:Deleted xsi:nil="true"></Configuration:Deleted>
          <Configuration:Rank xsi:nil="true"></Configuration:Rank>
          <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
          <Configuration:ChildItems xsi:nil="true"></Configuration:ChildItems>
          <Configuration:IconHint xsi:type="xsd:string"></Configuration:IconHint>
          <Configuration:ColorBlock xsi:nil="true"></Configuration:ColorBlock>
          <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
          <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
          <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
         </Configuration:MDOListItem>
        </Configuration:ChildItems>
        <Configuration:IconHint xsi:type="xsd:string"></Configuration:IconHint>
        <Configuration:ColorBlock xsi:type="xsd:int">0</Configuration:ColorBlock>
        <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
        <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
        <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
       </Configuration:MDOListItem>
      </Configuration:ChildItems>
      <Configuration:IconHint xsi:type="xsd:string"></Configuration:IconHint>
      <Configuration:ColorBlock xsi:type="xsd:int">0</Configuration:ColorBlock>
      <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
      <Configuration:StyleHint xsi:type="xsd:string"></Configuration:StyleHint>
      <Configuration:FullName xsi:type="xsd:string"></Configuration:FullName>
     </Configuration:MDOListItem>
    </Configuration:PinnedEntities>
   </Configuration:Response>
  </Configuration:CreateDefaultLandingPageEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

