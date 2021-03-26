---
uid: services82-sale-setaslost
title: Services82.SaleAgent.SetAsLost SOAP
Generated: true
---

# Services82 Sale SetAsLost SOAP

SOAP request and response examples **Remote/Services82/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services82.ISaleAgent.SetAsLost">SuperOffice.Services82.ISaleAgent.SetAsLost</see> method.

## SetAsLost

Change the status of one or more sales to Lost. Note that this does not affect the Completed state of the sale.

* **saleIds:** Array of sale ids to be marked as lost. All normal write access rules apply.



[WSDL file for Services82/Sale](../Services82-Sale.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetAsLost Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:SetAsLost>
    <Sale:SaleIds xsi:type="NetServerServices822:ArrayOfint">
     <NetServerServices822:int xsi:type="xsd:int">0</NetServerServices822:int>
    </Sale:SaleIds>
   </Sale:SetAsLost>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetAsLost Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Sale:SetAsLostResponse>
  </Sale:SetAsLostResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

