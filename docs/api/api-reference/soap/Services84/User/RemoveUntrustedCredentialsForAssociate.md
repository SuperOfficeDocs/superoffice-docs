---
uid: services84-user-removeuntrustedcredentialsforassociate
title: Services84.UserAgent.RemoveUntrustedCredentialsForAssociate SOAP
Generated: true
---

# Services84 User RemoveUntrustedCredentialsForAssociate SOAP

SOAP request and response examples **Remote/Services84/User.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IUserAgent.RemoveUntrustedCredentialsForAssociate">SuperOffice.Services84.IUserAgent.RemoveUntrustedCredentialsForAssociate</see> method.

## RemoveUntrustedCredentialsForAssociate

Remove a credentials entry for a specified user.

* **associateId:** Id of user to remove credentials for.
* **type:** Type of credential(Ex: "imap", "smtp")
* **publicValue:** PublicValue field of credentials to remove.



[WSDL file for Services84/User](../Services84-User.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveUntrustedCredentialsForAssociate Request

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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <User:RemoveUntrustedCredentialsForAssociateResponse>
  </User:RemoveUntrustedCredentialsForAssociateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

