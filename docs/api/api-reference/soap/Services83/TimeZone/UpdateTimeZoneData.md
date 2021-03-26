---
uid: services83-timezone-updatetimezonedata
title: Services83.TimeZoneAgent.UpdateTimeZoneData SOAP
Generated: true
---

# Services83 TimeZone UpdateTimeZoneData SOAP

SOAP request and response examples **Remote/Services83/TimeZone.svc**
Implemented by the <see cref="M:SuperOffice.Services83.ITimeZoneAgent.UpdateTimeZoneData">SuperOffice.Services83.ITimeZoneAgent.UpdateTimeZoneData</see> method.

## UpdateTimeZoneData

Retrieve time zone data from the SuperOffice server and update TimeZone data in the database


**Returns:** Returns true if the operation succeeded


[WSDL file for Services83/TimeZone](../Services83-TimeZone.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateTimeZoneData Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services83">
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
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <TimeZone:UpdateTimeZoneDataResponse>
   <TimeZone:Response xsi:type="xsd:boolean">false</TimeZone:Response>
  </TimeZone:UpdateTimeZoneDataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

