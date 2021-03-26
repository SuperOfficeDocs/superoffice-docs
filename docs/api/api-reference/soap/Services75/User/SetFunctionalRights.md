---
uid: services75-user-setfunctionalrights
title: Services75.UserAgent.SetFunctionalRights SOAP
Generated: true
---

# Services75 User SetFunctionalRights SOAP

SOAP request and response examples **Remote/Services75/User.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IUserAgent.SetFunctionalRights">SuperOffice.Services75.IUserAgent.SetFunctionalRights</see> method.

## SetFunctionalRights

This method will set all functional rights for the given role. Functional rights not specified here will be removed from the role.

* **roleId:** The role id to set the functional rights for
* **functionalRightIds:** An array of functional rights ids to set for this role. Rights not included here are removed from the role.



[WSDL file for Services75/User](../Services75-User.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetFunctionalRights Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:SetFunctionalRights>
    <User:RoleId xsi:type="xsd:int">0</User:RoleId>
    <User:FunctionalRightIds xsi:type="NetServerServices752:ArrayOfint">
     <NetServerServices752:int xsi:type="xsd:int">0</NetServerServices752:int>
    </User:FunctionalRightIds>
   </User:SetFunctionalRights>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetFunctionalRights Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <User:SetFunctionalRightsResponse>
  </User:SetFunctionalRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

