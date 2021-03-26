---
uid: services88-saint-createdefaultsaintconfiguration
title: Services88.SaintAgent.CreateDefaultSaintConfiguration SOAP
Generated: true
---

# Services88 Saint CreateDefaultSaintConfiguration SOAP

SOAP request and response examples **Remote/Services88/Saint.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISaintAgent.CreateDefaultSaintConfiguration">SuperOffice.Services88.ISaintAgent.CreateDefaultSaintConfiguration</see> method.

## CreateDefaultSaintConfiguration

Loading default values into a new SaintConfiguration.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New SaintConfiguration with default values


[WSDL file for Services88/Saint](../Services88-Saint.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultSaintConfiguration Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Saint:ApplicationToken>1234567-1234-9876</Saint:ApplicationToken>
  <Saint:Credentials>
    <Saint:Ticket>7T:1234abcxyzExample==</Saint:Ticket>
  </Saint:Credentials>
 <SOAP-ENV:Body>
   <Saint:CreateDefaultSaintConfiguration>
   </Saint:CreateDefaultSaintConfiguration>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultSaintConfiguration Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Saint:CreateDefaultSaintConfigurationResponse>
   <Saint:Response xsi:type="Saint:SaintConfiguration">
    <Saint:OwnerTable xsi:type="xsd:short">0</Saint:OwnerTable>
    <Saint:Enabled xsi:type="xsd:boolean">false</Saint:Enabled>
    <Saint:Period1 xsi:type="xsd:int">0</Saint:Period1>
    <Saint:Period2 xsi:type="xsd:int">0</Saint:Period2>
    <Saint:Period3 xsi:type="xsd:int">0</Saint:Period3>
    <Saint:GenerationStart xsi:type="xsd:dateTime">2021-03-25T21:37:09Z</Saint:GenerationStart>
    <Saint:GenerationEnd xsi:type="xsd:dateTime">2021-03-25T21:37:09Z</Saint:GenerationEnd>
    <Saint:RowsGenerated xsi:type="xsd:int">0</Saint:RowsGenerated>
   </Saint:Response>
  </Saint:CreateDefaultSaintConfigurationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

