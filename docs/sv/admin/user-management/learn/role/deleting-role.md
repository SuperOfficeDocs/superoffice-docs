---
uid: help-sv-deleting-role
title: Ta bort en roll
description: Ta bort en roll
keywords: administrera användare, roll
author: Bergfrid Dias
date: 02.25.2025
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Ta bort en roll

[!include[Requirement](../includes/note-anon-req.md)]

När du tar bort en roll måste du flytta de användare som har rollen till en annan roll. Därför måste du se till att användarna har rätt åtkomst i den roll du flyttar dem till.

## Steg

1. [!include[Open Roles](includes/open-roles.md)]

2. Gå till fliken **Medarbetare** eller **Externa**.

    > [!NOTE]
    > Du kan inte ta bort rollen för anonyma användare.

3. Markera önskad roll i listan **Roller**.

4. Klicka på **Ta bort**.

    Varför är knappen Ta bort inaktiverad (grå)? Rollen du själv tillhör eller rollen systemanvändare (**Användarnivå 0**) kan inte tas bort. Om det bara finns en roll kan du inte ta bort den.

5. Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> bredvid fältet **Flytta alla användare med denna roll till** i dialogrutan **Ta bort roll** och välj en annan roll för de användare som tillhör rollen du vill ta bort.

6. Klicka på **Ta bort**. Rollen tas bort från listan. Borttagningen av en roll kan inte ångras.
