---
uid: services84-mdo-setselected
title: Services84.MDOAgent.SetSelected SOAP
Generated: true
---

# Services84 MDO SetSelected SOAP

SOAP request and response examples **Remote/Services84/MDO.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IMDOAgent.SetSelected">SuperOffice.Services84.IMDOAgent.SetSelected</see> method.

## SetSelected

Saves the selected values as selected by their given list representation.

* **name:** Conceptual name of the MDO list
* **additionalInfo:** Additional info to the MDO provider
* **selectableMDOList:** Items to be updated

**Returns:** Array of updated SelectableMDOListItems


[WSDL file for Services84/MDO](../Services84-MDO.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetSelected Request

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
   <MDO:SetSelected>
    <MDO:Name xsi:type="xsd:string"></MDO:Name>
    <MDO:AdditionalInfo xsi:type="xsd:string"></MDO:AdditionalInfo>
    <MDO:SelectableMDOList xsi:type="MDO:ArrayOfSelectableMDOListItem">
     <MDO:SelectableMDOListItem xsi:type="MDO:SelectableMDOListItem">
      <MDO:Id xsi:type="xsd:int">0</MDO:Id>
      <MDO:Name xsi:type="xsd:string"></MDO:Name>
      <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
      <MDO:Deleted xsi:type="xsd:boolean">false</MDO:Deleted>
      <MDO:Rank xsi:type="xsd:int">0</MDO:Rank>
      <MDO:Type xsi:type="xsd:string"></MDO:Type>
      <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
      <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
      <MDO:Selected xsi:type="xsd:boolean">false</MDO:Selected>
      <MDO:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:30Z</MDO:LastChanged>
      <MDO:ChildItems xsi:type="MDO:ArrayOfSelectableMDOListItem">
       <MDO:SelectableMDOListItem xsi:type="MDO:SelectableMDOListItem">
        <MDO:Id xsi:type="xsd:int">0</MDO:Id>
        <MDO:Name xsi:type="xsd:string"></MDO:Name>
        <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
        <MDO:Deleted xsi:type="xsd:boolean">false</MDO:Deleted>
        <MDO:Rank xsi:type="xsd:int">0</MDO:Rank>
        <MDO:Type xsi:type="xsd:string"></MDO:Type>
        <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
        <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
        <MDO:Selected xsi:type="xsd:boolean">false</MDO:Selected>
        <MDO:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:30Z</MDO:LastChanged>
        <MDO:ChildItems xsi:type="MDO:ArrayOfSelectableMDOListItem">
         <MDO:SelectableMDOListItem xsi:type="MDO:SelectableMDOListItem">
          <MDO:Id xsi:nil="true"></MDO:Id>
          <MDO:Name xsi:type="xsd:string"></MDO:Name>
          <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
          <MDO:Deleted xsi:nil="true"></MDO:Deleted>
          <MDO:Rank xsi:nil="true"></MDO:Rank>
          <MDO:Type xsi:type="xsd:string"></MDO:Type>
          <MDO:ColorBlock xsi:nil="true"></MDO:ColorBlock>
          <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
          <MDO:Selected xsi:nil="true"></MDO:Selected>
          <MDO:LastChanged xsi:nil="true"></MDO:LastChanged>
          <MDO:ChildItems xsi:nil="true"></MDO:ChildItems>
          <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
          <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
          <MDO:Hidden xsi:nil="true"></MDO:Hidden>
          <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
         </MDO:SelectableMDOListItem>
        </MDO:ChildItems>
        <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
        <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
        <MDO:Hidden xsi:type="xsd:boolean">false</MDO:Hidden>
        <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
       </MDO:SelectableMDOListItem>
      </MDO:ChildItems>
      <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
      <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
      <MDO:Hidden xsi:type="xsd:boolean">false</MDO:Hidden>
      <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
     </MDO:SelectableMDOListItem>
    </MDO:SelectableMDOList>
   </MDO:SetSelected>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetSelected Response

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
  <MDO:SetSelectedResponse>
   <MDO:Response xsi:type="MDO:ArrayOfSelectableMDOListItem">
    <MDO:SelectableMDOListItem xsi:type="MDO:SelectableMDOListItem">
     <MDO:Id xsi:type="xsd:int">0</MDO:Id>
     <MDO:Name xsi:type="xsd:string"></MDO:Name>
     <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
     <MDO:Deleted xsi:type="xsd:boolean">false</MDO:Deleted>
     <MDO:Rank xsi:type="xsd:int">0</MDO:Rank>
     <MDO:Type xsi:type="xsd:string"></MDO:Type>
     <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
     <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
     <MDO:Selected xsi:type="xsd:boolean">false</MDO:Selected>
     <MDO:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:30Z</MDO:LastChanged>
     <MDO:ChildItems xsi:type="MDO:ArrayOfSelectableMDOListItem">
      <MDO:SelectableMDOListItem xsi:type="MDO:SelectableMDOListItem">
       <MDO:Id xsi:type="xsd:int">0</MDO:Id>
       <MDO:Name xsi:type="xsd:string"></MDO:Name>
       <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
       <MDO:Deleted xsi:type="xsd:boolean">false</MDO:Deleted>
       <MDO:Rank xsi:type="xsd:int">0</MDO:Rank>
       <MDO:Type xsi:type="xsd:string"></MDO:Type>
       <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
       <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
       <MDO:Selected xsi:type="xsd:boolean">false</MDO:Selected>
       <MDO:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:30Z</MDO:LastChanged>
       <MDO:ChildItems xsi:type="MDO:ArrayOfSelectableMDOListItem">
        <MDO:SelectableMDOListItem xsi:type="MDO:SelectableMDOListItem">
         <MDO:Id xsi:type="xsd:int">0</MDO:Id>
         <MDO:Name xsi:type="xsd:string"></MDO:Name>
         <MDO:ToolTip xsi:type="xsd:string"></MDO:ToolTip>
         <MDO:Deleted xsi:type="xsd:boolean">false</MDO:Deleted>
         <MDO:Rank xsi:type="xsd:int">0</MDO:Rank>
         <MDO:Type xsi:type="xsd:string"></MDO:Type>
         <MDO:ColorBlock xsi:type="xsd:int">0</MDO:ColorBlock>
         <MDO:IconHint xsi:type="xsd:string"></MDO:IconHint>
         <MDO:Selected xsi:type="xsd:boolean">false</MDO:Selected>
         <MDO:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:30Z</MDO:LastChanged>
         <MDO:ChildItems xsi:type="MDO:ArrayOfSelectableMDOListItem">
          <MDO:SelectableMDOListItem xsi:nil="true"></MDO:SelectableMDOListItem>
         </MDO:ChildItems>
         <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
         <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
         <MDO:Hidden xsi:type="xsd:boolean">false</MDO:Hidden>
         <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
        </MDO:SelectableMDOListItem>
       </MDO:ChildItems>
       <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
       <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
       <MDO:Hidden xsi:type="xsd:boolean">false</MDO:Hidden>
       <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
      </MDO:SelectableMDOListItem>
     </MDO:ChildItems>
     <MDO:ExtraInfo xsi:type="xsd:string"></MDO:ExtraInfo>
     <MDO:StyleHint xsi:type="xsd:string"></MDO:StyleHint>
     <MDO:Hidden xsi:type="xsd:boolean">false</MDO:Hidden>
     <MDO:FullName xsi:type="xsd:string"></MDO:FullName>
    </MDO:SelectableMDOListItem>
   </MDO:Response>
  </MDO:SetSelectedResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

