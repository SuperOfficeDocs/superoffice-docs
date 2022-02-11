---
title: Services88.ListAgent.CreateDefaultHierarchyEntity SOAP
generated: 1
uid: Services88-List-CreateDefaultHierarchyEntity
---

# Services88 List CreateDefaultHierarchyEntity

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.CreateDefaultHierarchyEntity">SuperOffice.Services88.IListAgent.CreateDefaultHierarchyEntity</see> method.

## CreateDefaultHierarchyEntity

Loading default values into a new HierarchyEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New HierarchyEntity with default values


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultHierarchyEntity Request

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
   <List:CreateDefaultHierarchyEntity>
   </List:CreateDefaultHierarchyEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultHierarchyEntity Response

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
  <List:CreateDefaultHierarchyEntityResponse>
   <List:Response xsi:type="List:HierarchyEntity">
    <List:HierarchyId xsi:type="xsd:int">0</List:HierarchyId>
    <List:Domain xsi:type="List:Domain">Unknown</List:Domain>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Fullname xsi:type="xsd:string"></List:Fullname>
    <List:ParentId xsi:type="xsd:int">0</List:ParentId>
    <List:Children xsi:type="List:ArrayOfHierarchyEntity">
     <List:HierarchyEntity xsi:type="List:HierarchyEntity">
      <List:HierarchyId xsi:type="xsd:int">0</List:HierarchyId>
      <List:Domain xsi:type="List:Domain">Unknown</List:Domain>
      <List:Name xsi:type="xsd:string"></List:Name>
      <List:Fullname xsi:type="xsd:string"></List:Fullname>
      <List:ParentId xsi:type="xsd:int">0</List:ParentId>
      <List:Children xsi:type="List:ArrayOfHierarchyEntity">
       <List:HierarchyEntity xsi:type="List:HierarchyEntity">
        <List:HierarchyId xsi:type="xsd:int">0</List:HierarchyId>
        <List:Domain xsi:type="List:Domain">Unknown</List:Domain>
        <List:Name xsi:type="xsd:string"></List:Name>
        <List:Fullname xsi:type="xsd:string"></List:Fullname>
        <List:ParentId xsi:type="xsd:int">0</List:ParentId>
        <List:Children xsi:type="List:ArrayOfHierarchyEntity">
         <List:HierarchyEntity xsi:type="List:HierarchyEntity">
          <List:HierarchyId xsi:nil="true"></List:HierarchyId>
          <List:Domain xsi:nil="true"></List:Domain>
          <List:Name xsi:type="xsd:string"></List:Name>
          <List:Fullname xsi:type="xsd:string"></List:Fullname>
          <List:ParentId xsi:nil="true"></List:ParentId>
          <List:Children xsi:nil="true"></List:Children>
          <List:Registered xsi:nil="true"></List:Registered>
          <List:RegisteredAssociateId xsi:nil="true"></List:RegisteredAssociateId>
          <List:Updated xsi:nil="true"></List:Updated>
          <List:UpdatedAssociateId xsi:nil="true"></List:UpdatedAssociateId>
         </List:HierarchyEntity>
        </List:Children>
        <List:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:44Z</List:Registered>
        <List:RegisteredAssociateId xsi:type="xsd:int">0</List:RegisteredAssociateId>
        <List:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:44Z</List:Updated>
        <List:UpdatedAssociateId xsi:type="xsd:int">0</List:UpdatedAssociateId>
       </List:HierarchyEntity>
      </List:Children>
      <List:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:44Z</List:Registered>
      <List:RegisteredAssociateId xsi:type="xsd:int">0</List:RegisteredAssociateId>
      <List:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:44Z</List:Updated>
      <List:UpdatedAssociateId xsi:type="xsd:int">0</List:UpdatedAssociateId>
     </List:HierarchyEntity>
    </List:Children>
    <List:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:44Z</List:Registered>
    <List:RegisteredAssociateId xsi:type="xsd:int">0</List:RegisteredAssociateId>
    <List:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:44Z</List:Updated>
    <List:UpdatedAssociateId xsi:type="xsd:int">0</List:UpdatedAssociateId>
   </List:Response>
  </List:CreateDefaultHierarchyEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

