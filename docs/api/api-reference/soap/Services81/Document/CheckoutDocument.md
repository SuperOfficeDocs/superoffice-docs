---
uid: services81-document-checkoutdocument
title: Services81.DocumentAgent.CheckoutDocument SOAP
Generated: true
---

# Services81 Document CheckoutDocument SOAP

SOAP request and response examples **Remote/Services81/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IDocumentAgent.CheckoutDocument">SuperOffice.Services81.IDocumentAgent.CheckoutDocument</see> method.

## CheckoutDocument

Check out a document for editing by the current user.

* **documentId:** SuperOffice document ID
* **allowedReturnTypes:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.<br />Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.<br />An empty array implies that the client places no restriction on possible return action requests.

**Returns:** Return information, including possible requests for further processing ("Return Action"). Return actions are constrained by the allowedReturnTypes parameter.


[WSDL file for Services81/Document](../Services81-Document.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CheckoutDocument Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:CheckoutDocument>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:AllowedReturnTypes xsi:type="NetServerServices812:ArrayOfstring">
     <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
    </Document:AllowedReturnTypes>
   </Document:CheckoutDocument>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CheckoutDocument Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Document:CheckoutDocumentResponse>
   <Document:Response xsi:type="Document:ReturnInfo">
    <Document:ExternalReference xsi:type="xsd:string"></Document:ExternalReference>
    <Document:VersionId xsi:type="xsd:string"></Document:VersionId>
    <Document:Success xsi:type="xsd:boolean">false</Document:Success>
    <Document:Type xsi:type="Document:ReturnType">None</Document:Type>
    <Document:Value xsi:type="xsd:string"></Document:Value>
    <Document:AdditionalInfo xsi:type="xsd:string"></Document:AdditionalInfo>
   </Document:Response>
  </Document:CheckoutDocumentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

