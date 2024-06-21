---
title: Business requirements
uid: app-business-requirements
description: "Business requirements for certifying standard applications."
author: Margrethe Romnes
date: 02.02.2022
keywords: certification, apps
topic: reference
envir: cloud
client: online
---

# Business requirements

Any application for SuperOffice CRM Online must indicate what it wants to achieve. Please adhere to these needs and expectations.

[Applications][1] need to add value rather than compete with SuperOffice CRM Online. You need a place to host, maintain, and develop your applications directly or via a partner of yours. Similarly, you also need to be a business in the position to invoice, collect, and support your customers or have a partner who does.

## General requirements

* All partners must register and outline their application concepts to get access to our [development environment][2] and APIs.
* All partners must agree with our general partnership agreement and sign the sub-data [processing agreement (DPA)][3].
* The application must have clear business value for the customer. It must be a business-oriented application that helps customers perform business processes.
* The application must be of high quality, safe, secure, and trustworthy.
* The application must have the necessary support and getting-started processes for customers.
* The application must be based on SaaS principles for pricing and billing.
* The application must be based on the Online Partner SDK.
  * We will not host any partner DLL assembly in the website's *bin* directory.
* The application must be a [standard application][4] that fits the many rather than customized to just one company *if you want to list it in the App Store*.

## Documentation

Proper product documentation will help the user help themselves.

### Requirements

* The application must have an **installation guide** available in at least 1 language if the user needs to set up something in SuperOffice CRM Online manually.
* If the application is supported outside Scandinavia, an English (or country-specific) version must be available.
* The application should have a **user guide** available in each supported language.
* On upgrade, the application must have a **release notes** document available.

### Guidance

The installation guide should contain a troubleshooting section to help customers, administrators, and consultants handle common issues.

Create screenshots, presentations, screencasts, or YouTube videos that we may link to from our App Store. During [provisioning][5], these may also be easily available for the administrator who sets up the solution.

## Support

Customers can get help from someone who can fix the problem.

### Requirement

* The add-on must have at least one assigned support resource.

### Guidance

We recommend using tracking software, for example, Customer Service, Trac, or Bugzilla, but it is not required.

<!-- Referenced links -->
[4]: ../index.md
[1]: ../../getting-started/index.md
[2]: ../../getting-started/app-envir.md
[5]: ../../provisioning/index.md
[3]: https://www.superoffice.com/trust-center/agreements/dpa/
