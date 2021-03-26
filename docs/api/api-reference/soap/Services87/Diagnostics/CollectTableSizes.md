---
uid: services87-diagnostics-collecttablesizes
title: Services87.DiagnosticsAgent.CollectTableSizes SOAP
Generated: true
---

# Services87 Diagnostics CollectTableSizes SOAP

SOAP request and response examples **Remote/Services87/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IDiagnosticsAgent.CollectTableSizes">SuperOffice.Services87.IDiagnosticsAgent.CollectTableSizes</see> method.

## CollectTableSizes

Collect and transmit usage statistics: Table Sizes. If opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.


**Returns:** This method has no return value


[WSDL file for Services87/Diagnostics](../Services87-Diagnostics.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CollectTableSizes Request

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
   <Diagnostics:CollectTableSizes>
   </Diagnostics:CollectTableSizes>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CollectTableSizes Response

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
  <Diagnostics:CollectTableSizesResponse>
  </Diagnostics:CollectTableSizesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

