---
uid: services80-list-getrelationdefinitionentity
title: Services80.ListAgent.GetRelationDefinitionEntity SOAP
Generated: true
---

# Services80 List GetRelationDefinitionEntity SOAP

SOAP request and response examples **Remote/Services80/List.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IListAgent.GetRelationDefinitionEntity">SuperOffice.Services80.IListAgent.GetRelationDefinitionEntity</see> method.

## GetRelationDefinitionEntity

Gets a RelationDefinitionEntity object.

* **relationDefinitionEntityId:** The identifier of the RelationDefinitionEntity object

**Returns:** RelationDefinitionEntity


[WSDL file for Services80/List](../Services80-List.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetRelationDefinitionEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetRelationDefinitionEntity>
    <List:RelationDefinitionEntityId xsi:type="xsd:int">0</List:RelationDefinitionEntityId>
   </List:GetRelationDefinitionEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetRelationDefinitionEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <List:GetRelationDefinitionEntityResponse>
   <List:Response xsi:type="List:RelationDefinitionEntity">
    <List:ReldefId xsi:type="xsd:int">0</List:ReldefId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:PassiveText xsi:type="xsd:string"></List:PassiveText>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:Source xsi:type="List:RelationTarget">None</List:Source>
    <List:Destination xsi:type="List:RelationTarget">None</List:Destination>
   </List:Response>
  </List:GetRelationDefinitionEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

