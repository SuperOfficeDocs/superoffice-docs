---
title: Services88.CRMScriptAgent.ExecuteScriptByUniqueId SOAP
generated: 1
uid: Services88-CRMScript-ExecuteScriptByUniqueId
---

# Services88 CRMScript ExecuteScriptByUniqueId

SOAP request and response examples **Remote/Services88/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICRMScriptAgent.ExecuteScriptByUniqueId">SuperOffice.Services88.ICRMScriptAgent.ExecuteScriptByUniqueId</see> method.

## ExecuteScriptByUniqueId

Execute a CRMScript with parameters, returning printed output value.
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.

* **cRMScriptUniqueId:** The unique id of the CRMScript to validate
* **parameters:** Parameters passed as variables to the CRMScript

**Returns:** The output produced by the CRMScript


[WSDL file for Services88/CRMScript](../Services88-CRMScript.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ExecuteScriptByUniqueId Request

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
   <CRMScript:ExecuteScriptByUniqueId>
    <CRMScript:CRMScriptUniqueId xsi:type="xsd:string"></CRMScript:CRMScriptUniqueId>
    <CRMScript:Parameters xsi:type="CRMScript:StringDictionary">
     <CRMScript:StringKeyValuePair>
      <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
      <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
     </CRMScript:StringKeyValuePair>
    </CRMScript:Parameters>
   </CRMScript:ExecuteScriptByUniqueId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ExecuteScriptByUniqueId Response

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
  <CRMScript:ExecuteScriptByUniqueIdResponse>
   <CRMScript:Response xsi:type="xsd:string"></CRMScript:Response>
  </CRMScript:ExecuteScriptByUniqueIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

