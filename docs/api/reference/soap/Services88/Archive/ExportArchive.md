---
title: Services88.ArchiveAgent.ExportArchive SOAP
generated: 1
uid: Services88-Archive-ExportArchive
---

# Services88 Archive ExportArchive

SOAP request and response examples **Remote/Services88/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IArchiveAgent.ExportArchive">SuperOffice.Services88.IArchiveAgent.ExportArchive</see> method.

## ExportArchive

Exports the target archive to a downloadable format.

* **providerName:** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
* **context:** Context parameter, url-encoded string context parameter for ArchiveProvider constructor
* **desiredEntities:** Comma separated list of the names of the desired entities.
* **columns:** Comma separated list of the names of the columns wanted; supports display names
* **sortOrder:** 
* **restrictions:** 
* **exportType:** To what format the archive should be exported; Excel, etc.
* **selectedRowIds:** 
* **estimatedRowCount:** The estimated amount of rows to be exported. Used to determine if the operation should be run as a batch task or immediately.



[WSDL file for Services88/Archive](../Services88-Archive.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ExportArchive Request

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
   <Archive:ExportArchive>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:Context xsi:type="xsd:string"></Archive:Context>
    <Archive:DesiredEntities xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Archive:DesiredEntities>
    <Archive:Columns xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Archive:Columns>
    <Archive:SortOrder xsi:type="Archive:ArrayOfArchiveOrderByInfo">
     <Archive:ArchiveOrderByInfo xsi:type="Archive:ArchiveOrderByInfo">
      <Archive:Name xsi:type="xsd:string"></Archive:Name>
      <Archive:Direction xsi:type="Archive:OrderBySortType">ASC</Archive:Direction>
     </Archive:ArchiveOrderByInfo>
    </Archive:SortOrder>
    <Archive:Restrictions xsi:type="Archive:ArrayOfArchiveRestrictionInfo">
     <Archive:ArchiveRestrictionInfo xsi:type="Archive:ArchiveRestrictionInfo">
      <Archive:Name xsi:type="xsd:string"></Archive:Name>
      <Archive:Operator xsi:type="xsd:string"></Archive:Operator>
      <Archive:Values xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </Archive:Values>
      <Archive:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </Archive:DisplayValues>
      <Archive:ColumnInfo xsi:type="Archive:ArchiveColumnInfo">
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
      </Archive:ColumnInfo>
      <Archive:IsActive xsi:type="xsd:boolean">false</Archive:IsActive>
      <Archive:SubRestrictions xsi:type="Archive:ArrayOfArchiveRestrictionInfo">
       <Archive:ArchiveRestrictionInfo xsi:type="Archive:ArchiveRestrictionInfo">
        <Archive:Name xsi:type="xsd:string"></Archive:Name>
        <Archive:Operator xsi:type="xsd:string"></Archive:Operator>
        <Archive:Values xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </Archive:Values>
        <Archive:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </Archive:DisplayValues>
        <Archive:ColumnInfo xsi:type="Archive:ArchiveColumnInfo">
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
        </Archive:ColumnInfo>
        <Archive:IsActive xsi:type="xsd:boolean">false</Archive:IsActive>
        <Archive:SubRestrictions xsi:type="Archive:ArrayOfArchiveRestrictionInfo">
         <Archive:ArchiveRestrictionInfo xsi:type="Archive:ArchiveRestrictionInfo">
          <Archive:Name xsi:type="xsd:string"></Archive:Name>
          <Archive:Operator xsi:type="xsd:string"></Archive:Operator>
          <Archive:Values xsi:nil="true"></Archive:Values>
          <Archive:DisplayValues xsi:nil="true"></Archive:DisplayValues>
          <Archive:ColumnInfo xsi:nil="true"></Archive:ColumnInfo>
          <Archive:IsActive xsi:nil="true"></Archive:IsActive>
          <Archive:SubRestrictions xsi:nil="true"></Archive:SubRestrictions>
          <Archive:InterParenthesis xsi:nil="true"></Archive:InterParenthesis>
          <Archive:InterOperator xsi:nil="true"></Archive:InterOperator>
          <Archive:UniqueHash xsi:nil="true"></Archive:UniqueHash>
         </Archive:ArchiveRestrictionInfo>
        </Archive:SubRestrictions>
        <Archive:InterParenthesis xsi:type="xsd:int">0</Archive:InterParenthesis>
        <Archive:InterOperator xsi:type="Archive:InterRestrictionOperator">None</Archive:InterOperator>
        <Archive:UniqueHash xsi:type="xsd:int">0</Archive:UniqueHash>
       </Archive:ArchiveRestrictionInfo>
      </Archive:SubRestrictions>
      <Archive:InterParenthesis xsi:type="xsd:int">0</Archive:InterParenthesis>
      <Archive:InterOperator xsi:type="Archive:InterRestrictionOperator">None</Archive:InterOperator>
      <Archive:UniqueHash xsi:type="xsd:int">0</Archive:UniqueHash>
     </Archive:ArchiveRestrictionInfo>
    </Archive:Restrictions>
    <Archive:ExportType xsi:type="xsd:string"></Archive:ExportType>
    <Archive:SelectedRowIds xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Archive:SelectedRowIds>
    <Archive:EstimatedRowCount xsi:type="xsd:int">0</Archive:EstimatedRowCount>
   </Archive:ExportArchive>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ExportArchive Response

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
  <Archive:ExportArchiveResponse>
   <Archive:Response xsi:type="Archive:ExportArchiveResult">
    <Archive:BatchTaskId xsi:type="xsd:int">0</Archive:BatchTaskId>
    <Archive:FileName xsi:type="xsd:string"></Archive:FileName>
    <Archive:Message xsi:type="xsd:string"></Archive:Message>
   </Archive:Response>
  </Archive:ExportArchiveResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

