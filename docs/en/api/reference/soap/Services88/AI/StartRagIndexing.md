---
title: Services88.AIAgent.StartRagIndexing SOAP
generated: true
uid: Services88-AI-StartRagIndexing
---

# Services88 AI StartRagIndexing

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.StartRagIndexing">SuperOffice.Services88.IAIAgent.StartRagIndexing</see> method.

## StartRagIndexing





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## StartRagIndexing Request

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
   <AI:StartRagIndexing>
    <AI:NamespaceName xsi:type="xsd:string"></AI:NamespaceName>
    <AI:SourceId xsi:type="xsd:string"></AI:SourceId>
   </AI:StartRagIndexing>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## StartRagIndexing Response

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
  <AI:StartRagIndexingResponse>
   <AI:Response xsi:type="xsd:int">0</AI:Response>
  </AI:StartRagIndexingResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

