---
uid: help-da-document-template-link
title: Tilføjelse af dokumentskabelon
description: I denne vejledning lærer du, hvordan du tilføjer en ny dokumentskabelon til SuperOffice CRM.
keywords: dokument, skabelon, liste
author: Bergfrid Dias
date: 07.12.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføjelse af dokumentskabelon

Hvis du opretter nye skabeloner eller ændrer en standardskabelon og gemmer den med et andet navn, skal du knytte skabelonerne til SuperOffice CRM, så programmet kan finde dem, når du skriver dokumenter i SuperOffice CRM.

Skabeloner vises som forekomster på listen **Dokument – Skabelon**, og du knytter en skabelon til SuperOffice CRM ved at tilføje den som en forekomst på listen.

Se denne video, eller følg nedenstående trin for at lære, hvordan du kan tilføje en dokumentskabelon:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/FnhcmjP-TgE]

(videoens længde - 2:30)

## Trin

1. I Indstillinger og vedligeholdelse, klik på knappen **Lister** i navigatoren (1).

1. Vælg fanen **Forekomster**, klik på pilen, og vælg **Dokument – Skabelon** (2).

1. Klik på **Tilføj** (3).

    ![Tilføj dokumentskabelon -screenshot][img3]

1. Indtast det ønskede navn for forekomsten i feltet **Navn** (1).

    ![Rediger forekomst -screenshot ][img2]

1. Vælg eventuelt, hvor du vil gemme dokumentskabelonen, på listen **Gem skabelonen i** (2).

1. Du har nu to muligheder:

    * Overføre en ny dokumentskabelon:

        1. Klik på **Kopier en eksisterende dokumentskabelon**.
        2. Klik på listen **Kopier skabelon**.
        3. Vælg den ønskede skabelon på listen.

    * Kopiere en eksisterende skabelon i SuperOffice:

        1. Vælg **Upload en ny skabelon på disken** (3).
        2. Klik på knappen **Upload**.
        3. Klik på **Upload fil** i dialogboksen **Upload fil**.
        4. Vælg den ønskede fil og klik på **Åbn**. Navnet på filen vises i dialogboksen **Rediger forekomst**.

1. Klik på **Gem** i dialogboksen **Rediger forekomst**. Dialogboksen opdateres.

1. Valgfrit: Rediger skabelonnavnet, hvis det er nødvendigt, og klik på **Rediger** for at redigere selve skabelonfilen.

1. Angiv ønsket information på fanerne **Detaljer** og **Sprog**.

1. Klik på **Gem**. Skabelonen bliver nu tilføjet som en særlig forekomst på listen **Forekomster** og er nu tilgængelig i CRM-klienten:

![New document -screenshot][img4]

![New document dialog -screenshot][img5]

> [!TIP]
> Gentag proceduren, hvis du vil tilføje flere skabeloner.

## Fanen Detaljer

Angiv følgende information på fanen **Detaljer**:

1. I feltet **Retning** angiver du, om skabelonen skal være udgående eller indgående ved at klikke på <i class="ph ph-caret-down" aria-label="Chevron"></i> og vælge fra rullemenuen.

2. I feltet **Dokumenttype** skal du vælge enten **Dokument** eller **Fax** som skabelontype.

3. I feltet **Dokument gemt i** kan du vælge at gemme dokumentet et andet sted end standardindstillingen.

4. I feltet **Hensigt** skal du klikke på <i class="ph ph-caret-down" aria-label="Chevron"></i> og vælge en af de foruddefinerede valgmuligheder fra listen. Disse forekomster bruges i forbindelse med statusovervågning (kræver licens til [Sales Intelligence][4]).

    > [!TIP]
    > Du kan oprette nye indstillinger, ud over de foruddefinerede indstillinger, ved at tilføje forekomster på listen **Opfølgning - Hensigt** i Indstillinger og vedligeholdelse.

5. Onsite: Marker alternativet **Udgiv**, hvis det skal være muligt at angive i dialogboksen Dokument, at den aktuelle dokumentskabelon skal være tilgængelig for eksterne brugere.

6. Onsite: Marker indstillingen **Gem i database** for at angive, at dokumenter, du opretter med denne skabelon, skal gemmes i dokumentdatabasen. Hvis du markerer denne indstilling, vises dokumentet på detaljekortet **Aktiviteter**. Hvis du ikke markerer denne indstilling, vises dokumentet ikke i SuperOffice, efter at du har oprettet det, og du får ikke adgang til det via programmet.

7. Marker indstillingen **Tilbudsdokumenttype** (4), hvis dokumentet skal være tilgængeligt som [tilbudsskabelon][2] eller ordrebekræftelsesskabelon. Du vælger typen tilbudsdokument på listen nedenfor.

    ![Reference list item -screenshot][img8]

8. Angiv standardindstillingen for feltet **Vores reference (standard)** (5)ved at anvende [skabelonvariablerne][2], eksempelvis *auth* for afsenderens for- og efternavne, eller {oref}.

9. Angiv eventuelt en beskrivelse af skabelonen i feltet **Beskrivelse**.

    > [!TIP]
    > Du kan åbne skabelonen til redigering direkte ved at klikke på knappen **Rediger** øverst i dialogboksen **Rediger forekomst**.

## Fanen Sprog

Here you can add translated versions of the document template.

1. Klik på **Tilføj**.

    ![Tilføj sprog -screenshot][img6]

1. I dialogboksen **Rediger forekomst** skal du vælge det sprog, du har brug for, på listen **Tilføj sprog**.

1. Tilføj den oversatte dokumentskabelon som beskrevet ovenfor.

    ![Oversatt dokumentskabelon -screenshot][img7]

1. Klik på **Tilføj**. Sproget vises på fanen **Sprog**.

1. Gentag ovenstående trin for at tilføje flere sprog.

## Relateret

* [Erstat nuværende skabelon][1]

<!-- Referenced links -->
[1]: update-template.md
[2]: ../learn/quote-templates.md
[4]: ../../../saint/learn/index.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/document/edit-list-item.png
[img3]: ../../../../media/loc/en/document/lists-add.png
[img4]: ../../../../media/loc/en/document/imagedmnmi.png
[img5]: ../../../../media/loc/en/document/image6r9sc.png
[img6]: ../../../../media/loc/en/document/language-add.png
[img7]: ../../../../media/loc/en/document/deutch-document-upload.png
[img8]: ../../../../media/loc/en/document/reference-item.png
