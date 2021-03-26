---
uid: services86-user-getallfunctionalrights
title: Services86.UserAgent.GetAllFunctionalRights SOAP
Generated: true
---

# Services86 User GetAllFunctionalRights SOAP

SOAP request and response examples **Remote/Services86/User.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IUserAgent.GetAllFunctionalRights">SuperOffice.Services86.IUserAgent.GetAllFunctionalRights</see> method.

## GetAllFunctionalRights

Get a list of all functional rights for the given type of role. MDO List name = 'FunctionRights', extra='roleType=0'
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **roleType:** Type of role (Employee/External/Anonymous/System)

**Returns:** FunctionRight items with name and description. Code name for function right is in the extra-info property.


[WSDL file for Services86/User](../Services86-User.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllFunctionalRights Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:GetAllFunctionalRights>
    <User:RoleType xsi:type="User:RoleType">Employee</User:RoleType>
   </User:GetAllFunctionalRights>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllFunctionalRights Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <User:GetAllFunctionalRightsResponse>
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
     <User:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:36:23Z</User:LastChanged>
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
       <User:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:36:23Z</User:LastChanged>
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
         <User:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:36:23Z</User:LastChanged>
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
  </User:GetAllFunctionalRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

