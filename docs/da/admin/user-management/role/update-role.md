---
uid: help-da-role-edit
title: Opdater rolle
description: Sådan redigerer du en rolle.
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
redirect_from: 
  - /da/admin/user-management/learn/role/editing-role
  - /da/admin/user-management/learn/role/deleting-role
language: da
---

# Opdater rolle

[!include[Requirement](../includes/note-anon-req.md)]

Hvis du vil opdatere eller slette en [rolle][3], skal du starte med at vælge rollen under fanen **Medarbejdere** eller **Eksterne**.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Vælg fanen **Medarbejdere** eller **Ekstern** .

    [Sådan redigerer du rollen for anonyme brugere.][1]

1. Dobbeltklik på den rolle du vil redigere, på listen.

## Redigering af en rolle

1. I dialogboksen **Opret ny rolle** skal du ændre navnet på og beskrivelsen af rollen efter behov og derefter klikke på **Gem**.

1. [Rediger rollens rettigheder.][4]

1. Hvis du redigerer roller til medarbejdere: Gå til fanen **Funktionelle rettigheder** og rediger rollens funktionelle rettigheder.

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    Ændringerne gemmes automatisk.

## Sletning af en rolle

Når du sletter en rolle, skal du flytte brugerne med denne rolle til en anden rolle. Du bør derfor sikre dig, at brugerne har den korrekte adgang i den rolle, du flytter dem til.

> [!NOTE]
> Du kan ikke slette rollen for anonyme brugere eller systembrugeren (**Brugerniveau 0**).
>
> **Du kan ikke fortryde sletningen af en rolle.**

1. Med rollen valgt, klik på **Slet**.

    Er knappen Slet deaktiveret (udtonet)? Det er ikke muligt at slette den rolle, du selv tilhører. Hvis der kun er én fane tilbage, kan du ikke slette den.

1. I dialogboksen **Slet rolle** skal du klikke på <i class="ph ph-caret-down" aria-label="Chevron"></i> ud for feltet **Tildel alle brugere med denne rolle til** og vælge en anden rolle for brugerne af den rolle du vil slette.

1. Klik på **Slet**.

    Rollen fjernes fra listen.

<!-- Referenced links -->
[1]: ../onsite/other-users.md#rights
[3]: index.md
[4]: set-data-rights-for-role.md
