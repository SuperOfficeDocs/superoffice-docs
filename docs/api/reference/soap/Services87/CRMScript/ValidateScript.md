---
title: Services87.CRMScriptAgent.ValidateScript SOAP
generated: 1
uid: Services87-CRMScript-ValidateScript
---

# Services87 CRMScript ValidateScript

SOAP request and response examples **Remote/Services87/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ICRMScriptAgent.ValidateScript">SuperOffice.Services87.ICRMScriptAgent.ValidateScript</see> method.

## ValidateScript

Validate a CRMScript. This will check that the syntax is correct
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.

* **cRMScriptId:** The id of the CRMScript to execute

**Returns:** True of the syntax is correct


[WSDL file for Services87/CRMScript](../Services87-CRMScript.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ValidateScript Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CRMScript="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <CRMScript:ApplicationToken>1234567-1234-9876</CRMScript:ApplicationToken>
  <CRMScript:Credentials>
    <CRMScript:Ticket>7T:1234abcxyzExample==</CRMScript:Ticket>
  </CRMScript:Credentials>
 <SOAP-ENV:Body>
   <CRMScript:ValidateScript>
    <CRMScript:CRMScriptId xsi:type="xsd:int">0</CRMScript:CRMScriptId>
   </CRMScript:ValidateScript>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ValidateScript Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CRMScript="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <CRMScript:ValidateScriptResponse>
   <CRMScript:Response xsi:type="CRMScript:CRMScriptResult">
    <CRMScript:Valid xsi:type="xsd:boolean">false</CRMScript:Valid>
    <CRMScript:ErrorMessage xsi:type="xsd:string"></CRMScript:ErrorMessage>
   </CRMScript:Response>
  </CRMScript:ValidateScriptResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

