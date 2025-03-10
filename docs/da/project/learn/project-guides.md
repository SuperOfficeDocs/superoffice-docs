---
uid: help-da-project-guide
title: Projektguider
description: Introduktion til projektguider i SuperOffice CRM.
keywords: projektguide, guide, workflow, detaljekort Projektguide, projekt
author: SuperOffice RnD
date: 03.07.2025
version: 10.5.2
topic: concept
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Projektguider

En projektguide i SuperOffice CRM er et værktøj til processtyring, der forenkler og standardiserer projektudførelse ved at knytte projekttyper til foruddefinerede statusser. Hver status indeholder specifikke opfølgninger, dokumenter og milepæle, der guider dig gennem projektets livscyklus. Denne strukturerede tilgang sikrer ensartethed på tværs af projekter og hjælper projektledere med at holde styr på opgaver og leverancer.

Som standard findes der flere projektguider i SuperOffice CRM. Du kan bruge dem, som de er, eller tilpasse dem i **Indstillinger og vedligeholdelse**, så de passer til din virksomheds arbejdsgange.

## Hvad er en projektguide?

En projektguide består af:

* **Statusser:** De forskellige faser i et projekt, såsom Planlagt, Igangværende og Afslutning.
* **Opfølgninger:** Handlinger som opgaver og møder, der er knyttet til hver status.
* **Dokumenter:** Relevante filer, såsom rapporter eller notater, der er forbundet med projektet.
* **Milepæle:** Vigtige opfølgninger, der markerer væsentlige fremskridt i projektet.

Når du opretter et projekt eller ændrer dets type til en, der er knyttet til en projektguide, aktiveres guiden automatisk i detaljekortet **Projektguide**. Dette detaljekort viser statusserne, de tilknyttede aktiviteter og de næste trin for projektet.

**Eksempel:**

For en projekttype **Konference** kan projektguiden indeholde:

* Planlagt: En opfølgning til et "Planlægningsmøde" og et dokument med "Konferenceprogram".
* Igangværende: Opgaver til at oprette en deltagerliste og sende invitationer.
* Afslutning: Et evalueringsmøde og en afsluttende rapport.

Projektguider oprettes i Indstillinger og vedligeholdelse og kan tilpasses, så de matcher din organisations specifikke arbejdsgange.

## Sådan fungerer en projektguide

1. **Start med en status:** Når du opretter eller opdaterer et projekt med en tilknyttet projektguide, vælges den første status automatisk. Detaljekortet **Projektguide** viser de opfølgninger og dokumenter, der er knyttet til denne status.

1. **Opret aktiviteter:** Hver opfølgning eller dokument i guiden kan oprettes direkte fra detaljekortet:
    * Klik på **Opret** ved siden af opfølgningen eller dokumentet.
    * Udfyld de foruddefinerede felter i dialogen, og gem.

    > [!TIP]
    > Tildel opfølgninger til teammedlemmer for at fremme samarbejdet. Dialogboksen **Overfør opgaven til en projektdeltager** vises for udvalgte opfølgninger.

1. **Marker opgaver som fuldførte:** Når en aktivitet er afsluttet, markeres den som fuldført i detaljekortet **Projektguide**. Dokumenter markeres automatisk som fuldførte ved oprettelse.

    Fuldførte aktiviteter vises også i detaljekortet **Aktiviteter**.

1. **Gå videre til næste status:** Når alle opgaver i en status er færdige, eller efter behov:
    * Flyt projektet til næste status manuelt eller automatisk (hvis defineret i **Indstillinger og vedligeholdelse**).
    * Guiden opdateres og viser opfølgninger og dokumenter for den nye status.

1. **Gentag for alle statusser:** Arbejd dig gennem hver status ved at fuldføre de foreslåede aktiviteter, indtil projektet er afsluttet.

> [!NOTE]
> Du kan skifte til næste status uden at afslutte alle opfølgninger i den nuværende status.

## <a id="project-guide-tab"></a>Detaljekortet Projektguide

![Detaljekortet Projektguide med status for Planlagt -screenshot][img1]

Detaljekortet **Projektguide** giver en struktureret oversigt over projektets foruddefinerede statusser, opfølgninger og dokumenter. Dette detaljekort hjælper brugere med at holde styr på opgaver og sikre, at projektet skrider planmæssigt frem.

### Vigtige elementer

* **Statusknapper:** Øverst på detaljekortet vises knapper for de foruddefinerede statusser, såsom Planlagt, Igangværende, Afslutning og Fuldført.

    ![Projektguide-statusser -screenshot][img2]

  * **Aktuel status:** Markeres med en udfyldt cirkel (<i class="ph ph-circle-fill" aria-hidden="true"></i>).
  * **Fremtidige statusser:** Vises som en tom cirkel (<i class="ph ph-circle" aria-hidden="true"></i>).
  * **Fuldførte statusser:** Markeres med et flueben (<i class="ph ph-check" aria-hidden="true"></i>).

* **Aktiviteter:** Detaljekortet er opdelt i to kolonner: **Opfølgninger** og **Dokumenter**. Hver række indeholder en **Opret**-knap, så brugeren kan oprette den nødvendige opfølgning eller det nødvendige dokument direkte fra detaljekortet.

    **Milepælsopfølgninger** er markeret med et diamantikon (<i class="ph ph-diamond" aria-hidden="true"></i>). Feltet **Næste milepæl** på projektkortet viser automatisk datoen for næste milepæl, så brugere kan holde øje med vigtige projektdeadlines.

* **Filtre:** Nederst i detaljekortet findes følgende filtre, som kan bruges til at justere visningen:

  * **Kun oprettede:** Viser kun fuldførte eller igangværende opfølgninger og dokumenter.
  * **Kun milepæle:** Viser kun milepælsopfølgninger.
  * **Vis alle statusser:** Viser alle statusser og deres tilhørende opfølgninger og dokumenter.

### Tips til brug

* Hurtig navigation: Brug statusknapperne til at fokusere på opgaver i en specifik fase af projektet.
* Effektiv opgavestyring: Markér opfølgninger som fuldførte, eller opret opgaver direkte fra detaljekortet.
* Tilpasning: Brug filtrene til at fokusere på milepæle eller kun oprettede aktiviteter.

## Opret en opfølgning eller et dokument

For at oprette en opfølgning eller et dokument, der er knyttet til en projektguide:

1. Gå til detaljekortet **Projektguide**.
1. Find den opfølgning eller det dokument, du vil oprette, under den aktuelle status.
1. Klik på **Opret** ud for elementet.

    * For opfølgninger åbnes [Opfølgningsdialogen][7] med forudfyldte felter baseret på projektguidens indstillinger. Foretag de nødvendige ændringer, og klik på **Gem**.

    * For dokumenter åbnes [Dokumentdialogen][8] med en forudvalgt skabelon. Udfyld de påkrævede felter, og klik på **Gem**.

> [!TIP]
> Du kan oprette flere opfølgninger eller dokumenter af samme type ved at højreklikke på et element og vælge **Opret en til**.

## Markér en opfølgning som fuldført

1. På detaljekortet **Projektguide** skal du finde den relevante opfølgning.
1. Markér afkrydsningsfeltet ud for opfølgningens navn. Opfølgningen markeres som fuldført og vises som afsluttet på detaljekortet **Aktiviteter**.

Dokumenter markeres automatisk som fuldførte, når de oprettes.

## <a id="change-status"></a>Flyt til næste status

At skifte mellem projektets statusser er en central funktion i projektguiden. Overgangen til næste status kan ske automatisk eller manuelt, afhængigt af dine workflow-indstillinger.

### Automatisk statusovergang

Hvis projektguiden er konfigureret til at foreslå næste status, vises dialogboksen **Projektguide - flyt projektet til næste status**, når alle påkrævede opfølgninger og dokumenter i den aktuelle status er fuldført.

1. Fuldfør alle påkrævede opfølgninger og dokumenter for den aktuelle status.
1. Når dialogboksen vises, klik på **Ja** for at flytte til næste status, eller **Nej** for at forblive i den aktuelle status.

> [!NOTE]
> Automatisk statusovergang skal være aktiveret i **Indstillinger og vedligeholdelse** for at denne funktion virker.

### Manuel statusovergang

Du kan manuelt flytte projektet til næste status uden at afslutte alle opfølgninger og dokumenter i den aktuelle fase. Når du ændrer en status, f.eks. fra *Planlagt* til *Igangværende*, markeres den forrige status automatisk som fuldført med et flueben på detaljekortet **Projektguide**.

#### Fra detaljekortet Projektguide

1. Højreklik på knappen for den ønskede status.
1. Vælg **Gå til denne status** i menuen.

#### Fra Projektkortet

1. Klik på **Rediger** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) på projektkortet.
1. Klik på pilen ved siden af feltet **Status** for at åbne listen.
1. Vælg den ønskede status.
1. Klik på **Gem** for at bekræfte ændringen.

> [!TIP]
> Du kan også vende tilbage til en tidligere status ved at følge de samme trin.

## Fordele ved projektguider

* Standardiseret arbejdsproces: Sikrer ensartet projektstyring på tværs af teamet.
* Øget gennemsigtighed: Holder alle teammedlemmer opdaterede om projektets aktuelle status og næste trin.
* Fleksibilitet: Gør det muligt at tilpasse projektguiden, så den passer til din virksomheds specifikke processer.

## Relateret indhold

* [Introduktion til projekter][2]
* [Opret et projekt][4]
* [Rediger eller deaktiver en projektguide][5]

<!-- Referenced links -->
[2]: index.md
[4]: create.md
[5]: edit.md
[7]: ../../diary/learn/create-follow-up.md
[8]: ../../document/learn/edit.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/project-guide-tab.png
[img2]: ../../../media/loc/en/project/guide-statuses.png
