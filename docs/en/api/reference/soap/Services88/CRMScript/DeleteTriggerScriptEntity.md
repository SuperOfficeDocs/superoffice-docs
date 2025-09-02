---
title: Services88.CRMScriptAgent.DeleteTriggerScriptEntity SOAP
generated: true
uid: Services88-CRMScript-DeleteTriggerScriptEntity
content_type: reference
---

# Services88 CRMScript DeleteTriggerScriptEntity

SOAP request and response examples **Remote/Services88/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICRMScriptAgent.DeleteTriggerScriptEntity">SuperOffice.Services88.ICRMScriptAgent.DeleteTriggerScriptEntity</see> method.

## DeleteTriggerScriptEntity





[WSDL file for Services88/CRMScript](../Services88-CRMScript.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteTriggerScriptEntity Request

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
   <CRMScript:DeleteTriggerScriptEntity>
    <CRMScript:TriggerScriptEntityId xsi:type="xsd:int">0</CRMScript:TriggerScriptEntityId>
   </CRMScript:DeleteTriggerScriptEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteTriggerScriptEntity Response

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
  <CRMScript:DeleteTriggerScriptEntityResponse>
  </CRMScript:DeleteTriggerScriptEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

