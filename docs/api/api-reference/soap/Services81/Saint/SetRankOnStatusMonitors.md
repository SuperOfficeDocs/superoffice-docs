---
uid: services81-saint-setrankonstatusmonitors
title: Services81.SaintAgent.SetRankOnStatusMonitors SOAP
Generated: true
---

# Services81 Saint SetRankOnStatusMonitors SOAP

SOAP request and response examples **Remote/Services81/Saint.svc**
Implemented by the <see cref="M:SuperOffice.Services81.ISaintAgent.SetRankOnStatusMonitors">SuperOffice.Services81.ISaintAgent.SetRankOnStatusMonitors</see> method.

## SetRankOnStatusMonitors

Set rank order on status monitors

* **type:** Type of status monitors to reorder ("contact", "project", etc.)
* **itemsIds:** The ids of the items in the order you want

**Returns:** This method has no return value


[WSDL file for Services81/Saint](../Services81-Saint.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetRankOnStatusMonitors Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Saint:ApplicationToken>1234567-1234-9876</Saint:ApplicationToken>
  <Saint:Credentials>
    <Saint:Ticket>7T:1234abcxyzExample==</Saint:Ticket>
  </Saint:Credentials>
 <SOAP-ENV:Body>
   <Saint:SetRankOnStatusMonitors>
    <Saint:Type xsi:type="xsd:string"></Saint:Type>
    <Saint:ItemsIds xsi:type="NetServerServices812:ArrayOfint">
     <NetServerServices812:int xsi:type="xsd:int">0</NetServerServices812:int>
    </Saint:ItemsIds>
   </Saint:SetRankOnStatusMonitors>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetRankOnStatusMonitors Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Saint:SetRankOnStatusMonitorsResponse>
  </Saint:SetRankOnStatusMonitorsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

