---
uid: QuoteLineStaticSelection
title: QuoteLineStaticSelection
description: Static archive Provider for the Selection quoteline archive.
keywords: QuoteLineStaticSelection archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "QuoteLineStaticSelection"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.QuoteLineSelectionStaticProvider">SuperOffice.CRM.ArchiveLists.Archive.QuoteLineSelectionStaticProvider</see> inside NetServer's SODatabase assembly.

Static archive Provider for the Selection quoteline archive.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"quoteLine"|[[Quoteline static]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|quoteLineId|int|SR\_QUOTE\_QUOTELINE\_QUOTELINEID: SR\_QUOTE\_QUOTELINE\_QUOTELINEID\_TOOLTIP| x |
|quoteAlternativeId|int|SR\_QUOTE\_QUOTELINE\_QUOTEALTERNATIVEID: SR\_QUOTE\_QUOTELINE\_QUOTEALTERNATIVEID\_TOOLTIP| x |
|erpProductKey|string|SR\_QUOTE\_QUOTELINE\_PRODUCTKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTKEY\_TOOLTIP| x |
|rank|int|SR\_QUOTE\_QUOTELINE\_RANK: SR\_QUOTE\_QUOTELINE\_RANK\_TOOLTIP| x |
|quantity|decimal|SR\_QUOTE\_QUOTELINE\_QUANTITY: SR\_QUOTE\_QUOTELINE\_QUANTITY\_TOOLTIP| x |
|name|string|SR\_QUOTE\_QUOTELINE\_NAME: SR\_QUOTE\_QUOTELINE\_NAME\_TOOLTIP| x |
|description|string|SR\_QUOTE\_QUOTELINE\_DESCRIPTION: SR\_QUOTE\_QUOTELINE\_DESCRIPTION\_TOOLTIP| x |
|code|string|SR\_QUOTE\_QUOTELINE\_CODE: SR\_QUOTE\_QUOTELINE\_CODE\_TOOLTIP| x |
|quantityUnit|string|SR\_QUOTE\_QUOTELINE\_UNIT: SR\_QUOTE\_QUOTELINE\_UNIT\_TOOLTIP| x |
|priceUnit|string|SR\_QUOTE\_QUOTELINE\_PRICEUNIT: SR\_QUOTE\_QUOTELINE\_PRICEUNIT\_TOOLTIP| x |
|url|string|SR\_QUOTE\_QUOTELINE\_URL: SR\_QUOTE\_QUOTELINE\_URL\_TOOLTIP| x |
|subscriptionUnit|string|SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT: SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT\_TOOLTIP| x |
|subscriptionQuantity|decimal|SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONQUANTITY: SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONQUANTITY\_TOOLTIP| x |
|UnitListPriceSubscriptionQuantity| *None* |SR\_SUBSCRIPTIONLISTPRICE: SR\_SUBSCRIPTIONLISTPRICE\_TOOLTIP|  |
|PriceUnitSubscriptionUnit| *None* |SR\_PRICESUBUNIT: SR\_PRICESUBUNIT\_TOOLTIP|  |
|PriceUnitSubscriptionQuantityUnit| *None* |SR\_EXPANDEDUNIT: SR\_EXPANDEDUNIT\_TOOLTIP|  |
|vatInfo|string|SR\_QUOTE\_QUOTELINE\_VATINFO: SR\_QUOTE\_QUOTELINE\_VATINFO\_TOOLTIP| x |
|vat|decimal|SR\_QUOTE\_QUOTELINE\_VAT: SR\_QUOTE\_QUOTELINE\_VAT\_TOOLTIP| x |
|unitCost|decimal|SR\_QUOTE\_QUOTELINE\_UNITCOST: SR\_QUOTE\_QUOTELINE\_UNITCOST\_TOOLTIP| x |
|unitMinimumPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE: SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE\_TOOLTIP| x |
|unitListPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE: SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE\_TOOLTIP| x |
|totalPrice|decimal|SR\_QUOTE\_QUOTELINE\_TOTALPRICE: SR\_QUOTE\_QUOTELINE\_TOTALPRICE\_TOOLTIP| x |
|totalCost|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_TOTALCOST|  |
|quoteLineThumbnail| *None* |SR\_QUOTE\_QUOTELINE\_THUMBNAIL: SR\_QUOTE\_QUOTELINE\_THUMBNAIL\_TOOLTIP|  |
|quoteLineThumbnailLarge| *None* |SR\_QUOTE\_QUOTELINE\_THUMBNAIL: SR\_QUOTE\_QUOTELINE\_THUMBNAIL\_TOOLTIP|  |
|discountAmount|decimal|SR\_QUOTE\_QUOTELINE\_DISCOUNTAMOUNT: SR\_QUOTE\_QUOTELINE\_DISCOUNTAMOUNT\_TOOLTIP| x |
|discountPercent|decimal|SR\_QUOTE\_QUOTELINE\_DISCOUNTPERCENT: SR\_QUOTE\_QUOTELINE\_DISCOUNTPERCENT\_TOOLTIP| x |
|earningAmount|decimal|SR\_QUOTE\_QUOTELINE\_EARNINGAMOUNT: SR\_QUOTE\_QUOTELINE\_EARNINGAMOUNT\_TOOLTIP| x |
|earningPercent|decimal|SR\_QUOTE\_QUOTELINE\_EARNINGPERCENT: SR\_QUOTE\_QUOTELINE\_EARNINGPERCENT\_TOOLTIP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|productCategoryKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY\_TOOLTIP|  |
|productFamilyKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY\_TOOLTIP|  |
|productTypeKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY\_TOOLTIP|  |
|status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP| x |
|subTotal|decimal|SR\_QUOTE\_QUOTELINE\_SUBTOTAL: SR\_QUOTE\_QUOTELINE\_SUBTOTAL\_TOOLTIP| x |
|vatAmount|decimal|SR\_QUOTE\_QUOTELINE\_VATAMNT: SR\_QUOTE\_QUOTELINE\_VATAMNT\_TOOLTIP| x |
|totalPriceIncVAT|decimal|SR\_QUOTE\_QUOTELINE\_TOTINCVAT: SR\_QUOTE\_QUOTELINE\_TOTINCVAT\_TOOLTIP| x |
|totalPriceWithAlternativeDiscount|decimal|SR\_QUOTE\_QUOTELINE\_TOTINCALTDIS: SR\_QUOTE\_QUOTELINE\_TOTINCALTDIS\_TOOLTIP| x |
|selectionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP|  |
|selectionMemberId|int|SR\_SELECTIONMEMBER\_ID: SR\_SELECTIONMEMBER\_ID\_TOOLTIP|  |
|rowKind| *None* |SR\_SELECTION\_ROWKIND: SR\_SELECTION\_ROWKIND\_TOOLTIP|  |
|targetTableNumber|int|TargetTableNumber: TargetTableNumber| x |
|targetRecordId|int|TargetRecordId: TargetRecordId| x |
|contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|alternative/quoteAlternativeId|int|SR\_QUOTE\_QUOTEALTERNATIVE\_ID: SR\_QUOTE\_QUOTEALTERNATIVE\_ID\_TOOLTIP| x |
|alternative/quoteVersionId|int|SR\_QUOTE\_QUOTEVERSION\_ID: SR\_QUOTE\_QUOTEVERSION\_ID\_TOOLTIP| x |
|alternative/name|string|SR\_QUOTE\_QUOTEALTERNATIVE\_NAME: SR\_QUOTE\_QUOTEALTERNATIVE\_NAME\_TOOLTIP| x |
|alternative/description|string|SR\_QUOTE\_QUOTEALTERNATIVE\_DESCRIPTION: SR\_QUOTE\_QUOTEALTERNATIVE\_DESCRIPTION\_TOOLTIP| x |
|alternative/status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP| x |
|alternative/reason|string|SR\_QUOTE\_QUOTELINE\_QUOTEREASON: SR\_QUOTE\_QUOTELINE\_QUOTEREASON\_TOOLTIP| x |
|alternative/erpDiscountPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTPERCENT\_TOOLTIP| x |
|alternative/erpDiscountAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTAMOUNT\_TOOLTIP| x |
|alternative/discountPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTPERCENT\_TOOLTIP| x |
|alternative/discountAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTAMOUNT\_TOOLTIP| x |
|alternative/vatInfo|string|SR\_QUOTE\_QUOTEALTERNATIVE\_VATINFO: SR\_QUOTE\_QUOTEALTERNATIVE\_VATINFO\_TOOLTIP| x |
|alternative/vat|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_VAT: SR\_QUOTE\_QUOTEALTERNATIVE\_VAT\_TOOLTIP| x |
|alternative/earningPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSPERCENT\_TOOLTIP| x |
|alternative/earningAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSAMOUNT\_TOOLTIP| x |
|alternative/totalPrice|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_TOTAL: SR\_QUOTE\_QUOTEALTERNATIVE\_TOTAL\_TOOLTIP| x |
|alternative/extraField1|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD1: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD1\_TOOLTIP| x |
|alternative/extraField2|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD2: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD2\_TOOLTIP| x |
|alternative/extraField3|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD3: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD3\_TOOLTIP| x |
|alternative/extraField4|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD4: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD4\_TOOLTIP| x |
|alternative/extraField5|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD5: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD5\_TOOLTIP| x |
|alternative/alternativeOrdering|int|SR\_QUOTE\_QUOTEALTERNATIVE\_ID: SR\_QUOTE\_QUOTEALTERNATIVE\_ID\_TOOLTIP| x |
|alternative/subTotal|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_SUBTOTAL: SR\_QUOTE\_QUOTEALTERNATIVE\_SUBTOTAL\_TOOLTIP| x |
|alternative/totalPriceIncVAT|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ALTTOTINCVAT: SR\_QUOTE\_QUOTEALTERNATIVE\_ALTTOTINCVAT\_TOOLTIP| x |
|alternative/vatAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ALTVATAMT: SR\_QUOTE\_QUOTEALTERNATIVE\_ALTVATAMT\_TOOLTIP| x |
|alternative/version/quoteVersionId|int|SR\_QUOTE\_QUOTEVERSION\_ID: SR\_QUOTE\_QUOTEVERSION\_ID\_TOOLTIP| x |
|alternative/version/description|string|SR\_QUOTE\_QUOTEVERSION\_DESCRIPTION: SR\_QUOTE\_QUOTEVERSION\_DESCRIPTION\_TOOLTIP| x |
|alternative/version/number|string|SR\_QUOTE\_QUOTEVERSION\_NUMBER: SR\_QUOTE\_QUOTEVERSION\_NUMBER\_TOOLTIP| x |
|alternative/version/sent|date|SR\_QUOTE\_QUOTEVERSION\_SENT: SR\_QUOTE\_QUOTEVERSION\_SENT\_TOOLTIP| x |
|alternative/version/expiration|date|SR\_QUOTE\_QUOTEVERSION\_EXPIRATION: SR\_QUOTE\_QUOTEVERSION\_EXPIRATION\_TOOLTIP| x |
|alternative/version/state|listAny|SR\_QUOTE\_QUOTEVERSION\_STATE: SR\_QUOTE\_QUOTEVERSION\_STATE\_TOOLTIP| x |
|alternative/version/status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP| x |
|alternative/version/reason|string|SR\_QUOTE\_QUOTELINE\_QUOTEREASON: SR\_QUOTE\_QUOTELINE\_QUOTEREASON\_TOOLTIP| x |
|alternative/version/paymentTerms|listExternal|SR\_QUOTE\_QUOTEVERSION\_PAYMENTTERMS: SR\_QUOTE\_QUOTEVERSION\_PAYMENTTERMS\_TOOLTIP|  |
|alternative/version/paymentType|listExternal|SR\_QUOTE\_QUOTEVERSION\_PAYMENTTYPE: SR\_QUOTE\_QUOTEVERSION\_PAYMENTTYPE\_TOOLTIP|  |
|alternative/version/deliveryTerms|listExternal|SR\_QUOTE\_QUOTEVERSION\_DELIVERYTERMS: SR\_QUOTE\_QUOTEVERSION\_DELIVERYTERMS\_TOOLTIP|  |
|alternative/version/deliveryType|listExternal|SR\_QUOTE\_QUOTEVERSION\_DELIVERYTYPE: SR\_QUOTE\_QUOTEVERSION\_DELIVERYTYPE\_TOOLTIP|  |
|alternative/version/approvedBy|associate|SR\_QUOTE\_QUOTEVERSION\_APPROVEDBY: SR\_QUOTE\_QUOTEVERSION\_APPROVEDBY\_TOOLTIP| x |
|alternative/version/approvalRegisteredBy|associate|SR\_QUOTE\_QUOTEVERSION\_APPROVALREGISTEREDBY: SR\_QUOTE\_QUOTEVERSION\_APPROVALREGISTEREDBY\_TOOLTIP| x |
|alternative/version/approvedText|string|SR\_QUOTE\_QUOTEVERSION\_APPROVEDTEXT: SR\_QUOTE\_QUOTEVERSION\_APPROVEDTEXT\_TOOLTIP| x |
|alternative/version/approvedDate|date|SR\_QUOTE\_QUOTEVERSION\_APPROVEDDATE: SR\_QUOTE\_QUOTEVERSION\_APPROVEDDATE\_TOOLTIP| x |
|alternative/version/extraField1|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD1: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD1\_TOOLTIP| x |
|alternative/version/extraField2|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD2: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD2\_TOOLTIP| x |
|alternative/version/extraField3|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD3: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD3\_TOOLTIP| x |
|alternative/version/extraField4|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD4: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD4\_TOOLTIP| x |
|alternative/version/extraField5|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD5: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD5\_TOOLTIP| x |
|alternative/version/quote/quoteId|int|SR\_QUOTE\_QUOTE\_ID: SR\_QUOTE\_QUOTE\_ID\_TOOLTIP| x |
|alternative/version/quote/poNumber|string|SR\_QUOTE\_QUOTE\_PONUMBER: SR\_QUOTE\_QUOTE\_PONUMBER\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/orderComment|string|SR\_QUOTE\_QUOTE\_ORDERCOMMENT: SR\_QUOTE\_QUOTE\_ORDERCOMMENT\_TOOLTIP| x |
|alternative/version/quote/connectionId|int|SR\_QUOTE\_CONNECTIONID: SR\_QUOTE\_CONNECTIONID\_TOOLTIP| x |
|alternative/version/quote/registeredDate|date|SR\_QUOTE\_QUOTE\_REGISTERED: SR\_QUOTE\_QUOTE\_REGISTERED\_TOOLTIP| x |
|alternative/version/quote/sale/completed|bool|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|alternative/version/quote/sale/icon|listAny|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|alternative/version/quote/sale/date|date|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|alternative/version/quote/sale/time| *None* |SR\_SINGULAR\_SALE - SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|alternative/version/quote/sale/type|listAny|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|alternative/version/quote/sale/recordType|string|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|alternative/version/quote/sale/text|positiveString|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|alternative/version/quote/sale/associateId|associate|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|alternative/version/quote/sale/contactId|listAny|SR\_SINGULAR\_SALE - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/personId|listAny|SR\_SINGULAR\_SALE - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/projectId|listAny|SR\_SINGULAR\_SALE - SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/saleId|int|SR\_SINGULAR\_SALE - SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/userGroup|userGroup|SR\_SINGULAR\_SALE - SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|alternative/version/quote/sale/who| *None* |SR\_SINGULAR\_SALE - SR\_WHO: SR\_WHO\_TOOLTIP|  |
|alternative/version/quote/sale/updatedBy|associate|SR\_SINGULAR\_SALE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/updatedByFullName|associate|SR\_SINGULAR\_SALE - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/updatedDate|date|SR\_SINGULAR\_SALE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|alternative/version/quote/sale/registeredBy|associate|SR\_SINGULAR\_SALE - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/registeredByFullName|associate|SR\_SINGULAR\_SALE - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/registeredDate|date|SR\_SINGULAR\_SALE - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|alternative/version/quote/sale/currencyId|int|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/currency|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP| x |
|alternative/version/quote/sale/credited|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP| x |
|alternative/version/quote/sale/lossReason|listAny|SR\_SINGULAR\_SALE - SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP| x |
|alternative/version/quote/sale/source|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP| x |
|alternative/version/quote/sale/competitor|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP| x |
|alternative/version/quote/sale/heading|stringorPK|SR\_SINGULAR\_SALE - SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/amount|decimal|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|alternative/version/quote/sale/amountWeighted|decimal|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|alternative/version/quote/sale/earning|decimal|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP| x |
|alternative/version/quote/sale/earningPercent|decimal|SR\_SINGULAR\_SALE - SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP| x |
|alternative/version/quote/sale/probPercent|int|SR\_SINGULAR\_SALE - SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP| x |
|alternative/version/quote/sale/originalStage|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED| x |
|alternative/version/quote/sale/stage|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|alternative/version/quote/sale/stageName| *None* |SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|alternative/version/quote/sale/saleStatus|listAny|SR\_SINGULAR\_SALE - SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP| x |
|alternative/version/quote/sale/stageRank| *None* |SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP| x |
|alternative/version/quote/sale/saleType|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|alternative/version/quote/sale/saleTypeId| *None* |SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|alternative/version/quote/sale/stageId| *None* |SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|alternative/version/quote/sale/nextDueDate|date|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP| x |
|alternative/version/quote/sale/reopenDate|date|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP| x |
|alternative/version/quote/sale/stalledComment|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP| x |
|alternative/version/quote/sale/saleTypeCategory|listAny|SR\_SINGULAR\_SALE - SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT| x |
|alternative/version/quote/sale/soldReason|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP| x |
|alternative/version/quote/sale/saleNumber|string|SR\_SINGULAR\_SALE - SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER| x |
|alternative/version/quote/sale/hasStakeholders|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP| x |
|alternative/version/quote/sale/stakeholdersEnabled|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP| x |
|alternative/version/quote/sale/hasQuote|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP| x |
|alternative/version/quote/sale/hasGuide|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|alternative/version/quote/sale/description|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |
|alternative/version/quote/sale/activeErpLinks|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|alternative/version/quote/sale/createdByWorkflow|listAny|SR\_SINGULAR\_SALE - SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|alternative/version/quote/sale/amountInBaseCurrency| *None* |SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|alternative/version/quote/sale/amountWeightedInBaseCurrency| *None* |SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|alternative/version/quote/sale/daysInStage|int|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP| x |
|alternative/version/quote/sale/visibleFor|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_VISIBLE\_FOR|  |
|alternative/version/quote/sale/sale/textId|int|SR\_SINGULAR\_SALE - Text ID| x |
|alternative/version/quote/sale/sale/description|positiveString|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|alternative/version/quote/sale/person/personId|int|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|alternative/version/quote/sale/person/firstName|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/lastName|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/middleName|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/fullName|string|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|alternative/version/quote/sale/person/contactId|int|SR\_SINGULAR\_SALE - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/person/hasInfoText|bool|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|alternative/version/quote/sale/person/hasInterests|bool|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|alternative/version/quote/sale/person/personHasInterests|bool|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|alternative/version/quote/sale/person/mrMrs|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|alternative/version/quote/sale/person/position|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_POSITION| x |
|alternative/version/quote/sale/person/personNumber|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|alternative/version/quote/sale/person/title|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|alternative/version/quote/sale/person/personCountry|listAny|SR\_SINGULAR\_SALE - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|alternative/version/quote/sale/person/personCountryId|int|SR\_SINGULAR\_SALE - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|alternative/version/quote/sale/person/personNoMail|bool|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|alternative/version/quote/sale/person/rank|int|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|alternative/version/quote/sale/person/birthdate| *None* |SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|alternative/version/quote/sale/person/associateType| *None* |SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|alternative/version/quote/sale/person/useAsMailingAddress|bool|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|alternative/version/quote/sale/person/personSource|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|alternative/version/quote/sale/person/retired|bool|SR\_SINGULAR\_SALE - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|alternative/version/quote/sale/person/birthYear|int|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|alternative/version/quote/sale/person/birthMonth|int|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|alternative/version/quote/sale/person/birthDay|int|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|alternative/version/quote/sale/person/kanaFirstName|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|alternative/version/quote/sale/person/kanaLastName|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|alternative/version/quote/sale/person/personUpdatedBy|associate|SR\_SINGULAR\_SALE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/person/personUpdatedByFullName|associate|SR\_SINGULAR\_SALE - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/person/personUpdatedDate|date|SR\_SINGULAR\_SALE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|alternative/version/quote/sale/person/personRegisteredBy|associate|SR\_SINGULAR\_SALE - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/person/personRegisteredByFullName|associate|SR\_SINGULAR\_SALE - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/person/personRegisteredDate|date|SR\_SINGULAR\_SALE - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|alternative/version/quote/sale/person/portraitThumbnail| *None* |SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|alternative/version/quote/sale/person/personActiveErpLinks|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|alternative/version/quote/sale/person/ticketPriority|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|alternative/version/quote/sale/person/supportLanguage|listAny|SR\_SINGULAR\_SALE - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|alternative/version/quote/sale/person/supportAssociate|associate|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/sale/person/supportAssociateFullName|associate|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociateId|associate|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociateFullName|associate|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|alternative/version/quote/sale/person/personCategory|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_CATEGORY| x |
|alternative/version/quote/sale/person/personCategoryGroup|listAny|SR\_SINGULAR\_SALE - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|alternative/version/quote/sale/person/personCategoryRank|int|SR\_SINGULAR\_SALE - !!Category rank| x |
|alternative/version/quote/sale/person/personBusiness|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_BUSINESS| x |
|alternative/version/quote/sale/person/leadStatus|listAny|SR\_SINGULAR\_SALE - SR\_LABEL\_LEADSTATUS| x |
|alternative/version/quote/sale/person/leadstatusRank|int|SR\_SINGULAR\_SALE - !!Lead status RANK| x |
|alternative/version/quote/sale/person/personDeletedDate|datetime|SR\_SINGULAR\_SALE - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|alternative/version/quote/sale/person/hasCompany|bool|SR\_SINGULAR\_SALE - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|alternative/version/quote/sale/person/isProjectMember|bool|SR\_SINGULAR\_SALE - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|alternative/version/quote/sale/person/isStakeholder|bool|SR\_SINGULAR\_SALE - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|alternative/version/quote/sale/person/updatedByWorkflow|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|alternative/version/quote/sale/person/whenUpdatedByWorkflow|datetime|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|alternative/version/quote/sale/person/createdByForm|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|alternative/version/quote/sale/person/phone/formattedNumber|string|SR\_SINGULAR\_SALE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|alternative/version/quote/sale/person/personDirectPhone/formattedNumber|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|alternative/version/quote/sale/person/personDirectPhone/description|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|alternative/version/quote/sale/person/personMobilePhone/formattedNumber|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|alternative/version/quote/sale/person/personMobilePhone/description|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|alternative/version/quote/sale/person/personPrivate/formattedNumber|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|alternative/version/quote/sale/person/personPrivate/description|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|alternative/version/quote/sale/person/personPager/formattedNumber|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|alternative/version/quote/sale/person/personPager/description|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|alternative/version/quote/sale/person/personDirectFax/formattedNumber|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|alternative/version/quote/sale/person/personDirectFax/description|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|alternative/version/quote/sale/person/searchPhone/formattedNumber|string|SR\_SINGULAR\_SALE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|alternative/version/quote/sale/person/searchPhone/description|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|alternative/version/quote/sale/person/personInfo/textId|int|SR\_SINGULAR\_SALE - Text ID| x |
|alternative/version/quote/sale/person/personInfo/infoText|positiveString|SR\_SINGULAR\_SALE - SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|alternative/version/quote/sale/person/email/emailProtocol|string|SR\_SINGULAR\_SALE - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|alternative/version/quote/sale/person/email/emailAddress|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_EMAIL| x |
|alternative/version/quote/sale/person/email/emailDescription|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_DESCRIPTION| x |
|alternative/version/quote/sale/person/email/emailId|int|SR\_SINGULAR\_SALE - ID| x |
|alternative/version/quote/sale/person/email/emailLastSent|datetime|SR\_SINGULAR\_SALE - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|alternative/version/quote/sale/person/email/emailBounceCount|int|SR\_SINGULAR\_SALE - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|alternative/version/quote/sale/person/email/emailLastBounce|datetime|SR\_SINGULAR\_SALE - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|alternative/version/quote/sale/person/email/emailHasBounced|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|alternative/version/quote/sale/person/personUrl/URLAddress|string|SR\_SINGULAR\_SALE - SR\_PROJECTARCHIVE\_URL| x |
|alternative/version/quote/sale/person/personUrl/URLDescription|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_DESCRIPTION| x |
|alternative/version/quote/sale/person/personAddress/addressId|int|SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAddress/line1|string|SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAddress/line2|string|SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAddress/line3|string|SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAddress/county|string|SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAddress/city|string|SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAddress/zip|string|SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAddress/state|string|SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAddress/wgs84latitude|decimal|SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|alternative/version/quote/sale/person/personAddress/wgs84longitude|decimal|SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|alternative/version/quote/sale/person/personAddress/formattedAddress| *None* |SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/personAddress/formattedMultiLineAddress| *None* |SR\_SINGULAR\_SALE - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/restrictionAddress/addressId|int|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/person/restrictionAddress/line1|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|alternative/version/quote/sale/person/restrictionAddress/line2|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|alternative/version/quote/sale/person/restrictionAddress/line3|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|alternative/version/quote/sale/person/restrictionAddress/county|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|alternative/version/quote/sale/person/restrictionAddress/city|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|alternative/version/quote/sale/person/restrictionAddress/zip|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|alternative/version/quote/sale/person/restrictionAddress/state|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|alternative/version/quote/sale/person/restrictionAddress/wgs84latitude|decimal|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|alternative/version/quote/sale/person/restrictionAddress/wgs84longitude|decimal|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|alternative/version/quote/sale/person/restrictionAddress/formattedAddress| *None* |SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/restrictionAddress/formattedMultiLineAddress| *None* |SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/person/personInterestIds|listInterest|SR\_SINGULAR\_SALE - SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|alternative/version/quote/sale/person/personUdef/SuperOffice:1|string|SR\_SINGULAR\_SALE - contactshorttext: tooltipshorttext| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:2|string|SR\_SINGULAR\_SALE - contactlongtext: tooltiplongtext| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:3|int|SR\_SINGULAR\_SALE - contactnumber| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:4|date|SR\_SINGULAR\_SALE - contactdate| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:5|unlimitedDate|SR\_SINGULAR\_SALE - contactunlimiteddate: tooltipunlimiteddate| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:6|bool|SR\_SINGULAR\_SALE - contactcheckbox| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:7|listAny|SR\_SINGULAR\_SALE - contactdropdownlistbox| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:8|decimal|SR\_SINGULAR\_SALE - contactdecimal| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:9|string|SR\_SINGULAR\_SALE - page1saleonly| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:10|string|SR\_SINGULAR\_SALE - page1marketingonly| x |
|alternative/version/quote/sale/person/personUdef/SuperOffice:11|string|SR\_SINGULAR\_SALE - page1adminonly| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_integer|int|SR\_SINGULAR\_SALE - Extra Integer: Custom person integer| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_hidden\_integer|int|SR\_SINGULAR\_SALE - Extra hidden integer: Custom integer field that is hidden| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_float|decimal|SR\_SINGULAR\_SALE - Extra float: Custom float field| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_longtext|string|SR\_SINGULAR\_SALE - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_date|date|SR\_SINGULAR\_SALE - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_datetime|datetime|SR\_SINGULAR\_SALE - Extra DateTime: Custom person date and time field. No default| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_time| *None* |SR\_SINGULAR\_SALE - Extra time: Custom time field on person. Current time as default| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_boolean|bool|SR\_SINGULAR\_SALE - Extra Boolean: Custom boolean field on person. Default checked| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_timespan|timeSpan|SR\_SINGULAR\_SALE - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_shorttext|string|SR\_SINGULAR\_SALE - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_shorttext\_list|listAny|SR\_SINGULAR\_SALE - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_user\_relation|associate|SR\_SINGULAR\_SALE - Extra user relation: Custom person-user relation field| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_category\_relation|listAny|SR\_SINGULAR\_SALE - Extra category relation: Custom person-category relation| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_priority\_relation|listAny|SR\_SINGULAR\_SALE - Extra priority relation: Custom person-priority relation| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_request\_relation|stringorPK|SR\_SINGULAR\_SALE - Extra request relation: Request relation on contact| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_appointment\_relation|stringorPK|SR\_SINGULAR\_SALE - Extra appointment relation: Appointment relation on person| x |
|alternative/version/quote/sale/person/personExtra/x\_person\_contact\_relation|stringorPK|SR\_SINGULAR\_SALE - Extra company relation: Company relation on contact| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/id|int|SR\_SINGULAR\_SALE - Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/x\_start|date|SR\_SINGULAR\_SALE - Rental - Start rental: Start rental| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/x\_end|date|SR\_SINGULAR\_SALE - Rental - End: End| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/x\_amount|int|SR\_SINGULAR\_SALE - Rental - Amount: Number to rent. Default = 1| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/x\_contact|stringorPK|SR\_SINGULAR\_SALE - Rental - Renter: Company that rents equipment| x |
|alternative/version/quote/sale/person/personExtra/y\_rental/y\_equipment/x\_name|string|SR\_SINGULAR\_SALE - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/sale/person/personExtra/y\_car/id|int|SR\_SINGULAR\_SALE - Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|alternative/version/quote/sale/person/personAssociate/firstName|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/lastName|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/middleName|string|SR\_SINGULAR\_SALE - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/fullName|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/contactId|int|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|alternative/version/quote/sale/person/personAssociate/personId|int|SR\_SINGULAR\_SALE - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|alternative/version/quote/sale/person/personAssociate/mrMrs|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/title|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/associateDbId|associate|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|alternative/version/quote/sale/person/personAssociate/contactName|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/contactDepartment|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/usergroup|userGroup|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/usergroupId|int|SR\_SINGULAR\_SALE - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/contactFullName|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/contactCategory|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|alternative/version/quote/sale/person/personAssociate/role|listAny|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|alternative/version/quote/sale/person/personAssociate/assocName|associate|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|alternative/version/quote/sale/person/personAssociate/assocTooltip|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|alternative/version/quote/sale/person/personAssociate/assocType|listAny|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/ejUserId|int|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|alternative/version/quote/sale/person/personAssociate/simultaneousEjUser|bool|SR\_SINGULAR\_SALE - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|alternative/version/quote/sale/person/personAssociate/ejDisplayName|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|alternative/version/quote/sale/person/personAssociate/ejStatus|int|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|alternative/version/quote/sale/person/personAssociate/credentialType| *None* |SR\_SINGULAR\_SALE - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/credentialDisplayValue| *None* |SR\_SINGULAR\_SALE - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/isActive|bool|SR\_SINGULAR\_SALE - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/isActiveText|bool|SR\_SINGULAR\_SALE - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/portraitThumbnail| *None* |SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|alternative/version/quote/sale/person/personAssociate/otherGroups|userGroup|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|alternative/version/quote/sale/person/personAssociate/userName|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/personAssociate/personEmail|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_EMAIL| x |
|alternative/version/quote/sale/person/personAssociate/locationAddress|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|alternative/version/quote/sale/person/personAssociate/isLocation|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|alternative/version/quote/sale/person/correspondingAssociate/firstName|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/lastName|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/middleName|string|SR\_SINGULAR\_SALE - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/fullName|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/contactId|int|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|alternative/version/quote/sale/person/correspondingAssociate/personId|int|SR\_SINGULAR\_SALE - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|alternative/version/quote/sale/person/correspondingAssociate/mrMrs|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/title|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/associateDbId|associate|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|alternative/version/quote/sale/person/correspondingAssociate/contactName|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/contactDepartment|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/usergroup|userGroup|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/usergroupId|int|SR\_SINGULAR\_SALE - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/contactFullName|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/contactCategory|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|alternative/version/quote/sale/person/correspondingAssociate/role|listAny|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|alternative/version/quote/sale/person/correspondingAssociate/assocName|associate|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|alternative/version/quote/sale/person/correspondingAssociate/assocTooltip|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|alternative/version/quote/sale/person/correspondingAssociate/assocType|listAny|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/ejUserId|int|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|alternative/version/quote/sale/person/correspondingAssociate/simultaneousEjUser|bool|SR\_SINGULAR\_SALE - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|alternative/version/quote/sale/person/correspondingAssociate/ejDisplayName|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|alternative/version/quote/sale/person/correspondingAssociate/ejStatus|int|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|alternative/version/quote/sale/person/correspondingAssociate/credentialType| *None* |SR\_SINGULAR\_SALE - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/credentialDisplayValue| *None* |SR\_SINGULAR\_SALE - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/isActive|bool|SR\_SINGULAR\_SALE - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/isActiveText|bool|SR\_SINGULAR\_SALE - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/portraitThumbnail| *None* |SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|alternative/version/quote/sale/person/correspondingAssociate/otherGroups|userGroup|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|alternative/version/quote/sale/person/correspondingAssociate/userName|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/person/correspondingAssociate/personEmail|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_EMAIL| x |
|alternative/version/quote/sale/person/correspondingAssociate/locationAddress|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|alternative/version/quote/sale/person/correspondingAssociate/isLocation|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|alternative/version/quote/sale/person/isMailingRecipient|bool|SR\_SINGULAR\_SALE - SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient| x |
|alternative/version/quote/sale/person/hasStoreConsent|bool|SR\_SINGULAR\_SALE - SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|alternative/version/quote/sale/person/withdrawnStoreConsent|bool|SR\_SINGULAR\_SALE - SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|alternative/version/quote/sale/person/hasEmarketingConsent|bool|SR\_SINGULAR\_SALE - SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|alternative/version/quote/sale/person/withdrawnEmarketingConsent|bool|SR\_SINGULAR\_SALE - SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|alternative/version/quote/sale/person/subscription|listAny|SR\_SINGULAR\_SALE - SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP| x |
|alternative/version/quote/sale/person/legalBaseStore|listAny|SR\_SINGULAR\_SALE - SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|alternative/version/quote/sale/person/legalBaseEmarketing|listAny|SR\_SINGULAR\_SALE - SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|alternative/version/quote/sale/person/consentSourceStore|listAny|SR\_SINGULAR\_SALE - SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|alternative/version/quote/sale/person/consentSourceEmarketing|listAny|SR\_SINGULAR\_SALE - SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|alternative/version/quote/sale/contact/contactId|int|SR\_SINGULAR\_SALE - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/contact/name|stringorPK|SR\_SINGULAR\_SALE - SR\_COMPANY\_NAME| x |
|alternative/version/quote/sale/contact/department|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_DEPARTEMENT| x |
|alternative/version/quote/sale/contact/nameDepartment|string|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|alternative/version/quote/sale/contact/hasInfoText|bool|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|alternative/version/quote/sale/contact/hasInterests|bool|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|alternative/version/quote/sale/contact/associateId|associate|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|alternative/version/quote/sale/contact/category|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_CATEGORY| x |
|alternative/version/quote/sale/contact/categoryGroup|listAny|SR\_SINGULAR\_SALE - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|alternative/version/quote/sale/contact/companyCategoryRank|int|SR\_SINGULAR\_SALE - Category rank| x |
|alternative/version/quote/sale/contact/business|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_BUSINESS| x |
|alternative/version/quote/sale/contact/country|listAny|SR\_SINGULAR\_SALE - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|alternative/version/quote/sale/contact/countryId|int|SR\_SINGULAR\_SALE - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|alternative/version/quote/sale/contact/number|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_NUMBER| x |
|alternative/version/quote/sale/contact/code|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_CODE| x |
|alternative/version/quote/sale/contact/orgnr|string|SR\_SINGULAR\_SALE - VAT No.| x |
|alternative/version/quote/sale/contact/stop|bool|SR\_SINGULAR\_SALE - SR\_CC\_STOPX| x |
|alternative/version/quote/sale/contact/contactNoMail|bool|SR\_SINGULAR\_SALE - SR\_NO\_MAIL\_COMPANY| x |
|alternative/version/quote/sale/contact/updatedBy|associate|SR\_SINGULAR\_SALE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/contact/updatedByFullName|associate|SR\_SINGULAR\_SALE - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/contact/updatedDate|date|SR\_SINGULAR\_SALE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|alternative/version/quote/sale/contact/registeredBy|associate|SR\_SINGULAR\_SALE - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/contact/registeredByFullName|associate|SR\_SINGULAR\_SALE - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/sale/contact/registeredDate|date|SR\_SINGULAR\_SALE - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactSource|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|alternative/version/quote/sale/contact/contactDeleted|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|alternative/version/quote/sale/contact/phone/formattedNumber|string|SR\_SINGULAR\_SALE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|alternative/version/quote/sale/contact/activeErpLinks|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|alternative/version/quote/sale/contact/deletedDate|datetime|SR\_SINGULAR\_SALE - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|alternative/version/quote/sale/contact/mainContact| *None* |SR\_SINGULAR\_SALE - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|alternative/version/quote/sale/contact/forceCompany|bool|SR\_SINGULAR\_SALE - Dummy: Dummy|  |
|alternative/version/quote/sale/contact/contactPhone/formattedNumber|string|SR\_SINGULAR\_SALE - SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|alternative/version/quote/sale/contact/contactPhone/description|string|SR\_SINGULAR\_SALE - SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactFax/formattedNumber|string|SR\_SINGULAR\_SALE - SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|alternative/version/quote/sale/contact/contactFax/description|string|SR\_SINGULAR\_SALE - SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|alternative/version/quote/sale/contact/searchPhone/formattedNumber|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|alternative/version/quote/sale/contact/searchPhone/description|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|alternative/version/quote/sale/contact/email/emailProtocol|string|SR\_SINGULAR\_SALE - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|alternative/version/quote/sale/contact/email/emailAddress|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_EMAIL| x |
|alternative/version/quote/sale/contact/email/emailDescription|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_DESCRIPTION| x |
|alternative/version/quote/sale/contact/email/emailId|int|SR\_SINGULAR\_SALE - ID| x |
|alternative/version/quote/sale/contact/email/emailLastSent|datetime|SR\_SINGULAR\_SALE - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|alternative/version/quote/sale/contact/email/emailBounceCount|int|SR\_SINGULAR\_SALE - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|alternative/version/quote/sale/contact/email/emailLastBounce|datetime|SR\_SINGULAR\_SALE - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|alternative/version/quote/sale/contact/email/emailHasBounced|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|alternative/version/quote/sale/contact/postAddress/addressId|int|SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/contact/postAddress/line1|string|SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|alternative/version/quote/sale/contact/postAddress/line2|string|SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|alternative/version/quote/sale/contact/postAddress/line3|string|SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|alternative/version/quote/sale/contact/postAddress/county|string|SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|alternative/version/quote/sale/contact/postAddress/city|string|SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|alternative/version/quote/sale/contact/postAddress/zip|string|SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|alternative/version/quote/sale/contact/postAddress/state|string|SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|alternative/version/quote/sale/contact/postAddress/wgs84latitude|decimal|SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|alternative/version/quote/sale/contact/postAddress/wgs84longitude|decimal|SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|alternative/version/quote/sale/contact/postAddress/formattedAddress| *None* |SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/postAddress/formattedMultiLineAddress| *None* |SR\_SINGULAR\_SALE - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/streetAddress/addressId|int|SR\_SINGULAR\_SALE - SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/contact/streetAddress/line1|string|SR\_SINGULAR\_SALE - SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|alternative/version/quote/sale/contact/streetAddress/line2|string|SR\_SINGULAR\_SALE - SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|alternative/version/quote/sale/contact/streetAddress/line3|string|SR\_SINGULAR\_SALE - SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|alternative/version/quote/sale/contact/streetAddress/county|string|SR\_SINGULAR\_SALE - SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|alternative/version/quote/sale/contact/streetAddress/city|string|SR\_SINGULAR\_SALE - SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|alternative/version/quote/sale/contact/streetAddress/zip|string|SR\_SINGULAR\_SALE - SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|alternative/version/quote/sale/contact/streetAddress/state|string|SR\_SINGULAR\_SALE - SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|alternative/version/quote/sale/contact/streetAddress/wgs84latitude|decimal|SR\_SINGULAR\_SALE - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|alternative/version/quote/sale/contact/streetAddress/wgs84longitude|decimal|SR\_SINGULAR\_SALE - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|alternative/version/quote/sale/contact/streetAddress/formattedAddress| *None* |SR\_SINGULAR\_SALE - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/streetAddress/formattedMultiLineAddress| *None* |SR\_SINGULAR\_SALE - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/restrictionAddress/addressId|int|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|alternative/version/quote/sale/contact/restrictionAddress/line1|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|alternative/version/quote/sale/contact/restrictionAddress/line2|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|alternative/version/quote/sale/contact/restrictionAddress/line3|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|alternative/version/quote/sale/contact/restrictionAddress/county|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|alternative/version/quote/sale/contact/restrictionAddress/city|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|alternative/version/quote/sale/contact/restrictionAddress/zip|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|alternative/version/quote/sale/contact/restrictionAddress/state|string|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|alternative/version/quote/sale/contact/restrictionAddress/wgs84latitude|decimal|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|alternative/version/quote/sale/contact/restrictionAddress/wgs84longitude|decimal|SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|alternative/version/quote/sale/contact/restrictionAddress/formattedAddress| *None* |SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/restrictionAddress/formattedMultiLineAddress| *None* |SR\_SINGULAR\_SALE - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|alternative/version/quote/sale/contact/url/URLAddress|string|SR\_SINGULAR\_SALE - SR\_PROJECTARCHIVE\_URL| x |
|alternative/version/quote/sale/contact/url/URLDescription|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_DESCRIPTION| x |
|alternative/version/quote/sale/contact/contactAssociate/firstName|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/lastName|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/middleName|string|SR\_SINGULAR\_SALE - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/fullName|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/contactId|int|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|alternative/version/quote/sale/contact/contactAssociate/personId|int|SR\_SINGULAR\_SALE - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|alternative/version/quote/sale/contact/contactAssociate/mrMrs|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/title|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/associateDbId|associate|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|alternative/version/quote/sale/contact/contactAssociate/contactName|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/contactDepartment|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/usergroup|userGroup|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/usergroupId|int|SR\_SINGULAR\_SALE - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/contactFullName|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/contactCategory|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|alternative/version/quote/sale/contact/contactAssociate/role|listAny|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|alternative/version/quote/sale/contact/contactAssociate/assocName|associate|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|alternative/version/quote/sale/contact/contactAssociate/assocTooltip|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|alternative/version/quote/sale/contact/contactAssociate/assocType|listAny|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/ejUserId|int|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|alternative/version/quote/sale/contact/contactAssociate/simultaneousEjUser|bool|SR\_SINGULAR\_SALE - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|alternative/version/quote/sale/contact/contactAssociate/ejDisplayName|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|alternative/version/quote/sale/contact/contactAssociate/ejStatus|int|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|alternative/version/quote/sale/contact/contactAssociate/credentialType| *None* |SR\_SINGULAR\_SALE - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/credentialDisplayValue| *None* |SR\_SINGULAR\_SALE - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/isActive|bool|SR\_SINGULAR\_SALE - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/isActiveText|bool|SR\_SINGULAR\_SALE - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/portraitThumbnail| *None* |SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|alternative/version/quote/sale/contact/contactAssociate/otherGroups|userGroup|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|alternative/version/quote/sale/contact/contactAssociate/userName|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/contact/contactAssociate/personEmail|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_EMAIL| x |
|alternative/version/quote/sale/contact/contactAssociate/locationAddress|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|alternative/version/quote/sale/contact/contactAssociate/isLocation|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|alternative/version/quote/sale/contact/contactInterestIds|listInterest|SR\_SINGULAR\_SALE - SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:1|string|SR\_SINGULAR\_SALE - companyshorttext: tooltipshorttext| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:2|string|SR\_SINGULAR\_SALE - companylongtext: tooltiplongtext| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:3|int|SR\_SINGULAR\_SALE - companynumber| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:4|date|SR\_SINGULAR\_SALE - companydate| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:5|unlimitedDate|SR\_SINGULAR\_SALE - companyunlimiteddate: tooltipunlimiteddate| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:6|bool|SR\_SINGULAR\_SALE - companycheckbox| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:7|listAny|SR\_SINGULAR\_SALE - companydropdownlistbox| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:8|decimal|SR\_SINGULAR\_SALE - companydecimal| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:9|string|SR\_SINGULAR\_SALE - page1saleonly| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:10|string|SR\_SINGULAR\_SALE - page1marketingonly| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:11|string|SR\_SINGULAR\_SALE - page1adminonly| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:12|listAny|SR\_SINGULAR\_SALE - Udlist one: Static tooltip for udlist one| x |
|alternative/version/quote/sale/contact/contactUdef/SuperOffice:13|listAny|SR\_SINGULAR\_SALE - Udlist two: Static tooltip for udlist two| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_integer|int|SR\_SINGULAR\_SALE - Extra Integer: Custom integer field| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_hidden\_integer|int|SR\_SINGULAR\_SALE - Extra hidden integer: Custom integer field - hidden| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_default\_integer|int|SR\_SINGULAR\_SALE - Extra Default Integer: Custom integer field with default value 123.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_float|decimal|SR\_SINGULAR\_SALE - Extra Float: Custom float field with 3 decimals| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_longtext|string|SR\_SINGULAR\_SALE - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_dropdown|listAny|SR\_SINGULAR\_SALE - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_date|date|SR\_SINGULAR\_SALE - Extra date: Custom date field. User current as default.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_datetime|datetime|SR\_SINGULAR\_SALE - Extra DateTime: Custom Date Time field. No default value. External| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_time| *None* |SR\_SINGULAR\_SALE - Extra time: Custom time field.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_boolean|bool|SR\_SINGULAR\_SALE - Extra boolean: Custom boolean field.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_timespan|timeSpan|SR\_SINGULAR\_SALE - Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_shorttext|string|SR\_SINGULAR\_SALE - Extra short text: Custom short text field. Keep HTML tags.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_short\_dropdown|listAny|SR\_SINGULAR\_SALE - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_contact\_relation|stringorPK|SR\_SINGULAR\_SALE - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_request\_relation|stringorPK|SR\_SINGULAR\_SALE - Extra Request relation: Request relation on company| x |
|alternative/version/quote/sale/contact/contactExtra/x\_contact\_contact|stringorPK|SR\_SINGULAR\_SALE - Extra contact relation: Contact relation on company| x |
|alternative/version/quote/sale/contact/contactExtra/y\_organization/x\_name|string|SR\_SINGULAR\_SALE - Organization - Name: Name| x |
|alternative/version/quote/sale/contact/NumberOfActivities|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|alternative/version/quote/sale/contact/NumberOfActivitiesInPeriod|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedActivities|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedActivitiesInPeriod|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|alternative/version/quote/sale/contact/LastActivity|date|SR\_SINGULAR\_SALE - SR\_ROU\_LAST\_ACTIVITY|  |
|alternative/version/quote/sale/contact/LastCompletedActivity|date|SR\_SINGULAR\_SALE - SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|alternative/version/quote/sale/contact/LastDoByActivity|date|SR\_SINGULAR\_SALE - SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|alternative/version/quote/sale/contact/NumberOfSales|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_SALES|  |
|alternative/version/quote/sale/contact/NumberOfSalesInPeriod|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedSales|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedSalesInPeriod|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|alternative/version/quote/sale/contact/LastSale|date|SR\_SINGULAR\_SALE - SR\_ROU\_LAST\_SALE|  |
|alternative/version/quote/sale/contact/LastCompletedSale|date|SR\_SINGULAR\_SALE - SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|alternative/version/quote/sale/contact/LastDoBySale|date|SR\_SINGULAR\_SALE - SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|alternative/version/quote/sale/contact/NumberOfTickets|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|alternative/version/quote/sale/contact/NumberOfTicketsInPeriod|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedTickets|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|alternative/version/quote/sale/contact/NumberOfNotCompletedTicketsInPeriod|int|SR\_SINGULAR\_SALE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|alternative/version/quote/sale/contact/LastTicket|date|SR\_SINGULAR\_SALE - SR\_ROU\_LAST\_TICKET|  |
|alternative/version/quote/sale/contact/LastCompletedTicket|date|SR\_SINGULAR\_SALE - SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|alternative/version/quote/sale/contact/LastDoByTicket|date|SR\_SINGULAR\_SALE - SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|alternative/version/quote/sale/contact/SaintStatus1|saintStatus|SR\_SINGULAR\_SALE - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|alternative/version/quote/sale/contact/SaintStatus2|saintStatus|SR\_SINGULAR\_SALE - C-company: Kundens navn starter med bokstaven C|  |
|alternative/version/quote/sale/contact/saintSaleStatus|listAny|SR\_SINGULAR\_SALE - SR\_WITH\_STATUS|  |
|alternative/version/quote/sale/contact/saintAmountClass|listAny|SR\_SINGULAR\_SALE - SR\_AMOUNT\_CLASS|  |
|alternative/version/quote/sale/contact/saintActivityType|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_SAINT\_TYPE|  |
|alternative/version/quote/sale/contact/saintDirection|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_DIRECTION|  |
|alternative/version/quote/sale/contact/saintIntention|listAny|SR\_SINGULAR\_SALE - SR\_ACTIVITY\_INTENTION|  |
|alternative/version/quote/sale/contact/saintTicketStatus|listAny|SR\_SINGULAR\_SALE - SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|alternative/version/quote/sale/contact/saintTicketCategory|listAny|SR\_SINGULAR\_SALE - SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|alternative/version/quote/sale/associate/firstName|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/associate/lastName|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/associate/middleName|string|SR\_SINGULAR\_SALE - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|alternative/version/quote/sale/associate/fullName|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|alternative/version/quote/sale/associate/contactId|int|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|alternative/version/quote/sale/associate/personId|int|SR\_SINGULAR\_SALE - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|alternative/version/quote/sale/associate/mrMrs|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|alternative/version/quote/sale/associate/title|string|SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|alternative/version/quote/sale/associate/associateDbId|associate|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|alternative/version/quote/sale/associate/contactName|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/associate/contactDepartment|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|alternative/version/quote/sale/associate/usergroup|userGroup|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|alternative/version/quote/sale/associate/usergroupId|int|SR\_SINGULAR\_SALE - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|alternative/version/quote/sale/associate/contactFullName|string|SR\_SINGULAR\_SALE - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|alternative/version/quote/sale/associate/contactCategory|listAny|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|alternative/version/quote/sale/associate/role|listAny|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|alternative/version/quote/sale/associate/assocName|associate|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|alternative/version/quote/sale/associate/assocTooltip|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|alternative/version/quote/sale/associate/assocType|listAny|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|alternative/version/quote/sale/associate/ejUserId|int|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|alternative/version/quote/sale/associate/simultaneousEjUser|bool|SR\_SINGULAR\_SALE - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|alternative/version/quote/sale/associate/ejDisplayName|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|alternative/version/quote/sale/associate/ejStatus|int|SR\_SINGULAR\_SALE - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|alternative/version/quote/sale/associate/credentialType| *None* |SR\_SINGULAR\_SALE - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|alternative/version/quote/sale/associate/credentialDisplayValue| *None* |SR\_SINGULAR\_SALE - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|alternative/version/quote/sale/associate/isActive|bool|SR\_SINGULAR\_SALE - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|alternative/version/quote/sale/associate/isActiveText|bool|SR\_SINGULAR\_SALE - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|alternative/version/quote/sale/associate/portraitThumbnail| *None* |SR\_SINGULAR\_SALE - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|alternative/version/quote/sale/associate/otherGroups|userGroup|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|alternative/version/quote/sale/associate/userName|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/associate/personEmail|string|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_EMAIL| x |
|alternative/version/quote/sale/associate/locationAddress|string|SR\_SINGULAR\_SALE - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|alternative/version/quote/sale/associate/isLocation|bool|SR\_SINGULAR\_SALE - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:1|string|SR\_SINGULAR\_SALE - saleshorttext| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:2|string|SR\_SINGULAR\_SALE - salelongtext| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:3|int|SR\_SINGULAR\_SALE - salenumber| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:4|date|SR\_SINGULAR\_SALE - saledate| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:5|unlimitedDate|SR\_SINGULAR\_SALE - saleunlimiteddate| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:6|bool|SR\_SINGULAR\_SALE - salecheckbox| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:7|listAny|SR\_SINGULAR\_SALE - saledropdownlistbox| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:8|decimal|SR\_SINGULAR\_SALE - saledecimal| x |
|alternative/version/quote/sale/project/completed|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectId|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP| x |
|alternative/version/quote/sale/project/name|stringorPK|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/project/number|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP| x |
|alternative/version/quote/sale/project/type|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/sale/project/status|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP| x |
|alternative/version/quote/sale/project/statusRank| *None* |SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP| x |
|alternative/version/quote/sale/project/associateId|associate|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|alternative/version/quote/sale/project/hasInfoText|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP| x |
|alternative/version/quote/sale/project/icon| *None* |SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|alternative/version/quote/sale/project/text|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|alternative/version/quote/sale/project/description|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION| x |
|alternative/version/quote/sale/project/updatedBy|associate|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/project/updatedByFullName|associate|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/project/updatedDate|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|alternative/version/quote/sale/project/registeredBy|associate|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/project/registeredByFullName|associate|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|alternative/version/quote/sale/project/registeredDate|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|alternative/version/quote/sale/project/hasGuide|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|alternative/version/quote/sale/project/nextMilestone|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP| x |
|alternative/version/quote/sale/project/endDate|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP| x |
|alternative/version/quote/sale/project/imageThumbnail| *None* |SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|alternative/version/quote/sale/project/activeErpLinks|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|alternative/version/quote/sale/project/eventId|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID| x |
|alternative/version/quote/sale/project/startDate|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectPublish/isPublished|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectPublish/publishedFrom|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectPublish/publishedTo|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectPublish/publishedBy| *None* |SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|alternative/version/quote/sale/project/projectEvent/isExternalEvent|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectEvent/eventDate|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectEvent/hasSignOn|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectEvent/hasSignOff|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectUrl/URLAddress|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PROJECTARCHIVE\_URL| x |
|alternative/version/quote/sale/project/projectUrl/URLDescription|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_DESCRIPTION| x |
|alternative/version/quote/sale/project/projectAssociate/firstName|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/lastName|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/middleName|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/fullName|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/contactId|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|alternative/version/quote/sale/project/projectAssociate/personId|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|alternative/version/quote/sale/project/projectAssociate/mrMrs|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/title|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/associateDbId|associate|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|alternative/version/quote/sale/project/projectAssociate/contactName|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/contactDepartment|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/usergroup|userGroup|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/usergroupId|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/contactFullName|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/contactCategory|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|alternative/version/quote/sale/project/projectAssociate/role|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|alternative/version/quote/sale/project/projectAssociate/assocName|associate|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|alternative/version/quote/sale/project/projectAssociate/assocTooltip|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|alternative/version/quote/sale/project/projectAssociate/assocType|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/ejUserId|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|alternative/version/quote/sale/project/projectAssociate/simultaneousEjUser|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|alternative/version/quote/sale/project/projectAssociate/ejDisplayName|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|alternative/version/quote/sale/project/projectAssociate/ejStatus|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|alternative/version/quote/sale/project/projectAssociate/credentialType| *None* |SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/credentialDisplayValue| *None* |SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/isActive|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/isActiveText|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/portraitThumbnail| *None* |SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|alternative/version/quote/sale/project/projectAssociate/otherGroups|userGroup|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|alternative/version/quote/sale/project/projectAssociate/userName|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|alternative/version/quote/sale/project/projectAssociate/personEmail|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_EMAIL| x |
|alternative/version/quote/sale/project/projectAssociate/locationAddress|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|alternative/version/quote/sale/project/projectAssociate/isLocation|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:1|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - projectshorttext| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:2|string|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - projectlongtext| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:3|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - projectnumber| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:4|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - projectdate| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:5|unlimitedDate|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - projectunlimiteddate| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:6|bool|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - projectcheckbox| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:7|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - projectdropdownlistbox| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:8|decimal|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - projectdecimal| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:9|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - page1saleandmarketing| x |
|alternative/version/quote/sale/project/projectUdef/SuperOffice:10|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - page1saleandadmin| x |
|alternative/version/quote/sale/project/NumberOfActivities|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|alternative/version/quote/sale/project/NumberOfActivitiesInPeriod|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedActivities|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedActivitiesInPeriod|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|alternative/version/quote/sale/project/LastActivity|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_LAST\_ACTIVITY|  |
|alternative/version/quote/sale/project/LastCompletedActivity|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|alternative/version/quote/sale/project/LastDoByActivity|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|alternative/version/quote/sale/project/NumberOfSales|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_NUMBER\_OF\_SALES|  |
|alternative/version/quote/sale/project/NumberOfSalesInPeriod|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedSales|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|alternative/version/quote/sale/project/NumberOfNotCompletedSalesInPeriod|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|alternative/version/quote/sale/project/LastSale|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_LAST\_SALE|  |
|alternative/version/quote/sale/project/LastCompletedSale|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|alternative/version/quote/sale/project/LastDoBySale|date|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|alternative/version/quote/sale/project/SaintStatus3|saintStatus|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|alternative/version/quote/sale/project/saintSaleStatus|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_WITH\_STATUS|  |
|alternative/version/quote/sale/project/saintAmountClass|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_AMOUNT\_CLASS|  |
|alternative/version/quote/sale/project/saintActivityType|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_SAINT\_TYPE|  |
|alternative/version/quote/sale/project/saintDirection|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARCHIVE\_DIRECTION|  |
|alternative/version/quote/sale/project/saintIntention|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ACTIVITY\_INTENTION|  |
|alternative/version/quote/sale/project/saintTicketStatus|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|alternative/version/quote/sale/project/saintTicketCategory|listAny|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|alternative/version/quote/sale/project/project/textId|int|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - Text ID| x |
|alternative/version/quote/sale/project/project/infoText|positiveString|SR\_SINGULAR\_SALE - SR\_SINGULAR\_PROJECT - SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|alternative/version/quote/connection/quoteConnectionId|int|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONID: SR\_QUOTE\_CONNECTIONID\_TOOLTIP| x |
|alternative/version/quote/connection/deleted|bool|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONDELETED: SR\_QUOTE\_CONNECTIONDELETED\_TOOLTIP| x |
|alternative/version/quote/connection/allAccess|bool|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONALLACCESS: SR\_QUOTE\_CONNECTIONALLACCESS\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|alternative/version/quote/connection/erpName|int|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONERPNAME: SR\_QUOTE\_CONNECTIONERPNAME\_TOOLTIP| x |
|alternative/version/quote/connection/displayName|string|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONDISPLAYNAME: SR\_QUOTE\_CONNECTIONDISPLAYNAME\_TOOLTIP| x |
|alternative/version/quote/connection/displayDescription|string|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONDISPLAYDESCRIPTION: SR\_QUOTE\_CONNECTIONDISPLAYDESCRIPTION\_TOOLTIP| x |
|alternative/version/quote/connection/connectorName|string|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONCONNECTORNAME: SR\_QUOTE\_CONNECTIONCONNECTORNAME\_TOOLTIP| x |
|alternative/version/quote/connection/extraData|string|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONEXTRADATA: SR\_QUOTE\_CONNECTIONEXTRADATA\_TOOLTIP| x |
|alternative/version/quote/connection/updatedBy|associate|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|alternative/version/quote/connection/updatedDate|date|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|alternative/version/quote/connection/registeredBy|associate|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|alternative/version/quote/connection/registeredDate|date|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|alternative/version/quote/connection/erpConnection/id|int|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_ID: SR\_ERPCONN\_ID\_TOOLTIP|  |
|alternative/version/quote/connection/erpConnection/name|string|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_NAME: SR\_ERPCONN\_NAME\_TOOLTIP|  |
|alternative/version/quote/connection/erpConnection/description|string|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_DESCRIPTION: SR\_ERPCONN\_DESCRIPTION\_TOOLTIP|  |
|alternative/version/quote/connection/erpConnection/active|bool|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_ACTIVE: SR\_ERPCONN\_ACTIVE\_TOOLTIP|  |
|alternative/version/quote/connection/erpConnection/erpId|string|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_ERPID: SR\_ERPCONN\_ERPID\_TOOLTIP|  |
|alternative/version/quote/connection/erpConnection/mostRecent|string|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_MOSTRECENT: SR\_ERPCONN\_MOSTRECENT\_TOOLTIP|  |
|alternative/version/quote/connection/erpConnection/allAccess|bool|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_ALLACCESS: SR\_ERPCONN\_ALLACCESS\_TOOLTIP|  |
|alternative/version/quote/connection/erpConnection/deleted|bool|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_CONNECTIONDELETED: SR\_ERPCONN\_CONNECTIONDELETED\_TOOLTIP|  |
|alternative/version/quote/connection/erpConnection/updatedBy|associate|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|alternative/version/quote/connection/erpConnection/updatedDate|date|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|alternative/version/quote/connection/erpConnection/registeredBy|associate|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|alternative/version/quote/connection/erpConnection/registeredDate|date|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|alternative/version/quote/connection/erpConnection/connector/id|stringorPK|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_ID: SR\_ERPCONN\_ID\_TOOLTIP| x |
|alternative/version/quote/connection/erpConnection/connector/url|string|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_URL: SR\_ERPCONN\_URL\_TOOLTIP| x |
|alternative/version/quote/connection/erpConnection/connector/name|string|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_NAME: SR\_ERPCONN\_NAME\_TOOLTIP| x |
|alternative/version/quote/connection/erpConnection/connector/updatedBy|associate|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|alternative/version/quote/connection/erpConnection/connector/updatedDate|date|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|alternative/version/quote/connection/erpConnection/connector/registeredBy|associate|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|alternative/version/quote/connection/erpConnection/connector/registeredDate|date|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_ERPCONN\_CONNECTIONS - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/QuoteLineStaticSelection?$select=alternative/description,alternative/version/quote/sale/amountInBaseCurrency,alternative/version/quote/sale/person/personExtra/x_person_appointment_relation,alternative/version/quote/sale/person/correspondingAssociate/title,alternative/version/quote/sale/contact/postAddress/line2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

