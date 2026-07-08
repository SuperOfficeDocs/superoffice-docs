---
title: Services88.CustomObjectAgent.GetCustomObjectsIcons SOAP
generated: true
uid: Services88-CustomObject-GetCustomObjectsIcons
content_type: reference
---

# Services88 CustomObject GetCustomObjectsIcons

SOAP request and response examples **Remote/Services88/CustomObject.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomObjectAgent.GetCustomObjectsIcons">SuperOffice.Services88.ICustomObjectAgent.GetCustomObjectsIcons</see> method.

## GetCustomObjectsIcons





[WSDL file for Services88/CustomObject](../Services88-CustomObject.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCustomObjectsIcons Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomObject="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <CustomObject:ApplicationToken>1234567-1234-9876</CustomObject:ApplicationToken>
  <CustomObject:Credentials>
    <CustomObject:Ticket>7T:1234abcxyzExample==</CustomObject:Ticket>
  </CustomObject:Credentials>
 <SOAP-ENV:Body>
   <CustomObject:GetCustomObjectsIcons>
   </CustomObject:GetCustomObjectsIcons>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCustomObjectsIcons Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomObject="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <CustomObject:GetCustomObjectsIconsResponse>
   <CustomObject:Response xsi:type="CustomObject:StringDictionary">
    <CustomObject:StringKeyValuePair>
     <CustomObject:Key xsi:type="xsd:string"></CustomObject:Key>
     <CustomObject:Value xsi:type="xsd:string"></CustomObject:Value>
    </CustomObject:StringKeyValuePair>
   </CustomObject:Response>
  </CustomObject:GetCustomObjectsIconsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

