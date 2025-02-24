---
uid: help-sv-role-create
title: Skapa roll
description: Skapa roll
keywords: roll, administrera användare
author: Bergfrid Dias
date: 02.25.2025
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Skapa en roll

[!include[Requirement](../includes/note-anon-req.md)]

1. [!include[Open Roles](includes/open-roles.md)]

2. Välj någon av följande flikar:

    * **Medarbetare**: Här kan du lägga till roller för anställda vid ditt företag.
    * **Externt**:  Här kan du lägga till roller för externa användare (endast lokalt).

    > [!NOTE]
    > Det finns bara en roll för anonyma användare och du kan inte skapa nya. Se [Redigera behörigheter för anonyma användare][5].

3. Klicka på **Lägg till** under listan.

4. Ange ett namn på rollen i fältet **Rollnamn** i dialogrutan **Skapa ny roll**.

5. Ange en beskrivning av rollen i fältet **Beskrivning**.

6. Välj ett av följande alternativ:

    * Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> bredvid rutan **Kopiera behörigheter från** och välj den roll som den nya rollen ska baseras på.
    * Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> och välj **Starta med tomma behörigheter** om du vill skapa rollen från början.

7. Klicka på **Spara**. Den nya rollen visas i listan **Roller**.

8. Klicka på rollnamnet i listan så visas behörigheterna för rollen på fliken **Databehörigheter**.

9. [Ange databehörigheter på fliken **Databehörigheter**][7].

10. Om du skapar roller för medarbetare: Klicka på fliken **Funktionella behörigheter**.

    Här kan du bestämma vilka funktioner som ska vara tillgängliga för rollen, till exempel dokumentkoppling, publicering, export av urval och administratörsbehörighet under Inställningar och underhåll.

    > [!TIP]
    > Håll muspekaren över en behörighet om du vill visa mer information om den.

11. Definiera rollens [funktionella behörigheter][6]:

    [!include[How to set functional rights](includes/add-remove-right.md)]

    Ändringarna sparas automatiskt.

## Vad vill du göra nu?

* [Lägga till användare][5]
* [Redigera roller][4]

<!-- Referenced links -->
[4]: editing-role.md
[5]: ../add-associate.md
[6]: functional-rights.md
[7]: set-data-rights-for-role.md
