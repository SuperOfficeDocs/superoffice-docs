---
uid: help-da-service-profile-common
title: Fællesprofiler
description: Fællesprofiler
author: SuperOffice RnD
date: 06.29.2022
keywords: profil, service
topic: howto
language: da
---

# Fællesprofiler

[!include[Legacy](../includes/legacy-profiles.md)]

Fællesprofiler er knyttet til en [rolle][2] og gælder for alle brugere, der har denne rolle. Du kan konfigurere fællesprofiler i skærmbilledet **Vis profiler**.

## Profiltyper

* **System**: Du kan konfigurere disse profiler ved at følge fremgangsmåden nedenfor.
* **System screens**: En liste over skærmbilleder, der er oprettet ved hjælp af [systemdesignere][1] i SuperOffice Service. Disse kan du ændre, hvis du har adgang til **Systemdesign** > **Billeder**.

## <a id="create"></a>Oprettelse af fællesprofiler

Følgende trin viser for eksempel, hvordan du tilføjer et felt på skærmbilledet **Find anmodninger** .

1. Vælg **Systemindstillinger** > **Profil**. Skærmbilledet **Vis profiler** vises.
2. Vælg **System**. Der vises en hierarkisk oversigt over alle profilerne i systemet.
3. Klik på **Søg**.
4. Peg på **Find anmodninger**, og klik på <i class="ph ph-list" aria-label="Main menu"></i> (**Ny fælles profil**) til højre for navnet. Skærmbilledet **Rediger elementprofil** vises.
5. I feltet **Navn** skal du indtaste det ønskede navn på profilen.
6. Klik på knappen **Tilføj kriterium**.
7. I dialogboksen skal du gøre følgende:
    * **Indtast etiketten til feltet her**: Indtast feltnavnet.
    * **Vælg felt**: Vælg, hvilket felt i databasen du vil hente data fra.
8. Klik på **OK**. Det nye kriterium tilføjes under de andre.
9. Klik på **OK**. Den nye profil oprettes. Nu kan du for eksempel [knytte den til en bestemt rolle][3].

## Rediger oplysninger i en fælles profil

1. Vælg **Systemindstillinger** > **Profil**. Skærmbilledet **Vis profiler** vises.
2. Vælg **System**. Der vises en hierarkisk oversigt over alle profilerne i systemet.
3. Bladr ned gennem hierarkiet, til du kommer til den ønskede profil.
4. Klik på profilnavnet. Skærmbilledet **Rediger elementprofil** vises.
5. Foretag de nødvendige ændringer.
6. Klik på **OK**. Ændringerne gemmes.

## Slet en fællesprofil

1. Vælg **Systemindstillinger** > **Profil**. Skærmbilledet **Vis profiler** vises.
2. Vælg **System**. Der vises en hierarkisk oversigt over alle profilerne i systemet.
3. Bladr ned gennem hierarkiet, til du kommer til den ønskede profil.
4. Klik på profilnavnet. Skærmbilledet **Rediger elementprofil** vises.
5. Klik på knappen **Genopret standard (sletter denne profil)** nederst i skærmbilledet. Profilen slettes.

## Hvad ønsker du at få mere at vide om?

* [Personlige profiler][4]
* [Globale profiler][5]

<!-- Referenced links -->
[1]: ../screen-properties.md
[2]: ../../../../admin/user-management/learn/role/index.md
[3]: ../../../../admin/user-management/learn/role/create-role.md
[4]: personal.md
[5]: global.md
