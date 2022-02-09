---
title: Services88.DashAgent.SaveDashTheme SOAP
generated: 1
uid: Services88-Dash-SaveDashTheme
---

# Services88 Dash SaveDashTheme

SOAP request and response examples **Remote/Services88/Dash.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDashAgent.SaveDashTheme">SuperOffice.Services88.IDashAgent.SaveDashTheme</see> method.

## SaveDashTheme

Updates the existing DashTheme or creates a new DashTheme if the id parameter is 0.

* **dashTheme:** The DashTheme that is saved.

**Returns:** New or updated DashTheme


[WSDL file for Services88/Dash](../Services88-Dash.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveDashTheme Request

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
   <Dash:SaveDashTheme>
    <Dash:DashTheme xsi:type="Dash:DashTheme">
     <Dash:DashboardThemeId xsi:type="xsd:int">0</Dash:DashboardThemeId>
     <Dash:Name xsi:type="xsd:string"></Dash:Name>
     <Dash:Config xsi:type="xsd:string"></Dash:Config>
     <Dash:Rank xsi:type="xsd:short">0</Dash:Rank>
     <Dash:Client xsi:type="xsd:string"></Dash:Client>
     <Dash:Style xsi:type="xsd:string"></Dash:Style>
    </Dash:DashTheme>
   </Dash:SaveDashTheme>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveDashTheme Response

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
  <Dash:SaveDashThemeResponse>
   <Dash:Response xsi:type="Dash:DashTheme">
    <Dash:DashboardThemeId xsi:type="xsd:int">0</Dash:DashboardThemeId>
    <Dash:Name xsi:type="xsd:string"></Dash:Name>
    <Dash:Config xsi:type="xsd:string"></Dash:Config>
    <Dash:Rank xsi:type="xsd:short">0</Dash:Rank>
    <Dash:Client xsi:type="xsd:string"></Dash:Client>
    <Dash:Style xsi:type="xsd:string"></Dash:Style>
   </Dash:Response>
  </Dash:SaveDashThemeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

