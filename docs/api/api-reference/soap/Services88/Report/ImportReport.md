---
uid: services88-report-importreport
title: Services88.ReportAgent.ImportReport SOAP
Generated: true
---

# Services88 Report ImportReport SOAP

SOAP request and response examples **Remote/Services88/Report.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IReportAgent.ImportReport">SuperOffice.Services88.IReportAgent.ImportReport</see> method.

## ImportReport

Takes the input stream and create a report. This stream must be on a valid xml format

* **report:** The report to import in a correct xml format

**Returns:** The id of the newly imported report


[WSDL file for Services88/Report](../Services88-Report.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ImportReport Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Report:ImportReportResponse>
   <Report:Response xsi:type="xsd:int">0</Report:Response>
  </Report:ImportReportResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

