---
title: Services88.ListAgent.GetAmountClassEntity SOAP
generated: 1
uid: Services88-List-GetAmountClassEntity
---

# Services88 List GetAmountClassEntity

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.GetAmountClassEntity">SuperOffice.Services88.IListAgent.GetAmountClassEntity</see> method.

## GetAmountClassEntity

Gets a AmountClassEntity object.

* **amountClassEntityId:** The identifier of the AmountClassEntity object

**Returns:** AmountClassEntity


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAmountClassEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetAmountClassEntity>
    <List:AmountClassEntityId xsi:type="xsd:int">0</List:AmountClassEntityId>
   </List:GetAmountClassEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAmountClassEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:GetAmountClassEntityResponse>
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
  </List:GetAmountClassEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

