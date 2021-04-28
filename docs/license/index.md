---
title: changes_7_licensing
description: Changes in SuperOffice 7 - Licensing
author: {github-id}
keywords: database
so.topic: reference
so.envir:             # cloud or onsite
so.client:                    # online, web, win, pocket, or mobile
---

# Licensing

The license system has its own set of tables

* [ModuleOwner][1] – an issuer of licenses.
  * Initially only one row (SuperOffice)
  * Contains global expiration dates
* [ModuleLicense][2] – one row per license
  * More than you see, some licenses are hidden from the GUI
  * Several types: System, site, associate; on/off or a defined number of licenses

## License assignment

[LicenseAssocLink][3] – assigns one particular `moduleLicense` to a certain associate. That is how John becomes a User and a Windows client user; this would be 2 records.

The sum of licenses assigned to any particular module is limited to the number in `moduleLicense`.
A new license set from SuperLicense will not be accepted if more than the acquired number is already assigned.

## License signing

Licenses are signed using public/private keys.

The private key is a closely guarded secret and without it, you cannot make a keycode generator.

Individual `moduleLicense` rows are also signed and all rows are also hash-checked to make tampering harder.

**Summary:** You touch them, they stop working. SoAdmin / NetServer can edit them, no-one else.
Hackers can hack the DLLs, but not make a keycode generator that works with un-hacked code.

<!-- Referenced links -->
[1]: ../../../database/docs/tables/ModuleOwner.md
[2]: ../../../database/docs/tables/ModuleLicense.md
[3]: ../../../database/docs/tables/LicenseAssocLink.md
