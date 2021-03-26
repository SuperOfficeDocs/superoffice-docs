---
uid: services75-saint-createdefaultstatusmonitorperiods
title: Services75.SaintAgent.CreateDefaultStatusMonitorPeriods SOAP
Generated: true
---

# Services75 Saint CreateDefaultStatusMonitorPeriods SOAP

SOAP request and response examples **Remote/Services75/Saint.svc**
Implemented by the <see cref="M:SuperOffice.Services75.ISaintAgent.CreateDefaultStatusMonitorPeriods">SuperOffice.Services75.ISaintAgent.CreateDefaultStatusMonitorPeriods</see> method.

## CreateDefaultStatusMonitorPeriods

Loading default values into a new StatusMonitorPeriods.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New StatusMonitorPeriods with default values


[WSDL file for Services75/Saint](../Services75-Saint.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultStatusMonitorPeriods Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Saint:ApplicationToken>1234567-1234-9876</Saint:ApplicationToken>
  <Saint:Credentials>
    <Saint:Ticket>7T:1234abcxyzExample==</Saint:Ticket>
  </Saint:Credentials>
 <SOAP-ENV:Body>
   <Saint:CreateDefaultStatusMonitorPeriods>
   </Saint:CreateDefaultStatusMonitorPeriods>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultStatusMonitorPeriods Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Saint:CreateDefaultStatusMonitorPeriodsResponse>
   <Saint:Response xsi:type="Saint:StatusMonitorPeriods">
    <Saint:Period1 xsi:type="xsd:int">0</Saint:Period1>
    <Saint:Period2 xsi:type="xsd:int">0</Saint:Period2>
    <Saint:Period3 xsi:type="xsd:int">0</Saint:Period3>
   </Saint:Response>
  </Saint:CreateDefaultStatusMonitorPeriodsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

