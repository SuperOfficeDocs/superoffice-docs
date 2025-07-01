---
title: SORTS
description: SuperOffice Remote Travel Server (SORTS)
author: SuperOffice Product and Engineering
keywords:
date:
content_type: concept
deployment: onsite
platform: win
---

# SuperOffice Remote Travel Server (SORTS)

This program will process received wishlists from Travel users. A wishlist contains requests for other people’s documents.

It is only possible to run the Remote Travel Server through SuperOffice Travel Gateway, and we recommend that it’s run after it should run after each time the update files are read from the travel users, normally once a day.

![sorts -screenshot][img1]

Based on the received wishlist SORTS will create an output file with a list of documents requested by the remote travel user. The next time the user is using SORT  the output file will be processed, and the missing or newer documents will be copied from the server to the local machine.

The output file is based on the user's wishlist (.ini), copied from the local SuperOffice program folder, into the central\wishlist. When SORTS is run from SuperOffice Travel Gateway on the central database the output file is created: CopyList-

EE\2006.2\SuperO-Mailm-Upgrade-to-CRM-5---N.DOC -> File location

EE\2006.1\Super001.doc -> File location

PVM\2006.2\KPMG004.DOC -> File location

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/sorts.gif
