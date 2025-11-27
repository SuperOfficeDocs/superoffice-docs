---
title: Services88.AIAgent.GetCopilotDataSourceEntity SOAP
generated: true
uid: Services88-AI-GetCopilotDataSourceEntity
content_type: reference
---

# Services88 AI GetCopilotDataSourceEntity

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.GetCopilotDataSourceEntity">SuperOffice.Services88.IAIAgent.GetCopilotDataSourceEntity</see> method.

## GetCopilotDataSourceEntity





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCopilotDataSourceEntity Request

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
   <AI:GetCopilotDataSourceEntity>
    <AI:CopilotDataSourceEntityId xsi:type="xsd:int">0</AI:CopilotDataSourceEntityId>
   </AI:GetCopilotDataSourceEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCopilotDataSourceEntity Response

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
  <AI:GetCopilotDataSourceEntityResponse>
   <AI:Response xsi:type="AI:CopilotDataSourceEntity">
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
   </AI:Response>
  </AI:GetCopilotDataSourceEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

