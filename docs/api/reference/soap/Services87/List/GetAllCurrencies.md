---
title: Services87.ListAgent.GetAllCurrencies SOAP
generated: 1
uid: Services87-List-GetAllCurrencies
---

# Services87 List GetAllCurrencies

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.GetAllCurrencies">SuperOffice.Services87.IListAgent.GetAllCurrencies</see> method.

## GetAllCurrencies

Returns all currencies

* **includeDeleted:** Include deleted items in result?

**Returns:** Array of currencies


[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllCurrencies Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetAllCurrencies>
    <List:IncludeDeleted xsi:type="xsd:boolean">false</List:IncludeDeleted>
   </List:GetAllCurrencies>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllCurrencies Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <List:GetAllCurrenciesResponse>
   <List:Response xsi:type="List:ArrayOfCurrencyEntity">
    <List:CurrencyEntity xsi:type="List:CurrencyEntity">
     <List:CurrencyId xsi:type="xsd:int">0</List:CurrencyId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:Rate xsi:type="xsd:double">0.0</List:Rate>
     <List:Units xsi:type="xsd:double">0.0</List:Units>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    </List:CurrencyEntity>
   </List:Response>
  </List:GetAllCurrenciesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

