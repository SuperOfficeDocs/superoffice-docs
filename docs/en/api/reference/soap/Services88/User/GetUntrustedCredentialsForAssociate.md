---
title: Services88.UserAgent.GetUntrustedCredentialsForAssociate SOAP
generated: true
uid: Services88-User-GetUntrustedCredentialsForAssociate
---

# Services88 User GetUntrustedCredentialsForAssociate

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.GetUntrustedCredentialsForAssociate">SuperOffice.Services88.IUserAgent.GetUntrustedCredentialsForAssociate</see> method.

## GetUntrustedCredentialsForAssociate





[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUntrustedCredentialsForAssociate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <User:GetUntrustedCredentialsForAssociateResponse>
   <User:Response xsi:type="User:ArrayOfUntrustedCredentials">
    <User:UntrustedCredentials xsi:type="User:UntrustedCredentials">
     <User:ValidFrom xsi:type="xsd:dateTime">2025-06-26T01:45:06Z</User:ValidFrom>
     <User:ValidTo xsi:type="xsd:dateTime">2025-06-26T01:45:06Z</User:ValidTo>
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

