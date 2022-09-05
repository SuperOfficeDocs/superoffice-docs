---
title: Services85.TimeZoneAgent.GetBaseTimeZoneId SOAP
generated: 1
uid: Services85-TimeZone-GetBaseTimeZoneId
---

# Services85 TimeZone GetBaseTimeZoneId

SOAP request and response examples **Remote/Services85/TimeZone.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ITimeZoneAgent.GetBaseTimeZoneId">SuperOffice.Services85.ITimeZoneAgent.GetBaseTimeZoneId</see> method.

## GetBaseTimeZoneId

Get the base timezone id.


**Returns:** Returns the base timezone id. Returns 0 if not set.


[WSDL file for Services85/TimeZone](../Services85-TimeZone.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetBaseTimeZoneId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <TimeZone:ApplicationToken>1234567-1234-9876</TimeZone:ApplicationToken>
  <TimeZone:Credentials>
    <TimeZone:Ticket>7T:1234abcxyzExample==</TimeZone:Ticket>
  </TimeZone:Credentials>
 <SOAP-ENV:Body>
   <TimeZone:GetBaseTimeZoneId>
   </TimeZone:GetBaseTimeZoneId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetBaseTimeZoneId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:TimeZone="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <TimeZone:GetBaseTimeZoneIdResponse>
   <TimeZone:Response xsi:type="xsd:int">0</TimeZone:Response>
  </TimeZone:GetBaseTimeZoneIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

