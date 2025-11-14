---
uid: help-no-user-other
title: Administrere andre brukere
description: Administrere anonyme brukere og systembrukere (Onsite)
keywords: anonym bruker, systembruker, Andre brukere
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
deployment: onsite
platform: web
index: true
redirect_from: 
  - /no/admin/user-management/learn/other-users
  - /no/admin/user-management/learn/role/edit-rights-for-anonymous-users
language: no
---

# Administrere anonyme brukere og systembrukere (Onsite)

* **Systembruker**: Systembrukere kan logge seg på systemet via tredjepartsapplikasjoner og har alle rettigheter.
* **Anonym**: Anonyme brukere har rettigheter basert på [rollen for anonyme brukere](#rights). Det er vanligvis ikke nødvendig å ha mer enn én anonym bruker.

> [!NOTE]
> Anonyme brukere og systembrukere krever lisens til systemet [SuperOffice Expander Services][1] og kan administreres i fanen **Andre brukere**.
>
> 1. Velg <i class="ph ph-user" aria-hidden="true"></i> **Brukere** i navigatoren.
> 1. Velg fanen **Andre brukere**. I listen vises eksisterende anonyme brukere og systembrukere.

## Legge til anonym bruker eller systembruker

1. Klikk på **Legg til** under listen.

1. Angi en ID i feltet **Bruker-ID**.

1. Angi eventuelt et passord for brukeren i feltet **Passord**.

1. Angi eventuelt en beskrivelse av brukeren i boksen **Beskrivelse**.

1. Velg **type**: **Systembruker** eller **Anonym**

1. Velg **Aktiv** til høyre for **Pålogging** for å aktivere brukeren.

1. Klikk på **Lagre**. Brukeren legges til i listen.

## Redigere anonym bruker eller systembruker

1. Dobbeltklikk på brukeren du ønsker å redigere, i listen.

1. Gjør de nødvendige endringene i dialogboksen som vises.

1. Klikk til slutt på **Lagre**.

## <a id="rights"></a>Redigere rettigheter for anonyme brukere (Onsite)

Det finnes bare én rolle for anonyme brukere, og det er bare datarettighetene som kan redigeres for denne rollen.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Velg fanen **Anonym**.

1. [Angi datarettighetene i fanen **Datarettigheter**][2].

Endringene lagres automatisk.

## Endre påloggingsrettigheter for andre brukere

Hvis en anonym bruker eller en systembruker ikke lenger skal ha mulighet til å logge på systemet, kan du fjerne påloggingsrettighetene for denne brukeren. Brukeren blir ikke fjernet, men definert som inaktiv og kan når som helst aktiveres igjen.

### Deaktivere en bruker

1. Merk den aktive brukeren du ønsker å fjerne påloggingsrettigheter for, i listen, og klikk på **Fjern pålogging** nedenfor listen.

    Denne brukeren kan ikke lenger logge på systemet.

### Aktivere en bruker

1. Dobbeltklikk på den brukeren du vil aktivere, i listen.
1. Velg **Aktiv** til høyre for **Pålogging** for å aktivere brukeren.
1. Klikk på **Lagre**. Brukeren kan logge på systemet.

## Slette anonym bruker eller systembruker

1. Merk brukeren du vil slette.
1. Klikk på **Slett**-knappen. Brukeren fjernes fra listen.

<!-- Referenced links -->
[1]: ../../license/expander-services.md
[2]: ../role/set-data-rights-for-role.md
