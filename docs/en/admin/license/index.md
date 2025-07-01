---
title: Licensing
uid: licensing
description: SuperOffice license system
author: Christian Mogensen
date: 08.20.2021
keywords: database
content_type: concept
---

# Licensing

The license system has its own set of database tables:

* [ModuleOwner][1] – an issuer of licenses
  * Initially only one row (SuperOffice).
  * Contains global expiration dates.

* [ModuleLicense][2] – one row per license
  * More than you see, some licenses are hidden from the GUI.
  * Several types: System, site, associate; on/off or a defined number of licenses.
  * Visible licenses (like user plans) show in the Admin UI. User plans have `ExtraFlags = 1`.
  * Hidden licenses (like the **user** log-in right, or the **web** web-client license) don't show in the UI but are
    checked in the code to verify that a feature is available to a given user.

## System licenses

ModuleLicense rows with type = 1 (System) define what features are available on the system.

For example, ModuleLicense **saint** is present if the system has Sales Intelligence enabled. The license is hidden since it is not on the price list. It is a feature enabled implicitly, so it is hidden.

The SuperOffice client code will check for the presence of the license, and turn on SAINT features if the license is present.

## Site licenses

Site licenses (ModuleLicense.Type=2) are not used as much anymore. In the olden days, when we had satellites, some licenses could be assigned to sites, rather than being available everywhere.

## User licenses

User licenses (ModuleLicense.Type=3) are licenses that can be assigned to users. The number of assignments cannot exceed the number of licenses available.

User licenses can also be hidden. This reduces the complexity of the user interface. Hidden licenses are activated by a user plan.

User-plans have the ModuleLicense.ExtraFlags = 1 - they also define the implied licenses in the ExtraInfo field: `"set=user,web,chat-cal"` tells the license system to also assign the **user**, **web**, and **chat-cal** licenses when the user-plan is assigned to the user.

## User-license assignment

[LicenseAssocLink][3] – assigns one particular `moduleLicense` to a certain associate. That is how John becomes a User and a Windows client user; this would be 2 records.

The sum of licenses assigned to any particular module is limited to the number in `moduleLicense`. A new license set from SuperLicense will not be accepted if more than the acquired number is already assigned.

## License signing

Licenses are signed using public/private keys.

The private key is a closely guarded secret and without it, you cannot make a keycode generator.

Individual `moduleLicense` rows are also signed and all rows are also hash-checked to make tampering harder.

**Summary:** You touch them, they stop working. SoAdmin and NetServer can edit them, no one else.
Hackers can hack the DLLs, but not make a keycode generator that works with un-hacked code.

## Counting Users

There are two approaches:

### 1: Get the license and read the number of user or web licenses

Users must have both **user** and **web** to log in to the SuperOffice web application. This number is the upper bound. It does not tell you how many are in use.

For some customers, the number of licenses is huge, because they are paying by use, using SCIM. To handle this, count the number of user licenses in use, rather than the total number of licenses available.

### 2: Get the license and sum the number of ExtraFlags=1 licenses in use

User plans are what the user is paying for. They define multiple implied, hidden licenses.

The same SCIM caveat applies: count the number of user plans in use, rather than the total number available.

<!-- Referenced links -->
[1]: ../../database/tables/ModuleOwner.md
[2]: ../../database/tables/ModuleLicense.md
[3]: ../../database/tables/LicenseAssocLink.md
