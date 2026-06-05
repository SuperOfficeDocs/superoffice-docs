---
title: Services88.ListAgent.ValidateTicketRelationDefinition SOAP
generated: true
uid: Services88-List-ValidateTicketRelationDefinition
content_type: reference
---

# Services88 List ValidateTicketRelationDefinition

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.ValidateTicketRelationDefinition">SuperOffice.Services88.IListAgent.ValidateTicketRelationDefinition</see> method.

## ValidateTicketRelationDefinition





[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ValidateTicketRelationDefinition Request

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
   <List:ValidateTicketRelationDefinition>
    <List:TicketRelationDefinitionId xsi:type="xsd:int">0</List:TicketRelationDefinitionId>
    <List:SourceTicketTypeIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </List:SourceTicketTypeIds>
    <List:DestinationTicketTypeIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </List:DestinationTicketTypeIds>
    <List:RelationType xsi:type="List:TicketRelationType">Related</List:RelationType>
   </List:ValidateTicketRelationDefinition>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ValidateTicketRelationDefinition Response

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
  <List:ValidateTicketRelationDefinitionResponse>
   <List:Response xsi:type="List:ArrayOfTicketRelationDefinitionResult">
    <List:TicketRelationDefinitionResult xsi:type="List:TicketRelationDefinitionResult">
     <List:SourceTicketTypeId xsi:type="xsd:int">0</List:SourceTicketTypeId>
     <List:DestinationTicketTypeId xsi:type="xsd:int">0</List:DestinationTicketTypeId>
     <List:IsValid xsi:type="xsd:boolean">false</List:IsValid>
     <List:ExistingRelationDefinitionName xsi:type="xsd:string"></List:ExistingRelationDefinitionName>
    </List:TicketRelationDefinitionResult>
   </List:Response>
  </List:ValidateTicketRelationDefinitionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

