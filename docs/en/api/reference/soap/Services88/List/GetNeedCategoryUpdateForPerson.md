---
title: Services88.ListAgent.GetNeedCategoryUpdateForPerson SOAP
generated: true
uid: Services88-List-GetNeedCategoryUpdateForPerson
content_type: reference
---

# Services88 List GetNeedCategoryUpdateForPerson

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.GetNeedCategoryUpdateForPerson">SuperOffice.Services88.IListAgent.GetNeedCategoryUpdateForPerson</see> method.

## GetNeedCategoryUpdateForPerson





[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNeedCategoryUpdateForPerson Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetNeedCategoryUpdateForPerson>
    <List:LeadStatus xsi:type="xsd:int">0</List:LeadStatus>
    <List:PersonId xsi:type="xsd:int">0</List:PersonId>
    <List:ContactId xsi:type="xsd:int">0</List:ContactId>
    <List:CategoryId xsi:type="xsd:int">0</List:CategoryId>
   </List:GetNeedCategoryUpdateForPerson>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNeedCategoryUpdateForPerson Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:GetNeedCategoryUpdateForPersonResponse>
   <List:Response xsi:type="List:AutomatedCategoryUpdate">
    <List:Enabled xsi:type="xsd:boolean">false</List:Enabled>
    <List:TriggerType xsi:type="List:CategoryUpdateTrigger">None</List:TriggerType>
    <List:UserConfirmation xsi:type="xsd:boolean">false</List:UserConfirmation>
    <List:DefaultCategory xsi:type="xsd:int">0</List:DefaultCategory>
    <List:LeadstatusId xsi:type="xsd:int">0</List:LeadstatusId>
   </List:Response>
  </List:GetNeedCategoryUpdateForPersonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

