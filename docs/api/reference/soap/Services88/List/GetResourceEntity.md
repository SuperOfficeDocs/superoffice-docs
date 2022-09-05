---
title: Services88.ListAgent.GetResourceEntity SOAP
generated: 1
uid: Services88-List-GetResourceEntity
---

# Services88 List GetResourceEntity

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.GetResourceEntity">SuperOffice.Services88.IListAgent.GetResourceEntity</see> method.

## GetResourceEntity

Gets a ResourceEntity object.

* **resourceEntityId:** The identifier of the ResourceEntity object

**Returns:** ResourceEntity


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetResourceEntity Request

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
   <List:GetResourceEntity>
    <List:ResourceEntityId xsi:type="xsd:int">0</List:ResourceEntityId>
   </List:GetResourceEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetResourceEntity Response

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
  <List:GetResourceEntityResponse>
   <List:Response xsi:type="List:ResourceEntity">
    <List:ResourceId xsi:type="xsd:int">0</List:ResourceId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:IsLocation xsi:type="xsd:boolean">false</List:IsLocation>
    <List:LocationAddress xsi:type="xsd:string"></List:LocationAddress>
   </List:Response>
  </List:GetResourceEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

