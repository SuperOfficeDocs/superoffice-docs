---
title: Services88.SaleAgent.SetAsLostWithReason SOAP
generated: true
uid: Services88-Sale-SetAsLostWithReason
---

# Services88 Sale SetAsLostWithReason

SOAP request and response examples **Remote/Services88/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISaleAgent.SetAsLostWithReason">SuperOffice.Services88.ISaleAgent.SetAsLostWithReason</see> method.

## SetAsLostWithReason





[WSDL file for Services88/Sale](../Services88-Sale.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetAsLostWithReason Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:SetAsLostWithReason>
    <Sale:SaleIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Sale:SaleIds>
    <Sale:ReasonId xsi:type="xsd:int">0</Sale:ReasonId>
   </Sale:SetAsLostWithReason>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetAsLostWithReason Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Sale:SetAsLostWithReasonResponse>
  </Sale:SetAsLostWithReasonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

