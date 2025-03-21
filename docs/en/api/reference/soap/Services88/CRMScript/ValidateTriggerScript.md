---
title: Services88.CRMScriptAgent.ValidateTriggerScript SOAP
generated: true
uid: Services88-CRMScript-ValidateTriggerScript
---

# Services88 CRMScript ValidateTriggerScript

SOAP request and response examples **Remote/Services88/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICRMScriptAgent.ValidateTriggerScript">SuperOffice.Services88.ICRMScriptAgent.ValidateTriggerScript</see> method.

## ValidateTriggerScript





[WSDL file for Services88/CRMScript](../Services88-CRMScript.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ValidateTriggerScript Request

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
   <CRMScript:ValidateTriggerScript>
    <CRMScript:TriggerScriptId xsi:type="xsd:int">0</CRMScript:TriggerScriptId>
   </CRMScript:ValidateTriggerScript>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ValidateTriggerScript Response

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
  <CRMScript:ValidateTriggerScriptResponse>
   <CRMScript:Response xsi:type="CRMScript:CRMScriptResult">
    <CRMScript:Valid xsi:type="xsd:boolean">false</CRMScript:Valid>
    <CRMScript:ErrorMessage xsi:type="xsd:string"></CRMScript:ErrorMessage>
    <CRMScript:LineNumber xsi:type="xsd:int">0</CRMScript:LineNumber>
    <CRMScript:ErrorInformation xsi:type="CRMScript:CRMScriptErrorInfo">
     <CRMScript:ErrorMessage xsi:type="xsd:string"></CRMScript:ErrorMessage>
     <CRMScript:IncludeId xsi:type="xsd:string"></CRMScript:IncludeId>
     <CRMScript:LineNumber xsi:type="xsd:int">0</CRMScript:LineNumber>
     <CRMScript:CharacterPosition xsi:type="xsd:int">0</CRMScript:CharacterPosition>
    </CRMScript:ErrorInformation>
    <CRMScript:Transpiled xsi:type="xsd:string"></CRMScript:Transpiled>
    <CRMScript:Includes xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </CRMScript:Includes>
    <CRMScript:SourceMaps xsi:type="CRMScript:ArrayOfCRMScriptSourceMap">
     <CRMScript:CRMScriptSourceMap xsi:type="CRMScript:CRMScriptSourceMap">
      <CRMScript:LineNumberFrom xsi:type="xsd:int">0</CRMScript:LineNumberFrom>
      <CRMScript:LineNumberTo xsi:type="xsd:int">0</CRMScript:LineNumberTo>
      <CRMScript:Delta xsi:type="xsd:int">0</CRMScript:Delta>
      <CRMScript:IncludeId xsi:type="xsd:string"></CRMScript:IncludeId>
      <CRMScript:IncludedFrom xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </CRMScript:IncludedFrom>
     </CRMScript:CRMScriptSourceMap>
    </CRMScript:SourceMaps>
   </CRMScript:Response>
  </CRMScript:ValidateTriggerScriptResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

