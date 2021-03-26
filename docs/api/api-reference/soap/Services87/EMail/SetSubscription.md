---
uid: services87-email-setsubscription
title: Services87.EMailAgent.SetSubscription SOAP
Generated: true
---

# Services87 EMail SetSubscription SOAP

SOAP request and response examples **Remote/Services87/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IEMailAgent.SetSubscription">SuperOffice.Services87.IEMailAgent.SetSubscription</see> method.

## SetSubscription

Set subscription on or off on a set of folders
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **connectionInfo:** All information needed to connect to the mailserver
* **folders:** Folders to set subscription value on



[WSDL file for Services87/EMail](../Services87-EMail.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetSubscription Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:SetSubscription>
    <EMail:ConnectionInfo xsi:type="EMail:EMailConnectionInfo">
     <EMail:ServerName xsi:type="xsd:string"></EMail:ServerName>
     <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
     <EMail:Password xsi:type="xsd:string"></EMail:Password>
     <EMail:Folder xsi:type="xsd:string"></EMail:Folder>
     <EMail:UseSSL xsi:type="xsd:boolean">false</EMail:UseSSL>
    </EMail:ConnectionInfo>
    <EMail:Folders xsi:type="EMail:ArrayOfEMailFolder">
     <EMail:EMailFolder xsi:type="EMail:EMailFolder">
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
      <EMail:Delimiter xsi:type="xsd:string"></EMail:Delimiter>
      <EMail:Flags xsi:type="xsd:string"></EMail:Flags>
      <EMail:TotalItems xsi:type="xsd:int">0</EMail:TotalItems>
      <EMail:UnreadItems xsi:type="xsd:int">0</EMail:UnreadItems>
      <EMail:Subscribed xsi:type="xsd:boolean">false</EMail:Subscribed>
      <EMail:EmailFolderId xsi:type="xsd:int">0</EMail:EmailFolderId>
     </EMail:EMailFolder>
    </EMail:Folders>
   </EMail:SetSubscription>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetSubscription Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <EMail:SetSubscriptionResponse>
  </EMail:SetSubscriptionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

