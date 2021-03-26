---
uid: services84-user-getallroles
title: Services84.UserAgent.GetAllRoles SOAP
Generated: true
---

# Services84 User GetAllRoles SOAP

SOAP request and response examples **Remote/Services84/User.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IUserAgent.GetAllRoles">SuperOffice.Services84.IUserAgent.GetAllRoles</see> method.

## GetAllRoles

Get a list of all roles for the given type of role. MDO List name = 'Roles', extra='0' (roleType)

* **roleType:** Type of role (Employee/External/Anonymous/System)

**Returns:** FunctionRight items with name and description. Code name for function right is in the extra-info property.


[WSDL file for Services84/User](../Services84-User.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllRoles Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:GetAllRoles>
    <User:RoleType xsi:type="User:RoleType">Employee</User:RoleType>
   </User:GetAllRoles>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllRoles Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <User:GetAllRolesResponse>
   <User:Response xsi:type="User:ArrayOfSelectableMDOListItem">
    <User:SelectableMDOListItem xsi:type="User:SelectableMDOListItem">
     <User:Id xsi:type="xsd:int">0</User:Id>
     <User:Name xsi:type="xsd:string"></User:Name>
     <User:ToolTip xsi:type="xsd:string"></User:ToolTip>
     <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
     <User:Rank xsi:type="xsd:int">0</User:Rank>
     <User:Type xsi:type="xsd:string"></User:Type>
     <User:ColorBlock xsi:type="xsd:int">0</User:ColorBlock>
     <User:IconHint xsi:type="xsd:string"></User:IconHint>
     <User:Selected xsi:type="xsd:boolean">false</User:Selected>
     <User:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:38Z</User:LastChanged>
     <User:ChildItems xsi:type="User:ArrayOfSelectableMDOListItem">
      <User:SelectableMDOListItem xsi:type="User:SelectableMDOListItem">
       <User:Id xsi:type="xsd:int">0</User:Id>
       <User:Name xsi:type="xsd:string"></User:Name>
       <User:ToolTip xsi:type="xsd:string"></User:ToolTip>
       <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
       <User:Rank xsi:type="xsd:int">0</User:Rank>
       <User:Type xsi:type="xsd:string"></User:Type>
       <User:ColorBlock xsi:type="xsd:int">0</User:ColorBlock>
       <User:IconHint xsi:type="xsd:string"></User:IconHint>
       <User:Selected xsi:type="xsd:boolean">false</User:Selected>
       <User:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:38Z</User:LastChanged>
       <User:ChildItems xsi:type="User:ArrayOfSelectableMDOListItem">
        <User:SelectableMDOListItem xsi:type="User:SelectableMDOListItem">
         <User:Id xsi:type="xsd:int">0</User:Id>
         <User:Name xsi:type="xsd:string"></User:Name>
         <User:ToolTip xsi:type="xsd:string"></User:ToolTip>
         <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
         <User:Rank xsi:type="xsd:int">0</User:Rank>
         <User:Type xsi:type="xsd:string"></User:Type>
         <User:ColorBlock xsi:type="xsd:int">0</User:ColorBlock>
         <User:IconHint xsi:type="xsd:string"></User:IconHint>
         <User:Selected xsi:type="xsd:boolean">false</User:Selected>
         <User:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:38Z</User:LastChanged>
         <User:ChildItems xsi:type="User:ArrayOfSelectableMDOListItem">
          <User:SelectableMDOListItem xsi:nil="true"></User:SelectableMDOListItem>
         </User:ChildItems>
         <User:ExtraInfo xsi:type="xsd:string"></User:ExtraInfo>
         <User:StyleHint xsi:type="xsd:string"></User:StyleHint>
         <User:Hidden xsi:type="xsd:boolean">false</User:Hidden>
         <User:FullName xsi:type="xsd:string"></User:FullName>
        </User:SelectableMDOListItem>
       </User:ChildItems>
       <User:ExtraInfo xsi:type="xsd:string"></User:ExtraInfo>
       <User:StyleHint xsi:type="xsd:string"></User:StyleHint>
       <User:Hidden xsi:type="xsd:boolean">false</User:Hidden>
       <User:FullName xsi:type="xsd:string"></User:FullName>
      </User:SelectableMDOListItem>
     </User:ChildItems>
     <User:ExtraInfo xsi:type="xsd:string"></User:ExtraInfo>
     <User:StyleHint xsi:type="xsd:string"></User:StyleHint>
     <User:Hidden xsi:type="xsd:boolean">false</User:Hidden>
     <User:FullName xsi:type="xsd:string"></User:FullName>
    </User:SelectableMDOListItem>
   </User:Response>
  </User:GetAllRolesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

