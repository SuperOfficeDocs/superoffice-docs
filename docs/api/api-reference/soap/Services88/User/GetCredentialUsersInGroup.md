---
title: Services88.UserAgent.GetCredentialUsersInGroup SOAP
generated: 1
uid: Services88-User-GetCredentialUsersInGroup
---

# Services88 User GetCredentialUsersInGroup

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.GetCredentialUsersInGroup">SuperOffice.Services88.IUserAgent.GetCredentialUsersInGroup</see> method.

## GetCredentialUsersInGroup

Get credential users within a user group
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **type:** Type of credentials, corresponding to name of plugin and type in the credentials table.
* **groupName:** Name of user group needed to discover the users.



[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCredentialUsersInGroup Request

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
   <User:GetCredentialUsersInGroup>
    <User:Type xsi:type="xsd:string"></User:Type>
    <User:GroupName xsi:type="xsd:string"></User:GroupName>
   </User:GetCredentialUsersInGroup>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCredentialUsersInGroup Response

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
  <User:GetCredentialUsersInGroupResponse>
   <User:Response xsi:type="User:CredentialsGroupUsers">
    <User:Headings xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </User:Headings>
    <User:Users xsi:type="User:ArrayOfCredentialUser">
     <User:CredentialUser xsi:type="User:CredentialUser">
      <User:Value xsi:type="xsd:string"></User:Value>
      <User:DisplayValue xsi:type="xsd:string"></User:DisplayValue>
      <User:Columns xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </User:Columns>
      <User:CanCreatePerson xsi:type="xsd:boolean">false</User:CanCreatePerson>
     </User:CredentialUser>
    </User:Users>
   </User:Response>
  </User:GetCredentialUsersInGroupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

