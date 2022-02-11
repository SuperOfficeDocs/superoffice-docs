---
title: Services88.CRMScriptAgent.SaveCRMScriptEntity SOAP
generated: 1
uid: Services88-CRMScript-SaveCRMScriptEntity
---

# Services88 CRMScript SaveCRMScriptEntity

SOAP request and response examples **Remote/Services88/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICRMScriptAgent.SaveCRMScriptEntity">SuperOffice.Services88.ICRMScriptAgent.SaveCRMScriptEntity</see> method.

## SaveCRMScriptEntity

Updates the existing CRMScriptEntity or creates a new CRMScriptEntity if the id parameter is 0.
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.

* **cRMScriptEntity:** The CRMScriptEntity that is saved.

**Returns:** New or updated CRMScriptEntity


[WSDL file for Services88/CRMScript](../Services88-CRMScript.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveCRMScriptEntity Request

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
   <CRMScript:SaveCRMScriptEntity>
    <CRMScript:CRMScriptEntity xsi:type="CRMScript:CRMScriptEntity">
     <CRMScript:EjscriptId xsi:type="xsd:int">0</CRMScript:EjscriptId>
     <CRMScript:UniqueIdentifier xsi:type="xsd:string"></CRMScript:UniqueIdentifier>
     <CRMScript:Name xsi:type="xsd:string"></CRMScript:Name>
     <CRMScript:Description xsi:type="xsd:string"></CRMScript:Description>
     <CRMScript:IncludeId xsi:type="xsd:string"></CRMScript:IncludeId>
     <CRMScript:HierarchyId xsi:type="xsd:int">0</CRMScript:HierarchyId>
     <CRMScript:Source xsi:type="xsd:string"></CRMScript:Source>
     <CRMScript:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</CRMScript:Registered>
     <CRMScript:RegisteredAssociateId xsi:type="xsd:int">0</CRMScript:RegisteredAssociateId>
     <CRMScript:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</CRMScript:Updated>
     <CRMScript:UpdatedAssociateId xsi:type="xsd:int">0</CRMScript:UpdatedAssociateId>
    </CRMScript:CRMScriptEntity>
   </CRMScript:SaveCRMScriptEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveCRMScriptEntity Response

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
  <CRMScript:SaveCRMScriptEntityResponse>
   <CRMScript:Response xsi:type="CRMScript:CRMScriptEntity">
    <CRMScript:EjscriptId xsi:type="xsd:int">0</CRMScript:EjscriptId>
    <CRMScript:UniqueIdentifier xsi:type="xsd:string"></CRMScript:UniqueIdentifier>
    <CRMScript:Name xsi:type="xsd:string"></CRMScript:Name>
    <CRMScript:Description xsi:type="xsd:string"></CRMScript:Description>
    <CRMScript:IncludeId xsi:type="xsd:string"></CRMScript:IncludeId>
    <CRMScript:HierarchyId xsi:type="xsd:int">0</CRMScript:HierarchyId>
    <CRMScript:Source xsi:type="xsd:string"></CRMScript:Source>
    <CRMScript:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</CRMScript:Registered>
    <CRMScript:RegisteredAssociateId xsi:type="xsd:int">0</CRMScript:RegisteredAssociateId>
    <CRMScript:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</CRMScript:Updated>
    <CRMScript:UpdatedAssociateId xsi:type="xsd:int">0</CRMScript:UpdatedAssociateId>
   </CRMScript:Response>
  </CRMScript:SaveCRMScriptEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

