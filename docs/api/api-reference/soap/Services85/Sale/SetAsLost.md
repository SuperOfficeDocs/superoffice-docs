---
uid: services85-sale-setaslost
title: Services85.SaleAgent.SetAsLost SOAP
Generated: true
---

# Services85 Sale SetAsLost SOAP

SOAP request and response examples **Remote/Services85/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISaleAgent.SetAsLost">SuperOffice.Services85.ISaleAgent.SetAsLost</see> method.

## SetAsLost

Change the status of one or more sales to Lost. Note that this does not affect the Completed state of the sale.

* **saleIds:** Array of sale ids to be marked as lost. All normal write access rules apply.



[WSDL file for Services85/Sale](../Services85-Sale.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetAsLost Request

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
   <Sale:SetAsLost>
    <Sale:SaleIds xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Sale:SetAsLostResponse>
  </Sale:SetAsLostResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

