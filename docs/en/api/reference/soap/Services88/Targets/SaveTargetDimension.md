---
title: Services88.TargetsAgent.SaveTargetDimension SOAP
generated: true
uid: Services88-Targets-SaveTargetDimension
content_type: reference
---

# Services88 Targets SaveTargetDimension

SOAP request and response examples **Remote/Services88/Targets.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITargetsAgent.SaveTargetDimension">SuperOffice.Services88.ITargetsAgent.SaveTargetDimension</see> method.

## SaveTargetDimension





[WSDL file for Services88/Targets](../Services88-Targets.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveTargetDimension Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Targets="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Targets:ApplicationToken>1234567-1234-9876</Targets:ApplicationToken>
  <Targets:Credentials>
    <Targets:Ticket>7T:1234abcxyzExample==</Targets:Ticket>
  </Targets:Credentials>
 <SOAP-ENV:Body>
   <Targets:SaveTargetDimension>
    <Targets:TargetDimension xsi:type="Targets:TargetDimension">
     <Targets:TargetDimensionId xsi:type="xsd:int">0</Targets:TargetDimensionId>
     <Targets:AssignmentLevel xsi:type="Targets:TargetAssignementLevel">Company</Targets:AssignmentLevel>
     <Targets:EntityType xsi:type="Targets:TargetEntityType">None</Targets:EntityType>
     <Targets:MeasurementUnit xsi:type="Targets:TargetMeasurementUnit">None</Targets:MeasurementUnit>
     <Targets:DimensionListField xsi:type="xsd:string"></Targets:DimensionListField>
     <Targets:DimensionListName xsi:type="xsd:string"></Targets:DimensionListName>
     <Targets:DimensionListId xsi:type="xsd:int">0</Targets:DimensionListId>
     <Targets:DimensionListLabel xsi:type="xsd:string"></Targets:DimensionListLabel>
     <Targets:SelectedDimensions xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </Targets:SelectedDimensions>
    </Targets:TargetDimension>
   </Targets:SaveTargetDimension>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveTargetDimension Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Targets="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Targets:SaveTargetDimensionResponse>
   <Targets:Response xsi:type="Targets:TargetDimension">
    <Targets:TargetDimensionId xsi:type="xsd:int">0</Targets:TargetDimensionId>
    <Targets:AssignmentLevel xsi:type="Targets:TargetAssignementLevel">Company</Targets:AssignmentLevel>
    <Targets:EntityType xsi:type="Targets:TargetEntityType">None</Targets:EntityType>
    <Targets:MeasurementUnit xsi:type="Targets:TargetMeasurementUnit">None</Targets:MeasurementUnit>
    <Targets:DimensionListField xsi:type="xsd:string"></Targets:DimensionListField>
    <Targets:DimensionListName xsi:type="xsd:string"></Targets:DimensionListName>
    <Targets:DimensionListId xsi:type="xsd:int">0</Targets:DimensionListId>
    <Targets:DimensionListLabel xsi:type="xsd:string"></Targets:DimensionListLabel>
    <Targets:SelectedDimensions xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Targets:SelectedDimensions>
   </Targets:Response>
  </Targets:SaveTargetDimensionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

