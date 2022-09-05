---
title: Services85.BLOBAgent.GetAppData SOAP
generated: 1
uid: Services85-BLOB-GetAppData
---

# Services85 BLOB GetAppData

SOAP request and response examples **Remote/Services85/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IBLOBAgent.GetAppData">SuperOffice.Services85.IBLOBAgent.GetAppData</see> method.

## GetAppData

Get a CLOB (limited to a reasonable size by the mechanics of Web Services) according to a string key; ALSO limits to the current ApplicationToken if any

* **key:** The key string, less than 200 characters. Must be unique within each application.

**Returns:** The applications value, suggested to be a JSON, XML or other readable structure


[WSDL file for Services85/BLOB](../Services85-BLOB.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAppData Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:GetAppData>
    <BLOB:Key xsi:type="xsd:string"></BLOB:Key>
   </BLOB:GetAppData>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAppData Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <BLOB:GetAppDataResponse>
   <BLOB:Response xsi:type="xsd:string"></BLOB:Response>
  </BLOB:GetAppDataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

