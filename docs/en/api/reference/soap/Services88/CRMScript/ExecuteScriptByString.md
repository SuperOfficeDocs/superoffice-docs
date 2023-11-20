---
title: Services88.CRMScriptAgent.ExecuteScriptByString SOAP
generated: true
uid: Services88-CRMScript-ExecuteScriptByString
---

# Services88 CRMScript ExecuteScriptByString

SOAP request and response examples **Remote/Services88/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICRMScriptAgent.ExecuteScriptByString">SuperOffice.Services88.ICRMScriptAgent.ExecuteScriptByString</see> method.

## ExecuteScriptByString





[WSDL file for Services88/CRMScript](../Services88-CRMScript.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ExecuteScriptByString Request

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
   <CRMScript:ExecuteScriptByString>
    <CRMScript:Script xsi:type="xsd:string"></CRMScript:Script>
    <CRMScript:Parameters xsi:type="CRMScript:StringDictionary">
     <CRMScript:StringKeyValuePair>
      <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
      <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
     </CRMScript:StringKeyValuePair>
    </CRMScript:Parameters>
    <CRMScript:EventData xsi:type="CRMScript:EventData">
     <CRMScript:Type xsi:type="CRMScript:EventHandlerType">Unknown</CRMScript:Type>
     <CRMScript:InputValues xsi:type="CRMScript:StringDictionary">
      <CRMScript:StringKeyValuePair>
       <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
       <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
      </CRMScript:StringKeyValuePair>
     </CRMScript:InputValues>
     <CRMScript:BlockExecution xsi:type="xsd:boolean">false</CRMScript:BlockExecution>
     <CRMScript:NavigateTo xsi:type="xsd:string"></CRMScript:NavigateTo>
     <CRMScript:Message xsi:type="xsd:string"></CRMScript:Message>
     <CRMScript:ShowDialog xsi:type="xsd:string"></CRMScript:ShowDialog>
     <CRMScript:OutputValues xsi:type="CRMScript:StringDictionary">
      <CRMScript:StringKeyValuePair>
       <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
       <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
      </CRMScript:StringKeyValuePair>
     </CRMScript:OutputValues>
     <CRMScript:StateValues xsi:type="CRMScript:StringDictionary">
      <CRMScript:StringKeyValuePair>
       <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
       <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
      </CRMScript:StringKeyValuePair>
     </CRMScript:StateValues>
     <CRMScript:Exception xsi:type="xsd:string"></CRMScript:Exception>
     <CRMScript:ParserValues xsi:type="CRMScript:StringDictionary">
      <CRMScript:StringKeyValuePair>
       <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
       <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
      </CRMScript:StringKeyValuePair>
     </CRMScript:ParserValues>
     <CRMScript:CgiVariables xsi:type="CRMScript:StringDictionary">
      <CRMScript:StringKeyValuePair>
       <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
       <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
      </CRMScript:StringKeyValuePair>
     </CRMScript:CgiVariables>
     <CRMScript:CgiContent xsi:type="xsd:string"></CRMScript:CgiContent>
    </CRMScript:EventData>
   </CRMScript:ExecuteScriptByString>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ExecuteScriptByString Response

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
  <CRMScript:ExecuteScriptByStringResponse>
   <CRMScript:Response xsi:type="CRMScript:CRMScriptRunResult">
    <CRMScript:Output xsi:type="xsd:string"></CRMScript:Output>
    <CRMScript:Parameters xsi:type="CRMScript:StringDictionary">
     <CRMScript:StringKeyValuePair>
      <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
      <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
     </CRMScript:StringKeyValuePair>
    </CRMScript:Parameters>
    <CRMScript:TraceRun xsi:type="CRMScript:CRMScriptTraceRun">
     <CRMScript:StartedAt xsi:type="xsd:dateTime">2023-11-10T12:36:15Z</CRMScript:StartedAt>
     <CRMScript:EndedAt xsi:type="xsd:dateTime">2023-11-10T12:36:15Z</CRMScript:EndedAt>
     <CRMScript:ExecutionTime xsi:type="xsd:int">0</CRMScript:ExecutionTime>
     <CRMScript:UserExecutionTime xsi:type="xsd:int">0</CRMScript:UserExecutionTime>
     <CRMScript:PeakMemory xsi:type="xsd:int">0</CRMScript:PeakMemory>
     <CRMScript:NumFrames xsi:type="xsd:int">0</CRMScript:NumFrames>
     <CRMScript:FileSize xsi:type="xsd:int">0</CRMScript:FileSize>
     <CRMScript:AssociateId xsi:type="xsd:int">0</CRMScript:AssociateId>
     <CRMScript:Status xsi:type="xsd:string"></CRMScript:Status>
     <CRMScript:Frames xsi:type="xsd:string"></CRMScript:Frames>
    </CRMScript:TraceRun>
    <CRMScript:Eventdata xsi:type="CRMScript:EventData">
     <CRMScript:Type xsi:type="CRMScript:EventHandlerType">Unknown</CRMScript:Type>
     <CRMScript:InputValues xsi:type="CRMScript:StringDictionary">
      <CRMScript:StringKeyValuePair>
       <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
       <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
      </CRMScript:StringKeyValuePair>
     </CRMScript:InputValues>
     <CRMScript:BlockExecution xsi:type="xsd:boolean">false</CRMScript:BlockExecution>
     <CRMScript:NavigateTo xsi:type="xsd:string"></CRMScript:NavigateTo>
     <CRMScript:Message xsi:type="xsd:string"></CRMScript:Message>
     <CRMScript:ShowDialog xsi:type="xsd:string"></CRMScript:ShowDialog>
     <CRMScript:OutputValues xsi:type="CRMScript:StringDictionary">
      <CRMScript:StringKeyValuePair>
       <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
       <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
      </CRMScript:StringKeyValuePair>
     </CRMScript:OutputValues>
     <CRMScript:StateValues xsi:type="CRMScript:StringDictionary">
      <CRMScript:StringKeyValuePair>
       <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
       <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
      </CRMScript:StringKeyValuePair>
     </CRMScript:StateValues>
     <CRMScript:Exception xsi:type="xsd:string"></CRMScript:Exception>
     <CRMScript:ParserValues xsi:type="CRMScript:StringDictionary">
      <CRMScript:StringKeyValuePair>
       <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
       <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
      </CRMScript:StringKeyValuePair>
     </CRMScript:ParserValues>
     <CRMScript:CgiVariables xsi:type="CRMScript:StringDictionary">
      <CRMScript:StringKeyValuePair>
       <CRMScript:Key xsi:type="xsd:string"></CRMScript:Key>
       <CRMScript:Value xsi:type="xsd:string"></CRMScript:Value>
      </CRMScript:StringKeyValuePair>
     </CRMScript:CgiVariables>
     <CRMScript:CgiContent xsi:type="xsd:string"></CRMScript:CgiContent>
    </CRMScript:Eventdata>
    <CRMScript:Success xsi:type="xsd:boolean">false</CRMScript:Success>
    <CRMScript:ErrorInformation xsi:type="CRMScript:CRMScriptErrorInfo">
     <CRMScript:ErrorMessage xsi:type="xsd:string"></CRMScript:ErrorMessage>
     <CRMScript:ErrorLine xsi:type="xsd:int">0</CRMScript:ErrorLine>
     <CRMScript:ErrorCharacterPosition xsi:type="xsd:int">0</CRMScript:ErrorCharacterPosition>
    </CRMScript:ErrorInformation>
   </CRMScript:Response>
  </CRMScript:ExecuteScriptByStringResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

