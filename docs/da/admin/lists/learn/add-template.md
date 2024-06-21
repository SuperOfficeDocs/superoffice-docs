---
uid: help-da-add-template
title: Tilføjelse af en skabelon
description: "I denne vejledning lærer du, hvordan du tilføjer en ny dokumentskabelon til SuperOffice CRM."
author: SuperOffice RnD
date: 03.24.2023
keywords: dokument, skabelon
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføjelse af dokumentskabelon

For at sikre, at alle i firmaet bruger de samme dokumenter, kan du oprette og tilføje dine egne dokumentskabeloner til forskellige filtyper. Brug de tilgængelige skabelonvariabler til at tilpasse og automatisere indtastningen af kundeoplysninger i dine dokumenter.

Hvis du opretter nye skabeloner eller ændrer en standardskabelon og gemmer den med et andet navn, skal du knytte skabelonerne til SuperOffice CRM, så programmet kan finde dem, når du skriver dokumenter i SuperOffice CRM. Når du har tilknyttet skabelonerne, kan du nemt skrive breve, fax og andre dokumenter, som du har oprettet skabeloner til, ved hjælp af [funktionen Dokument i SuperOffice CRM][5].

Se denne video, eller følg nedenstående trin for at lære, hvordan du kan tilføje en dokumentskabelon (videoens længde - 2:30):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/FnhcmjP-TgE]

## Trin

> [!TIP]
> Hvis du vil tilføje nye skabeloner, kan du nemt kopiere en eksisterende dokumentskabelonfil og redigere den, så den passer til dine behov.

Skabeloner vises som forekomster på listen **Dokument – Skabelon**, og du knytter en skabelon til SuperOffice CRM ved at tilføje den som en forekomst på listen.

[!include[Edit list item](includes/edit-list-item.md)] når forekomsterne er dokumentskabeloner:

1. Indtast det ønskede navn for forekomsten i feltet **Navn**.
2. Vælg eventuelt, hvor du vil gemme dokumentskabelonen, på listen **Gem skabelonen i**.
3. Du har nu to muligheder:

    * Overføre en ny dokumentskabelon:

        1. Klik på **Kopier en eksisterende dokumentskabelon**.
        2. Klik på listen **Kopier skabelon**.
        3. Vælg den ønskede skabelon på listen.

    * Kopiere en eksisterende skabelon i SuperOffice:

        1. Vælg**Upload en ny skabelon på disken**.
        2. Klik på knappen**Upload**.
        3. Klik på **Upload fil** i dialogboksen **Upload fil**.
        4. Vælg den ønskede fil og klik på **Åbn**. Navnet på filen vises i dialogboksen **Rediger forekomst**.

4. Klik på **Gem** i dialogboksen **Rediger forekomst**. Dialogboksen opdateres.
5. Valgfrit: Rediger skabelonnavnet, hvis det er nødvendigt, og klik på **Rediger** for at redigere selve skabelonfilen.
6. Angiv ønsket information på fanerne **Detaljer** og **Sprog**.
7. Klik på **Gem**. Skabelonen bliver nu tilføjet som en særlig forekomst på listen **Forekomster**. Gentag proceduren, hvis du vil tilføje flere skabeloner.

## Fanen Detaljer

Angiv følgende information på fanen **Detaljer**:

1. I feltet **Retning** angiver du, om skabelonen skal være udgående eller indgående ved at klikke på ![icon][img1] pilen og vælge fra rullemenuen.

2. I feltet **Dokumenttype** skal du vælge enten **Dokument** eller **Fax** som skabelontype.

3. I feltet **Dokument gemt i** kan du vælge at gemme dokumentet et andet sted end standardindstillingen.

4. I feltet **Hensigt** skal du klikke på ![icon][img1] og vælge en af de foruddefinerede valgmuligheder fra listen. Disse forekomster bruges i forbindelse med statusovervågning (kræver licens til [Sales Intelligence][4]).

    > [!TIP]
    >Du kan oprette nye indstillinger, ud over de foruddefinerede indstillinger, ved at tilføje forekomster på listen **Opfølgning - Hensigt** i Indstillinger og vedligeholdelse.

5. Onsite: Marker alternativet **Udgiv**, hvis det skal være muligt at angive i skærmbilledet Dokument, at den aktuelle dokumentskabelon skal være tilgængelig for eksterne brugere.

6. Onsite: Marker indstillingen **Gem i database** for at angive, at dokumenter, du opretter med denne skabelon, skal gemmes i dokumentdatabasen. Hvis du markerer denne indstilling, vises dokumentet på detaljekortet **Aktiviteter**. Hvis du ikke markerer denne indstilling, vises dokumentet ikke i SuperOffice, efter at du har oprettet det, og du får ikke adgang til det via programmet.

7. Marker indstillingen **Tilbudsdokumenttype**, hvis dokumentet skal være tilgængeligt som tilbudsskabelon eller ordrebekræftelsesskabelon. Du vælger typen tilbudsdokument på listen nedenfor.

    [!include[Link to quote template docs](includes/learn-quote-templates.md)]

8. Angiv standardindstillingen for feltet **Vores reference (standard)** ved at anvende [skabelonvariablerne][2], eksempelvis *auth* for afsenderens for- og efternavne.

9. Angiv eventuelt en beskrivelse af skabelonen i feltet **Beskrivelse**.

    > [!TIP]
    > Du kan åbne skabelonen til redigering direkte ved at klikke på knappen **Rediger** øverst i dialogboksen **Rediger forekomst**.

## Fanen Sprog

Her kan du tilføjer oversatte versioner af dokumentskabelonen.

1. Klik på **Tilføj**.
2. I dialogboksen **Rediger forekomst** skal du vælge det sprog, du har brug for, på listen **Tilføj sprog**.
3. Tilføj den oversatte dokumentskabelon som beskrevet ovenfor.
4. Klik på **Tilføj**. Sproget vises på fanen **Sprog**.
5. Gentag ovenstående trin for at tilføje flere sprog.

## Relateret

* [Hvordan uploader og bruger jeg dokumentskabeloner?][3] – FAQ
* [Erstat nuværende skabelon][1]

<!-- Referenced links -->
[2]: ../../../document/learn/template-variables.md
[5]: ../../../document/learn/index.md
[1]: replace-existing-template.md
[4]: ../../../sale/saint/learn/index.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-upload-and-use-document-templates-in-superoffice-crm/

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-down.png
