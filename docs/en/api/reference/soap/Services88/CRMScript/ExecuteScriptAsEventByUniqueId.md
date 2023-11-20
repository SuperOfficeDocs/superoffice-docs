---
title: Services88.CRMScriptAgent.ExecuteScriptAsEventByUniqueId SOAP
generated: true
uid: Services88-CRMScript-ExecuteScriptAsEventByUniqueId
---

# Services88 CRMScript ExecuteScriptAsEventByUniqueId

SOAP request and response examples **Remote/Services88/CRMScript.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICRMScriptAgent.ExecuteScriptAsEventByUniqueId">SuperOffice.Services88.ICRMScriptAgent.ExecuteScriptAsEventByUniqueId</see> method.

## ExecuteScriptAsEventByUniqueId





[WSDL file for Services88/CRMScript](../Services88-CRMScript.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ExecuteScriptAsEventByUniqueId Request

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
   <CRMScript:ExecuteScriptAsEventByUniqueId>
    <CRMScript:CRMScriptUniqueId xsi:type="xsd:string"></CRMScript:CRMScriptUniqueId>
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
   </CRMScript:ExecuteScriptAsEventByUniqueId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ExecuteScriptAsEventByUniqueId Response

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
  <CRMScript:ExecuteScriptAsEventByUniqueIdResponse>
   <CRMScript:Response xsi:type="CRMScript:EventData">
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
   </CRMScript:Response>
  </CRMScript:ExecuteScriptAsEventByUniqueIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

