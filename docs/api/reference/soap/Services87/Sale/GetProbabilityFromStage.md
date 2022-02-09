---
title: Services87.SaleAgent.GetProbabilityFromStage SOAP
generated: 1
uid: Services87-Sale-GetProbabilityFromStage
---

# Services87 Sale GetProbabilityFromStage

SOAP request and response examples **Remote/Services87/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ISaleAgent.GetProbabilityFromStage">SuperOffice.Services87.ISaleAgent.GetProbabilityFromStage</see> method.

## GetProbabilityFromStage

Get the probability percentage for a given sale stage

* **stageId:** Probability list id

**Returns:** Probability percentage


[WSDL file for Services87/Sale](../Services87-Sale.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProbabilityFromStage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services87">
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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Sale:GetProbabilityFromStageResponse>
   <Sale:Response xsi:type="xsd:int">0</Sale:Response>
  </Sale:GetProbabilityFromStageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

