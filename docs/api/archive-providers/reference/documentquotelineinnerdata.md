---
uid: DocumentQuoteLineInnerData
title: DocumentQuoteLineInnerData
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "DocumentQuoteLineInnerData"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
|quoteLineId|int|Quote line ID: Database identity of the quote line| x |
|quoteAlternativeId|int|Alternative ID: The database identity of the quote alternative| x |
|erpProductKey|string|Product key: The foreign key of the product the quote line is based on.| x |
|rank|int|Rank: Shows the rank of a product| x |
|quantity|decimal|Quantity: The quantity that is offered| x |
|name|string|Name: The name of the product that is being offered.  This name can be changed to accommodate the customer's needs.| x |
|description|string|Description: Description of the product that is offered| x |
|code|string|Code: The product or article code. This code is created to help you quickly find products you offer regularly.| x |
|quantityUnit|string|Unit: The unit of the product that is offered.| x |
|priceUnit|string|Price unit: What is the price unit defined in| x |
|url|string|Web address: The web address of the product info.| x |
|subscriptionUnit|string|Subscription unit: Unit the subscription is sold/renewed in, such as year/quarter/month| x |
|subscriptionQuantity|decimal|Subscription quantity: Number of subscription units offered| x |
|UnitListPriceSubscriptionQuantity| *None* |Subscription list price: Unit price * subscription quantity|  |
|PriceUnitSubscriptionUnit| *None* |P/S Unit: Price unit/subscription unit|  |
|PriceUnitSubscriptionQuantityUnit| *None* |Expanded unit: Price unit @ subscription quantity + unit|  |
|vatInfo|string|VAT info: | x |
|vat|decimal|VAT: May be filled out by the ERP system| x |
|unitCost|decimal|Cost: Cost per item.| x |
|unitMinimumPrice|decimal|Unit minimum price: Minimum price per item. Users are not allowed to send quotes with prices lower than the minimum price.| x |
|unitListPrice|decimal|List price: List price of a unit| x |
|totalPrice|decimal|Total: List price * Quantity - Discount Amount| x |
|totalCost|decimal|Total cost|  |
|quoteLineThumbnail| *None* |Thumbnail: A miniature version of the product picture|  |
|quoteLineThumbnailLarge| *None* |Thumbnail: A miniature version of the product picture|  |
|discountAmount|decimal|Discount: Discount amount given by salesperson| x |
|discountPercent|decimal|Discount (%: Discount percent given by salesperson| x |
|earningAmount|decimal|Earnings: Amount of Earnings (Total - Cost) on the line, after discount| x |
|earningPercent|decimal|Earnings (%: Percentage Earnings on the line (Total - Cost / Total), after discount| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|productCategoryKey|listExternal|Product category: The category the product is defined in|  |
|productFamilyKey|listExternal|Product family: The family the product is defined in|  |
|productTypeKey|listExternal|Product type: The type of product|  |
|status|listAny|Quote status: Status field showing the status of each line.| x |
|subTotal|decimal|Sum: Sum of Quantity * Unit list price| x |
|vatAmount|decimal|VAT (amount: The calculated VAT amount| x |
|totalPriceIncVAT|decimal|Total incl. VAT: Total including VAT| x |
|totalPriceWithAlternativeDiscount|decimal|Total incl. alt. disc: Total, including any discount percentage set on the alternative| x |
|alternative/quoteAlternativeId|int|QuoteAlternative ID: SuperOffice database ID of the quote alternative record| x |
|alternative/quoteVersionId|int|ID: Database ID of QuoteVersion record| x |
|alternative/name|string|Name: Name of the quote alternative| x |
|alternative/description|string|Description: Description of the quote alternative| x |
|alternative/status|listAny|Quote status: Status field showing the status of each line.| x |
|alternative/reason|string|Quote reason: The reason or explanation for any status other than 'OK'.| x |
|alternative/erpDiscountPercent|decimal|ERP Discount %: Discount percentage suggested by ERP system| x |
|alternative/erpDiscountAmount|decimal|ERP Discount: Discount amount suggested by ERP system| x |
|alternative/discountPercent|decimal|Discount %: Enter discount in percent for entire alternative| x |
|alternative/discountAmount|decimal|Discount: Enter total discount for entire alternative| x |
|alternative/vatInfo|string|VAT Info: Information about value-added and other taxes| x |
|alternative/vat|decimal|VAT: Value-added and other taxes, total amount| x |
|alternative/earningPercent|decimal|Earnings %: Total Earnings as a percentage of the total price, of all lines in the quote alternative, including all discounts| x |
|alternative/earningAmount|decimal|Earnings: Total Earnings for all lines in the quote alternative, including all discounts| x |
|alternative/totalPrice|decimal|Total: Total price of all items in the quote alternative, including all discounts| x |
|alternative/extraField1|string|Extra 1: Extra field 1 on the quote alternative| x |
|alternative/extraField2|string|Extra 2: Extra field 2 on the quote alternative| x |
|alternative/extraField3|string|Extra 3: Extra field 3on the quote alternative| x |
|alternative/extraField4|string|Extra 4: Extra field 4 on the quote alternative| x |
|alternative/extraField5|string|Extra 5: Extra field 5 on the quote alternative| x |
|alternative/alternativeOrdering|int|QuoteAlternative ID: SuperOffice database ID of the quote alternative record| x |
|alternative/subTotal|decimal|Total before discount: Total of all lines, before applying the Alternative discount| x |
|alternative/totalPriceIncVAT|decimal|Total incl. VAT: Total of all lines, including VAT| x |
|alternative/vatAmount|decimal|VAT: VAT (amount) for the alternative| x |
|alternative/version/quoteVersionId|int|ID: Database ID of QuoteVersion record| x |
|alternative/version/description|string|Description: Description of the quote version| x |
|alternative/version/number|string|Number: Reference number for the quote version| x |
|alternative/version/sent|date|Sent: The date the quote (version) was sent to the customer| x |
|alternative/version/expiration|date|Expiry date: The last date that the quote is valid| x |
|alternative/version/state|listAny|State: The current state the quote is in| x |
|alternative/version/status|listAny|Quote status: Status field showing the status of each line.| x |
|alternative/version/reason|string|Quote reason: The reason or explanation for any status other than 'OK'.| x |
|alternative/version/paymentTerms|listExternal|Payment terms: Payment terms|  |
|alternative/version/paymentType|listExternal|Payment type: Payment type|  |
|alternative/version/deliveryTerms|listExternal|Delivery terms: Delivery terms|  |
|alternative/version/deliveryType|listExternal|Delivery type: Delivery type|  |
|alternative/version/approvedBy|associate|Approved by: Associate who approved a quote that broke one or more of the workflow rules that trigger an approval process| x |
|alternative/version/approvalRegisteredBy|associate|Approval reg by: Associate who entered the approval of a quote that broke one or more of the workflow rules that trigger an approval process.  Not necessarily the person who approved the quote.| x |
|alternative/version/approvedText|string|Approval comment: Comment added to the approval of a quote that broke one or more of the workflow rules that trigger an approval process| x |
|alternative/version/approvedDate|date|Approved date: Date of approval of a quote that broke one or more of the workflow rules that trigger an approval process| x |
|alternative/version/extraField1|string|Extra field 1: One of the extra fields on the product; meaning is installation dependent| x |
|alternative/version/extraField2|string|Extra field 2: One of the extra fields on the product; meaning is installation dependent| x |
|alternative/version/extraField3|string|Extra field 3: One of the extra fields on the product; meaning is installation dependent| x |
|alternative/version/extraField4|string|Extra field 4: One of the extra fields on the product; meaning is installation dependent| x |
|alternative/version/extraField5|string|Extra field 5: One of the extra fields on the product; meaning is installation dependent| x |
|alternative/version/quote/quoteId|int|Quote ID: SuperOffice database ID of quote record| x |
|alternative/version/quote/poNumber|string|P.O. Number: Customer's purchase order number| x |
|alternative/version/quote/orderComment|string|Comment: Customer's comment| x |
|alternative/version/quote/connectionId|int|DB-ID: Database ID| x |
|alternative/version/quote/registeredDate|date|Registered at: Displays the date when the quote was registered.| x |
|alternative/version/quote/sale/completed|bool|Sale - Completed: Displays a checkbox showing if an appointment is completed| x |
|alternative/version/quote/sale/icon| *None* |Sale - Category: Displays the icon for an activity type| x |
|alternative/version/quote/sale/date|date|Sale - Date: Displays start date of a follow-up / sale date of a sale| x |
|alternative/version/quote/sale/time| *None* |Sale - Time: Time|  |
|alternative/version/quote/sale/type|listAny|Sale - Type: Displays the type of an activity| x |
|alternative/version/quote/sale/recordType|string|Sale - Record type: Shows the record type| x |
|alternative/version/quote/sale/text|positiveString|Sale - Text: Displays a descriptive text for the item| x |
|alternative/version/quote/sale/associateId|associate|Sale - ID: Displays the login ID of the associate who owns the activity.| x |
|alternative/version/quote/sale/contactId|listAny|Sale - Company ID: Database ID of company| x |
|alternative/version/quote/sale/personId|listAny|Sale - Contact ID: Database ID of the contact row| x |
|alternative/version/quote/sale/projectId|listAny|Sale - Project ID: Database ID of project record| x |
|alternative/version/quote/sale/saleId|int|Sale - Sale ID: The database ID of the sale record| x |
|alternative/version/quote/sale/userGroup|userGroup|Sale - User group: The user group that owns the record| x |
|alternative/version/quote/sale/who| *None* |Sale - Who: Contact and/or company|  |
|alternative/version/quote/sale/updatedBy|associate|Sale - Updated by: The user who last updated the data| x |
|alternative/version/quote/sale/updatedDate|date|Sale - Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/sale/registeredBy|associate|Sale - Registered by: The user who registered the data| x |
|alternative/version/quote/sale/registeredDate|date|Sale - Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/sale/currencyId|int|Sale - Currency ID: The currency list item ID| x |
|alternative/version/quote/sale/currency|listAny|Sale - Currency: The currency of the sale| x |
|alternative/version/quote/sale/credited|listAny|Sale - Credited: The user to be credited with the sale| x |
|alternative/version/quote/sale/lossReason|listAny|Sale - Reason (lost): The reason for losing the sale| x |
|alternative/version/quote/sale/source|listAny|Sale - Source: The source (lead) of the sale| x |
|alternative/version/quote/sale/competitor|listAny|Sale - Competitor: The competitor who won the sale| x |
|alternative/version/quote/sale/heading|stringorPK|Sale - Sale: Displays a descriptive text for the item| x |
|alternative/version/quote/sale/amount|decimal|Sale - Amount: The gross sales total| x |
|alternative/version/quote/sale/amountWeighted|decimal|Sale - Weighted amount: Virtual field calculated from amount * probability percent.| x |
|alternative/version/quote/sale/earning|decimal|Sale - Profit: Gross profit (gross sales total - cost) for the sale| x |
|alternative/version/quote/sale/earningPercent|decimal|Sale - Profit as %: The profit as a percentage of the gross sales total| x |
|alternative/version/quote/sale/probPercent|int|Sale - Probability as %: Probability as %| x |
|alternative/version/quote/sale/originalStage|listAny|Sale - Stage: Displays the stage of the sale| x |
|alternative/version/quote/sale/stage|listAny|Sale - Stage: Displays the stage of the sale| x |
|alternative/version/quote/sale/saleStatus|listAny|Sale - Status: The status of the sale - open, lost or sold| x |
|alternative/version/quote/sale/saleType|listAny|Sale - Sale type: Sale type, from list| x |
|alternative/version/quote/sale/nextDueDate|date|Sale - Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|alternative/version/quote/sale/reopenDate|date|Sale - Reopen date: Displays the reopen date for the sale| x |
|alternative/version/quote/sale/stalledComment|listAny|Sale - Reason (stalled): The reason the sale has been stalled| x |
|alternative/version/quote/sale/soldReason|listAny|Sale - Reason (sold): Reason (sold)| x |
|alternative/version/quote/sale/saleNumber|string|Sale - Number: Number| x |
|alternative/version/quote/sale/hasStakeholders|bool|Sale - Has stakeholders: Does this sale have stakeholders enabled| x |
|alternative/version/quote/sale/hasQuote|bool|Sale - Has quote?: Does the sale have a quote attached?| x |
|alternative/version/quote/sale/hasGuide|bool|Sale - Guided: Does this sale have a Sales Guide| x |
|alternative/version/quote/sale/description|string|Sale - Description: The long description field on Sale|  |
|alternative/version/quote/sale/activeErpLinks|bool|Sale - ERP connected: Is there an active ERP Sync?| x |
|alternative/version/quote/sale/visibleFor|listAny|Sale - Visible for|  |
|alternative/version/quote/sale/sale/textId|int|Sale - Text ID| x |
|alternative/version/quote/sale/sale/description|positiveString|Sale - Text: Displays the text entered in the description field| x |
|alternative/version/quote/sale/associate/firstName|string|Sale - First name: Displays the contact's first name| x |
|alternative/version/quote/sale/associate/lastName|string|Sale - Last name: Displays the contact's last name| x |
|alternative/version/quote/sale/associate/middleName|string|Sale - Middle Name: Displays the contact's middle name.| x |
|alternative/version/quote/sale/associate/fullName|string|Sale - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|alternative/version/quote/sale/associate/contactId|int|Sale - Company ID: Database ID of the company the user belongs to|  |
|alternative/version/quote/sale/associate/personId|int|Sale - Contact ID: Database ID of the contact row|  |
|alternative/version/quote/sale/associate/mrMrs|string|Sale - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/associate/title|string|Sale - Title: Displays whether the contact is addressed as Mr or Ms| x |
|alternative/version/quote/sale/associate/associateDbId|associate|Sale - ID| x |
|alternative/version/quote/sale/associate/contactName|string|Sale - Owning company: Name of the company the user belongs to| x |
|alternative/version/quote/sale/associate/contactDepartment|string|Sale - Owning department: Name of the department at the company the user belongs to| x |
|alternative/version/quote/sale/associate/usergroup|userGroup|Sale - Primary group: The user's primary user group| x |
|alternative/version/quote/sale/associate/contactFullName|string|Sale - Owner: Name and department of the company the user belongs to| x |
|alternative/version/quote/sale/associate/contactCategory|listAny|Sale - Category: Category| x |
|alternative/version/quote/sale/associate/role|listAny|Sale - Role: Role| x |
|alternative/version/quote/sale/associate/assocName|associate|Sale - User ID: User ID| x |
|alternative/version/quote/sale/associate/assocTooltip|string|Sale - Description: Description|  |
|alternative/version/quote/sale/associate/assocType|listAny|Sale - Type: Type of user: associate, external user, system user, anonymous account| x |
|alternative/version/quote/sale/associate/ejUserId|int|Sale - Service user ID: The database ID of a Service user|  |
|alternative/version/quote/sale/associate/simultaneousEjUser|bool|Sale - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|alternative/version/quote/sale/associate/ejDisplayName|string|Sale - Nick name: User's nick name in Service| x |
|alternative/version/quote/sale/associate/ejStatus|int|Sale - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|alternative/version/quote/sale/associate/credentialType| *None* |Sale - Auth. type: What type of credentials to use when this user logs in| x |
|alternative/version/quote/sale/associate/credentialDisplayValue| *None* |Sale - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|alternative/version/quote/sale/associate/isActive|bool|Sale - Active: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/associate/isActiveText|bool|Sale - Active status: Is this user active, and should be able to log in?| x |
|alternative/version/quote/sale/associate/portraitThumbnail| *None* |Sale - Person image: Person image|  |
|alternative/version/quote/sale/associate/otherGroups|userGroup|Sale - Other groups: Other groups|  |
|alternative/version/quote/sale/associate/userName|string|Sale - User name: User name| x |
|alternative/version/quote/sale/associate/personEmail|string|Sale - E-mail| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:1|string|Sale - saleshorttext| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:2|string|Sale - salelongtext| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:3|int|Sale - salenumber| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:4|date|Sale - saledate| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:5|unlimitedDate|Sale - saleunlimiteddate| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:6|bool|Sale - salecheckbox| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:7|listAny|Sale - saledropdownlistbox| x |
|alternative/version/quote/sale/saleUdef/SuperOffice:8|decimal|Sale - saledecimal| x |
|alternative/version/quote/connection/quoteConnectionId|int|ERP connection - DB-ID: Database ID| x |
|alternative/version/quote/connection/deleted|bool|ERP connection - Deleted: Column showing if the ERP connection has been marked as deleted| x |
|alternative/version/quote/connection/allAccess|bool|ERP connection - Unrestricted: There are no access restrictions on this ERP connection| x |
|alternative/version/quote/connection/erpName|int|ERP connection - ERP name: Name of ERP system| x |
|alternative/version/quote/connection/displayName|string|ERP connection - Name: Localized display name| x |
|alternative/version/quote/connection/displayDescription|string|ERP connection - Description: Describes the connection in more detail.| x |
|alternative/version/quote/connection/connectorName|string|ERP connection - Quote Connector name: Name of Quote Connector module. Defined by the developer of the module.| x |
|alternative/version/quote/connection/extraData|string|ERP connection - Extra data: XML encoded data.| x |
|alternative/version/quote/connection/updatedBy|associate|ERP connection - Updated by: The user who last updated the data| x |
|alternative/version/quote/connection/updatedDate|date|ERP connection - Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/connection/registeredBy|associate|ERP connection - Registered by: The user who registered the data| x |
|alternative/version/quote/connection/registeredDate|date|ERP connection - Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/connection/erpConnection/id|int|ERP connection - ERP connections - Connection ID: Database key for an ERP connection|  |
|alternative/version/quote/connection/erpConnection/name|string|ERP connection - ERP connections - Name: Name of the ERP connection in the CRM system|  |
|alternative/version/quote/connection/erpConnection/description|string|ERP connection - ERP connections - Description: The description of the ERP connection in the CRM system|  |
|alternative/version/quote/connection/erpConnection/active|bool|ERP connection - ERP connections - Active: Is the ERP connection currently active?|  |
|alternative/version/quote/connection/erpConnection/erpId|string|ERP connection - ERP connections - ERP ID: The global unique ID of this ERP connection, as used by the Sync Connector|  |
|alternative/version/quote/connection/erpConnection/mostRecent|string|ERP connection - ERP connections - Timestamp: The timestamp of the most recent synchronization on this ERP connection|  |
|alternative/version/quote/connection/erpConnection/allAccess|bool|ERP connection - ERP connections - Unrestricted: There are no access restrictions on this ERP connection|  |
|alternative/version/quote/connection/erpConnection/deleted|bool|ERP connection - ERP connections - Deleted: Column showing if the ERP connection has been marked as deleted|  |
|alternative/version/quote/connection/erpConnection/updatedBy|associate|ERP connection - ERP connections - Updated by: The user who last updated the data| x |
|alternative/version/quote/connection/erpConnection/updatedDate|date|ERP connection - ERP connections - Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/connection/erpConnection/registeredBy|associate|ERP connection - ERP connections - Registered by: The user who registered the data| x |
|alternative/version/quote/connection/erpConnection/registeredDate|date|ERP connection - ERP connections - Registered date: The date/time the data was registered in UTC.| x |
|alternative/version/quote/connection/erpConnection/connector/id|stringorPK|ERP connection - ERP connections - Connection ID: Database key for an ERP connection| x |
|alternative/version/quote/connection/erpConnection/connector/url|string|ERP connection - ERP connections - URL of Sync Connector: The URL to the location where the Sync Connector is installed| x |
|alternative/version/quote/connection/erpConnection/connector/name|string|ERP connection - ERP connections - Name: Name of the ERP connection in the CRM system| x |
|alternative/version/quote/connection/erpConnection/connector/updatedBy|associate|ERP connection - ERP connections - Updated by: The user who last updated the data| x |
|alternative/version/quote/connection/erpConnection/connector/updatedDate|date|ERP connection - ERP connections - Updated: The date/time the data was last updated in UTC.| x |
|alternative/version/quote/connection/erpConnection/connector/registeredBy|associate|ERP connection - ERP connections - Registered by: The user who registered the data| x |
|alternative/version/quote/connection/erpConnection/connector/registeredDate|date|ERP connection - ERP connections - Registered date: The date/time the data was registered in UTC.| x |

## Sample

```http!
GET /api/v1/archive/DocumentQuoteLineInnerData?$select=quantity,PriceUnitSubscriptionQuantityUnit,alternative/version/quote/connection/erpConnection/connector/registeredBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

