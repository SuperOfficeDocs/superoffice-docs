---
title: Services84.UserAgent.GetFunctionalRights SOAP
generated: 1
uid: Services84-User-GetFunctionalRights
---

# Services84 User GetFunctionalRights

SOAP request and response examples **Remote/Services84/User.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IUserAgent.GetFunctionalRights">SuperOffice.Services84.IUserAgent.GetFunctionalRights</see> method.

## GetFunctionalRights

Get all functional rights for the given role. Functional rights not set on the role are not included. MDO List name = 'FunctionRights', extra='role=123'

* **roleId:** The role id to get the functional rights for.

**Returns:** FunctionRight items with name and description. Code name for function right is in the extra-info property.

[WSDL file for Services84/User](../Services84-User.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFunctionalRights Request

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
   <User:GetFunctionalRights>
    <User:RoleId xsi:type="xsd:int">0</User:RoleId>
   </User:GetFunctionalRights>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetFunctionalRights Response

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
  <User:GetFunctionalRightsResponse>
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
     <User:LastChanged xsi:type="xsd:dateTime">2022-08-26T08:51:57Z</User:LastChanged>
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
       <User:LastChanged xsi:type="xsd:dateTime">2022-08-26T08:51:57Z</User:LastChanged>
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
         <User:LastChanged xsi:type="xsd:dateTime">2022-08-26T08:51:57Z</User:LastChanged>
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
  </User:GetFunctionalRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
