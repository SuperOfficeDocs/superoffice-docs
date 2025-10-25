---
uid: help-sv-role-create
title: Skapa roll
description: Skapa roll
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
redirect_from: /sv/admin/user-management/learn/role/create-role
language: sv
---

# Skapa en roll

[!include[Requirement](../includes/note-anon-req.md)]

1. [!include[Open Roles](../includes/open-roles.md)]

1. Välj någon av följande flikar:

    * **Medarbetare**: Här kan du lägga till roller för anställda vid ditt företag.
    * **Externt**:  Här kan du lägga till roller för externa användare (endast lokalt).

    > [!NOTE]
    > Det finns bara en roll för anonyma användare och du kan inte skapa nya. Se [Redigera behörigheter för anonyma användare][8].

1. Klicka på **Lägg till** under listan.

1. Ange ett namn på rollen i fältet **Rollnamn** i dialogrutan **Skapa ny roll**.

1. Ange en beskrivning av rollen i fältet **Beskrivning**.

1. Välj ett av följande alternativ:

    * Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> bredvid rutan **Kopiera behörigheter från** och välj den roll som den nya rollen ska baseras på.
    * Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> och välj **Starta med tomma behörigheter** om du vill skapa rollen från början.

1. Klicka på **Spara**. Den nya rollen visas i listan **Roller**.

1. Klicka på rollnamnet i listan så visas behörigheterna för rollen på fliken **Databehörigheter**.

1. [Ange databehörigheter på fliken **Databehörigheter**][7].

1. Om du skapar roller för medarbetare: Klicka på fliken **Funktionella behörigheter**.

    Här kan du bestämma vilka funktioner som ska vara tillgängliga för rollen, till exempel dokumentkoppling, publicering, export av urval och administratörsbehörighet under Inställningar och underhåll.

    > [!TIP]
    > Håll muspekaren över en behörighet om du vill visa mer information om den.

1. Definiera rollens [funktionella behörigheter][6]:

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    Ändringarna sparas automatiskt.

## Relaterat innhåll

* [Lägga till användare][5]
* [Redigera roller][4]

<!-- Referenced links -->
[4]: update-role.md
[5]: ../add-associate.md
[6]: functional-rights.md
[7]: set-data-rights-for-role.md
[8]: ../onsite/other-users.md#rights
