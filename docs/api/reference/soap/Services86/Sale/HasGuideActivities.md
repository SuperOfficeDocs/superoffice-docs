---
title: Services86.SaleAgent.HasGuideActivities SOAP
generated: 1
uid: Services86-Sale-HasGuideActivities
---

# Services86 Sale HasGuideActivities

SOAP request and response examples **Remote/Services86/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ISaleAgent.HasGuideActivities">SuperOffice.Services86.ISaleAgent.HasGuideActivities</see> method.

## HasGuideActivities



* **saleId:** 



[WSDL file for Services86/Sale](../Services86-Sale.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## HasGuideActivities Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:HasGuideActivities>
    <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
   </Sale:HasGuideActivities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## HasGuideActivities Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Sale:HasGuideActivitiesResponse>
   <Sale:Response xsi:type="xsd:boolean">false</Sale:Response>
  </Sale:HasGuideActivitiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

