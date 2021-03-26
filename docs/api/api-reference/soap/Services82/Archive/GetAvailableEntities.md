---
uid: services82-archive-getavailableentities
title: Services82.ArchiveAgent.GetAvailableEntities SOAP
Generated: true
---

# Services82 Archive GetAvailableEntities SOAP

SOAP request and response examples **Remote/Services82/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IArchiveAgent.GetAvailableEntities">SuperOffice.Services82.IArchiveAgent.GetAvailableEntities</see> method.

## GetAvailableEntities





[WSDL file for Services82/Archive](../Services82-Archive.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAvailableEntities Request

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
   <Archive:GetAvailableEntities>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:Context xsi:type="xsd:string"></Archive:Context>
   </Archive:GetAvailableEntities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAvailableEntities Response

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
  <Archive:GetAvailableEntitiesResponse>
   <Archive:Response xsi:type="Archive:ArrayOfMDOListItem">
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
   </Archive:Response>
  </Archive:GetAvailableEntitiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

