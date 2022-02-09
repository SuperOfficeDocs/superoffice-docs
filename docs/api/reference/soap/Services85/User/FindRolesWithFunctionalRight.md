---
title: Services85.UserAgent.FindRolesWithFunctionalRight SOAP
generated: 1
uid: Services85-User-FindRolesWithFunctionalRight
---

# Services85 User FindRolesWithFunctionalRight

SOAP request and response examples **Remote/Services85/User.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IUserAgent.FindRolesWithFunctionalRight">SuperOffice.Services85.IUserAgent.FindRolesWithFunctionalRight</see> method.

## FindRolesWithFunctionalRight

Find all roles with a given functional right. The roles matched must contain the specified functional right.

* **functionalRightName:** Functional right name to search for

**Returns:** Roles that contains the given functional right


[WSDL file for Services85/User](../Services85-User.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindRolesWithFunctionalRight Request

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
   <User:FindRolesWithFunctionalRight>
    <User:FunctionalRightName xsi:type="xsd:string"></User:FunctionalRightName>
   </User:FindRolesWithFunctionalRight>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindRolesWithFunctionalRight Response

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
  <User:FindRolesWithFunctionalRightResponse>
   <User:Response xsi:type="User:ArrayOfMDOListItem">
    <User:MDOListItem xsi:type="User:MDOListItem">
     <User:Id xsi:type="xsd:int">0</User:Id>
     <User:Name xsi:type="xsd:string"></User:Name>
     <User:ToolTip xsi:type="xsd:string"></User:ToolTip>
     <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
     <User:Rank xsi:type="xsd:int">0</User:Rank>
     <User:Type xsi:type="xsd:string"></User:Type>
     <User:ChildItems xsi:type="User:ArrayOfMDOListItem">
      <User:MDOListItem xsi:type="User:MDOListItem">
       <User:Id xsi:type="xsd:int">0</User:Id>
       <User:Name xsi:type="xsd:string"></User:Name>
       <User:ToolTip xsi:type="xsd:string"></User:ToolTip>
       <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
       <User:Rank xsi:type="xsd:int">0</User:Rank>
       <User:Type xsi:type="xsd:string"></User:Type>
       <User:ChildItems xsi:type="User:ArrayOfMDOListItem">
        <User:MDOListItem xsi:type="User:MDOListItem">
         <User:Id xsi:type="xsd:int">0</User:Id>
         <User:Name xsi:type="xsd:string"></User:Name>
         <User:ToolTip xsi:type="xsd:string"></User:ToolTip>
         <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
         <User:Rank xsi:type="xsd:int">0</User:Rank>
         <User:Type xsi:type="xsd:string"></User:Type>
         <User:ChildItems xsi:type="User:ArrayOfMDOListItem">
          <User:MDOListItem xsi:nil="true"></User:MDOListItem>
         </User:ChildItems>
         <User:IconHint xsi:type="xsd:string"></User:IconHint>
         <User:ColorBlock xsi:type="xsd:int">0</User:ColorBlock>
         <User:ExtraInfo xsi:type="xsd:string"></User:ExtraInfo>
         <User:StyleHint xsi:type="xsd:string"></User:StyleHint>
         <User:FullName xsi:type="xsd:string"></User:FullName>
        </User:MDOListItem>
       </User:ChildItems>
       <User:IconHint xsi:type="xsd:string"></User:IconHint>
       <User:ColorBlock xsi:type="xsd:int">0</User:ColorBlock>
       <User:ExtraInfo xsi:type="xsd:string"></User:ExtraInfo>
       <User:StyleHint xsi:type="xsd:string"></User:StyleHint>
       <User:FullName xsi:type="xsd:string"></User:FullName>
      </User:MDOListItem>
     </User:ChildItems>
     <User:IconHint xsi:type="xsd:string"></User:IconHint>
     <User:ColorBlock xsi:type="xsd:int">0</User:ColorBlock>
     <User:ExtraInfo xsi:type="xsd:string"></User:ExtraInfo>
     <User:StyleHint xsi:type="xsd:string"></User:StyleHint>
     <User:FullName xsi:type="xsd:string"></User:FullName>
    </User:MDOListItem>
   </User:Response>
  </User:FindRolesWithFunctionalRightResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

