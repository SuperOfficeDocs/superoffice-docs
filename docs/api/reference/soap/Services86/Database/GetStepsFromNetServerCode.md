---
title: Services86.DatabaseAgent.GetStepsFromNetServerCode SOAP
generated: 1
uid: Services86-Database-GetStepsFromNetServerCode
---

# Services86 Database GetStepsFromNetServerCode

SOAP request and response examples **Remote/Services86/Database.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IDatabaseAgent.GetStepsFromNetServerCode">SuperOffice.Services86.IDatabaseAgent.GetStepsFromNetServerCode</see> method.

## GetStepsFromNetServerCode

Get information about the dictionary steps that NetServer was generated for


**Returns:** Array of dictionary steps used when NetServer was generated, listing only the highest number for each step


[WSDL file for Services86/Database](../Services86-Database.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetStepsFromNetServerCode Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Database="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Database="http://www.superoffice.net/ws/crm/NetServer/Services86">
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

