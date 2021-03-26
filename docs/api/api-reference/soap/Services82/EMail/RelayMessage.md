---
uid: services82-email-relaymessage
title: Services82.EMailAgent.RelayMessage SOAP
Generated: true
---

# Services82 EMail RelayMessage SOAP

SOAP request and response examples **Remote/Services82/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IEMailAgent.RelayMessage">SuperOffice.Services82.IEMailAgent.RelayMessage</see> method.

## RelayMessage



* **connectionInfoExtended:** 
* **rfc822:** 
* **from:** 
* **recipients:** 



[WSDL file for Services82/EMail](../Services82-EMail.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RelayMessage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:RelayMessage>
    <EMail:ConnectionInfoExtended xsi:type="EMail:EMailConnectionInfoExtended">
     <EMail:Port xsi:type="xsd:int">0</EMail:Port>
     <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
     <EMail:Protocol xsi:type="xsd:string"></EMail:Protocol>
     <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
     <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
     <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
    </EMail:ConnectionInfoExtended>
    <EMail:Rfc822 xsi:type="xsd:string"></EMail:Rfc822>
    <EMail:From xsi:type="xsd:string"></EMail:From>
    <EMail:Recipients xsi:type="NetServerServices822:ArrayOfstring">
     <NetServerServices822:string xsi:type="xsd:string"></NetServerServices822:string>
    </EMail:Recipients>
   </EMail:RelayMessage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RelayMessage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <EMail:RelayMessageResponse>
  </EMail:RelayMessageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

