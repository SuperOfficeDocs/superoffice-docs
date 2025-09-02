---
title: Services88.ListAgent.UpdateCategoryMemberships SOAP
generated: true
uid: Services88-List-UpdateCategoryMemberships
content_type: reference
---

# Services88 List UpdateCategoryMemberships

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.UpdateCategoryMemberships">SuperOffice.Services88.IListAgent.UpdateCategoryMemberships</see> method.

## UpdateCategoryMemberships





[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateCategoryMemberships Request

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
   <List:UpdateCategoryMemberships>
    <List:TicketCategoryId xsi:type="xsd:int">0</List:TicketCategoryId>
    <List:MembershipsToAdd xsi:type="List:ArrayOfTicketCategoryMembershipEntity">
     <List:TicketCategoryMembershipEntity xsi:type="List:TicketCategoryMembershipEntity">
      <List:User xsi:type="List:Associate">
       <List:AssociateId xsi:type="xsd:int">0</List:AssociateId>
       <List:Name xsi:type="xsd:string"></List:Name>
       <List:PersonId xsi:type="xsd:int">0</List:PersonId>
       <List:Rank xsi:type="xsd:short">0</List:Rank>
       <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
       <List:Type xsi:type="List:UserType">Unknown</List:Type>
       <List:GroupIdx xsi:type="xsd:int">0</List:GroupIdx>
       <List:FullName xsi:type="xsd:string"></List:FullName>
       <List:FormalName xsi:type="xsd:string"></List:FormalName>
       <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
       <List:EjUserId xsi:type="xsd:int">0</List:EjUserId>
       <List:UserName xsi:type="xsd:string"></List:UserName>
       <List:ExtraFields xsi:type="List:StringDictionary">
        <List:StringKeyValuePair>
         <List:Key xsi:type="xsd:string"></List:Key>
         <List:Value xsi:type="xsd:string"></List:Value>
        </List:StringKeyValuePair>
       </List:ExtraFields>
       <List:CustomFields xsi:type="List:StringDictionary">
        <List:StringKeyValuePair>
         <List:Key xsi:type="xsd:string"></List:Key>
         <List:Value xsi:type="xsd:string"></List:Value>
        </List:StringKeyValuePair>
       </List:CustomFields>
      </List:User>
      <List:Weight xsi:type="xsd:short">0</List:Weight>
     </List:TicketCategoryMembershipEntity>
    </List:MembershipsToAdd>
    <List:MembershipsToUpdate xsi:type="List:ArrayOfTicketCategoryMembershipEntity">
     <List:TicketCategoryMembershipEntity xsi:type="List:TicketCategoryMembershipEntity">
      <List:User xsi:type="List:Associate">
       <List:AssociateId xsi:type="xsd:int">0</List:AssociateId>
       <List:Name xsi:type="xsd:string"></List:Name>
       <List:PersonId xsi:type="xsd:int">0</List:PersonId>
       <List:Rank xsi:type="xsd:short">0</List:Rank>
       <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
       <List:Type xsi:type="List:UserType">Unknown</List:Type>
       <List:GroupIdx xsi:type="xsd:int">0</List:GroupIdx>
       <List:FullName xsi:type="xsd:string"></List:FullName>
       <List:FormalName xsi:type="xsd:string"></List:FormalName>
       <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
       <List:EjUserId xsi:type="xsd:int">0</List:EjUserId>
       <List:UserName xsi:type="xsd:string"></List:UserName>
       <List:ExtraFields xsi:type="List:StringDictionary">
        <List:StringKeyValuePair>
         <List:Key xsi:type="xsd:string"></List:Key>
         <List:Value xsi:type="xsd:string"></List:Value>
        </List:StringKeyValuePair>
       </List:ExtraFields>
       <List:CustomFields xsi:type="List:StringDictionary">
        <List:StringKeyValuePair>
         <List:Key xsi:type="xsd:string"></List:Key>
         <List:Value xsi:type="xsd:string"></List:Value>
        </List:StringKeyValuePair>
       </List:CustomFields>
      </List:User>
      <List:Weight xsi:type="xsd:short">0</List:Weight>
     </List:TicketCategoryMembershipEntity>
    </List:MembershipsToUpdate>
    <List:MembershipsToDelete xsi:type="List:ArrayOfTicketCategoryMembershipEntity">
     <List:TicketCategoryMembershipEntity xsi:type="List:TicketCategoryMembershipEntity">
      <List:User xsi:type="List:Associate">
       <List:AssociateId xsi:type="xsd:int">0</List:AssociateId>
       <List:Name xsi:type="xsd:string"></List:Name>
       <List:PersonId xsi:type="xsd:int">0</List:PersonId>
       <List:Rank xsi:type="xsd:short">0</List:Rank>
       <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
       <List:Type xsi:type="List:UserType">Unknown</List:Type>
       <List:GroupIdx xsi:type="xsd:int">0</List:GroupIdx>
       <List:FullName xsi:type="xsd:string"></List:FullName>
       <List:FormalName xsi:type="xsd:string"></List:FormalName>
       <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
       <List:EjUserId xsi:type="xsd:int">0</List:EjUserId>
       <List:UserName xsi:type="xsd:string"></List:UserName>
       <List:ExtraFields xsi:type="List:StringDictionary">
        <List:StringKeyValuePair>
         <List:Key xsi:type="xsd:string"></List:Key>
         <List:Value xsi:type="xsd:string"></List:Value>
        </List:StringKeyValuePair>
       </List:ExtraFields>
       <List:CustomFields xsi:type="List:StringDictionary">
        <List:StringKeyValuePair>
         <List:Key xsi:type="xsd:string"></List:Key>
         <List:Value xsi:type="xsd:string"></List:Value>
        </List:StringKeyValuePair>
       </List:CustomFields>
      </List:User>
      <List:Weight xsi:type="xsd:short">0</List:Weight>
     </List:TicketCategoryMembershipEntity>
    </List:MembershipsToDelete>
   </List:UpdateCategoryMemberships>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateCategoryMemberships Response

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
  <List:UpdateCategoryMembershipsResponse>
  </List:UpdateCategoryMembershipsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

