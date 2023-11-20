---
title: Services88.AIAgent.GetTrainingStatus SOAP
generated: true
uid: Services88-AI-GetTrainingStatus
---

# Services88 AI GetTrainingStatus

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.GetTrainingStatus">SuperOffice.Services88.IAIAgent.GetTrainingStatus</see> method.

## GetTrainingStatus





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTrainingStatus Request

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
   <AI:GetTrainingStatus>
   </AI:GetTrainingStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTrainingStatus Response

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
  <AI:GetTrainingStatusResponse>
   <AI:Response xsi:type="AI:CategorizationStatusResponse">
    <AI:ContextIdentifier xsi:type="xsd:string"></AI:ContextIdentifier>
    <AI:Status xsi:type="xsd:string"></AI:Status>
    <AI:CurrentModel xsi:type="AI:CategorizationModelDetails">
     <AI:ModelBuiltDateTime xsi:type="xsd:dateTime">2023-11-10T12:35:35Z</AI:ModelBuiltDateTime>
     <AI:Accuracy xsi:type="xsd:double">0.0</AI:Accuracy>
     <AI:TicketCountForTraining xsi:type="xsd:int">0</AI:TicketCountForTraining>
    </AI:CurrentModel>
    <AI:PreviousModel xsi:type="AI:CategorizationModelDetails">
     <AI:ModelBuiltDateTime xsi:type="xsd:dateTime">2023-11-10T12:35:35Z</AI:ModelBuiltDateTime>
     <AI:Accuracy xsi:type="xsd:double">0.0</AI:Accuracy>
     <AI:TicketCountForTraining xsi:type="xsd:int">0</AI:TicketCountForTraining>
    </AI:PreviousModel>
   </AI:Response>
  </AI:GetTrainingStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

