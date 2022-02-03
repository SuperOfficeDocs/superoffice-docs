---
title: Services84.SaleAgent.SetAsSold SOAP
generated: 1
uid: Services84-Sale-SetAsSold
---

# Services84 Sale SetAsSold

SOAP request and response examples **Remote/Services84/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ISaleAgent.SetAsSold">SuperOffice.Services84.ISaleAgent.SetAsSold</see> method.

## SetAsSold

Change the status of one or more Sales to Sold. Note that this does not mark them as Completed.

* **saleIds:** Array of sale ids to be marked as lost. All the normal write access rules apply.



[WSDL file for Services84/Sale](../Services84-Sale.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetAsSold Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:SetAsSold>
    <Sale:SaleIds xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </Sale:SaleIds>
   </Sale:SetAsSold>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetAsSold Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Sale:SetAsSoldResponse>
  </Sale:SetAsSoldResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

