---
uid: services80-saint-regeneratestatusmonitor
title: Services80.SaintAgent.RegenerateStatusMonitor SOAP
Generated: true
---

# Services80 Saint RegenerateStatusMonitor SOAP

SOAP request and response examples **Remote/Services80/Saint.svc**
Implemented by the <see cref="M:SuperOffice.Services80.ISaintAgent.RegenerateStatusMonitor">SuperOffice.Services80.ISaintAgent.RegenerateStatusMonitor</see> method.

## RegenerateStatusMonitor

Regenerate the given status monitor

* **statusMonitorId:** The id of the statusmonitor to regenerate

**Returns:** This method has no return value


[WSDL file for Services80/Saint](../Services80-Saint.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RegenerateStatusMonitor Request

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
   <Saint:RegenerateStatusMonitor>
    <Saint:StatusMonitorId xsi:type="xsd:int">0</Saint:StatusMonitorId>
   </Saint:RegenerateStatusMonitor>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RegenerateStatusMonitor Response

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
  <Saint:RegenerateStatusMonitorResponse>
  </Saint:RegenerateStatusMonitorResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

