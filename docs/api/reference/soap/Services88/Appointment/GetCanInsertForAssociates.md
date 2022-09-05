---
title: Services88.AppointmentAgent.GetCanInsertForAssociates SOAP
generated: 1
uid: Services88-Appointment-GetCanInsertForAssociates
---

# Services88 Appointment GetCanInsertForAssociates

SOAP request and response examples **Remote/Services88/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAppointmentAgent.GetCanInsertForAssociates">SuperOffice.Services88.IAppointmentAgent.GetCanInsertForAssociates</see> method.

## GetCanInsertForAssociates

Check if current associate can create appointments in the diary of other associates.

* **associateIds:** Array of associate ids to check for.

**Returns:** Returns an array of bool corresponding to the associate array input parameter.


[WSDL file for Services88/Appointment](../Services88-Appointment.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCanInsertForAssociates Request

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
   <Appointment:GetCanInsertForAssociates>
    <Appointment:AssociateIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Appointment:AssociateIds>
   </Appointment:GetCanInsertForAssociates>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCanInsertForAssociates Response

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
  <Appointment:GetCanInsertForAssociatesResponse>
   <Appointment:Response xsi:type="NetServerServices882:ArrayOfboolean">
    <NetServerServices882:boolean xsi:type="xsd:boolean">false</NetServerServices882:boolean>
   </Appointment:Response>
  </Appointment:GetCanInsertForAssociatesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

