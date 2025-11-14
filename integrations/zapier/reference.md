---
uid: zapier-reference
title: SuperOffice triggers and actions
description: Overview of SuperOffice triggers and actions supported by Zapier. List of Zap templates.
keywords: Zap trigger, Zap action, Zap template, Slack, Google Sheets, Google Drive, Dropbox, Trello, Asana, Eventbrite, SurveyMonkey, JotForm, Wufoo
author: miguellemos95, PhilipYates
date: 11.06.2025
content_type: reference
category: integration
topic: Zapier
platform: Zapier
language: en
redirect_from: /en/automation/zapier/reference
---

# Supported SuperOffice triggers and actions

## Triggers

Supported triggers and the events in SuperOffice CRM Online that cause them to be called.

| Trigger | Called when |
|---|---|
| **New** | |
| [New Appointment][1] | A new appointment is created in SuperOffice. |
| [New Company][1] | A new company is created in SuperOffice. |
| [New Contact][1] | A new contact is created in SuperOffice. |
| [New Document][1] | A new document is created in SuperOffice. |
| [New Project Member][1] | A new project member is created in SuperOffice. |
| [New Project][1] | A new project is created in SuperOffice. |
| [New Request][1] | A new request is created in SuperOffice. |
| [New Sale][1] | A new sale is created in SuperOffice. |
| **Changed** | |
| [Appointment Changed][9] | An appointment in SuperOffice is updated. |
| [Company Changed][9] | A company in SuperOffice is updated. |
| [Contact Changed][9] | A contact in SuperOffice is updated. |
| [Document Changed][9] | A document in SuperOffice is updated. |
| [Project Changed][9]| A project in SuperOffice is updated. |
| [Project Member Changed][9] | A project member in SuperOffice is updated. |
| [Sale Changed][9] | A sale in SuperOffice is updated (edited, sold, lost, completed). |

## Actions

Supported actions and the effect they have on SuperOffice CRM Online when run.

| Action | Result |
|---|---|
| **Create** | |
| [Create appointment][16] | Creates a new appointment in SuperOffice. |
| [Create company][17] | Creates a new company in SuperOffice. |
| [Create contact][18] | Creates a new contact in SuperOffice. |
| [Create document][19] | Creates a new document in SuperOffice. |
| [Create project member][20] | Creates a new project member in an existing project in SuperOffice. |
| [Create project][21] | Creates a new project in SuperOffice. |
| [Create request message attachment][22] | Creates a new request message attachment in SuperOffice in an existing request message. |
| [Create request message][23] | Creates a new request message in an existing request. |
| [Create request][24] | Creates a new request in SuperOffice. |
| [Create sale][25] | Creates a new sale in SuperOffice. |
| **Remove** | |
| [Remove project member][26] | Removes a project member from an existing project in SuperOffice. |
| **Search** | |
| [Find Company][27] | Searches for a company with specified criteria in SuperOffice. |
| [Find Contact][28] | Searches for a contact with specified criteria in SuperOffice. |
| [Find project][29] | Searches for a project with specified criteria in SuperOffice. |
| [Find request][30] | Searches for a request with specified criteria in SuperOffice. |
| [Find Sale][31] | Searches for a sale with specified criteria in SuperOffice. |
| **Update** | |
| [Update appointment][32] | Updates an existing appointment in SuperOffice. |
| [Update company][33] | Updates an existing company in SuperOffice. |
| [Update contact][34] | Updates an existing contact in SuperOffice. |
| [Update document content][35] | Updates content in an existing document in SuperOffice. |
| [Update project][36] | Updates an existing project in SuperOffice. |
| [Update request][37] | Updates an existing request in SuperOffice. |
| [Update sale][38] | Updates an existing sale in SuperOffice. |

## Zap templates

Zap templates are ready-made Zaps to use as-is or amend to fit a particular workflow.

### Slack

* Inform a team in **Slack** (action) whenever a sales lead is created (trigger).

* When you close a new sale (trigger), share the good news with a team in **Slack** (action).

### Sync

* Keep **Google sheets** up to date (action) when new leads come in (trigger).

* Keep **Google sheets** up to date (action) with a new sale information (trigger).

* Keep SuperOffice (trigger) and **Google Drive** (action) in sync automatically.

* Keep **Google Drive** (trigger) and SuperOffice (action) in sync automatically.

* Add new documents in **DropBox** (trigger) to SuperOffice (action).

* Keep   **Autopilot** database up to date (action) when new contacts are created in SuperOffice (trigger)

### Productivity

* Stay on top of **Trello** board projects (action) when new companies are created in SuperOffice (trigger)

* Create a new **Trello** board (action) when new sales are created in SuperOffice (trigger)

* Create a new **Trello** card (action) when new sales are created in SuperOffice (trigger)

* Stay on top of all projects by syncing SuperOffice (action) and **Asana** (trigger).

### Marketing

* When you lose a sale (trigger), find out why via **SurveyMonkey** (action).

* Capture new contacts in SuperOffice (action) when new **Eventbrite** attendees sign up (trigger)

* Capture new contacts in SuperOffice (action) when forms are submitted using **Wufoo** (trigger)

* Capture new contacts in SuperOffice (action) when forms are submitted using **JotForm** (trigger)

* Set time aside automatically (action) whenever someone reaches out on **Facebook** (trigger).

* Add new leads from **Facebook Lead AS** (trigger) as new contacts in SuperOffice (action).

<!-- Referenced links -->
[1]: howto/triggers/new.md
[9]: howto/triggers/changed.md
[16]: howto/actions/create-appointment.md
[17]: howto/actions/create-company.md
[18]: howto/actions/create-contact.md
[19]: howto/actions/create-document.md
[20]: howto/actions/create-project-member.md
[21]: howto/actions/create-project.md
[22]: howto/actions/create-request-message-attachment.md
[23]: howto/actions/create-request-message.md
[24]: howto/actions/create-request.md
[25]: howto/actions/create-sale.md
[26]: howto/actions/remove-project-member.md
[27]: howto/actions/search-company.md
[28]: howto/actions/search-contact.md
[29]: howto/actions/search-project.md
[30]: howto/actions/search-request.md
[31]: howto/actions/search-sale.md
[32]: howto/actions/update-appointment.md
[33]: howto/actions/update-company.md
[34]: howto/actions/update-contact.md
[35]: howto/actions/update-document-content.md
[36]: howto/actions/update-project.md
[37]: howto/actions/update-request.md
[38]: howto/actions/update-sale.md
