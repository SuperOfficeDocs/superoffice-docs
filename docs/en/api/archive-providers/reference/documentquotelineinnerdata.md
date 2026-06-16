---
uid: DocumentQuoteLineInnerData
title: DocumentQuoteLineInnerData
description: 
keywords: DocumentQuoteLineInnerData archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "DocumentQuoteLineInnerData"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.DocumentQuoteLineInnerDataProvider">SuperOffice.CRM.ArchiveLists.DocumentQuoteLineInnerDataProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"quoteLine"||

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
|alternative/version/quote/orderComment|string|SR\_QUOTE\_QUOTE\_ORDERCOMMENT: SR\_QUOTE\_QUOTE\_ORDERCOMMENT\_TOOLTIP| x |
|alternative/version/quote/connectionId|int|SR\_QUOTE\_CONNECTIONID: SR\_QUOTE\_CONNECTIONID\_TOOLTIP| x |
|alternative/version/quote/registeredDate|date|SR\_QUOTE\_QUOTE\_REGISTERED: SR\_QUOTE\_QUOTE\_REGISTERED\_TOOLTIP| x |
|alternative/version/quote/sale/completed|bool|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|alternative/version/quote/sale/icon|listAny|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|alternative/version/quote/sale/date|date|SR\_SINGULAR\_SALE - SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|alternative/version/quote/sale/time| *None* |SR\_SINGULAR\_SALE - SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|alternative/version/quote/connection/quoteConnectionId|int|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONID: SR\_QUOTE\_CONNECTIONID\_TOOLTIP| x |
|alternative/version/quote/connection/deleted|bool|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONDELETED: SR\_QUOTE\_CONNECTIONDELETED\_TOOLTIP| x |
|alternative/version/quote/connection/allAccess|bool|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONALLACCESS: SR\_QUOTE\_CONNECTIONALLACCESS\_TOOLTIP| x |
|alternative/version/quote/connection/erpName|int|SR\_QUOTE\_SINGULAR\_QUOTECONNECTION - SR\_QUOTE\_CONNECTIONERPNAME: SR\_QUOTE\_CONNECTIONERPNAME\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
GET /api/v1/archive/DocumentQuoteLineInnerData?$select=alternative/version/extraField2,alternative/version/quote/sale/soldReason,alternative/version/quote/sale/associate/assocTooltip,alternative/version/quote/connection/erpConnection/active
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

