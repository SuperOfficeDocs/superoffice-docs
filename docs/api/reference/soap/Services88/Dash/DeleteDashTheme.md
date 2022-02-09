---
title: Services88.DashAgent.DeleteDashTheme SOAP
generated: 1
uid: Services88-Dash-DeleteDashTheme
---

# Services88 Dash DeleteDashTheme

SOAP request and response examples **Remote/Services88/Dash.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDashAgent.DeleteDashTheme">SuperOffice.Services88.IDashAgent.DeleteDashTheme</see> method.

## DeleteDashTheme

Deletes the DashTheme

* **dashThemeId:** The identity of the DashTheme



[WSDL file for Services88/Dash](../Services88-Dash.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteDashTheme Request

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
   <Dash:DeleteDashTheme>
    <Dash:DashThemeId xsi:type="xsd:int">0</Dash:DashThemeId>
   </Dash:DeleteDashTheme>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteDashTheme Response

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
  <Dash:DeleteDashThemeResponse>
  </Dash:DeleteDashThemeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

