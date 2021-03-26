---
uid: services84-user-getcredentialusersingroup
title: Services84.UserAgent.GetCredentialUsersInGroup SOAP
Generated: true
---

# Services84 User GetCredentialUsersInGroup SOAP

SOAP request and response examples **Remote/Services84/User.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IUserAgent.GetCredentialUsersInGroup">SuperOffice.Services84.IUserAgent.GetCredentialUsersInGroup</see> method.

## GetCredentialUsersInGroup

Get credential users within a user group

* **type:** Type of credentials, corresponding to name of plugin and type in the credentials table.
* **groupName:** Name of user group needed to discover the users.



[WSDL file for Services84/User](../Services84-User.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCredentialUsersInGroup Request

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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <User:GetCredentialUsersInGroupResponse>
   <User:Response xsi:type="User:CredentialsGroupUsers">
    <User:Headings xsi:type="NetServerServices842:ArrayOfstring">
     <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
    </User:Headings>
    <User:Users xsi:type="User:ArrayOfCredentialUser">
     <User:CredentialUser xsi:type="User:CredentialUser">
      <User:Value xsi:type="xsd:string"></User:Value>
      <User:DisplayValue xsi:type="xsd:string"></User:DisplayValue>
      <User:Columns xsi:type="NetServerServices842:ArrayOfstring">
       <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
      </User:Columns>
      <User:CanCreatePerson xsi:type="xsd:boolean">false</User:CanCreatePerson>
     </User:CredentialUser>
    </User:Users>
   </User:Response>
  </User:GetCredentialUsersInGroupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

