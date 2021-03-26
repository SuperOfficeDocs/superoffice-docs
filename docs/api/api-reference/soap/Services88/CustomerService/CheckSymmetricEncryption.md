---
uid: services88-customerservice-checksymmetricencryption
title: Services88.CustomerServiceAgent.CheckSymmetricEncryption SOAP
Generated: true
---

# Services88 CustomerService CheckSymmetricEncryption SOAP

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.CheckSymmetricEncryption">SuperOffice.Services88.ICustomerServiceAgent.CheckSymmetricEncryption</see> method.

## CheckSymmetricEncryption

Do a test to check that we are using the same encryption keys

* **encryptedString:** An encrypted version of the string

**Returns:** Encrypted version of the string done by NetServer


[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CheckSymmetricEncryption Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:CheckSymmetricEncryption>
    <CustomerService:EncryptedString xsi:type="xsd:string"></CustomerService:EncryptedString>
   </CustomerService:CheckSymmetricEncryption>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CheckSymmetricEncryption Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <CustomerService:CheckSymmetricEncryptionResponse>
   <CustomerService:Response xsi:type="xsd:string"></CustomerService:Response>
  </CustomerService:CheckSymmetricEncryptionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

