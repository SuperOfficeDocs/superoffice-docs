---
title: Services88.MarketingAgent.CalculateMailingStatistics SOAP
generated: 1
uid: Services88-Marketing-CalculateMailingStatistics
---

# Services88 Marketing CalculateMailingStatistics

SOAP request and response examples **Remote/Services88/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IMarketingAgent.CalculateMailingStatistics">SuperOffice.Services88.IMarketingAgent.CalculateMailingStatistics</see> method.

## CalculateMailingStatistics

Calculate open and click rates for one or more mailings

* **shipmentId:** If 0, calculate rates for all dirty (are\_statistics\_dirty) shipments

**Returns:** Number of shipments updated with calculated statistics


[WSDL file for Services88/Marketing](../Services88-Marketing.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CalculateMailingStatistics Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Marketing:ApplicationToken>1234567-1234-9876</Marketing:ApplicationToken>
  <Marketing:Credentials>
    <Marketing:Ticket>7T:1234abcxyzExample==</Marketing:Ticket>
  </Marketing:Credentials>
 <SOAP-ENV:Body>
   <Marketing:CalculateMailingStatistics>
    <Marketing:ShipmentId xsi:type="xsd:int">0</Marketing:ShipmentId>
   </Marketing:CalculateMailingStatistics>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CalculateMailingStatistics Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Marketing:CalculateMailingStatisticsResponse>
   <Marketing:Response xsi:type="xsd:int">0</Marketing:Response>
  </Marketing:CalculateMailingStatisticsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

