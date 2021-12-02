---
title: Services85.QuoteAgent.AddSaleTypeQuoteAttachment SOAP
generated: 1
uid: Services85-Quote-AddSaleTypeQuoteAttachment
---

# Services85 Quote AddSaleTypeQuoteAttachment

SOAP request and response examples **Remote/Services85/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IQuoteAgent.AddSaleTypeQuoteAttachment">SuperOffice.Services85.IQuoteAgent.AddSaleTypeQuoteAttachment</see> method.

## AddSaleTypeQuoteAttachment

Adds a new quote attachment document to a sale type

* **saleTypeId:** The ID of the sale type
* **documentId:** The ID of the document

**Returns:** ID of the new sale type quote attachment row


[WSDL file for Services85/Quote](../Services85-Quote.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddSaleTypeQuoteAttachment Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:AddSaleTypeQuoteAttachment>
    <Quote:SaleTypeId xsi:type="xsd:int">0</Quote:SaleTypeId>
    <Quote:DocumentId xsi:type="xsd:int">0</Quote:DocumentId>
   </Quote:AddSaleTypeQuoteAttachment>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddSaleTypeQuoteAttachment Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Quote:AddSaleTypeQuoteAttachmentResponse>
   <Quote:Response xsi:type="xsd:int">0</Quote:Response>
  </Quote:AddSaleTypeQuoteAttachmentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

