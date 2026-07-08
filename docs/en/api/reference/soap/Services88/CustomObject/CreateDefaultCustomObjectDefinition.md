---
title: Services88.CustomObjectAgent.CreateDefaultCustomObjectDefinition SOAP
generated: true
uid: Services88-CustomObject-CreateDefaultCustomObjectDefinition
content_type: reference
---

# Services88 CustomObject CreateDefaultCustomObjectDefinition

SOAP request and response examples **Remote/Services88/CustomObject.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomObjectAgent.CreateDefaultCustomObjectDefinition">SuperOffice.Services88.ICustomObjectAgent.CreateDefaultCustomObjectDefinition</see> method.

## CreateDefaultCustomObjectDefinition





[WSDL file for Services88/CustomObject](../Services88-CustomObject.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultCustomObjectDefinition Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomObject="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <CustomObject:ApplicationToken>1234567-1234-9876</CustomObject:ApplicationToken>
  <CustomObject:Credentials>
    <CustomObject:Ticket>7T:1234abcxyzExample==</CustomObject:Ticket>
  </CustomObject:Credentials>
 <SOAP-ENV:Body>
   <CustomObject:CreateDefaultCustomObjectDefinition>
   </CustomObject:CreateDefaultCustomObjectDefinition>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultCustomObjectDefinition Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomObject="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <CustomObject:CreateDefaultCustomObjectDefinitionResponse>
   <CustomObject:Response xsi:type="CustomObject:CustomObjectDefinition">
    <CustomObject:Id xsi:type="xsd:int">0</CustomObject:Id>
    <CustomObject:Name xsi:type="xsd:string"></CustomObject:Name>
    <CustomObject:Title xsi:type="xsd:string"></CustomObject:Title>
    <CustomObject:DisplayField xsi:type="xsd:string"></CustomObject:DisplayField>
    <CustomObject:Description xsi:type="xsd:string"></CustomObject:Description>
    <CustomObject:IconId xsi:type="xsd:int">0</CustomObject:IconId>
    <CustomObject:Flags xsi:type="xsd:int">0</CustomObject:Flags>
    <CustomObject:Fields xsi:type="CustomObject:ArrayOfCustomObjectField">
     <CustomObject:CustomObjectField xsi:type="CustomObject:CustomObjectField">
      <CustomObject:FieldName xsi:type="xsd:string"></CustomObject:FieldName>
      <CustomObject:FieldType xsi:type="xsd:string"></CustomObject:FieldType>
      <CustomObject:DisplayName xsi:type="xsd:string"></CustomObject:DisplayName>
      <CustomObject:Description xsi:type="xsd:string"></CustomObject:Description>
      <CustomObject:UseDefaultValue xsi:type="xsd:boolean">false</CustomObject:UseDefaultValue>
      <CustomObject:DefaultValue xsi:type="xsd:string"></CustomObject:DefaultValue>
      <CustomObject:Rank xsi:type="xsd:int">0</CustomObject:Rank>
      <CustomObject:IsDefault xsi:type="xsd:boolean">false</CustomObject:IsDefault>
     </CustomObject:CustomObjectField>
    </CustomObject:Fields>
   </CustomObject:Response>
  </CustomObject:CreateDefaultCustomObjectDefinitionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

