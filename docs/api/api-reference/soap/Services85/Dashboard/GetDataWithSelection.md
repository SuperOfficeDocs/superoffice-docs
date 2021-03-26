---
uid: services85-dashboard-getdatawithselection
title: Services85.DashboardAgent.GetDataWithSelection SOAP
Generated: true
---

# Services85 Dashboard GetDataWithSelection SOAP

SOAP request and response examples **Remote/Services85/Dashboard.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IDashboardAgent.GetDataWithSelection">SuperOffice.Services85.IDashboardAgent.GetDataWithSelection</see> method.

## GetDataWithSelection

Get data for this tile

* **dashboardTileId:** Tile Id
* **selectionId:** Selection Id
* **restrictions:** Replacement restrictions

**Returns:** The data


[WSDL file for Services85/Dashboard](../Services85-Dashboard.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDataWithSelection Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Dashboard:ApplicationToken>1234567-1234-9876</Dashboard:ApplicationToken>
  <Dashboard:Credentials>
    <Dashboard:Ticket>7T:1234abcxyzExample==</Dashboard:Ticket>
  </Dashboard:Credentials>
 <SOAP-ENV:Body>
   <Dashboard:GetDataWithSelection>
    <Dashboard:DashboardTileId xsi:type="xsd:int">0</Dashboard:DashboardTileId>
    <Dashboard:SelectionId xsi:type="xsd:int">0</Dashboard:SelectionId>
    <Dashboard:Restrictions xsi:type="xsd:string"></Dashboard:Restrictions>
   </Dashboard:GetDataWithSelection>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDataWithSelection Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Dashboard:GetDataWithSelectionResponse>
   <Dashboard:Response xsi:type="Dashboard:ArrayOfTileData">
    <Dashboard:TileData xsi:type="Dashboard:TileData">
     <Dashboard:Columns xsi:type="Dashboard:ArrayOfArchiveColumnInfo">
      <Dashboard:ArchiveColumnInfo xsi:type="Dashboard:ArchiveColumnInfo">
       <Dashboard:DisplayName xsi:type="xsd:string"></Dashboard:DisplayName>
       <Dashboard:DisplayTooltip xsi:type="xsd:string"></Dashboard:DisplayTooltip>
       <Dashboard:DisplayType xsi:type="xsd:string"></Dashboard:DisplayType>
       <Dashboard:CanOrderBy xsi:type="xsd:boolean">false</Dashboard:CanOrderBy>
       <Dashboard:Name xsi:type="xsd:string"></Dashboard:Name>
       <Dashboard:CanRestrictBy xsi:type="xsd:boolean">false</Dashboard:CanRestrictBy>
       <Dashboard:RestrictionType xsi:type="xsd:string"></Dashboard:RestrictionType>
       <Dashboard:RestrictionListName xsi:type="xsd:string"></Dashboard:RestrictionListName>
       <Dashboard:IsVisible xsi:type="xsd:boolean">false</Dashboard:IsVisible>
       <Dashboard:Width xsi:type="xsd:string"></Dashboard:Width>
       <Dashboard:IconHint xsi:type="xsd:string"></Dashboard:IconHint>
       <Dashboard:HeadingIconHint xsi:type="xsd:string"></Dashboard:HeadingIconHint>
      </Dashboard:ArchiveColumnInfo>
     </Dashboard:Columns>
     <Dashboard:Result xsi:type="Dashboard:ArchiveListResult">
      <Dashboard:RowCount xsi:type="xsd:int">0</Dashboard:RowCount>
      <Dashboard:Rows xsi:type="Dashboard:ArrayOfArchiveListItem">
       <Dashboard:ArchiveListItem xsi:type="Dashboard:ArchiveListItem">
        <Dashboard:EntityName xsi:type="xsd:string"></Dashboard:EntityName>
        <Dashboard:PrimaryKey xsi:type="xsd:int">0</Dashboard:PrimaryKey>
        <Dashboard:ColumnData xsi:type="Dashboard:ColumnDataDictionary">
         <Dashboard:ColumnDataKeyValuePair>
          <Dashboard:Key xsi:type="xsd:string"></Dashboard:Key>
          <Dashboard:Value xsi:nil="true"></Dashboard:Value>
         </Dashboard:ColumnDataKeyValuePair>
        </Dashboard:ColumnData>
        <Dashboard:LinkHint xsi:type="xsd:string"></Dashboard:LinkHint>
        <Dashboard:StyleHint xsi:type="xsd:string"></Dashboard:StyleHint>
       </Dashboard:ArchiveListItem>
      </Dashboard:Rows>
     </Dashboard:Result>
    </Dashboard:TileData>
   </Dashboard:Response>
  </Dashboard:GetDataWithSelectionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

