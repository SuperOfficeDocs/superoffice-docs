---
uid: services80-sale-deletesaleentity
title: Services80.SaleAgent.DeleteSaleEntity SOAP
Generated: true
---

# Services80 Sale DeleteSaleEntity SOAP

SOAP request and response examples **Remote/Services80/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services80.ISaleAgent.DeleteSaleEntity">SuperOffice.Services80.ISaleAgent.DeleteSaleEntity</see> method.

## DeleteSaleEntity

Deletes the SaleEntity

* **saleEntityId:** The identity of the SaleEntity



[WSDL file for Services80/Sale](../Services80-Sale.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteSaleEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:DeleteSaleEntity>
    <Sale:SaleEntityId xsi:type="xsd:int">0</Sale:SaleEntityId>
   </Sale:DeleteSaleEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteSaleEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Sale:DeleteSaleEntityResponse>
  </Sale:DeleteSaleEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

