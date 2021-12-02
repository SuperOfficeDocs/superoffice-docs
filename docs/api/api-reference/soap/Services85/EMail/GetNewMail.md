---
title: Services85.EMailAgent.GetNewMail SOAP
generated: 1
uid: Services85-EMail-GetNewMail
---

# Services85 EMail GetNewMail

SOAP request and response examples **Remote/Services85/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IEMailAgent.GetNewMail">SuperOffice.Services85.IEMailAgent.GetNewMail</see> method.

## GetNewMail

Get new email in folder(s) for current associate

* **folders:** List of folder ids to check for new email

**Returns:** The downloaded email envelopes


[WSDL file for Services85/EMail](../Services85-EMail.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNewMail Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetNewMail>
    <EMail:Folders xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
    </EMail:Folders>
   </EMail:GetNewMail>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNewMail Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <EMail:GetNewMailResponse>
   <EMail:Response xsi:type="EMail:ArrayOfEMailEnvelope">
    <EMail:EMailEnvelope xsi:type="EMail:EMailEnvelope">
     <EMail:ServerId xsi:type="xsd:int">0</EMail:ServerId>
     <EMail:MessageId xsi:type="xsd:string"></EMail:MessageId>
     <EMail:Subject xsi:type="xsd:string"></EMail:Subject>
     <EMail:From xsi:type="EMail:EMailAddress">
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Address xsi:type="xsd:string"></EMail:Address>
      <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
      <EMail:DuplicatePersonIds xsi:type="NetServerServices852:ArrayOfint">
       <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
      </EMail:DuplicatePersonIds>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
     </EMail:From>
     <EMail:To xsi:type="EMail:ArrayOfEMailAddress">
      <EMail:EMailAddress xsi:type="EMail:EMailAddress">
       <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
       <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
       <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
       <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
       <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
       <EMail:Address xsi:type="xsd:string"></EMail:Address>
       <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
       <EMail:DuplicatePersonIds xsi:type="NetServerServices852:ArrayOfint">
        <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
       </EMail:DuplicatePersonIds>
       <EMail:Name xsi:type="xsd:string"></EMail:Name>
      </EMail:EMailAddress>
     </EMail:To>
     <EMail:Sent xsi:type="xsd:dateTime">2021-11-30T13:22:31Z</EMail:Sent>
     <EMail:Priority xsi:type="EMail:EMailPriority">NoPriority</EMail:Priority>
     <EMail:Flags xsi:type="EMail:EMailFlags">Seen</EMail:Flags>
     <EMail:Size xsi:type="xsd:int">0</EMail:Size>
     <EMail:EMailSOInfo xsi:type="EMail:EMailSOInfo">
      <EMail:DocumentId xsi:type="xsd:int">0</EMail:DocumentId>
      <EMail:AppointmentId xsi:type="xsd:int">0</EMail:AppointmentId>
      <EMail:ProjectId xsi:type="xsd:int">0</EMail:ProjectId>
      <EMail:SaleId xsi:type="xsd:int">0</EMail:SaleId>
      <EMail:Archived xsi:type="xsd:boolean">false</EMail:Archived>
      <EMail:ArchivedAt xsi:type="xsd:dateTime">2021-11-30T13:22:31Z</EMail:ArchivedAt>
      <EMail:ArchivedBy xsi:type="xsd:int">0</EMail:ArchivedBy>
      <EMail:ArchivedDisplayName xsi:type="xsd:string"></EMail:ArchivedDisplayName>
     </EMail:EMailSOInfo>
    </EMail:EMailEnvelope>
   </EMail:Response>
  </EMail:GetNewMailResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

