---
title: minimal_php_app_overview       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Example PHP application # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Example PHP application

Building online PHP applications for SuperOffice CRM Online is not only possible: leveraging a useful library such as `nusoap` makes it simple and effective too.

## Objectives

* Demonstrate federated authentication and application approval by an administrative user
* Demonstrate JWT/SAML token signature verification
* Demonstrate provisioning tasks, such as creating web panels, and list items
* Demonstrate exchanging system user token for a system user ticket
* Demonstrate tenant web service invocation using a system user ticket

## Application overview

The first time the application is visited, the user will be redirected to `sod.superoffice.com/login` to sign in to SuperID. Upon successful sign-in, SuperID will redirect the user to the application's redirect URL (`https://localhost/php/index.php`).

*Index.php* displays several links, giving the application the opportunity to provision various types of items, as well as create a new company using the signed in admin user, or a system user.

![x][img1]

Selecting to create a new company, regardless of the option to use the logged in or system user, and upon successfully creating a new company, the application will redirect to the *contactEntity.php* page and display the results.

![x][img2]

## System user lifetime

A [system user token][1] is unique for each application authorization in a tenant and will remain the same for the lifetime of the application.

A **system user ticket** is only good for a short period of time. Therefore, your application must expect to operate as demonstrated for batch operations. When communicating with a tenant on a periodic basis, you must obtain a new system user ticket before accessing the tenant web services again.

## JWT and SAML signature verification

Every application in production must demonstrate their application validates the token upon each successful login to SuperID within the application's callback location.

Each application must also validate each token received by SuperId when exchanging a system user token for a system user ticket. These types of checks are tested when certifying an application.

## Public key certificates

The host running this example must have the [public certificates installed][2] for this example to work.

<!-- Referenced links -->
[1]: ../../authentication/online/system-user/system-user-token.md
[2]: ../../authentication/online/certificates/configure.md

<!-- Referenced images -->
[img1]: media/image001.png
[img2]: media/image003.png
