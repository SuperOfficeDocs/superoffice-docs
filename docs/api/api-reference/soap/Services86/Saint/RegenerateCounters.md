---
uid: services86-saint-regeneratecounters
title: Services86.SaintAgent.RegenerateCounters SOAP
Generated: true
---

# Services86 Saint RegenerateCounters SOAP

SOAP request and response examples **Remote/Services86/Saint.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ISaintAgent.RegenerateCounters">SuperOffice.Services86.ISaintAgent.RegenerateCounters</see> method.

## RegenerateCounters

Regenerate the Saint counters - this can take several minutes

* **runAsBatch:** If true, then execute the regeneration as a Batch Task; the service call will return immediately. Otherwise wait until the task completes, may cause a timeout if called as a Web Service

**Returns:** Information about the batch task, if batch execution was requested. Otherwise null


[WSDL file for Services86/Saint](../Services86-Saint.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RegenerateCounters Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Saint:ApplicationToken>1234567-1234-9876</Saint:ApplicationToken>
  <Saint:Credentials>
    <Saint:Ticket>7T:1234abcxyzExample==</Saint:Ticket>
  </Saint:Credentials>
 <SOAP-ENV:Body>
   <Saint:RegenerateCounters>
    <Saint:RunAsBatch xsi:type="xsd:boolean">false</Saint:RunAsBatch>
   </Saint:RegenerateCounters>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RegenerateCounters Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Saint="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Saint:RegenerateCountersResponse>
   <Saint:Response xsi:type="Saint:BatchTaskInfo">
    <Saint:Id xsi:type="xsd:int">0</Saint:Id>
    <Saint:Name xsi:type="xsd:string"></Saint:Name>
    <Saint:AssociateId xsi:type="xsd:int">0</Saint:AssociateId>
    <Saint:DetailsTable xsi:type="xsd:short">0</Saint:DetailsTable>
    <Saint:DetailsRecord xsi:type="xsd:int">0</Saint:DetailsRecord>
    <Saint:IsSystemTask xsi:type="xsd:boolean">false</Saint:IsSystemTask>
    <Saint:IsInternalTask xsi:type="xsd:boolean">false</Saint:IsInternalTask>
    <Saint:ParameterObject xsi:type="Saint:StringDictionary">
     <Saint:StringKeyValuePair>
      <Saint:Key xsi:type="xsd:string"></Saint:Key>
      <Saint:Value xsi:type="xsd:string"></Saint:Value>
     </Saint:StringKeyValuePair>
    </Saint:ParameterObject>
    <Saint:LastStarted xsi:type="xsd:dateTime">2021-03-25T21:36:20Z</Saint:LastStarted>
    <Saint:Created xsi:type="xsd:dateTime">2021-03-25T21:36:20Z</Saint:Created>
    <Saint:StartCount xsi:type="xsd:int">0</Saint:StartCount>
    <Saint:DatabaseSerialNumber xsi:type="xsd:string"></Saint:DatabaseSerialNumber>
    <Saint:Context xsi:type="xsd:string"></Saint:Context>
    <Saint:Result xsi:type="xsd:string"></Saint:Result>
    <Saint:State xsi:type="Saint:BatchTaskState">Unknown</Saint:State>
    <Saint:Description xsi:type="xsd:string"></Saint:Description>
    <Saint:Response xsi:type="xsd:string"></Saint:Response>
    <Saint:Request xsi:type="xsd:string"></Saint:Request>
    <Saint:ProgressDescription xsi:type="xsd:string"></Saint:ProgressDescription>
    <Saint:ProgressPercent xsi:type="xsd:short">0</Saint:ProgressPercent>
   </Saint:Response>
  </Saint:RegenerateCountersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

