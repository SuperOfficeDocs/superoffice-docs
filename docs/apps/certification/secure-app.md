---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: secure_app   # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Pass Watchcom initial security evaluation # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id} # Your GitHub alias.
keywords:
so.topic: guide  # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud   # cloud or onsite
so.client: online   # online, web, win, pocket, or mobile
---

# Pass Watchcom initial security evaluation

The Watchcom security evaluation is a mandatory part of our certification program.

## Pre-requisites

* You have [submitted your standard application for certification][1].
* Your designated certification contact must be available during the test period.
* We have screened your application and approved it for our staging environment (`qaonline.superoffice.com`).

We may send you multiple sets of keys at the same time. You will **not** be able to connect using the production keys until you pass the security evaluation and we explicitly activate them!

## Workflow

1. We send you the [application keys][2] for both [stage and production][3].

2. You set up the application in stage and **make sure that it still works**.

3. Your certification contact notifies us that you are ready to proceed.

4. We run a quick verification to confirm that you are ready for Watchcom.

5. We prepare a _Handover_ document and send it to Watchcom. It explains:

    * what does the application add?
    * how does the application work with SuperOffice?

6. Our Watchcom contact will get in touch with your certification contact to schedule a date and time for testing. [Read more about the test scope][4].

7. After the test, you get the full report from Watchcom while we only receive a pass/fail notification. **It is your responsibility to fix any red flags!**

8. When approved, we activate the application's keys to the production environment.

9. You can now set up the application in production and connect to test that it works. **The application is still not published!**

**Next steps:** [get listed in the App Store][5] and [publish your application][6]

<!-- Referenced links -->
[1]: certify-app.md
[2]: ../client-id-secret.md
[3]: ../getting-started/app-envir.md
[4]: initial-watchcom-eval.md
[5]: ../get-listed.md
[6]: ../publish-standard-app.md