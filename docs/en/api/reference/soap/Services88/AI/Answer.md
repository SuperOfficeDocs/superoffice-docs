---
title: Services88.AIAgent.Answer SOAP
generated: true
uid: Services88-AI-Answer
content_type: reference
---

# Services88 AI Answer

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.Answer">SuperOffice.Services88.IAIAgent.Answer</see> method.

## Answer





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Answer Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <AI:ApplicationToken>1234567-1234-9876</AI:ApplicationToken>
  <AI:Credentials>
    <AI:Ticket>7T:1234abcxyzExample==</AI:Ticket>
  </AI:Credentials>
 <SOAP-ENV:Body>
   <AI:Answer>
    <AI:NamespaceName xsi:type="xsd:string"></AI:NamespaceName>
    <AI:Query xsi:type="xsd:string"></AI:Query>
    <AI:Type xsi:type="AI:RagType">None</AI:Type>
    <AI:Top xsi:type="xsd:int">0</AI:Top>
   </AI:Answer>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Answer Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <AI:AnswerResponse>
   <AI:Response xsi:type="AI:RagAnswer">
    <AI:Answer xsi:type="xsd:string"></AI:Answer>
    <AI:Source xsi:type="AI:ArrayOfRagResult">
     <AI:RagResult xsi:type="AI:RagResult">
      <AI:Chunk xsi:type="xsd:string"></AI:Chunk>
      <AI:Title xsi:type="xsd:string"></AI:Title>
      <AI:Id xsi:type="xsd:string"></AI:Id>
      <AI:Type xsi:type="AI:RagType">None</AI:Type>
      <AI:Score xsi:type="xsd:double">0.0</AI:Score>
      <AI:Metadata xsi:type="AI:StringObjectDictionary">
       <AI:StringObjectKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:anyType"></AI:Value>
       </AI:StringObjectKeyValuePair>
      </AI:Metadata>
     </AI:RagResult>
    </AI:Source>
    <AI:TrackingId xsi:type="xsd:string"></AI:TrackingId>
   </AI:Response>
  </AI:AnswerResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

