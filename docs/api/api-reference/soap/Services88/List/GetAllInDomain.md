---
uid: services88-list-getallindomain
title: Services88.ListAgent.GetAllInDomain SOAP
Generated: true
---

# Services88 List GetAllInDomain SOAP

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.GetAllInDomain">SuperOffice.Services88.IListAgent.GetAllInDomain</see> method.

## GetAllInDomain

Get all items in a domain

* **domain:** Type of items to get (scripts, extra tables, etc)
* **children:** Include sub-items?

**Returns:** All items and child items within a domain


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllInDomain Request

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
   <List:GetAllInDomain>
    <List:Domain xsi:type="List:Domain">Unknown</List:Domain>
    <List:Children xsi:type="xsd:boolean">false</List:Children>
   </List:GetAllInDomain>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllInDomain Response

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
  <List:GetAllInDomainResponse>
   <List:Response xsi:type="List:ArrayOfHierarchyEntity">
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
         <List:HierarchyId xsi:type="xsd:int">0</List:HierarchyId>
         <List:Domain xsi:type="List:Domain">Unknown</List:Domain>
         <List:Name xsi:type="xsd:string"></List:Name>
         <List:Fullname xsi:type="xsd:string"></List:Fullname>
         <List:ParentId xsi:type="xsd:int">0</List:ParentId>
         <List:Children xsi:type="List:ArrayOfHierarchyEntity">
          <List:HierarchyEntity xsi:nil="true"></List:HierarchyEntity>
         </List:Children>
         <List:Registered xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:Registered>
         <List:RegisteredAssociateId xsi:type="xsd:int">0</List:RegisteredAssociateId>
         <List:Updated xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:Updated>
         <List:UpdatedAssociateId xsi:type="xsd:int">0</List:UpdatedAssociateId>
        </List:HierarchyEntity>
       </List:Children>
       <List:Registered xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:Registered>
       <List:RegisteredAssociateId xsi:type="xsd:int">0</List:RegisteredAssociateId>
       <List:Updated xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:Updated>
       <List:UpdatedAssociateId xsi:type="xsd:int">0</List:UpdatedAssociateId>
      </List:HierarchyEntity>
     </List:Children>
     <List:Registered xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:Registered>
     <List:RegisteredAssociateId xsi:type="xsd:int">0</List:RegisteredAssociateId>
     <List:Updated xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:Updated>
     <List:UpdatedAssociateId xsi:type="xsd:int">0</List:UpdatedAssociateId>
    </List:HierarchyEntity>
   </List:Response>
  </List:GetAllInDomainResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

