---
title: Services86.CRMScriptAgent.DeleteCRMScriptByUniqueIdentifier SOAP
generated: 1
uid: Services86-CRMScript-DeleteCRMScriptByUniqueIdentifier
---

# Services86 CRMScript DeleteCRMScriptByUniqueIdentifier

SOAP request and response examples **Remote/Services86/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ICRMScriptAgent.DeleteCRMScriptByUniqueIdentifier">SuperOffice.Services86.ICRMScriptAgent.DeleteCRMScriptByUniqueIdentifier</see> method.

## DeleteCRMScriptByUniqueIdentifier

Delete the CRMScript
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.

* **uniqueIdentifier:** Global unique reference to script (independent of installation)

**Returns:** This method has no return value


[WSDL file for Services86/CRMScript](../Services86-CRMScript.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteCRMScriptByUniqueIdentifier Request

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
   <CRMScript:DeleteCRMScriptByUniqueIdentifier>
    <CRMScript:UniqueIdentifier xsi:type="xsd:string"></CRMScript:UniqueIdentifier>
   </CRMScript:DeleteCRMScriptByUniqueIdentifier>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteCRMScriptByUniqueIdentifier Response

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
  <CRMScript:DeleteCRMScriptByUniqueIdentifierResponse>
  </CRMScript:DeleteCRMScriptByUniqueIdentifierResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

