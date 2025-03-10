---
uid: help-da-project-type
title: Projekttype
description: Lær, hvordan du opretter en ny projekttype i SuperOffice CRM. Definer navne, angiv estimerede varigheder, tilknyt statusser og tilføj eventuelt en projektguide for en mere strømlinet projektstyring.
keywords: tilføj projekttype, projekttype, projekt, listen Projekt - Type status
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Projekttype

[!include[Must be admin](../../learn/includes/req-admin.md)]

Feltet **Type** i projektkortet kategoriserer projekter og definerer deres arbejdsprocesser. Disse typer er foruddefineret i listen **Projekt - Type, status**, som du kan administrere i **Indstillinger og vedligeholdelse** under **Lister**.

Hvert projekt skal have en type, og disse typer kan knyttes til specifikke [statusser][1] og eventuelt til [projektguider][4]. Projektguider effektiviserer eksekveringen ved at guide brugere gennem foruddefinerede faser, opfølgninger og dokumenter.

## Tilføj en projekttype

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Vælg **Projekt - Type, status** fra dropdown-menuen. Fanen **Elementer** viser alle eksisterende projekttyper.

1. Klik på **Tilføj** for at åbne dialogboksen **Rediger listeelement**.

    ![Dialogboksen Rediger listeelement til projekttyper -screenshot][img1]

1. Indtast et navn for projekttypen i feltet **Navn**. *(Obligatorisk)*

    Dette navn vil fremgå af feltet **Type** i projektkortet.

1. Angiv den typiske projektvarighed i feltet **Estimeret tid for denne projektproces** (uger, dage eller måneder).

    Dette bestemmer standard slutdatoen ved oprettelse af et projekt (dags dato + estimeret tid).

1. Vælg de nødvendige statusser på listen **Statusser anvendt til denne projekttype**.

    > [!NOTE]
    > For at knytte projekttypen til en projektguide skal du vælge mindst to statusser.

1. *(Valgfrit)* Markér **Denne projekttype er knyttet til en guide**, hvis projekter af denne type skal følge en projektguide.

1. *(Valgfrit)* Markér **Foreslå at flytte projektet til næste status automatisk** for at opfordre brugerne til at [skifte status][5], når alle opfølgninger i den nuværende status er fuldført.

1. Tilføj en beskrivelse af projekttypen i feltet **Beskrivelse**, hvis det er nødvendigt.

1. Klik på **Gem** for at anvende ændringerne, eller **Afbryd** for at fortryde dem.

    Projekttypen tilføjes nu til listen **Elementer**. Gentag disse trin for at tilføje flere projekttyper.

## Rediger eller slet en projekttype

1. Følg trin 1-2 ovenfor for at få adgang til listen **Projekt - Type, status**.

1. For at redigere:
   * Dobbeltklik på den ønskede projekttype for at åbne **Rediger listeelement**-dialogboksen.
   * Foretag de nødvendige ændringer, og klik på **Gem**.

1. For at slette:
   * Vælg projekttypen i listen, og klik på **Slet**.

    > [!CAUTION]
    > Hvis du sletter en projekttype, fjernes dens tilknytning til statusser og projektguider. Sørg for, at den ikke er i aktiv brug, før du fortsætter.

## <a id="restore"></a>Gendan en slettet projekttype

Hvis en projekttype er blevet slettet, kan du gendanne den fra listen **Projekt - Type, status**. Dog vil en gendannelse ikke automatisk genetablere forbindelserne til de relaterede projektstatusser eller guider. Disse forbindelser skal genoprettes manuelt efter behov.

1. Gå til listen **Projekt - Type, status**.

1. Markér **Vis slettede elementer og overskrifter** i bunden. Slettede elementer vises gennemstreget i fanen **Elementer**.

1. Dobbeltklik på det slettede element, du vil gendanne. Dialogboksen **Rediger listeelement** åbnes.

1. Klik på **Gendan**.

1. Opdater eventuelle nødvendige felter, og klik på **Gem**. Elementet er nu aktivt og vil blive vist i fanen **Elementer**.

## Relateret indhold

* [Tilføj en projektstatus][1]
* [Opret en projektguide][2]
* [Rediger en projektguide][3]

<!-- Referenced links -->
[1]: project-status.md
[2]: create-project-guide.md
[3]: edit-project-guide.md
[4]: ../learn/project-guides.md
[5]: ../learn/project-guides.md#change-status

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/edit-project-type.png
