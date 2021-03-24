---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: start_certification       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Submit standard app for certification # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Submit standard app for certification

Your standard application is almost ready. Before we go live, we need to ensure that it can be safely distributed via the SuperOffice App Store and that you have given thought to the cybersecurity of your company and the information security of your application.

## Pre-requisites

* You have gone through the [certification checklist][1]
* You have appointed a designated certification contact who will be available during the test period

## Required info

* Name of application
* Client ID in our SOD environment
* Certification contact
* List of endpoints

## Relevant info

* Technology stack
* If using system user
* Data operations
* Public URLs to support and product pages
* Previous auditing experience
* Test cases and test documents
  * If you have been running heavy testing in our SOD environment, please include the date and time for these tests since we may go back and check logs for the last 30 days inside Application Insight.

## Process

1. [Submit a standard application for certification][2] (form).
2. Provide additional info and clarify questions while we run certification tests in SOD and Stage.
    * Respond to the reply email with any additional information
    * We may contact you or schedule a time for either a phone call or WebEx meeting
3. [Pass Watchcom security test][3].
4. Fix issues if necessary.

**Next step:** [publish application in CRM Online][4] environment.

<!-- Referenced links -->
[1]: checklist.md
[2]: https://community.superoffice.com/en/developer/create-apps/resources/start-application-certification/
[3]: secure-app.md
[4]: ../publish/publish-standard-app.md
