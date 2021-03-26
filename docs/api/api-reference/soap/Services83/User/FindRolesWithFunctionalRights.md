---
uid: services83-user-findroleswithfunctionalrights
title: Services83.UserAgent.FindRolesWithFunctionalRights SOAP
Generated: true
---

# Services83 User FindRolesWithFunctionalRights SOAP

SOAP request and response examples **Remote/Services83/User.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IUserAgent.FindRolesWithFunctionalRights">SuperOffice.Services83.IUserAgent.FindRolesWithFunctionalRights</see> method.

## FindRolesWithFunctionalRights

Find all roles with a given set of functional rights. The roles matched must contain one or more of the specified functional rights.

* **functionalRightNames:** An array of functional rights names to search for

**Returns:** Role ids that contains your functional rights


[WSDL file for Services83/User](../Services83-User.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindRolesWithFunctionalRights Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:FindRolesWithFunctionalRights>
    <User:FunctionalRightNames xsi:type="NetServerServices832:ArrayOfstring">
     <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
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
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <User:FindRolesWithFunctionalRightsResponse>
   <User:Response xsi:type="NetServerServices832:ArrayOfint">
    <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
   </User:Response>
  </User:FindRolesWithFunctionalRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

