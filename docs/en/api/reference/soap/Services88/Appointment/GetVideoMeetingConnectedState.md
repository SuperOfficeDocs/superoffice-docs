---
title: Services88.AppointmentAgent.GetVideoMeetingConnectedState SOAP
generated: true
uid: Services88-Appointment-GetVideoMeetingConnectedState
content_type: reference
---

# Services88 Appointment GetVideoMeetingConnectedState

SOAP request and response examples **Remote/Services88/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAppointmentAgent.GetVideoMeetingConnectedState">SuperOffice.Services88.IAppointmentAgent.GetVideoMeetingConnectedState</see> method.

## GetVideoMeetingConnectedState





[WSDL file for Services88/Appointment](../Services88-Appointment.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetVideoMeetingConnectedState Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:GetVideoMeetingConnectedState>
   </Appointment:GetVideoMeetingConnectedState>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetVideoMeetingConnectedState Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Appointment:GetVideoMeetingConnectedStateResponse>
   <Appointment:Response xsi:type="Appointment:UserConnectedState">
    <Appointment:IsConnected xsi:type="xsd:boolean">false</Appointment:IsConnected>
    <Appointment:ProviderId xsi:type="xsd:string"></Appointment:ProviderId>
    <Appointment:LoginUrl xsi:type="xsd:string"></Appointment:LoginUrl>
   </Appointment:Response>
  </Appointment:GetVideoMeetingConnectedStateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

