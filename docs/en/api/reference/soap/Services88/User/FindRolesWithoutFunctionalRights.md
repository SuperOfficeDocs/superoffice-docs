---
title: Services88.UserAgent.FindRolesWithoutFunctionalRights SOAP
generated: true
uid: Services88-User-FindRolesWithoutFunctionalRights
---

# Services88 User FindRolesWithoutFunctionalRights

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.FindRolesWithoutFunctionalRights">SuperOffice.Services88.IUserAgent.FindRolesWithoutFunctionalRights</see> method.

## FindRolesWithoutFunctionalRights





[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindRolesWithoutFunctionalRights Request

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
   <User:FindRolesWithoutFunctionalRights>
    <User:FunctionalRightNames xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <User:FindRolesWithoutFunctionalRightsResponse>
   <User:Response xsi:type="NetServerServices882:ArrayOfint">
    <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
   </User:Response>
  </User:FindRolesWithoutFunctionalRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

