---
uid: services85-database-getstepsindatabase
title: Services85.DatabaseAgent.GetStepsInDatabase SOAP
Generated: true
---

# Services85 Database GetStepsInDatabase SOAP

SOAP request and response examples **Remote/Services85/Database.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IDatabaseAgent.GetStepsInDatabase">SuperOffice.Services85.IDatabaseAgent.GetStepsInDatabase</see> method.

## GetStepsInDatabase

Get information about the dictionary steps that are in the currently-loggedon database


**Returns:** Array of dictionary steps in the database, listing only the highest number for each step


[WSDL file for Services85/Database](../Services85-Database.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetStepsInDatabase Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Database="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Database:ApplicationToken>1234567-1234-9876</Database:ApplicationToken>
  <Database:Credentials>
    <Database:Ticket>7T:1234abcxyzExample==</Database:Ticket>
  </Database:Credentials>
 <SOAP-ENV:Body>
   <Database:GetStepsInDatabase>
   </Database:GetStepsInDatabase>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetStepsInDatabase Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Database="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Database:GetStepsInDatabaseResponse>
   <Database:Response xsi:type="Database:ArrayOfDictionaryStepInformation">
    <Database:DictionaryStepInformation xsi:type="Database:DictionaryStepInformation">
     <Database:Name xsi:type="xsd:string"></Database:Name>
     <Database:StepNumber xsi:type="xsd:int">0</Database:StepNumber>
    </Database:DictionaryStepInformation>
   </Database:Response>
  </Database:GetStepsInDatabaseResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

