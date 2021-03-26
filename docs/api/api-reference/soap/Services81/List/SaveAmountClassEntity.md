---
uid: services81-list-saveamountclassentity
title: Services81.ListAgent.SaveAmountClassEntity SOAP
Generated: true
---

# Services81 List SaveAmountClassEntity SOAP

SOAP request and response examples **Remote/Services81/List.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IListAgent.SaveAmountClassEntity">SuperOffice.Services81.IListAgent.SaveAmountClassEntity</see> method.

## SaveAmountClassEntity

Updates the existing AmountClassEntity or creates a new AmountClassEntity if the id parameter is empty

* **amountClassEntity:** The AmountClassEntity that is saved.

**Returns:** New or updated AmountClassEntity


[WSDL file for Services81/List](../Services81-List.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveAmountClassEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SaveAmountClassEntity>
    <List:AmountClassEntity xsi:type="List:AmountClassEntity">
     <List:AmountClassId xsi:type="xsd:int">0</List:AmountClassId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:AmountFrom xsi:type="xsd:double">0.0</List:AmountFrom>
     <List:AmountTo xsi:type="xsd:double">0.0</List:AmountTo>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:CurrencyId xsi:type="xsd:int">0</List:CurrencyId>
    </List:AmountClassEntity>
   </List:SaveAmountClassEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveAmountClassEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <List:SaveAmountClassEntityResponse>
   <List:Response xsi:type="List:AmountClassEntity">
    <List:AmountClassId xsi:type="xsd:int">0</List:AmountClassId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:AmountFrom xsi:type="xsd:double">0.0</List:AmountFrom>
    <List:AmountTo xsi:type="xsd:double">0.0</List:AmountTo>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:CurrencyId xsi:type="xsd:int">0</List:CurrencyId>
   </List:Response>
  </List:SaveAmountClassEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

