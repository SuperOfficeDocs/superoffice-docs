---
uid: services84-userdefinedfieldinfo-deleteuserdefinedfieldinfo
title: Services84.UserDefinedFieldInfoAgent.DeleteUserDefinedFieldInfo SOAP
Generated: true
---

# Services84 UserDefinedFieldInfo DeleteUserDefinedFieldInfo SOAP

SOAP request and response examples **Remote/Services84/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IUserDefinedFieldInfoAgent.DeleteUserDefinedFieldInfo">SuperOffice.Services84.IUserDefinedFieldInfoAgent.DeleteUserDefinedFieldInfo</see> method.

## DeleteUserDefinedFieldInfo

Deletes the UserDefinedFieldInfo

* **userDefinedFieldInfoId:** The identity of the UserDefinedFieldInfo



[WSDL file for Services84/UserDefinedFieldInfo](../Services84-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteUserDefinedFieldInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <UserDefinedFieldInfo:ApplicationToken>1234567-1234-9876</UserDefinedFieldInfo:ApplicationToken>
  <UserDefinedFieldInfo:Credentials>
    <UserDefinedFieldInfo:Ticket>7T:1234abcxyzExample==</UserDefinedFieldInfo:Ticket>
  </UserDefinedFieldInfo:Credentials>
 <SOAP-ENV:Body>
   <UserDefinedFieldInfo:DeleteUserDefinedFieldInfo>
    <UserDefinedFieldInfo:UserDefinedFieldInfoId xsi:type="xsd:int">0</UserDefinedFieldInfo:UserDefinedFieldInfoId>
   </UserDefinedFieldInfo:DeleteUserDefinedFieldInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteUserDefinedFieldInfo Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <UserDefinedFieldInfo:DeleteUserDefinedFieldInfoResponse>
  </UserDefinedFieldInfo:DeleteUserDefinedFieldInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

