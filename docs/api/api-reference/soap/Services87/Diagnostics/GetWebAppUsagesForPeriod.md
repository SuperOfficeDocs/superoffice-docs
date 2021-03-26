---
uid: services87-diagnostics-getwebappusagesforperiod
title: Services87.DiagnosticsAgent.GetWebAppUsagesForPeriod SOAP
Generated: true
---

# Services87 Diagnostics GetWebAppUsagesForPeriod SOAP

SOAP request and response examples **Remote/Services87/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IDiagnosticsAgent.GetWebAppUsagesForPeriod">SuperOffice.Services87.IDiagnosticsAgent.GetWebAppUsagesForPeriod</see> method.

## GetWebAppUsagesForPeriod

Get all WebAppUsages for a given period, that match an optional search term

* **fromDate:** 
* **toDate:** 
* **searchTerm:** ViewState search term. '%' is the wildcard character, for example 'Pocket%' will match all viewstates starting with 'Pocket'. If empty, all viewstates will be matched



[WSDL file for Services87/Diagnostics](../Services87-Diagnostics.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetWebAppUsagesForPeriod Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Diagnostics:ApplicationToken>1234567-1234-9876</Diagnostics:ApplicationToken>
  <Diagnostics:Credentials>
    <Diagnostics:Ticket>7T:1234abcxyzExample==</Diagnostics:Ticket>
  </Diagnostics:Credentials>
 <SOAP-ENV:Body>
   <Diagnostics:GetWebAppUsagesForPeriod>
    <Diagnostics:FromDate xsi:type="xsd:dateTime">2021-03-25T21:36:31Z</Diagnostics:FromDate>
    <Diagnostics:ToDate xsi:type="xsd:dateTime">2021-03-25T21:36:31Z</Diagnostics:ToDate>
    <Diagnostics:SearchTerm xsi:type="xsd:string"></Diagnostics:SearchTerm>
   </Diagnostics:GetWebAppUsagesForPeriod>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetWebAppUsagesForPeriod Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Diagnostics:GetWebAppUsagesForPeriodResponse>
   <Diagnostics:Response xsi:type="Diagnostics:ArrayOfWebAppUsage">
    <Diagnostics:WebAppUsage xsi:type="Diagnostics:WebAppUsage">
     <Diagnostics:WebAppUsageId xsi:type="xsd:int">0</Diagnostics:WebAppUsageId>
     <Diagnostics:AssocId xsi:type="xsd:int">0</Diagnostics:AssocId>
     <Diagnostics:Timestamp xsi:type="xsd:dateTime">2021-03-25T21:36:31Z</Diagnostics:Timestamp>
     <Diagnostics:ViewState xsi:type="xsd:string"></Diagnostics:ViewState>
     <Diagnostics:AggregateCount xsi:type="xsd:unsignedInt">0</Diagnostics:AggregateCount>
     <Diagnostics:AggregateBin xsi:type="xsd:unsignedInt">0</Diagnostics:AggregateBin>
     <Diagnostics:Version xsi:type="xsd:unsignedInt">0</Diagnostics:Version>
    </Diagnostics:WebAppUsage>
   </Diagnostics:Response>
  </Diagnostics:GetWebAppUsagesForPeriodResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

