---
title: Services88.DashAgent.DeleteDashTile SOAP
generated: 1
uid: Services88-Dash-DeleteDashTile
---

# Services88 Dash DeleteDashTile

SOAP request and response examples **Remote/Services88/Dash.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDashAgent.DeleteDashTile">SuperOffice.Services88.IDashAgent.DeleteDashTile</see> method.

## DeleteDashTile

Deletes the DashTile

* **dashTileId:** The identity of the DashTile



[WSDL file for Services88/Dash](../Services88-Dash.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteDashTile Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dash="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Dash:ApplicationToken>1234567-1234-9876</Dash:ApplicationToken>
  <Dash:Credentials>
    <Dash:Ticket>7T:1234abcxyzExample==</Dash:Ticket>
  </Dash:Credentials>
 <SOAP-ENV:Body>
   <Dash:DeleteDashTile>
    <Dash:DashTileId xsi:type="xsd:int">0</Dash:DashTileId>
   </Dash:DeleteDashTile>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteDashTile Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dash="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Dash:DeleteDashTileResponse>
  </Dash:DeleteDashTileResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

