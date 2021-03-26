---
uid: services88-relation-savecontactrelation
title: Services88.RelationAgent.SaveContactRelation SOAP
Generated: true
---

# Services88 Relation SaveContactRelation SOAP

SOAP request and response examples **Remote/Services88/Relation.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IRelationAgent.SaveContactRelation">SuperOffice.Services88.IRelationAgent.SaveContactRelation</see> method.

## SaveContactRelation

Creates a new or updates an existing contact relation.

* **contactRelationEntity:** Relation to save

**Returns:** Saved relation


[WSDL file for Services88/Relation](../Services88-Relation.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveContactRelation Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Relation="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Relation:ApplicationToken>1234567-1234-9876</Relation:ApplicationToken>
  <Relation:Credentials>
    <Relation:Ticket>7T:1234abcxyzExample==</Relation:Ticket>
  </Relation:Credentials>
 <SOAP-ENV:Body>
   <Relation:SaveContactRelation>
    <Relation:ContactRelationEntity xsi:type="Relation:ContactRelationEntity">
     <Relation:SourceContactId xsi:type="xsd:int">0</Relation:SourceContactId>
     <Relation:SourcePersonId xsi:type="xsd:int">0</Relation:SourcePersonId>
     <Relation:DestinationContactId xsi:type="xsd:int">0</Relation:DestinationContactId>
     <Relation:DestinationPersonId xsi:type="xsd:int">0</Relation:DestinationPersonId>
     <Relation:RelationId xsi:type="xsd:int">0</Relation:RelationId>
     <Relation:Comment xsi:type="xsd:string"></Relation:Comment>
     <Relation:RelationDefinitionId xsi:type="xsd:int">0</Relation:RelationDefinitionId>
     <Relation:Reversed xsi:type="xsd:short">0</Relation:Reversed>
     <Relation:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:37:08Z</Relation:UpdatedDate>
     <Relation:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:37:08Z</Relation:CreatedDate>
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
    </Relation:ContactRelationEntity>
   </Relation:SaveContactRelation>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveContactRelation Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Relation="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Relation:SaveContactRelationResponse>
   <Relation:Response xsi:type="Relation:ContactRelationEntity">
    <Relation:SourceContactId xsi:type="xsd:int">0</Relation:SourceContactId>
    <Relation:SourcePersonId xsi:type="xsd:int">0</Relation:SourcePersonId>
    <Relation:DestinationContactId xsi:type="xsd:int">0</Relation:DestinationContactId>
    <Relation:DestinationPersonId xsi:type="xsd:int">0</Relation:DestinationPersonId>
    <Relation:RelationId xsi:type="xsd:int">0</Relation:RelationId>
    <Relation:Comment xsi:type="xsd:string"></Relation:Comment>
    <Relation:RelationDefinitionId xsi:type="xsd:int">0</Relation:RelationDefinitionId>
    <Relation:Reversed xsi:type="xsd:short">0</Relation:Reversed>
    <Relation:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:37:08Z</Relation:UpdatedDate>
    <Relation:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:37:08Z</Relation:CreatedDate>
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
  </Relation:SaveContactRelationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

