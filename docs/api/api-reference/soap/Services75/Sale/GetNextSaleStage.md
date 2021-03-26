---
uid: services75-sale-getnextsalestage
title: Services75.SaleAgent.GetNextSaleStage SOAP
Generated: true
---

# Services75 Sale GetNextSaleStage SOAP

SOAP request and response examples **Remote/Services75/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services75.ISaleAgent.GetNextSaleStage">SuperOffice.Services75.ISaleAgent.GetNextSaleStage</see> method.

## GetNextSaleStage

Gets the next (not deleted) sale stage id if the current stage is deleted. If the current stage is not deleted, the CurrentStageId is returned

* **saleId:** 
* **includeCurrentStage:** 



[WSDL file for Services75/Sale](../Services75-Sale.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNextSaleStage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services75">
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
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Sale:GetNextSaleStageResponse>
   <Sale:Response xsi:type="xsd:int">0</Sale:Response>
  </Sale:GetNextSaleStageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

