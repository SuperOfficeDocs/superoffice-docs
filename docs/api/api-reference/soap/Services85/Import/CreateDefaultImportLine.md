---
uid: services85-import-createdefaultimportline
title: Services85.ImportAgent.CreateDefaultImportLine SOAP
Generated: true
---

# Services85 Import CreateDefaultImportLine SOAP

SOAP request and response examples **Remote/Services85/Import.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IImportAgent.CreateDefaultImportLine">SuperOffice.Services85.IImportAgent.CreateDefaultImportLine</see> method.

## CreateDefaultImportLine

Create a new empty import row with x count of values

* **countColumns:** The count of values that will can be filled out

**Returns:** A new ImportLine


[WSDL file for Services85/Import](../Services85-Import.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultImportLine Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Import="http://www.superoffice.net/ws/crm/NetServer/Services85">
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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Import="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Import:CreateDefaultImportLineResponse>
   <Import:Response xsi:type="Import:ImportLine">
    <Import:Values xsi:type="NetServerServices852:ArrayOfstring">
     <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
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

