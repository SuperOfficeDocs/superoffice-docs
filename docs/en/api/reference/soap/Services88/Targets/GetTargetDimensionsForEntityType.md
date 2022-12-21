---
title: Services88.TargetsAgent.GetTargetDimensionsForEntityType SOAP
generated: 1
uid: Services88-Targets-GetTargetDimensionsForEntityType
---

# Services88 Targets GetTargetDimensionsForEntityType

SOAP request and response examples **Remote/Services88/Targets.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITargetsAgent.GetTargetDimensionsForEntityType">SuperOffice.Services88.ITargetsAgent.GetTargetDimensionsForEntityType</see> method.

## GetTargetDimensionsForEntityType

Returns the target dimensions for the given entity type.

* **entityType:** Targeted entity type

**Returns:** Target dimensions for year and entity type.

[WSDL file for Services88/Targets](../Services88-Targets.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTargetDimensionsForEntityType Request

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
   <Targets:GetTargetDimensionsForEntityType>
    <Targets:EntityType xsi:type="Targets:TargetEntityType">None</Targets:EntityType>
   </Targets:GetTargetDimensionsForEntityType>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetTargetDimensionsForEntityType Response

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
  <Targets:GetTargetDimensionsForEntityTypeResponse>
   <Targets:Response xsi:type="Targets:ArrayOfTargetDimension">
    <Targets:TargetDimension xsi:type="Targets:TargetDimension">
     <Targets:TargetDimensionId xsi:type="xsd:int">0</Targets:TargetDimensionId>
     <Targets:AssignmentLevel xsi:type="Targets:TargetAssignementLevel">Company</Targets:AssignmentLevel>
     <Targets:EntityType xsi:type="Targets:TargetEntityType">None</Targets:EntityType>
     <Targets:MeasurementUnit xsi:type="Targets:TargetMeasurementUnit">None</Targets:MeasurementUnit>
     <Targets:DimensionList xsi:type="xsd:string"></Targets:DimensionList>
     <Targets:DimensionListName xsi:type="xsd:string"></Targets:DimensionListName>
     <Targets:SelectedDimensions xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </Targets:SelectedDimensions>
    </Targets:TargetDimension>
   </Targets:Response>
  </Targets:GetTargetDimensionsForEntityTypeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
