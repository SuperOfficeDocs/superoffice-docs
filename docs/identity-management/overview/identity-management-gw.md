---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: identity_management_gw       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:  The Identity Management Gateway Architecture, User interface and Pre-requisites                # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {frodeb@superoffice.com}             # Your GitHub alias.
keywords: Identity, Management, Gateway, Architecture, SuperId, 
so.topic:               reference        # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir:                     cloud
so.client:                    online
---

# The Identity Management Gateway

A rules wizard where the administrator can configure rules for how Azure AD users shall be configured in SuperOffice.

The **Identity Manager Gateway** is a SCIM connector between Azure AD and SuperOffice CRM Online. The user interface aka the SCIM configuration tool is simply called the **Identity Manager**.

## Architecture

![SCIM flow][img1]

## User interface

The Identity Manager is a clean, web-based user interface for SCIM identity management. It has 2 tabs: configurations and preview.

### Configurations tab

* **User Sync Rules** pane - the rules wizard  
* **SCIM users** pane - a list of users that _can_ be synchronized
* **Preview** pane - details for the currently selected user

![SCIM UI configurations tab][img2]

### Preview tab

* Number of available Azure AD users
* Number of users synchronized to SuperOffice
* Name and username of each Azure AD user and the access-control related settings that will be applied to each of them given the current ruleset

![SCIM UI preview tab][img3]

### Other settings

* User Sync Active (on/off)
* Send Welcome Email (on/off)
* Notifications Email for critical errors (email address)

## Pre-requisites

To access the Identity Manager, you will need:

* **Tenant** configured with **SuperID** \- register to [get a developer account in SOD][1]
* A SuperOffice admin account for that tenant linked to an Azure AD account (AAD admin not required)

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/developer/create-apps/how-to/set-up/get-access-to-sod/

<!-- Referenced images-->
[img1]: \media\scim-flow-ui.png
[img2]: \media\scim-config-tab.png
[img3]: \media\scim-preview-tab.png