---
uid: services80-viewstate-gethistorylengthprefvalue
title: Services80.ViewStateAgent.GetHistoryLengthPrefValue SOAP
Generated: true
---

# Services80 ViewState GetHistoryLengthPrefValue SOAP

SOAP request and response examples **Remote/Services80/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IViewStateAgent.GetHistoryLengthPrefValue">SuperOffice.Services80.IViewStateAgent.GetHistoryLengthPrefValue</see> method.

## GetHistoryLengthPrefValue

Get the logged on user's preferred history list length. Will return the system preference if no user preferences are available.


**Returns:** The history list lenght


[WSDL file for Services80/ViewState](../Services80-ViewState.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetHistoryLengthPrefValue Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <ViewState:ApplicationToken>1234567-1234-9876</ViewState:ApplicationToken>
  <ViewState:Credentials>
    <ViewState:Ticket>7T:1234abcxyzExample==</ViewState:Ticket>
  </ViewState:Credentials>
 <SOAP-ENV:Body>
   <ViewState:GetHistoryLengthPrefValue>
   </ViewState:GetHistoryLengthPrefValue>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetHistoryLengthPrefValue Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <ViewState:GetHistoryLengthPrefValueResponse>
   <ViewState:Response xsi:type="xsd:int">0</ViewState:Response>
  </ViewState:GetHistoryLengthPrefValueResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

