---
title: Services84.QuoteAgent.GetActivePriceLists SOAP
generated: 1
uid: Services84-Quote-GetActivePriceLists
---

# Services84 Quote GetActivePriceLists

SOAP request and response examples **Remote/Services84/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IQuoteAgent.GetActivePriceLists">SuperOffice.Services84.IQuoteAgent.GetActivePriceLists</see> method.

## GetActivePriceLists

Gets the available active PriceLists in a specific currency. Will return empty array if there is no PriceList with the stated currency available.

* **quoteConnectionId:** Primary key of the connection
* **currency:** Iso currency like: USD or NOK. See http://www.currency-iso.org/dl\_iso\_table\_a1.xls for details. Case insensitive. Will return empty array if there is no PriceList with the stated currency available.

**Returns:** The PriceLists that supports a specific currency


[WSDL file for Services84/Quote](../Services84-Quote.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetActivePriceLists Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetActivePriceLists>
    <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
    <Quote:Currency xsi:type="xsd:string"></Quote:Currency>
   </Quote:GetActivePriceLists>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetActivePriceLists Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Quote:GetActivePriceListsResponse>
   <Quote:Response xsi:type="Quote:ArrayOfPriceList">
    <Quote:PriceList xsi:type="Quote:PriceList">
     <Quote:PriceListId xsi:type="xsd:int">0</Quote:PriceListId>
     <Quote:ERPPriceListKey xsi:type="xsd:string"></Quote:ERPPriceListKey>
     <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
     <Quote:Name xsi:type="xsd:string"></Quote:Name>
     <Quote:Description xsi:type="xsd:string"></Quote:Description>
     <Quote:Currency xsi:type="xsd:string"></Quote:Currency>
     <Quote:CurrencyName xsi:type="xsd:string"></Quote:CurrencyName>
     <Quote:ValidFrom xsi:type="xsd:dateTime">2021-11-30T13:22:19Z</Quote:ValidFrom>
     <Quote:ValidTo xsi:type="xsd:dateTime">2021-11-30T13:22:19Z</Quote:ValidTo>
     <Quote:IsActive xsi:type="xsd:boolean">false</Quote:IsActive>
    </Quote:PriceList>
   </Quote:Response>
  </Quote:GetActivePriceListsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

