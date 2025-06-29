---
title: Services88.DashAgent.CreateDefaultPreviewDash SOAP
generated: true
uid: Services88-Dash-CreateDefaultPreviewDash
---

# Services88 Dash CreateDefaultPreviewDash

SOAP request and response examples **Remote/Services88/Dash.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDashAgent.CreateDefaultPreviewDash">SuperOffice.Services88.IDashAgent.CreateDefaultPreviewDash</see> method.

## CreateDefaultPreviewDash





[WSDL file for Services88/Dash](../Services88-Dash.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultPreviewDash Request

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
   <Dash:CreateDefaultPreviewDash>
   </Dash:CreateDefaultPreviewDash>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultPreviewDash Response

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
  <Dash:CreateDefaultPreviewDashResponse>
   <Dash:Response xsi:type="Dash:PreviewDash">
    <Dash:DashboardId xsi:type="xsd:int">0</Dash:DashboardId>
    <Dash:Name xsi:type="xsd:string"></Dash:Name>
    <Dash:Description xsi:type="xsd:string"></Dash:Description>
    <Dash:OwnedByFullName xsi:type="xsd:string"></Dash:OwnedByFullName>
    <Dash:Registered xsi:type="xsd:dateTime">2025-06-26T01:43:28Z</Dash:Registered>
    <Dash:Tiles xsi:type="Dash:ArrayOfPreviewDashTile">
     <Dash:PreviewDashTile xsi:type="Dash:PreviewDashTile">
      <Dash:Name xsi:type="xsd:string"></Dash:Name>
      <Dash:TileType xsi:type="Dash:DashTileType">None</Dash:TileType>
     </Dash:PreviewDashTile>
    </Dash:Tiles>
   </Dash:Response>
  </Dash:CreateDefaultPreviewDashResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

