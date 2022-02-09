---
title: Services88.FileManagerAgent.ReadFilePart SOAP
generated: 1
uid: Services88-FileManager-ReadFilePart
---

# Services88 FileManager ReadFilePart

SOAP request and response examples **Remote/Services88/FileManager.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFileManagerAgent.ReadFilePart">SuperOffice.Services88.IFileManagerAgent.ReadFilePart</see> method.

## ReadFilePart





[WSDL file for Services88/FileManager](../Services88-FileManager.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ReadFilePart Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FileManager="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <FileManager:ApplicationToken>1234567-1234-9876</FileManager:ApplicationToken>
  <FileManager:Credentials>
    <FileManager:Ticket>7T:1234abcxyzExample==</FileManager:Ticket>
  </FileManager:Credentials>
 <SOAP-ENV:Body>
   <FileManager:ReadFilePart>
    <FileManager:DocumentId xsi:type="xsd:int">0</FileManager:DocumentId>
    <FileManager:FilePosition xsi:type="xsd:long">0</FileManager:FilePosition>
    <FileManager:Length xsi:type="xsd:int">0</FileManager:Length>
   </FileManager:ReadFilePart>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ReadFilePart Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FileManager="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <FileManager:ReadFilePartResponse>
   <FileManager:Response xsi:type="xsd:string"></FileManager:Response>
   <FileManager:Length xsi:type="xsd:int">0</FileManager:Length>
  </FileManager:ReadFilePartResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

