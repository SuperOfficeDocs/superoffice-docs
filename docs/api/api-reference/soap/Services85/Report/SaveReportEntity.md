---
uid: services85-report-savereportentity
title: Services85.ReportAgent.SaveReportEntity SOAP
Generated: true
---

# Services85 Report SaveReportEntity SOAP

SOAP request and response examples **Remote/Services85/Report.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IReportAgent.SaveReportEntity">SuperOffice.Services85.IReportAgent.SaveReportEntity</see> method.

## SaveReportEntity

Updates the existing ReportEntity or creates a new ReportEntity if the id parameter is 0.

* **reportEntity:** The ReportEntity that is saved.

**Returns:** New or updated ReportEntity


[WSDL file for Services85/Report](../Services85-Report.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveReportEntity Request

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
   <Report:SaveReportEntity>
    <Report:ReportEntity xsi:type="Report:ReportEntity">
     <Report:ReportId xsi:type="xsd:int">0</Report:ReportId>
     <Report:ReportCategory xsi:type="Report:ReportCategory">None</Report:ReportCategory>
     <Report:Description xsi:type="xsd:string"></Report:Description>
     <Report:ReportLayout xsi:type="Report:ReportLayout">Unknown</Report:ReportLayout>
     <Report:Name xsi:type="xsd:string"></Report:Name>
     <Report:AssociateId xsi:type="xsd:int">0</Report:AssociateId>
     <Report:TemplateId xsi:type="xsd:int">0</Report:TemplateId>
     <Report:Published xsi:type="xsd:boolean">false</Report:Published>
    </Report:ReportEntity>
   </Report:SaveReportEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveReportEntity Response

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
  <Report:SaveReportEntityResponse>
   <Report:Response xsi:type="Report:ReportEntity">
    <Report:ReportId xsi:type="xsd:int">0</Report:ReportId>
    <Report:ReportCategory xsi:type="Report:ReportCategory">None</Report:ReportCategory>
    <Report:Description xsi:type="xsd:string"></Report:Description>
    <Report:ReportLayout xsi:type="Report:ReportLayout">Unknown</Report:ReportLayout>
    <Report:Name xsi:type="xsd:string"></Report:Name>
    <Report:AssociateId xsi:type="xsd:int">0</Report:AssociateId>
    <Report:TemplateId xsi:type="xsd:int">0</Report:TemplateId>
    <Report:Published xsi:type="xsd:boolean">false</Report:Published>
   </Report:Response>
  </Report:SaveReportEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

