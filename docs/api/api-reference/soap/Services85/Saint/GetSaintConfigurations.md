---
uid: services85-saint-getsaintconfigurations
title: Services85.SaintAgent.GetSaintConfigurations SOAP
Generated: true
---

# Services85 Saint GetSaintConfigurations SOAP

SOAP request and response examples **Remote/Services85/Saint.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISaintAgent.GetSaintConfigurations">SuperOffice.Services85.ISaintAgent.GetSaintConfigurations</see> method.

## GetSaintConfigurations

Returns the StatusMonitorPeriods entity.


**Returns:** The SaintConfiguration for all entities


[WSDL file for Services85/Saint](../Services85-Saint.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSaintConfigurations Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Saint:ApplicationToken>1234567-1234-9876</Saint:ApplicationToken>
  <Saint:Credentials>
    <Saint:Ticket>7T:1234abcxyzExample==</Saint:Ticket>
  </Saint:Credentials>
 <SOAP-ENV:Body>
   <Saint:GetSaintConfigurations>
   </Saint:GetSaintConfigurations>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSaintConfigurations Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Saint:GetSaintConfigurationsResponse>
   <Saint:Response xsi:type="Saint:ArrayOfSaintConfiguration">
    <Saint:SaintConfiguration xsi:type="Saint:SaintConfiguration">
     <Saint:OwnerTable xsi:type="xsd:short">0</Saint:OwnerTable>
     <Saint:Enabled xsi:type="xsd:boolean">false</Saint:Enabled>
     <Saint:Period1 xsi:type="xsd:int">0</Saint:Period1>
     <Saint:Period2 xsi:type="xsd:int">0</Saint:Period2>
     <Saint:Period3 xsi:type="xsd:int">0</Saint:Period3>
     <Saint:GenerationStart xsi:type="xsd:dateTime">2021-03-25T21:35:57Z</Saint:GenerationStart>
     <Saint:GenerationEnd xsi:type="xsd:dateTime">2021-03-25T21:35:57Z</Saint:GenerationEnd>
     <Saint:RowsGenerated xsi:type="xsd:int">0</Saint:RowsGenerated>
    </Saint:SaintConfiguration>
   </Saint:Response>
  </Saint:GetSaintConfigurationsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

