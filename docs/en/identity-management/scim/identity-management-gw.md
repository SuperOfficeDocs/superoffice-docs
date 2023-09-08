---
title: The Identity Management Gateway
uid: identity_management_gw
description: The Identity Management Gateway Architecture, User interface, and Pre-requisites
author:
keywords: Identity, Management, Gateway, Architecture, SuperID, 
so.topic: reference
so.date:
so.envir:  cloud
so.client: online
---

# The Identity Management Gateway

A rules wizard where the administrator can configure rules for how Azure AD users shall be configured in SuperOffice.

The **Identity Manager Gateway** is a SCIM connector between Azure AD and SuperOffice CRM Online. The user interface aka the SCIM configuration tool is simply called the **Identity Manager**.

## Architecture

![SCIM flow -screenshot][img1]

## User interface

The Identity Manager is a clean, web-based user interface for SCIM identity management. It has 2 tabs: configurations and preview.

### Configurations tab

* **User Sync Rules** pane - the rules wizard
* **SCIM users** pane - a list of users that **can** be synchronized
* **Preview** pane - details for the currently selected user

![SCIM UI configurations tab -screenshot][img2]

### Preview tab

* Number of available Azure AD users
* Number of users synchronized to SuperOffice
* Name and username of each Azure AD user and the access control-related settings that will be applied to each of them given the current ruleset

![SCIM UI preview tab -screenshot][img3]

### Other settings

* User Sync Active (on/off)
* Send Welcome Email (on/off)
* Notifications Email for critical errors (email address)

## Pre-requisites

To access the Identity Manager, you will need:

* **Tenant** configured with **SuperID** - register to [get a developer account in SOD][1]
* A SuperOffice admin account for that tenant linked to an Azure AD account (AAD admin not required)

<!-- Referenced links -->
[1]: ../../developer-portal/getting-started/get-access-to-sod.md

<!-- Referenced images-->
[img1]: media/scim-flow-ui.png
[img2]: media/scim-config-tab.png
[img3]: media/scim-preview-tab.png
