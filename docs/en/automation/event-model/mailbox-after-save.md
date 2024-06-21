---
title: Mailbox after save
uid: event_model_mailbox_after_save
description: CRMScript event model - Mailbox event, execute after message is saved
author:
date:
keywords:
topic: reference
---

# Mailbox event, execute after message is saved

This is a CRMScript you can add under the menu **System design** in the screen **System Script**.

Here you can add CRMScript code that will be executed for all mailboxes after the mail has been processed by any email filters (except scripts to be executed for the filter) and saved to the system. The script will be executed before any notifications and email-filter scripts are run. The call sequence can be described like this:

1. Get emails from the mail server
2. Analyze email
3. Run the "Mailbox event, executed before message is saved" script
4. Run mailbox filter code (except attached script)
5. Store message to the system
6. Run this script
7. Run mailbox filter attached scripts
8. Send notifications

There are several variables available in this context. These can be obtained by

```crmscript
getVariable("xxx")
```

## Read-only variables

| Variable | Description |
|---|---|
| messageId | The ID of the newly created message |
| ticketId | The ID of the ticket |
| customerId|  The ID of the primary customer connected to this ticket |
| customerEmail|  Email address of the primary customer connected to this ticket |
| mailBackup | Raw version of the email |
| isNewCustomer | set to 1 if this email created a new customer/person (from version 8.1 - R13) |

In addition, any variables set by the email filter are also available with the name specified in the email filter.
