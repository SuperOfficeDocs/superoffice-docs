---
title: id_transfer_tickets      
description: Identity transfer tickets
author: {github-id}             # Your GitHub alias.
so.date: 05.08.2018
keywords:
so.topic: concept
---

# Identity transfer tickets

SuperOffice is a platform that consists of several applications and modules. These include:

* Win Client / Portal / Web Panel / Partner app
* Web Sales Client / Batch / Reporter / OLE DB Provider
* Web Service Client / request / next request / next request ...

SuperOffice must successfully allow an authenticated user's identity to transit in such a way that does not reveal too much, and that is hard to falsify, steal and misuse.

Identity transfer is **essential** in any non-trivial system because the world is much larger than one program (technically, one process or AppDomain is *one program*). It must be reasonably secure, scalable, and fast.

SuperOffice **cannot** reproduce a user's authentication, because it’s possible the credentials were never seen!

Enter the **ticket**, a string that proves that you are currently authenticated, without revealing who you are or how you got there. Like a paper train ticket, it is only valid if it has a _"stub"_.

A ticket is created upon successful authentication, and the stub is persisted along with the credential record in the database.

A ticket itself does not contain a user ID, the user's password, or anything else that is intelligible. When viewed in the database, it's unrecognizable to prevent falsify valid tickets.

A ticket is **base-64 encoded**, and when unpacked it is appears as `{3F2504E0-4F89-11D3-9A0C-0305E82C3301};1254895` – and that is all. Essentially we have 2 random numbers: one is very large (the [GUID][1], the other is smaller.

We use the GUID to find the stub in the credentials table, and the other number to match a hash in the same row. You can’t reconstruct the ticket from the hash, it's a one-way street, but you can get the hash from the ticket. By itself, the ticket by design doesn’t tell you anything useful.

To get information from a ticket, it must be given to NetServer for authentication. When authenticated, you know who you are and your request will proceed to execute. Otherwise, you’re out of luck.

<!-- Referenced links -->
[1]: http://en.wikipedia.org/wiki/Globally_Unique_Identifier
