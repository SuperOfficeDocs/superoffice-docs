---
title: Services88.ErpSyncAgent.SaveConnectionListMappings SOAP
generated: 1
uid: Services88-ErpSync-SaveConnectionListMappings
---

# Services88 ErpSync SaveConnectionListMappings

SOAP request and response examples **Remote/Services88/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IErpSyncAgent.SaveConnectionListMappings">SuperOffice.Services88.IErpSyncAgent.SaveConnectionListMappings</see> method.

## SaveConnectionListMappings

Saves a connection to the database.
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.

* **listMapping:** The list item mappings to save.

**Returns:** The saved list mappings.


[WSDL file for Services88/ErpSync](../Services88-ErpSync.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveConnectionListMappings Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:SaveConnectionListMappings>
    <ErpSync:ListMapping xsi:type="ErpSync:ErpConnectionListMappingContainer">
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
          <ErpSync:Id xsi:nil="true"></ErpSync:Id>
          <ErpSync:Name xsi:type="xsd:string"></ErpSync:Name>
          <ErpSync:ToolTip xsi:type="xsd:string"></ErpSync:ToolTip>
          <ErpSync:Deleted xsi:nil="true"></ErpSync:Deleted>
          <ErpSync:Rank xsi:nil="true"></ErpSync:Rank>
          <ErpSync:Type xsi:type="xsd:string"></ErpSync:Type>
          <ErpSync:ChildItems xsi:nil="true"></ErpSync:ChildItems>
          <ErpSync:IconHint xsi:type="xsd:string"></ErpSync:IconHint>
          <ErpSync:ColorBlock xsi:nil="true"></ErpSync:ColorBlock>
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
          <ErpSync:Id xsi:nil="true"></ErpSync:Id>
          <ErpSync:Name xsi:type="xsd:string"></ErpSync:Name>
          <ErpSync:ToolTip xsi:type="xsd:string"></ErpSync:ToolTip>
          <ErpSync:Deleted xsi:nil="true"></ErpSync:Deleted>
          <ErpSync:Rank xsi:nil="true"></ErpSync:Rank>
          <ErpSync:Type xsi:type="xsd:string"></ErpSync:Type>
          <ErpSync:ChildItems xsi:nil="true"></ErpSync:ChildItems>
          <ErpSync:IconHint xsi:type="xsd:string"></ErpSync:IconHint>
          <ErpSync:ColorBlock xsi:nil="true"></ErpSync:ColorBlock>
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
    </ErpSync:ListMapping>
   </ErpSync:SaveConnectionListMappings>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveConnectionListMappings Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <ErpSync:SaveConnectionListMappingsResponse>
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
  </ErpSync:SaveConnectionListMappingsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

