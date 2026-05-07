---
uid: teams-security
title: Permissions and security in SuperOffice for Teams
description: Microsoft Graph permissions requested by SuperOffice for Teams and how they are used.
keywords: SuperOffice for Teams, Teams, permissions, security, Microsoft Graph, privacy
author:
date: 07.05.2026
version:
content_type: reference
category: integration
topic: SuperOffice for Teams
language: en
---

# Permissions and security

SuperOffice for Teams requests a limited set of Microsoft Graph permissions, following the principle of least privilege. All permissions are **delegated**, meaning the app cannot access data autonomously – it only acts on behalf of the signed-in user.

## Permissions requested

| Permission | Purpose |
|---|---|
| Read names and descriptions of channels | Identify which channels are available to archive from. |
| Read channel members | Identify participants to match against SuperOffice contacts. |
| Read channel messages | Retrieve messages for archiving. |
| Read chat messages | Retrieve chat messages for archiving. |
| Read files the user can access | Retrieve files shared in channels for archiving. |
| Read items in site collections | Access SharePoint-backed channel file storage. |
| Read basic user profiles | Display participant names in the archive form. |

These permissions are maintained and validated by Microsoft.

<!-- Referenced links -->