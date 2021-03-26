---
uid: services83-blob-setappdata
title: Services83.BLOBAgent.SetAppData SOAP
Generated: true
---

# Services83 BLOB SetAppData SOAP

SOAP request and response examples **Remote/Services83/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IBLOBAgent.SetAppData">SuperOffice.Services83.IBLOBAgent.SetAppData</see> method.

## SetAppData

Get a CLOB (limited to a reasonable size by the mechanics of Web Services) according to a string key; ALSO limits to the current ApplicationToken if any. Existing data, if any, will be overwritten. Overwrite with a blank value to delete.

* **key:** The key string, less than 200 characters. Must be unique within each application.
* **data:** The applications value, suggested to be a JSON, XML or other readable structure

**Returns:** This method has no return value


[WSDL file for Services83/BLOB](../Services83-BLOB.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetAppData Request

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
   <BLOB:SetAppData>
    <BLOB:Key xsi:type="xsd:string"></BLOB:Key>
    <BLOB:Data xsi:type="xsd:string"></BLOB:Data>
   </BLOB:SetAppData>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetAppData Response

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
  <BLOB:SetAppDataResponse>
  </BLOB:SetAppDataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

