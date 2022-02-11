---
title: Services84.UserAgent.SaveUntrustedCredentials SOAP
generated: 1
uid: Services84-User-SaveUntrustedCredentials
---

# Services84 User SaveUntrustedCredentials

SOAP request and response examples **Remote/Services84/User.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IUserAgent.SaveUntrustedCredentials">SuperOffice.Services84.IUserAgent.SaveUntrustedCredentials</see> method.

## SaveUntrustedCredentials

Save credentials for authenticated user.

* **type:** Type of credential(Ex: "imap", "smtp")
* **credentials:** Credentials to save.



[WSDL file for Services84/User](../Services84-User.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveUntrustedCredentials Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:SaveUntrustedCredentials>
    <User:Type xsi:type="xsd:string"></User:Type>
    <User:Credentials xsi:type="User:UntrustedCredentials">
     <User:ValidFrom xsi:type="xsd:dateTime">2021-11-30T13:22:23Z</User:ValidFrom>
     <User:ValidTo xsi:type="xsd:dateTime">2021-11-30T13:22:23Z</User:ValidTo>
     <User:Comment xsi:type="xsd:string"></User:Comment>
     <User:SecretValue xsi:type="xsd:string"></User:SecretValue>
     <User:PublicValue xsi:type="xsd:string"></User:PublicValue>
     <User:IsActive xsi:type="xsd:boolean">false</User:IsActive>
    </User:Credentials>
   </User:SaveUntrustedCredentials>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveUntrustedCredentials Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <User:SaveUntrustedCredentialsResponse>
  </User:SaveUntrustedCredentialsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

