---
uid: services86-crmscript-executescript
title: Services86.CRMScriptAgent.ExecuteScript SOAP
Generated: true
---

# Services86 CRMScript ExecuteScript SOAP

SOAP request and response examples **Remote/Services86/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ICRMScriptAgent.ExecuteScript">SuperOffice.Services86.ICRMScriptAgent.ExecuteScript</see> method.

## ExecuteScript

Execute a CRMScript with parameters
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.

* **cRMScriptId:** The id of the CRMScript to execute
* **parameters:** Parameters passed as variables to the CRMScript

**Returns:** The output produced by the CRMScript


[WSDL file for Services86/CRMScript](../Services86-CRMScript.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ExecuteScript Request

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
   <CRMScript:ExecuteScript>
    <CRMScript:CRMScriptId xsi:type="xsd:int">0</CRMScript:CRMScriptId>
    <CRMScript:Parameters xsi:type="CRMScript:StringDictionary">
     <CRMScript:StringKeyValuePair>
      <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
      <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
     </CRMScript:StringKeyValuePair>
    </CRMScript:Parameters>
   </CRMScript:ExecuteScript>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ExecuteScript Response

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
  <CRMScript:ExecuteScriptResponse>
   <CRMScript:Response xsi:type="xsd:string"></CRMScript:Response>
  </CRMScript:ExecuteScriptResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

