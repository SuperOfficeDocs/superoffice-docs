---
title: Services88.TimeZoneAgent.GetDefaultTimeZoneInformation SOAP
generated: true
uid: Services88-TimeZone-GetDefaultTimeZoneInformation
content_type: reference
---

# Services88 TimeZone GetDefaultTimeZoneInformation

SOAP request and response examples **Remote/Services88/TimeZone.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITimeZoneAgent.GetDefaultTimeZoneInformation">SuperOffice.Services88.ITimeZoneAgent.GetDefaultTimeZoneInformation</see> method.

## GetDefaultTimeZoneInformation





[WSDL file for Services88/TimeZone](../Services88-TimeZone.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultTimeZoneInformation Request

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
   <TimeZone:GetDefaultTimeZoneInformation>
   </TimeZone:GetDefaultTimeZoneInformation>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDefaultTimeZoneInformation Response

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
  <TimeZone:GetDefaultTimeZoneInformationResponse>
   <TimeZone:Response xsi:type="TimeZone:PreferredTimeZone">
    <TimeZone:PreferenceId xsi:type="xsd:int">0</TimeZone:PreferenceId>
    <TimeZone:TZLocationId xsi:type="xsd:int">0</TimeZone:TZLocationId>
    <TimeZone:LocationCode xsi:type="xsd:string"></TimeZone:LocationCode>
    <TimeZone:Description xsi:type="xsd:string"></TimeZone:Description>
    <TimeZone:Country xsi:type="xsd:string"></TimeZone:Country>
    <TimeZone:Bias xsi:type="xsd:short">0</TimeZone:Bias>
   </TimeZone:Response>
  </TimeZone:GetDefaultTimeZoneInformationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

