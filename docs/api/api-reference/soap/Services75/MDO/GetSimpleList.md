---
uid: services75-mdo-getsimplelist
title: Services75.MDOAgent.GetSimpleList SOAP
Generated: true
---

# Services75 MDO GetSimpleList SOAP

SOAP request and response examples **Remote/Services75/MDO.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IMDOAgent.GetSimpleList">SuperOffice.Services75.IMDOAgent.GetSimpleList</see> method.

## GetSimpleList

Method returns a simple flat MDO List.

* **name:** Conceptual name of the MDO list-

**Returns:** Array of MDOListItem


[WSDL file for Services75/MDO](../Services75-MDO.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSimpleList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <MDO:ApplicationToken>1234567-1234-9876</MDO:ApplicationToken>
  <MDO:Credentials>
    <MDO:Ticket>7T:1234abcxyzExample==</MDO:Ticket>
  </MDO:Credentials>
 <SOAP-ENV:Body>
   <MDO:GetSimpleList>
    <MDO:Name xsi:type="xsd:string"></MDO:Name>
   </MDO:GetSimpleList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSimpleList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <MDO:GetSimpleListResponse>
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
        </MDO:MDOListItem>
       </MDO:ChildItems>
       <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
       <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
       <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
       <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
      </MDO:MDOListItem>
     </MDO:ChildItems>
     <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
     <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
     <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
     <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
    </MDO:MDOListItem>
   </MDO:Response>
  </MDO:GetSimpleListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

