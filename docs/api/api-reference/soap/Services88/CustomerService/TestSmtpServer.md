---
uid: services88-customerservice-testsmtpserver
title: Services88.CustomerServiceAgent.TestSmtpServer SOAP
Generated: true
---

# Services88 CustomerService TestSmtpServer SOAP

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.TestSmtpServer">SuperOffice.Services88.ICustomerServiceAgent.TestSmtpServer</see> method.

## TestSmtpServer

This method will do a test of a SMTP account, by sending an email to a special @superoffice.com account

* **smtpUri:** An URI containing information to connect to the SMTP server, eg. smtps://myuser:mypassword@smtp.myserver.com:465. Note that username and password must be url encoded
* **from:** The from-address used in the test
* **useStoredPassword:** Use database persisted password

**Returns:** Contains the result of the test


[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## TestSmtpServer Request

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
   <CustomerService:TestSmtpServer>
    <CustomerService:SmtpUri xsi:type="xsd:string"></CustomerService:SmtpUri>
    <CustomerService:From xsi:type="xsd:string"></CustomerService:From>
    <CustomerService:UseStoredPassword xsi:type="xsd:boolean">false</CustomerService:UseStoredPassword>
   </CustomerService:TestSmtpServer>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## TestSmtpServer Response

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
  <CustomerService:TestSmtpServerResponse>
   <CustomerService:Response xsi:type="CustomerService:SmtpTestResult">
    <CustomerService:Success xsi:type="xsd:boolean">false</CustomerService:Success>
    <CustomerService:ErrorMessage xsi:type="xsd:string"></CustomerService:ErrorMessage>
   </CustomerService:Response>
  </CustomerService:TestSmtpServerResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

