---
title: Services85.ListAgent.GetBaseCurrency SOAP
generated: 1
uid: Services85-List-GetBaseCurrency
---

# Services85 List GetBaseCurrency

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.GetBaseCurrency">SuperOffice.Services85.IListAgent.GetBaseCurrency</see> method.

## GetBaseCurrency

Get the base currency, used for calculating exchange rates


**Returns:** The base currency that other currencies are expressed in terms of


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetBaseCurrency Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetBaseCurrency>
   </List:GetBaseCurrency>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetBaseCurrency Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <List:GetBaseCurrencyResponse>
   <List:Response xsi:type="List:CurrencyEntity">
    <List:CurrencyId xsi:type="xsd:int">0</List:CurrencyId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:Rate xsi:type="xsd:double">0.0</List:Rate>
    <List:Units xsi:type="xsd:double">0.0</List:Units>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
   </List:Response>
  </List:GetBaseCurrencyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

