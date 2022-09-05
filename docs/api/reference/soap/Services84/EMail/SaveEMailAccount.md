---
title: Services84.EMailAgent.SaveEMailAccount SOAP
generated: 1
uid: Services84-EMail-SaveEMailAccount
---

# Services84 EMail SaveEMailAccount

SOAP request and response examples **Remote/Services84/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IEMailAgent.SaveEMailAccount">SuperOffice.Services84.IEMailAgent.SaveEMailAccount</see> method.

## SaveEMailAccount

Updates the existing EMailAccount or creates a new EMailAccount if the id parameter is 0.

* **eMailAccount:** The EMailAccount that is saved.

**Returns:** New or updated EMailAccount


[WSDL file for Services84/EMail](../Services84-EMail.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveEMailAccount Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:SaveEMailAccount>
    <EMail:EMailAccount xsi:type="EMail:EMailAccount">
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
    </EMail:EMailAccount>
   </EMail:SaveEMailAccount>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveEMailAccount Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <EMail:SaveEMailAccountResponse>
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
  </EMail:SaveEMailAccountResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

