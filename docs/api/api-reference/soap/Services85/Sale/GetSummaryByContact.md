---
uid: services85-sale-getsummarybycontact
title: Services85.SaleAgent.GetSummaryByContact SOAP
Generated: true
---

# Services85 Sale GetSummaryByContact SOAP

SOAP request and response examples **Remote/Services85/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISaleAgent.GetSummaryByContact">SuperOffice.Services85.ISaleAgent.GetSummaryByContact</see> method.

## GetSummaryByContact



* **contactId:** 
* **fromDate:** 
* **toDate:** 



[WSDL file for Services85/Sale](../Services85-Sale.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSummaryByContact Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:GetSummaryByContact>
    <Sale:ContactId xsi:type="xsd:int">0</Sale:ContactId>
    <Sale:FromDate xsi:type="xsd:dateTime">2021-03-25T21:35:57Z</Sale:FromDate>
    <Sale:ToDate xsi:type="xsd:dateTime">2021-03-25T21:35:57Z</Sale:ToDate>
   </Sale:GetSummaryByContact>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSummaryByContact Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Sale:GetSummaryByContactResponse>
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
  </Sale:GetSummaryByContactResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

