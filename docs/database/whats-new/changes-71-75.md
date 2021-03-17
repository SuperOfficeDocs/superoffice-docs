---
title: changes_71_to_75
description: Changes in SuperOffice from 7.1 to 7.5
author: {github-id}
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
| 25 | `obsolete_1` | [SORPublishGroupLink](../tables/sorpublishgrouplink.md) |
| 26 | `obsolete_2` | [QuoteConnection](../tables/quoteconnection.md) |
| 27 | `obsolete_3` | [QuoteConnectionAccess](../tables/quoteconnectionaccess.md) |
| 34 | `obsolete_4` | [Quote](../tables/quote.md) |
| 39 | `obsolete_9` | [QuoteVersion](../tables/quoteversion.md) |
| 47 | `obsolete_5` | [QuoteAlternative](../tables/quotealternative.md) |
| 127 | `obsolete_6` | [QuoteLine](../tables/quoteline.md) |
| 128 | `obsolete_7` | [PriceList](../tables/pricelist.md) |
| 129 | `obsolete_8` | [Product](../tables/product.md) |

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
| `ActiveErpLinks` | long | [!include[ALT](./includes/activeerplinks-descr.md)] |

### [Person](../tables/person.md)

| Field | Type | Description |
|---|---|---|
| `ActiveErpLinks` | long | [!include[ALT](./includes/activeerplinks-descr.md)] |

### [Project](../tables/project.md)

| Field | Type | Description |
|---|---|---|
| `ActiveErpLinks` | long | [!include[ALT](./includes/activeerplinks-descr.md)] |

### [Sale](../tables/sale.md)

| Field | Type | Description |
|---|---|---|
| `ActiveErpLinks` | long | [!include[ALT](./includes/activeerplinks-descr.md)] |

### [Currency](../tables/currency.md)

| Field | Type | Description |
|---|---|---|
| `isoCode` | VarWChar | [ISO currency code][1] |

### [DocTmpl](../tables/doctmpl.md)

| Field | Type | Description |
|---|---|---|
| `loadTemplateFromPlugin` | long | If nonzero, then this is the ID of the document plugin that should supply the template document file, instead of the default so\_arc/template |
| `quoteDocType` | ushort | The role this document plays in the Quote system, if any |

### [SaleType](../tables/saletype.md)

| Field | Type | Description |
|---|---|---|
| `allowQuoteAlternatives`| ushort | Can quotes linked to sales of this type, have multiple alternatives |
| `defaultQuoteValidity` | long | Default valid days for quotes linked to sales of this type (valid from quote transmission) |
| `quoteLinesTemplate` | longid | The template that this sale type should use when producing the product lines offer document the template must have `DocTmplQuoteType=QuoteLines` |
| `maxDiscountPercentSet` | ushort | Is there a limit, in percent, to the total discount on quotes linked to sales of this type |
| `minEarningPercentSet` | ushort | Is there a limit, in earning as percent of total, on quotes linked to sales of this type |
| `maxDiscountPercent` | long | The maximum discount in percent of total, if set, on quotes linked to sales of this type |
| `minEarningPercent` | long | The minimum earning in percent of total, if set, on quotes linked to sales of this type |
| `confirmationLinesTemplate` | longid | The template that this sale type should use when producing the order confirmation lines document the template must have `DocTmplQuoteType=ConfirmationLines` |
| `documentGroupingFields[60]` | wchar\_t | Comma-separated names of grouping fields for quote lines, when generating the documents |
| `archiveGroupingFields[60]` | wchar\_t | Comma-separated names of grouping fields for quote lines, in the quote lines archive |

### [Role](../tables/role.md)

| Field | Type | Description |
|---|---|---|
| `use_categories` | ushort | Override user categories with role categories (CS role) |

### [ej\_category](../tables/ej-category.md)

| Field | Type | Description |
|---|---|---|
| `notification_email[2048]` | wchar\_t | Comma separated list of addresses to notify when requests are re-delegated to (unassigned) in this category. |

### [ej\_message](../tables/ej-message.md)

| Field | Type | Description |
|---|---|---|
| `inbox` | longid | The ID of the inbox entry which created this message. Note: inbox entries are regularly deleted. |

### [ticket](../tables/ticket.md)

| Field | Type | Description |
|---|---|---|
| `origin` | ushort | What is the origin of this ticket |
| `time_spent_internally` | long | The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| `time_spent_externally` | long | The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| `time_spent_queue` | long | The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| `real_time_spent_internally` | long | The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| `real_time_spent_externally` | long | The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| `real_time_spent_queue` | long | The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| `time_spent_calculated` | DbDateTime | When the `time_spent` value was last calculated. |
| `num_replies` | long | The number of replies (messages) to the customer for this request. |
| `num_messages` | long | The total number of messages for this request. |

### [ticket\_status](../tables/ticket-status.md)

| Field | Type | Description |
|---|---|---|
| `time_counter` | ushort | Which field in ticket we count time spent on (queue, internal, external) |
| `deleted` | ushort | Whether the status is deleted (unavailable) or not |
| `no_email_reopen` | ushort | Whether inbound emails can reopen requests with this status or not |

### [mail\_in\_filter](../tables/mail-in-filter.md)

| Field | Type | Description |
|---|---|---|
| `autofaq` | ushort | Whether to suggest FAQ entries for this email account or not |
| `autofaq_kb_category` | longid | The root folder for the auto faq search. |

### [extra\_fields](../tables/extra-fields.md)

| Field | Type | Description |
|---|---|---|
| `description[2048]` | wchar\_t | Optional description of what this field is used for. |

### [extra\_tables](../tables/extra-tables.md)

| Field | Type | Description |
|---|---|---|
| `description[2048]` | wchar\_t | Optional description of what this table is used for |

### [extra\_menus](../tables/extra-menus.md)

| Field | Type | Description |
|---|---|---|
| `extra_info[256]` | wchar\_t | Field used for various extra information depending on menu type |
| `base_program` | ushort | Base program used in URL (ticket, rms, ...) |
| `extra_table` | longid | ExtraTable that the menu is connected to |
| `group_id` | longid | Link to `extra_menus` table if this menu item is to be shown in a custom menu group |

### [role\_category](../tables/role-category.md)

| Field | Type | Description |
|---|---|---|
| `crm_role` | longid | Link to Role |

### [role\_element](../tables/role-element.md)

| Field | Type | Description |
|---|---|---|
| `crm_role` | longid | Link to Role |

### [role\_workflow](../tables/role-workflow.md)

| Field | Type | Description |
|---|---|---|
| `crm_role` | longid | Link to Role |

### [s\_shipment](../tables/s-shipment.md)

| Field | Type | Description |
|---|---|---|
| `envelope_from[256]` | wchar\_t | Email address for the MTA envelope (where bounces are returned) |

### [s\_link](../tables/s-link.md)

| Field | Type | Description |
|---|---|---|
| `action_flags` | ushort | Bitmask defining what action should be taken |
| `add_contact_interest` | longid | Contact interest to add to recipient person |
| `remove_contact_interest` | longid | Person interest to remove from recipient person |
| `add_person_interest` | longid | Person interest to add to recipient person |
| `remove_person_interest` | longid | Person interest to remove from recipient person |
| `add_contact_selection` | longid | Static contact selection to add person to |
| `remove_contact_selection` | longid | Static contact selection to remove person from |
| `add_project` | longid | Project to add person to, as member |
| `remove_project` | longid | Project to remove person from, as member |
| `task_text[2048]` | wchar\_t | Text of task to be created |
| `task_idx` | longid | Task type of new task |
| `task_flags`| ushort  | Flags that control how the task is created |
| `task_associate_id` | longid | Associate whose diary should receive the task or assignment (unless AssignToOurContact is specified) |
| `task_creating_associate_id` | longid | Associate who should stand as creator of task also works as fallback if an assigned task is rejected. Usually the associate who ordered the shipment |
| `task_project` | longid | Project to connect task to, can be 0 |
| `task_start` | DbDateTime | Start time of task, unless UseNextAvailableTime is specified |
| `task_duration` | long | Task duration in minutes |

### [s\_link\_customer](../tables/s-link-customer.md)

| Field | Type | Description |
|---|---|---|
| `http_user_agent[256]` | wchar\_t | The HTTP\_USER\_AGENT reported when the customer opened this link |

### [s\_link\_customer\_statical](../tables/s-link-customer-statical.md)

| Field | Type | Description |
|---|---|---|
| `http_user_agent[256]` | wchar\_t | The HTTP\_USER\_AGENT reported when the customer opened this link |

### [s\_shipment\_addr](../tables/s-shipment-addr.md)

| Field | Type | Description |
|---|---|---|
| `status` | ushort | Status for sending to this particular recipient |
| `contact_id` | longid | Id of contact bound to shipment address |
| `sending_time` | DbDateTime | Estimated or actual sent time (depends on status) |

### [s\_list\_shipment](../tables/s-list-shipment.md)

| Field | Type | Description |
|---|---|---|
| `status` | ushort | Status of shipment list |

### [screen\_definition](../tables/screen-definition.md)

| Field | Type | Description |
|---|---|---|
| `description[2048]` | wchar\_t | Optional description of what this screen is used for |

### [scheduled\_task](../tables/scheduled-task.md)

| Field | Type | Description |
|---|---|---|
| `description[2048]` | wchar\_t | Optional description of what this task is used for. |

### [ejscript](../tables/ejscript.md)

| Field | Type | Description |
|---|---|---|
| `long_description[2048]` | wchar\_t | Optional description of what this script is used for. |

### [sms](../tables/sms.md)

| Field | Type | Description |
|---|---|---|
| `outgoing_message_id | longid | Reference to the outgoing message entry created by NetServer for sending a status update |

### [external\_document](../tables/external-document.md)

| Field | Type | Description |
|---|---|---|
| `s_message` | longid | Relation to `s_message` if this document is an image in a newsletter |

### [outgoing\_message](../tables/outgoing-message.md)

| Field | Type | Description |
|---|---|---|
| `registered` | DbDateTime | Registered when |
| `registered_associate_id` | longid | Registered by whom |
| `updated` | DbDateTime | Last updated when |
| `updated_associate_id` | longid | Last updated by whom |

<!-- Referenced links -->
[1]: http://www.xe.com/iso4217.php
