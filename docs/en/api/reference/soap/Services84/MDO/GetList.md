---
title: Services84.MDOAgent.GetList SOAP
generated: 1
uid: Services84-MDO-GetList
---

# Services84 MDO GetList

SOAP request and response examples **Remote/Services84/MDO.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IMDOAgent.GetList">SuperOffice.Services84.IMDOAgent.GetList</see> method.

## GetList

[WSDL file for Services84/MDO](../Services84-MDO.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <MDO:ApplicationToken>1234567-1234-9876</MDO:ApplicationToken>
  <MDO:Credentials>
    <MDO:Ticket>7T:1234abcxyzExample==</MDO:Ticket>
  </MDO:Credentials>
 <SOAP-ENV:Body>
   <MDO:GetList>
    <MDO:Name xsi:type="xsd:string"></MDO:Name>
    <MDO:ForceFlatList xsi:type="xsd:boolean">false</MDO:ForceFlatList>
    <MDO:AdditionalInfo xsi:type="xsd:string"></MDO:AdditionalInfo>
    <MDO:OnlyHistory xsi:type="xsd:boolean">false</MDO:OnlyHistory>
   </MDO:GetList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <MDO:GetListResponse>
   <MDO:Response xsi:type="MDO:ArrayOfMDOListItem">
    <MDO:MDOListItem xsi:type="MDO:MDOListItem">
     <MDO:Id xsi:type="xsd:int">0</MDO:Id>
     <MDO:Name xsi:type="xsd:string"></MDO:Name>
     <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
     <MDO:Deleted xsi:type="xsd:boolean">false</MDO:Deleted>
     <MDO:Rank xsi:type="xsd:int">0</MDO:Rank>
     <MDO:Type xsi:type="xsd:string"></MDO:Type>
     <MDO:ChildItems xsi:type="MDO:ArrayOfMDOListItem">
      <MDO:MDOListItem xsi:type="MDO:MDOListItem">
       <MDO:Id xsi:type="xsd:int">0</MDO:Id>
       <MDO:Name xsi:type="xsd:string"></MDO:Name>
       <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
       <MDO:Deleted xsi:type="xsd:boolean">false</MDO:Deleted>
       <MDO:Rank xsi:type="xsd:int">0</MDO:Rank>
       <MDO:Type xsi:type="xsd:string"></MDO:Type>
       <MDO:ChildItems xsi:type="MDO:ArrayOfMDOListItem">
        <MDO:MDOListItem xsi:type="MDO:MDOListItem">
         <MDO:Id xsi:type="xsd:int">0</MDO:Id>
         <MDO:Name xsi:type="xsd:string"></MDO:Name>
         <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
         <MDO:Deleted xsi:type="xsd:boolean">false</MDO:Deleted>
         <MDO:Rank xsi:type="xsd:int">0</MDO:Rank>
         <MDO:Type xsi:type="xsd:string"></MDO:Type>
         <MDO:ChildItems xsi:type="MDO:ArrayOfMDOListItem">
          <MDO:MDOListItem xsi:nil="true"></MDO:MDOListItem>
         </MDO:ChildItems>
         <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
         <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
         <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
         <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
         <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
        </MDO:MDOListItem>
       </MDO:ChildItems>
       <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
       <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
       <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
       <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
       <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
      </MDO:MDOListItem>
     </MDO:ChildItems>
     <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
     <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
     <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
     <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
     <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
    </MDO:MDOListItem>
   </MDO:Response>
  </MDO:GetListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
