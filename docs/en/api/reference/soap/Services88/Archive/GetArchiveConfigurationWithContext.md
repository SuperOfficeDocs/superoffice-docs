---
title: Services88.ArchiveAgent.GetArchiveConfigurationWithContext SOAP
generated: true
uid: Services88-Archive-GetArchiveConfigurationWithContext
---

# Services88 Archive GetArchiveConfigurationWithContext

SOAP request and response examples **Remote/Services88/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IArchiveAgent.GetArchiveConfigurationWithContext">SuperOffice.Services88.IArchiveAgent.GetArchiveConfigurationWithContext</see> method.

## GetArchiveConfigurationWithContext





[WSDL file for Services88/Archive](../Services88-Archive.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetArchiveConfigurationWithContext Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:GetArchiveConfigurationWithContext>
    <Archive:GuiName xsi:type="xsd:string"></Archive:GuiName>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:Context xsi:type="xsd:string"></Archive:Context>
   </Archive:GetArchiveConfigurationWithContext>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetArchiveConfigurationWithContext Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Archive:GetArchiveConfigurationWithContextResponse>
   <Archive:Response xsi:type="Archive:ArchiveConfiguration">
    <Archive:ArchiveColumnInfo xsi:type="Archive:ArrayOfArchiveColumnInfo">
     <Archive:ArchiveColumnInfo xsi:type="Archive:ArchiveColumnInfo">
      <Archive:DisplayName xsi:type="xsd:string"></Archive:DisplayName>
      <Archive:DisplayTooltip xsi:type="xsd:string"></Archive:DisplayTooltip>
      <Archive:DisplayType xsi:type="xsd:string"></Archive:DisplayType>
      <Archive:CanOrderBy xsi:type="xsd:boolean">false</Archive:CanOrderBy>
      <Archive:Name xsi:type="xsd:string"></Archive:Name>
      <Archive:CanRestrictBy xsi:type="xsd:boolean">false</Archive:CanRestrictBy>
      <Archive:RestrictionType xsi:type="xsd:string"></Archive:RestrictionType>
      <Archive:RestrictionListName xsi:type="xsd:string"></Archive:RestrictionListName>
      <Archive:IsVisible xsi:type="xsd:boolean">false</Archive:IsVisible>
      <Archive:Width xsi:type="xsd:string"></Archive:Width>
      <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
      <Archive:HeadingIconHint xsi:type="xsd:string"></Archive:HeadingIconHint>
      <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
     </Archive:ArchiveColumnInfo>
    </Archive:ArchiveColumnInfo>
    <Archive:ArchiveEntityInfo xsi:type="Archive:ArrayOfSelectableMDOListItem">
     <Archive:SelectableMDOListItem xsi:type="Archive:SelectableMDOListItem">
      <Archive:Id xsi:type="xsd:int">0</Archive:Id>
      <Archive:Name xsi:type="xsd:string"></Archive:Name>
      <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
      <Archive:Deleted xsi:type="xsd:boolean">false</Archive:Deleted>
      <Archive:Rank xsi:type="xsd:int">0</Archive:Rank>
      <Archive:Type xsi:type="xsd:string"></Archive:Type>
      <Archive:ColorBlock xsi:type="xsd:int">0</Archive:ColorBlock>
      <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
      <Archive:Selected xsi:type="xsd:boolean">false</Archive:Selected>
      <Archive:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:42:53Z</Archive:LastChanged>
      <Archive:ChildItems xsi:type="Archive:ArrayOfSelectableMDOListItem">
       <Archive:SelectableMDOListItem xsi:type="Archive:SelectableMDOListItem">
        <Archive:Id xsi:type="xsd:int">0</Archive:Id>
        <Archive:Name xsi:type="xsd:string"></Archive:Name>
        <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
        <Archive:Deleted xsi:type="xsd:boolean">false</Archive:Deleted>
        <Archive:Rank xsi:type="xsd:int">0</Archive:Rank>
        <Archive:Type xsi:type="xsd:string"></Archive:Type>
        <Archive:ColorBlock xsi:type="xsd:int">0</Archive:ColorBlock>
        <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
        <Archive:Selected xsi:type="xsd:boolean">false</Archive:Selected>
        <Archive:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:42:53Z</Archive:LastChanged>
        <Archive:ChildItems xsi:type="Archive:ArrayOfSelectableMDOListItem">
         <Archive:SelectableMDOListItem xsi:type="Archive:SelectableMDOListItem">
          <Archive:Id xsi:nil="true"></Archive:Id>
          <Archive:Name xsi:type="xsd:string"></Archive:Name>
          <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
          <Archive:Deleted xsi:nil="true"></Archive:Deleted>
          <Archive:Rank xsi:nil="true"></Archive:Rank>
          <Archive:Type xsi:type="xsd:string"></Archive:Type>
          <Archive:ColorBlock xsi:nil="true"></Archive:ColorBlock>
          <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
          <Archive:Selected xsi:nil="true"></Archive:Selected>
          <Archive:LastChanged xsi:nil="true"></Archive:LastChanged>
          <Archive:ChildItems xsi:nil="true"></Archive:ChildItems>
          <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
          <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
          <Archive:Hidden xsi:nil="true"></Archive:Hidden>
          <Archive:FullName xsi:type="xsd:string"></Archive:FullName>
         </Archive:SelectableMDOListItem>
        </Archive:ChildItems>
        <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
        <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
        <Archive:Hidden xsi:type="xsd:boolean">false</Archive:Hidden>
        <Archive:FullName xsi:type="xsd:string"></Archive:FullName>
       </Archive:SelectableMDOListItem>
      </Archive:ChildItems>
      <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
      <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
      <Archive:Hidden xsi:type="xsd:boolean">false</Archive:Hidden>
      <Archive:FullName xsi:type="xsd:string"></Archive:FullName>
     </Archive:SelectableMDOListItem>
    </Archive:ArchiveEntityInfo>
    <Archive:ArchiveOrderByInfo xsi:type="Archive:ArrayOfArchiveOrderByInfo">
     <Archive:ArchiveOrderByInfo xsi:type="Archive:ArchiveOrderByInfo">
      <Archive:Name xsi:type="xsd:string"></Archive:Name>
      <Archive:Direction xsi:type="Archive:OrderBySortType">ASC</Archive:Direction>
     </Archive:ArchiveOrderByInfo>
    </Archive:ArchiveOrderByInfo>
    <Archive:OwnerKeys xsi:type="xsd:string"></Archive:OwnerKeys>
   </Archive:Response>
  </Archive:GetArchiveConfigurationWithContextResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

