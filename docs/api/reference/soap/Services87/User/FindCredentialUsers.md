---
title: Services87.UserAgent.FindCredentialUsers SOAP
generated: 1
uid: Services87-User-FindCredentialUsers
---

# Services87 User FindCredentialUsers

SOAP request and response examples **Remote/Services87/User.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IUserAgent.FindCredentialUsers">SuperOffice.Services87.IUserAgent.FindCredentialUsers</see> method.

## FindCredentialUsers

Find users matching the partial name.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **type:** Type of credentials, corresponding to name of plugin and type in the credentials table.
* **searchString:** Partly name of the user group



[WSDL file for Services87/User](../Services87-User.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindCredentialUsers Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:FindCredentialUsers>
    <User:Type xsi:type="xsd:string"></User:Type>
    <User:SearchString xsi:type="xsd:string"></User:SearchString>
   </User:FindCredentialUsers>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindCredentialUsers Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <User:FindCredentialUsersResponse>
   <User:Response xsi:type="User:CredentialsGroupUsers">
    <User:Headings xsi:type="NetServerServices872:ArrayOfstring">
     <NetServerServices872:string xsi:type="xsd:string"></NetServerServices872:string>
    </User:Headings>
    <User:Users xsi:type="User:ArrayOfCredentialUser">
     <User:CredentialUser xsi:type="User:CredentialUser">
      <User:Value xsi:type="xsd:string"></User:Value>
      <User:DisplayValue xsi:type="xsd:string"></User:DisplayValue>
      <User:Columns xsi:type="NetServerServices872:ArrayOfstring">
       <NetServerServices872:string xsi:type="xsd:string"></NetServerServices872:string>
      </User:Columns>
      <User:CanCreatePerson xsi:type="xsd:boolean">false</User:CanCreatePerson>
     </User:CredentialUser>
    </User:Users>
   </User:Response>
  </User:FindCredentialUsersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

