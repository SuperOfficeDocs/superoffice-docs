---
uid: services84-dashboard-deletedashboard
title: Services84.DashboardAgent.DeleteDashboard SOAP
Generated: true
---

# Services84 Dashboard DeleteDashboard SOAP

SOAP request and response examples **Remote/Services84/Dashboard.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IDashboardAgent.DeleteDashboard">SuperOffice.Services84.IDashboardAgent.DeleteDashboard</see> method.

## DeleteDashboard

Deletes the Dashboard

* **dashboardId:** The identity of the Dashboard



[WSDL file for Services84/Dashboard](../Services84-Dashboard.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteDashboard Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Dashboard:ApplicationToken>1234567-1234-9876</Dashboard:ApplicationToken>
  <Dashboard:Credentials>
    <Dashboard:Ticket>7T:1234abcxyzExample==</Dashboard:Ticket>
  </Dashboard:Credentials>
 <SOAP-ENV:Body>
   <Dashboard:DeleteDashboard>
    <Dashboard:DashboardId xsi:type="xsd:int">0</Dashboard:DashboardId>
   </Dashboard:DeleteDashboard>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteDashboard Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Dashboard:DeleteDashboardResponse>
  </Dashboard:DeleteDashboardResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

