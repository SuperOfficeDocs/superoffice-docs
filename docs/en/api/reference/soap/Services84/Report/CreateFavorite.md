---
title: Services84.ReportAgent.CreateFavorite SOAP
generated: 1
uid: Services84-Report-CreateFavorite
---

# Services84 Report CreateFavorite

SOAP request and response examples **Remote/Services84/Report.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IReportAgent.CreateFavorite">SuperOffice.Services84.IReportAgent.CreateFavorite</see> method.

## CreateFavorite

[WSDL file for Services84/Report](../Services84-Report.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateFavorite Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Report:ApplicationToken>1234567-1234-9876</Report:ApplicationToken>
  <Report:Credentials>
    <Report:Ticket>7T:1234abcxyzExample==</Report:Ticket>
  </Report:Credentials>
 <SOAP-ENV:Body>
   <Report:CreateFavorite>
    <Report:SourceId xsi:type="xsd:int">0</Report:SourceId>
    <Report:Name xsi:type="xsd:string"></Report:Name>
    <Report:Description xsi:type="xsd:string"></Report:Description>
   </Report:CreateFavorite>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## CreateFavorite Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Report:CreateFavoriteResponse>
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
  </Report:CreateFavoriteResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
