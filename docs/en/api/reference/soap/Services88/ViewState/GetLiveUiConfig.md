---
title: Services88.ViewStateAgent.GetLiveUiConfig SOAP
generated: true
uid: Services88-ViewState-GetLiveUiConfig
content_type: reference
---

# Services88 ViewState GetLiveUiConfig

SOAP request and response examples **Remote/Services88/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IViewStateAgent.GetLiveUiConfig">SuperOffice.Services88.IViewStateAgent.GetLiveUiConfig</see> method.

## GetLiveUiConfig





[WSDL file for Services88/ViewState](../Services88-ViewState.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLiveUiConfig Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <ViewState:ApplicationToken>1234567-1234-9876</ViewState:ApplicationToken>
  <ViewState:Credentials>
    <ViewState:Ticket>7T:1234abcxyzExample==</ViewState:Ticket>
  </ViewState:Credentials>
 <SOAP-ENV:Body>
   <ViewState:GetLiveUiConfig>
   </ViewState:GetLiveUiConfig>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLiveUiConfig Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <ViewState:GetLiveUiConfigResponse>
   <ViewState:Response xsi:type="ViewState:LiveUiConfig">
    <ViewState:IsEnabled xsi:type="xsd:boolean">false</ViewState:IsEnabled>
    <ViewState:PollingInterval xsi:type="xsd:int">0</ViewState:PollingInterval>
   </ViewState:Response>
  </ViewState:GetLiveUiConfigResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

