---
uid: services75-list-saveresourceentity
title: Services75.ListAgent.SaveResourceEntity SOAP
Generated: true
---

# Services75 List SaveResourceEntity SOAP

SOAP request and response examples **Remote/Services75/List.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IListAgent.SaveResourceEntity">SuperOffice.Services75.IListAgent.SaveResourceEntity</see> method.

## SaveResourceEntity

Updates the existing ResourceEntity or creates a new ResourceEntity if the id parameter is empty

* **resourceEntity:** The ResourceEntity that is saved.

**Returns:** New or updated ResourceEntity


[WSDL file for Services75/List](../Services75-List.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveResourceEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SaveResourceEntity>
    <List:ResourceEntity xsi:type="List:ResourceEntity">
     <List:ResourceId xsi:type="xsd:int">0</List:ResourceId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:IsLocation xsi:type="xsd:boolean">false</List:IsLocation>
     <List:LocationAddress xsi:type="xsd:string"></List:LocationAddress>
    </List:ResourceEntity>
   </List:SaveResourceEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveResourceEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <List:SaveResourceEntityResponse>
   <List:Response xsi:type="List:ResourceEntity">
    <List:ResourceId xsi:type="xsd:int">0</List:ResourceId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:IsLocation xsi:type="xsd:boolean">false</List:IsLocation>
    <List:LocationAddress xsi:type="xsd:string"></List:LocationAddress>
   </List:Response>
  </List:SaveResourceEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

