---
title: Services85.DashboardAgent.GetDashboard SOAP
generated: 1
uid: Services85-Dashboard-GetDashboard
---

# Services85 Dashboard GetDashboard

SOAP request and response examples **Remote/Services85/Dashboard.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IDashboardAgent.GetDashboard">SuperOffice.Services85.IDashboardAgent.GetDashboard</see> method.

## GetDashboard

[WSDL file for Services85/Dashboard](../Services85-Dashboard.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDashboard Request

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
   <Dashboard:GetDashboard>
    <Dashboard:DashboardId xsi:type="xsd:int">0</Dashboard:DashboardId>
   </Dashboard:GetDashboard>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetDashboard Response

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
  <Dashboard:GetDashboardResponse>
   <Dashboard:Response xsi:type="Dashboard:Dashboard">
    <Dashboard:DashboardId xsi:type="xsd:int">0</Dashboard:DashboardId>
    <Dashboard:AssociateId xsi:type="xsd:int">0</Dashboard:AssociateId>
    <Dashboard:Caption xsi:type="xsd:string"></Dashboard:Caption>
    <Dashboard:Layout xsi:type="Dashboard:DashboardLayout">None</Dashboard:Layout>
    <Dashboard:Tiles xsi:type="Dashboard:ArrayOfDashboardTile">
     <Dashboard:DashboardTile xsi:type="Dashboard:DashboardTile">
      <Dashboard:DashboardTileId xsi:type="xsd:int">0</Dashboard:DashboardTileId>
      <Dashboard:Caption xsi:type="xsd:string"></Dashboard:Caption>
      <Dashboard:Description xsi:type="xsd:string"></Dashboard:Description>
      <Dashboard:ChartName xsi:type="xsd:string"></Dashboard:ChartName>
      <Dashboard:ChartId xsi:type="xsd:string"></Dashboard:ChartId>
      <Dashboard:IsDefault xsi:type="xsd:boolean">false</Dashboard:IsDefault>
      <Dashboard:AssociateId xsi:type="xsd:int">0</Dashboard:AssociateId>
      <Dashboard:GroupId xsi:type="xsd:int">0</Dashboard:GroupId>
      <Dashboard:SelectionId xsi:type="xsd:int">0</Dashboard:SelectionId>
      <Dashboard:Config xsi:type="xsd:string"></Dashboard:Config>
      <Dashboard:Type xsi:type="Dashboard:DashboardTileType">None</Dashboard:Type>
      <Dashboard:EntityType xsi:type="Dashboard:DashboardTileEntityType">None</Dashboard:EntityType>
      <Dashboard:Options xsi:type="Dashboard:ArrayOfDashboardTileOption">
       <Dashboard:DashboardTileOption xsi:type="Dashboard:DashboardTileOption">
        <Dashboard:Name xsi:type="xsd:string"></Dashboard:Name>
        <Dashboard:Description xsi:type="xsd:string"></Dashboard:Description>
        <Dashboard:Type xsi:type="Dashboard:DashboardTileOptionType">None</Dashboard:Type>
        <Dashboard:ListName xsi:type="xsd:string"></Dashboard:ListName>
        <Dashboard:ListItems xsi:type="Dashboard:ArrayOfMDOListItem">
         <Dashboard:MDOListItem xsi:type="Dashboard:MDOListItem">
          <Dashboard:Id xsi:nil="true"></Dashboard:Id>
          <Dashboard:Name xsi:type="xsd:string"></Dashboard:Name>
          <Dashboard:ToolTip xsi:type="xsd:string"></Dashboard:ToolTip>
          <Dashboard:Deleted xsi:nil="true"></Dashboard:Deleted>
          <Dashboard:Rank xsi:nil="true"></Dashboard:Rank>
          <Dashboard:Type xsi:type="xsd:string"></Dashboard:Type>
          <Dashboard:ChildItems xsi:nil="true"></Dashboard:ChildItems>
          <Dashboard:IconHint xsi:type="xsd:string"></Dashboard:IconHint>
          <Dashboard:ColorBlock xsi:nil="true"></Dashboard:ColorBlock>
          <Dashboard:ExtraInfo xsi:type="xsd:string"></Dashboard:ExtraInfo>
          <Dashboard:StyleHint xsi:type="xsd:string"></Dashboard:StyleHint>
          <Dashboard:FullName xsi:type="xsd:string"></Dashboard:FullName>
         </Dashboard:MDOListItem>
        </Dashboard:ListItems>
        <Dashboard:Value xsi:type="xsd:string"></Dashboard:Value>
        <Dashboard:DefaultDataOption xsi:type="xsd:boolean">false</Dashboard:DefaultDataOption>
       </Dashboard:DashboardTileOption>
      </Dashboard:Options>
      <Dashboard:VisibleFor xsi:type="Dashboard:ArrayOfVisibleFor">
       <Dashboard:VisibleFor xsi:type="Dashboard:VisibleFor">
        <Dashboard:VisibleId xsi:type="xsd:int">0</Dashboard:VisibleId>
        <Dashboard:Visibility xsi:type="Dashboard:Visibility">All</Dashboard:Visibility>
        <Dashboard:DisplayValue xsi:type="xsd:string"></Dashboard:DisplayValue>
       </Dashboard:VisibleFor>
      </Dashboard:VisibleFor>
     </Dashboard:DashboardTile>
    </Dashboard:Tiles>
   </Dashboard:Response>
  </Dashboard:GetDashboardResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
