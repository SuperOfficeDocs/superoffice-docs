---
uid: services87-saint-savesaintconfiguration
title: Services87.SaintAgent.SaveSaintConfiguration SOAP
Generated: true
---

# Services87 Saint SaveSaintConfiguration SOAP

SOAP request and response examples **Remote/Services87/Saint.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ISaintAgent.SaveSaintConfiguration">SuperOffice.Services87.ISaintAgent.SaveSaintConfiguration</see> method.

## SaveSaintConfiguration

Updates the existing SaintConfiguration or creates a new SaintConfiguration if the id parameter is 0.

* **saintConfiguration:** The SaintConfiguration that is saved.

**Returns:** New or updated SaintConfiguration


[WSDL file for Services87/Saint](../Services87-Saint.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveSaintConfiguration Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Saint:ApplicationToken>1234567-1234-9876</Saint:ApplicationToken>
  <Saint:Credentials>
    <Saint:Ticket>7T:1234abcxyzExample==</Saint:Ticket>
  </Saint:Credentials>
 <SOAP-ENV:Body>
   <Saint:SaveSaintConfiguration>
    <Saint:SaintConfiguration xsi:type="Saint:SaintConfiguration">
     <Saint:OwnerTable xsi:type="xsd:short">0</Saint:OwnerTable>
     <Saint:Enabled xsi:type="xsd:boolean">false</Saint:Enabled>
     <Saint:Period1 xsi:type="xsd:int">0</Saint:Period1>
     <Saint:Period2 xsi:type="xsd:int">0</Saint:Period2>
     <Saint:Period3 xsi:type="xsd:int">0</Saint:Period3>
     <Saint:GenerationStart xsi:type="xsd:dateTime">2021-03-25T21:36:44Z</Saint:GenerationStart>
     <Saint:GenerationEnd xsi:type="xsd:dateTime">2021-03-25T21:36:44Z</Saint:GenerationEnd>
     <Saint:RowsGenerated xsi:type="xsd:int">0</Saint:RowsGenerated>
    </Saint:SaintConfiguration>
   </Saint:SaveSaintConfiguration>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveSaintConfiguration Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Saint:SaveSaintConfigurationResponse>
   <Saint:Response xsi:type="Saint:SaintConfiguration">
    <Saint:OwnerTable xsi:type="xsd:short">0</Saint:OwnerTable>
    <Saint:Enabled xsi:type="xsd:boolean">false</Saint:Enabled>
    <Saint:Period1 xsi:type="xsd:int">0</Saint:Period1>
    <Saint:Period2 xsi:type="xsd:int">0</Saint:Period2>
    <Saint:Period3 xsi:type="xsd:int">0</Saint:Period3>
    <Saint:GenerationStart xsi:type="xsd:dateTime">2021-03-25T21:36:44Z</Saint:GenerationStart>
    <Saint:GenerationEnd xsi:type="xsd:dateTime">2021-03-25T21:36:44Z</Saint:GenerationEnd>
    <Saint:RowsGenerated xsi:type="xsd:int">0</Saint:RowsGenerated>
   </Saint:Response>
  </Saint:SaveSaintConfigurationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

