---
uid: services86-dashboard-getdata
title: Services86.DashboardAgent.GetData SOAP
Generated: true
---

# Services86 Dashboard GetData SOAP

SOAP request and response examples **Remote/Services86/Dashboard.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IDashboardAgent.GetData">SuperOffice.Services86.IDashboardAgent.GetData</see> method.

## GetData

Get data for this tile

* **dashboardTileId:** Tile Id
* **restrictions:** Replacement restrictions

**Returns:** The data


[WSDL file for Services86/Dashboard](../Services86-Dashboard.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetData Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Dashboard:ApplicationToken>1234567-1234-9876</Dashboard:ApplicationToken>
  <Dashboard:Credentials>
    <Dashboard:Ticket>7T:1234abcxyzExample==</Dashboard:Ticket>
  </Dashboard:Credentials>
 <SOAP-ENV:Body>
   <Dashboard:GetData>
    <Dashboard:DashboardTileId xsi:type="xsd:int">0</Dashboard:DashboardTileId>
    <Dashboard:Restrictions xsi:type="xsd:string"></Dashboard:Restrictions>
   </Dashboard:GetData>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetData Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Dashboard:GetDataResponse>
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
  </Dashboard:GetDataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

