---
title: Services85.MDOAgent.GetSelectableListWithRestriction SOAP
generated: 1
uid: Services85-MDO-GetSelectableListWithRestriction
---

# Services85 MDO GetSelectableListWithRestriction

SOAP request and response examples **Remote/Services85/MDO.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IMDOAgent.GetSelectableListWithRestriction">SuperOffice.Services85.IMDOAgent.GetSelectableListWithRestriction</see> method.

## GetSelectableListWithRestriction

Method to get a Selectable MDO list with restrictions.

* **name:** Conceptual name of the MDO list
* **additionalInfo:** Additional info to the MDO provider
* **searchValue:** the value used to restrict the list

**Returns:** Array of SelectableMDOListItem

[WSDL file for Services85/MDO](../Services85-MDO.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSelectableListWithRestriction Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <MDO:ApplicationToken>1234567-1234-9876</MDO:ApplicationToken>
  <MDO:Credentials>
    <MDO:Ticket>7T:1234abcxyzExample==</MDO:Ticket>
  </MDO:Credentials>
 <SOAP-ENV:Body>
   <MDO:GetSelectableListWithRestriction>
    <MDO:Name xsi:type="xsd:string"></MDO:Name>
    <MDO:AdditionalInfo xsi:type="xsd:string"></MDO:AdditionalInfo>
    <MDO:SearchValue xsi:type="xsd:string"></MDO:SearchValue>
   </MDO:GetSelectableListWithRestriction>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetSelectableListWithRestriction Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <MDO:GetSelectableListWithRestrictionResponse>
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
     <MDO:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:36Z</MDO:LastChanged>
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
       <MDO:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:36Z</MDO:LastChanged>
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
         <MDO:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:36Z</MDO:LastChanged>
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
  </MDO:GetSelectableListWithRestrictionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
