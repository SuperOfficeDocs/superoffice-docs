---
uid: services83-diagnostics-resyncusers
title: Services83.DiagnosticsAgent.ResyncUsers SOAP
Generated: true
---

# Services83 Diagnostics ResyncUsers SOAP

SOAP request and response examples **Remote/Services83/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IDiagnosticsAgent.ResyncUsers">SuperOffice.Services83.IDiagnosticsAgent.ResyncUsers</see> method.

## ResyncUsers

Resynchronize user information with SuperOffice Community, if opted-out then this call does nothing. The call returns immediately (starting a background thread), and updates CS scheduler table to set the next run time.


**Returns:** This method has no return value


[WSDL file for Services83/Diagnostics](../Services83-Diagnostics.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ResyncUsers Request

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
   <Diagnostics:ResyncUsers>
   </Diagnostics:ResyncUsers>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ResyncUsers Response

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
  <Diagnostics:ResyncUsersResponse>
  </Diagnostics:ResyncUsersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

