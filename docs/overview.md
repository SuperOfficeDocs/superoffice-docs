---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: overview       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Introduction to SuperOffice CRM Online development # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: article              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud        # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Introduction to SuperOffice CRM Online development

SuperOffice CRM Online has great extensibility points that allow vendors to create complimentary applications in and around SuperOffice.

While a great standalone CRM solution, SuperOffice becomes better with complimentary applications.

When creating an application for SuperOffice CRM Online, there are several key elements that all partners must understand. Explore our documentation to learn about security, authentication, validation, development environment, provisioning, and application models.

Partners building applications for SuperOffice CRM Online must be comfortable with **federated authentication**. All applications must use **SuperID** for authenticating users.

![soap-onboarding.jpg][img1]

To develop applications in our SOD environment is free. Required licenses apply only in production (live).

## SuperOffice CRM Online web client at a glance

* An online platform serving thousands of customers
* Distributed and federated platform service
* Client-side JavaScript
* CRM integrations limited to web panels and database access
* Customer Service integrations can be almost everything you want

## Deploying your application

Your new standard or custom application has been developed and tested and is now ready to be put to work.

### Deploy standard application

![stdapp-publishing.jpg][img2]

### Deploy custom application

![custapp-publishing.jpg][img3]

<!-- Referenced images -->
[img1]: media/soap-onboarding.jpg
[img2]: https://community.superoffice.com/globalassets/developer-club/soap/stdapp-publishing.jpg
[img3]: https://community.superoffice.com/globalassets/developer-club/soap/custapp-publishing.jpg