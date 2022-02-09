---
title: Services85.SaleAgent.DeleteSaleStakeholder SOAP
generated: 1
uid: Services85-Sale-DeleteSaleStakeholder
---

# Services85 Sale DeleteSaleStakeholder

SOAP request and response examples **Remote/Services85/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISaleAgent.DeleteSaleStakeholder">SuperOffice.Services85.ISaleAgent.DeleteSaleStakeholder</see> method.

## DeleteSaleStakeholder

Deletes the SaleStakeholder

* **saleStakeholderId:** The identity of the SaleStakeholder



[WSDL file for Services85/Sale](../Services85-Sale.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteSaleStakeholder Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:DeleteSaleStakeholder>
    <Sale:SaleStakeholderId xsi:type="xsd:int">0</Sale:SaleStakeholderId>
   </Sale:DeleteSaleStakeholder>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteSaleStakeholder Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Sale:DeleteSaleStakeholderResponse>
  </Sale:DeleteSaleStakeholderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

