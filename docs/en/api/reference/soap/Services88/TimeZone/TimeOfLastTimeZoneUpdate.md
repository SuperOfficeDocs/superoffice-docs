---
title: Services88.TimeZoneAgent.TimeOfLastTimeZoneUpdate SOAP
generated: true
uid: Services88-TimeZone-TimeOfLastTimeZoneUpdate
---

# Services88 TimeZone TimeOfLastTimeZoneUpdate

SOAP request and response examples **Remote/Services88/TimeZone.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITimeZoneAgent.TimeOfLastTimeZoneUpdate">SuperOffice.Services88.ITimeZoneAgent.TimeOfLastTimeZoneUpdate</see> method.

## TimeOfLastTimeZoneUpdate





[WSDL file for Services88/TimeZone](../Services88-TimeZone.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## TimeOfLastTimeZoneUpdate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <TimeZone:ApplicationToken>1234567-1234-9876</TimeZone:ApplicationToken>
  <TimeZone:Credentials>
    <TimeZone:Ticket>7T:1234abcxyzExample==</TimeZone:Ticket>
  </TimeZone:Credentials>
 <SOAP-ENV:Body>
   <TimeZone:TimeOfLastTimeZoneUpdate>
   </TimeZone:TimeOfLastTimeZoneUpdate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## TimeOfLastTimeZoneUpdate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <TimeZone:TimeOfLastTimeZoneUpdateResponse>
   <TimeZone:Response xsi:type="xsd:dateTime">2025-06-26T01:45:01Z</TimeZone:Response>
  </TimeZone:TimeOfLastTimeZoneUpdateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

