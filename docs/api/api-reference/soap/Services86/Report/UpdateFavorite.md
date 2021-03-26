---
uid: services86-report-updatefavorite
title: Services86.ReportAgent.UpdateFavorite SOAP
Generated: true
---

# Services86 Report UpdateFavorite SOAP

SOAP request and response examples **Remote/Services86/Report.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IReportAgent.UpdateFavorite">SuperOffice.Services86.IReportAgent.UpdateFavorite</see> method.

## UpdateFavorite

Updates the favorite.

* **reportEntity:** ReportEntity carrier containg updated data.

**Returns:** The updated ReportEntity carrier.


[WSDL file for Services86/Report](../Services86-Report.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateFavorite Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Report:ApplicationToken>1234567-1234-9876</Report:ApplicationToken>
  <Report:Credentials>
    <Report:Ticket>7T:1234abcxyzExample==</Report:Ticket>
  </Report:Credentials>
 <SOAP-ENV:Body>
   <Report:UpdateFavorite>
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
   </Report:UpdateFavorite>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateFavorite Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Report:UpdateFavoriteResponse>
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
  </Report:UpdateFavoriteResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

