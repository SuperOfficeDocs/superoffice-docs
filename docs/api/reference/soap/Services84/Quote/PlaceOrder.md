---
title: Services84.QuoteAgent.PlaceOrder SOAP
generated: 1
uid: Services84-Quote-PlaceOrder
---

# Services84 Quote PlaceOrder

SOAP request and response examples **Remote/Services84/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IQuoteAgent.PlaceOrder">SuperOffice.Services84.IQuoteAgent.PlaceOrder</see> method.

## PlaceOrder

Place an order in the ERP system.

* **quoteAlternativeId:** Id of the alternative to place the order on.
* **markSaleAsSold:** Should the state of the owning Sale be set to sold
* **poNumber:** Purchase order number, saved to Quote record
* **orderComment:** Order comment, saved to Quote record
* **culture:** Desired culture for email body and other culture-sensitive templates/content

**Returns:** Status for the placed order.


[WSDL file for Services84/Quote](../Services84-Quote.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## PlaceOrder Request

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
   <Quote:PlaceOrder>
    <Quote:QuoteAlternativeId xsi:type="xsd:int">0</Quote:QuoteAlternativeId>
    <Quote:MarkSaleAsSold xsi:type="xsd:boolean">false</Quote:MarkSaleAsSold>
    <Quote:PoNumber xsi:type="xsd:string"></Quote:PoNumber>
    <Quote:OrderComment xsi:type="xsd:string"></Quote:OrderComment>
    <Quote:Culture xsi:type="xsd:string"></Quote:Culture>
   </Quote:PlaceOrder>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## PlaceOrder Response

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
  <Quote:PlaceOrderResponse>
   <Quote:Response xsi:type="Quote:PluginUrlResponse">
    <Quote:IsOk xsi:type="xsd:boolean">false</Quote:IsOk>
    <Quote:UserExplanation xsi:type="xsd:string"></Quote:UserExplanation>
    <Quote:TechExplanation xsi:type="xsd:string"></Quote:TechExplanation>
    <Quote:ErrorCode xsi:type="xsd:string"></Quote:ErrorCode>
    <Quote:Changes xsi:type="Quote:ChangedData">
     <Quote:AddedRecords xsi:type="Quote:ArrayOfChangedDataItem">
      <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
       <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
       <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
      </Quote:ChangedDataItem>
     </Quote:AddedRecords>
     <Quote:UpdatedRecords xsi:type="Quote:ArrayOfChangedDataItem">
      <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
       <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
       <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
      </Quote:ChangedDataItem>
     </Quote:UpdatedRecords>
     <Quote:DeletedRecords xsi:type="Quote:ArrayOfChangedDataItem">
      <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
       <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
       <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
      </Quote:ChangedDataItem>
     </Quote:DeletedRecords>
    </Quote:Changes>
    <Quote:Url xsi:type="xsd:string"></Quote:Url>
   </Quote:Response>
  </Quote:PlaceOrderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

