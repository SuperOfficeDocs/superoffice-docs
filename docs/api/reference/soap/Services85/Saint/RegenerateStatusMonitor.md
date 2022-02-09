---
title: Services85.SaintAgent.RegenerateStatusMonitor SOAP
generated: 1
uid: Services85-Saint-RegenerateStatusMonitor
---

# Services85 Saint RegenerateStatusMonitor

SOAP request and response examples **Remote/Services85/Saint.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISaintAgent.RegenerateStatusMonitor">SuperOffice.Services85.ISaintAgent.RegenerateStatusMonitor</see> method.

## RegenerateStatusMonitor

Regenerate the given status monitor

* **statusMonitorId:** The id of the statusmonitor to regenerate

**Returns:** This method has no return value


[WSDL file for Services85/Saint](../Services85-Saint.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RegenerateStatusMonitor Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services85">
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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Saint:RegenerateStatusMonitorResponse>
  </Saint:RegenerateStatusMonitorResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

