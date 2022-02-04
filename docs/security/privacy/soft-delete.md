---
title: Soft delete
uid: soft_delete
description: Soft delete – the Undo revolution
author: Marek Vokáč
so.date: 04.30.2018
keywords:
so.topic: article
---

# Soft delete – the Undo revolution

SuperOffice has, up to now, always supported the firm-and-resolute model of data deletion: once you delete something, it is gone. If you have a database backup then you can get things back, but it takes time and makes the IT staff give you the Evil Eye, at least if it happens often.

Of course, insiders will know that the story is a little bit more nuanced. If you delete a person, the Windows client will delete a fair bit of directly-dependent stuff such as email, phone, and address. The Web client won’t. And in any case, references in appointment records and elsewhere will remain in the database. They don’t do much harm since our code is quite used to this; it will simply show no person name, even though there is a nonzero person ID on an appointment… but it’s all slightly messy and unsatisfactory.

GDPR provides us with the necessary motivation to do something about this. Two complementary functions are coming in 8.3: the **soft delete** and the **deep delete**. Both are important, and together they give us a much more consistent, user-friendly, and GDPR-compliant story.

**Soft delete** means that instead of deleting a record physically from the database, we just mark it as deleted. We do that by setting a new field, **deletedDate**, to the moment of deletion (in UTC). Rows that have NULL or our beginning-of-time value (which for reasons I won’t go into is 1.1.1760) are considered active; rows that have a different date are considered deleted.

The considering is done by very low-level code in NetServer and in the Windows codebase, which catches every query going into the database. Whenever application code searches for a record in the person table, this code will appendAND (deletedDate IS NULL OR deletedDate = 1.1.1760)to the query (for each table that has soft-delete). As a result, such rows disappear from the results and are never given back to the application – which in practice is the same as deleting them.

But they are not gone from the database, and the new Recycle Bin in the Sales client will show them. There you can **Recover** them, which simply means that the deletedDate is reset… and voilá, the record is back.

The soft delete only applies to the primary table, meaning **person** and **contact**. Any dependent records are left intact, and this is where we take advantage of being used to an "inconsistent" database; our code happily filters out such records because the primary is gone. Therefore, recovery is instant and full, everything comes back again in the user interface.

Deleting a company will delete its persons. Restoring a company will restore all deleted persons on it; restoring a person will also restore its company if it has been deleted (but not all the other persons on the company).

GDPR places limits on keeping irrelevant information, and soft-deleted person and company records are no exception. Therefore, after a time – which will default to 14 days – a periodic background process will *really* delete soft-deleted records that are older than the "retention time". And this time we’re going deep down into the database and cleaning up properly.

Directly dependent records such as email or phone are deleted. Other tables have independent reasons to exist: a meeting still happened, even if no longer have a valid person reference, so there we just zero the appointment.person_id. In all, about 65 tables are impacted by such a cleanup. Not by coincidence, the cleanup is the same one that happens during the upgrade to 8.2R05 in preparation for allowing person-without-company to be visible. That code is well tested and will clean up any loose ends.

Initially, we are rolling out this functionality for **person** and **contact**. Much of it is controlled by settings in the database model and can be extended to other tables, but the details of the deep delete of course reflect our business logic and have to be custom coded for each table. In the future, we may add soft-delete to our other main entities. Note that the "delete" function we already have in Lists is different – that is not really a delete, semantically it just means "value not available for setting".

For partners who use our APIs at any level, nothing changes. You can ask NetServer to delete a record and the interception code will change that into an Update for you, transparently. Search for something, and the filtering conditions will be appended. For those (few?) who work directly with the database, well, now might be the time to consider switching to an API approach?

If you’d like to make a better Recycle Bin, adding a condition like deletedDate > 1.1.1760 to a select, will switch off the automatic filtering conditions for all tables in the query.

Database Mirroring and Travel will both replicate the soft delete as the **update** it really is. Mirroring will also replicate the deep delete that happens later, but Travel will not. The reason is that the deep delete, being a real consistency cleanup, needs to work with whatever is actually in the database. Only the code local to the receiving database can know that, so we use the same strategy as when replicating a Move/Merge operation. The initial operation (update deletedDate) is replicated; and the consequences in the form of a deep delete are **recreated** on the receiving database, after the proper interval, using whatever data is present at the time.

To summarize: for the person and contact tables, a **delete** through any API becomes an update to a date field; and any **select** automatically gets conditions that make such rows disappear. A background process will periodically clean up soft-deleted records that are too old.

For users, it means that delete operations can be undone. For DBAs, the deep delete means a more consistent database. And for lawyers, the threat of GDPR non-compliance becomes smaller. What could be better?
