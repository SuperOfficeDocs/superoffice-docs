---
uid: services82-sale-getprobabilityfromstage
title: Services82.SaleAgent.GetProbabilityFromStage SOAP
Generated: true
---

# Services82 Sale GetProbabilityFromStage SOAP

SOAP request and response examples **Remote/Services82/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services82.ISaleAgent.GetProbabilityFromStage">SuperOffice.Services82.ISaleAgent.GetProbabilityFromStage</see> method.

## GetProbabilityFromStage



* **stageId:** 



[WSDL file for Services82/Sale](../Services82-Sale.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProbabilityFromStage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:GetProbabilityFromStage>
    <Sale:StageId xsi:type="xsd:int">0</Sale:StageId>
   </Sale:GetProbabilityFromStage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProbabilityFromStage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Sale:GetProbabilityFromStageResponse>
   <Sale:Response xsi:type="xsd:int">0</Sale:Response>
  </Sale:GetProbabilityFromStageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

