---
uid: services85-list-changecurrency
title: Services85.ListAgent.ChangeCurrency SOAP
Generated: true
---

# Services85 List ChangeCurrency SOAP

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.ChangeCurrency">SuperOffice.Services85.IListAgent.ChangeCurrency</see> method.

## ChangeCurrency

Recalculates the amount to the new currency.

* **amount:** The amount in the old currency
* **fromCurrency:** The old currency name
* **toCurrency:** The new currency name

**Returns:** Amount in new currency


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangeCurrency Request

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
   <List:ChangeCurrency>
    <List:Amount xsi:type="xsd:double">0.0</List:Amount>
    <List:FromCurrency xsi:type="xsd:string"></List:FromCurrency>
    <List:ToCurrency xsi:type="xsd:string"></List:ToCurrency>
   </List:ChangeCurrency>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChangeCurrency Response

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
  <List:ChangeCurrencyResponse>
   <List:Response xsi:type="xsd:double">0.0</List:Response>
  </List:ChangeCurrencyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

