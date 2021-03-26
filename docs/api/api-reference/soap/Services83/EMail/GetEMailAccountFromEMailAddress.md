---
uid: services83-email-getemailaccountfromemailaddress
title: Services83.EMailAgent.GetEMailAccountFromEMailAddress SOAP
Generated: true
---

# Services83 EMail GetEMailAccountFromEMailAddress SOAP

SOAP request and response examples **Remote/Services83/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IEMailAgent.GetEMailAccountFromEMailAddress">SuperOffice.Services83.IEMailAgent.GetEMailAccountFromEMailAddress</see> method.

## GetEMailAccountFromEMailAddress

Returns the email account corresponding to this email address (for the current associate).

* **fromAddress:** The address associated with this email account

**Returns:** Found or empty email account


[WSDL file for Services83/EMail](../Services83-EMail.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetEMailAccountFromEMailAddress Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetEMailAccountFromEMailAddress>
    <EMail:FromAddress xsi:type="xsd:string"></EMail:FromAddress>
   </EMail:GetEMailAccountFromEMailAddress>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetEMailAccountFromEMailAddress Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <EMail:GetEMailAccountFromEMailAddressResponse>
   <EMail:Response xsi:type="EMail:EMailAccount">
    <EMail:EMailAccountId xsi:type="xsd:int">0</EMail:EMailAccountId>
    <EMail:EMailAddress xsi:type="xsd:string"></EMail:EMailAddress>
    <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
    <EMail:IncomingCredentials xsi:type="EMail:ServiceAuth">
     <EMail:ServiceAuthId xsi:type="xsd:int">0</EMail:ServiceAuthId>
     <EMail:Server xsi:type="xsd:string"></EMail:Server>
     <EMail:Port xsi:type="xsd:int">0</EMail:Port>
     <EMail:AuthType xsi:type="xsd:string"></EMail:AuthType>
     <EMail:Username xsi:type="xsd:string"></EMail:Username>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
    </EMail:IncomingCredentials>
    <EMail:OutgoingCredentials xsi:type="EMail:ServiceAuth">
     <EMail:ServiceAuthId xsi:type="xsd:int">0</EMail:ServiceAuthId>
     <EMail:Server xsi:type="xsd:string"></EMail:Server>
     <EMail:Port xsi:type="xsd:int">0</EMail:Port>
     <EMail:AuthType xsi:type="xsd:string"></EMail:AuthType>
     <EMail:Username xsi:type="xsd:string"></EMail:Username>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
    </EMail:OutgoingCredentials>
    <EMail:AccountStatus xsi:type="xsd:short">0</EMail:AccountStatus>
    <EMail:ErrorCount xsi:type="xsd:int">0</EMail:ErrorCount>
    <EMail:ErrorReason xsi:type="xsd:string"></EMail:ErrorReason>
   </EMail:Response>
  </EMail:GetEMailAccountFromEMailAddressResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

