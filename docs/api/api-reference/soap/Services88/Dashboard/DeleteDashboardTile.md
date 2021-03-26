---
uid: services88-dashboard-deletedashboardtile
title: Services88.DashboardAgent.DeleteDashboardTile SOAP
Generated: true
---

# Services88 Dashboard DeleteDashboardTile SOAP

SOAP request and response examples **Remote/Services88/Dashboard.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDashboardAgent.DeleteDashboardTile">SuperOffice.Services88.IDashboardAgent.DeleteDashboardTile</see> method.

## DeleteDashboardTile

Deletes the DashboardTile

* **dashboardTileId:** The identity of the DashboardTile



[WSDL file for Services88/Dashboard](../Services88-Dashboard.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteDashboardTile Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Dashboard:ApplicationToken>1234567-1234-9876</Dashboard:ApplicationToken>
  <Dashboard:Credentials>
    <Dashboard:Ticket>7T:1234abcxyzExample==</Dashboard:Ticket>
  </Dashboard:Credentials>
 <SOAP-ENV:Body>
   <Dashboard:DeleteDashboardTile>
    <Dashboard:DashboardTileId xsi:type="xsd:int">0</Dashboard:DashboardTileId>
   </Dashboard:DeleteDashboardTile>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteDashboardTile Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Dashboard:DeleteDashboardTileResponse>
  </Dashboard:DeleteDashboardTileResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

