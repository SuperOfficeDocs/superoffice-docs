---
title: Services85.QuoteAgent.GetQuoteList SOAP
generated: 1
uid: Services85-Quote-GetQuoteList
---

# Services85 Quote GetQuoteList

SOAP request and response examples **Remote/Services85/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IQuoteAgent.GetQuoteList">SuperOffice.Services85.IQuoteAgent.GetQuoteList</see> method.

## GetQuoteList

Gets a named list from the connector Return array of QuoteListItems. Return NULL if the given list is not supported.

* **quoteListType:** The name of the requested list, for instance: ProductCategory, ProductFamily, ProductType, PaymentTerms, PaymentType, DeliveryTerms, DeliveryType.

**Returns:** The list items


[WSDL file for Services85/Quote](../Services85-Quote.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetQuoteList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetQuoteList>
    <Quote:QuoteListType xsi:type="xsd:string"></Quote:QuoteListType>
   </Quote:GetQuoteList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetQuoteList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Quote:GetQuoteListResponse>
   <Quote:Response xsi:type="Quote:ArrayOfQuoteListItem">
    <Quote:QuoteListItem xsi:type="Quote:QuoteListItem">
     <Quote:ERPQuoteListItemKey xsi:type="xsd:string"></Quote:ERPQuoteListItemKey>
     <Quote:DisplayValue xsi:type="xsd:string"></Quote:DisplayValue>
     <Quote:DisplayDescription xsi:type="xsd:string"></Quote:DisplayDescription>
    </Quote:QuoteListItem>
   </Quote:Response>
  </Quote:GetQuoteListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

