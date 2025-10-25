---
uid: help-da-user-other
title: Administration af andre brugere
description: Administration af anonyme brugere og systembrugere (onsite)
keywords: anonym bruger, systembruger, Andre brugere
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
  - /da/admin/user-management/learn/other-users
  - /da/admin/user-management/learn/role/edit-rights-for-anonymous-users
language: da
---

# Administration af anonyme brugere og systembrugere (onsite)

* **Systembruger**: Systembrugere kan logge på systemet via tredjepartsprogrammer og har alle rettigheder.
* **Anonym**: Anonyme brugere har rettigheder baseret på [rollen for anonyme brugere](#rights). Det er normalt ikke nødvendigt at have mere end én anonym bruger oprettet.

> [!NOTE]
> Anonyme brugere og systembrugere har brug for [SuperOffice Expander Services][1]-systemlicensen og kan administreres under fanen **Andre brugere**.
>
> 1. Vælg <i class="ph ph-user" aria-hidden="true"></i> **Brugere** i navigatoren.
> 1. Vælg fanen **Andre brugere**. Listen viser eksisterende anonyme brugere og systembrugere.

## Tilføjelse af anonym bruger eller systembruger

1. Klik på **Tilføj** under listen.

1. Indtast et ID i feltet **Bruger-ID**.

1. Indtast om nødvendigt en adgangskode til brugeren i feltet **Adgangskode**.

1. Angiv efter behov en beskrivelse af brugeren i feltet **Beskrivelse**.

1. Vælg **Type**: **Systembruger** eller **Anonym**

1. Vælg **Aktiv** til højre for **Logon** for at aktivere brugeren.

1. Klik på **Gem**. Brugeren føjes til listen.

## Rediger anonym bruger eller systembruger

1. På listen, dobbeltklik på den bruger, du vil redigere.

1. Foretag de ønskede ændringer i den dialogboks, der vises.

1. For at afslutte skal du klikke på **Gem**.

## <a id="rights"></a>Redigering af rettigheder for anonyme brugere (onsite)

Der er kun én rolle for anonyme brugere, og kun datarettighederne for denne rolle kan redigeres.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Vælg fanen **Anonym.**

1. [Angiv datarettighederne under **fanen Datarettigheder** .][2]

Ændringerne gemmes automatisk.

## Ændring af logonrettigheder for andre brugere

Hvis en anonym bruger eller en systembruger ikke længere skal have mulighed for at logge på systemet, kan du fjerne deres logonrettigheder. Den eksterne bruger fjernes ikke, men defineres som inaktiv og kan altid genaktiveres, hvis det er nødvendigt.

### Deaktivering af en bruger

1. Vælg på listen den aktive bruger, du vil fjerne logonrettigheder for, og klik på **Fjern logon** under listen.

    Denne bruger kan derefter ikke længere logge på systemet.

### Aktivering af en bruger

1. Dobbeltklik på den bruger, du vil aktivere, på listen.
1. Vælg **Aktiv** til højre for **Logon** for at aktivere brugeren.
1. Klik på **Gem**. Denne bruger kan derefter logge på systemet.

## Sletning af anonym bruger eller systembruger

1. Vælg den bruger, du vil slette.
1. Klik på knappen **Slet**. Brugeren fjernes fra listen.

<!-- Referenced links -->
[1]: ../../license/expander-services.md
[2]: ../role/set-data-rights-for-role.md
