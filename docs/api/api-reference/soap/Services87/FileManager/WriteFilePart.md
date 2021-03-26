---
uid: services87-filemanager-writefilepart
title: Services87.FileManagerAgent.WriteFilePart SOAP
Generated: true
---

# Services87 FileManager WriteFilePart SOAP

SOAP request and response examples **Remote/Services87/FileManager.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IFileManagerAgent.WriteFilePart">SuperOffice.Services87.IFileManagerAgent.WriteFilePart</see> method.

## WriteFilePart





[WSDL file for Services87/FileManager](../Services87-FileManager.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## WriteFilePart Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FileManager="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <FileManager:ApplicationToken>1234567-1234-9876</FileManager:ApplicationToken>
  <FileManager:Credentials>
    <FileManager:Ticket>7T:1234abcxyzExample==</FileManager:Ticket>
  </FileManager:Credentials>
 <SOAP-ENV:Body>
   <FileManager:WriteFilePart>
    <FileManager:DocumentId xsi:type="xsd:int">0</FileManager:DocumentId>
    <FileManager:FilePosition xsi:type="xsd:long">0</FileManager:FilePosition>
    <FileManager:DocumentData xsi:type="xsd:string"></FileManager:DocumentData>
   </FileManager:WriteFilePart>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## WriteFilePart Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FileManager="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <FileManager:WriteFilePartResponse>
  </FileManager:WriteFilePartResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

