---
uid: services83-dashboard-deletedashboard
title: Services83.DashboardAgent.DeleteDashboard SOAP
Generated: true
---

# Services83 Dashboard DeleteDashboard SOAP

SOAP request and response examples **Remote/Services83/Dashboard.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IDashboardAgent.DeleteDashboard">SuperOffice.Services83.IDashboardAgent.DeleteDashboard</see> method.

## DeleteDashboard

Deletes the Dashboard

* **dashboardId:** The identity of the Dashboard



[WSDL file for Services83/Dashboard](../Services83-Dashboard.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteDashboard Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services83">
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
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dashboard="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Dashboard:DeleteDashboardResponse>
  </Dashboard:DeleteDashboardResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

