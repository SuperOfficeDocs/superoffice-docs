---
uid: help-da-user-other
title: Administration af andre brugere
description: Administration af anonyme brugere og systembrugere (onsite)
author: Bergfrid
date: 03.15.2023
keywords: user, anonym, systembruger
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
envir: onsite
---

# Administration af anonyme brugere og systembrugere (onsite)

* **Systembruger**: [!include[Access rights](includes/def-system-user.md)]
* **Anonym**: [!include[Access rights](includes/def-anon-user.md)]

> [!NOTE]
> Anonyme brugere og systembrugere har brug for **SuperOffice Expander Services**-systemlicensen. [Læs mere][1].

## Tilføjelse af anonym bruger eller systembruger

1. [!include[Click Users](includes/goto-users.md)]

2. [!include[Select Other users](includes/select-other-users.md)]

3. Klik på **Tilføj** under listen.

4. Indtast et ID i feltet **Bruger-ID**.

5. Indtast om nødvendigt en adgangskode til brugeren i feltet **Adgangskode**.

6. Angiv efter behov en beskrivelse af brugeren i feltet **Beskrivelse**.

7. Vælg **Type**: **Systembruger** eller **Anonym**

8. Vælg **Aktiv** til højre for **Logon** for at aktivere brugeren.

9. Klik på **Gem**. Brugeren føjes til listen.

## Rediger anonym bruger eller systembruger

1. [!include[Click Users](includes/goto-users.md)]

2. [!include[Select Other users](includes/select-other-users.md)]

3. Dobbeltklik på den bruger, du vil redigere, på listen.

4. Foretag de ønskede ændringer i den dialogboks, der vises.

5. For at afslutte skal du klikke på **Gem**.

## Ændring af logonrettigheder for andre brugere

Hvis en anonym bruger eller en systembruger ikke længere skal have mulighed for at logge på systemet, kan du fjerne deres logonrettigheder. Den eksterne bruger fjernes ikke, men defineres som inaktiv og kan altid genaktiveres, hvis det er nødvendigt.

### Deaktivering af en bruger

1. [!include[Click Users](includes/goto-users.md)]
2. [!include[Select Other users](includes/select-other-users.md)]
3. Vælg på listen den aktive bruger, du vil fjerne logonrettigheder for, og klik på **Fjern logon** under listen.

    Denne bruger kan derefter ikke længere logge på systemet.

### Aktivering af en bruger

1. [!include[Click Users](includes/goto-users.md)]
2. [!include[Select Other users](includes/select-other-users.md)]
3. Dobbeltklik på den bruger, du vil aktivere, på listen.
4. Vælg **Aktiv** til højre for **Logon** for at aktivere brugeren.
5. Klik på **Gem**. Denne bruger kan derefter logge på systemet.

## Sletning af anonym bruger eller systembruger

1. [!include[Click Users](includes/goto-users.md)]
2. [!include[Select Other users](includes/select-other-users.md)]
3. Vælg den bruger, du vil slette.
4. Klik på knappen **Slet**. Brugeren fjernes fra listen.

<!-- Referenced links -->
[1]: ../../../../en/admin/license/expander-services/index.md

<!-- Referenced images -->
