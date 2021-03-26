---
uid: services75-freetext-setmultiwordoperator
title: Services75.FreeTextAgent.SetMultiWordOperator SOAP
Generated: true
---

# Services75 FreeText SetMultiWordOperator SOAP

SOAP request and response examples **Remote/Services75/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IFreeTextAgent.SetMultiWordOperator">SuperOffice.Services75.IFreeTextAgent.SetMultiWordOperator</see> method.

## SetMultiWordOperator

Sets the operator used when matching multiple words

* **freeTextOperator:** The operator

**Returns:** No return value


[WSDL file for Services75/FreeText](../Services75-FreeText.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetMultiWordOperator Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <FreeText:ApplicationToken>1234567-1234-9876</FreeText:ApplicationToken>
  <FreeText:Credentials>
    <FreeText:Ticket>7T:1234abcxyzExample==</FreeText:Ticket>
  </FreeText:Credentials>
 <SOAP-ENV:Body>
   <FreeText:SetMultiWordOperator>
    <FreeText:FreeTextOperator xsi:type="FreeText:FreeTextOperator">Contains</FreeText:FreeTextOperator>
   </FreeText:SetMultiWordOperator>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetMultiWordOperator Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <FreeText:SetMultiWordOperatorResponse>
  </FreeText:SetMultiWordOperatorResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

