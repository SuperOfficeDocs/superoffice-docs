---
title: Services87.DiagnosticsAgent.WebAppUsageExistsInPeriod SOAP
generated: 1
uid: Services87-Diagnostics-WebAppUsageExistsInPeriod
---

# Services87 Diagnostics WebAppUsageExistsInPeriod

SOAP request and response examples **Remote/Services87/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IDiagnosticsAgent.WebAppUsageExistsInPeriod">SuperOffice.Services87.IDiagnosticsAgent.WebAppUsageExistsInPeriod</see> method.

## WebAppUsageExistsInPeriod

Returns true if viewState has been clicked at least once since FromDate, if asscoiateId &lt; 0 or FromDate is DateTime.MinValue no restriction given for those parameters

* **associateId:** The asscoiate id to look for webapp usage
* **viewState:** The viewState to search for
* **fromDate:** The datetime to restrict webapp usage on

**Returns:** Returns true if viewState has been clicked at least once since FromDate


[WSDL file for Services87/Diagnostics](../Services87-Diagnostics.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## WebAppUsageExistsInPeriod Request

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
   <Diagnostics:WebAppUsageExistsInPeriod>
    <Diagnostics:AssociateId xsi:type="xsd:int">0</Diagnostics:AssociateId>
    <Diagnostics:ViewState xsi:type="xsd:string"></Diagnostics:ViewState>
    <Diagnostics:FromDate xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Diagnostics:FromDate>
   </Diagnostics:WebAppUsageExistsInPeriod>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## WebAppUsageExistsInPeriod Response

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
  <Diagnostics:WebAppUsageExistsInPeriodResponse>
   <Diagnostics:Response xsi:type="xsd:boolean">false</Diagnostics:Response>
  </Diagnostics:WebAppUsageExistsInPeriodResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

