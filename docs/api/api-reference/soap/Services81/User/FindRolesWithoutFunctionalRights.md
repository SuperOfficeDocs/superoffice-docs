---
uid: services81-user-findroleswithoutfunctionalrights
title: Services81.UserAgent.FindRolesWithoutFunctionalRights SOAP
Generated: true
---

# Services81 User FindRolesWithoutFunctionalRights SOAP

SOAP request and response examples **Remote/Services81/User.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IUserAgent.FindRolesWithoutFunctionalRights">SuperOffice.Services81.IUserAgent.FindRolesWithoutFunctionalRights</see> method.

## FindRolesWithoutFunctionalRights

This method will find all roles without a given set of functional rights for the given role. The roles matched must not contain any of the specified functional rights.

* **functionalRightNames:** An array of functional rights names to search for

**Returns:** Role ids that without your functional rights


[WSDL file for Services81/User](../Services81-User.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindRolesWithoutFunctionalRights Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:FindRolesWithoutFunctionalRights>
    <User:FunctionalRightNames xsi:type="NetServerServices812:ArrayOfstring">
     <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
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
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <User:FindRolesWithoutFunctionalRightsResponse>
   <User:Response xsi:type="NetServerServices812:ArrayOfint">
    <NetServerServices812:int xsi:type="xsd:int">0</NetServerServices812:int>
   </User:Response>
  </User:FindRolesWithoutFunctionalRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

