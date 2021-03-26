---
uid: services80-timezone-setactivetimezonerow
title: Services80.TimeZoneAgent.SetActiveTimeZoneRow SOAP
Generated: true
---

# Services80 TimeZone SetActiveTimeZoneRow SOAP

SOAP request and response examples **Remote/Services80/TimeZone.svc**
Implemented by the <see cref="M:SuperOffice.Services80.ITimeZoneAgent.SetActiveTimeZoneRow">SuperOffice.Services80.ITimeZoneAgent.SetActiveTimeZoneRow</see> method.

## SetActiveTimeZoneRow

Set active state of singe row in the TZLocation table

* **id:** Id of row to set active state on
* **active:** Set active to true or false



[WSDL file for Services80/TimeZone](../Services80-TimeZone.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetActiveTimeZoneRow Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <TimeZone:ApplicationToken>1234567-1234-9876</TimeZone:ApplicationToken>
  <TimeZone:Credentials>
    <TimeZone:Ticket>7T:1234abcxyzExample==</TimeZone:Ticket>
  </TimeZone:Credentials>
 <SOAP-ENV:Body>
   <TimeZone:SetActiveTimeZoneRow>
    <TimeZone:Id xsi:type="xsd:int">0</TimeZone:Id>
    <TimeZone:Active xsi:type="xsd:boolean">false</TimeZone:Active>
   </TimeZone:SetActiveTimeZoneRow>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetActiveTimeZoneRow Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <TimeZone:SetActiveTimeZoneRowResponse>
  </TimeZone:SetActiveTimeZoneRowResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

