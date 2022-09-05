---
title: Services84.BatchAgent.GetBatchTaskInfo SOAP
generated: 1
uid: Services84-Batch-GetBatchTaskInfo
---

# Services84 Batch GetBatchTaskInfo

SOAP request and response examples **Remote/Services84/Batch.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IBatchAgent.GetBatchTaskInfo">SuperOffice.Services84.IBatchAgent.GetBatchTaskInfo</see> method.

## GetBatchTaskInfo

Get a single BatchTaskInfo based on Id.

* **id:** Id of the BatchTaskInfo to get.

**Returns:** Returns a BatchTaskInfo.


[WSDL file for Services84/Batch](../Services84-Batch.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetBatchTaskInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Batch="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Batch:ApplicationToken>1234567-1234-9876</Batch:ApplicationToken>
  <Batch:Credentials>
    <Batch:Ticket>7T:1234abcxyzExample==</Batch:Ticket>
  </Batch:Credentials>
 <SOAP-ENV:Body>
   <Batch:GetBatchTaskInfo>
    <Batch:Id xsi:type="xsd:int">0</Batch:Id>
   </Batch:GetBatchTaskInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetBatchTaskInfo Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Batch="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Batch:GetBatchTaskInfoResponse>
   <Batch:Response xsi:type="Batch:BatchTaskInfo">
    <Batch:Id xsi:type="xsd:int">0</Batch:Id>
    <Batch:Name xsi:type="xsd:string"></Batch:Name>
    <Batch:AssociateId xsi:type="xsd:int">0</Batch:AssociateId>
    <Batch:DetailsTable xsi:type="xsd:short">0</Batch:DetailsTable>
    <Batch:DetailsRecord xsi:type="xsd:int">0</Batch:DetailsRecord>
    <Batch:IsSystemTask xsi:type="xsd:boolean">false</Batch:IsSystemTask>
    <Batch:IsInternalTask xsi:type="xsd:boolean">false</Batch:IsInternalTask>
    <Batch:ParameterObject xsi:type="Batch:StringDictionary">
     <Batch:StringKeyValuePair>
      <Batch:Key xsi:type="xsd:string"></Batch:Key>
      <Batch:Value xsi:type="xsd:string"></Batch:Value>
     </Batch:StringKeyValuePair>
    </Batch:ParameterObject>
    <Batch:LastStarted xsi:type="xsd:dateTime">2022-08-26T08:50:19Z</Batch:LastStarted>
    <Batch:Created xsi:type="xsd:dateTime">2022-08-26T08:50:19Z</Batch:Created>
    <Batch:StartCount xsi:type="xsd:int">0</Batch:StartCount>
    <Batch:DatabaseSerialNumber xsi:type="xsd:string"></Batch:DatabaseSerialNumber>
    <Batch:Context xsi:type="xsd:string"></Batch:Context>
    <Batch:Result xsi:type="xsd:string"></Batch:Result>
    <Batch:State xsi:type="Batch:BatchTaskState">Unknown</Batch:State>
    <Batch:Description xsi:type="xsd:string"></Batch:Description>
    <Batch:Response xsi:type="xsd:string"></Batch:Response>
    <Batch:Request xsi:type="xsd:string"></Batch:Request>
    <Batch:ProgressDescription xsi:type="xsd:string"></Batch:ProgressDescription>
    <Batch:ProgressPercent xsi:type="xsd:short">0</Batch:ProgressPercent>
   </Batch:Response>
  </Batch:GetBatchTaskInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

