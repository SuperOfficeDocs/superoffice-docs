---
uid: table-Heading
title: Heading table
description: Heading items for all MDO lists, lists that are grouped and filtered.
so.generated: true
keywords: database table Heading
so.topic: reference
so.envir: onsite, online
---

# Heading Table (58)

Heading items for all MDO lists, lists that are grouped and filtered.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|heading\_id|Primary key|PK| |
|name|The visible heading|String(239)| |
|rank|Rank order |UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is deleted and should not be shown in lists|UShort|&#x25CF;|
|listTableId|Which List is this heading connected to? (table ID)|TableNumber| |
|extraId|Extra ID for refining the list id|Id|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Heading table relationship diagram](./media/Heading.png)

[!include[details](./includes/heading.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|heading\_id |PK |Clustered, Unique |
|name |String(239) |Index |
|listTableId |TableNumber |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[AmountClassHeadingLink](amountclassheadinglink.md)  |Heading link table for AmountClass, for MDO headers |
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[AssociateHeadingLink](associateheadinglink.md)  |Heading link table for associate for display only. Supportive table, used for grouping and filtering on lists.  |
|[BusinessHeadingLink](businessheadinglink.md)  |Heading link table for Business, for MDO headers |
|[CategoryHeadingLink](categoryheadinglink.md)  |Heading link table for Category, for MDO headers |
|[ComptrHeadingLink](comptrheadinglink.md)  |Heading link table for Comptr, for MDO headers |
|[ContIntHeadingLink](contintheadinglink.md)  |Heading link table for ContInt, for MDO headers |
|[CountryHeadingLink](countryheadinglink.md)  |Heading link table for Country, for MDO headers |
|[CreditedHeadingLink](creditedheadinglink.md)  |Heading link table for Credited, for MDO headers |
|[CurrencyHeadingLink](currencyheadinglink.md)  |Heading link table for Currency, for MDO headers |
|[DeliveryTermsHeadingLink](deliverytermsheadinglink.md)  |Heading link table for DeliveryTerms, for MDO item headings |
|[DeliveryTypeHeadingLink](deliverytypeheadinglink.md)  |Heading link table for DeliveryType, for MDO item headings |
|[DocTmplHeadingLink](doctmplheadinglink.md)  |Heading link table for DocTmpl, for MDO headers |
|[ExtAppHeadingLink](extappheadinglink.md)  |Heading link table for ExtApp, for MDO headers |
|[IntentHeadingLink](intentheadinglink.md)  |Heading link table for Intent, for MDO headers |
|[MrMrsHeadingLink](mrmrsheadinglink.md)  |Heading link table for MrMrs, for MDO headers |
|[PaymentTermsHeadingLink](paymenttermsheadinglink.md)  |Heading link table for PaymentTerms, for MDO item headings |
|[PaymentTypeHeadingLink](paymenttypeheadinglink.md)  |Heading link table for PaymentType, for MDO item headings |
|[PersIntHeadingLink](persintheadinglink.md)  |Heading link table for PersInt, for MDO headers |
|[PersPosHeadingLink](persposheadinglink.md)  |Heading link table for PersPos, for MDO headers |
|[PMembTypeHeadingLink](pmembtypeheadinglink.md)  |Heading link table for PMembType, for MDO headers |
|[PriceUnitHeadingLink](priceunitheadinglink.md)  |Heading link table for PriceUnit, for MDO item headings |
|[PriorityHeadingLink](priorityheadinglink.md)  |Heading link table for Priority, for MDO headers |
|[ProbHeadingLink](probheadinglink.md)  |Heading link table for Prob, for MDO headers |
|[ProductCategoryHeadingLink](productcategoryheadinglink.md)  |Heading link table for ProductCategory, for MDO item headings |
|[ProductFamilyHeadingLink](productfamilyheadinglink.md)  |Heading link table for ProductFamily, for MDO item headings |
|[ProductTypeHeadingLink](producttypeheadinglink.md)  |Heading link table for ProductType, for MDO item headings |
|[ProjStatusHeadingLink](projstatusheadinglink.md)  |Heading link table for ProjStatus, for MDO headers |
|[ProjTypeHeadingLink](projtypeheadinglink.md)  |Heading link table for ProjType, for MDO headers |
|[QuoteApprReasonHeadingLink](quoteapprreasonheadinglink.md)  |Heading link table for QuoteApprReason, for MDO headers |
|[QuoteDenyReasonHeadingLink](quotedenyreasonheadinglink.md)  |Heading link table for QuoteDenyReason, for MDO headers |
|[ReasonHeadingLink](reasonheadinglink.md)  |Heading link table for Reason, for MDO headers |
|[ReasonSoldHeadingLink](reasonsoldheadinglink.md)  |Heading link table for ReasonSold, for MDO headers |
|[ReasonStalledHeadingLink](reasonstalledheadinglink.md)  |Heading link table for ReasonStalled, for MDO headers |
|[RejectReasonHeadingLink](rejectreasonheadinglink.md)  |Heading link table for RejectReason, for MDO headers |
|[RelDefHeadingLink](reldefheadinglink.md)  |Heading link table for RelDef, for MDO headers |
|[SaleTypeCatHeadingLink](saletypecatheadinglink.md)  |Heading link table for SaleTypeCat, for MDO headers |
|[SaleTypeHeadingLink](saletypeheadinglink.md)  |Heading link table for SaleType, for MDO headers |
|[SalutationHeadingLink](salutationheadinglink.md)  |Heading link table for Salutation, for MDO headers |
|[SearchCatHeadingLink](searchcatheadinglink.md)  |Heading link table for SearchCat, for MDO headers |
|[SourceHeadingLink](sourceheadinglink.md)  |Heading link table for Source, for MDO headers |
|[StakeholderRoleHeadingLink](stakeholderroleheadinglink.md)  |Heading link table for StakeholderRole, for MDO headers |
|[SubscriptionUnitHeadingLink](subscriptionunitheadinglink.md)  |Heading link table for SubscriptionUnit, for MDO item headings |
|[TagsHeadingLink](tagsheadinglink.md)  |Heading link table for Source, for MDO headers |
|[TaskHeadingLink](taskheadinglink.md)  |Heading link table for Task, for MDO headers |
|[TaskMenuHeadingLink](taskmenuheadinglink.md)  |Heading link table for TaskMenu, for MDO headers |
|[UDListHeadingLink](udlistheadinglink.md)  |Heading link table for UDList, for MDO headers. Note - MDO mode for userdefinede lists are either turned on or off, you may not have it on for one userdefined list and off for the others. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

