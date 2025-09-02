---
title: Services88.ArchiveAgent.GetAvailableEntities SOAP
generated: true
uid: Services88-Archive-GetAvailableEntities
content_type: reference
---

# Services88 Archive GetAvailableEntities

SOAP request and response examples **Remote/Services88/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IArchiveAgent.GetAvailableEntities">SuperOffice.Services88.IArchiveAgent.GetAvailableEntities</see> method.

## GetAvailableEntities





[WSDL file for Services88/Archive](../Services88-Archive.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAvailableEntities Request

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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
         <Archive:FullName xsi:type="xsd:string"></Archive:FullName>
        </Archive:MDOListItem>
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
   </Archive:Response>
  </Archive:GetAvailableEntitiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

