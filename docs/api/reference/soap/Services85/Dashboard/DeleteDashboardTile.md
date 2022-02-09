---
title: Services85.DashboardAgent.DeleteDashboardTile SOAP
generated: 1
uid: Services85-Dashboard-DeleteDashboardTile
---

# Services85 Dashboard DeleteDashboardTile

SOAP request and response examples **Remote/Services85/Dashboard.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IDashboardAgent.DeleteDashboardTile">SuperOffice.Services85.IDashboardAgent.DeleteDashboardTile</see> method.

## DeleteDashboardTile

Deletes the DashboardTile

* **dashboardTileId:** The identity of the DashboardTile



[WSDL file for Services85/Dashboard](../Services85-Dashboard.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteDashboardTile Request

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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Dashboard:DeleteDashboardTileResponse>
  </Dashboard:DeleteDashboardTileResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

