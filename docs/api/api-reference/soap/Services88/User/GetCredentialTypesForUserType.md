---
uid: services88-user-getcredentialtypesforusertype
title: Services88.UserAgent.GetCredentialTypesForUserType SOAP
Generated: true
---

# Services88 User GetCredentialTypesForUserType SOAP

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.GetCredentialTypesForUserType">SuperOffice.Services88.IUserAgent.GetCredentialTypesForUserType</see> method.

## GetCredentialTypesForUserType

Get available credential types that can be used for the specified user type.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **userType:** The user type to retrieve credential types for

**Returns:** Credential types that can be used for authentication


[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCredentialTypesForUserType Request

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
   <User:GetCredentialTypesForUserType>
    <User:UserType xsi:type="User:UserType">Unknown</User:UserType>
   </User:GetCredentialTypesForUserType>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCredentialTypesForUserType Response

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
  <User:GetCredentialTypesForUserTypeResponse>
   <User:Response xsi:type="User:ArrayOfCredentialType">
    <User:CredentialType xsi:type="User:CredentialType">
     <User:DisplayType xsi:type="xsd:string"></User:DisplayType>
     <User:Type xsi:type="xsd:string"></User:Type>
     <User:Description xsi:type="xsd:string"></User:Description>
     <User:ValueControl xsi:type="User:CredentialControlType">Static</User:ValueControl>
     <User:CanCreatePerson xsi:type="xsd:boolean">false</User:CanCreatePerson>
     <User:IsUserNameSupported xsi:type="xsd:boolean">false</User:IsUserNameSupported>
    </User:CredentialType>
   </User:Response>
  </User:GetCredentialTypesForUserTypeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

