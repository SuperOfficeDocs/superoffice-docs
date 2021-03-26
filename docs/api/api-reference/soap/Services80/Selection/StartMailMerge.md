---
uid: services80-selection-startmailmerge
title: Services80.SelectionAgent.StartMailMerge SOAP
Generated: true
---

# Services80 Selection StartMailMerge SOAP

SOAP request and response examples **Remote/Services80/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services80.ISelectionAgent.StartMailMerge">SuperOffice.Services80.ISelectionAgent.StartMailMerge</see> method.

## StartMailMerge

Start a mailmerge operation with specified settings.

* **settings:** All settings needed to perform the mailmerge operation.



[WSDL file for Services80/Selection](../Services80-Selection.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## StartMailMerge Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:StartMailMerge>
    <Selection:Settings xsi:type="Selection:MailMergeSettings">
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
      <Selection:StartDate xsi:type="xsd:dateTime">2021-03-25T21:34:19Z</Selection:StartDate>
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
    </Selection:Settings>
   </Selection:StartMailMerge>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## StartMailMerge Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Selection:StartMailMergeResponse>
  </Selection:StartMailMergeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

