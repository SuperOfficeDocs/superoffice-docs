---
uid: services85-list-createdefaultsalestageentity
title: Services85.ListAgent.CreateDefaultSaleStageEntity SOAP
Generated: true
---

# Services85 List CreateDefaultSaleStageEntity SOAP

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.CreateDefaultSaleStageEntity">SuperOffice.Services85.IListAgent.CreateDefaultSaleStageEntity</see> method.

## CreateDefaultSaleStageEntity

Loading default values into a new SaleStageEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New SaleStageEntity with default values


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultSaleStageEntity Request

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
   <List:CreateDefaultSaleStageEntity>
   </List:CreateDefaultSaleStageEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultSaleStageEntity Response

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
  <List:CreateDefaultSaleStageEntityResponse>
   <List:Response xsi:type="List:SaleStageEntity">
    <List:SaleStageId xsi:type="xsd:int">0</List:SaleStageId>
    <List:Value xsi:type="xsd:string"></List:Value>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Probability xsi:type="xsd:short">0</List:Probability>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
   </List:Response>
  </List:CreateDefaultSaleStageEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

