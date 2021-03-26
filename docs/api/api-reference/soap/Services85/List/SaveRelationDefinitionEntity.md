---
uid: services85-list-saverelationdefinitionentity
title: Services85.ListAgent.SaveRelationDefinitionEntity SOAP
Generated: true
---

# Services85 List SaveRelationDefinitionEntity SOAP

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.SaveRelationDefinitionEntity">SuperOffice.Services85.IListAgent.SaveRelationDefinitionEntity</see> method.

## SaveRelationDefinitionEntity

Updates the existing RelationDefinitionEntity or creates a new RelationDefinitionEntity if the id parameter is 0.

* **relationDefinitionEntity:** The RelationDefinitionEntity that is saved.

**Returns:** New or updated RelationDefinitionEntity


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveRelationDefinitionEntity Request

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
   <List:SaveRelationDefinitionEntity>
    <List:RelationDefinitionEntity xsi:type="List:RelationDefinitionEntity">
     <List:ReldefId xsi:type="xsd:int">0</List:ReldefId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:PassiveText xsi:type="xsd:string"></List:PassiveText>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:Source xsi:type="List:RelationTarget">None</List:Source>
     <List:Destination xsi:type="List:RelationTarget">None</List:Destination>
    </List:RelationDefinitionEntity>
   </List:SaveRelationDefinitionEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveRelationDefinitionEntity Response

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
  <List:SaveRelationDefinitionEntityResponse>
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
  </List:SaveRelationDefinitionEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

