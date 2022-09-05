---
title: Services86.CRMScriptAgent.SaveCRMScriptByUniqueIdentifier SOAP
generated: 1
uid: Services86-CRMScript-SaveCRMScriptByUniqueIdentifier
---

# Services86 CRMScript SaveCRMScriptByUniqueIdentifier

SOAP request and response examples **Remote/Services86/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ICRMScriptAgent.SaveCRMScriptByUniqueIdentifier">SuperOffice.Services86.ICRMScriptAgent.SaveCRMScriptByUniqueIdentifier</see> method.

## SaveCRMScriptByUniqueIdentifier

Create or Update the CRMScript information
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.

* **uniqueIdentifier:** Global unique reference to script (independent of installation)
* **crmscript:** Information about the CRMScript

**Returns:** Information about the CRMScript as saved in the database


[WSDL file for Services86/CRMScript](../Services86-CRMScript.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveCRMScriptByUniqueIdentifier Request

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
   <CRMScript:SaveCRMScriptByUniqueIdentifier>
    <CRMScript:UniqueIdentifier xsi:type="xsd:string"></CRMScript:UniqueIdentifier>
    <CRMScript:Crmscript xsi:type="CRMScript:Script">
     <CRMScript:UniqueIdentifier xsi:type="xsd:string"></CRMScript:UniqueIdentifier>
     <CRMScript:Name xsi:type="xsd:string"></CRMScript:Name>
     <CRMScript:Description xsi:type="xsd:string"></CRMScript:Description>
     <CRMScript:IncludeId xsi:type="xsd:string"></CRMScript:IncludeId>
     <CRMScript:Source xsi:type="xsd:string"></CRMScript:Source>
     <CRMScript:Registered xsi:type="xsd:dateTime">2022-08-26T08:54:35Z</CRMScript:Registered>
     <CRMScript:RegisteredBy xsi:type="xsd:string"></CRMScript:RegisteredBy>
     <CRMScript:Updated xsi:type="xsd:dateTime">2022-08-26T08:54:35Z</CRMScript:Updated>
     <CRMScript:UpdatedBy xsi:type="xsd:string"></CRMScript:UpdatedBy>
     <CRMScript:Path xsi:type="xsd:string"></CRMScript:Path>
    </CRMScript:Crmscript>
   </CRMScript:SaveCRMScriptByUniqueIdentifier>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveCRMScriptByUniqueIdentifier Response

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
  <CRMScript:SaveCRMScriptByUniqueIdentifierResponse>
   <CRMScript:Response xsi:type="CRMScript:Script">
    <CRMScript:UniqueIdentifier xsi:type="xsd:string"></CRMScript:UniqueIdentifier>
    <CRMScript:Name xsi:type="xsd:string"></CRMScript:Name>
    <CRMScript:Description xsi:type="xsd:string"></CRMScript:Description>
    <CRMScript:IncludeId xsi:type="xsd:string"></CRMScript:IncludeId>
    <CRMScript:Source xsi:type="xsd:string"></CRMScript:Source>
    <CRMScript:Registered xsi:type="xsd:dateTime">2022-08-26T08:54:35Z</CRMScript:Registered>
    <CRMScript:RegisteredBy xsi:type="xsd:string"></CRMScript:RegisteredBy>
    <CRMScript:Updated xsi:type="xsd:dateTime">2022-08-26T08:54:35Z</CRMScript:Updated>
    <CRMScript:UpdatedBy xsi:type="xsd:string"></CRMScript:UpdatedBy>
    <CRMScript:Path xsi:type="xsd:string"></CRMScript:Path>
   </CRMScript:Response>
  </CRMScript:SaveCRMScriptByUniqueIdentifierResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

