---
title: Services88.TargetsAgent.CreateDefaultTargetRevisionHistory SOAP
generated: 1
uid: Services88-Targets-CreateDefaultTargetRevisionHistory
---

# Services88 Targets CreateDefaultTargetRevisionHistory

SOAP request and response examples **Remote/Services88/Targets.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITargetsAgent.CreateDefaultTargetRevisionHistory">SuperOffice.Services88.ITargetsAgent.CreateDefaultTargetRevisionHistory</see> method.

## CreateDefaultTargetRevisionHistory

Loading default values into a new TargetRevisionHistory.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New TargetRevisionHistory with default values


[WSDL file for Services88/Targets](../Services88-Targets.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultTargetRevisionHistory Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Targets="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Targets:ApplicationToken>1234567-1234-9876</Targets:ApplicationToken>
  <Targets:Credentials>
    <Targets:Ticket>7T:1234abcxyzExample==</Targets:Ticket>
  </Targets:Credentials>
 <SOAP-ENV:Body>
   <Targets:CreateDefaultTargetRevisionHistory>
   </Targets:CreateDefaultTargetRevisionHistory>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultTargetRevisionHistory Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Targets="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Targets:CreateDefaultTargetRevisionHistoryResponse>
   <Targets:Response xsi:type="Targets:TargetRevisionHistory">
    <Targets:TargetGroupId xsi:type="xsd:int">0</Targets:TargetGroupId>
    <Targets:Year xsi:type="xsd:int">0</Targets:Year>
    <Targets:Revisions xsi:type="Targets:ArrayOfTargetRevision">
     <Targets:TargetRevision xsi:type="Targets:TargetRevision">
      <Targets:LogEvent xsi:type="Targets:LogEvent">None</Targets:LogEvent>
      <Targets:Who xsi:type="Targets:Associate">
       <Targets:AssociateId xsi:type="xsd:int">0</Targets:AssociateId>
       <Targets:Name xsi:type="xsd:string"></Targets:Name>
       <Targets:PersonId xsi:type="xsd:int">0</Targets:PersonId>
       <Targets:Rank xsi:type="xsd:short">0</Targets:Rank>
       <Targets:Tooltip xsi:type="xsd:string"></Targets:Tooltip>
       <Targets:Type xsi:type="Targets:UserType">Unknown</Targets:Type>
       <Targets:GroupIdx xsi:type="xsd:int">0</Targets:GroupIdx>
       <Targets:FullName xsi:type="xsd:string"></Targets:FullName>
       <Targets:FormalName xsi:type="xsd:string"></Targets:FormalName>
       <Targets:Deleted xsi:type="xsd:boolean">false</Targets:Deleted>
       <Targets:EjUserId xsi:type="xsd:int">0</Targets:EjUserId>
       <Targets:UserName xsi:type="xsd:string"></Targets:UserName>
      </Targets:Who>
      <Targets:When xsi:type="xsd:dateTime">2022-08-26T09:00:33Z</Targets:When>
      <Targets:Changes xsi:type="Targets:ArrayOfTargetChange">
       <Targets:TargetChange xsi:type="Targets:TargetChange">
        <Targets:FieldIdentifier xsi:type="xsd:string"></Targets:FieldIdentifier>
        <Targets:ValueChangeFrom xsi:type="xsd:double">0.0</Targets:ValueChangeFrom>
        <Targets:ValueChangeTo xsi:type="xsd:double">0.0</Targets:ValueChangeTo>
       </Targets:TargetChange>
      </Targets:Changes>
     </Targets:TargetRevision>
    </Targets:Revisions>
   </Targets:Response>
  </Targets:CreateDefaultTargetRevisionHistoryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

