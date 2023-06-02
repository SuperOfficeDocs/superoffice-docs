---
uid: help-no-deleting-role
title: Slette en rolle
description: Slette en rolle
author: Bergfrid Dias
so.date: 03.15.2023
keywords: brukeradministrasjon, rolle
so.topic: howto
so.user: admin
language: no
---

# Slette en rolle

[!include[Requirement](../includes/note-anon-req.md)]

Når du sletter en rolle, må du flytte brukerne som har rollen du sletter, til en annen rolle. Du bør derfor være sikker på at brukerne får riktig tilgang i rollen du flytter dem til.

## Trinn

1. [!include[Open Roles](includes/open-roles.md)]

2. Velg fanen **Medarbeidere** eller **Eksterne**.

    > [!NOTE]
    > Du kan ikke slette rollen for anonyme brukere.

3. Merk ønsket rolle i listen **Roller**.

4. Klikk på **Slett**.

    Er Slett-knappen deaktivert (grå)? Det er ikke mulig å slette rollen man selv tilhører, eller systembrukerrollen (**Brukernivå 0**). Hvis det er bare én rolle, kan du ikke slette den.

5. I dialogboksen **Slett rolle** klikker du på ![ikon][img3] pilen ved siden av feltet **Flytt alle brukere med denne rollen til**, og deretter velger du en annen rolle for brukeren med rollen du vil slette.

6. Klikk på **Slett**. Rollen fjernes fra listen. Du kan ikke angre slettingen av en rolle.

<!-- Referenced links -->

<!-- Referenced images -->
[img3]: ../../../../../media/icons/arrow-down.png
