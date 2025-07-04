---
title: User provisioning
uid: user_provisioning
description: User provisioning
author: SuperOffice Product and Engineering
date: 01.15.2024
keywords: IDP, SCIM, Microsoft Entra, ME-ID, AAD
content_type: concept
deployment: online
platform: web
index: true
---

# User provisioning

User provisioning is an important identity management process for handling information about users in multiple applications and systems.

> [!NOTE]
> When we talk about user provisioning, we refer to the data **object representing a person** and not the physical person. It is also distinct from [application provisioning][1].

The user data object generally consist of:

* A unique ID
* Sign-in credentials
* The person's name (or some other description)
* The person's contact information

**Access control** is then to link this account (object) to resources through a set of **policies**. Large organizations commonly use **groups** to simplify this linking.

## What is user provisioning and de-provisioning?

User provisioning centralizes the management of the user data object and pushes updates to other systems and applications that also need to know about the person the object represents. De-provisioning is the process of removing the user from the subscribed systems - for example when an employee leaves a company.

Microsoft Entra ID (formerly Azure Active Directory) is one such centralized system.

## What are the benefits?

In short, user provisioning and de-provisioning make identity management easier, faster, and safer.

### Increase productivity of admins

IT professionals, identity managers, and HR benefit from being able to register a person in a single application rather than having to manually create a user account in each application this person needs access to. You'd want to give a new hire access to all the applications they need to do their job as soon as possible. And you want accurate information in all systems.

Not only does user provisioning streamline the onboarding process, but think about the cascade of updates necessary when the person changes department, the person marries and requests a name change, the person gets a new cell phone number, the person gets a new employee ID after a corporate mergers and acquisitions scenario.

User de-provisioning gives the admins a one-stop kill-switch for when they need to revoke access and remove the user from the applications.

### Comply with laws and regulations

Many countries have strong governance for identity management. For example, GDPR.

User provisioning gives you a **centralized record** for situations such as:

* The user exercises the right to access personal data and the right to correct information.

* The person leaves the company and you no longer have a legal basis to store the information.

* Your company is being audited.

### Strengthen security and reduce the risk of errors

The more users and applications your organization has, the greater is the risk of introducing errors by manually creating, updating, and deleting users in each application. Not only trivial errors such as misspelling a person's middle name but errors that lead to the disclosure of highly sensitive information.

## How does it work in SuperOffice?

> [!NOTE]
> To be able to sign in to SuperOffice, a person needs an active user account and a valid license.

A user data object can enter the SuperOffice sphere in the following ways:

* [Add user manually][2] in Admin client.

* Add the user in Admin client referring to UPN of the identity provider.

* [Provision user from Microsoft Entra ID via SCIM][3].

## When user is deleted

What happens when a user is being deleted by upstream source (Entra ID) or user license is set to (No Selection) by rules.

* When user license is set to (No Selection) by rules we remove the user's license and set both "IsPersonRetired" and "Deleted" flags,

* When a user is deleted from Microsoft Entra ID: [After you delete a user, the account remains in a suspended state for 30 days](https://learn.microsoft.com/en-us/entra/fundamentals/users-restore). When this happens Entra ID sends update on the user to our SCIM API which sets "active" property on the user to "false". For these users SCIM sets license to (No Selection) no matter what license is assigned by matching rules.

* After 30 days user is deleted in Entra ID and it sends DELETE command to SCIM API. When this happens SCIM API executes NetServer's `DeleteUser` API.

<!-- Referenced links -->
[1]: ../../developer-portal/provisioning/index.md
[2]: ../user/add-user-in-admin-client.md
[3]: overview.md
