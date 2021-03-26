---
uid: services80-sale-deletesalestakeholders
title: Services80.SaleAgent.DeleteSaleStakeholders SOAP
Generated: true
---

# Services80 Sale DeleteSaleStakeholders SOAP

SOAP request and response examples **Remote/Services80/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services80.ISaleAgent.DeleteSaleStakeholders">SuperOffice.Services80.ISaleAgent.DeleteSaleStakeholders</see> method.

## DeleteSaleStakeholders



* **saleStakeholderIds:** 



[WSDL file for Services80/Sale](../Services80-Sale.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteSaleStakeholders Request

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
   <Sale:DeleteSaleStakeholders>
    <Sale:SaleStakeholderIds xsi:type="NetServerServices802:ArrayOfint">
     <NetServerServices802:int xsi:type="xsd:int">0</NetServerServices802:int>
    </Sale:SaleStakeholderIds>
   </Sale:DeleteSaleStakeholders>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteSaleStakeholders Response

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
  <Sale:DeleteSaleStakeholdersResponse>
  </Sale:DeleteSaleStakeholdersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

