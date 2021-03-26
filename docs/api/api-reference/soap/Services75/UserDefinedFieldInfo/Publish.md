---
uid: services75-userdefinedfieldinfo-publish
title: Services75.UserDefinedFieldInfoAgent.Publish SOAP
Generated: true
---

# Services75 UserDefinedFieldInfo Publish SOAP

SOAP request and response examples **Remote/Services75/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IUserDefinedFieldInfoAgent.Publish">SuperOffice.Services75.IUserDefinedFieldInfoAgent.Publish</see> method.

## Publish

Publish changed Udef fields for the given owner type

* **ownerType:** The owner type to publish for



[WSDL file for Services75/UserDefinedFieldInfo](../Services75-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Publish Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <UserDefinedFieldInfo:ApplicationToken>1234567-1234-9876</UserDefinedFieldInfo:ApplicationToken>
  <UserDefinedFieldInfo:Credentials>
    <UserDefinedFieldInfo:Ticket>7T:1234abcxyzExample==</UserDefinedFieldInfo:Ticket>
  </UserDefinedFieldInfo:Credentials>
 <SOAP-ENV:Body>
   <UserDefinedFieldInfo:Publish>
    <UserDefinedFieldInfo:OwnerType xsi:type="UserDefinedFieldInfo:UDefType">Invalid</UserDefinedFieldInfo:OwnerType>
   </UserDefinedFieldInfo:Publish>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Publish Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <UserDefinedFieldInfo:PublishResponse>
  </UserDefinedFieldInfo:PublishResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

