---
uid: services82-timezone-updatetimezonedata
title: Services82.TimeZoneAgent.UpdateTimeZoneData SOAP
Generated: true
---

# Services82 TimeZone UpdateTimeZoneData SOAP

SOAP request and response examples **Remote/Services82/TimeZone.svc**
Implemented by the <see cref="M:SuperOffice.Services82.ITimeZoneAgent.UpdateTimeZoneData">SuperOffice.Services82.ITimeZoneAgent.UpdateTimeZoneData</see> method.

## UpdateTimeZoneData

Retrieve time zone data from the SuperOffice server and update TimeZone data in the database


**Returns:** Returns true if the operation succeeded


[WSDL file for Services82/TimeZone](../Services82-TimeZone.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateTimeZoneData Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <TimeZone:ApplicationToken>1234567-1234-9876</TimeZone:ApplicationToken>
  <TimeZone:Credentials>
    <TimeZone:Ticket>7T:1234abcxyzExample==</TimeZone:Ticket>
  </TimeZone:Credentials>
 <SOAP-ENV:Body>
   <TimeZone:UpdateTimeZoneData>
   </TimeZone:UpdateTimeZoneData>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateTimeZoneData Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <TimeZone:UpdateTimeZoneDataResponse>
   <TimeZone:Response xsi:type="xsd:boolean">false</TimeZone:Response>
  </TimeZone:UpdateTimeZoneDataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

