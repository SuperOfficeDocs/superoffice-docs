---
title: Services84.DocumentAgent.GetCheckoutState SOAP
generated: 1
uid: Services84-Document-GetCheckoutState
---

# Services84 Document GetCheckoutState

SOAP request and response examples **Remote/Services84/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IDocumentAgent.GetCheckoutState">SuperOffice.Services84.IDocumentAgent.GetCheckoutState</see> method.

## GetCheckoutState

[WSDL file for Services84/Document](../Services84-Document.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCheckoutState Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services84">
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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services84">
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
