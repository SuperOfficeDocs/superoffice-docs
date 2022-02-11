---
title: Services85.UserAgent.GetUntrustedCredentialsForAssociate SOAP
generated: 1
uid: Services85-User-GetUntrustedCredentialsForAssociate
---

# Services85 User GetUntrustedCredentialsForAssociate

SOAP request and response examples **Remote/Services85/User.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IUserAgent.GetUntrustedCredentialsForAssociate">SuperOffice.Services85.IUserAgent.GetUntrustedCredentialsForAssociate</see> method.

## GetUntrustedCredentialsForAssociate

Get a set of credentials of a specified type for a specified user. SecretValue is only populated for authenticated user, and system users.

* **associateId:** Id of user to retrieve credentials for.
* **type:** Type of credential(Ex: "imap", "smtp").

**Returns:** Array of credentials of the specified type.


[WSDL file for Services85/User](../Services85-User.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUntrustedCredentialsForAssociate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:GetUntrustedCredentialsForAssociate>
    <User:AssociateId xsi:type="xsd:int">0</User:AssociateId>
    <User:Type xsi:type="xsd:string"></User:Type>
   </User:GetUntrustedCredentialsForAssociate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUntrustedCredentialsForAssociate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <User:GetUntrustedCredentialsForAssociateResponse>
   <User:Response xsi:type="User:ArrayOfUntrustedCredentials">
    <User:UntrustedCredentials xsi:type="User:UntrustedCredentials">
     <User:ValidFrom xsi:type="xsd:dateTime">2021-11-30T13:22:44Z</User:ValidFrom>
     <User:ValidTo xsi:type="xsd:dateTime">2021-11-30T13:22:44Z</User:ValidTo>
     <User:Comment xsi:type="xsd:string"></User:Comment>
     <User:SecretValue xsi:type="xsd:string"></User:SecretValue>
     <User:PublicValue xsi:type="xsd:string"></User:PublicValue>
     <User:IsActive xsi:type="xsd:boolean">false</User:IsActive>
    </User:UntrustedCredentials>
   </User:Response>
  </User:GetUntrustedCredentialsForAssociateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

