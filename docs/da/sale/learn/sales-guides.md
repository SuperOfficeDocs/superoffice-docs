---
uid: help-da-sales-guide
title: Salgsguide
description: Introduktion til salgsguider i SuperOffice.
keywords: salgsguide, guide, workflow, detaljekortet Salgsguide, salg
author: SuperOffice RnD
date: 04.03.2025
version: 10.5.2
topic: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Salgsguider

Salgsguider i SuperOffice CRM er kraftfulde værktøjer, der forenkler og standardiserer salgsprocessen ved at knytte salgstyper til foruddefinerede faser. Hver fase indeholder foreslåede opfølgninger og dokumenter, som guider sælgerne gennem en struktureret salgsproces. Dette sikrer, at ingen muligheder overses, og at teamet arbejder ensartet.

> [!NOTE]
> Denne funktion kræver en Sales Premium-licens.

## Hvad er en salgsguide?

En salgsguide består af:

* **Faser:** Foruddefinerede trin i salgsprocessen, såsom Første møde, Tilbud eller Underskrivelse af kontrakt. Hver fase har et navn, en sandsynlighedsprocent og en beskrivelse.
* **Opfølgninger:** Aktiviteter som opkald eller møder, der er knyttet til hver fase.
* **Dokumenter:** Skabeloner til tilbud, kontrakter eller e-mails, der er relevante for salgsprocessen.

Når du opretter et salg eller ændrer salgstypen til en, der har en tilknyttet salgsguide, aktiveres guiden automatisk i detaljekortet **Salgsguide**. Dette detaljekort giver et overblik over faser, opfølgninger og dokumenter for salget.

**Eksempel:**

En salgstype for kundeanskaffelse kan indeholde:

* Første møde-fasen: Opfølgning på møde og introduktionsmail.
* Tilbudsfasen: Udarbejdelse og afsendelse af tilbud.
* Underskrivelse af kontrakt: Underskrift af kontrakt og planlægning af opfølgninger.

Salgsguider opsættes i Indstillinger og vedligeholdelse og kan tilpasses, så de passer til din virksomheds specifikke workflows.

## Sådan fungerer en salgsguide

Se denne video for at lære, hvor nemt det er at bruge salgsguiden:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IyETjAtn3po]

(videoens længde – 1:24)

### Trin

1. **Start med en fase:** Når du opretter eller opdaterer et salg med en tilknyttet salgsguide, vælges den første fase automatisk. Detaljekortet **Salgsguide** viser de opfølgninger og dokumenter, der er knyttet til denne fase.

1. **Opret aktiviteter:** Opfølgninger og dokumenter kan oprettes direkte fra detaljekortet **Salgsguide**:
    * Klik på **Opret** ud for opfølgningen eller dokumentet.
    * Udfyld felterne i den åbne dialog og gem.

    > [!TIP]
    > Tildel opfølgninger til specifikke teammedlemmer for bedre samarbejde.

1. **Marker opgaven som udført:** Når en aktivitet er afsluttet, skal du markere afkrydsningsfeltet ved siden af dens navn i detaljekortet **Salgsguide**. Dokumenter markeres automatisk som udført, når de oprettes.

    Fuldførte opgaver vises også på detaljekortet **Aktiviteter**.

1. **Gå videre til næste fase:** Når alle aktiviteter for en fase er fuldført, eller når det er nødvendigt:
    * Flyt manuelt salget til næste fase, eller lad det ske automatisk (hvis aktiveret).
    * Guiden opdateres og viser de foreslåede opfølgninger og dokumenter for den nye fase.

1. **Gentag, indtil salget er afsluttet:** Arbejd dig gennem faserne, indtil salget markeres som **Solgt** eller **Tabt**.

> [!NOTE]
> Du kan gå videre til næste fase uden at fuldføre alle opfølgninger i den aktuelle fase.

## <a id="sales-guide-tab"></a>Detaljekortet Salgsguide

Detaljekortet **Salgsguide** giver et visuelt og funktionelt overblik over salgsprocessen, så sælgere nemt kan holde styr på deres fremgang og opgaver.

![Detaljekortet Salgsguide med status Første møde -screenshot][img1]

### Hovedkomponenter

* **Faseknapper:** Øverst vises knapper, der repræsenterer foruddefinerede faser, såsom Første møde, Tilbud og Underskrivelse af kontrakt.

    ![Faser i salgsguide -screenshot][img2]

  * **Aktuel fase:** Markereres med en udfyldt cirkel (<i class="ph ph-fill ph-circle" aria-hidden="true"></i>).
  * **Kommende faser:** Vises med en tom cirkel (<i class="ph ph-circle" aria-hidden="true"></i>).
  * **Fuldførte faser:** Markereres med et flueben (<i class="ph ph-check" aria-hidden="true"></i>).

* **Aktiviteter:** Detaljekortet er opdelt i to kolonner: **Opfølgninger** og **Dokumenter**. Hver række indeholder en **Opret**-knap, som gør det muligt at oprette den nødvendige opfølgning eller dokument direkte fra detaljekortet.

    > [!TIP]
    > Brug afkrydsningsfeltet **Vis alle faser** for at se alle opfølgninger og dokumenter på tværs af faserne.

## Opret en opfølgning eller et dokument

For at oprette en opfølgning eller et dokument knyttet til en salgsguide:

1. Gå til detaljekortet **Salgsguide**.
1. Find opfølgningen eller dokumentet under den aktuelle fase.
1. Klik på **Opret** ud for elementet.

   * For opfølgninger åbnes [Opfølgning-dialogen][6] med forudfyldte felter baseret på salgsguidens indstillinger. Foretag eventuelle ændringer, og klik derefter på **Gem**.

   * For dokumenter åbnes [Dokument-dialogen][7] med en forvalgt skabelon. Udfyld de påkrævede felter, og klik på **Gem**.

> [!TIP]
> Du kan oprette flere opfølgninger eller dokumenter af samme type ved at højreklikke på et element og vælge **Opret en til**.

## Marker en opfølgning som udført

1. Gå til detaljekortet **Salgsguide**, og find den opfølgning, du har gennemført.
1. Markér afkrydsningsfeltet ved siden af opfølgningens navn. Opgaven markeres som udført og vises i detaljekortet **Aktiviteter** som færdig.

Dokumenter markeres automatisk som udført, når de oprettes.

### Hvorfor åbnes dialogboksen Salgsguide, når jeg fuldfører en opfølgning?

I Indstillinger og vedligeholdelse kan du angive, at en opfølgning i en salgsguide automatisk foreslås, når den foregående opfølgning markeres som fuldført. I så fald åbnes dialogboksen **Salgsguide**, når du markerer den forrige opfølgning som fuldført.

I dialogboksen **Salgsguide** har du tre muligheder:

* Klik på **Opret** for at oprette den næste opfølgning i salgsguiden. Dette tager dig direkte til opfølgningsdialogen.

* Klik på **Afbryd**, hvis du ikke vil oprette opfølgningen på nuværende tidspunkt. Dialogboksen lukkes, og du skal huske at oprette opfølgningen senere.

* Markér **Altid oprette opfølgning? Vis ikke denne dialogboks igen**, hvis du altid vil oprette den foreslåede opfølgning automatisk. Herefter vil dialogen for opfølgninger åbne direkte næste gang.

> [!TIP]
> Hvis du vil gendanne denne indstilling, så dialogboksen **Salgsguide** åbnes igen, skal du gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige indstillinger** > **Præferencer** > **Salg** og vælge **Ja** for indstillingen **Bekræft oprettelse af foreslået opfølgning**.

## <a id="change-stage"></a>Skift til næste fase

Salgsguider understøtter både manuel og automatisk fremgang gennem faserne:

### Automatisk faseovergang

Hvis aktiveret, foreslås den næste fase automatisk, når alle krævede opfølgninger og dokumenter i den aktuelle fase er markeret som fuldførte. Du kan vælge at gå videre eller blive i den nuværende fase.

![Dialogboks for automatisk skift af salgsfase -screenshot][img3]

1. Fuldfør alle påkrævede opfølgninger og dokumenter for den aktuelle fase.
1. Når dialogboksen vises, klik på **Ja** for at gå videre til næste fase eller **Nej** for at forblive i den nuværende fase.

> [!NOTE]
> Automatisk faseovergang skal aktiveres i **Indstillinger og vedligeholdelse** for at denne funktion fungerer.

### Manuel faseovergang

Du kan manuelt skifte til næste fase, hvis det er nødvendigt, uden at have fuldført alle opfølgninger og dokumenter i den aktuelle fase.

1. Højreklik på knappen for den ønskede fase i detaljekortet **Salgsguide**.
1. Vælg **Gå til denne fase** i menuen.

Alternativt:

1. Klik på **Rediger** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) på hovedkortet **Salg**.
1. Brug rullemenuen **Fase** til at vælge næste fase.
1. Klik på **Gem**.

> [!TIP]
> Du kan også gå tilbage til en tidligere fase ved at følge samme trin.

## Fordele ved salgsguider

* Ensartethed: Standardiserer salgsprocesser på tværs af organisationen.
* Effektivitet: Giver klare trin, skabeloner og opgaver for hver fase.
* Overblik: Hjælper sælgere med at holde fokus på den aktuelle fase og de næste opgaver.

## Relateret indhold

* [Introduktion til salg][1]
* [Opret et salg][2]
* [Salgsguide-tutorial][3]
* [Opret en ny salgsguide][4]
* [Rediger eller deaktiver en salgsguide][5]

<!-- Referenced links -->
[1]: index.md
[2]: create.md
[3]: tutorial.md
[4]: ../admin/create-sales-guide.md
[5]: ../admin/edit-sales-guide.md
[6]: ../../diary/learn/create-follow-up.md
[7]: ../../document/learn/edit.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/sales-guide-tab.png
[img2]: ../../../media/loc/en/sale/guide-stages.png
[img3]: ../../../media/loc/en/sale/goto-next-stage.png
