---
uid: services87-timezone-setactivetimezonesbyfilter
title: Services87.TimeZoneAgent.SetActiveTimeZonesByFilter SOAP
Generated: true
---

# Services87 TimeZone SetActiveTimeZonesByFilter SOAP

SOAP request and response examples **Remote/Services87/TimeZone.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ITimeZoneAgent.SetActiveTimeZonesByFilter">SuperOffice.Services87.ITimeZoneAgent.SetActiveTimeZonesByFilter</see> method.

## SetActiveTimeZonesByFilter

Toggles active state of a single row in the TZLocation table

* **filter:** Filter timezones
* **active:** Set active to true or false



[WSDL file for Services87/TimeZone](../Services87-TimeZone.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetActiveTimeZonesByFilter Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <TimeZone:ApplicationToken>1234567-1234-9876</TimeZone:ApplicationToken>
  <TimeZone:Credentials>
    <TimeZone:Ticket>7T:1234abcxyzExample==</TimeZone:Ticket>
  </TimeZone:Credentials>
 <SOAP-ENV:Body>
   <TimeZone:SetActiveTimeZonesByFilter>
    <TimeZone:Filter xsi:type="xsd:string"></TimeZone:Filter>
    <TimeZone:Active xsi:type="xsd:boolean">false</TimeZone:Active>
   </TimeZone:SetActiveTimeZonesByFilter>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetActiveTimeZonesByFilter Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <TimeZone:SetActiveTimeZonesByFilterResponse>
  </TimeZone:SetActiveTimeZonesByFilterResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

