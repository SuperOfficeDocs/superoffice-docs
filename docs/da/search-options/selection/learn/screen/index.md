---
uid: help-da-selection-screen
title: Detaljekortene i skærmbilledet Udvalg
description: Detaljekortene i skærmbilledet Udvalg
keywords: selection
author: Bergfrid Dias
date: 09.17.2024
version: 10.3.9
topic: reference
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Skærmbilledet Udvalg

Den første fane i et udvalg indeholder en liste over medlemmer (poster, data) i det aktive udvalg. Udvalgsmedlemmer kan være firmaer eller personer, projekter, salg, dokumenter, opfølgninger, formularindsendelser, chatsamtaler, udsendelser eller produkter.

Medlemslisten ser lidt forskellig ud afhængig af, hvad udvalget indeholder. Alle udvalgstyper undtagen **Firma/person** har to faner, der indeholder udvalgsdata.

> [!TIP]
> Hvis du dobbeltklikker på en post på listen over medlemmer, vises den aktuelle post.

## Detaljekortene i skærmbilledet Udvalg

| Fane | Beskrivelse |
|---|---|
| Medlemslisten | Indeholder udvalgsdata. |
| Firma/person | Indeholder firmaer og personer, der er knyttet til listen over medlemmer. Eksempel: Alle personer eller firmaer, der er knyttet til salget i et udvalg. Hvis udvalget er et udvalg af firmaer/personer, er dette den eneste fane med medlemmer. |
| Kriterier | Vis og [rediger kriterierne][3] for et dynamisk udvalg. |
| Detaljer | Vis og rediger [generel information for et udvalg][1]. |
| Diagrammer | [Vis udvalgsdataene i et diagram.][5] Diagrammer over markeringer kan også bruges i [dashboards][6]. |
| Udsendelser | Opret en udsendelse til personer i et udvalg. [Vis de udsendelser,](#mailing) der arkiveres for dette udvalg. |

> [!TIP]
> Klik på <i class="ph ph-gear" aria-label="Gear"></i> til højre for kolonnetitlerne i et udvalg for at gruppere og filtrere poster, tilføje/fjerne kolonner, og angive beregninger. Disse indstillinger kan gemmes til det aktive udvalg ved kun at vælge **Gem kun kolonner for det aktuelle udvalg**. Se også [Detaljekortene][9] for yderligere funktioner.

Hvis du vil gå frem og tilbage mellem udvalg, skal du klikke på knapperne forrige/næste (<i class="ph ph-arrow-left" aria-hidden="true"></i><i class="ph ph-arrow-right" aria-hidden="true"></i>) øverst til højre i skærmbilledet.

### <a id="filter"></a>Filtrering af listen over medlemmer

> [!NOTE]
> Før du filtrerer listen over medlemmer (for eksempel salg eller opfølgninger), skal du klikke på **Vis alle** i sidefoden på fanen. Det sikrer, at fanen viser alle poster i udvalget. For at sikre den bedst mulige ydelse, når du arbejder med store udvalg, indlæses som regel kun de første 100 poster på listen over medlemmer.

For at aktivere kolonnefilteret skal du klikke på <i class="ph ph-gear" aria-label="Gear"></i> længst til højre for kolonnetitlerne og klikke på **Aktivér filter**. Filterknappen (<i class="ph ph-funnel" aria-hidden="true"></i>) vises nu på kolonnen, hvilket kan [filtreres][8].

### Knappen Opgave <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>

Brug knappen **Opgave** for at udføre forskellige opgaver for medlemmerne eller nogle af medlemmerne i udvalget. Eksempler: afsendelse af e-mails, masseredigering og eksport. Hvilke opgaver der vises, afhænger af, hvilken type poster udvalget består af (hvad der er valgt i feltet **Udvalg af**).

### Andre knapper

* **Fjern medlemmer**. Denne indstilling er kun tilgængelig for statiske udvalg. Hvis du vil [fjerne bestemte medlemmer i udvalget][2], skal du vælge de relevante medlemmer, højreklikke og vælge **Fjern**.

* **Antal: antallet**, Antal medlemmer i det aktive udvalg.

* **Vis alle**. Bruges til at vise alle udvalgsmedlemmer.

    > [!NOTE]
    > Som standard viser listen kun de første 100 poster i udvalget. For at ændre denne værdi skal du gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige indstillinger** > **Præferencer** > **Funktioner** > **Arkivsidestørrelse**.

* <i class="ph ph-arrow-clockwise" aria-label="Refresh"></i>: Opdaterer dataene på listen.

### <a id="mailing"></a> Vis udsendelser arkiveret efter udvalg

Brug fanen **Udsendelser** på skærmbilledet Valg til at holde styr på alle udsendelser, der er relateret til et udvalg.

Dobbeltklik på en udsendelse for at redigere den.

**Opret udsendelse**: Klik her for at [oprette en ny udsendelse][7] til personerne i dette udvalg.

**Eksporter**: Bruges til at eksportere listen til et regneark.

## Relateret indhold

* [Udførelse af opgaver med udvalg][4]
* [Brug af filtre i detaljekortene][8]
* [Opret udvalg][1]

<!-- Referenced links -->
[1]: ../create/index.md
[2]: ../update/add-remove-members-static.md
[5]: ../howto/display-as-charts.md
[3]: ../../../learn/search-criteria.md
[6]: ../../../../dashboard/learn/create.md
[7]: ../../../../marketing/mailing/learn/create/index.md
[8]: ../../../../learn/section-tabs/filter.md
[9]: ../../../../learn/section-tabs/index.md
[4]: ../../../../learn/getting-started/index.md
