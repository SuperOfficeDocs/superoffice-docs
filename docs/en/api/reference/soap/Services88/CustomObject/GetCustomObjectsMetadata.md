---
title: Services88.CustomObjectAgent.GetCustomObjectsMetadata SOAP
generated: true
uid: Services88-CustomObject-GetCustomObjectsMetadata
content_type: reference
---

# Services88 CustomObject GetCustomObjectsMetadata

SOAP request and response examples **Remote/Services88/CustomObject.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomObjectAgent.GetCustomObjectsMetadata">SuperOffice.Services88.ICustomObjectAgent.GetCustomObjectsMetadata</see> method.

## GetCustomObjectsMetadata





[WSDL file for Services88/CustomObject](../Services88-CustomObject.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCustomObjectsMetadata Request

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
   <CustomObject:GetCustomObjectsMetadata>
   </CustomObject:GetCustomObjectsMetadata>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCustomObjectsMetadata Response

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
  <CustomObject:GetCustomObjectsMetadataResponse>
   <CustomObject:Response xsi:type="CustomObject:ArrayOfCustomObjectMetadata">
    <CustomObject:CustomObjectMetadata xsi:type="CustomObject:CustomObjectMetadata">
     <CustomObject:Name xsi:type="xsd:string"></CustomObject:Name>
     <CustomObject:TableName xsi:type="xsd:string"></CustomObject:TableName>
     <CustomObject:IconHint xsi:type="xsd:string"></CustomObject:IconHint>
     <CustomObject:FlagHideId xsi:type="xsd:boolean">false</CustomObject:FlagHideId>
     <CustomObject:FlagHidden xsi:type="xsd:boolean">false</CustomObject:FlagHidden>
     <CustomObject:FlagShowInFind xsi:type="xsd:boolean">false</CustomObject:FlagShowInFind>
     <CustomObject:FlagShowInNavigator xsi:type="xsd:boolean">false</CustomObject:FlagShowInNavigator>
     <CustomObject:Relations xsi:type="CustomObject:ArrayOfCustomObjectRelation">
      <CustomObject:CustomObjectRelation xsi:type="CustomObject:CustomObjectRelation">
       <CustomObject:EntityName xsi:type="xsd:string"></CustomObject:EntityName>
       <CustomObject:EntityType xsi:type="xsd:string"></CustomObject:EntityType>
       <CustomObject:EntityTitle xsi:type="xsd:string"></CustomObject:EntityTitle>
       <CustomObject:ProviderName xsi:type="xsd:string"></CustomObject:ProviderName>
       <CustomObject:RelationField xsi:type="xsd:string"></CustomObject:RelationField>
       <CustomObject:DisplayField xsi:type="xsd:string"></CustomObject:DisplayField>
       <CustomObject:HideFunctions xsi:type="xsd:boolean">false</CustomObject:HideFunctions>
      </CustomObject:CustomObjectRelation>
     </CustomObject:Relations>
     <CustomObject:HasWebPanels xsi:type="xsd:boolean">false</CustomObject:HasWebPanels>
    </CustomObject:CustomObjectMetadata>
   </CustomObject:Response>
  </CustomObject:GetCustomObjectsMetadataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

