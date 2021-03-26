---
uid: services85-user-findroleswithoutfunctionalrights
title: Services85.UserAgent.FindRolesWithoutFunctionalRights SOAP
Generated: true
---

# Services85 User FindRolesWithoutFunctionalRights SOAP

SOAP request and response examples **Remote/Services85/User.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IUserAgent.FindRolesWithoutFunctionalRights">SuperOffice.Services85.IUserAgent.FindRolesWithoutFunctionalRights</see> method.

## FindRolesWithoutFunctionalRights

Find all roles without a given set of functional rights. The roles matched must not contain any of the specified functional rights.

* **functionalRightNames:** An array of functional rights names to search for

**Returns:** Role ids that without your functional rights


[WSDL file for Services85/User](../Services85-User.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindRolesWithoutFunctionalRights Request

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
   <User:FindRolesWithoutFunctionalRights>
    <User:FunctionalRightNames xsi:type="NetServerServices852:ArrayOfstring">
     <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
    </User:FunctionalRightNames>
   </User:FindRolesWithoutFunctionalRights>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindRolesWithoutFunctionalRights Response

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
  <User:FindRolesWithoutFunctionalRightsResponse>
   <User:Response xsi:type="NetServerServices852:ArrayOfint">
    <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
   </User:Response>
  </User:FindRolesWithoutFunctionalRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

