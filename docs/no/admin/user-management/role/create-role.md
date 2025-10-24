---
uid: help-no-role-create
title: Opprette rolle
description: Opprette rolle
keywords: rolle, brukeradministrasjon
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /no/admin/user-management/learn/role/create-role
language: no
---

# Opprett en rolle

[!include[Requirement](../includes/note-anon-req.md)]

1. [!include[Open Roles](../includes/open-roles.md)]

1. Velg en av følgende faner:

    * **Medarbeidere**: Her kan du legge til roller for ansatte i bedriften din.
    * **Ekstern**:  Her kan du legge til roller for eksterne brukere (bare onsite).

    > [!NOTE]
    > Det finnes bare én rolle for anonyme brukere, og du kan ikke opprette nye. Se [Redigere rettigheter for anonyme brukere][8].

1. Klikk på **Legg til** under listen.

1. I dialogboksen **Opprett ny rolle** skriver du inn et navn for rollen i feltet **Rollenavn**.

1. Angi en beskrivelse av rollen i feltet **Beskrivelse**.

1. Velg ett av følgende alternativer:

    * Klikk på <i class="ph ph-caret-down" aria-label="Chevron"></i> ved siden av boksen **Kopier rettigheter fra**, og velg deretter rollen du ønsker å basere den nye rollen på.
    * Klikk på <i class="ph ph-caret-down" aria-label="Chevron"></i>, og velg deretter **Start med tomme rettigheter** hvis du vil opprette rollen fra bunnen av.

1. Klikk på **Lagre**. Den nye rollen vises i listen **Roller**.

1. Klikk på rollenavnet i listen for å vise rettighetene for rollen i fanen **Datarettigheter**.

1. [Angi datarettighetene i fanen **Datarettigheter**][7].

1. Hvis du oppretter roller for medarbeidere: Klikk på fanen **Funksjonelle rettigheter**.

    I denne fanen kan du bestemme hvilke funksjoner som skal være tilgjengelige for rollen, for eksempel brevfletting, publisering, eksport av utvalg og administratortilgang i Innstillinger og vedlikehold.

    > [!TIP]
    > Hold musepekeren over en rettighet for å vise mer informasjon om den.

1. Angi rollens [funksjonelle rettigheter][6]:

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    Endringene lagres automatisk.

## Relatert innhold

* [Legge til brukere][5]
* [Redigere roller][4]

<!-- Referenced links -->
[4]: update-role.md
[5]: ../add-associate.md
[6]: functional-rights.md
[7]: set-data-rights-for-role.md
[8]: ../onsite/other-users.md#rights
