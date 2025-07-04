---
uid: help-da-selection
title: Udvalg
description: Udvalg
keywords: dynamisk udvalg, statisk udvalg, kombinationsudvalg, kombinerede udvalg, skærmbilledet Udvalg, udvalgsmedlemmer, udvalg
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from:
  - /da/search-options/selection/learn/combined-selections
  - /da/search-options/selection/learn/dynamic-selections
  - /da/search-options/selection/learn/static-selections
  - /da/search-options/selection/learn/screen/index
---

# Udvalg

Du kan oprette udvalg af poster/data, som du arbejder meget med.

> [!TIP]
> Du kan oprette diagrammer ud fra udvalg og også bruge udvalg til at oprette udsendelser.

Desuden indeholder alle udvalgene en oversigt over de firmaer og personer, som er knyttet til posterne i udvalget. For eksempel firmaer og personer, der er knyttet til salget i et salgsudvalg.

## <a id="types"></a>Typer

Der findes tre forskellige typer af udvalg i SuperOffice CRM:

* **Statisk udvalg:** Indeholder kun manuelt tilføjede medlemmer.
* **Dynamisk udvalg:** Opdateres automatisk med medlemmer, der opfylder udvalgets kriterier.
* **Kombinationsudvalg:** En kombination af to eksisterende udvalg.

### Statiske udvalg

Et statisk udvalg indeholder kun de medlemmer, du har tilføjet manuelt eller via en søgning, i modsætning til et dynamisk udvalg. Når du har oprettet et statisk udvalg og tilføjet medlemmer, forbliver det uændret, indtil du manuelt tilføjer eller fjerner medlemmer.

Brug et statisk udvalg, hvis du ønsker fuld kontrol over dets medlemmer. Du kan manuelt [tilføje og fjerne medlemmer][7], enten individuelt eller via en søgning.

**Eksempel:** En håndplukket liste over VIP-kunder til en personlig markedsføringskampagne.

### Dynamiske udvalg

Et dynamisk udvalg fungerer som en gemt søgning, der køres hver gang du åbner udvalget. Når du tilføjer poster til SuperOffice CRM, som opfylder udvalgets kriterier, opdateres udvalget automatisk med de nye medlemmer, i modsætning til et statisk udvalg.

Anvend et dynamisk udvalg, hvis du ønsker en opdateret oversigt over firmaer, personer, salg, projekter, dokumenter, opfølgninger, sager eller produkter, som opfylder et bestemt sæt søgekriterier.

**Eksempel:** En realtidsliste over alle åbne salgsmuligheder i det aktuelle kvartal, der automatisk opdateres, når nye salgsmuligheder oprettes.

### Kombinerede udvalg

Et kombinationsudvalg er en kombination af to eksisterende udvalg (statisk eller dynamisk). Det kan indeholde poster, der er fælles for de to udvalg, poster der adskiller sig, poster der kun findes i ét af udvalgene eller alle poster fra begge udvalg.

**Eksempel:** En filtreret liste over alle kunder, der har købt et specifikt produkt og samtidig har en åben sag i supportsystemet, hvilket hjælper med at prioritere opfølgninger.

Efter [oprettelse af et kombinationsudvalg][4] kan du vælge at ændre det til et statisk udvalg.

## <a id="tabs"></a>Faner i skærmbilledet Udvalg

| Fane | Beskrivelse |
|---|---|
| Medlemmer | Viser listen over poster i udvalget. |
| Firma/person | Viser firmaer og personer knyttet til udvalgsmedlemmer. Hvis udvalget er for firmaer eller personer, er dette den eneste fane med medlemmer. |
| Kriterier | Vis og [rediger kriterier][9] for et dynamisk udvalg. |
| Detaljer | Vis og rediger generelle oplysninger om udvalget. |
| Diagrammer | [Vis udvalgsdata i et diagram.][3] Diagrammer kan også bruges i [dashboards][16]. |
| Udsendelser | Viser udsendelser, der er arkiveret for dette udvalg. [Opret en udsendelse][8] til kontakter i udvalget. |

> [!TIP]
> Klik på <i class="ph ph-gear" aria-label="Gear"></i> til højre for kolonnetitlerne i et udvalg for at gruppere og filtrere poster, tilføje/fjerne kolonner og angive beregninger. Disse indstillinger kan gemmes for det aktive udvalg ved at vælge **Gem kun kolonner for det aktuelle udvalg**.

## <a id="members"></a>Udvalgsmedlemmer

Den første fane i et udvalg viser de poster, der er inkluderet i udvalget. Dobbeltklik på en post for at åbne og se detaljerne.

Layoutet varierer afhængigt af, hvad udvalget indeholder. Alle posttyper undtagen **Firma/person** har to lister: én med udvalgsdata og én med tilknyttede firmaer og personer.

> [!NOTE]
> Som standard vises kun de første 100 poster. For at ændre dette, gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige indstillinger** > **Præferencer** > **Funktioner** > **Arkivsidestørrelse**.

### <a id="filter"></a>Filtrering af listen over medlemmer

1. Klik på **Vis alle** i sidefoden på fanen for at inkludere alle poster.

1. For at aktivere [kolonnefilteret][12], klik på <i class="ph ph-gear" aria-label="Gear"></i> og vælg **Aktivér filter**. Filterknappen (<i class="ph ph-funnel" aria-hidden="true"></i>) vises derefter på filtrerbare kolonner.

## Knapper

| Knap | Navn | Beskrivelse |
|---|---|---|
| <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i> | Opgavemenu | Udfør forskellige opgaver for udvalgsmedlemmer, såsom at sende e-mails, masseredigere og eksportere. De tilgængelige opgaver afhænger af posttypen i feltet **Udvalg af**. |
| <i class="ph ph-arrow-clockwise" aria-hidden="true"></i> | Opdater | Opdaterer dataene i listen. |
| **Antal: tal** | | Viser antallet af medlemmer i det aktive udvalg. |
| <i class="ph ph-download-simple" aria-hidden="true"></i> | Eksportér | [Eksportér listen til et regneark.][6] |

## <a id="ex"></a>Eksempler på, hvordan du kan bruge udvalg

Udvalg giver dig mulighed for at gruppere og filtrere data baseret på specifikke kriterier. Nedenfor finder du eksempler på forskellige typer af udvalg og deres mulige anvendelsesområder.

### Firmaer

Du kan oprette et dynamisk udvalg, som indeholder alle firmaer i kategorien *Leverandør* med adresse i Tyskland, hvis du planlægger yderligere aktiviteter i Tyskland.

### Personer

* Alle personer, der er oprettet inden for de sidste 30 dage.
* Alle personer, hvor du har defineret *julekort* eller *nyhedsbrev* som en interesse.

### Salg

Et udvalg af alle salg, du har gennemført i første kvartal, eller alle dine salg med statussen **Udsat**, kan hjælpe dig med at identificere tendenser og vurdere, hvor du skal rette din fremtidige salgsindsats.

> [!TIP]
> [Gruppér kolonner og summer beløb][10] for at opdage tendenser og få et klart overblik over dine data.

![Udvalg af salg - gruppering og sum af beløb -screenshot][img3]

### Projekter

* Et udvalg af alle projekter af typen *Internt*, som er aktuelle, hjælper dig med at vurdere, hvilke der kan afsluttes/fuldføres, og hvilke der stadig er værd at arbejde videre med.

* Alle aktive projekter, du deltager i.

### Dokumenter

* Et udvalg af alle dokumenter, du har oprettet i den sidste måned, giver dig et overblik over, hvilke dokumenter der er produceret, og hjælper dig med at identificere eventuelle oversete dokumenter.

* Alle kontrakter, der er registreret i SuperOffice CRM.

### Opfølgninger

* Et udvalg af alle opfølgninger på en bestemt kunde giver dig indsigt i, hvilket forhold I har til kunden, før du afholder et salgsmøde.

* Et udvalg af alle opfølgninger, du har denne måned, hjælper dig med at se, hvilke opfølgninger du har planlagt, og om du bør oprette flere.

### Produkter (kræver en Sales Premium-licens)

* En liste over alle kunder, der har købt et bestemt produkt eller en bestemt produktkategori.

* Et udvalg af alle produkter solgt i år, baseret på salg med tilbud, der har statussen **Solgt**. Udvalget kan begrænses til specifikke produktkategorier, produktfamilier osv., afhængigt af hvilken type statistisk output du har brug for.

* Hvis du planlægger at opgradere et produkt fra f.eks. version 2 til version 3, kan du oprette et udvalg af alle kunder, der har købt version 2, og bruge dette som grundlag for en kampagne.

### Sager

* En liste over åbne sager med prioriteten **Høj** for din afdeling (kategori).

* Et udvalg af alle åbne sager, der ikke er blevet opdateret i over en uge, hjælper dig med at følge op på de ansvarlige sagsbehandlere.

### Udvalg

* Alle aktive udvalg, der ejes af dig.
* Alle udvalg med en bestemt kategori eller af en bestemt type.

### Markedsføring og kundeengagement

* Ikke-behandlede formularindsendelser for dine kunder.
* Dine chatsamtaler.
* Dine kunders chatsamtaler med specifikke vurderinger.
* Udsendelser med en bestemt åben-rate eller klikfrekvens.
* Udsendelser med høje afvisningsprocenter.

## Relateret indhold

* [Tilføj post som foretrukken][11]
* [Opret udvalg][2]
* [Rediger eller slet udvalg][5]
* [Udfør opgaver med udvalg][1]
* [Vis udvalg som diagrammer][3]

<!-- Referenced links -->
[1]: howto/index.md
[3]: howto/display-as-charts.md
[6]: howto/export.md
[8]: howto/create-mailings.md
[2]: create.md
[4]: combine.md
[5]: update.md
[7]: add-remove-members-static.md
[9]: ../../learn/search-criteria.md
[11]: ../../../learn/basics/fav.md
[10]: ../../../learn/section-tabs/configure-columns.md#calculate
[12]: ../../../learn/section-tabs/filter.md
[16]: ../../../dashboard/learn/create.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/sale/selection-sales-column-calculation-grouping.png
