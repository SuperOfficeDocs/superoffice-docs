---
title: Services84.ArchiveAgent.GetArchiveConfiguration SOAP
generated: 1
uid: Services84-Archive-GetArchiveConfiguration
---

# Services84 Archive GetArchiveConfiguration

SOAP request and response examples **Remote/Services84/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IArchiveAgent.GetArchiveConfiguration">SuperOffice.Services84.IArchiveAgent.GetArchiveConfiguration</see> method.

## GetArchiveConfiguration

Get the configuration for one archive. The configuration is keyed by a combination of archive provider name and gui name. The archive provider name must match an archive provider plugin; the gui name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in a gui.

* **guiName:** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
* **providerName:** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.

**Returns:** Archive configuration consisting of column information, orderby information and entities


[WSDL file for Services84/Archive](../Services84-Archive.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetArchiveConfiguration Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:GetArchiveConfiguration>
    <Archive:GuiName xsi:type="xsd:string"></Archive:GuiName>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
   </Archive:GetArchiveConfiguration>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetArchiveConfiguration Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Archive:GetArchiveConfigurationResponse>
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
      <Archive:LastChanged xsi:type="xsd:dateTime">2022-08-26T08:50:09Z</Archive:LastChanged>
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
        <Archive:LastChanged xsi:type="xsd:dateTime">2022-08-26T08:50:09Z</Archive:LastChanged>
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
   </Archive:Response>
  </Archive:GetArchiveConfigurationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

