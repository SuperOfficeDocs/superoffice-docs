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

So the code deals with module licenses, not [user-plans][1]. Module license names are static and kept in [SoLicenseNames][2].

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

The [LicenseAgent.GetUserLicenses][4] Agent API and the REST API [/api/v1/License/ownername/modulename][5] support checking license status.

The `/api/v1/License/ownername/modulename` endpoint will tell you if the license exists or not, but will not tell you if the license is assigned to the user. It is therefore mostly useful for checking for global system licenses like `sale`, `project` or `quote`, not user-specific licenses like `sale-cal` or `quote-cal`.

The current user principal will give you a list of the current user's assigned licenses:

[`GET User/currentPrincipal`][6] will return a list of licenses the current user has.

```json
{
  "UserType": "InternalAssociate",
  "Associate": "HugoBoss",
  "AssociateId": 3456,
  "IsPerson": true,
  "PersonId": 321,
  "CountryId": 578,
  "HomeCountryId": 578,
  "ContactId": 3,
  "GroupId": 10,
  "ContactOwner": 1234,
  "RoleId": 50331659,
  "RoleName": "Standard",
  "RoleType": "Employee",
  "Licenses": [
    {
      "OwnerName": "SUPEROFFICE",
      "OwnerDescription": "SuperOffice AS",
      "Name": "server",
      "Description": "SuperOffice Server",
      "Version": "11.11",
      "LicenseType": "SiteLicense",
      "ExtraFlags": 0,
      "ExtraInfo": "",
      "LicenseNumber": 1,
      "IsHidden": true,
      "IsUnrestricted": false,
      "ExpiryDate": "2026-06-11T00:00:00",
    },
    {
      "OwnerName": "SUPEROFFICE",
      "OwnerDescription": "SuperOffice AS",
      "Name": "guide-cal",
      "Description": "Guides",
      "Version": "11.11",
      "LicenseType": "UserLicense",
      "ExtraFlags": 0,
      "ExtraInfo": "",
      "LicenseNumber": 1600,
      "IsHidden": true,
      "IsUnrestricted": false,
      "ExpiryDate": "2026-06-11T00:00:00",
    },
    {
      "OwnerName": "SUPEROFFICE",
      "OwnerDescription": "SuperOffice AS",
      "Name": "ten-salesservicemarketing",
      "Description": "SalesPremiumServicePremiumMarketingPremium",
      "Version": "11.11",
      "LicenseType": "UserLicense",
      "ExtraFlags": 1,
      "ExtraInfo": "set=user,web,pocket-crm-cal,selection-cal,relation-cal,report-cal,project-cal,guide-cal,saint-cal,selection-combined-cal,mail-merge-cal,chat-cal,forms-cal,ej-client,t2,dash-cal,sale-cal,target-cal,quote-cal,stakeholder-cal,ej-mod-spm-cal,mktg-auto-cal",
      "LicenseNumber": 700,
      "IsHidden": false,
      "IsUnrestricted": false,
      "ExpiryDate": "2026-06-11T00:00:00",
    },
  ...
```

So from this we can see we have a `superoffice.server` site license, and the current user has been assigned a `superoffice.guide-cal` user license, courtesy of their `superoffice.ten-salesservicemarketing` user-plan license.
Note that user-licenses that are not assigned to the user do not appear in the payload - so if you want to know if the license exists use the `/api/v1/License/ownername/modulename` endpoint to check.

The currentPricipal also has useful information like the role function-rights.


<!-- Referenced links-->
[1]: userplans.md
[2]: @SuperOffice.License.SoLicenseNames
[3]: hiddenlicenses.md
[4]: @v1LicenseAgent_GetUserLicenses
[5]: @v1License_GetThirdPartyLicenseAssignments
[6]: @v1User_GetCurrentPrincipal


<!-- Referenced images -->
[img1]: media\licenses-admin.png
