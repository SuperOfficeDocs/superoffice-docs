---
title: Services88.ListAgent.SaveTicketRelationDefinitionEntity SOAP
generated: true
uid: Services88-List-SaveTicketRelationDefinitionEntity
content_type: reference
---

# Services88 List SaveTicketRelationDefinitionEntity

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SaveTicketRelationDefinitionEntity">SuperOffice.Services88.IListAgent.SaveTicketRelationDefinitionEntity</see> method.

## SaveTicketRelationDefinitionEntity





[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveTicketRelationDefinitionEntity Request

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
   <List:SaveTicketRelationDefinitionEntity>
    <List:TicketRelationDefinitionEntity xsi:type="List:TicketRelationDefinitionEntity">
     <List:TicketRelationDefId xsi:type="xsd:int">0</List:TicketRelationDefId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Description xsi:type="xsd:string"></List:Description>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:RelationType xsi:type="List:TicketRelationType">Related</List:RelationType>
     <List:IsBuiltIn xsi:type="xsd:boolean">false</List:IsBuiltIn>
     <List:IsParentMandatory xsi:type="xsd:boolean">false</List:IsParentMandatory>
     <List:IsCloseParentWithChild xsi:type="xsd:boolean">false</List:IsCloseParentWithChild>
     <List:IsPreventClosingParent xsi:type="xsd:boolean">false</List:IsPreventClosingParent>
     <List:IsCloseWithParent xsi:type="xsd:boolean">false</List:IsCloseWithParent>
     <List:SourceTicketTypes xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </List:SourceTicketTypes>
     <List:DestinationTicketTypes xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </List:DestinationTicketTypes>
    </List:TicketRelationDefinitionEntity>
   </List:SaveTicketRelationDefinitionEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveTicketRelationDefinitionEntity Response

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
  <List:SaveTicketRelationDefinitionEntityResponse>
   <List:Response xsi:type="List:TicketRelationDefinitionEntity">
    <List:TicketRelationDefId xsi:type="xsd:int">0</List:TicketRelationDefId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Description xsi:type="xsd:string"></List:Description>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:RelationType xsi:type="List:TicketRelationType">Related</List:RelationType>
    <List:IsBuiltIn xsi:type="xsd:boolean">false</List:IsBuiltIn>
    <List:IsParentMandatory xsi:type="xsd:boolean">false</List:IsParentMandatory>
    <List:IsCloseParentWithChild xsi:type="xsd:boolean">false</List:IsCloseParentWithChild>
    <List:IsPreventClosingParent xsi:type="xsd:boolean">false</List:IsPreventClosingParent>
    <List:IsCloseWithParent xsi:type="xsd:boolean">false</List:IsCloseWithParent>
    <List:SourceTicketTypes xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </List:SourceTicketTypes>
    <List:DestinationTicketTypes xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </List:DestinationTicketTypes>
   </List:Response>
  </List:SaveTicketRelationDefinitionEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

