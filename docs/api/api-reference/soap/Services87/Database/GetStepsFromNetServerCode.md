---
uid: services87-database-getstepsfromnetservercode
title: Services87.DatabaseAgent.GetStepsFromNetServerCode SOAP
Generated: true
---

# Services87 Database GetStepsFromNetServerCode SOAP

SOAP request and response examples **Remote/Services87/Database.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IDatabaseAgent.GetStepsFromNetServerCode">SuperOffice.Services87.IDatabaseAgent.GetStepsFromNetServerCode</see> method.

## GetStepsFromNetServerCode

Get information about the dictionary steps that NetServer was generated for


**Returns:** Array of dictionary steps used when NetServer was generated, listing only the highest number for each step


[WSDL file for Services87/Database](../Services87-Database.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetStepsFromNetServerCode Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Database="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Database:ApplicationToken>1234567-1234-9876</Database:ApplicationToken>
  <Database:Credentials>
    <Database:Ticket>7T:1234abcxyzExample==</Database:Ticket>
  </Database:Credentials>
 <SOAP-ENV:Body>
   <Database:GetStepsFromNetServerCode>
   </Database:GetStepsFromNetServerCode>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetStepsFromNetServerCode Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Database="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Database:GetStepsFromNetServerCodeResponse>
   <Database:Response xsi:type="Database:ArrayOfDictionaryStepInformation">
    <Database:DictionaryStepInformation xsi:type="Database:DictionaryStepInformation">
     <Database:Name xsi:type="xsd:string"></Database:Name>
     <Database:StepNumber xsi:type="xsd:int">0</Database:StepNumber>
    </Database:DictionaryStepInformation>
   </Database:Response>
  </Database:GetStepsFromNetServerCodeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

