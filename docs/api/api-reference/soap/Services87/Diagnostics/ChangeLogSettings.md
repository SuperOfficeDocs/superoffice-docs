---
uid: services87-diagnostics-changelogsettings
title: Services87.DiagnosticsAgent.ChangeLogSettings SOAP
Generated: true
---

# Services87 Diagnostics ChangeLogSettings SOAP

SOAP request and response examples **Remote/Services87/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IDiagnosticsAgent.ChangeLogSettings">SuperOffice.Services87.IDiagnosticsAgent.ChangeLogSettings</see> method.

## ChangeLogSettings

Change NetServer log settings.

* **logWarning:** Turn on warning log
* **logInformation:** Turn on information log
* **logSuccessAudit:** Turn on success audit log
* **logFailureAudit:** Turn on failure audit log
* **logToEventLog:** Log to event log
* **logToSuperOffice:** Log to SuperOffice
* **logToFile:** Log to file
* **logToTrace:** Log to trace



[WSDL file for Services87/Diagnostics](../Services87-Diagnostics.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangeLogSettings Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Diagnostics:ApplicationToken>1234567-1234-9876</Diagnostics:ApplicationToken>
  <Diagnostics:Credentials>
    <Diagnostics:Ticket>7T:1234abcxyzExample==</Diagnostics:Ticket>
  </Diagnostics:Credentials>
 <SOAP-ENV:Body>
   <Diagnostics:ChangeLogSettings>
    <Diagnostics:LogWarning xsi:type="xsd:boolean">false</Diagnostics:LogWarning>
    <Diagnostics:LogInformation xsi:type="xsd:boolean">false</Diagnostics:LogInformation>
    <Diagnostics:LogSuccessAudit xsi:type="xsd:boolean">false</Diagnostics:LogSuccessAudit>
    <Diagnostics:LogFailureAudit xsi:type="xsd:boolean">false</Diagnostics:LogFailureAudit>
    <Diagnostics:LogToEventLog xsi:type="xsd:boolean">false</Diagnostics:LogToEventLog>
    <Diagnostics:LogToSuperOffice xsi:type="xsd:boolean">false</Diagnostics:LogToSuperOffice>
    <Diagnostics:LogToFile xsi:type="xsd:boolean">false</Diagnostics:LogToFile>
    <Diagnostics:LogToTrace xsi:type="xsd:boolean">false</Diagnostics:LogToTrace>
   </Diagnostics:ChangeLogSettings>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChangeLogSettings Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Diagnostics:ChangeLogSettingsResponse>
  </Diagnostics:ChangeLogSettingsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

