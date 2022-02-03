---
title: Services86.SaleAgent.GetNextDueDate SOAP
generated: 1
uid: Services86-Sale-GetNextDueDate
---

# Services86 Sale GetNextDueDate

SOAP request and response examples **Remote/Services86/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ISaleAgent.GetNextDueDate">SuperOffice.Services86.ISaleAgent.GetNextDueDate</see> method.

## GetNextDueDate

Gets the next due date for a sale. The next due date is the next future appointment that is not completed.

* **saleId:** Sale id

**Returns:** Next due date for the given sale.


[WSDL file for Services86/Sale](../Services86-Sale.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNextDueDate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Sale:GetNextDueDateResponse>
   <Sale:Response xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Sale:Response>
  </Sale:GetNextDueDateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

