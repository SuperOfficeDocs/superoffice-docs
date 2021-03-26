---
uid: services82-sale-offerautonextstageonapppointmentcompleted
title: Services82.SaleAgent.OfferAutoNextStageOnApppointmentCompleted SOAP
Generated: true
---

# Services82 Sale OfferAutoNextStageOnApppointmentCompleted SOAP

SOAP request and response examples **Remote/Services82/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services82.ISaleAgent.OfferAutoNextStageOnApppointmentCompleted">SuperOffice.Services82.ISaleAgent.OfferAutoNextStageOnApppointmentCompleted</see> method.

## OfferAutoNextStageOnApppointmentCompleted



* **appointmentId:** 



[WSDL file for Services82/Sale](../Services82-Sale.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## OfferAutoNextStageOnApppointmentCompleted Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:OfferAutoNextStageOnApppointmentCompleted>
    <Sale:AppointmentId xsi:type="xsd:int">0</Sale:AppointmentId>
   </Sale:OfferAutoNextStageOnApppointmentCompleted>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## OfferAutoNextStageOnApppointmentCompleted Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Sale:OfferAutoNextStageOnApppointmentCompletedResponse>
   <Sale:Response xsi:type="xsd:boolean">false</Sale:Response>
  </Sale:OfferAutoNextStageOnApppointmentCompletedResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

