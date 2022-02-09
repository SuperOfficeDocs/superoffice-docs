---
title: Services87.CRMScriptAgent.GetCRMScriptByUniqueIdentifier SOAP
generated: 1
uid: Services87-CRMScript-GetCRMScriptByUniqueIdentifier
---

# Services87 CRMScript GetCRMScriptByUniqueIdentifier

SOAP request and response examples **Remote/Services87/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ICRMScriptAgent.GetCRMScriptByUniqueIdentifier">SuperOffice.Services87.ICRMScriptAgent.GetCRMScriptByUniqueIdentifier</see> method.

## GetCRMScriptByUniqueIdentifier

Get information about a script from a unique identifier
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.

* **uniqueIdentifier:** Global unique reference to script (independent of installation)

**Returns:** Information about CRMScript


[WSDL file for Services87/CRMScript](../Services87-CRMScript.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCRMScriptByUniqueIdentifier Request

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
   <CRMScript:GetCRMScriptByUniqueIdentifier>
    <CRMScript:UniqueIdentifier xsi:type="xsd:string"></CRMScript:UniqueIdentifier>
   </CRMScript:GetCRMScriptByUniqueIdentifier>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCRMScriptByUniqueIdentifier Response

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
  <CRMScript:GetCRMScriptByUniqueIdentifierResponse>
   <CRMScript:Response xsi:type="CRMScript:Script">
    <CRMScript:UniqueIdentifier xsi:type="xsd:string"></CRMScript:UniqueIdentifier>
    <CRMScript:Name xsi:type="xsd:string"></CRMScript:Name>
    <CRMScript:Description xsi:type="xsd:string"></CRMScript:Description>
    <CRMScript:IncludeId xsi:type="xsd:string"></CRMScript:IncludeId>
    <CRMScript:Source xsi:type="xsd:string"></CRMScript:Source>
    <CRMScript:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:12Z</CRMScript:Registered>
    <CRMScript:RegisteredBy xsi:type="xsd:string"></CRMScript:RegisteredBy>
    <CRMScript:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:12Z</CRMScript:Updated>
    <CRMScript:UpdatedBy xsi:type="xsd:string"></CRMScript:UpdatedBy>
    <CRMScript:Path xsi:type="xsd:string"></CRMScript:Path>
   </CRMScript:Response>
  </CRMScript:GetCRMScriptByUniqueIdentifierResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

