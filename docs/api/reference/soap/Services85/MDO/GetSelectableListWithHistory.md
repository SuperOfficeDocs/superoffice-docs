---
title: Services85.MDOAgent.GetSelectableListWithHistory SOAP
generated: 1
uid: Services85-MDO-GetSelectableListWithHistory
---

# Services85 MDO GetSelectableListWithHistory

SOAP request and response examples **Remote/Services85/MDO.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IMDOAgent.GetSelectableListWithHistory">SuperOffice.Services85.IMDOAgent.GetSelectableListWithHistory</see> method.

## GetSelectableListWithHistory

Method to get a Selectable MDO list with own history list.

* **name:** Conceptual name of the MDO list.
* **forceFlatList:** Force the list to be flat
* **additionalInfo:** Additional info to the MDO provider
* **historyItems:** An array of ids, used to get the history list
* **onlyHistory:** If true, return only history items

**Returns:** Array of SelectableMDOListItem


[WSDL file for Services85/MDO](../Services85-MDO.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSelectableListWithHistory Request

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
   <MDO:GetSelectableListWithHistory>
    <MDO:Name xsi:type="xsd:string"></MDO:Name>
    <MDO:ForceFlatList xsi:type="xsd:boolean">false</MDO:ForceFlatList>
    <MDO:AdditionalInfo xsi:type="xsd:string"></MDO:AdditionalInfo>
    <MDO:HistoryItems xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
    </MDO:HistoryItems>
    <MDO:OnlyHistory xsi:type="xsd:boolean">false</MDO:OnlyHistory>
   </MDO:GetSelectableListWithHistory>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSelectableListWithHistory Response

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
  <MDO:GetSelectableListWithHistoryResponse>
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
     <MDO:LastChanged xsi:type="xsd:dateTime">2022-08-26T08:53:16Z</MDO:LastChanged>
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
       <MDO:LastChanged xsi:type="xsd:dateTime">2022-08-26T08:53:16Z</MDO:LastChanged>
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
         <MDO:LastChanged xsi:type="xsd:dateTime">2022-08-26T08:53:16Z</MDO:LastChanged>
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
  </MDO:GetSelectableListWithHistoryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

