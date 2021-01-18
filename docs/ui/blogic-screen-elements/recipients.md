---
title: blogic_recipients
description: Recipients
author:
so.date:
keywords:
so.topic: reference
---

# Recipients

This element is used to specify email recipients.

## Configuration

| Setting  | Description                                                        |
|:---------|:-------------------------------------------------------------------|
| label    | UI label                                                           |
| ticketId | The related ticket<br/>Affects the values in the *copyTo* settings |

### Which lines to show

The following **boolean** values specify which lines to show:

* copyToAll
* copyToCreatedBy
* copyToCustomer
* copyToEab
* copyToOther
* copyToOwner
* copyToSelf

## Example

```crmscript
copyToAll = false
copyToCreatedBy = false
copyToCustomer = false
copyToEab = true
copyToOther = true
copyToOwner = false
copyToSelf = true
```

## Functions

### getFieldValue(String field)

| Field                  | Description                                                     |
|:-----------------------|:----------------------------------------------------------------|
| to                     | Returns a properly formatted string of To-recipients            |
| cc                     | CC recipients                                                   |
| bcc                    | Bcc recipients                                                  |
| sms                    | Comma-separated SMS recipients                                  |
| isCopyToAnyCustomerSet | Whether 1 or more recipients are customers<br />1 = yes, 0 = no |

### setFieldValue(String action, Map values)

| Action               |  Map keys | Description                                                   |
|:---------------------|:----------|:--------------------------------------------------------------|
| addCustomers         | ids       | Adds customers with IDs specified in the comma-separated list |
| setDefaultToCustomer | id        | Enables the checkbox in front of the customer line            |
