---
uid: services81-sale-getsummarybygroup
title: Services81.SaleAgent.GetSummaryByGroup SOAP
Generated: true
---

# Services81 Sale GetSummaryByGroup SOAP

SOAP request and response examples **Remote/Services81/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services81.ISaleAgent.GetSummaryByGroup">SuperOffice.Services81.ISaleAgent.GetSummaryByGroup</see> method.

## GetSummaryByGroup



* **groupId:** 
* **fromDate:** 
* **toDate:** 



[WSDL file for Services81/Sale](../Services81-Sale.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSummaryByGroup Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:GetSummaryByGroup>
    <Sale:GroupId xsi:type="xsd:int">0</Sale:GroupId>
    <Sale:FromDate xsi:type="xsd:dateTime">2021-03-25T21:34:37Z</Sale:FromDate>
    <Sale:ToDate xsi:type="xsd:dateTime">2021-03-25T21:34:37Z</Sale:ToDate>
   </Sale:GetSummaryByGroup>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSummaryByGroup Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Sale:GetSummaryByGroupResponse>
   <Sale:Response xsi:type="Sale:SaleSummary">
    <Sale:BaseCurrency xsi:type="xsd:string"></Sale:BaseCurrency>
    <Sale:OwnCurrency xsi:type="xsd:string"></Sale:OwnCurrency>
    <Sale:SoldTotalBaseCurrency xsi:type="xsd:double">0.0</Sale:SoldTotalBaseCurrency>
    <Sale:Sold xsi:type="xsd:int">0</Sale:Sold>
    <Sale:SoldTotalOwnCurrency xsi:type="xsd:double">0.0</Sale:SoldTotalOwnCurrency>
    <Sale:Lost xsi:type="xsd:int">0</Sale:Lost>
    <Sale:LostTotalBaseCurrency xsi:type="xsd:double">0.0</Sale:LostTotalBaseCurrency>
    <Sale:LostTotalOwnCurrency xsi:type="xsd:double">0.0</Sale:LostTotalOwnCurrency>
    <Sale:Open xsi:type="xsd:int">0</Sale:Open>
    <Sale:OpenTotalBaseCurrency xsi:type="xsd:double">0.0</Sale:OpenTotalBaseCurrency>
    <Sale:OpenTotalOwnCurrency xsi:type="xsd:double">0.0</Sale:OpenTotalOwnCurrency>
    <Sale:OpenWeightedBaseCurrency xsi:type="xsd:double">0.0</Sale:OpenWeightedBaseCurrency>
    <Sale:OpenWeightedOwnCurrency xsi:type="xsd:double">0.0</Sale:OpenWeightedOwnCurrency>
    <Sale:PreviousOverdue xsi:type="xsd:int">0</Sale:PreviousOverdue>
    <Sale:PreviousOverdueTotalBaseCurrency xsi:type="xsd:double">0.0</Sale:PreviousOverdueTotalBaseCurrency>
    <Sale:PreviousOverdueTotalOwnCurrency xsi:type="xsd:double">0.0</Sale:PreviousOverdueTotalOwnCurrency>
    <Sale:PreviousOverdueWeightedBaseCurrency xsi:type="xsd:double">0.0</Sale:PreviousOverdueWeightedBaseCurrency>
    <Sale:PreviousOverdueWeightedOwnCurrency xsi:type="xsd:double">0.0</Sale:PreviousOverdueWeightedOwnCurrency>
    <Sale:CurrentOverdue xsi:type="xsd:int">0</Sale:CurrentOverdue>
    <Sale:CurrentOverdueTotalBaseCurrency xsi:type="xsd:double">0.0</Sale:CurrentOverdueTotalBaseCurrency>
    <Sale:CurrentOverdueTotalOwnCurrency xsi:type="xsd:double">0.0</Sale:CurrentOverdueTotalOwnCurrency>
    <Sale:CurrentOverdueWeightedBaseCurrency xsi:type="xsd:double">0.0</Sale:CurrentOverdueWeightedBaseCurrency>
    <Sale:CurrentOverdueWeightedOwnCurrency xsi:type="xsd:double">0.0</Sale:CurrentOverdueWeightedOwnCurrency>
    <Sale:FutureOpen xsi:type="xsd:int">0</Sale:FutureOpen>
    <Sale:FutureOpenTotalBaseCurrency xsi:type="xsd:double">0.0</Sale:FutureOpenTotalBaseCurrency>
    <Sale:FutureOpenTotalOwnCurrency xsi:type="xsd:double">0.0</Sale:FutureOpenTotalOwnCurrency>
    <Sale:FutureOpenWeightedBaseCurrency xsi:type="xsd:double">0.0</Sale:FutureOpenWeightedBaseCurrency>
    <Sale:FutureOpenWeightedOwnCurrency xsi:type="xsd:double">0.0</Sale:FutureOpenWeightedOwnCurrency>
   </Sale:Response>
  </Sale:GetSummaryByGroupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

