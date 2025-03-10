---
uid: help-da-add-email-template
title: Tilføjelse af e-mailskabelon
description: Tilføjelse af e-mailskabelon
keywords: e-mailskabelon
author: SuperOffice RnD
date: 02.28.2025
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføjelse af en e-mailskabelon

E-mailskabeloner kan bruges, når du opretter nye e-mails i SuperOffice-indbakken, og når du sender tilbud, ordrebekræftelser og bekræftelser på beskyttelse af personoplysninger.

Skabeloner vises som forekomster på listen **E-mail – Skabelon**, og du kan tilføje nye skabeloner til SuperOffice CRM ved at tilføje dem som en forekomst på listen.

[!include[Edit list item](includes/edit-list-item.md)] når forekomsterne er e-mailskabeloner:

1. Indtast det ønskede navn for forekomsten i feltet **Skabelonnavn**.

2. Vælg den type skabelon, du opretter, i feltet **Skabelontype**. Vælg **Normal**, hvis skabelonen skal være tilgængelig i **Indbakke**. Du kan også gøre skabelonen tilgængelig som tilbudsskabelon, [ordrebekræftelsesskabelon][3] eller [skabelon til bekræftelse af personbeskyttelse][4].

3. Vælg eventuelt, hvor du vil gemme dokumentskabelonen, på listen **Gem skabelonen i**.

4. Du har nu tre valgmuligheder:

    * **Opret ny e-mailskabelon**
    * **Kopiér en eksisterende e-mail-skabelonfil**.
        1. Klik på listen **Kopier skabelon**.
        2. Vælg den ønskede skabelon på listen.
    * **Upload en ny e-mail-skabelon fra disk (.md/.md)**
        1. Klik på knappen**Upload**.
        2. Klik på **Upload fil** i dialogboksen **Upload fil**.
        3. Vælg den ønskede fil og klik på **Åbn**. Navnet på filen vises i dialogboksen **Rediger forekomst**.

5. Klik på **Gem** i dialogboksen **Rediger forekomst**. Dialogboksen opdateres.

6. Valgfrit: Rediger skabelonnavnet, hvis det er nødvendigt.

7. Klik **Rediger** for at redigere selve skabelonfilen. Hvis du har oprettet en ny e-mailskabelon, skal du føje indhold til skabelonen.

8. Angiv ønsket information på fanerne **Detaljer** og **Sprog**.

9. Klik på **Gem**. Skabelonen bliver nu tilføjet som en særlig forekomst på listen **Forekomster**. Gentag proceduren, hvis du vil tilføje flere skabeloner.

## Fanen Detaljer

Angiv følgende information på fanen **Detaljer**:

1. (valgfrit) Rediger navnet på skabelonen i feltet **Navn**. Du kan også [tilføje fanenavnet på andre sprog][1] ved at klikke på <i class="ph ph-translate" aria-label="Translate"></i>.

2. Indtast titlen på e-mailmeddelelsen i feltet **Emne**. Du kan også [tilføje emnet på andre sprog][1] ved at klikke på <i class="ph ph-translate" aria-label="Translate"></i>.

3. Vælg **Brug signatur i ny e-mail** for at føje din signatur til nye e-mails. Hvis du ikke har en personlig signatur, bruges systemsignaturen.

4. Vælg **Vis e-maildialogboks** for at få vist dialogboksen **Ny e-mail**, når du opretter en ny e-mail baseret på denne skabelon. I denne dialogboks kan du indtaste data som firma, person og projekt, hvilket er nødvendigt, hvis e-mailskabelonen indeholder skabelonvariabler.

5. Angiv eventuelt en beskrivelse af skabelonen i feltet **Beskrivelse**.

6. I feltet **Retning** angiver du, om skabelonen skal være udgående eller indgående ved at klikke på <i class="ph ph-caret-down" aria-label="Chevron"></i> og vælge fra rullemenuen. Vælg **Udgående**, hvis skabelonen skal være tilgængelig i **Indbakke**.

7. I feltet **Hensigt** klikkes på <i class="ph ph-caret-down" aria-label="Chevron"></i>, hvorefter en af de foruddefinerede valgmuligheder vælges fra listen. Disse forekomster bruges i forbindelse med statusovervågning (kræver licens til [Sales Intelligence][5]).

    > [!TIP]
    > Du kan oprette nye indstillinger ud over de foruddefinerede indstillinger ved at tilføje forekomster på listen **Opfølgning - Hensigt** i Indstillinger og vedligeholdelse.

8. I feltet **Dokument gemt i** kan du vælge at gemme dokumentet et andet sted end standardindstillingen.

9. Angiv standardindstillingen for feltet **Vores reference** ved at anvende [skabelonvariabler][2], eksempelvis *auth* for afsenderens for- og efternavne.

> [!NOTE]
> Du kan åbne skabelonen til redigering direkte ved at klikke på knappen **Rediger** øverst i dialogboksen **Rediger forekomst**. Det er kun htm/html-filer, der kan redigeres direkte i denne editor. Filtypen vises i feltet **Filnavn** under fanen **Detaljer**. Klik på knappen **Download** for at hente andre filtyper og redigere dem i det relevante program.

## Fanen Sprog

Her kan du tilføjer oversatte versioner af dokumentskabelonen.

1. Klik på **Tilføj**.
2. I dialogboksen **Rediger listeelement** skal du vælge det sprog, du har brug for, på listen **Tilføj sprog**.
3. Tilføj den oversatte dokumentskabelon som beskrevet ovenfor.
4. Klik på **Tilføj**. Sproget vises på fanen **Sprog**.
5. Gentag ovenstående trin for at tilføje flere sprog.

> [!TIP]
> Klik på <i class="ph ph-translate" aria-label="Translate"></i> ud for det relevante felt for at [tilføje oversættelser][1] af skabelonnavnet og e-mailens emne.

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../document/templates/learn/template-variables.md
[3]: ../../../sale/admin/sale-type.md
[4]: privacy-source-add.md
[5]: ../../../saint/learn/index.md
