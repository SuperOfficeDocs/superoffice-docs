---
uid: crmscript-request-split-merge
title: Split and merge
description: How to split and merge requests in CRMScript.
keywords: Service, ticket, request, CRMScript
author: Bergfrid Skaara Dias
date: 05.26.2023
version: 10
topic: howto
---

# Split and merge

If one request contains multiple questions, you can split the request.

Sometimes, you will for example see that the customer initially asks a technical question, but then uses the opportunity to raise an invoicing query as well.

Other times, the situation is reversed: multiple contacts in the same company have reported the same technical issue (via phone, email). You can then merge these duplicates into one request.

There's no `split()` or `merge()` method, but you can write your own logic. Here's how.

## Split request

Pre-requisite: ID of the original ticket and the message you want to split out is known.

1. Load the original ticket.
1. Create a new ticket and copy *essential* data from the original.
1. Set a suitable title and category.
1. Copy the message with the new question to the new ticket.
1. Modify the original ticket to reflect the split.
1. Save both tickets and resume processing.

> [!TIP]
> You can also split a message.

## Merge requests

1. Load both requests.
2. Copy all contacts and messages from the source into the target.
3. Select which request data to keep. If you want to keep the value from the source, copy this into the target ticket (overwrite).
4. Set source ticket `connect_id` field equal to the target ticket ID.
5. Set the status of the source ticket to **5** (Merged/Linked).
6. Update any other important settings on the target ticket.
7. Save both tickets and resume processing.

> [!TIP]
> To filter [SearchEngine][1] results for merged tickets, include criteria to exclude tickets with status equals 5.

<!-- Referenced links -->
[1]: ../../searchengine/index.md
