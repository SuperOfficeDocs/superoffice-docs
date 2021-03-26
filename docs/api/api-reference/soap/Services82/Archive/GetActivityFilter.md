---
uid: services82-archive-getactivityfilter
title: Services82.ArchiveAgent.GetActivityFilter SOAP
Generated: true
---

# Services82 Archive GetActivityFilter SOAP

SOAP request and response examples **Remote/Services82/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IArchiveAgent.GetActivityFilter">SuperOffice.Services82.IArchiveAgent.GetActivityFilter</see> method.

## GetActivityFilter

Get activity filter for the specified list.


**Returns:** The activity filter for the specified list


[WSDL file for Services82/Archive](../Services82-Archive.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetActivityFilter Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:GetActivityFilter>
   </Archive:GetActivityFilter>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetActivityFilter Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Archive:GetActivityFilterResponse>
   <Archive:Response xsi:type="Archive:ActivityFilter">
    <Archive:FromDate xsi:type="xsd:dateTime">2021-03-25T21:34:41Z</Archive:FromDate>
    <Archive:ToDate xsi:type="xsd:dateTime">2021-03-25T21:34:41Z</Archive:ToDate>
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
      <Archive:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:34:41Z</Archive:LastChanged>
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
        <Archive:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:34:41Z</Archive:LastChanged>
        <Archive:ChildItems xsi:type="Archive:ArrayOfSelectableMDOListItem">
         <Archive:SelectableMDOListItem xsi:type="Archive:SelectableMDOListItem">
          <Archive:Id xsi:nil="true"></Archive:Id>
          <Archive:Name xsi:type="xsd:string"></Archive:Name>
          <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
          <Archive:Deleted xsi:nil="true"></Archive:Deleted>
          <Archive:Rank xsi:nil="true"></Archive:Rank>
          <Archive:Type xsi:type="xsd:string"></Archive:Type>
          <Archive:ColorBlock xsi:nil="true"></Archive:ColorBlock>
          <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
          <Archive:Selected xsi:nil="true"></Archive:Selected>
          <Archive:LastChanged xsi:nil="true"></Archive:LastChanged>
          <Archive:ChildItems xsi:nil="true"></Archive:ChildItems>
          <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
          <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
          <Archive:Hidden xsi:nil="true"></Archive:Hidden>
         </Archive:SelectableMDOListItem>
        </Archive:ChildItems>
        <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
        <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
        <Archive:Hidden xsi:type="xsd:boolean">false</Archive:Hidden>
       </Archive:SelectableMDOListItem>
      </Archive:ChildItems>
      <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
      <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
      <Archive:Hidden xsi:type="xsd:boolean">false</Archive:Hidden>
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
      <Archive:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:34:41Z</Archive:LastChanged>
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
        <Archive:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:34:41Z</Archive:LastChanged>
        <Archive:ChildItems xsi:type="Archive:ArrayOfSelectableMDOListItem">
         <Archive:SelectableMDOListItem xsi:type="Archive:SelectableMDOListItem">
          <Archive:Id xsi:nil="true"></Archive:Id>
          <Archive:Name xsi:type="xsd:string"></Archive:Name>
          <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
          <Archive:Deleted xsi:nil="true"></Archive:Deleted>
          <Archive:Rank xsi:nil="true"></Archive:Rank>
          <Archive:Type xsi:type="xsd:string"></Archive:Type>
          <Archive:ColorBlock xsi:nil="true"></Archive:ColorBlock>
          <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
          <Archive:Selected xsi:nil="true"></Archive:Selected>
          <Archive:LastChanged xsi:nil="true"></Archive:LastChanged>
          <Archive:ChildItems xsi:nil="true"></Archive:ChildItems>
          <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
          <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
          <Archive:Hidden xsi:nil="true"></Archive:Hidden>
         </Archive:SelectableMDOListItem>
        </Archive:ChildItems>
        <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
        <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
        <Archive:Hidden xsi:type="xsd:boolean">false</Archive:Hidden>
       </Archive:SelectableMDOListItem>
      </Archive:ChildItems>
      <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
      <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
      <Archive:Hidden xsi:type="xsd:boolean">false</Archive:Hidden>
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
         <Archive:MDOListItem xsi:type="Archive:MDOListItem">
          <Archive:Id xsi:nil="true"></Archive:Id>
          <Archive:Name xsi:type="xsd:string"></Archive:Name>
          <Archive:ToolTip xsi:type="xsd:string"></Archive:ToolTip>
          <Archive:Deleted xsi:nil="true"></Archive:Deleted>
          <Archive:Rank xsi:nil="true"></Archive:Rank>
          <Archive:Type xsi:type="xsd:string"></Archive:Type>
          <Archive:ChildItems xsi:nil="true"></Archive:ChildItems>
          <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
          <Archive:ColorBlock xsi:nil="true"></Archive:ColorBlock>
          <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
          <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
         </Archive:MDOListItem>
        </Archive:ChildItems>
        <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
        <Archive:ColorBlock xsi:type="xsd:int">0</Archive:ColorBlock>
        <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
        <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
       </Archive:MDOListItem>
      </Archive:ChildItems>
      <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
      <Archive:ColorBlock xsi:type="xsd:int">0</Archive:ColorBlock>
      <Archive:ExtraInfo xsi:type="xsd:string"></Archive:ExtraInfo>
      <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
     </Archive:MDOListItem>
    </Archive:FutureDateList>
   </Archive:Response>
  </Archive:GetActivityFilterResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

