---
title: Developer Portal
uid: developer-portal-overview
description: Introduction to the SuperOffice Online Developer Portal.
keywords: developer, Developer Portal, apps, app-store, navigation
author: AnthonyYates, Bergfrid Dias
date: 07.07.2026
version: 2.0
version_devportal: 2.15
content_type: concept
---

# Developer Portal

The [SuperOffice Developer Portal][6] contains a set of self-serve tools that developers can use to manage their access to SuperOffice Online APIs.

![SuperOffice Developer Portal start page for a partner -screenshot][img1]

In the portal, you have the opportunity to:

* Register and manage your SuperOffice Apps, and the authentication keys and tokens that they use.
* Manage your endpoint access requirements and integrations integration services endpoints.
* Learn more about different endpoints and features available.
* Explore API metrics, exceptions, and failed requests for your apps.
* With elevated privileges within your organization, you can manage users and their Developer Portal access.

> [!NOTE]
> The Developer Portal handles the application workflows. However, communication between you and SuperOffice goes through Service.

## How the portal is organized

The Developer Portal has three main areas:

* The Top bar
* The Navigator (left side)
* The content area

### The Top bar

![SuperOffice Developer Portal Top bar -screenshot][img2]

The Top bar (green with the SuperOffice logo) is always present and gives you quick access to:

* A list of all your apps — across every partner you have access to
* Your partner page
* SuperOffice Docs
* The forums on our Help Center and Community
* The personal menu, where you access your profile and can sign out

### The Navigator

The Navigator lets you move between the main sections of your partner and app pages. The items depend on the context:

![SuperOffice Developer Portal Navigator partner -screenshot][img3]
![SuperOffice Developer Portal Navigator application -screenshot][img4]

Clicking a section opens it in the content area.

> [!TIP]
> Click the chevrons to collapse and expand the navigator.

![SuperOffice Developer Portal Navigator expand/collapse -screenshot][img7]

### The content area

The content area is where you view and update information. Some pages have one or more labelled groups. For example, compare the **Application Settings** below with the **Partner Overview** at the top of this page.

![SuperOffice Developer Portal application settings -screenshot][img5]

Other pages have subsections with their own navigator.

> [!NOTE]
> When you click **Save Settings** it applies to all changes on the page, across all subsections. The scope is determined by the left-most Navigator.

## Key areas and concepts

When you sign in to the Developer Portal, you either represent SuperOffice or a third-party organization hereafter referred to as **a partner**. SuperOffice is responsible for the SuperOffice CRM Online service and the partner is responsible for creating apps customizing the core service.

### Application

[!include[Application defined](includes/def-app.md)]

[!include[Standard vs. custom apps](includes/std-vs-custom-app.md)]

Each partner's applications are listed in the **Applications** section of the partner Navigator, where you also find the **Create App** button. The **Apps** menu in the Top bar lists all applications across every partner you have access to.

[Learn more about applications][3]

### Partner

A partner may own and/or develop applications.

> [!NOTE]
> A partner's applications are listed in the **Applications** section of the partner Navigator, shown as tiles. If there are more than eight applications by a partner, you'll instead see a list that can be filtered and grouped.

Anyone may [register as a CRM Online developer][1] and the first person who register for a new company will trigger the creation of a partner.

You see only the partners you belong to. If you have a role in multiple partners, you choose one as your current context.

A partner can have users with different roles:

| Role | Description |
|---|---|
| Administrator | Manages own users and their permissions |
| Developer | Develops apps and configures everything related to security for those apps |
| Marketing | Manages content shown in the App Store |

> [!NOTE]
> SuperOffice employees also have different roles, such as the App Manager and Online Operations.

### User

[!include[ALT](includes/def-dp-user.md)]

The first person (user) assigned to a partner is commonly the administrator of that partner inside the portal. The administrator can add additional users.

### Settings

Both partners and applications have settings. These are essential information such as name and contact persons.

### Configuration

Each application has a configuration, including client ID and secret, certificates, redirection URLs, and endpoints. The initial configuration is added when you [register the application][4]. You can update and test the configuration in SOD and when you are ready, request approval to go live.

### App Store information

Both partners and standard applications have App Store information. This is your partner profile page
and one or more app-specific product pages shown in the SuperOffice App Store.

If your company develops custom applications only, you can ignore the **App Store information** section. Likewise, this section is hidden on the app page of all custom apps.

The **App Store information** section is visible only if your partner account has created at least one standard application.
If no standard application exists, the section will not appear in the portal. This ensures that App Store configuration is shown only when it is relevant and actionable.

Compare a partner with no standard applications, where **App Store information** is hidden from the Navigator, with a partner that has at least one standard application, where the section is shown:

![Partner Overview without standard applications, App Store information hidden from the Navigator -screenshot][img8]
![Partner Overview with standard applications, App Store information shown in the Navigator -screenshot][img9]

[Read more about App Store information.][5]

### Environments: SOD, Stage, Production

[!include[Introduction to application environments, SOD, stage, production](includes/app-envir-intro.md)]

[Read more about the different environments.][2]

## Ready to get access?

You can get started using the SuperOffice Online API by [signing up for a developer account][1].

Watch the walk-through on YouTube:

<!-- markdownlint-disable-next-line MD034 MD007 -->
> [!Video https://www.youtube-nocookie.com/embed/One6P5Jm5l0]

<!-- Referenced links -->
[1]: getting-started/get-access-to-sod.md
[2]: getting-started/app-envir.md
[3]: index.yml
[4]: create-app/index.md
[5]: standard-app/app-store/app-store-info.md
[6]: https://dev.superoffice.com/

<!-- Referenced images -->
[img1]: media/partner-overview.png
[img2]: media/top-bar.png
[img3]: media/nav-partner.png
[img4]: media/nav-app.png
[img5]: media/app-settings.png
[img7]: media/nav-expand-collapse.png
[img8]: media/partner-overview-no-standard-apps.png
[img9]: media/partner-overview-with-standard-apps.png
