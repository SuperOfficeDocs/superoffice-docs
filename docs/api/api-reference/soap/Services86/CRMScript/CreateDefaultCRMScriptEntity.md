---
uid: services86-crmscript-createdefaultcrmscriptentity
title: Services86.CRMScriptAgent.CreateDefaultCRMScriptEntity SOAP
Generated: true
---

# Services86 CRMScript CreateDefaultCRMScriptEntity SOAP

SOAP request and response examples **Remote/Services86/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ICRMScriptAgent.CreateDefaultCRMScriptEntity">SuperOffice.Services86.ICRMScriptAgent.CreateDefaultCRMScriptEntity</see> method.

## CreateDefaultCRMScriptEntity

Loading default values into a new CRMScriptEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.


**Returns:** New CRMScriptEntity with default values


[WSDL file for Services86/CRMScript](../Services86-CRMScript.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultCRMScriptEntity Request

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
   <CRMScript:CreateDefaultCRMScriptEntity>
   </CRMScript:CreateDefaultCRMScriptEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultCRMScriptEntity Response

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
  <CRMScript:CreateDefaultCRMScriptEntityResponse>
   <CRMScript:Response xsi:type="CRMScript:CRMScriptEntity">
    <CRMScript:EjscriptId xsi:type="xsd:int">0</CRMScript:EjscriptId>
    <CRMScript:UniqueIdentifier xsi:type="xsd:string"></CRMScript:UniqueIdentifier>
    <CRMScript:Name xsi:type="xsd:string"></CRMScript:Name>
    <CRMScript:Description xsi:type="xsd:string"></CRMScript:Description>
    <CRMScript:IncludeId xsi:type="xsd:string"></CRMScript:IncludeId>
    <CRMScript:HierarchyId xsi:type="xsd:int">0</CRMScript:HierarchyId>
    <CRMScript:Source xsi:type="xsd:string"></CRMScript:Source>
    <CRMScript:Registered xsi:type="xsd:dateTime">2021-03-25T21:36:05Z</CRMScript:Registered>
    <CRMScript:RegisteredAssociateId xsi:type="xsd:int">0</CRMScript:RegisteredAssociateId>
    <CRMScript:Updated xsi:type="xsd:dateTime">2021-03-25T21:36:05Z</CRMScript:Updated>
    <CRMScript:UpdatedAssociateId xsi:type="xsd:int">0</CRMScript:UpdatedAssociateId>
   </CRMScript:Response>
  </CRMScript:CreateDefaultCRMScriptEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

