---
uid: license-user-plans
title: How user plans are constructed
description: How user plans are put together from module licenses.
author: xt1
date: 04.20.2026
version: 11.12
keywords: license, user plan
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# User plans in version 10-11

User plans come in two tiers: Essential and Premium
User plans come in three flavors: Sales, Service and Marketing. Flavors can be combined.

So at its simplest we get the *Sales-Essential* user.
At the most complex we get the *Sales-Premium-Service-Premium-Marketing-Premium* user.

## Sales-Essential user

If this is all we have, we get issued the following licenses:

| name | type | description |
|------|------|-----------|
| `server` | system | Required for system to work. |
| `user` | user | to log in |
| `web` | user |to log in to web |
| `pocket-crm-cal` |user | to log in to mobile |
| `visible-for` |user | to allow users to use confidential appointments |
| `import` | system |enables the import functionality in admin |
| `dash` | system |enables the dashboard functionality |
| `document` | system |enables document creation/editing |
| `selection` |system | enables selection panel |
| `relation` |system | enables relations archive |
| `relation-cal` | user |allows user to create/edit relations |
| `sale` | system |enables the sales panel |
| `sale-cal`|user | allows user to create/edit sales |
| `sales-t1` | system |marker to indicate sales-essentials |
| `ten-sales` | user | user plan license, defines which user licenses are enabled for the user |

The CAL licenses are per-user licenses - they must be assigned to a specific user in order to work.
The user-plan license is flagged with `ExtraFlag` = 1, and [ExtraInfo = list of user licenses to activate][2].

The licenses that are automatically enabled by the user-plan are [hidden][1], so they don't appear in the license panel.

## User plans in version 8-9

User plans come in one tier.
User plans come in five flavors: Sales, Service, Marketing, and Complete, plus a reduced Standard CRM User.

### Standard CRM user

| name | type | description |
|------|------|-------------|
| `server` | system | Required for system to work. |
| `user` | user | to log in |
| `web` | user |to log in to web |
| `pocket-crm-cal` |user | to log in to mobile |
| `visible-for` |user | to allow users to use confidential appointments |
| `import` | system |enables the import functionality in admin |
| `dash` | system |enables the dashboard functionality |
| `document` | system |enables document creation/editing |
| `selection` |system | enables selection panel |
| `selection-cal` |user | allows user to create/edit selections |
| `selection-combined-cal` |user | enables combination selection type for user |
| `relation` |system | enables relations archive |
| `relation-cal` | user |allows user to create/edit relations |
| `project` | system |enables the project panel |
| `project-cal`|user | allows user to create/edit projects |
| `mail-merge-cal` | user |enables basic mail-merge functionality |
| `sales-t1` | system |marker to indicate sales-essentials |
| `superlicense-contact-manager` | user | user plan license, defines which user licenses are enabled for the user |

Again, the user plan license has [extra flags = 1][2], and a list of licenses to enable automatically stored in extra info.

Note that this user-plan includes projects, but the sales-essential user-plan does not. Projects are a premium feature in the 10-11 user-plans.
Standard CRM user does not have sales access, but the sales-essential user-plan does.

So checking for the user-plan means more work when the pricelist changes.
Checking the module licenses means everything just keeps working as before.


## User plans in version 6 and 7

User plans did not exist. 
Licenses were sold individually and you could mix and match.

You could buy 10 user licenses, 7 web licenses, 5 windows licenses, and let some users log in via web, some via windows app, and two lucky people could do both.

Back then we didn't have so many module licenses, so life was a little easier.

| name | type | description |
|------|------|-------------|
| `server` | system | Required for system to work. |
| `user` | user | to log in |
| `web` | user |to log in to web |
| `pocket-crm-server` |system | to enable mobile |
| `pocket-crm-cal` |user | to log in to mobile |
| `visible-for` |user | to allow users to use confidential appointments |

These user licenses would be manually enabled for each user in admin.

![Nested series of checkboxes][img3]

<!-- References -->
[1]: hidden-licenses.md
[2]: module-licenses.md

[img3]: ../../../../media/loc/en/admin/licenses-prereq.png
