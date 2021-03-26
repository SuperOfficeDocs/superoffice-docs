---
uid: services85-user-findroleswithfunctionalrights
title: Services85.UserAgent.FindRolesWithFunctionalRights SOAP
Generated: true
---

# Services85 User FindRolesWithFunctionalRights SOAP

SOAP request and response examples **Remote/Services85/User.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IUserAgent.FindRolesWithFunctionalRights">SuperOffice.Services85.IUserAgent.FindRolesWithFunctionalRights</see> method.

## FindRolesWithFunctionalRights

Find all roles with a given set of functional rights. The roles matched must contain one or more of the specified functional rights.

* **functionalRightNames:** An array of functional rights names to search for

**Returns:** Role ids that contains your functional rights


[WSDL file for Services85/User](../Services85-User.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindRolesWithFunctionalRights Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:FindRolesWithFunctionalRights>
    <User:FunctionalRightNames xsi:type="NetServerServices852:ArrayOfstring">
     <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <User:FindRolesWithFunctionalRightsResponse>
   <User:Response xsi:type="NetServerServices852:ArrayOfint">
    <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
   </User:Response>
  </User:FindRolesWithFunctionalRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

