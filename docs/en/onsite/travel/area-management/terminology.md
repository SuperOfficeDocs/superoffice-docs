---
uid: area_management_terminology
title: terminology
description: Area Management definitions
author: SuperOffice Product and Engineering
keywords:
date:
content_type: concept
deployment: onsite
platform: win
---

# Terminology

To fully understand how Area Management works, you should read the definitions below. The fields can be found in the dialog boxes Area Management and Area Definition.

* **Defined Areas:** Displays the name of the area that is defined.

* **Area Name:** The name of an area. The area defines both data selection and sign-on access rights. These do not necessarily cover the same employees.

* **Available associates:** Lists all users who are defined as employees in the Users panel in the Admin client.

* **Included associates:** Names of all users who are included in the area.

* **Include all data in Area (no filtering):** If ticked the Available associates and Included associates listbox are removed and all data from the central database will be available in the area. Note - changing this requires that you generate a new prototype, this change is not replicated.

* **Oldest follow-up(days):** You can set a limit on the age of follow-ups you want in the Travel Area. The limit is specified in days and is applied during prototype generation. It only affects follow-ups (of all types) and documents. 0 means "no age limit".

* **Encryption of replicated data:** Should the up/dwn files be encrypted.

* **Enable freetext:** Should the area have free-text search enabled.

**Local DB Type:** If the area is used as a satellite, what is the default database type for travel.

**Available associates:** Lists all users who can be assigned login access rights.

**Assigned associates:** Displays the users who have login access rights to the area. A user can only have sign-on rights to one area at a time.
