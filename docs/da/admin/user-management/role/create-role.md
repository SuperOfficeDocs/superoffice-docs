---
uid: help-da-role-create
title: Oprettelse af rolle
description: Oprettelse af rolle
keywords: rolle, brugerstyring
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /da/admin/user-management/learn/role/create-role
language: da
---

# Oprettelse af en rolle

[!include[Requirement](../includes/note-anon-req.md)]

1. [!include[Open Roles](../includes/open-roles.md)]

1. Vælg en af følgende faner:

    * **Medarbejdere**: Her kan du tilføje roller til ansatte i firmaet.
    * **Eksternt**:  Her kan du tilføje roller til eksterne brugere (kun onsite).

    > [!NOTE]
    > Der findes kun én rolle til anonyme brugere, og du kan ikke oprette nye. Se [Redigering af rettigheder for anonyme brugere][8].

1. Klik på **Tilføj** under listen.

1. Angiv i dialogboksen **Opret ny rolle** et navn på rollen i feltet **Rollenavn**.

1. Angiv en beskrivelse af rollen i feltet **Beskrivelse**.

1. Vælg en af følgende valgmuligheder:

    * Klik på <i class="ph ph-caret-down" aria-label="Chevron"></i> ved siden af feltet **Kopier rettigheder fra**, og vælg den rolle, du ønsker at basere den nye rolle på.
    * Klik på <i class="ph ph-caret-down" aria-label="Chevron"></i>, og vælg **Start med tomme rettigheder**, hvis du vil oprette rollen fra bunden.

1. Klik på **Gem**. Den nye rolle vises på listen **Roller**.

1. Klik på rollenavnet på listen for at få vist rettighederne for rollen under fanen **Datarettigheder**.

1. [Angiv datarettighederne under fanen **Datarettigheder**][7].

1. Hvis du opretter roller til medarbejdere: Klik på fanen **Funktionelle rettigheder**.

    Under denne fane kan du bestemme, hvilke funktioner som skal være tilgængelige for rollen, for eksempel brevfletning, udgivelse, eksport af udvalg og administratoradgang i Indstillinger og vedligeholdelse.

    > [!TIP]
    > Hold musemarkøren over en rettighed for at få vist yderligere oplysninger om denne.

1. Angiv rollens [funktionelle rettigheder][6]:

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    Ændringerne gemmes automatisk.

## Relateret indhold

* [Tilføjelse af brugere][5]
* [Redigering af roller][4]

<!-- Referenced links -->
[4]: update-role.md
[5]: ../add-associate.md
[6]: functional-rights.md
[7]: set-data-rights-for-role.md
[8]: ../onsite/other-users.md#rights
