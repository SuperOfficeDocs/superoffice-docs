---
title: Services85.ReportAgent.GenerateReport SOAP
generated: 1
uid: Services85-Report-GenerateReport
---

# Services85 Report GenerateReport

SOAP request and response examples **Remote/Services85/Report.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IReportAgent.GenerateReport">SuperOffice.Services85.IReportAgent.GenerateReport</see> method.

## GenerateReport

Generates the report in PDF format

* **reportId:** The id of the report.
* **labelLayoutId:** The id of the labellayout. Use 0 if the report isn't of type label.
* **filename:** Filename of the report.
* **language:** Language to use when generating the report.
* **fileType:** 
* **restrictions:** Use restrictions to provide additional restrictions when generating the report.

**Returns:** Batch task id, as string. Used to be path to the generated report, but no more.


[WSDL file for Services85/Report](../Services85-Report.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GenerateReport Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Report:ApplicationToken>1234567-1234-9876</Report:ApplicationToken>
  <Report:Credentials>
    <Report:Ticket>7T:1234abcxyzExample==</Report:Ticket>
  </Report:Credentials>
 <SOAP-ENV:Body>
   <Report:GenerateReport>
    <Report:ReportId xsi:type="xsd:int">0</Report:ReportId>
    <Report:LabelLayoutId xsi:type="xsd:int">0</Report:LabelLayoutId>
    <Report:Filename xsi:type="xsd:string"></Report:Filename>
    <Report:Language xsi:type="xsd:string"></Report:Language>
    <Report:FileType xsi:type="xsd:string"></Report:FileType>
    <Report:Restrictions xsi:type="Report:ArrayOfArchiveRestrictionInfo">
     <Report:ArchiveRestrictionInfo xsi:type="Report:ArchiveRestrictionInfo">
      <Report:Name xsi:type="xsd:string"></Report:Name>
      <Report:Operator xsi:type="xsd:string"></Report:Operator>
      <Report:Values xsi:type="NetServerServices852:ArrayOfstring">
       <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
      </Report:Values>
      <Report:DisplayValues xsi:type="NetServerServices852:ArrayOfstring">
       <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
      </Report:DisplayValues>
      <Report:ColumnInfo xsi:type="Report:ArchiveColumnInfo">
       <Report:DisplayName xsi:type="xsd:string"></Report:DisplayName>
       <Report:DisplayTooltip xsi:type="xsd:string"></Report:DisplayTooltip>
       <Report:DisplayType xsi:type="xsd:string"></Report:DisplayType>
       <Report:CanOrderBy xsi:type="xsd:boolean">false</Report:CanOrderBy>
       <Report:Name xsi:type="xsd:string"></Report:Name>
       <Report:CanRestrictBy xsi:type="xsd:boolean">false</Report:CanRestrictBy>
       <Report:RestrictionType xsi:type="xsd:string"></Report:RestrictionType>
       <Report:RestrictionListName xsi:type="xsd:string"></Report:RestrictionListName>
       <Report:IsVisible xsi:type="xsd:boolean">false</Report:IsVisible>
       <Report:Width xsi:type="xsd:string"></Report:Width>
       <Report:IconHint xsi:type="xsd:string"></Report:IconHint>
       <Report:HeadingIconHint xsi:type="xsd:string"></Report:HeadingIconHint>
      </Report:ColumnInfo>
      <Report:IsActive xsi:type="xsd:boolean">false</Report:IsActive>
      <Report:SubRestrictions xsi:type="Report:ArrayOfArchiveRestrictionInfo">
       <Report:ArchiveRestrictionInfo xsi:type="Report:ArchiveRestrictionInfo">
        <Report:Name xsi:type="xsd:string"></Report:Name>
        <Report:Operator xsi:type="xsd:string"></Report:Operator>
        <Report:Values xsi:type="NetServerServices852:ArrayOfstring">
         <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
        </Report:Values>
        <Report:DisplayValues xsi:type="NetServerServices852:ArrayOfstring">
         <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
        </Report:DisplayValues>
        <Report:ColumnInfo xsi:type="Report:ArchiveColumnInfo">
         <Report:DisplayName xsi:type="xsd:string"></Report:DisplayName>
         <Report:DisplayTooltip xsi:type="xsd:string"></Report:DisplayTooltip>
         <Report:DisplayType xsi:type="xsd:string"></Report:DisplayType>
         <Report:CanOrderBy xsi:type="xsd:boolean">false</Report:CanOrderBy>
         <Report:Name xsi:type="xsd:string"></Report:Name>
         <Report:CanRestrictBy xsi:type="xsd:boolean">false</Report:CanRestrictBy>
         <Report:RestrictionType xsi:type="xsd:string"></Report:RestrictionType>
         <Report:RestrictionListName xsi:type="xsd:string"></Report:RestrictionListName>
         <Report:IsVisible xsi:type="xsd:boolean">false</Report:IsVisible>
         <Report:Width xsi:type="xsd:string"></Report:Width>
         <Report:IconHint xsi:type="xsd:string"></Report:IconHint>
         <Report:HeadingIconHint xsi:type="xsd:string"></Report:HeadingIconHint>
        </Report:ColumnInfo>
        <Report:IsActive xsi:type="xsd:boolean">false</Report:IsActive>
        <Report:SubRestrictions xsi:type="Report:ArrayOfArchiveRestrictionInfo">
         <Report:ArchiveRestrictionInfo xsi:type="Report:ArchiveRestrictionInfo">
          <Report:Name xsi:type="xsd:string"></Report:Name>
          <Report:Operator xsi:type="xsd:string"></Report:Operator>
          <Report:Values xsi:nil="true"></Report:Values>
          <Report:DisplayValues xsi:nil="true"></Report:DisplayValues>
          <Report:ColumnInfo xsi:nil="true"></Report:ColumnInfo>
          <Report:IsActive xsi:nil="true"></Report:IsActive>
          <Report:SubRestrictions xsi:nil="true"></Report:SubRestrictions>
          <Report:InterParenthesis xsi:nil="true"></Report:InterParenthesis>
          <Report:InterOperator xsi:nil="true"></Report:InterOperator>
          <Report:UniqueHash xsi:nil="true"></Report:UniqueHash>
         </Report:ArchiveRestrictionInfo>
        </Report:SubRestrictions>
        <Report:InterParenthesis xsi:type="xsd:int">0</Report:InterParenthesis>
        <Report:InterOperator xsi:type="Report:InterRestrictionOperator">None</Report:InterOperator>
        <Report:UniqueHash xsi:type="xsd:int">0</Report:UniqueHash>
       </Report:ArchiveRestrictionInfo>
      </Report:SubRestrictions>
      <Report:InterParenthesis xsi:type="xsd:int">0</Report:InterParenthesis>
      <Report:InterOperator xsi:type="Report:InterRestrictionOperator">None</Report:InterOperator>
      <Report:UniqueHash xsi:type="xsd:int">0</Report:UniqueHash>
     </Report:ArchiveRestrictionInfo>
    </Report:Restrictions>
   </Report:GenerateReport>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GenerateReport Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Report:GenerateReportResponse>
   <Report:Response xsi:type="xsd:string"></Report:Response>
  </Report:GenerateReportResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

