---
uid: services83-blob-getchatimagewithsize
title: Services83.BLOBAgent.GetChatImageWithSize SOAP
Generated: true
---

# Services83 BLOB GetChatImageWithSize SOAP

SOAP request and response examples **Remote/Services83/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IBLOBAgent.GetChatImageWithSize">SuperOffice.Services83.IBLOBAgent.GetChatImageWithSize</see> method.

## GetChatImageWithSize





[WSDL file for Services83/BLOB](../Services83-BLOB.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetChatImageWithSize Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:GetChatImageWithSize>
    <BLOB:ChatTopicId xsi:type="xsd:int">0</BLOB:ChatTopicId>
    <BLOB:Width xsi:type="xsd:int">0</BLOB:Width>
    <BLOB:Height xsi:type="xsd:int">0</BLOB:Height>
   </BLOB:GetChatImageWithSize>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetChatImageWithSize Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <BLOB:GetChatImageWithSizeResponse>
   <BLOB:Response xsi:type="xsd:base64Binary"></BLOB:Response>
  </BLOB:GetChatImageWithSizeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

