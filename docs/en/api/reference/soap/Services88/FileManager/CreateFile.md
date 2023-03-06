---
title: Services88.FileManagerAgent.CreateFile SOAP
generated: 1
uid: Services88-FileManager-CreateFile
---

# Services88 FileManager CreateFile

SOAP request and response examples **Remote/Services88/FileManager.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFileManagerAgent.CreateFile">SuperOffice.Services88.IFileManagerAgent.CreateFile</see> method.

## CreateFile





[WSDL file for Services88/FileManager](../Services88-FileManager.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateFile Request

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
   <FileManager:CreateFile>
    <FileManager:DocumentId xsi:type="xsd:int">0</FileManager:DocumentId>
    <FileManager:OverwriteExistingStream xsi:type="xsd:boolean">false</FileManager:OverwriteExistingStream>
   </FileManager:CreateFile>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateFile Response

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
  <FileManager:CreateFileResponse>
  </FileManager:CreateFileResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

