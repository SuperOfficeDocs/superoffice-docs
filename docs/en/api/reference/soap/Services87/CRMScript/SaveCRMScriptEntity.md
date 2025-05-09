---
title: Services87.CRMScriptAgent.SaveCRMScriptEntity SOAP
generated: 1
uid: Services87-CRMScript-SaveCRMScriptEntity
---

# Services87 CRMScript SaveCRMScriptEntity

SOAP request and response examples **Remote/Services87/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ICRMScriptAgent.SaveCRMScriptEntity">SuperOffice.Services87.ICRMScriptAgent.SaveCRMScriptEntity</see> method.

## SaveCRMScriptEntity

[WSDL file for Services87/CRMScript](../Services87-CRMScript.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveCRMScriptEntity Request

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
   <CRMScript:SaveCRMScriptEntity>
    <CRMScript:CRMScriptEntity xsi:type="CRMScript:CRMScriptEntity">
     <CRMScript:EjscriptId xsi:type="xsd:int">0</CRMScript:EjscriptId>
     <CRMScript:UniqueIdentifier xsi:type="xsd:string"></CRMScript:UniqueIdentifier>
     <CRMScript:Name xsi:type="xsd:string"></CRMScript:Name>
     <CRMScript:Description xsi:type="xsd:string"></CRMScript:Description>
     <CRMScript:IncludeId xsi:type="xsd:string"></CRMScript:IncludeId>
     <CRMScript:HierarchyId xsi:type="xsd:int">0</CRMScript:HierarchyId>
     <CRMScript:Source xsi:type="xsd:string"></CRMScript:Source>
     <CRMScript:Registered xsi:type="xsd:dateTime">2023-03-31T13:25:04Z</CRMScript:Registered>
     <CRMScript:RegisteredAssociateId xsi:type="xsd:int">0</CRMScript:RegisteredAssociateId>
     <CRMScript:Updated xsi:type="xsd:dateTime">2023-03-31T13:25:04Z</CRMScript:Updated>
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
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CRMScript="http://www.superoffice.net/ws/crm/NetServer/Services87">
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
    <CRMScript:Registered xsi:type="xsd:dateTime">2023-03-31T13:25:04Z</CRMScript:Registered>
    <CRMScript:RegisteredAssociateId xsi:type="xsd:int">0</CRMScript:RegisteredAssociateId>
    <CRMScript:Updated xsi:type="xsd:dateTime">2023-03-31T13:25:04Z</CRMScript:Updated>
    <CRMScript:UpdatedAssociateId xsi:type="xsd:int">0</CRMScript:UpdatedAssociateId>
   </CRMScript:Response>
  </CRMScript:SaveCRMScriptEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
