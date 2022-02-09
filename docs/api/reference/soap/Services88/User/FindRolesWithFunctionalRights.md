---
title: Services88.UserAgent.FindRolesWithFunctionalRights SOAP
generated: 1
uid: Services88-User-FindRolesWithFunctionalRights
---

# Services88 User FindRolesWithFunctionalRights

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.FindRolesWithFunctionalRights">SuperOffice.Services88.IUserAgent.FindRolesWithFunctionalRights</see> method.

## FindRolesWithFunctionalRights

Find all roles with a given set of functional rights. The roles matched must contain one or more of the specified functional rights.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **functionalRightNames:** An array of functional rights names to search for

**Returns:** Role ids that contains your functional rights


[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindRolesWithFunctionalRights Request

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
   <User:FindRolesWithFunctionalRights>
    <User:FunctionalRightNames xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </User:FunctionalRightNames>
   </User:FindRolesWithFunctionalRights>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindRolesWithFunctionalRights Response

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
  <User:FindRolesWithFunctionalRightsResponse>
   <User:Response xsi:type="NetServerServices882:ArrayOfint">
    <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
   </User:Response>
  </User:FindRolesWithFunctionalRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

