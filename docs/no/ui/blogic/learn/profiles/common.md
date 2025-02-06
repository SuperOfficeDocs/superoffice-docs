---
uid: help-no-service-profile-common
title: Felles profiler
description: Felles profiler
author: SuperOffice RnD
date: 06.29.2022
keywords: profil, tjeneste
topic: howto
language: no
---

# Felles profiler

[!include[Legacy](../includes/legacy-profiles.md)]

Fellesprofiler er koblet til en [rolle][2] og gjelder for alle brukere som har denne rollen. Du kan konfigurere felles profiler i bildet **Vis profiler**.

## Profiltyper

* **System**: Du kan konfigurere disse profilene ved å følge fremgangsmåten nedenfor.
* **Systemskjermbilder**: En liste over skjermbilder som er opprettet ved hjelp [av systemdesignerne][1] i SuperOffice Service. Disse kan du endre hvis du har tilgang til **Systemdesign** > **Skjermbilder**.

## <a id="create"></a>Opprett felles profiler

Fremgangsmåten nedenfor viser et eksempel på hvordan du legger til et felt i skjermbildet **Finn saker**.

1. Velg **Systeminnstillinger** > **Profil**. Skjermbildet **Vis profiler** vises.
2. Velg **System**. En hierarkisk oversikt over alle profilene i systemet vises.
3. Klikk på **Søk**.
4. Pek på **Finn saker**, og klikk på <i class="ph ph-list" aria-label="Main menu"></i> (**Ny felles profil**) til høyre for navnet. Skjermbildet **Rediger elementprofil** vises.
5. I feltet **Navn** skriver du inn ønsket navn på profilen.
6. Klikk på knappen **Legg til kriterium**.
7. Gjør følgende i dialogboksen:
    * **Angi ledeteksten for feltet her**: Skriv inn feltnavnet.
    * **Velg felt**: Velg hvilket felt i databasen du vil hente data fra.
8. Klikk på **OK**. Det nye kriteriet legges til under de andre.
9. Klikk på **OK**. Den nye profilen opprettes. Nå kan du for eksempel [koble den til en bestemt rolle][3].

## Redigere informasjon i en felles profil

1. Velg **Systeminnstillinger** > **Profil**. Skjermbildet **Vis profiler** vises.
2. Velg **System**. En hierarkisk oversikt over alle profilene i systemet vises.
3. Bla deg nedover i hierarkiet til du kommer til ønsket profil.
4. Klikk på profilnavnet. Skjermbildet **Rediger elementprofil** vises.
5. Gjør de nødvendige endringene.
6. Klikk på **OK**. Endringene lagres.

## Slett en felles profil

1. Velg **Systeminnstillinger** > **Profil**. Skjermbildet **Vis profiler** vises.
2. Velg **System**. En hierarkisk oversikt over alle profilene i systemet vises.
3. Bla deg nedover i hierarkiet til du kommer til ønsket profil.
4. Klikk på profilnavnet. Skjermbildet **Rediger elementprofil** vises.
5. Klikk på knappen **Gjenopprett standard (sletter denne profilen)** nederst i skjermbildet. Profilen slettes.

## Hva vil du lære mer om?

* [Personlige profiler][4]
* [Globale profiler][5]

<!-- Referenced links -->
[1]: ../screen-properties.md
[2]: ../../../../admin/user-management/learn/role/index.md
[3]: ../../../../admin/user-management/learn/role/create-role.md
[4]: personal.md
[5]: global.md
