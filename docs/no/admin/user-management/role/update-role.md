---
uid: help-no-role-edit
title: Oppdatere rolle
description: Slik redigerer du en rolle.
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
redirect_from: 
  - /no/admin/user-management/learn/role/editing-role
  - /no/admin/user-management/learn/role/deleting-role
language: no
---

# Oppdatere rolle

[!include[Requirement](../includes/note-anon-req.md)]

For å oppdatere eller slette en [rolle][3], må du først velge rollen i fanen **Medarbeidere** eller **Eksterne**.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Velg fanen **Medarbeidere** eller **Eksterne**.

    [Slik redigerer du rollen for anonyme brukere.][1]

1. I listen, dobbeltklikk på rollen du ønsker å redigere.

## Redigere en rolle

1. I dialogboksen **Opprett ny rolle** gjør du ønskede endringer i navnet og beskrivelsen til rollen, og deretter klikker du på **Lagre**.

1. [Rediger eventuelt rettighetene til rollen.][4]

1. Hvis du redigerer roller for medarbeidere: Gå eventuelt til fanen **Funksjonelle rettigheter**, og rediger de funksjonelle rettighetene til rollen.

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    Endringene lagres automatisk.

## Slette en rolle

Når du sletter en rolle, må du flytte brukerne som har rollen du sletter, til en annen rolle. Du bør derfor være sikker på at brukerne får riktig tilgang i rollen du flytter dem til.

> [!NOTE]
> Du kan ikke slette rollen for anonyme brukere eller systembrukeren (**Brukernivå 0**).
>
> **Du kan ikke angre slettingen av en rolle.**

1. Med rollen markert, klikk på **Slett**.

    Er Slett-knappen deaktivert (grå)? Det er ikke mulig å slette rollen man selv tilhører. Hvis det er bare én rolle, kan du ikke slette den.

1. I dialogboksen **Slett rolle** klikker du på <i class="ph ph-caret-down" aria-label="Chevron"></i> ved siden av feltet **Flytt alle brukere med denne rollen til**, og deretter velger du en annen rolle for brukeren med rollen du vil slette.

1. Klikk på **Slett**.

    * Rollen fjernes fra listen.

<!-- Referenced links -->
[1]: ../onsite/other-users.md#rights
[3]: index.md
[4]: set-data-rights-for-role.md
