---
title: Services88.DashAgent.GetDashTileDefinition SOAP
generated: 1
uid: Services88-Dash-GetDashTileDefinition
---

# Services88 Dash GetDashTileDefinition

SOAP request and response examples **Remote/Services88/Dash.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDashAgent.GetDashTileDefinition">SuperOffice.Services88.IDashAgent.GetDashTileDefinition</see> method.

## GetDashTileDefinition

Gets a DashTileDefinition object.

* **dashTileDefinitionId:** The identifier of the DashTileDefinition object

**Returns:** DashTileDefinition

[WSDL file for Services88/Dash](../Services88-Dash.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDashTileDefinition Request

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
   <Dash:GetDashTileDefinition>
    <Dash:DashTileDefinitionId xsi:type="xsd:int">0</Dash:DashTileDefinitionId>
   </Dash:GetDashTileDefinition>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetDashTileDefinition Response

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
  <Dash:GetDashTileDefinitionResponse>
   <Dash:Response xsi:type="Dash:DashTileDefinition">
    <Dash:DashboardTileDefinitionId xsi:type="xsd:int">0</Dash:DashboardTileDefinitionId>
    <Dash:Name xsi:type="xsd:string"></Dash:Name>
    <Dash:Description xsi:type="xsd:string"></Dash:Description>
    <Dash:DefaultHeight xsi:type="xsd:int">0</Dash:DefaultHeight>
    <Dash:DefaultWidth xsi:type="xsd:int">0</Dash:DefaultWidth>
    <Dash:TileType xsi:type="Dash:DashTileType">None</Dash:TileType>
    <Dash:EntityType xsi:type="Dash:DashTileEntityType">None</Dash:EntityType>
    <Dash:EntityName xsi:type="xsd:string"></Dash:EntityName>
    <Dash:SelectionId xsi:type="xsd:int">0</Dash:SelectionId>
    <Dash:CurrencyMode xsi:type="Dash:DashTileCurrencyMode">None</Dash:CurrencyMode>
    <Dash:CurrencyCode xsi:type="xsd:string"></Dash:CurrencyCode>
    <Dash:Measure xsi:type="Dash:DashTileMeasure">None</Dash:Measure>
    <Dash:MeasureField xsi:type="xsd:string"></Dash:MeasureField>
    <Dash:SortBy xsi:type="xsd:string"></Dash:SortBy>
    <Dash:LayoutConfig xsi:type="xsd:string"></Dash:LayoutConfig>
    <Dash:SecondarySelectionId xsi:type="xsd:int">0</Dash:SecondarySelectionId>
    <Dash:MeasureByField xsi:type="xsd:string"></Dash:MeasureByField>
    <Dash:Usage xsi:type="Dash:DashTileUsage">Dashboard</Dash:Usage>
    <Dash:ProviderName xsi:type="xsd:string"></Dash:ProviderName>
   </Dash:Response>
  </Dash:GetDashTileDefinitionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
