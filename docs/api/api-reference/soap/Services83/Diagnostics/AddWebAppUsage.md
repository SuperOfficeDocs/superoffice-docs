---
uid: services83-diagnostics-addwebappusage
title: Services83.DiagnosticsAgent.AddWebAppUsage SOAP
Generated: true
---

# Services83 Diagnostics AddWebAppUsage SOAP

SOAP request and response examples **Remote/Services83/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IDiagnosticsAgent.AddWebAppUsage">SuperOffice.Services83.IDiagnosticsAgent.AddWebAppUsage</see> method.

## AddWebAppUsage

Adds WebApp usage to existing log

* **webAppUsages:** Web app usage.



[WSDL file for Services83/Diagnostics](../Services83-Diagnostics.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddWebAppUsage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Diagnostics:ApplicationToken>1234567-1234-9876</Diagnostics:ApplicationToken>
  <Diagnostics:Credentials>
    <Diagnostics:Ticket>7T:1234abcxyzExample==</Diagnostics:Ticket>
  </Diagnostics:Credentials>
 <SOAP-ENV:Body>
   <Diagnostics:AddWebAppUsage>
    <Diagnostics:WebAppUsages xsi:type="Diagnostics:ArrayOfWebAppUsage">
     <Diagnostics:WebAppUsage xsi:type="Diagnostics:WebAppUsage">
      <Diagnostics:WebAppUsageId xsi:type="xsd:int">0</Diagnostics:WebAppUsageId>
      <Diagnostics:AssocId xsi:type="xsd:int">0</Diagnostics:AssocId>
      <Diagnostics:Timestamp xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Diagnostics:Timestamp>
      <Diagnostics:ViewState xsi:type="xsd:string"></Diagnostics:ViewState>
      <Diagnostics:AggregateCount xsi:type="xsd:unsignedInt">0</Diagnostics:AggregateCount>
      <Diagnostics:AggregateBin xsi:type="xsd:unsignedInt">0</Diagnostics:AggregateBin>
      <Diagnostics:Version xsi:type="xsd:unsignedInt">0</Diagnostics:Version>
     </Diagnostics:WebAppUsage>
    </Diagnostics:WebAppUsages>
   </Diagnostics:AddWebAppUsage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddWebAppUsage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Diagnostics:AddWebAppUsageResponse>
  </Diagnostics:AddWebAppUsageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

