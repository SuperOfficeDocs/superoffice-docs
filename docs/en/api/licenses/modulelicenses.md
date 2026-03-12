---
title: Module Licenses
description: ModuleLicense details
author: xt1
date: 12.03.2026
keywords: License, modulelicense
content_type: concept
---

# Module Licenses

| field | description |
|-------|-------------|
| ModuleName | code name: the "user" part of "superoffice.user" |
| ModuleDescription | Display name - shown in admin |
| ModuleTooltip | tooltip shown in admin |
| ModuleVersion | product version license was issued to: "10.1" |
| LicenseType | system/site/user |
| NumberOfLicenses | quantity |
| Unrestricted | do we care if the number is exceeded or not |
| IsHidden | true/false - show the license in admin? |
| PrerequisiteModuleName | you must have this module on before you can activate this license. |
| ExtraInfo | licenses that are implied by this license. |
| ExtraFlags | 1 for user plans, 0 for everything else. |

Module licenses all have an owner - usually "SuperOffice" for us - but partners can define their own licenses, and run their own license servers.

Module license names are usually "superoffice.something", but the ModuleName is just "something".

The full list of licenses are in [SoLicenseNames][2].

This list is included in the webApi client package, and is used on the license server (via Nuget package) for consistency.

## Hidden

Modules that are hidden are not shown in the admin panel.
The licenses still exist and can be checked for, they just aren't visible in admin.

## Unrestricted

User and site licenses are usually restricted - in other words, admins are not allowed to assign more than the licensed number of licenses.

If the unrestricted flag is true, then there is no restriction, and the admin can assign as many as they want, even if the number of licenses is 1.

The `visible-for` license is unrestricted - since we do not charge extra for confidential appointments.

The `quote-cal` license is restricted, because we do charge extra for user access to quotes. Back when licenses were sold individually, you could buy 10 user licenses, and only 3 quote-cals. These days quote-cals are packaged into the user-plan, so the need for separately controllable licenses is 

## Prerequisites

In 7.x the licenses were sold loosely, so a web user required a user license in order to be activated.

| licenses | prereq |
|----------|---------|
| user     |          |
| web      | user    |
| windows  | user    |
| pocket-cal | user    |
| travel   |  user |
| remote-travel | travel |

Which would render in the user license panel as a series of nested checkboxes:

![Nested series of checkboxes][img3]

<!--
<input type="checkbox" name="user" checked /> User<br/>
&nbsp;&nbsp;&nbsp;&nbsp;<input type="checkbox" name="web" checked /> Web<br/>
&nbsp;&nbsp;&nbsp;&nbsp;<input type="checkbox" name="win" /> Windows <br/>
&nbsp;&nbsp;&nbsp;&nbsp;<input type="checkbox" name="mobr" checked /> Mobile <br/>
&nbsp;&nbsp;&nbsp;&nbsp;<input type="checkbox" name="trav" checked /> Travel <br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type="checkbox" name="travr" checked /> Remote Travel <br/>
-->

You could not enable the windows license without first checking the user license.

<!-- Referenced links-->
[1]: userplans.md
[2]: @SuperOffice.License.SoLicenseNames

[img3]: media\licenses-prereq.png
