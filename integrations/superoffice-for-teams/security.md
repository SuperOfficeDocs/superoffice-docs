---
uid: teams-security
title: Permissions and security in SuperOffice for Teams
description: Microsoft Graph permissions requested by SuperOffice for Teams and how they are used.
keywords: SuperOffice for Teams, Teams, permissions, security, Microsoft Graph, privacy
author: schildea
date: 07.05.2026
content_type: reference
category: integration
topic: SuperOffice for Teams
language: en
---

# Permissions and security in SuperOffice for Teams

SuperOffice for Teams requests a limited set of Microsoft Graph permissions, following the principle of least privilege. Permissions are delegated, which means SuperOffice for Teams cannot access data autonomously. The app only asks for the minimum access it needs:

* Read names and descriptions of channels.
* Read channel members.
* Read channel messages.
* Read chat messages.
* Read files the user can access.
* Read items in site collections.
* Read basic user profiles.

These permissions are maintained and validated by Microsoft.

<!-- Referenced links -->