---
uid: services88-user-removeuntrustedcredentialsforassociate
title: Services88.UserAgent.RemoveUntrustedCredentialsForAssociate SOAP
Generated: true
---

# Services88 User RemoveUntrustedCredentialsForAssociate SOAP

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.RemoveUntrustedCredentialsForAssociate">SuperOffice.Services88.IUserAgent.RemoveUntrustedCredentialsForAssociate</see> method.

## RemoveUntrustedCredentialsForAssociate

Remove a credentials entry for a specified user.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **associateId:** Id of user to remove credentials for.
* **type:** Type of credential(Ex: "imap", "smtp")
* **publicValue:** PublicValue field of credentials to remove.



[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveUntrustedCredentialsForAssociate Request

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
   <User:RemoveUntrustedCredentialsForAssociate>
    <User:AssociateId xsi:type="xsd:int">0</User:AssociateId>
    <User:Type xsi:type="xsd:string"></User:Type>
    <User:PublicValue xsi:type="xsd:string"></User:PublicValue>
   </User:RemoveUntrustedCredentialsForAssociate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveUntrustedCredentialsForAssociate Response

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
  <User:RemoveUntrustedCredentialsForAssociateResponse>
  </User:RemoveUntrustedCredentialsForAssociateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

