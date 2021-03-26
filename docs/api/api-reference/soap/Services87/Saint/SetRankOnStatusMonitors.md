---
uid: services87-saint-setrankonstatusmonitors
title: Services87.SaintAgent.SetRankOnStatusMonitors SOAP
Generated: true
---

# Services87 Saint SetRankOnStatusMonitors SOAP

SOAP request and response examples **Remote/Services87/Saint.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ISaintAgent.SetRankOnStatusMonitors">SuperOffice.Services87.ISaintAgent.SetRankOnStatusMonitors</see> method.

## SetRankOnStatusMonitors

Set rank order on status monitors

* **type:** Type of status monitors to reorder ("contact", "project", etc.)
* **itemsIds:** The ids of the items in the order you want

**Returns:** This method has no return value


[WSDL file for Services87/Saint](../Services87-Saint.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetRankOnStatusMonitors Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Saint:ApplicationToken>1234567-1234-9876</Saint:ApplicationToken>
  <Saint:Credentials>
    <Saint:Ticket>7T:1234abcxyzExample==</Saint:Ticket>
  </Saint:Credentials>
 <SOAP-ENV:Body>
   <Saint:SetRankOnStatusMonitors>
    <Saint:Type xsi:type="xsd:string"></Saint:Type>
    <Saint:ItemsIds xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Saint:SetRankOnStatusMonitorsResponse>
  </Saint:SetRankOnStatusMonitorsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

