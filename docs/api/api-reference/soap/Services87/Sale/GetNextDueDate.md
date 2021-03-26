---
uid: services87-sale-getnextduedate
title: Services87.SaleAgent.GetNextDueDate SOAP
Generated: true
---

# Services87 Sale GetNextDueDate SOAP

SOAP request and response examples **Remote/Services87/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ISaleAgent.GetNextDueDate">SuperOffice.Services87.ISaleAgent.GetNextDueDate</see> method.

## GetNextDueDate

Gets the next due date for a sale. The next due date is the next future appointment that is not completed.

* **saleId:** Sale id

**Returns:** Next due date for the given sale.


[WSDL file for Services87/Sale](../Services87-Sale.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNextDueDate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services87">
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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Sale:GetNextDueDateResponse>
   <Sale:Response xsi:type="xsd:dateTime">2021-03-25T21:36:45Z</Sale:Response>
  </Sale:GetNextDueDateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

