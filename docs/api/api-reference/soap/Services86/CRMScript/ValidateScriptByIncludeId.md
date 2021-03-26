---
uid: services86-crmscript-validatescriptbyincludeid
title: Services86.CRMScriptAgent.ValidateScriptByIncludeId SOAP
Generated: true
---

# Services86 CRMScript ValidateScriptByIncludeId SOAP

SOAP request and response examples **Remote/Services86/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ICRMScriptAgent.ValidateScriptByIncludeId">SuperOffice.Services86.ICRMScriptAgent.ValidateScriptByIncludeId</see> method.

## ValidateScriptByIncludeId

Validate a CRMScript. This will check that the syntax is correct
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.

* **cRMScriptIncludeId:** The include id of the CRMScript to validate

**Returns:** True of the syntax is correct


[WSDL file for Services86/CRMScript](../Services86-CRMScript.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ValidateScriptByIncludeId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CRMScript="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <CRMScript:ApplicationToken>1234567-1234-9876</CRMScript:ApplicationToken>
  <CRMScript:Credentials>
    <CRMScript:Ticket>7T:1234abcxyzExample==</CRMScript:Ticket>
  </CRMScript:Credentials>
 <SOAP-ENV:Body>
   <CRMScript:ValidateScriptByIncludeId>
    <CRMScript:CRMScriptIncludeId xsi:type="xsd:string"></CRMScript:CRMScriptIncludeId>
   </CRMScript:ValidateScriptByIncludeId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ValidateScriptByIncludeId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CRMScript="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <CRMScript:ValidateScriptByIncludeIdResponse>
   <CRMScript:Response xsi:type="CRMScript:CRMScriptResult">
    <CRMScript:Valid xsi:type="xsd:boolean">false</CRMScript:Valid>
    <CRMScript:ErrorMessage xsi:type="xsd:string"></CRMScript:ErrorMessage>
   </CRMScript:Response>
  </CRMScript:ValidateScriptByIncludeIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

