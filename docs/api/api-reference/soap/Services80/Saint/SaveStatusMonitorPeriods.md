---
uid: services80-saint-savestatusmonitorperiods
title: Services80.SaintAgent.SaveStatusMonitorPeriods SOAP
Generated: true
---

# Services80 Saint SaveStatusMonitorPeriods SOAP

SOAP request and response examples **Remote/Services80/Saint.svc**
Implemented by the <see cref="M:SuperOffice.Services80.ISaintAgent.SaveStatusMonitorPeriods">SuperOffice.Services80.ISaintAgent.SaveStatusMonitorPeriods</see> method.

## SaveStatusMonitorPeriods

Updates the existing StatusMonitorPeriods or creates a new StatusMonitorPeriods if the id parameter is empty

* **statusMonitorPeriods:** The StatusMonitorPeriods that is saved.

**Returns:** New or updated StatusMonitorPeriods


[WSDL file for Services80/Saint](../Services80-Saint.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveStatusMonitorPeriods Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Saint:ApplicationToken>1234567-1234-9876</Saint:ApplicationToken>
  <Saint:Credentials>
    <Saint:Ticket>7T:1234abcxyzExample==</Saint:Ticket>
  </Saint:Credentials>
 <SOAP-ENV:Body>
   <Saint:SaveStatusMonitorPeriods>
    <Saint:StatusMonitorPeriods xsi:type="Saint:StatusMonitorPeriods">
     <Saint:Period1 xsi:type="xsd:int">0</Saint:Period1>
     <Saint:Period2 xsi:type="xsd:int">0</Saint:Period2>
     <Saint:Period3 xsi:type="xsd:int">0</Saint:Period3>
    </Saint:StatusMonitorPeriods>
   </Saint:SaveStatusMonitorPeriods>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveStatusMonitorPeriods Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Saint:SaveStatusMonitorPeriodsResponse>
   <Saint:Response xsi:type="Saint:StatusMonitorPeriods">
    <Saint:Period1 xsi:type="xsd:int">0</Saint:Period1>
    <Saint:Period2 xsi:type="xsd:int">0</Saint:Period2>
    <Saint:Period3 xsi:type="xsd:int">0</Saint:Period3>
   </Saint:Response>
  </Saint:SaveStatusMonitorPeriodsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

