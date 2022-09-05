---
title: Services88.ListAgent.SaveSaleStageEntity SOAP
generated: 1
uid: Services88-List-SaveSaleStageEntity
---

# Services88 List SaveSaleStageEntity

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SaveSaleStageEntity">SuperOffice.Services88.IListAgent.SaveSaleStageEntity</see> method.

## SaveSaleStageEntity

Updates the existing SaleStageEntity or creates a new SaleStageEntity if the id parameter is 0.

* **saleStageEntity:** The SaleStageEntity that is saved.

**Returns:** New or updated SaleStageEntity


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveSaleStageEntity Request

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
   <List:SaveSaleStageEntity>
    <List:SaleStageEntity xsi:type="List:SaleStageEntity">
     <List:SaleStageId xsi:type="xsd:int">0</List:SaleStageId>
     <List:Value xsi:type="xsd:string"></List:Value>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Probability xsi:type="xsd:short">0</List:Probability>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
    </List:SaleStageEntity>
   </List:SaveSaleStageEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveSaleStageEntity Response

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
  <List:SaveSaleStageEntityResponse>
   <List:Response xsi:type="List:SaleStageEntity">
    <List:SaleStageId xsi:type="xsd:int">0</List:SaleStageId>
    <List:Value xsi:type="xsd:string"></List:Value>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Probability xsi:type="xsd:short">0</List:Probability>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
   </List:Response>
  </List:SaveSaleStageEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

