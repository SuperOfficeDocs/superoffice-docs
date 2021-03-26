---
uid: services85-selection-createtemporaryselectionfromids
title: Services85.SelectionAgent.CreateTemporarySelectionFromIds SOAP
Generated: true
---

# Services85 Selection CreateTemporarySelectionFromIds SOAP

SOAP request and response examples **Remote/Services85/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISelectionAgent.CreateTemporarySelectionFromIds">SuperOffice.Services85.ISelectionAgent.CreateTemporarySelectionFromIds</see> method.

## CreateTemporarySelectionFromIds

Creates a temporary selection with members from a collection of entity id's.

* **ids:** A collection of Ids to copy into the temporary selection as members. The ids are primary keys of entities defined by the targetTableNumber parameter.
* **targetTableNumber:** The type of selection to create.

**Returns:** Returns the newly created SelectionEntity.


[WSDL file for Services85/Selection](../Services85-Selection.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateTemporarySelectionFromIds Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:CreateTemporarySelectionFromIds>
    <Selection:Ids xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
    </Selection:Ids>
    <Selection:TargetTableNumber xsi:type="xsd:int">0</Selection:TargetTableNumber>
   </Selection:CreateTemporarySelectionFromIds>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateTemporarySelectionFromIds Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Selection:CreateTemporarySelectionFromIdsResponse>
   <Selection:Response xsi:type="Selection:SelectionEntity">
    <Selection:Description xsi:type="xsd:string"></Selection:Description>
    <Selection:Postit xsi:type="xsd:string"></Selection:Postit>
    <Selection:Associate xsi:type="Selection:Associate">
     <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
     <Selection:Name xsi:type="xsd:string"></Selection:Name>
     <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
     <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
     <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
     <Selection:Type xsi:type="Selection:UserType">Unknown</Selection:Type>
     <Selection:GroupIdx xsi:type="xsd:int">0</Selection:GroupIdx>
     <Selection:FullName xsi:type="xsd:string"></Selection:FullName>
     <Selection:FormalName xsi:type="xsd:string"></Selection:FormalName>
     <Selection:Deleted xsi:type="xsd:boolean">false</Selection:Deleted>
     <Selection:EjUserId xsi:type="xsd:int">0</Selection:EjUserId>
    </Selection:Associate>
    <Selection:CreatedBy xsi:type="Selection:Associate">
     <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
     <Selection:Name xsi:type="xsd:string"></Selection:Name>
     <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
     <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
     <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
     <Selection:Type xsi:type="Selection:UserType">Unknown</Selection:Type>
     <Selection:GroupIdx xsi:type="xsd:int">0</Selection:GroupIdx>
     <Selection:FullName xsi:type="xsd:string"></Selection:FullName>
     <Selection:FormalName xsi:type="xsd:string"></Selection:FormalName>
     <Selection:Deleted xsi:type="xsd:boolean">false</Selection:Deleted>
     <Selection:EjUserId xsi:type="xsd:int">0</Selection:EjUserId>
    </Selection:CreatedBy>
    <Selection:UpdatedBy xsi:type="Selection:Associate">
     <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
     <Selection:Name xsi:type="xsd:string"></Selection:Name>
     <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
     <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
     <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
     <Selection:Type xsi:type="Selection:UserType">Unknown</Selection:Type>
     <Selection:GroupIdx xsi:type="xsd:int">0</Selection:GroupIdx>
     <Selection:FullName xsi:type="xsd:string"></Selection:FullName>
     <Selection:FormalName xsi:type="xsd:string"></Selection:FormalName>
     <Selection:Deleted xsi:type="xsd:boolean">false</Selection:Deleted>
     <Selection:EjUserId xsi:type="xsd:int">0</Selection:EjUserId>
    </Selection:UpdatedBy>
    <Selection:SelectionCategory xsi:type="Selection:SelectionCategory">
     <Selection:Id xsi:type="xsd:int">0</Selection:Id>
     <Selection:Value xsi:type="xsd:string"></Selection:Value>
     <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
    </Selection:SelectionCategory>
    <Selection:GroupIdx xsi:type="xsd:int">0</Selection:GroupIdx>
    <Selection:IncludePerson xsi:type="xsd:int">0</Selection:IncludePerson>
    <Selection:MemberCount xsi:type="xsd:unsignedInt">0</Selection:MemberCount>
    <Selection:Name xsi:type="xsd:string"></Selection:Name>
    <Selection:PostitTextId xsi:type="xsd:int">0</Selection:PostitTextId>
    <Selection:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:58Z</Selection:CreatedDate>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:SoundEx xsi:type="xsd:string"></Selection:SoundEx>
    <Selection:Source xsi:type="xsd:short">0</Selection:Source>
    <Selection:TextId xsi:type="xsd:int">0</Selection:TextId>
    <Selection:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:58Z</Selection:UpdatedDate>
    <Selection:UpdatedCount xsi:type="xsd:short">0</Selection:UpdatedCount>
    <Selection:Visibility xsi:type="xsd:short">0</Selection:Visibility>
    <Selection:SelectionType xsi:type="Selection:SelectionType">Static</Selection:SelectionType>
    <Selection:CompanyUnique xsi:type="xsd:boolean">false</Selection:CompanyUnique>
    <Selection:TargetTableNumber xsi:type="xsd:int">0</Selection:TargetTableNumber>
    <Selection:TargetTableName xsi:type="xsd:string"></Selection:TargetTableName>
    <Selection:Completed xsi:type="xsd:boolean">false</Selection:Completed>
    <Selection:LeftSelectionId xsi:type="xsd:int">0</Selection:LeftSelectionId>
    <Selection:RightSelectionId xsi:type="xsd:int">0</Selection:RightSelectionId>
    <Selection:SelectionUnionType xsi:type="Selection:SelectionUnionType">Unknown</Selection:SelectionUnionType>
    <Selection:VisibleFor xsi:type="Selection:ArrayOfVisibleFor">
     <Selection:VisibleFor xsi:type="Selection:VisibleFor">
      <Selection:VisibleId xsi:type="xsd:int">0</Selection:VisibleId>
      <Selection:Visibility xsi:type="Selection:Visibility">All</Selection:Visibility>
      <Selection:DisplayValue xsi:type="xsd:string"></Selection:DisplayValue>
     </Selection:VisibleFor>
    </Selection:VisibleFor>
   </Selection:Response>
  </Selection:CreateTemporarySelectionFromIdsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

