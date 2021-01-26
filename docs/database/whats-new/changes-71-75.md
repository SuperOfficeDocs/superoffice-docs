---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: changes_71_to_75       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Changes in SuperOffice from 7.1 to 7.5 # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Table changes from 7.1 to 7.5

## Renamed tables

| Table no | 7.1 | 7.5 |
|---|---|---|
| 25 | obsolete\_1 | [SORPublishGroupLink](../tables/sorpublishgrouplink.md) |
| 26 | obsolete\_2 | [QuoteConnection](../tables/quoteconnection.md) |
| 27 | obsolete\_3 | [QuoteConnectionAccess](../tables/quoteconnectionaccess.md) |
| 34 | obsolete\_4 | [Quote](../tables/quote.md) |
| 39 | obsolete\_9 | [QuoteVersion](../tables/quoteversion.md) |
| 47 | obsolete\_5 | [QuoteAlternative](../tables/quotealternative.md) |
| 127 | obsolete\_6 | [QuoteLine](../tables/quoteline.md) |
| 128 | obsolete\_7 | [PriceList](../tables/pricelist.md) |
| 129 | obsolete\_8 | [Product](../tables/product.md) |

## New tables

| Table no | Name |
|---|---|
| 408 | [ProductCategory](../tables/productcategory.md) |
| 409 | [ProductCategoryGroupLink](../tables/productcategorygrouplink.md) |
| 410 | [ProductCategoryHeadingLink](../tables/productcategoryheadinglink.md) |
| 411 | [ProductFamily](../tables/productfamily.md) |
| 412 | [ProductFamilyGroupLink](../tables/productfamilygrouplink.md) |
| 413 | [ProductFamilyHeadingLink](../tables/productfamilyheadinglink.md) |
| 414 | [ProductType](../tables/producttype.md) |
| 415 | [ProductTypeGroupLink](../tables/producttypegrouplink.md) |
| 416 | [ProductTypeHeadingLink](../tables/producttypeheadinglink.md) |
| 417 | [ErpConnector](../tables/erpconnector.md) |
| 418 | [ErpConnection](../tables/erpconnection.md) |
| 419 | [ErpConnectionActorType](../tables/erpconnectionactortype.md) |
| 420 | [ErpConnectionAccess](../tables/erpconnectionaccess.md) |
| 421 | [ConnectionConfigField](../tables/connectionconfigfield.md) |
| 422 | [ErpInternalKey](../tables/erpinternalkey.md) |
| 423 | [ErpExternalKey](../tables/erpexternalkey.md) |
| 424 | [ErpListItemMapping](../tables/erplistitemmapping.md) |
| 425 | [ErpField](../tables/erpfield.md) |
| 426 | [ErpSyncLog](../tables/erpsynclog.md) |
| 427 | [PaymentTerms](../tables/paymentterms.md) |
| 428 | [PaymentTermsGroupLink](../tables/paymenttermsgrouplink.md) |
| 429 | [PaymentTermsHeadingLink](../tables/paymenttermsheadinglink.md) |
| 430 | [PaymentType](../tables/paymenttype.md) |
| 431 | [PaymentTypeGroupLink](../tables/paymenttypegrouplink.md) |
| 432 | [PaymentTypeHeadingLink](../tables/paymenttypeheadinglink.md) |
| 433 | [DeliveryTerms](../tables/deliveryterms.md) |
| 434 | [DeliveryTermsGroupLink](../tables/deliverytermsgrouplink.md) |
| 435 | [DeliveryTermsHeadingLink](../tables/deliverytermsheadinglink.md) |
| 436 | [DeliveryType](../tables/deliverytype.md) |
| 437 | [DeliveryTypeGroupLink](../tables/deliverytypegrouplink.md) |
| 438 | [DeliveryTypeHeadingLink](../tables/deliverytypeheadinglink.md) |
| 439 | [PriceUnit](../tables/priceunit.md) |
| 440 | [PriceUnitGroupLink](../tables/priceunitgrouplink.md) |
| 441 | [PriceUnitHeadingLink](../tables/priceunitheadinglink.md) |
| 442 | [SubscriptionUnit](../tables/subscriptionunit.md) |
| 443 | [SubscriptionUnitGroupLink](../tables/subscriptionunitgrouplink.md) |
| 444 | [SubscriptionUnitHeadingLink](../tables/subscriptionunitheadinglink.md) |
| 445 | [QuoteLineConfiguration](../tables/quotelineconfiguration.md) |
| 446 | [SaleTypeQuoteAttachment](../tables/saletypequoteattachment.md) |
| 447 | [QuoteVersionAttachment](../tables/quoteversionattachment.md) |
| 448 | [ResourceOverride](../tables/resourceoverride.md) |
| 449 | [ErpConfiguration](../tables/erpconfiguration.md) |
| 450 | [EjCategoryGroupLink](../tables/ejcategorygrouplink.md) |

## New fields on existing tables

### [Contact](../tables/contact.md)

| Field | Type | Description |
|---|---|---|
| ActiveErpLinks | long | The number of Erp Sync connections this record is synced with; count of the ErpExternalKey+ErpInternalKey relations |

### [Person](../tables/person.md)

| Field | Type | Description |
|---|---|---|
| ActiveErpLinks | long | The number of Erp Sync connections this record is synced with; count of the ErpExternalKey+ErpInternalKey relations |

### [Project](../tables/project.md)

| Field | Type | Description |
|---|---|---|
| ActiveErpLinks | long | The number of Erp Sync connections this record is synced with; count of the ErpExternalKey+ErpInternalKey relations |

### [Sale](../tables/sale.md)

| Field | Type | Description |
|---|---|---|
| ActiveErpLinks | long | The number of Erp Sync connections this record is synced with; count of the ErpExternalKey+ErpInternalKey relations |

### [Currency](../tables/currency.md)

| Field | Type | Description |
|---|---|---|
| isoCode | VarWChar | ISO currency code, see `http://www.xe.com/iso4217.php` |

### [DocTmpl](../tables/doctmpl.md)

| Field | Type | Description |
|---|---|---|
| long | loadTemplateFromPlugin | If nonzero, then this is the ID of the document plugin that should supply the template document file, instead of the default so\_arc/template |
| ushort | quoteDocType | The role this document plays in the Quote system, if any |

### [SaleType](../tables/saletype.md)

| Field | Type | Description |
|---|---|---|
| ushort | allowQuoteAlternatives | Can quotes linked to sales of this type, have multiple Alternatives |
| long | defaultQuoteValidity | Default valid days for quotes linked to sales of this type (valid from quote transmission) |
| longid | quoteLinesTemplate | The template that this sale type should use when producing the product lines offer document the template must have DocTmplQuoteType=QuoteLines |
| ushort | maxDiscountPercentSet | Is there a limit, in percent, to the total discount on quotes linked to sales of this type |
| ushort | minEarningPercentSet | Is there a limit, in earning as percent of total, on quotes linked to sales of this type |
| long | maxDiscountPercent | The maximum discount in percent of total, if set, on quotes linked to sales of this type |
| long | minEarningPercent | The minimum earning in percent of total, if set, on quotes linked to sales of this type |
| longid | confirmationLinesTemplate | The template that this sale type should use when producing the order confirmation lines document the template must have DocTmplQuoteType=ConfirmationLines |
| wchar\_t | documentGroupingFields\[60\] | Comma-separated names of grouping fields for quote lines, when generating the documents |
| wchar\_t | archiveGroupingFields\[60\] | Comma-separated names of grouping fields for quote lines, in the quote lines archive |

### [Role](../tables/role.md)

| Field | Type | Description |
|---|---|---|
| ushort | use\_categories | Override user categories with role categories (CS role) |

### [ej\_category](../tables/ej-category.md)

| Field | Type | Description |
|---|---|---|
| wchar\_t | notification\_email\[2048\] | Comma separated list of addresses to notify when requests are redelegated to (unassigned) in this category. |

### [ej\_message](../tables/ej-message.md)

| Field | Type | Description |
|---|---|---|
| longid | inbox | The id of the inbox entry which created this message. Note: inbox entries are regularily deleted. |

### [ticket](../tables/ticket.md)

| Field | Type | Description |
|---|---|---|
| ushort | origin | What is the origin of this ticket |
| long | time\_spent\_internally | The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| long | time\_spent\_externally | The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| long | time\_spent\_queue | The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| long | real\_time\_spent\_internally | The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| long | real\_time\_spent\_externally | The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| long | real\_time\_spent\_queue | The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| DbDateTime | time\_spent\_calculated | When the time\_spent value was last calculated. |
| long | num\_replies | The number of replies (messages) to the customer for this request. |
| long | num\_messages | The total number of messages for this request. |

### [ticket\_status](../tables/ticket-status.md)

| Field | Type | Description |
|---|---|---|
| ushort | time\_counter | Which field in ticket we count time spent on (queue, internal, external) |
| ushort | deleted | Whether the status is deleted (unavailable) or not |
| ushort | no\_email\_reopen | Whether inbound emails can reopen requests with this status or not |

### [mail\_in\_filter](../tables/mail-in-filter.md)

| Field | Type | Description |
|---|---|---|
| ushort | autofaq | Whether to suggest FAQ entries for this email account or not |
| longid | autofaq\_kb\_category | The root folder for the auto faq search. |

### [extra\_fields](../tables/extra-fields.md)

| Field | Type | Description |
|---|---|---|
| wchar\_t | description\[2048\] | Optional description of what this field is used for. |

### [extra\_tables](../tables/extra-tables.md)

| Field | Type | Description |
|---|---|---|
| wchar\_t | description\[2048\] | Optional description of what this table is used for |

### [extra\_menus](../tables/extra-menus.md)

| Field | Type | Description |
|---|---|---|
| wchar\_t | extra\_info\[256\] | Field used for various extra information depending on menu type |
| ushort | base\_program | Base program used in url (ticket, rms, ...) |
| longid | extra\_table | ExtraTable that the menu is connected to |
| longid | group\_id | Link to extra\_menus table if this menu item is to be shown in a custom menu group |

### [role\_category](../tables/role-category.md)

| Field | Type | Description |
|---|---|---|
| longid | crm\_role | Link to Role |

### [role\_element](../tables/role-element.md)

| Field | Type | Description |
|---|---|---|
| longid | crm\_role | Link to Role |

### [role\_workflow](../tables/role-workflow.md)

| Field | Type | Description |
|---|---|---|
| longid | crm\_role | Link to Role |

### [s\_shipment](../tables/s-shipment.md)

| Field | Type | Description |
|---|---|---|
| wchar\_t | envelope\_from\[256\] | Email address for the MTA envelope (where bounces are returned) |

### [s\_link](../tables/s-link.md)

| Field | Type | Description |
|---|---|---|
| ushort | action\_flags | Bitmask defining what action should be taken |
| longid | add\_contact\_interest | Contact interest to add to recipient person |
| longid | remove\_contact\_interest | Person interest to remove from recipient person |
| longid | add\_person\_interest | Person interest to add to recipient person |
| longid | remove\_person\_interest | Person interest to remove from recipient person |
| longid | add\_contact\_selection | Static contact selection to add person to |
| longid | remove\_contact\_selection | Static contact selection to remove person from |
| longid | add\_project | Project to add person to, as member |
| longid | remove\_project | Project to remove person from, as member |
| wchar\_t | task\_text\[2048\] | Text of task to be created |
| longid | task\_idx | Task type of new task |
| ushort | task\_flags | Flags that control how the task is created |
| longid | task\_associate\_id | Associate whose diary should receive the task or assignment (unless AssignToOurContact is specified) |
| longid | task\_creating\_associate\_id | Associate who should stand as creator of task also works as fallback if an assigned task is rejected. Usually the associate who ordered the shipment |
| longid | task\_project | Project to connect task to, can be 0 |
| DbDateTime | task\_start | Start time of task, unless UseNextAvailableTime is specified |
| long | task\_duration | Task duration in minutes |

### [s\_link\_customer](../tables/s-link-customer.md)

| Field | Type | Description |
|---|---|---|
| wchar\_t | http\_user\_agent\[256\] | The HTTP\_USER\_AGENT reported when the customer opened this link |

### [s\_link\_customer\_statical](../tables/s-link-customer-statical.md)

| Field | Type | Description |
|---|---|---|
| wchar\_t | http\_user\_agent\[256\] | The HTTP\_USER\_AGENT reported when the customer opened this link |

### [s\_shipment\_addr](../tables/s-shipment-addr.md)

| Field | Type | Description |
|---|---|---|
| ushort | status | Status for sending to this particular recipient |
| longid | contact\_id | Id of contact bound to shipment address |
| DbDateTime | sending\_time | Estimated or actual sent time (depends on status) |

### [s\_list\_shipment](../tables/s-list-shipment.md)

| Field | Type | Description |
|---|---|---|
| ushort | status | Status of shipment list |

### [screen\_definition](../tables/screen-definition.md)

| Field | Type | Description |
|---|---|---|
| wchar\_t | description\[2048\] | Optional description of what this screen is used for |

### [scheduled\_task](../tables/scheduled-task.md)

| Field | Type | Description |
|---|---|---|
| wchar\_t |description\[2048\] | Optional description of what this task is used for. |

### [ejscript](../tables/ejscript.md)

| Field | Type | Description |
|---|---|---|
| wchar\_t | long\_description\[2048\] | Optional description of what this script is used for. |

### [sms](../tables/sms.md)

| Field | Type | Description |
|---|---|---|
| longid | outgoing\_message\_id | Reference to the outgoing message entry created by netserver for sending and status update |

### [external\_document](../tables/external-document.md)

| Field | Type | Description |
|---|---|---|
| longid | s\_message | Relation to s\_message if this document is an image in a newsletter |

### [outgoing\_message](../tables/outgoing-message.md)

| Field | Type | Description |
|---|---|---|
| DbDateTime | registered | Registered when |
| longid | registered\_associate\_id | Registered by whom |
| DbDateTime | updated | Last updated when |
| longid | updated\_associate\_id | Last updated by whom |
