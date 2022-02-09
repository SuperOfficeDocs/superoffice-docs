---
title: Services87.DocumentAgent.GetCheckoutState SOAP
generated: 1
uid: Services87-Document-GetCheckoutState
---

# Services87 Document GetCheckoutState

SOAP request and response examples **Remote/Services87/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IDocumentAgent.GetCheckoutState">SuperOffice.Services87.IDocumentAgent.GetCheckoutState</see> method.

## GetCheckoutState

Get the current checkout state for a document, relative to the user perforing the call.

* **documentId:** SuperOffice document ID

**Returns:** Current checkout state of the document


[WSDL file for Services87/Document](../Services87-Document.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCheckoutState Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetCheckoutState>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
   </Document:GetCheckoutState>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCheckoutState Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Document:GetCheckoutStateResponse>
   <Document:Response xsi:type="Document:CheckoutInfo">
    <Document:State xsi:type="Document:CheckoutState">NotCheckedOut</Document:State>
    <Document:AssociateId xsi:type="xsd:int">0</Document:AssociateId>
    <Document:Name xsi:type="xsd:string"></Document:Name>
   </Document:Response>
  </Document:GetCheckoutStateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

