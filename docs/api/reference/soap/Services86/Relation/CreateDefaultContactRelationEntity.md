---
title: Services86.RelationAgent.CreateDefaultContactRelationEntity SOAP
generated: 1
uid: Services86-Relation-CreateDefaultContactRelationEntity
---

# Services86 Relation CreateDefaultContactRelationEntity

SOAP request and response examples **Remote/Services86/Relation.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IRelationAgent.CreateDefaultContactRelationEntity">SuperOffice.Services86.IRelationAgent.CreateDefaultContactRelationEntity</see> method.

## CreateDefaultContactRelationEntity

Loading default values into a new ContactRelationEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New ContactRelationEntity with default values


[WSDL file for Services86/Relation](../Services86-Relation.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultContactRelationEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Relation="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Relation:ApplicationToken>1234567-1234-9876</Relation:ApplicationToken>
  <Relation:Credentials>
    <Relation:Ticket>7T:1234abcxyzExample==</Relation:Ticket>
  </Relation:Credentials>
 <SOAP-ENV:Body>
   <Relation:CreateDefaultContactRelationEntity>
   </Relation:CreateDefaultContactRelationEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultContactRelationEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Relation="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Relation:CreateDefaultContactRelationEntityResponse>
   <Relation:Response xsi:type="Relation:ContactRelationEntity">
    <Relation:SourceContactId xsi:type="xsd:int">0</Relation:SourceContactId>
    <Relation:SourcePersonId xsi:type="xsd:int">0</Relation:SourcePersonId>
    <Relation:DestinationContactId xsi:type="xsd:int">0</Relation:DestinationContactId>
    <Relation:DestinationPersonId xsi:type="xsd:int">0</Relation:DestinationPersonId>
    <Relation:RelationId xsi:type="xsd:int">0</Relation:RelationId>
    <Relation:Comment xsi:type="xsd:string"></Relation:Comment>
    <Relation:RelationDefinitionId xsi:type="xsd:int">0</Relation:RelationDefinitionId>
    <Relation:Reversed xsi:type="xsd:short">0</Relation:Reversed>
    <Relation:UpdatedDate xsi:type="xsd:dateTime">2022-08-26T08:55:44Z</Relation:UpdatedDate>
    <Relation:CreatedDate xsi:type="xsd:dateTime">2022-08-26T08:55:44Z</Relation:CreatedDate>
    <Relation:CreatedBy xsi:type="Relation:Associate">
     <Relation:AssociateId xsi:type="xsd:int">0</Relation:AssociateId>
     <Relation:Name xsi:type="xsd:string"></Relation:Name>
     <Relation:PersonId xsi:type="xsd:int">0</Relation:PersonId>
     <Relation:Rank xsi:type="xsd:short">0</Relation:Rank>
     <Relation:Tooltip xsi:type="xsd:string"></Relation:Tooltip>
     <Relation:Type xsi:type="Relation:UserType">Unknown</Relation:Type>
     <Relation:GroupIdx xsi:type="xsd:int">0</Relation:GroupIdx>
     <Relation:FullName xsi:type="xsd:string"></Relation:FullName>
     <Relation:FormalName xsi:type="xsd:string"></Relation:FormalName>
     <Relation:Deleted xsi:type="xsd:boolean">false</Relation:Deleted>
     <Relation:EjUserId xsi:type="xsd:int">0</Relation:EjUserId>
     <Relation:UserName xsi:type="xsd:string"></Relation:UserName>
    </Relation:CreatedBy>
    <Relation:UpdatedBy xsi:type="Relation:Associate">
     <Relation:AssociateId xsi:type="xsd:int">0</Relation:AssociateId>
     <Relation:Name xsi:type="xsd:string"></Relation:Name>
     <Relation:PersonId xsi:type="xsd:int">0</Relation:PersonId>
     <Relation:Rank xsi:type="xsd:short">0</Relation:Rank>
     <Relation:Tooltip xsi:type="xsd:string"></Relation:Tooltip>
     <Relation:Type xsi:type="Relation:UserType">Unknown</Relation:Type>
     <Relation:GroupIdx xsi:type="xsd:int">0</Relation:GroupIdx>
     <Relation:FullName xsi:type="xsd:string"></Relation:FullName>
     <Relation:FormalName xsi:type="xsd:string"></Relation:FormalName>
     <Relation:Deleted xsi:type="xsd:boolean">false</Relation:Deleted>
     <Relation:EjUserId xsi:type="xsd:int">0</Relation:EjUserId>
     <Relation:UserName xsi:type="xsd:string"></Relation:UserName>
    </Relation:UpdatedBy>
    <Relation:SourceContactName xsi:type="xsd:string"></Relation:SourceContactName>
    <Relation:SourcePersonName xsi:type="xsd:string"></Relation:SourcePersonName>
    <Relation:DestinationContactName xsi:type="xsd:string"></Relation:DestinationContactName>
    <Relation:DestinationPersonName xsi:type="xsd:string"></Relation:DestinationPersonName>
    <Relation:ActiveText xsi:type="xsd:string"></Relation:ActiveText>
    <Relation:PassiveText xsi:type="xsd:string"></Relation:PassiveText>
   </Relation:Response>
  </Relation:CreateDefaultContactRelationEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

