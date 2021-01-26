---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: changes_7_licensing       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Changes in SuperOffice 7 - Licensing # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Licensing

The license system has its own set of tables

* [ModuleOwner][1] – an issuer of licenses.
  * Initially only one row (SuperOffice).
  * Contains global expiration dates
* [ModuleLicense][2] – one row per license
  * More than you see, some licenses are hidden from the GUI
  * Several types: System, site, associate; on/off or a defined number of licenses

## License assignment

[LicenseAssocLink][3] – assigns one particular moduleLicense to a certain associate. That is how Marekv becomes a User and a Windows client user; this would be two records

The sum of licenses assigned of any particular module is limited to the number in moduleLicense.
A new license set from SuperLicense will not be accepted, if more than the acquired number is already assigned.

## License signing

Licenses are signed using public/private keys.

The private key is a closely guarded secret and without it, you cannot make a keycode generator.

Individual moduleLicense rows are also signed and all rows are also hash-checked to make tampering harder.

**Summary:** You touch them, they stop working. SoAdmin / NetServer can edit them, no-one else.
Hackers can hack the DLLs, but not make a keycode generator that works with unhacked code

<!-- Referenced links -->
[1]: ../../tables/ModuleOwner.md
[2]: ../../tables/ModuleLicense.md
[3]: ../../tables/LicenseAssocLink.md
