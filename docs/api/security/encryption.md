---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: changes_7_encryption       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Changes in SuperOffice 7 - Encryption # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Encryption

We used to have license info in the company and associate tables; password in associate; and diverse and sundry hashes and checks
The hashes remain, but with different contents

License has moved; password has moved; associate encrypted fields are gone.

Our custom encryption algorithms are gone, we now use the operating system and standard methods

Hashing/checksums are dictionary-controlled

The idea behind hashing is simple. As long as you write through NetServer, it will create a checksum when doing insert/update, and check it during a select. If the checksum does not match during select, then the row is refused.  The NetServer code can be picky about who it allows to be the caller during updates, thereby limiting callers to be the authorized SuperOffice clients.

The Windows code does the same thing – set hash on write, check hash on read.

If you tamper with the contents of hashed rows, that will cause them to "disappear"; they will be in the database, but our code will reject them.

We use hashing to protect critical data, such as licensing and access control.
