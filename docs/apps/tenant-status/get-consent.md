---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: get_consent_for_tenant       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Obtain consent to access a customer's tenant # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Obtain consent to access a customer's tenant

Each customer is responsible for their data and must explicitly approve each and every application that shall have access to their database in the production environment.

External consultants **MAY NOT** approve access to a customer's production database!

1. Send the administrator to the authorization endpoint and [authenticate the user][1].

2. The administrator clicks **I approve**. The dialog shows your application name, your company name, and other information relevant to the [consent][2].

    ![Consent][img1]

3. Provision the application.

<!-- Referenced links -->
[1]: ../../authentication/auth-user.md
[2]: ../provisioning/index.md

<!-- Referenced images -->
[img1]: media/superid_approve.png
