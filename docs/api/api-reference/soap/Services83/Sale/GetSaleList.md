---
uid: services83-sale-getsalelist
title: Services83.SaleAgent.GetSaleList SOAP
Generated: true
---

# Services83 Sale GetSaleList SOAP

SOAP request and response examples **Remote/Services83/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services83.ISaleAgent.GetSaleList">SuperOffice.Services83.ISaleAgent.GetSaleList</see> method.

## GetSaleList

Gets an array of Sale objects.

* **saleIds:** The identifiers of the Sale object

**Returns:** Array of Sale objects


[WSDL file for Services83/Sale](../Services83-Sale.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSaleList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:GetSaleList>
    <Sale:SaleIds xsi:type="NetServerServices832:ArrayOfint">
     <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
    </Sale:SaleIds>
   </Sale:GetSaleList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSaleList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Sale:GetSaleListResponse>
   <Sale:Response xsi:type="Sale:ArrayOfSale">
    <Sale:Sale xsi:type="Sale:Sale">
     <Sale:ContactName xsi:type="xsd:string"></Sale:ContactName>
     <Sale:SaleDate xsi:type="xsd:dateTime">2021-03-25T21:35:15Z</Sale:SaleDate>
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
     <Sale:NextDueDate xsi:type="xsd:dateTime">2021-03-25T21:35:15Z</Sale:NextDueDate>
    </Sale:Sale>
   </Sale:Response>
  </Sale:GetSaleListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

