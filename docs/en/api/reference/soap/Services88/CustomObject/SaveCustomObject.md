---
title: Services88.CustomObjectAgent.SaveCustomObject SOAP
generated: true
uid: Services88-CustomObject-SaveCustomObject
content_type: reference
---

# Services88 CustomObject SaveCustomObject

SOAP request and response examples **Remote/Services88/CustomObject.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomObjectAgent.SaveCustomObject">SuperOffice.Services88.ICustomObjectAgent.SaveCustomObject</see> method.

## SaveCustomObject





[WSDL file for Services88/CustomObject](../Services88-CustomObject.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveCustomObject Request

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
   <CustomObject:SaveCustomObject>
    <CustomObject:DefinitionName xsi:type="xsd:string"></CustomObject:DefinitionName>
    <CustomObject:Row xsi:type="CustomObject:CustomObject">
     <CustomObject:DefinitionName xsi:type="xsd:string"></CustomObject:DefinitionName>
     <CustomObject:Id xsi:type="xsd:int">0</CustomObject:Id>
     <CustomObject:Values xsi:type="CustomObject:StringDictionary">
      <CustomObject:StringKeyValuePair>
       <CustomObject:Key xsi:type="xsd:string"></CustomObject:Key>
       <CustomObject:Value xsi:type="xsd:string"></CustomObject:Value>
      </CustomObject:StringKeyValuePair>
     </CustomObject:Values>
    </CustomObject:Row>
   </CustomObject:SaveCustomObject>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveCustomObject Response

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
  <CustomObject:SaveCustomObjectResponse>
   <CustomObject:Response xsi:type="CustomObject:CustomObject">
    <CustomObject:DefinitionName xsi:type="xsd:string"></CustomObject:DefinitionName>
    <CustomObject:Id xsi:type="xsd:int">0</CustomObject:Id>
    <CustomObject:Values xsi:type="CustomObject:StringDictionary">
     <CustomObject:StringKeyValuePair>
      <CustomObject:Key xsi:type="xsd:string"></CustomObject:Key>
      <CustomObject:Value xsi:type="xsd:string"></CustomObject:Value>
     </CustomObject:StringKeyValuePair>
    </CustomObject:Values>
   </CustomObject:Response>
  </CustomObject:SaveCustomObjectResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

