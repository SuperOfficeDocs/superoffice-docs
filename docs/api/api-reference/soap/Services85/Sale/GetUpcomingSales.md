---
title: Services85.SaleAgent.GetUpcomingSales SOAP
generated: 1
uid: Services85-Sale-GetUpcomingSales
---

# Services85 Sale GetUpcomingSales

SOAP request and response examples **Remote/Services85/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISaleAgent.GetUpcomingSales">SuperOffice.Services85.ISaleAgent.GetUpcomingSales</see> method.

## GetUpcomingSales

Returns all open sales, sorted descending with the latest first.  If the weigthed amount is -1, the amount restriction is omitted.

* **weightedAmountLimit:** The amount weighted by the probability that the sale is closed (amount * probability).
* **count:** The maximum number of items to return. If -1 all are returned.

**Returns:** Array of upcoming sales.


[WSDL file for Services85/Sale](../Services85-Sale.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUpcomingSales Request

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
   <Sale:GetUpcomingSales>
    <Sale:WeightedAmountLimit xsi:type="xsd:int">0</Sale:WeightedAmountLimit>
    <Sale:Count xsi:type="xsd:int">0</Sale:Count>
   </Sale:GetUpcomingSales>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUpcomingSales Response

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
  <Sale:GetUpcomingSalesResponse>
   <Sale:Response xsi:type="Sale:ArrayOfSale">
    <Sale:Sale xsi:type="Sale:Sale">
     <Sale:ContactName xsi:type="xsd:string"></Sale:ContactName>
     <Sale:SaleDate xsi:type="xsd:dateTime">2021-11-30T13:22:42Z</Sale:SaleDate>
     <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
     <Sale:Probability xsi:type="xsd:short">0</Sale:Probability>
     <Sale:Title xsi:type="xsd:string"></Sale:Title>
     <Sale:Amount xsi:type="xsd:double">0.0</Sale:Amount>
     <Sale:Currency xsi:type="xsd:string"></Sale:Currency>
     <Sale:ProjectName xsi:type="xsd:string"></Sale:ProjectName>
     <Sale:AssociateFullName xsi:type="xsd:string"></Sale:AssociateFullName>
     <Sale:Description xsi:type="xsd:string"></Sale:Description>
     <Sale:Status xsi:type="Sale:SaleStatus">Unknown</Sale:Status>
     <Sale:WeightedAmount xsi:type="xsd:double">0.0</Sale:WeightedAmount>
     <Sale:ProjectId xsi:type="xsd:int">0</Sale:ProjectId>
     <Sale:EarningPercent xsi:type="xsd:double">0.0</Sale:EarningPercent>
     <Sale:Earning xsi:type="xsd:double">0.0</Sale:Earning>
     <Sale:ContactId xsi:type="xsd:int">0</Sale:ContactId>
     <Sale:AssociateId xsi:type="xsd:int">0</Sale:AssociateId>
     <Sale:PersonId xsi:type="xsd:int">0</Sale:PersonId>
     <Sale:SaleTypeId xsi:type="xsd:int">0</Sale:SaleTypeId>
     <Sale:SaleTypeName xsi:type="xsd:string"></Sale:SaleTypeName>
     <Sale:PersonFullName xsi:type="xsd:string"></Sale:PersonFullName>
     <Sale:Completed xsi:type="Sale:ActivityStatus">Unknown</Sale:Completed>
     <Sale:ActiveErpLinks xsi:type="xsd:int">0</Sale:ActiveErpLinks>
     <Sale:NextDueDate xsi:type="xsd:dateTime">2021-11-30T13:22:42Z</Sale:NextDueDate>
    </Sale:Sale>
   </Sale:Response>
  </Sale:GetUpcomingSalesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

