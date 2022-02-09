---
title: Services88.FileManagerAgent.BeginReadFilePart SOAP
generated: 1
uid: Services88-FileManager-BeginReadFilePart
---

# Services88 FileManager BeginReadFilePart

SOAP request and response examples **Remote/Services88/FileManager.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFileManagerAgent.BeginReadFilePart">SuperOffice.Services88.IFileManagerAgent.BeginReadFilePart</see> method.

## BeginReadFilePart





[WSDL file for Services88/FileManager](../Services88-FileManager.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## BeginReadFilePart Request

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
   <FileManager:BeginReadFilePart>
    <FileManager:DocumentId xsi:type="xsd:int">0</FileManager:DocumentId>
   </FileManager:BeginReadFilePart>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## BeginReadFilePart Response

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
  <FileManager:BeginReadFilePartResponse>
   <FileManager:FileName xsi:type="xsd:string"></FileManager:FileName>
   <FileManager:Length xsi:type="xsd:long">0</FileManager:Length>
  </FileManager:BeginReadFilePartResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

