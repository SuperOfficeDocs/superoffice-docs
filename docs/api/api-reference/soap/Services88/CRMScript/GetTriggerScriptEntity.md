---
title: Services88.CRMScriptAgent.GetTriggerScriptEntity SOAP
generated: 1
uid: Services88-CRMScript-GetTriggerScriptEntity
---

# Services88 CRMScript GetTriggerScriptEntity

SOAP request and response examples **Remote/Services88/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICRMScriptAgent.GetTriggerScriptEntity">SuperOffice.Services88.ICRMScriptAgent.GetTriggerScriptEntity</see> method.

## GetTriggerScriptEntity

Gets a TriggerScriptEntity object.
<para /><b>Online Restricted:</b> The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.

* **triggerScriptEntityId:** The identifier of the TriggerScriptEntity object

**Returns:** TriggerScriptEntity


[WSDL file for Services88/CRMScript](../Services88-CRMScript.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTriggerScriptEntity Request

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
   <CRMScript:GetTriggerScriptEntity>
    <CRMScript:TriggerScriptEntityId xsi:type="xsd:int">0</CRMScript:TriggerScriptEntityId>
   </CRMScript:GetTriggerScriptEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTriggerScriptEntity Response

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
  <CRMScript:GetTriggerScriptEntityResponse>
   <CRMScript:Response xsi:type="CRMScript:TriggerScriptEntity">
    <CRMScript:ScreenChooserId xsi:type="xsd:int">0</CRMScript:ScreenChooserId>
    <CRMScript:Name xsi:type="xsd:string"></CRMScript:Name>
    <CRMScript:ScreenType xsi:type="CRMScript:EventHandlerType">Unknown</CRMScript:ScreenType>
    <CRMScript:Enabled xsi:type="xsd:boolean">false</CRMScript:Enabled>
    <CRMScript:UniqueIdentifier xsi:type="xsd:string"></CRMScript:UniqueIdentifier>
    <CRMScript:Source xsi:type="xsd:string"></CRMScript:Source>
    <CRMScript:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</CRMScript:Registered>
    <CRMScript:RegisteredAssociateId xsi:type="xsd:int">0</CRMScript:RegisteredAssociateId>
    <CRMScript:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</CRMScript:Updated>
    <CRMScript:UpdatedAssociateId xsi:type="xsd:int">0</CRMScript:UpdatedAssociateId>
   </CRMScript:Response>
  </CRMScript:GetTriggerScriptEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

