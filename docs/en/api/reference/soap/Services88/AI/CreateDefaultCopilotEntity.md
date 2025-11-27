---
title: Services88.AIAgent.CreateDefaultCopilotEntity SOAP
generated: true
uid: Services88-AI-CreateDefaultCopilotEntity
content_type: reference
---

# Services88 AI CreateDefaultCopilotEntity

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.CreateDefaultCopilotEntity">SuperOffice.Services88.IAIAgent.CreateDefaultCopilotEntity</see> method.

## CreateDefaultCopilotEntity





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultCopilotEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <AI:ApplicationToken>1234567-1234-9876</AI:ApplicationToken>
  <AI:Credentials>
    <AI:Ticket>7T:1234abcxyzExample==</AI:Ticket>
  </AI:Credentials>
 <SOAP-ENV:Body>
   <AI:CreateDefaultCopilotEntity>
   </AI:CreateDefaultCopilotEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultCopilotEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <AI:CreateDefaultCopilotEntityResponse>
   <AI:Response xsi:type="AI:CopilotEntity">
    <AI:CopilotId xsi:type="xsd:int">0</AI:CopilotId>
    <AI:Name xsi:type="xsd:string"></AI:Name>
    <AI:CopilotDataSources xsi:type="AI:ArrayOfCopilotDataSourceEntity">
     <AI:CopilotDataSourceEntity xsi:type="AI:CopilotDataSourceEntity">
      <AI:CopilotDataSourceId xsi:type="xsd:int">0</AI:CopilotDataSourceId>
      <AI:CopilotDataSourceType xsi:type="AI:CopilotDataSourceType">Requests</AI:CopilotDataSourceType>
      <AI:CopilotId xsi:type="xsd:int">0</AI:CopilotId>
      <AI:Description xsi:type="xsd:string"></AI:Description>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:Settings xsi:type="AI:ArrayOfCopilotDataSourceSetting">
       <AI:CopilotDataSourceSetting xsi:type="AI:CopilotDataSourceSetting">
        <AI:CopilotDataSourceSettingId xsi:type="xsd:int">0</AI:CopilotDataSourceSettingId>
        <AI:CopilotDataSourceId xsi:type="xsd:int">0</AI:CopilotDataSourceId>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:CopilotDataSourceSetting>
      </AI:Settings>
     </AI:CopilotDataSourceEntity>
    </AI:CopilotDataSources>
   </AI:Response>
  </AI:CreateDefaultCopilotEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

