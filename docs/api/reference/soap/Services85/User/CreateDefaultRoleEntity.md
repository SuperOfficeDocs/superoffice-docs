---
title: Services85.UserAgent.CreateDefaultRoleEntity SOAP
generated: 1
uid: Services85-User-CreateDefaultRoleEntity
---

# Services85 User CreateDefaultRoleEntity

SOAP request and response examples **Remote/Services85/User.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IUserAgent.CreateDefaultRoleEntity">SuperOffice.Services85.IUserAgent.CreateDefaultRoleEntity</see> method.

## CreateDefaultRoleEntity

Loading default values into a new RoleEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance

**Returns:** New RoleEntity with default values

[WSDL file for Services85/User](../Services85-User.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultRoleEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:CreateDefaultRoleEntity>
   </User:CreateDefaultRoleEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## CreateDefaultRoleEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <User:CreateDefaultRoleEntityResponse>
   <User:Response xsi:type="User:RoleEntity">
    <User:RoleId xsi:type="xsd:int">0</User:RoleId>
    <User:Name xsi:type="xsd:string"></User:Name>
    <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
    <User:RoleType xsi:type="User:RoleType">Employee</User:RoleType>
    <User:Deleted xsi:type="xsd:short">0</User:Deleted>
    <User:Rank xsi:type="xsd:short">0</User:Rank>
    <User:Created xsi:type="xsd:dateTime">2021-11-30T13:22:43Z</User:Created>
    <User:UseCategories xsi:type="xsd:short">0</User:UseCategories>
    <User:CreatedBy xsi:type="User:Associate">
     <User:AssociateId xsi:type="xsd:int">0</User:AssociateId>
     <User:Name xsi:type="xsd:string"></User:Name>
     <User:PersonId xsi:type="xsd:int">0</User:PersonId>
     <User:Rank xsi:type="xsd:short">0</User:Rank>
     <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
     <User:Type xsi:type="User:UserType">Unknown</User:Type>
     <User:GroupIdx xsi:type="xsd:int">0</User:GroupIdx>
     <User:FullName xsi:type="xsd:string"></User:FullName>
     <User:FormalName xsi:type="xsd:string"></User:FormalName>
     <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
     <User:EjUserId xsi:type="xsd:int">0</User:EjUserId>
    </User:CreatedBy>
    <User:Updated xsi:type="xsd:dateTime">2021-11-30T13:22:43Z</User:Updated>
    <User:UpdatedBy xsi:type="User:Associate">
     <User:AssociateId xsi:type="xsd:int">0</User:AssociateId>
     <User:Name xsi:type="xsd:string"></User:Name>
     <User:PersonId xsi:type="xsd:int">0</User:PersonId>
     <User:Rank xsi:type="xsd:short">0</User:Rank>
     <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
     <User:Type xsi:type="User:UserType">Unknown</User:Type>
     <User:GroupIdx xsi:type="xsd:int">0</User:GroupIdx>
     <User:FullName xsi:type="xsd:string"></User:FullName>
     <User:FormalName xsi:type="xsd:string"></User:FormalName>
     <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
     <User:EjUserId xsi:type="xsd:int">0</User:EjUserId>
    </User:UpdatedBy>
    <User:DataRights xsi:type="User:DataRights">
     <User:ColumnsInfo xsi:type="User:ArrayOfRelationToOwner">
      <User:RelationToOwner xsi:type="User:RelationToOwner">
       <User:Id xsi:type="xsd:int">0</User:Id>
       <User:Value xsi:type="xsd:string"></User:Value>
       <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
      </User:RelationToOwner>
     </User:ColumnsInfo>
     <User:RowsInfo xsi:type="User:ArrayOfEntityName">
      <User:EntityName xsi:type="User:EntityName">
       <User:TableName xsi:type="xsd:string"></User:TableName>
       <User:TableDescription xsi:type="xsd:string"></User:TableDescription>
      </User:EntityName>
     </User:RowsInfo>
     <User:Rights xsi:type="User:ArrayOfArrayOfDataRight">
      <User:ArrayOfDataRight xsi:type="User:ArrayOfDataRight">
       <User:DataRight xsi:type="User:DataRight">
        <User:Value xsi:type="xsd:string"></User:Value>
        <User:Description xsi:type="xsd:string"></User:Description>
       </User:DataRight>
      </User:ArrayOfDataRight>
     </User:Rights>
    </User:DataRights>
   </User:Response>
  </User:CreateDefaultRoleEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
