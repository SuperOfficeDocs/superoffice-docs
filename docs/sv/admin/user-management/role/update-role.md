---
uid: help-sv-role-edit
title: Uppdatera roll
description: Så redigerar du en roll.
keywords: roll, administrera användare
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: 
  - /sv/admin/user-management/learn/role/editing-role
  - /sv/admin/user-management/learn/role/deleting-role
language: sv
---

# Uppdatera roll

[!include[Requirement](../includes/note-anon-req.md)]

För att uppdatera eller ta bort en [roll][3] börjar du med att välja rollen på fliken **Medarbetare** eller **Externa**.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Gå till fliken **Medarbetare** eller **Externa**.

    [Så redigerar du rollen för anonyma användare.][1]

1. I listan, dubbelklicka på den roll du vill redigera.

## Redigera en roll

1. Ändra rollens namn och beskrivning i dialogrutan **Skapa ny roll** och klicka sedan på **Spara**.

1. [Redigera rollens rättigheter.][4]

1. Om du redigerar roller för medarbetare: Gå till fliken **Funktionella behörigheter** och redigera rollens funktionella behörigheter.

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    Ändringarna sparas automatiskt.

## Ta bort en roll

När du tar bort en roll måste du flytta de användare som har rollen till en annan roll. Därför måste du se till att användarna har rätt åtkomst i den roll du flyttar dem till.

> [!NOTE]
> Du kan inte ta bort rollen för anonyma användare eller systemanvändarrollen (**Användarnivå 0**).
>
> **Borttagningen av en roll kan inte ångras.**

1. Med rollen markerat, klicka på **Ta bort**.

    * Varför är knappen Ta bort inaktiverad (grå)? Rollen du själv tillhör kan inte tas bort. Om det bara finns en roll kan du inte ta bort den.

1. Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> bredvid fältet **Flytta alla användare med denna roll till** i dialogrutan **Ta bort roll** och välj en annan roll för de användare som tillhör rollen du vill ta bort.

1. Klicka på **Ta bort**.

    * Rollen tas bort från listan.

<!-- Referenced links -->
[1]: ../onsite/other-users.md#rights
[3]: index.md
[4]: set-data-rights-for-role.md
