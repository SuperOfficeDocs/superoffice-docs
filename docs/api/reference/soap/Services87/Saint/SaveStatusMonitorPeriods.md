---
title: Services87.SaintAgent.SaveStatusMonitorPeriods SOAP
generated: 1
uid: Services87-Saint-SaveStatusMonitorPeriods
---

# Services87 Saint SaveStatusMonitorPeriods

SOAP request and response examples **Remote/Services87/Saint.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ISaintAgent.SaveStatusMonitorPeriods">SuperOffice.Services87.ISaintAgent.SaveStatusMonitorPeriods</see> method.

## SaveStatusMonitorPeriods

Updates the existing StatusMonitorPeriods or creates a new StatusMonitorPeriods if the id parameter is 0.

* **statusMonitorPeriods:** The StatusMonitorPeriods that is saved.

**Returns:** New or updated StatusMonitorPeriods


[WSDL file for Services87/Saint](../Services87-Saint.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveStatusMonitorPeriods Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services87">
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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services87">
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

