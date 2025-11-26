---
uid: online-development-introduction
title: Introduction to online development
description: Comprehensive guide to developing applications for SuperOffice CRM Online, covering environments, authentication, APIs, and best practices.
author: AnthonyYates
date: 15.10.2025
keywords: online development, SOD, SuperOffice Developer Portal, OAuth, REST API, SOAP API, app lifecycle
content_type: concept
deployment: online
platform: web
---

# Introduction to online development

## 1. Getting started with SuperOffice online development

Today, more businesses than ever rely on cloud solutions to stay flexible, connected, and efficient. SuperOffice CRM Online is at the heart of this shift—offering a robust platform for building tailored applications and integrations that meet unique business needs. Whether you’re creating a custom add-on for a single customer or launching a full-featured app for the App Store, everything starts at the SuperOffice Developer Portal.

In this article, we’ll guide you through the key steps of developing online for SuperOffice CRM Online. We’ll break down the environments, tools, and best practices you’ll need to go from idea to implementation—and help you avoid common roadblocks along the way.

---

## 2. Understanding the SuperOffice developer ecosystem

Think of the SuperOffice [Developer Portal][1] as your home base. It’s a self-service hub where you register apps, manage your organization users, monitor usage, and connect your application to real customers.

There are two main types of applications:

* [**Standard apps**][2] are published in the App Store and available to any customer.
* [**Custom apps**][3] are one-off solutions designed for a specific tenant.

You’ll usually work within a **partner organization**, where users can take on different roles by being assigned [specific permissions][4]:

* **Administrators** handle access and permissions.
* **Developers** build and maintain the applications.
* **Marketing** users create the content shown in the App Store.

Behind the scenes, SuperOffice staff also help guide apps through testing and launch.

---

## 3. Development environments explained

To keep things clean and safe, SuperOffice separates development from production with [three distinct environments][5]:

* **SOD (SuperOffice Online Development)** is your playground. It’s free to use and ideal for testing and experimenting.

* **Stage** simulates real-world conditions. Think of it as a dress rehearsal before your app goes live.

* **Production** is where your customers use your app. Only apps that pass review can operate here.

Each environment has its own credentials and tenants, so nothing you do in SOD can accidentally affect live customers.

---

## 4. Application lifecycle overview

Every SuperOffice app follows a clear path from start to finish:

1. [**Sign Up as a Developer**][6]

   * Create your account and partner profile.
   * You’ll get access to a test tenant in SOD.
   * This is a manual step internally and might take some time. An account confirmation email will be sent when the form is processed.

2. [**Register Your Application**][7]

   * Enter basic info like name and redirect URLs.
   * You’ll generate a client ID and secret.

3. **Build Your Application**

   * Use [SuperOffice APIs][12] to interact with CRM data.
   * Host your app on your own infrastructure.

4. **Test and Validate**

   * Use SOD to debug and refine.
   * Go through either [certification (standard apps)][10] or a simple [validation (custom apps)][11].

5. **Go Live**

   * [Standard apps][8] launch in the App Store.
   * [Custom apps][9] get activated for specific customers.

---

## 5. Registering your application

Before you can do much else, your app needs a digital identity. That's where app registration comes in.

### How to register an app

1. Make sure you have a [SuperOffice Developer Portal account][6].
2. Log in to [https://dev.superoffice.com][13] and navigate to your partner page.
3. On your partner page, click [**Create application**][7].
4. Using the wizard, fill out the basics:

   * App type
   * App name
   * Redirect (callback) URLs
   * Contact info (owner)

5. On the application configuration page, generate:

   * A **Client ID** (your app's ID)
   * A **Client Secret** (your app's password)

> [!NOTE]
> Make sure your redirect URLs match your actual hosted URLs—every detail counts!

Once registered, your app is ready for coding towards your **SOD tenant**.

---

## 6. Authentication and authorization

SuperOffice uses OAuth 2.0 and OpenID Connect for secure sign-ins. Every app must go through this flow to access CRM data. Check out [which flow is right][14] for your application.

### Here’s how it works

1. A user clicks to sign in from your app.
2. They’re redirected to our Identity provider, SuperID, to log in.
3. They grant permission for your app to access their data via their tenant web service endpoints.
4. Your app receives a short-lived **authorization code**.
5. That code is exchanged for an **access token** (and optional refresh token).

### Important tokens

* **Access Token**: Lets you talk to the API.
* **Refresh Token**: Gets a new access token without another login.
* **ID Token**: Proves who the user is (JWT format).

Storing these securely and knowing when to refresh them is key to a smooth user experience. Always encrypt sensitive data (even in the database) and use HTTPS for all communications.

---

## 7. Working with SuperOffice APIs

Once authenticated, your app can use SuperOffice APIs to interact with customer data.

### Choose your flavor

* [**REST API**][15] – Great for modern, lightweight integrations.
* [**SOAP API**][16] – More traditional, often used in .NET environments.

### What you can do

* Pull contact or company data
* Add appointments or sales
* Customize lists and fields
* and much more...

### Example (REST)

```http
GET https://{env}.superoffice.com/api/v1/contact/123
Authorization: Bearer {access_token}
```

For SOAP, you can use SuperOffice’s .NET libraries or roll your own proxy from WSDL files.

---

## 8. App configuration and hosting

You’re in charge of hosting your app — SuperOffice doesn’t run it for you. That means setting up your own environment (like Azure or AWS) and keeping it secure.

### What you’ll need

* A public-facing page to receive identity tokens
* HTTPS enabled with valid certificates
* High availability and solid uptime

Make sure your [redirect URLs][17] work before you start testing.

---

## 9. Testing and validation

Before your app goes live, it needs a check-up.

### Standard apps

* Go through [full certification][10].
* Includes a security review by Watchcom.

### Custom apps

* Quick [validation in SOD][11].
* Ensures everything runs smoothly and safely.

### What they’re looking for

* Token handling and security
* API call behavior
* Performance and stability

You’ll get a go/no-go in the Developer Portal when your app is ready for production.

> [!NOTE] All applications must be tested in SOD or a [production sandbox][26] before going live. This is a requirement for both standard and custom apps.

---

## 10. Publishing and deployment

Once you've passed testing, it's time to share your work.

### Standard apps

* Appear in the [SuperOffice App Store][19].
* Available to any customer.
* Requires ongoing maintenance and support.

### Custom apps

* Deployed privately to a single tenant.
* Perfect for specialized or internal use.

Track everything from the [**Tenant Manager**][20], including who’s using your app and where it’s installed.

---

## 11. Best practices for online development

Want your app to shine? Keep these best practices in mind:

* **Security first**: Always use HTTPS and sanitize inputs.
* **Don’t over-fetch**: Call only the APIs you need, and use [best practices][21].
* **Think long-term**: Write maintainable code and track versions.
* **Stay compliant**: Watch for changes in SuperOffice APIs in the [release notes][22].
* **Test early and often**: SOD is your friend—use it.

Good habits lead to happy users and fewer surprises down the line.

---

## 12. Resources and next steps

Ready to dive deeper? These links are your best friends:

* [Developer Portal Docs][1]
* [Online App Quickstart][23]
* [How to Register Your App][7]
* [Authentication Guide][24]
* [Join the Community][25]

Wherever you are in your development journey, the SuperOffice Developer Portal is here to help you build smart, secure, and scalable applications for the cloud.

<!-- Referenced links -->
[1]: ../../developer-portal/index.yml
[2]: ../../developer-portal/standard-app/index.md
[3]: ../../developer-portal/custom-app/index.md
[4]: ../../developer-portal/partner/manage-permissions.md
[5]: ../../developer-portal/getting-started/app-envir.md
[6]: https://dev.superoffice.com/register
[7]: ../../developer-portal/create-app/index.md
[8]: ../../developer-portal/standard-app/index.md
[9]: ../../developer-portal/custom-app/index.md
[10]: ../../developer-portal/standard-app/certification/index.md
[11]: ../../developer-portal/custom-app/validate.md
[12]: ../web-services/index.md
[13]: https://dev.superoffice.com
[14]: ../authentication/online/which-flow-to-use.md
[15]: ../web-services/endpoints/rest-webapi/index.md
[16]: ../web-services/endpoints/soap/index.md
[17]: ../../developer-portal/create-app/config/redirects.md
[18]: https://community.superoffice.com/en/forums
[19]: https://appstore.superoffice.com
[20]: ../../developer-portal/tenants/index.md
[21]: ../../developer-portal/best-practices/index.md
[22]: ../../../../release-notes/index.md
[23]: ../../developer-portal/getting-started/quickstart.md
[24]: ../authentication/online/index.md
[25]: https://community.superoffice.com
[26]: ../../online/sandbox/index.md

<!-- Referenced images -->
[img1]: media/online-app-development.png
