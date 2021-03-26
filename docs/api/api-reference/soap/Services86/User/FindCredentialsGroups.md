---
uid: services86-user-findcredentialsgroups
title: Services86.UserAgent.FindCredentialsGroups SOAP
Generated: true
---

# Services86 User FindCredentialsGroups SOAP

SOAP request and response examples **Remote/Services86/User.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IUserAgent.FindCredentialsGroups">SuperOffice.Services86.IUserAgent.FindCredentialsGroups</see> method.

## FindCredentialsGroups

Get user groups holding users filtered by the searchString.  This method is only relevant if the CredentialType control is of type link.  There will allways be at least one groups even if the underlying provider does not support groups.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **type:** Type of credentials, corresponding to name of plugin and type in the credentials table.
* **searchString:** Partly name of domain group.



[WSDL file for Services86/User](../Services86-User.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindCredentialsGroups Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:FindCredentialsGroups>
    <User:Type xsi:type="xsd:string"></User:Type>
    <User:SearchString xsi:type="xsd:string"></User:SearchString>
   </User:FindCredentialsGroups>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindCredentialsGroups Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <User:FindCredentialsGroupsResponse>
   <User:Response xsi:type="User:ArrayOfCredentialsGroup">
    <User:CredentialsGroup xsi:type="User:CredentialsGroup">
     <User:Name xsi:type="xsd:string"></User:Name>
     <User:DisplayName xsi:type="xsd:string"></User:DisplayName>
    </User:CredentialsGroup>
   </User:Response>
  </User:FindCredentialsGroupsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

