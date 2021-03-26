---
uid: services81-selection-createdefaultmailmergetask
title: Services81.SelectionAgent.CreateDefaultMailMergeTask SOAP
Generated: true
---

# Services81 Selection CreateDefaultMailMergeTask SOAP

SOAP request and response examples **Remote/Services81/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services81.ISelectionAgent.CreateDefaultMailMergeTask">SuperOffice.Services81.ISelectionAgent.CreateDefaultMailMergeTask</see> method.

## CreateDefaultMailMergeTask

Loading default values into a new MailMergeTask.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New MailMergeTask with default values


[WSDL file for Services81/Selection](../Services81-Selection.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultMailMergeTask Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:CreateDefaultMailMergeTask>
   </Selection:CreateDefaultMailMergeTask>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultMailMergeTask Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Selection:CreateDefaultMailMergeTaskResponse>
   <Selection:Response xsi:type="Selection:MailMergeTask">
    <Selection:ProjectId xsi:type="xsd:int">0</Selection:ProjectId>
    <Selection:TypeId xsi:type="xsd:int">0</Selection:TypeId>
    <Selection:StartDate xsi:type="xsd:dateTime">2021-03-25T21:34:37Z</Selection:StartDate>
    <Selection:Duration xsi:type="xsd:int">0</Selection:Duration>
    <Selection:Description xsi:type="xsd:string"></Selection:Description>
    <Selection:PriorityId xsi:type="xsd:int">0</Selection:PriorityId>
    <Selection:VisibleFor xsi:type="Selection:VisibleFor">
     <Selection:VisibleId xsi:type="xsd:int">0</Selection:VisibleId>
     <Selection:Visibility xsi:type="Selection:Visibility">All</Selection:Visibility>
     <Selection:DisplayValue xsi:type="xsd:string"></Selection:DisplayValue>
    </Selection:VisibleFor>
    <Selection:Completed xsi:type="Selection:ActivityStatus">Unknown</Selection:Completed>
    <Selection:OwnerAssociateId xsi:type="xsd:int">0</Selection:OwnerAssociateId>
    <Selection:SingleEntryOnEachCompany xsi:type="xsd:boolean">false</Selection:SingleEntryOnEachCompany>
    <Selection:SaleId xsi:type="xsd:int">0</Selection:SaleId>
   </Selection:Response>
  </Selection:CreateDefaultMailMergeTaskResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

