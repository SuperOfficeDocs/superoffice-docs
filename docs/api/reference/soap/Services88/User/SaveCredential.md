---
title: Services88.UserAgent.SaveCredential SOAP
generated: 1
uid: Services88-User-SaveCredential
---

# Services88 User SaveCredential

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.SaveCredential">SuperOffice.Services88.IUserAgent.SaveCredential</see> method.

## SaveCredential

Save (adds/replaces) current credential of the same type for the user.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **userId:** Primary key of the user (i.e. associate)
* **credential:** Credentials supported for authentication

**Returns:** True if the credential was successfully saved.


[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveCredential Request

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
   <User:SaveCredential>
    <User:UserId xsi:type="xsd:int">0</User:UserId>
    <User:Credential xsi:type="User:Credential">
     <User:Type xsi:type="User:CredentialType">
      <User:DisplayType xsi:type="xsd:string"></User:DisplayType>
      <User:Type xsi:type="xsd:string"></User:Type>
      <User:Description xsi:type="xsd:string"></User:Description>
      <User:ValueControl xsi:type="User:CredentialControlType">Static</User:ValueControl>
      <User:CanCreatePerson xsi:type="xsd:boolean">false</User:CanCreatePerson>
      <User:IsUserNameSupported xsi:type="xsd:boolean">false</User:IsUserNameSupported>
     </User:Type>
     <User:Value xsi:type="xsd:string"></User:Value>
     <User:DisplayValue xsi:type="xsd:string"></User:DisplayValue>
    </User:Credential>
   </User:SaveCredential>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveCredential Response

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
  <User:SaveCredentialResponse>
   <User:Response xsi:type="xsd:boolean">false</User:Response>
  </User:SaveCredentialResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

