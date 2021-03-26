---
uid: services80-import-createdefaultimportline
title: Services80.ImportAgent.CreateDefaultImportLine SOAP
Generated: true
---

# Services80 Import CreateDefaultImportLine SOAP

SOAP request and response examples **Remote/Services80/Import.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IImportAgent.CreateDefaultImportLine">SuperOffice.Services80.IImportAgent.CreateDefaultImportLine</see> method.

## CreateDefaultImportLine

Create a new empty import row with x count of values

* **countColumns:** The count of values that will can be filled out

**Returns:** A new ImportLine


[WSDL file for Services80/Import](../Services80-Import.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultImportLine Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Import="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Import:ApplicationToken>1234567-1234-9876</Import:ApplicationToken>
  <Import:Credentials>
    <Import:Ticket>7T:1234abcxyzExample==</Import:Ticket>
  </Import:Credentials>
 <SOAP-ENV:Body>
   <Import:CreateDefaultImportLine>
    <Import:CountColumns xsi:type="xsd:int">0</Import:CountColumns>
   </Import:CreateDefaultImportLine>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultImportLine Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Import="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Import:CreateDefaultImportLineResponse>
   <Import:Response xsi:type="Import:ImportLine">
    <Import:Values xsi:type="NetServerServices802:ArrayOfstring">
     <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
    </Import:Values>
    <Import:Selected xsi:type="xsd:boolean">false</Import:Selected>
    <Import:Operation xsi:type="Import:ImportAction">PersonAdded</Import:Operation>
    <Import:Type xsi:type="Import:ImportEntityType">Person</Import:Type>
    <Import:ExternalKey xsi:type="xsd:string"></Import:ExternalKey>
   </Import:Response>
  </Import:CreateDefaultImportLineResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

