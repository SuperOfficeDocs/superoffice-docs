---
uid: services82-userdefinedfieldinfo-setpublishstartsystemevent
title: Services82.UserDefinedFieldInfoAgent.SetPublishStartSystemEvent SOAP
Generated: true
---

# Services82 UserDefinedFieldInfo SetPublishStartSystemEvent SOAP

SOAP request and response examples **Remote/Services82/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IUserDefinedFieldInfoAgent.SetPublishStartSystemEvent">SuperOffice.Services82.IUserDefinedFieldInfoAgent.SetPublishStartSystemEvent</see> method.

## SetPublishStartSystemEvent



* **ownerType:** 



[WSDL file for Services82/UserDefinedFieldInfo](../Services82-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetPublishStartSystemEvent Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <UserDefinedFieldInfo:ApplicationToken>1234567-1234-9876</UserDefinedFieldInfo:ApplicationToken>
  <UserDefinedFieldInfo:Credentials>
    <UserDefinedFieldInfo:Ticket>7T:1234abcxyzExample==</UserDefinedFieldInfo:Ticket>
  </UserDefinedFieldInfo:Credentials>
 <SOAP-ENV:Body>
   <UserDefinedFieldInfo:SetPublishStartSystemEvent>
    <UserDefinedFieldInfo:OwnerType xsi:type="UserDefinedFieldInfo:UDefType">Invalid</UserDefinedFieldInfo:OwnerType>
   </UserDefinedFieldInfo:SetPublishStartSystemEvent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetPublishStartSystemEvent Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <UserDefinedFieldInfo:SetPublishStartSystemEventResponse>
  </UserDefinedFieldInfo:SetPublishStartSystemEventResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

