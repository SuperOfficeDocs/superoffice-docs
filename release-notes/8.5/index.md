---
author: SuperOffice AS – Research and Development
date: 12.18.2020
version: 8.5
---

# What’s new in SuperOffice 8.5

## Summary of highlights

SuperOffice 8.5 – is the last version of the SuperOffice CRM platform where the Windows client is supported.

Tags is a new main feature and is a powerful tool to search and group requests in SuperOffice Service.

You can set up tags in your system and tag any ticket with as many tags as you want. You are no longer limited to the standard categories. Using tags will simplify the way you save your requests and optimize your searching, listing, and filtering capabilities.

For a more efficient tag system, and to avoid duplicate tags for the same request, the ability to add or delete tags will be a functional right set by the administrator.

The SuperOffice Service Customer Centre has also given been a major update with both a modernized out-of-the-box look and feel and more importantly the ability to adjust the style to fit a company’s own corporate identity without the knowledge of HTML coding.

One of the major new features released in SuperOffice 8.5 has been the ability to send and receive appointment invitations from people outside your organization, i.e. those not using your SuperOffice Diary. The set of features associated with this makes managing your diary a whole lot easier and a lot more efficient than before.

Several of the main screens in Pocket CRM has been redesigned to offer an easier way to take action, whether that is to call, send a text, an e-mail, update a sale or make an appointment. The information presented has also been made more flexible with options for choosing what works for an individual user.

> [!NOTE]
> **Google has launched a new version of their Chrome web browser**. This new browser contains new and improved security measures that could affect the use of SuperOffice in combination with Iframes, cookies for the chat widget, and web forms you use on your websites. Make sure to upgrade to SuperOffice CRM 8.5 R11 to make sure this new browser is supported by SuperOffice.

## Breaking database change in NetServer

This coming release (new main version, 8.5) will contain the **Tags** functionality in Service. To make tag searching extremely fast, and to enable "all-of" searches, we have used a new way of encoding a many-to-many relation. Instead of having a classical link table that points to `ticket` on one side and a `tags` table on the other, we are collecting the IDs of tags into a single text field in the `ticket` table. Of course, this limits the number of tags you can have on a single ticket, but the upper limit is around 400 and that should be enough.

> [!NOTE]
> 400 is not the max number of distinct tags, but the number of different tags assigned to any *one* ticket.

The tag IDs are encoded into "words", using the letters A-J for digits 0-9 plus a Z for any possible negative signs. By doing this we can leverage the Fulltext Search functionality in SQL Server, which will discover and index these words. The result is a lightning-fast search, in tests, we have seen a 40ms search time to locate a ticket by looking for 4 tags among 10.000.000 rows. There is also an automatic fallback from Fulltext Search if that feature is turned off on SQL Server and our other supported database platforms. This fallback uses the LIKE operator, and while slower, still is useably fast.

To make this nifty encoding transparent to application developers we have extended our CDD universe with a new database column data type: `int[]` (array of integers), and specifically as a new Dictionary data type called **FKArray** (array of foreign keys). By doing this we make the encoding into these funny words invisible to developers, both inside and outside of SuperOffice. Columns declared using this type behave just like you would expect in the code, including being supported by the DotSyntax search engine. All the encoding, decoding, and searching happen down in the basement.

The cost of doing this is that the new database is **incompatible with previous NetServer releases**. *Incompatible* here means that an old NetServer will simply crash on start-up when it meets an upgraded database. This is a tad inelegant and quite possibly we can do better in the future… but right now that is what we have. In Online, we upgrade everything synchronously and expect no problems; there are no breaking changes in the service layer.

Onsite installations need some care: any partner integrations that **have their own NetServers** need to be recompiled with the new one, and be upgraded at the same time as the database is upgraded. Integrations that call the service layer are in the same position as apps in CRM Online, as long as the NetServer they're calling has been upgraded, the apps will work.

Database Mirroring is not technically affected. Mirroring looks at the database at a purely physical level, and simply sees a new NVARCHAR(4000) field that is created and replicated. Interpreting the content of this field is another matter. Hopefully, you don't need to do that, but we will publish the format and code to do so.

The error message you see in the NetServer log if you run an old NetServer against a new database looks like this:

```text
Element:
Message: Failed to load dictionary; often caused by wrong table prefix
Type: SuperOffice.Exceptions.SoDbAccessException

...

Inner Element:
Message: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
Parameter name: type
Actual value was 22.
Type: System.ArgumentOutOfRangeException
```

Please use the [Continuous Database forum][1] to communicate any **questions or concerns** you may have about this change.

## Details of the new features

* 8.5 R01 Tag your requests
* 8.5 R02 Pocket CRM, Sales, Marketing, Service, and Settings improvements
* 8.5 R03 Auto-save, request preferences & CRM script triggers
* 8.5 R04 Extra Service field available in CRM and Google reCAPTCHA for forms
* 8.5 R05 Configuration of Service Customer Centre, new fields in forms
* 8.5 R06 iOS 13 updates, Service available in Russian, and improved Bulk update
* 8.5 R07 Google Analytics for forms, Preview email attachments, and group Tags
* 8.5 R08 Extended email domain validation for forms and chat
* 8.5 R09 New Company and Contact card for Pocket CRM
* 8.5 R10 New user management, new main contact field, and Ukrainian language.
* 8.5 R11 Incoming and outgoing invitations for internal and external people
* 8.5 R12 Manage service categories from Settings and maintenance
* 8.5 R13 New and improved User administration features
* 8.5 R14 New invitation feature in Mail link and improvements in Pocket CRM
* 8.5 R15
* 8.5 R15 Hotfix: For versions of Chromium 86 and Edge 86
* 8.5 R16 Windows features, Chat security settings, security bugs on Web and Service
* 8.5 R17 OAuth – Open Authorization for Inbox / Open Authorization for Mail boxes

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/forums/api-forums/client-libraries-and-tools/
