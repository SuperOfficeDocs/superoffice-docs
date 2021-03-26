---
uid: services80-user-getcredentialtypes
title: Services80.UserAgent.GetCredentialTypes SOAP
Generated: true
---

# Services80 User GetCredentialTypes SOAP

SOAP request and response examples **Remote/Services80/User.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IUserAgent.GetCredentialTypes">SuperOffice.Services80.IUserAgent.GetCredentialTypes</see> method.

## GetCredentialTypes

Get available credential types that can be used for authentication


**Returns:** Credential types that can be used for authentication


[WSDL file for Services80/User](../Services80-User.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCredentialTypes Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:GetCredentialTypes>
   </User:GetCredentialTypes>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCredentialTypes Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <User:GetCredentialTypesResponse>
   <User:Response xsi:type="User:ArrayOfCredentialType">
    <User:CredentialType xsi:type="User:CredentialType">
     <User:DisplayType xsi:type="xsd:string"></User:DisplayType>
     <User:Type xsi:type="xsd:string"></User:Type>
     <User:Description xsi:type="xsd:string"></User:Description>
     <User:ValueControl xsi:type="User:CredentialControlType">Static</User:ValueControl>
     <User:CanCreatePerson xsi:type="xsd:boolean">false</User:CanCreatePerson>
    </User:CredentialType>
   </User:Response>
  </User:GetCredentialTypesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

