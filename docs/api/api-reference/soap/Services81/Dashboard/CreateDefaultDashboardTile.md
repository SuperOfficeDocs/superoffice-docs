---
uid: services81-dashboard-createdefaultdashboardtile
title: Services81.DashboardAgent.CreateDefaultDashboardTile SOAP
Generated: true
---

# Services81 Dashboard CreateDefaultDashboardTile SOAP

SOAP request and response examples **Remote/Services81/Dashboard.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IDashboardAgent.CreateDefaultDashboardTile">SuperOffice.Services81.IDashboardAgent.CreateDefaultDashboardTile</see> method.

## CreateDefaultDashboardTile

Loading default values into a new DashboardTile.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New DashboardTile with default values


[WSDL file for Services81/Dashboard](../Services81-Dashboard.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultDashboardTile Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Dashboard:ApplicationToken>1234567-1234-9876</Dashboard:ApplicationToken>
  <Dashboard:Credentials>
    <Dashboard:Ticket>7T:1234abcxyzExample==</Dashboard:Ticket>
  </Dashboard:Credentials>
 <SOAP-ENV:Body>
   <Dashboard:CreateDefaultDashboardTile>
   </Dashboard:CreateDefaultDashboardTile>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultDashboardTile Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Dashboard:CreateDefaultDashboardTileResponse>
   <Dashboard:Response xsi:type="Dashboard:DashboardTile">
    <Dashboard:DashboardTileId xsi:type="xsd:int">0</Dashboard:DashboardTileId>
    <Dashboard:Caption xsi:type="xsd:string"></Dashboard:Caption>
    <Dashboard:Description xsi:type="xsd:string"></Dashboard:Description>
    <Dashboard:AssociateId xsi:type="xsd:int">0</Dashboard:AssociateId>
    <Dashboard:Config xsi:type="xsd:string"></Dashboard:Config>
    <Dashboard:Type xsi:type="Dashboard:DashboardTileType">None</Dashboard:Type>
    <Dashboard:EntityType xsi:type="Dashboard:DashboardTileEntityType">None</Dashboard:EntityType>
   </Dashboard:Response>
  </Dashboard:CreateDefaultDashboardTileResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

