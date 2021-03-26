---
uid: services81-list-getproducttype
title: Services81.ListAgent.GetProductType SOAP
Generated: true
---

# Services81 List GetProductType SOAP

SOAP request and response examples **Remote/Services81/List.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IListAgent.GetProductType">SuperOffice.Services81.IListAgent.GetProductType</see> method.

## GetProductType

Gets a ProductType object.

* **productTypeId:** The identifier of the ProductType object

**Returns:** ProductType


[WSDL file for Services81/List](../Services81-List.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProductType Request

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
   <List:GetProductType>
    <List:ProductTypeId xsi:type="xsd:int">0</List:ProductTypeId>
   </List:GetProductType>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProductType Response

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
  <List:GetProductTypeResponse>
   <List:Response xsi:type="List:ProductType">
    <List:Id xsi:type="xsd:int">0</List:Id>
    <List:Value xsi:type="xsd:string"></List:Value>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
   </List:Response>
  </List:GetProductTypeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

