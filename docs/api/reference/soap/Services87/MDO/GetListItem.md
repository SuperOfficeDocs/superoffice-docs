---
title: Services87.MDOAgent.GetListItem SOAP
generated: 1
uid: Services87-MDO-GetListItem
---

# Services87 MDO GetListItem

SOAP request and response examples **Remote/Services87/MDO.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IMDOAgent.GetListItem">SuperOffice.Services87.IMDOAgent.GetListItem</see> method.

## GetListItem

Returns a single list item

* **listName:** Conceptual name of the MDO list
* **id:** Id of list item

**Returns:** Single MDO list item


[WSDL file for Services87/MDO](../Services87-MDO.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetListItem Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <MDO:ApplicationToken>1234567-1234-9876</MDO:ApplicationToken>
  <MDO:Credentials>
    <MDO:Ticket>7T:1234abcxyzExample==</MDO:Ticket>
  </MDO:Credentials>
 <SOAP-ENV:Body>
   <MDO:GetListItem>
    <MDO:ListName xsi:type="xsd:string"></MDO:ListName>
    <MDO:Id xsi:type="xsd:int">0</MDO:Id>
   </MDO:GetListItem>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetListItem Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <MDO:GetListItemResponse>
   <MDO:Response xsi:type="MDO:MDOListItem">
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
         <MDO:MDOListItem xsi:type="MDO:MDOListItem">
          <MDO:Id xsi:nil="true"></MDO:Id>
          <MDO:Name xsi:type="xsd:string"></MDO:Name>
          <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
          <MDO:Deleted xsi:nil="true"></MDO:Deleted>
          <MDO:Rank xsi:nil="true"></MDO:Rank>
          <MDO:Type xsi:type="xsd:string"></MDO:Type>
          <MDO:ChildItems xsi:nil="true"></MDO:ChildItems>
          <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
          <MDO:ColorBlock xsi:nil="true"></MDO:ColorBlock>
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
    </MDO:ChildItems>
    <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
    <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
    <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
    <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
    <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
   </MDO:Response>
  </MDO:GetListItemResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

