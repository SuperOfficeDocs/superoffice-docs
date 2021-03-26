---
uid: services82-timezone-initializetimezonedata
title: Services82.TimeZoneAgent.InitializeTimeZoneData SOAP
Generated: true
---

# Services82 TimeZone InitializeTimeZoneData SOAP

SOAP request and response examples **Remote/Services82/TimeZone.svc**
Implemented by the <see cref="M:SuperOffice.Services82.ITimeZoneAgent.InitializeTimeZoneData">SuperOffice.Services82.ITimeZoneAgent.InitializeTimeZoneData</see> method.

## InitializeTimeZoneData

Initalizes the TimeZoneData




[WSDL file for Services82/TimeZone](../Services82-TimeZone.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## InitializeTimeZoneData Request

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
   <TimeZone:InitializeTimeZoneData>
   </TimeZone:InitializeTimeZoneData>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## InitializeTimeZoneData Response

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
  <TimeZone:InitializeTimeZoneDataResponse>
   <TimeZone:Response xsi:type="TimeZone:ArrayOfTimeZoneData">
    <TimeZone:TimeZoneData xsi:type="TimeZone:TimeZoneData">
     <TimeZone:TZLocationID xsi:type="xsd:int">0</TimeZone:TZLocationID>
     <TimeZone:Name xsi:type="xsd:string"></TimeZone:Name>
     <TimeZone:TZLocationCode xsi:type="xsd:string"></TimeZone:TZLocationCode>
     <TimeZone:TZLocationCities xsi:type="xsd:string"></TimeZone:TZLocationCities>
     <TimeZone:IsoNumber xsi:type="xsd:int">0</TimeZone:IsoNumber>
     <TimeZone:TimeZoneSTDRules xsi:type="TimeZone:TimeZoneRuleDictionary">
      <TimeZone:TimeZoneRuleKeyValuePair>
       <TimeZone:Key xsi:type="xsd:dateTime"></TimeZone:Key>
       <TimeZone:Value xsi:type="TimeZone:TimeZoneRule">
        <TimeZone:TZOffset xsi:type="xsd:int">0</TimeZone:TZOffset>
        <TimeZone:StartRulePattern xsi:type="xsd:string"></TimeZone:StartRulePattern>
        <TimeZone:EndRulePattern xsi:type="xsd:string"></TimeZone:EndRulePattern>
        <TimeZone:StartDay xsi:type="xsd:int">0</TimeZone:StartDay>
        <TimeZone:StartMonth xsi:type="xsd:int">0</TimeZone:StartMonth>
        <TimeZone:EndDay xsi:type="xsd:int">0</TimeZone:EndDay>
        <TimeZone:EndMonth xsi:type="xsd:int">0</TimeZone:EndMonth>
       </TimeZone:Value>
      </TimeZone:TimeZoneRuleKeyValuePair>
     </TimeZone:TimeZoneSTDRules>
     <TimeZone:TimeZoneDSTRules xsi:type="TimeZone:TimeZoneRuleDictionary">
      <TimeZone:TimeZoneRuleKeyValuePair>
       <TimeZone:Key xsi:type="xsd:dateTime"></TimeZone:Key>
       <TimeZone:Value xsi:type="TimeZone:TimeZoneRule">
        <TimeZone:TZOffset xsi:type="xsd:int">0</TimeZone:TZOffset>
        <TimeZone:StartRulePattern xsi:type="xsd:string"></TimeZone:StartRulePattern>
        <TimeZone:EndRulePattern xsi:type="xsd:string"></TimeZone:EndRulePattern>
        <TimeZone:StartDay xsi:type="xsd:int">0</TimeZone:StartDay>
        <TimeZone:StartMonth xsi:type="xsd:int">0</TimeZone:StartMonth>
        <TimeZone:EndDay xsi:type="xsd:int">0</TimeZone:EndDay>
        <TimeZone:EndMonth xsi:type="xsd:int">0</TimeZone:EndMonth>
       </TimeZone:Value>
      </TimeZone:TimeZoneRuleKeyValuePair>
     </TimeZone:TimeZoneDSTRules>
    </TimeZone:TimeZoneData>
   </TimeZone:Response>
  </TimeZone:InitializeTimeZoneDataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

