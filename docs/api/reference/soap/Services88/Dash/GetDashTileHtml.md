---
title: Services88.DashAgent.GetDashTileHtml SOAP
generated: 1
uid: Services88-Dash-GetDashTileHtml
---

# Services88 Dash GetDashTileHtml

SOAP request and response examples **Remote/Services88/Dash.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDashAgent.GetDashTileHtml">SuperOffice.Services88.IDashAgent.GetDashTileHtml</see> method.

## GetDashTileHtml

Get HTML for a dashboard tile definition with TileType = HTML

* **dashboardTileDefinitionId:** The id of the dashboard tile definition
* **languageCode:** Preferred language code.

**Returns:** HTML data


[WSDL file for Services88/Dash](../Services88-Dash.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDashTileHtml Request

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
   <Dash:GetDashTileHtml>
    <Dash:DashboardTileDefinitionId xsi:type="xsd:int">0</Dash:DashboardTileDefinitionId>
    <Dash:LanguageCode xsi:type="xsd:string"></Dash:LanguageCode>
   </Dash:GetDashTileHtml>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDashTileHtml Response

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
  <Dash:GetDashTileHtmlResponse>
   <Dash:Response xsi:type="Dash:DashTileHtml">
    <Dash:LanguageCode xsi:type="xsd:string"></Dash:LanguageCode>
    <Dash:Html xsi:type="xsd:string"></Dash:Html>
   </Dash:Response>
  </Dash:GetDashTileHtmlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

