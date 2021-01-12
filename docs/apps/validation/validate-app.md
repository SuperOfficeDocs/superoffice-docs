---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: validate_app       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Get your custom app validated # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Get your custom app validated

Your custom application is almost ready. Before we go live, we need to ensure that it can be safely activated in SuperOffice CRM Online.

**Pre-requisites:**

* Redirect URL is secure
* You have gone through the [validation checklist][1]
* You have appointed a designated technical contact who will be available during the validation test period

**Required info:**

* Name of the application
* Client ID in our SOD environment
* Technical contact
* Description of what the application does

**Relevant info:**

* Technology stack
* If using system user
* Test cases and test documents
  * If you have been running heavy testing in our SOD environment, please include the date and time for these tests since we may go back and check logs for the last 30 days inside Application Insight.

**Process:**

1. [Submit a custom application for validation][3] (form).
2. Provide additional info and clarify questions while we run the validation test in SOD.
    * Respond to the reply email with any additional information
    * We may contact you or schedule a time for either a phone call or WebEx meeting
3. Fix issues if necessary.

**Next step:** [activate the custom application][2].

<!-- Referenced links -->
[1]: checklist.md
[2]: ../activate-custom-app.md
[3]: https://community.superoffice.com/en/developer/create-apps/resources/start-application-validation/
