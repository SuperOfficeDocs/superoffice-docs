---
title: Services87.CRMScriptAgent.DeleteCRMScriptEntity SOAP
generated: 1
uid: Services87-CRMScript-DeleteCRMScriptEntity
---

# Services87 CRMScript DeleteCRMScriptEntity

SOAP request and response examples **Remote/Services87/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ICRMScriptAgent.DeleteCRMScriptEntity">SuperOffice.Services87.ICRMScriptAgent.DeleteCRMScriptEntity</see> method.

## DeleteCRMScriptEntity

Deletes the CRMScriptEntity
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.

* **cRMScriptEntityId:** The identity of the CRMScriptEntity



[WSDL file for Services87/CRMScript](../Services87-CRMScript.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteCRMScriptEntity Request

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
   <CRMScript:DeleteCRMScriptEntity>
    <CRMScript:CRMScriptEntityId xsi:type="xsd:int">0</CRMScript:CRMScriptEntityId>
   </CRMScript:DeleteCRMScriptEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteCRMScriptEntity Response

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
  <CRMScript:DeleteCRMScriptEntityResponse>
  </CRMScript:DeleteCRMScriptEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

