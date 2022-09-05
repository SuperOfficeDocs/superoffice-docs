---
title: Services88.TimeZoneAgent.GetDefaultTimeZonePreference SOAP
generated: 1
uid: Services88-TimeZone-GetDefaultTimeZonePreference
---

# Services88 TimeZone GetDefaultTimeZonePreference

SOAP request and response examples **Remote/Services88/TimeZone.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITimeZoneAgent.GetDefaultTimeZonePreference">SuperOffice.Services88.ITimeZoneAgent.GetDefaultTimeZonePreference</see> method.

## GetDefaultTimeZonePreference

Returns the id of the default timezone preference with deflevel system wide


**Returns:** The id of the system wide default timezone preference


[WSDL file for Services88/TimeZone](../Services88-TimeZone.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultTimeZonePreference Request

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
   <TimeZone:GetDefaultTimeZonePreference>
   </TimeZone:GetDefaultTimeZonePreference>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDefaultTimeZonePreference Response

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
  <TimeZone:GetDefaultTimeZonePreferenceResponse>
   <TimeZone:Response xsi:type="xsd:int">0</TimeZone:Response>
  </TimeZone:GetDefaultTimeZonePreferenceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

