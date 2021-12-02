---
title: Services86.ErpSyncAgent.GetConnectionListMappings SOAP
generated: 1
uid: Services86-ErpSync-GetConnectionListMappings
---

# Services86 ErpSync GetConnectionListMappings

SOAP request and response examples **Remote/Services86/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IErpSyncAgent.GetConnectionListMappings">SuperOffice.Services86.IErpSyncAgent.GetConnectionListMappings</see> method.

## GetConnectionListMappings

Returns the listmappings for the specified connection.
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.

* **erpConnectionId:** Primary key of the connection

**Returns:** The listmappings


[WSDL file for Services86/ErpSync](../Services86-ErpSync.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConnectionListMappings Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:GetConnectionListMappings>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
   </ErpSync:GetConnectionListMappings>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConnectionListMappings Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <ErpSync:GetConnectionListMappingsResponse>
   <ErpSync:Response xsi:type="ErpSync:ErpConnectionListMappingContainer">
    <ErpSync:ErpListItemMappings xsi:type="ErpSync:ArrayOfErpConnectionListMapping">
     <ErpSync:ErpConnectionListMapping xsi:type="ErpSync:ErpConnectionListMapping">
      <ErpSync:CrmList xsi:type="ErpSync:MDOListItem">
       <ErpSync:Id xsi:type="xsd:int">0</ErpSync:Id>
       <ErpSync:Name xsi:type="xsd:string"></ErpSync:Name>
       <ErpSync:ToolTip xsi:type="xsd:string"></ErpSync:ToolTip>
       <ErpSync:Deleted xsi:type="xsd:boolean">false</ErpSync:Deleted>
       <ErpSync:Rank xsi:type="xsd:int">0</ErpSync:Rank>
       <ErpSync:Type xsi:type="xsd:string"></ErpSync:Type>
       <ErpSync:ChildItems xsi:type="ErpSync:ArrayOfMDOListItem">
        <ErpSync:MDOListItem xsi:type="ErpSync:MDOListItem">
         <ErpSync:Id xsi:type="xsd:int">0</ErpSync:Id>
         <ErpSync:Name xsi:type="xsd:string"></ErpSync:Name>
         <ErpSync:ToolTip xsi:type="xsd:string"></ErpSync:ToolTip>
         <ErpSync:Deleted xsi:type="xsd:boolean">false</ErpSync:Deleted>
         <ErpSync:Rank xsi:type="xsd:int">0</ErpSync:Rank>
         <ErpSync:Type xsi:type="xsd:string"></ErpSync:Type>
         <ErpSync:ChildItems xsi:type="ErpSync:ArrayOfMDOListItem">
          <ErpSync:MDOListItem xsi:nil="true"></ErpSync:MDOListItem>
         </ErpSync:ChildItems>
         <ErpSync:IconHint xsi:type="xsd:string"></ErpSync:IconHint>
         <ErpSync:ColorBlock xsi:type="xsd:int">0</ErpSync:ColorBlock>
         <ErpSync:ExtraInfo xsi:type="xsd:string"></ErpSync:ExtraInfo>
         <ErpSync:StyleHint xsi:type="xsd:string"></ErpSync:StyleHint>
         <ErpSync:FullName xsi:type="xsd:string"></ErpSync:FullName>
        </ErpSync:MDOListItem>
       </ErpSync:ChildItems>
       <ErpSync:IconHint xsi:type="xsd:string"></ErpSync:IconHint>
       <ErpSync:ColorBlock xsi:type="xsd:int">0</ErpSync:ColorBlock>
       <ErpSync:ExtraInfo xsi:type="xsd:string"></ErpSync:ExtraInfo>
       <ErpSync:StyleHint xsi:type="xsd:string"></ErpSync:StyleHint>
       <ErpSync:FullName xsi:type="xsd:string"></ErpSync:FullName>
      </ErpSync:CrmList>
      <ErpSync:ErpListName xsi:type="xsd:string"></ErpSync:ErpListName>
      <ErpSync:ErpCrmListItemMappings xsi:type="ErpSync:ArrayOfErpCrmListItemMapping">
       <ErpSync:ErpCrmListItemMapping xsi:type="ErpSync:ErpCrmListItemMapping">
        <ErpSync:ErpListItemId xsi:type="xsd:string"></ErpSync:ErpListItemId>
        <ErpSync:ErpListItemName xsi:type="xsd:string"></ErpSync:ErpListItemName>
        <ErpSync:CrmListItem xsi:type="ErpSync:MDOListItem">
         <ErpSync:Id xsi:type="xsd:int">0</ErpSync:Id>
         <ErpSync:Name xsi:type="xsd:string"></ErpSync:Name>
         <ErpSync:ToolTip xsi:type="xsd:string"></ErpSync:ToolTip>
         <ErpSync:Deleted xsi:type="xsd:boolean">false</ErpSync:Deleted>
         <ErpSync:Rank xsi:type="xsd:int">0</ErpSync:Rank>
         <ErpSync:Type xsi:type="xsd:string"></ErpSync:Type>
         <ErpSync:ChildItems xsi:type="ErpSync:ArrayOfMDOListItem">
          <ErpSync:MDOListItem xsi:nil="true"></ErpSync:MDOListItem>
         </ErpSync:ChildItems>
         <ErpSync:IconHint xsi:type="xsd:string"></ErpSync:IconHint>
         <ErpSync:ColorBlock xsi:type="xsd:int">0</ErpSync:ColorBlock>
         <ErpSync:ExtraInfo xsi:type="xsd:string"></ErpSync:ExtraInfo>
         <ErpSync:StyleHint xsi:type="xsd:string"></ErpSync:StyleHint>
         <ErpSync:FullName xsi:type="xsd:string"></ErpSync:FullName>
        </ErpSync:CrmListItem>
       </ErpSync:ErpCrmListItemMapping>
      </ErpSync:ErpCrmListItemMappings>
      <ErpSync:ErpActorTypeName xsi:type="xsd:string"></ErpSync:ErpActorTypeName>
      <ErpSync:ErpFieldId xsi:type="xsd:int">0</ErpSync:ErpFieldId>
     </ErpSync:ErpConnectionListMapping>
    </ErpSync:ErpListItemMappings>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:ErpConnectionName xsi:type="xsd:string"></ErpSync:ErpConnectionName>
   </ErpSync:Response>
  </ErpSync:GetConnectionListMappingsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

