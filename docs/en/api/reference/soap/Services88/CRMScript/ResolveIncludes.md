---
title: Services88.CRMScriptAgent.ResolveIncludes SOAP
generated: true
uid: Services88-CRMScript-ResolveIncludes
content_type: reference
---

# Services88 CRMScript ResolveIncludes

SOAP request and response examples **Remote/Services88/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICRMScriptAgent.ResolveIncludes">SuperOffice.Services88.ICRMScriptAgent.ResolveIncludes</see> method.

## ResolveIncludes





[WSDL file for Services88/CRMScript](../Services88-CRMScript.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ResolveIncludes Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CRMScript="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <CRMScript:ApplicationToken>1234567-1234-9876</CRMScript:ApplicationToken>
  <CRMScript:Credentials>
    <CRMScript:Ticket>7T:1234abcxyzExample==</CRMScript:Ticket>
  </CRMScript:Credentials>
 <SOAP-ENV:Body>
   <CRMScript:ResolveIncludes>
    <CRMScript:Script xsi:type="xsd:string"></CRMScript:Script>
    <CRMScript:IgnoreErrors xsi:type="xsd:boolean">false</CRMScript:IgnoreErrors>
   </CRMScript:ResolveIncludes>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ResolveIncludes Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CRMScript="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <CRMScript:ResolveIncludesResponse>
   <CRMScript:Response xsi:type="NetServerServices882:ArrayOfint">
    <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
   </CRMScript:Response>
  </CRMScript:ResolveIncludesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

