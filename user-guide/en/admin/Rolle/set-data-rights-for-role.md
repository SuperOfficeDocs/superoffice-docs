---
uid: help-en-set-data-rights-for-role
title: Set data rights for role
description: Set data rights for role
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Set data rights for a role

> [!NOTE]
> Some functions in this topic require a separate licence (external users and anonymous users). See [Licences](../chap03/Licences-screen.md).

You can set rights for <!-- Fix reuse ID=a1 -->(companies, contacts, projects, project members, selections, sales, follow-ups, documents, e-mails, mailings and relations) based on who owns the object. All users who belong to this role will be assigned <!-- Fix reuse ID=a6 -->(none, read, create, update and delete) based on the settings you make here.

To set data rights for a role:

1. Click the **Roles** button in the Navigator (![icon](../media/Knapp-rolle-liten.bmp)).
2. Choose the **Associates** tab or the **External** tab (![icon](../OnPremises.png)).  
    ![icon](../media/question.bmp) <!-- Fix reuse ID=a2 -->
    See [Edit rights for anonymous users](Edit-rights-for-anonymous-users.md).
3. Select the required role in the **Roles** list. The rights for the selected role are displayed in the **Data rights** tab.
4. Click the arrow (![icon](../media/pil-ned.bmp) ) next to the right you want to change, and select the required right.  
    ![icon](../media/question.bmp) <!-- Fix reuse ID=a3 -->  
    ![icon](../media/question.bmp) <!-- Fix reuse ID=a4 -->

    Data owned by
    Explanation

    \* Associates

    \*\* External

    You can choose from these rights:

    | Name | Rights | Tooltips |
    |---|---|---|
    | None | No rights | |
    | Read | Read rights | R |
    | Create | Read and create rights | CR |
    | Update | Read, create and update rights | CRU |
    | Delete | Read, create, update and delete rights | CRUD |

    **C** = Create, **R** = Read, **U** = Update, **D** = Delete

The changes are saved automatically.

![icon](../media/question.bmp) <!-- Fix reuse ID=a5 -->

If the data objects (companies, projects, documents and so on) are to be made accessible to external users (Audience users), it is not enough just to assign the external users read (or higher) access. The data objects must also be published in SuperOffice CRM.
