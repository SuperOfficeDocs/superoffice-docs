---
title: Services84.ReportAgent.ImportReport SOAP
generated: 1
uid: Services84-Report-ImportReport
---

# Services84 Report ImportReport

SOAP request and response examples **Remote/Services84/Report.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IReportAgent.ImportReport">SuperOffice.Services84.IReportAgent.ImportReport</see> method.

## ImportReport

Takes the input stream and create a report. This stream must be on a valid xml format

* **report:** The report to import in a correct xml format

**Returns:** The id of the newly imported report


[WSDL file for Services84/Report](../Services84-Report.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ImportReport Request

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
   <Report:ImportReport>
    <Report:Report xsi:type="xsd:string"></Report:Report>
   </Report:ImportReport>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ImportReport Response

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
  <Report:ImportReportResponse>
   <Report:Response xsi:type="xsd:int">0</Report:Response>
  </Report:ImportReportResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

