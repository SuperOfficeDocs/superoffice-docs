---
uid: services88-sale-getnextduedate
title: Services88.SaleAgent.GetNextDueDate SOAP
Generated: true
---

# Services88 Sale GetNextDueDate SOAP

SOAP request and response examples **Remote/Services88/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISaleAgent.GetNextDueDate">SuperOffice.Services88.ISaleAgent.GetNextDueDate</see> method.

## GetNextDueDate

Gets the next due date for a sale. The next due date is the next future appointment that is not completed.

* **saleId:** Sale id

**Returns:** Next due date for the given sale.


[WSDL file for Services88/Sale](../Services88-Sale.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNextDueDate Request

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
   <Sale:GetNextDueDate>
    <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
   </Sale:GetNextDueDate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNextDueDate Response

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
  <Sale:GetNextDueDateResponse>
   <Sale:Response xsi:type="xsd:dateTime">2021-03-25T21:37:10Z</Sale:Response>
  </Sale:GetNextDueDateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

