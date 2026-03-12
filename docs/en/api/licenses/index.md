---
title: Licenses
description: Overview of licenses.
author: xt1
date: 12.03.2026
keywords: License 
content_type: concept
---

# Licenses

When you buy a user plan, you are buying a set of licenses. Most of these licenses are hidden from the users view - they just pick a user-plan and go.
The code cannot deal with userplans - they change from version to version, and are re-packaged whenever mercury is in retrograde.

So the code deals with module licenses, not [user-plans][1]. [Module license names][2] are static and kept in [SoLicenseNames][2].

The pricelist will change - so we want to avoid hard-coding references to it into the application.
Instead of checking for a userplan identifier like "Sales-PREMIUM", we want to check for a feature identifier like "SALE-CAL", and have the license server handle the mapping between the pricelist and the features.

If the pricelist changes, we don't have to update all the checks - just update the license server.

## Visible vs Hidden licenses

The user sees a set of licenses in the admin panel, but the license server delivers a set of [hidden licenses][3] containing feature-specific licenses.

## CALs

In the olden days we sold CALs (Client Access Licenses) directly. To use the web client, you would buy a "user" CAL to login, a "web" CAL to use the web client, and then an "remote-travel" CAL to use another module. Administrators would tick off the boxes per user, and the feature would be activated for that user.

These days we follow the same principle. Feature licenses are split into two parts:

* `feature` - a system license to indicate that the feature is present and activated.
  Often a user without a CAL should still be able to view the feature in read-only mode.
* `feature-cal` - a user license to indicate that the user has edit rights on the feature.

The navigator will check if the `feature` system license is present.
The edit button will check if the `feature-cal` user license is on. If the user doesn't have it, the edit button will be disabled.
The admin client will check if the `feature` system license is present, and hide the corresponding admin page if missing.

## Sub-Features

Sometimes an existing feature will be split into pieces in order for parts to be sold as part of a premium package.

For example:

* `selection` - system license that controls the selection panel visibility.
* `selection-cal` - user license that controls selection edit button.
* `selection-combined-cal` - user license that controls access to creating combined selections.
  The "combined-cal" license was added later to .

Similarly new licenses for "escalate" , "inbox-filter", and "request-batch" were added to help differentiate the essential and premium layers of service user plans. The code checks for "escalate", not the user plan, so that we can easily change the licenses in a particular userplan without updating the client.

## Checking for Licenses

The [LicenseAgent.GetUserLicenses][4] Agent API and the [/api/v1/License/ownername/modulename][5] REST API support checking license status.

The `/api/v1/License/ownername/modulename` endpoint will tell you if the license exists or not, but will not tell you if the license is assigned to the user.

The current user principal will give you a list of the current user's assigned licenses:

[`GET User/currentPrincipal`][6] will return a list of licenses the current user has.



<!-- Referenced links-->
[1]: userplans.md
[2]: @SuperOffice.License.SoLicenseNames
[3]: hiddenlicenses.md
[4]: @v1LicenseAgent_GetUserLicenses
[5]: @v1License_GetThirdPartyLicenseAssignments
[6]: @v1User_GetCurrentPrincipal


<!-- Referenced images -->
[img1]: media\licenses-admin.png
