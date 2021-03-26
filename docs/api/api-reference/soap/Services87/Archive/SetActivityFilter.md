---
uid: services87-archive-setactivityfilter
title: Services87.ArchiveAgent.SetActivityFilter SOAP
Generated: true
---

# Services87 Archive SetActivityFilter SOAP

SOAP request and response examples **Remote/Services87/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IArchiveAgent.SetActivityFilter">SuperOffice.Services87.IArchiveAgent.SetActivityFilter</see> method.

## SetActivityFilter

Set activity filter for the specified list.

* **activityFilter:** New activity filter



[WSDL file for Services87/Archive](../Services87-Archive.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetActivityFilter Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:SetActivityFilter>
    <Archive:ActivityFilter xsi:type="Archive:ActivityFilter">
     <Archive:FromDate xsi:type="xsd:dateTime">2021-03-25T21:36:26Z</Archive:FromDate>
     <Archive:ToDate xsi:type="xsd:dateTime">2021-03-25T21:36:26Z</Archive:ToDate>
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
       <Archive:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:36:26Z</Archive:LastChanged>
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
         <Archive:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:36:26Z</Archive:LastChanged>
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
       <Archive:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:36:26Z</Archive:LastChanged>
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
         <Archive:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:36:26Z</Archive:LastChanged>
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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Archive:SetActivityFilterResponse>
  </Archive:SetActivityFilterResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

