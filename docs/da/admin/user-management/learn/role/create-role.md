---
uid: help-da-role-create
title: Oprettelse af rolle
description: Oprettelse af rolle
keywords: rolle, brugerstyring
author: Bergfrid Dias
date: 02.28.2025
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Oprettelse af en rolle

[!include[Requirement](../includes/note-anon-req.md)]

1. [!include[Open Roles](includes/open-roles.md)]

2. Vælg en af følgende faner:

    * **Medarbejdere**: Her kan du tilføje roller til ansatte i firmaet.
    * **Eksternt**:  Her kan du tilføje roller til eksterne brugere (kun onsite).

    > [!NOTE]
    > Der findes kun én rolle til anonyme brugere, og du kan ikke oprette nye. Se [Redigering af rettigheder for anonyme brugere][5].

3. Klik på **Tilføj** under listen.

4. Angiv i dialogboksen **Opret ny rolle** et navn på rollen i feltet **Rollenavn**.

5. Angiv en beskrivelse af rollen i feltet **Beskrivelse**.

6. Vælg en af følgende valgmuligheder:

    * Klik på <i class="ph ph-caret-down" aria-label="Chevron"></i> ved siden af feltet **Kopier rettigheder fra**, og vælg den rolle, du ønsker at basere den nye rolle på.
    * Klik på <i class="ph ph-caret-down" aria-label="Chevron"></i>, og vælg **Start med tomme rettigheder**, hvis du vil oprette rollen fra bunden.

7. Klik på **Gem**. Den nye rolle vises på listen **Roller**.

8. Klik på rollenavnet på listen for at få vist rettighederne for rollen under fanen **Datarettigheder**.

9. [Angiv datarettighederne under fanen **Datarettigheder**][7].

10. Hvis du opretter roller til medarbejdere: Klik på fanen **Funktionelle rettigheder**.

    Under denne fane kan du bestemme, hvilke funktioner som skal være tilgængelige for rollen, for eksempel brevfletning, udgivelse, eksport af udvalg og administratoradgang i Indstillinger og vedligeholdelse.

    > [!TIP]
    > Hold musemarkøren over en rettighed for at få vist yderligere oplysninger om denne.

11. Angiv rollens [funktionelle rettigheder][6]:

    [!include[How to set functional rights](includes/add-remove-right.md)]

    Ændringerne gemmes automatisk.

## Relateret indhold

* [Tilføjelse af brugere][5]
* [Redigering af roller][4]

<!-- Referenced links -->
[4]: editing-role.md
[5]: ../add-associate.md
[6]: functional-rights.md
[7]: set-data-rights-for-role.md
