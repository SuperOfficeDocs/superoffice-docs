---
uid: services87-diagnostics-logviewstate
title: Services87.DiagnosticsAgent.LogViewState SOAP
Generated: true
---

# Services87 Diagnostics LogViewState SOAP

SOAP request and response examples **Remote/Services87/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IDiagnosticsAgent.LogViewState">SuperOffice.Services87.IDiagnosticsAgent.LogViewState</see> method.

## LogViewState

Log a change in view state. The granularity of the logging depends on the current configuration. This call returns asynchronously, leaving the server to finish processing later on.

* **viewState:** Current view state to be logged



[WSDL file for Services87/Diagnostics](../Services87-Diagnostics.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## LogViewState Request

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
   <Diagnostics:LogViewState>
    <Diagnostics:ViewState xsi:type="xsd:string"></Diagnostics:ViewState>
   </Diagnostics:LogViewState>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## LogViewState Response

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
  <Diagnostics:LogViewStateResponse>
  </Diagnostics:LogViewStateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

