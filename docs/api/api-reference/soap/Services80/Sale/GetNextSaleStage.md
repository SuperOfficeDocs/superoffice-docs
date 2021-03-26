---
uid: services80-sale-getnextsalestage
title: Services80.SaleAgent.GetNextSaleStage SOAP
Generated: true
---

# Services80 Sale GetNextSaleStage SOAP

SOAP request and response examples **Remote/Services80/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services80.ISaleAgent.GetNextSaleStage">SuperOffice.Services80.ISaleAgent.GetNextSaleStage</see> method.

## GetNextSaleStage

Gets the next (not deleted) sale stage id if the current stage is deleted. If the current stage is not deleted, the CurrentStageId is returned

* **saleId:** 
* **includeCurrentStage:** 



[WSDL file for Services80/Sale](../Services80-Sale.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNextSaleStage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:GetNextSaleStage>
    <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
    <Sale:IncludeCurrentStage xsi:type="xsd:boolean">false</Sale:IncludeCurrentStage>
   </Sale:GetNextSaleStage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNextSaleStage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Sale:GetNextSaleStageResponse>
   <Sale:Response xsi:type="xsd:int">0</Sale:Response>
  </Sale:GetNextSaleStageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

