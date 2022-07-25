---
title: Services84.SelectionAgent.CreateDefaultMailMergeSettings SOAP
generated: 1
uid: Services84-Selection-CreateDefaultMailMergeSettings
---

# Services84 Selection CreateDefaultMailMergeSettings

SOAP request and response examples **Remote/Services84/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ISelectionAgent.CreateDefaultMailMergeSettings">SuperOffice.Services84.ISelectionAgent.CreateDefaultMailMergeSettings</see> method.

## CreateDefaultMailMergeSettings

Loading default values into a new MailMergeSettings.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance

**Returns:** New MailMergeSettings with default values

[WSDL file for Services84/Selection](../Services84-Selection.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultMailMergeSettings Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:CreateDefaultMailMergeSettings>
   </Selection:CreateDefaultMailMergeSettings>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## CreateDefaultMailMergeSettings Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Selection:CreateDefaultMailMergeSettingsResponse>
   <Selection:Response xsi:type="Selection:MailMergeSettings">
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:DocumentId xsi:type="xsd:int">0</Selection:DocumentId>
    <Selection:MailMergeDeliveryType xsi:type="Selection:EMailMergeTargetType">BestFit</Selection:MailMergeDeliveryType>
    <Selection:CustomAttention xsi:type="xsd:string"></Selection:CustomAttention>
    <Selection:AlwaysUseCustomAttention xsi:type="xsd:boolean">false</Selection:AlwaysUseCustomAttention>
    <Selection:SaveDocument xsi:type="xsd:boolean">false</Selection:SaveDocument>
    <Selection:CustomMailBody xsi:type="xsd:string"></Selection:CustomMailBody>
    <Selection:TaskEntity xsi:type="Selection:MailMergeTask">
     <Selection:ProjectId xsi:type="xsd:int">0</Selection:ProjectId>
     <Selection:TypeId xsi:type="xsd:int">0</Selection:TypeId>
     <Selection:StartDate xsi:type="xsd:dateTime">2021-11-30T13:22:21Z</Selection:StartDate>
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
    </Selection:TaskEntity>
    <Selection:AddCompanyInterest xsi:type="xsd:int">0</Selection:AddCompanyInterest>
    <Selection:AddPersonInterest xsi:type="xsd:int">0</Selection:AddPersonInterest>
    <Selection:RemoveCompanyInterest xsi:type="xsd:int">0</Selection:RemoveCompanyInterest>
    <Selection:RemovePersonInterest xsi:type="xsd:int">0</Selection:RemovePersonInterest>
    <Selection:IncludeNoMailingsRecipient xsi:type="xsd:boolean">false</Selection:IncludeNoMailingsRecipient>
    <Selection:TestOnly xsi:type="xsd:boolean">false</Selection:TestOnly>
    <Selection:ProjectId xsi:type="xsd:int">0</Selection:ProjectId>
    <Selection:IncludeRetiredRecipients xsi:type="xsd:boolean">false</Selection:IncludeRetiredRecipients>
    <Selection:IncludeStoppedRecipients xsi:type="xsd:boolean">false</Selection:IncludeStoppedRecipients>
    <Selection:CustomMailSubject xsi:type="xsd:string"></Selection:CustomMailSubject>
    <Selection:ExtraInfo xsi:type="xsd:string"></Selection:ExtraInfo>
    <Selection:Synchronous xsi:type="xsd:boolean">false</Selection:Synchronous>
    <Selection:IsTemporarySelection xsi:type="xsd:boolean">false</Selection:IsTemporarySelection>
   </Selection:Response>
  </Selection:CreateDefaultMailMergeSettingsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
