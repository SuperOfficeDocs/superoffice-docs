---
uid: services83-sale-setassold
title: Services83.SaleAgent.SetAsSold SOAP
Generated: true
---

# Services83 Sale SetAsSold SOAP

SOAP request and response examples **Remote/Services83/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services83.ISaleAgent.SetAsSold">SuperOffice.Services83.ISaleAgent.SetAsSold</see> method.

## SetAsSold

Change the status of one or more Sales to Sold. Note that this does not mark them as Completed.

* **saleIds:** Array of sale ids to be marked as lost. All the normal write access rules apply.



[WSDL file for Services83/Sale](../Services83-Sale.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetAsSold Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:SetAsSold>
    <Sale:SaleIds xsi:type="NetServerServices832:ArrayOfint">
     <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
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
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Sale:SetAsSoldResponse>
  </Sale:SetAsSoldResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

