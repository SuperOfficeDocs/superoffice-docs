---
title: Services86.UserDefinedFieldInfoAgent.Publish SOAP
generated: 1
uid: Services86-UserDefinedFieldInfo-Publish
---

# Services86 UserDefinedFieldInfo Publish

SOAP request and response examples **Remote/Services86/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IUserDefinedFieldInfoAgent.Publish">SuperOffice.Services86.IUserDefinedFieldInfoAgent.Publish</see> method.

## Publish

Publish changed Udef fields for the given owner type

* **ownerType:** The owner type to publish for

**Returns:** Batch task id or 0 that handles publishing.


[WSDL file for Services86/UserDefinedFieldInfo](../Services86-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Publish Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <UserDefinedFieldInfo:PublishResponse>
   <UserDefinedFieldInfo:Response xsi:type="xsd:int">0</UserDefinedFieldInfo:Response>
  </UserDefinedFieldInfo:PublishResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

