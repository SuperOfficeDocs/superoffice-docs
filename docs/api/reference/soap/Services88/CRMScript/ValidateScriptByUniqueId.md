---
title: Services88.CRMScriptAgent.ValidateScriptByUniqueId SOAP
generated: 1
uid: Services88-CRMScript-ValidateScriptByUniqueId
---

# Services88 CRMScript ValidateScriptByUniqueId

SOAP request and response examples **Remote/Services88/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICRMScriptAgent.ValidateScriptByUniqueId">SuperOffice.Services88.ICRMScriptAgent.ValidateScriptByUniqueId</see> method.

## ValidateScriptByUniqueId

Validate a CRMScript. This will check that the syntax is correct
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.

* **cRMScriptUniqueId:** The unique id of the CRMScript to validate

**Returns:** True of the syntax is correct


[WSDL file for Services88/CRMScript](../Services88-CRMScript.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ValidateScriptByUniqueId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CRMScript="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <CRMScript:ApplicationToken>1234567-1234-9876</CRMScript:ApplicationToken>
  <CRMScript:Credentials>
    <CRMScript:Ticket>7T:1234abcxyzExample==</CRMScript:Ticket>
  </CRMScript:Credentials>
 <SOAP-ENV:Body>
   <CRMScript:ValidateScriptByUniqueId>
    <CRMScript:CRMScriptUniqueId xsi:type="xsd:string"></CRMScript:CRMScriptUniqueId>
   </CRMScript:ValidateScriptByUniqueId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ValidateScriptByUniqueId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CRMScript="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <CRMScript:ValidateScriptByUniqueIdResponse>
   <CRMScript:Response xsi:type="CRMScript:CRMScriptResult">
    <CRMScript:Valid xsi:type="xsd:boolean">false</CRMScript:Valid>
    <CRMScript:ErrorMessage xsi:type="xsd:string"></CRMScript:ErrorMessage>
   </CRMScript:Response>
  </CRMScript:ValidateScriptByUniqueIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

