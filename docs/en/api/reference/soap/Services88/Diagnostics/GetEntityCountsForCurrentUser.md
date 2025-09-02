---
title: Services88.DiagnosticsAgent.GetEntityCountsForCurrentUser SOAP
generated: true
uid: Services88-Diagnostics-GetEntityCountsForCurrentUser
content_type: reference
---

# Services88 Diagnostics GetEntityCountsForCurrentUser

SOAP request and response examples **Remote/Services88/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDiagnosticsAgent.GetEntityCountsForCurrentUser">SuperOffice.Services88.IDiagnosticsAgent.GetEntityCountsForCurrentUser</see> method.

## GetEntityCountsForCurrentUser





[WSDL file for Services88/Diagnostics](../Services88-Diagnostics.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetEntityCountsForCurrentUser Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Diagnostics:ApplicationToken>1234567-1234-9876</Diagnostics:ApplicationToken>
  <Diagnostics:Credentials>
    <Diagnostics:Ticket>7T:1234abcxyzExample==</Diagnostics:Ticket>
  </Diagnostics:Credentials>
 <SOAP-ENV:Body>
   <Diagnostics:GetEntityCountsForCurrentUser>
   </Diagnostics:GetEntityCountsForCurrentUser>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetEntityCountsForCurrentUser Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Diagnostics:GetEntityCountsForCurrentUserResponse>
   <Diagnostics:Response xsi:type="Diagnostics:ArrayOfEntityCounts">
    <Diagnostics:EntityCounts xsi:type="Diagnostics:EntityCounts">
     <Diagnostics:EntityName xsi:type="xsd:string"></Diagnostics:EntityName>
     <Diagnostics:Records xsi:type="xsd:int">0</Diagnostics:Records>
    </Diagnostics:EntityCounts>
   </Diagnostics:Response>
  </Diagnostics:GetEntityCountsForCurrentUserResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

