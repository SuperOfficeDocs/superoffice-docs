---
title: Services88.DashAgent.CreateDefaultPreviewDashTile SOAP
generated: true
uid: Services88-Dash-CreateDefaultPreviewDashTile
content_type: reference
---

# Services88 Dash CreateDefaultPreviewDashTile

SOAP request and response examples **Remote/Services88/Dash.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDashAgent.CreateDefaultPreviewDashTile">SuperOffice.Services88.IDashAgent.CreateDefaultPreviewDashTile</see> method.

## CreateDefaultPreviewDashTile





[WSDL file for Services88/Dash](../Services88-Dash.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultPreviewDashTile Request

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
   <Dash:CreateDefaultPreviewDashTile>
   </Dash:CreateDefaultPreviewDashTile>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultPreviewDashTile Response

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
  <Dash:CreateDefaultPreviewDashTileResponse>
   <Dash:Response xsi:type="Dash:PreviewDashTile">
    <Dash:Name xsi:type="xsd:string"></Dash:Name>
    <Dash:TileType xsi:type="Dash:DashTileType">None</Dash:TileType>
   </Dash:Response>
  </Dash:CreateDefaultPreviewDashTileResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

