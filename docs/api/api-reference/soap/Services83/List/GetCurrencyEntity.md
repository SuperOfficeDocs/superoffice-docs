---
uid: services83-list-getcurrencyentity
title: Services83.ListAgent.GetCurrencyEntity SOAP
Generated: true
---

# Services83 List GetCurrencyEntity SOAP

SOAP request and response examples **Remote/Services83/List.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IListAgent.GetCurrencyEntity">SuperOffice.Services83.IListAgent.GetCurrencyEntity</see> method.

## GetCurrencyEntity

Gets a CurrencyEntity object.

* **currencyEntityId:** The identifier of the CurrencyEntity object

**Returns:** CurrencyEntity


[WSDL file for Services83/List](../Services83-List.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCurrencyEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetCurrencyEntity>
    <List:CurrencyEntityId xsi:type="xsd:int">0</List:CurrencyEntityId>
   </List:GetCurrencyEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCurrencyEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <List:GetCurrencyEntityResponse>
   <List:Response xsi:type="List:CurrencyEntity">
    <List:CurrencyId xsi:type="xsd:int">0</List:CurrencyId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:Rate xsi:type="xsd:double">0.0</List:Rate>
    <List:Units xsi:type="xsd:double">0.0</List:Units>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
   </List:Response>
  </List:GetCurrencyEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

