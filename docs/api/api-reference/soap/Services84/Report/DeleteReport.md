---
uid: services84-report-deletereport
title: Services84.ReportAgent.DeleteReport SOAP
Generated: true
---

# Services84 Report DeleteReport SOAP

SOAP request and response examples **Remote/Services84/Report.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IReportAgent.DeleteReport">SuperOffice.Services84.IReportAgent.DeleteReport</see> method.

## DeleteReport

Delete the report with the given id

* **reportId:** The id of the report to delete

**Returns:** Delete ok?


[WSDL file for Services84/Report](../Services84-Report.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteReport Request

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
   <Report:DeleteReport>
    <Report:ReportId xsi:type="xsd:int">0</Report:ReportId>
   </Report:DeleteReport>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteReport Response

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
  <Report:DeleteReportResponse>
   <Report:Response xsi:type="xsd:boolean">false</Report:Response>
  </Report:DeleteReportResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

