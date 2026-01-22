---
title: Services88.AIAgent.CancelIndexing SOAP
generated: true
uid: Services88-AI-CancelIndexing
content_type: reference
---

# Services88 AI CancelIndexing

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.CancelIndexing">SuperOffice.Services88.IAIAgent.CancelIndexing</see> method.

## CancelIndexing





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CancelIndexing Request

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
   <AI:CancelIndexing>
    <AI:NamespaceName xsi:type="xsd:string"></AI:NamespaceName>
   </AI:CancelIndexing>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CancelIndexing Response

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
  <AI:CancelIndexingResponse>
   <AI:Response xsi:type="AI:RagStatus">
    <AI:StartedAt xsi:type="xsd:dateTime">2026-01-21T01:32:34Z</AI:StartedAt>
    <AI:CompletedAt xsi:type="xsd:dateTime">2026-01-21T01:32:34Z</AI:CompletedAt>
    <AI:NamespaceName xsi:type="xsd:string"></AI:NamespaceName>
    <AI:CurrentRunTag xsi:type="xsd:string"></AI:CurrentRunTag>
    <AI:IsCompleted xsi:type="xsd:boolean">false</AI:IsCompleted>
    <AI:IsCancelled xsi:type="xsd:boolean">false</AI:IsCancelled>
    <AI:LastIndexed xsi:type="xsd:dateTime">2026-01-21T01:32:34Z</AI:LastIndexed>
    <AI:StatusAll xsi:type="AI:RagStatusChunks">
     <AI:NumberOfChunks xsi:type="xsd:int">0</AI:NumberOfChunks>
     <AI:NumberOfDocuments xsi:type="xsd:int">0</AI:NumberOfDocuments>
    </AI:StatusAll>
    <AI:StatusDocuments xsi:type="AI:RagStatusChunks">
     <AI:NumberOfChunks xsi:type="xsd:int">0</AI:NumberOfChunks>
     <AI:NumberOfDocuments xsi:type="xsd:int">0</AI:NumberOfDocuments>
    </AI:StatusDocuments>
    <AI:StatusFAQ xsi:type="AI:RagStatusChunks">
     <AI:NumberOfChunks xsi:type="xsd:int">0</AI:NumberOfChunks>
     <AI:NumberOfDocuments xsi:type="xsd:int">0</AI:NumberOfDocuments>
    </AI:StatusFAQ>
    <AI:StatusNone xsi:type="AI:RagStatusChunks">
     <AI:NumberOfChunks xsi:type="xsd:int">0</AI:NumberOfChunks>
     <AI:NumberOfDocuments xsi:type="xsd:int">0</AI:NumberOfDocuments>
    </AI:StatusNone>
    <AI:StatusProduct xsi:type="AI:RagStatusChunks">
     <AI:NumberOfChunks xsi:type="xsd:int">0</AI:NumberOfChunks>
     <AI:NumberOfDocuments xsi:type="xsd:int">0</AI:NumberOfDocuments>
    </AI:StatusProduct>
    <AI:StatusTicket xsi:type="AI:RagStatusChunks">
     <AI:NumberOfChunks xsi:type="xsd:int">0</AI:NumberOfChunks>
     <AI:NumberOfDocuments xsi:type="xsd:int">0</AI:NumberOfDocuments>
    </AI:StatusTicket>
    <AI:StatusWebpage xsi:type="AI:RagStatusChunks">
     <AI:NumberOfChunks xsi:type="xsd:int">0</AI:NumberOfChunks>
     <AI:NumberOfDocuments xsi:type="xsd:int">0</AI:NumberOfDocuments>
    </AI:StatusWebpage>
    <AI:StatusWebsite xsi:type="AI:RagStatusChunks">
     <AI:NumberOfChunks xsi:type="xsd:int">0</AI:NumberOfChunks>
     <AI:NumberOfDocuments xsi:type="xsd:int">0</AI:NumberOfDocuments>
    </AI:StatusWebsite>
   </AI:Response>
  </AI:CancelIndexingResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

