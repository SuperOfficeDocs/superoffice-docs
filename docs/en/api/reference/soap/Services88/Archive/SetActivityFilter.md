---
title: Services88.ArchiveAgent.SetActivityFilter SOAP
generated: true
uid: Services88-Archive-SetActivityFilter
---

# Services88 Archive SetActivityFilter

SOAP request and response examples **Remote/Services88/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IArchiveAgent.SetActivityFilter">SuperOffice.Services88.IArchiveAgent.SetActivityFilter</see> method.

## SetActivityFilter





[WSDL file for Services88/Archive](../Services88-Archive.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetActivityFilter Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:SetActivityFilter>
    <Archive:ActivityFilter xsi:type="Archive:ActivityFilter">
     <Archive:FromDate xsi:type="xsd:dateTime">2025-06-26T01:42:53Z</Archive:FromDate>
     <Archive:ToDate xsi:type="xsd:dateTime">2025-06-26T01:42:53Z</Archive:ToDate>
     <Archive:AssociateList xsi:type="Archive:ArrayOfSelectableMDOListItem">
      <Archive:SelectableMDOListItem xsi:type="Archive:SelectableMDOListItem">
       <Archive:Id xsi:type="xsd:int">0</Archive:Id>
       <Archive:Name xsi:type="xsd:string"></Archive:Name>
       <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
       <Archive:Deleted xsi:type="xsd:boolean">false</Archive:Deleted>
       <Archive:Rank xsi:type="xsd:int">0</Archive:Rank>
       <Archive:Type xsi:type="xsd:string"></Archive:Type>
       <Archive:ColorBlock xsi:type="xsd:int">0</Archive:ColorBlock>
       <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
       <Archive:Selected xsi:type="xsd:boolean">false</Archive:Selected>
       <Archive:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:42:53Z</Archive:LastChanged>
       <Archive:ChildItems xsi:type="Archive:ArrayOfSelectableMDOListItem">
        <Archive:SelectableMDOListItem xsi:type="Archive:SelectableMDOListItem">
         <Archive:Id xsi:type="xsd:int">0</Archive:Id>
         <Archive:Name xsi:type="xsd:string"></Archive:Name>
         <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
         <Archive:Deleted xsi:type="xsd:boolean">false</Archive:Deleted>
         <Archive:Rank xsi:type="xsd:int">0</Archive:Rank>
         <Archive:Type xsi:type="xsd:string"></Archive:Type>
         <Archive:ColorBlock xsi:type="xsd:int">0</Archive:ColorBlock>
         <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
         <Archive:Selected xsi:type="xsd:boolean">false</Archive:Selected>
         <Archive:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:42:53Z</Archive:LastChanged>
         <Archive:ChildItems xsi:type="Archive:ArrayOfSelectableMDOListItem">
          <Archive:SelectableMDOListItem xsi:nil="true"></Archive:SelectableMDOListItem>
         </Archive:ChildItems>
         <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
         <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
         <Archive:Hidden xsi:type="xsd:boolean">false</Archive:Hidden>
         <Archive:FullName xsi:type="xsd:string"></Archive:FullName>
        </Archive:SelectableMDOListItem>
       </Archive:ChildItems>
       <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
       <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
       <Archive:Hidden xsi:type="xsd:boolean">false</Archive:Hidden>
       <Archive:FullName xsi:type="xsd:string"></Archive:FullName>
      </Archive:SelectableMDOListItem>
     </Archive:AssociateList>
     <Archive:GroupList xsi:type="Archive:ArrayOfSelectableMDOListItem">
      <Archive:SelectableMDOListItem xsi:type="Archive:SelectableMDOListItem">
       <Archive:Id xsi:type="xsd:int">0</Archive:Id>
       <Archive:Name xsi:type="xsd:string"></Archive:Name>
       <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
       <Archive:Deleted xsi:type="xsd:boolean">false</Archive:Deleted>
       <Archive:Rank xsi:type="xsd:int">0</Archive:Rank>
       <Archive:Type xsi:type="xsd:string"></Archive:Type>
       <Archive:ColorBlock xsi:type="xsd:int">0</Archive:ColorBlock>
       <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
       <Archive:Selected xsi:type="xsd:boolean">false</Archive:Selected>
       <Archive:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:42:53Z</Archive:LastChanged>
       <Archive:ChildItems xsi:type="Archive:ArrayOfSelectableMDOListItem">
        <Archive:SelectableMDOListItem xsi:type="Archive:SelectableMDOListItem">
         <Archive:Id xsi:type="xsd:int">0</Archive:Id>
         <Archive:Name xsi:type="xsd:string"></Archive:Name>
         <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
         <Archive:Deleted xsi:type="xsd:boolean">false</Archive:Deleted>
         <Archive:Rank xsi:type="xsd:int">0</Archive:Rank>
         <Archive:Type xsi:type="xsd:string"></Archive:Type>
         <Archive:ColorBlock xsi:type="xsd:int">0</Archive:ColorBlock>
         <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
         <Archive:Selected xsi:type="xsd:boolean">false</Archive:Selected>
         <Archive:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:42:53Z</Archive:LastChanged>
         <Archive:ChildItems xsi:type="Archive:ArrayOfSelectableMDOListItem">
          <Archive:SelectableMDOListItem xsi:nil="true"></Archive:SelectableMDOListItem>
         </Archive:ChildItems>
         <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
         <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
         <Archive:Hidden xsi:type="xsd:boolean">false</Archive:Hidden>
         <Archive:FullName xsi:type="xsd:string"></Archive:FullName>
        </Archive:SelectableMDOListItem>
       </Archive:ChildItems>
       <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
       <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
       <Archive:Hidden xsi:type="xsd:boolean">false</Archive:Hidden>
       <Archive:FullName xsi:type="xsd:string"></Archive:FullName>
      </Archive:SelectableMDOListItem>
     </Archive:GroupList>
     <Archive:FutureDateList xsi:type="Archive:ArrayOfMDOListItem">
      <Archive:MDOListItem xsi:type="Archive:MDOListItem">
       <Archive:Id xsi:type="xsd:int">0</Archive:Id>
       <Archive:Name xsi:type="xsd:string"></Archive:Name>
       <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
       <Archive:Deleted xsi:type="xsd:boolean">false</Archive:Deleted>
       <Archive:Rank xsi:type="xsd:int">0</Archive:Rank>
       <Archive:Type xsi:type="xsd:string"></Archive:Type>
       <Archive:ChildItems xsi:type="Archive:ArrayOfMDOListItem">
        <Archive:MDOListItem xsi:type="Archive:MDOListItem">
         <Archive:Id xsi:type="xsd:int">0</Archive:Id>
         <Archive:Name xsi:type="xsd:string"></Archive:Name>
         <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
         <Archive:Deleted xsi:type="xsd:boolean">false</Archive:Deleted>
         <Archive:Rank xsi:type="xsd:int">0</Archive:Rank>
         <Archive:Type xsi:type="xsd:string"></Archive:Type>
         <Archive:ChildItems xsi:type="Archive:ArrayOfMDOListItem">
          <Archive:MDOListItem xsi:nil="true"></Archive:MDOListItem>
         </Archive:ChildItems>
         <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
         <Archive:ColorBlock xsi:type="xsd:int">0</Archive:ColorBlock>
         <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
         <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
         <Archive:FullName xsi:type="xsd:string"></Archive:FullName>
        </Archive:MDOListItem>
       </Archive:ChildItems>
       <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
       <Archive:ColorBlock xsi:type="xsd:int">0</Archive:ColorBlock>
       <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
       <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
       <Archive:FullName xsi:type="xsd:string"></Archive:FullName>
      </Archive:MDOListItem>
     </Archive:FutureDateList>
    </Archive:ActivityFilter>
   </Archive:SetActivityFilter>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetActivityFilter Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Archive:SetActivityFilterResponse>
  </Archive:SetActivityFilterResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

