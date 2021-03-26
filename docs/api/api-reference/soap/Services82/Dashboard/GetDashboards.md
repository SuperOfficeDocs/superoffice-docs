---
uid: services82-dashboard-getdashboards
title: Services82.DashboardAgent.GetDashboards SOAP
Generated: true
---

# Services82 Dashboard GetDashboards SOAP

SOAP request and response examples **Remote/Services82/Dashboard.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IDashboardAgent.GetDashboards">SuperOffice.Services82.IDashboardAgent.GetDashboards</see> method.

## GetDashboards

Gets all dashboards for an associate

* **associateId:** Associate Id

**Returns:** All the users dashboards


[WSDL file for Services82/Dashboard](../Services82-Dashboard.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDashboards Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Dashboard:ApplicationToken>1234567-1234-9876</Dashboard:ApplicationToken>
  <Dashboard:Credentials>
    <Dashboard:Ticket>7T:1234abcxyzExample==</Dashboard:Ticket>
  </Dashboard:Credentials>
 <SOAP-ENV:Body>
   <Dashboard:GetDashboards>
    <Dashboard:AssociateId xsi:type="xsd:int">0</Dashboard:AssociateId>
   </Dashboard:GetDashboards>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDashboards Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Dashboard:GetDashboardsResponse>
   <Dashboard:Response xsi:type="Dashboard:ArrayOfDashboard">
    <Dashboard:Dashboard xsi:type="Dashboard:Dashboard">
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
          <Dashboard:MDOListItem xsi:nil="true"></Dashboard:MDOListItem>
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
    </Dashboard:Dashboard>
   </Dashboard:Response>
  </Dashboard:GetDashboardsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

