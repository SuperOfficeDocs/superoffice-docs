---
uid: services81-freetext-regenerateindex
title: Services81.FreeTextAgent.RegenerateIndex SOAP
Generated: true
---

# Services81 FreeText RegenerateIndex SOAP

SOAP request and response examples **Remote/Services81/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IFreeTextAgent.RegenerateIndex">SuperOffice.Services81.IFreeTextAgent.RegenerateIndex</see> method.

## RegenerateIndex

Wipe and regenerate the freetext index by scanning the database (freetext search will be unavailable while this operation runs

* **runAsBatch:** If true, then execute the regeneration as a Batch Task; the service call will return immediately. Otherwise wait until the task completes, may cause a timeout if called as a Web Service

**Returns:** Information about the batch task, if batch execution was requested. Otherwise null


[WSDL file for Services81/FreeText](../Services81-FreeText.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RegenerateIndex Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <FreeText:ApplicationToken>1234567-1234-9876</FreeText:ApplicationToken>
  <FreeText:Credentials>
    <FreeText:Ticket>7T:1234abcxyzExample==</FreeText:Ticket>
  </FreeText:Credentials>
 <SOAP-ENV:Body>
   <FreeText:RegenerateIndex>
    <FreeText:RunAsBatch xsi:type="xsd:boolean">false</FreeText:RunAsBatch>
   </FreeText:RegenerateIndex>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RegenerateIndex Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <FreeText:RegenerateIndexResponse>
   <FreeText:Response xsi:type="FreeText:BatchTaskInfo">
    <FreeText:Id xsi:type="xsd:int">0</FreeText:Id>
    <FreeText:Name xsi:type="xsd:string"></FreeText:Name>
    <FreeText:AssociateId xsi:type="xsd:int">0</FreeText:AssociateId>
    <FreeText:DetailsTable xsi:type="xsd:short">0</FreeText:DetailsTable>
    <FreeText:DetailsRecord xsi:type="xsd:int">0</FreeText:DetailsRecord>
    <FreeText:IsSystemTask xsi:type="xsd:boolean">false</FreeText:IsSystemTask>
    <FreeText:IsInternalTask xsi:type="xsd:boolean">false</FreeText:IsInternalTask>
    <FreeText:ParameterObject xsi:type="FreeText:StringDictionary">
     <FreeText:StringKeyValuePair>
      <FreeText:Key xsi:type="xsd:string"></FreeText:Key>
      <FreeText:Value xsi:type="xsd:string"></FreeText:Value>
     </FreeText:StringKeyValuePair>
    </FreeText:ParameterObject>
    <FreeText:LastStarted xsi:type="xsd:dateTime">2021-03-25T21:34:29Z</FreeText:LastStarted>
    <FreeText:Created xsi:type="xsd:dateTime">2021-03-25T21:34:29Z</FreeText:Created>
    <FreeText:StartCount xsi:type="xsd:int">0</FreeText:StartCount>
    <FreeText:DatabaseSerialNumber xsi:type="xsd:string"></FreeText:DatabaseSerialNumber>
    <FreeText:Context xsi:type="xsd:string"></FreeText:Context>
    <FreeText:Result xsi:type="xsd:string"></FreeText:Result>
    <FreeText:State xsi:type="FreeText:BatchTaskState">Unknown</FreeText:State>
    <FreeText:Description xsi:type="xsd:string"></FreeText:Description>
    <FreeText:Response xsi:type="xsd:string"></FreeText:Response>
    <FreeText:Request xsi:type="xsd:string"></FreeText:Request>
    <FreeText:ProgressDescription xsi:type="xsd:string"></FreeText:ProgressDescription>
    <FreeText:ProgressPercent xsi:type="xsd:short">0</FreeText:ProgressPercent>
   </FreeText:Response>
  </FreeText:RegenerateIndexResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

