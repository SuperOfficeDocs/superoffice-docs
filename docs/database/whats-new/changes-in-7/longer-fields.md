---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: changes_7_longer_fields       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Changes in SuperOffice 7 - Longer fields # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Longer fields

* Contact name & department are extended to 220
* Project.name, selection.name, document.header
* Address fields  \[80\]
* Phone number - The search algorithm has been changed to handle arbitrarily long numbers, with more-or-less the same results. There is no practical limit to the phone number length anymore.
* Userpreference section, key, value -
  * preference values are now 2k, so the old hack that put long values into the text table is gone. Existing rows are converted during upgrade.
* URL is no longer split into two fields, there is just one, 1k long field; that should be enough

We now use nvarchar(max) instead of text as our large-string datatype. This is more efficient and functionally much more compatible and capable datatype.

This will not make the database bigger, unless the new space is actually used. SQL Server has a mechanism to put long strings into out-of-record pages so the max record limit is waived.

**We have extended just about all fields that needed or looked like they might need it. Further extensions are still possible between alpha and beta; after that – finito.**

SQL Server has a little-publicised limitation: Index nodes cannot be more than 900 bytes (even in 2008)
A unicode string consumes 2 bytes/char

A multi-field index creates nodes from the sum of all fields

And – so – if name + department (which have a combined index) become more than 900 bytes of actual content, save fails
For the most popular field combinations, we have limited the size; and it does not happen on Oracle.
If you introduce new combined indexes as part of some optimization, bear this in mind. The 900-byte limit is there.
