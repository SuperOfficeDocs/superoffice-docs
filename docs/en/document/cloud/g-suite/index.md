---
title: Google Workspace
uid: g_suite_document_integration
description: Google Workspace document integration
author: {github-id}
keywords:
topic: concept
---

# Google Workspace document integration

The Google Workspace Integration app integrates the Google Workspace’s document management features so that you can create, store, and find your documents within SuperOffice, and enjoy the benefits of both SuperOffice and Google Workspace services all in one place.

Simply sign in to SuperOffice using your Google Workspace login details and then open, edit, and store documents in Google Workspace directly from SuperOffice.

[View in App Store][2]

## Overview

Integrating SuperOffice CRM Online against Google Workspace enables the following functionality:

* Signing in to SuperOffice CRM Online with a Google Workspace-account.
* Using Google Drive to store documents and templates in the document archive.
* Using Google Drive to edit documents in the document-archive (if file-type is supported by Google Drive).
* This app is available for all SuperOffice CRM Online user plans.
* No support for 'Quote Details Templates', and 'Quotations templates' containing merge field `<<QuoteDetails>>`, when a document is to be stored in Google Drive.

## Components

The integration consists of four main components:

* SuperOffice CRM Online
* SuperOffice Federation Gateway (`http://superid.superoffice.com/`)
* Google Workspace subscription
* Google Workspace "Service account" with Google Drive

To ensure the security and integrity of the documents stored in Google Drive, SuperOffice will store all documents on a single Google Workspace Account (the service account and "owner" of the document archive).

While not required, SuperOffice recommends that a dedicated Google account is set up and used for this purpose.

For SuperOffice Online to be able to use Google Workspace for storage, SuperOffice must first be authorized to access data stored in the organization’s Google Drive.

The authorization process will grant rights to an app registered with Google Workspace called "SuperOffice". This is the SuperOffice Federation Gateway that handles secure communication between Google Workspace, SuperOffice Online, and other parties (like SuperOffice Mail Link).

Read the [technical description][7].

## What's the difference between a Google account and a Google Workspace account?

### What is Google Workspace?

Google Workspace is a set of Google applications that brings together essential services to help your business. This is a hosted service that lets businesses, schools, and institutions use a variety of Google products -- including Email, Google Docs, and Google Calendar - on a unique domain (`www.yourcompany.com`).

For instance, if you own the domain example.com and you sign up for Google Workspace services, everyone at your organization will get:

* A custom email address (user@example.com)
* Tools for word processing
* Spreadsheets and presentations
* A shared calendaring system
* Tools for creating web pages and sites for your business
* Access to a flexible intranet system
* And much, much more!

### How is a Google Account different from a Google Workspace account?

Although Google Workspace and Google Accounts allow you to access several of the same Google products, they're different types of accounts. A Google Account is a unified sign-in system that provides access to a variety of free Google consumer products - such as Gmail, Google Groups, Google Shopping List, Picasa, Web & App Activity, and Blogger - administered by Google. Google Workspace provides access to products powered by Google but administered by your organization.

### Not sure what kind of account you have?

If you’re able to [edit your account recovery options][3], then you have a Google Account. If you sign in to your account to the [account recovery options page][4] and receive a message with details to contact your administrator, then you have a Google Workspace account.

You may also check the domain name via Google Workspace Toolbox Dig (Google MX record lookup tool):

1. [Go to Dig][5].
2. Type in your domain.
3. Choose **MX**.
4. Identify if it includes "ANSWER" and what this answer redirects to. If the answer includes "Google" – you should be good to go!

## How to log in to CRM Online with Google authentication activated

1. Go to [online.SuperOffice.com][6].
2. Type in the email address, click **Next**.

* If your browser already has an active Google session - it will re-use this session to log you automatically in.
* If your browser has no active Google session - it will redirect you to Google for authentication before logging you into CRM Online.

The **Forgot password** feature is now handled by Google - since Google is activated as the authentication method for this site.

<!-- Referenced links -->
[2]: https://online.superoffice.com/AppStore/superoffice-as/g-suite-integration
[3]: https://www.google.com/accounts/UpdateAccountRecoveryOptions
[4]: http://www.google.com/accounts/UpdateAccountRecoveryOptions
[5]: https://toolbox.googleapps.com/apps/dig/
[6]: https://online.superoffice.com/
[7]: ../overview.md
