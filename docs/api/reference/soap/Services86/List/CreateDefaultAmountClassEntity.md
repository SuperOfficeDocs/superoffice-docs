---
title: Services86.ListAgent.CreateDefaultAmountClassEntity SOAP
generated: 1
uid: Services86-List-CreateDefaultAmountClassEntity
---

# Services86 List CreateDefaultAmountClassEntity

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.CreateDefaultAmountClassEntity">SuperOffice.Services86.IListAgent.CreateDefaultAmountClassEntity</see> method.

## CreateDefaultAmountClassEntity

Loading default values into a new AmountClassEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New AmountClassEntity with default values


[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultAmountClassEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:CreateDefaultAmountClassEntity>
   </List:CreateDefaultAmountClassEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultAmountClassEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <List:CreateDefaultAmountClassEntityResponse>
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
  </List:CreateDefaultAmountClassEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

