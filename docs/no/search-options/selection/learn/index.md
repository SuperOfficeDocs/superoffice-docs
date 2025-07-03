---
uid: help-no-selection
title: Utvalg
description: Utvalg
keywords: dynamisk utvalg, statisk utvalg, kombinert utvalg, kombinasjonsutvalg, Utvalg-skjermbildet, utvalgsmedlemmer, utvalg
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from:
  - /no/search-options/selection/learn/combined-selections
  - /no/search-options/selection/learn/dynamic-selections
  - /no/search-options/selection/learn/static-selections
  - /no/search-options/selection/learn/screen/index
---

# Utvalg

Du kan lage utvalg av poster/data som du jobber mye med. Hvis du også har lisens for tilgang til salgstilbud, kan du også opprette utvalg av produkter.

> [!TIP]
> Du kan opprette diagrammer fra utvalg og også bruke utvalg til å opprette masseutsendelser.

Alle utvalgene inneholder også en oversikt over firmaer og personer knyttet til postene i utvalget. For eksempel firmaer og personer knyttet til salget i et salgsutvalg.

## <a id="types"></a>Typer

Det finnes tre forskjellige typer utvalg i SuperOffice CRM:

* **Statisk utvalg:** Inneholder kun medlemmer som er lagt til manuelt.
* **Dynamisk utvalg:** Oppdateres automatisk med medlemmer som samsvarer med utvalgskriteriene.
* **Kombinert utvalg:** En kombinasjon av to eksisterende utvalg.

### Statiske utvalg

Et statisk utvalg inneholder kun medlemmene du har lagt til manuelt eller via et søk, i motsetning til et dynamisk utvalg. Når du har opprettet et statisk utvalg og lagt til medlemmer, vil det forbli uendret til du manuelt legger til eller fjerner medlemmer.

Bruk et statisk utvalg hvis du ønsker full kontroll over medlemmene til enhver tid. Du kan [legge til og fjerne medlemmer manuelt][7], enten individuelt eller via et søk.

**Eksempel:** En håndplukket liste over VIP-kunder for en personlig markedsføringskampanje.

### Dynamiske utvalg

Et dynamisk utvalg fungerer som et lagret søk som utføres hver gang du åpner utvalget. Hver gang du legger til poster i SuperOffice CRM som oppfyller søkekriteriene for et dynamisk utvalg, blir det automatisk oppdatert med de nye medlemmene – i motsetning til et statisk utvalg.

Bruk et dynamisk utvalg hvis du ønsker en alltid oppdatert liste over firmaer, personer, salg, prosjekter, dokumenter, oppfølginger, saker eller produkter som oppfyller spesifikke kriterier.

**Eksempel:** En sanntidsliste over alle åpne salgsavtaler i inneværende kvartal, automatisk oppdatert når nye avtaler opprettes.

### Kombinerte utvalg

Et kombinert utvalg er en kombinasjon av to eksisterende utvalg (statisk eller dynamisk). Det kan inneholde oppføringer som er felles for begge utvalgene, oppføringer som er forskjellige, oppføringer som kun finnes i ett av utvalgene, eller alle oppføringer fra begge utvalg.

**Eksempel:** En filtrert liste over alle kunder som har kjøpt et bestemt produkt og samtidig har en åpen supportsak, slik at du kan prioritere oppfølginger.

Etter [opprettelse av et kombinert utvalg][4] kan du velge å gjøre det om til et statisk utvalg.

## <a id="tabs"></a>Faner i Utvalg-skjermbildet

| Fane | Beskrivelse |
|---|---|
| Medlemslisten | Viser listen over poster i utvalget. |
| Firma/person | Viser firmaer og personer knyttet til utvalgsmedlemmer. Hvis utvalget er for firmaer eller personer, er dette den eneste fanen med medlemmer. |
| Kriterier | Vis og [rediger kriterier][9] for et dynamisk utvalg. |
| Detaljer | Vis og rediger generell informasjon om utvalget. |
| Diagrammer | [Vis utvalgsdata som et diagram.][3] Diagrammer kan også brukes i [dashbord][16]. |
| Utsendelser | Viser utsendelser som er arkivert for dette utvalget. [Opprett en utsendelse][8] til personer i utvalget. |

> [!TIP]
> Klikk på <i class="ph ph-gear" aria-label="Gear"></i> til høyre for kolonneoverskriftene i et utvalg for å gruppere og filtrere poster, legge til/fjerne kolonner og spesifisere beregninger. Disse innstillingene kan lagres for det aktive utvalget ved å velge **Lagre kolonner bare for gjeldende utvalg**.

## <a id="members"></a>Utvalgsmedlemmer

Den første fanen i et utvalg viser postene i utvalget. Dobbeltklikk på en post for å åpne og se detaljene.

Oppsettet varierer avhengig av hva utvalget inneholder. Alle utvalg unntatt **Firma/person** har to lister: én for utvalgsdata og én for tilknyttede firmaer og personer.

> [!NOTE]
> Som standard vises bare de første 100 postene. For å endre dette, gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige innstillinger** > **Preferanser** > **Funksjoner** > **Arkivsidestørrelse**.

### <a id="filter"></a>Filtrere listen over medlemmer

1. Klikk **Vis alle** i fanens bunntekst for å inkludere alle poster.

1. For å aktivere [kolonnefilteret][12], klikk på <i class="ph ph-gear" aria-label="Gear"></i> og velg **Aktiver filter**. Filterknappen (<i class="ph ph-funnel" aria-hidden="true"></i>) vil da vises i filtrerbare kolonner.

## Knapper

| Knap | Navn | Beskrivelse |
|---|---|---|
| <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i> | Oppgavemeny | Utfør ulike oppgaver for utvalgsmedlemmer, som å sende e-post, masseredigere og eksportere. De tilgjengelige oppgavene avhenger av posttypen i feltet **Utvalg av**. |
| <i class="ph ph-arrow-clockwise" aria-hidden="true"></i> | Oppdater | Oppdaterer dataene i listen. |
| **Antall: nummer** | | Viser antallet medlemmer i det aktive utvalget. |
| <i class="ph ph-download-simple" aria-hidden="true"></i> | Eksporter | [Eksporter listen til et regneark.][6] |

## <a id="ex"></a>Eksempler på hvordan du kan bruke utvalg

Utvalg lar deg gruppere og filtrere data basert på spesifikke kriterier. Nedenfor finner du eksempler på ulike typer utvalg og deres potensielle bruksområder.

### Firmaer

Du kan opprette et dynamisk utvalg som inneholder alle firmaer i kategorien *Leverandør* med adresse i Tyskland hvis du planlegger videre aktiviteter i Tyskland.

### Personer

* Alle personer som er opprettet de siste 30 dagene.
* Alle personer hvor *julekort* eller *nyhetsbrev* er definert som en interesse.

### Salg

Et utvalg av alle salg du har gjennomført i første kvartal, eller alle salg med statusen **Utsatt**, kan hjelpe deg med å identifisere trender og vurdere hvor du skal fokusere din fremtidige salgsinnsats.

> [!TIP]
> [Gruppér kolonner og summer beløp][10] for å oppdage trender og få en tydelig oversikt over dataene dine.

![Utvalg av salg - gruppering og sum av beløp -screenshot][img3]

### Prosjekter

* Et utvalg av alle pågående prosjekter av typen *Internt* hjelper deg med å vurdere hvilke prosjekter som kan avsluttes, og hvilke som fortsatt bør følges opp.

* Alle aktive prosjekter du deltar i.

### Dokumenter

* Et utvalg av alle dokumenter du har opprettet den siste måneden gir deg en oversikt over hvilke dokumenter som er produsert, og hjelper deg med å identifisere eventuelle glemte dokumenter.

* Alle kontrakter registrert i SuperOffice CRM.

### Oppfølginger

* Et utvalg av alle oppfølginger for en bestemt kunde gir deg innsikt i kundeforholdet før et salgsmøte.

* Et utvalg av alle oppfølginger du har denne måneden hjelper deg med å se hvilke avtaler du har og om du bør planlegge flere.

### Produkter (krever en Sales Premium-lisens)

* En liste over alle kunder som har kjøpt et bestemt produkt eller en bestemt produktkategori.

* Et utvalg av alle produkter som er solgt i år, basert på salg med tilbud som har statusen **Solgt**. Utvalget kan begrenses til spesifikke produktkategorier, produktfamilier osv., avhengig av hvilken type statistisk rapportering du trenger.

* Hvis du planlegger en produktoppgradering fra for eksempel versjon 2 til versjon 3, kan du opprette et utvalg av alle kunder som har kjøpt versjon 2, og bruke dette som grunnlag for en kampanje.

### Saker

* En liste over åpne saker med prioritet **Høy** for din avdeling (kategori).

* Et utvalg av alle åpne saker som ikke har blitt oppdatert på over en uke hjelper deg med å følge opp de ansvarlige saksbehandlerne.

### Utvalg

* Alle aktive utvalg du eier.
* Alle utvalg med en bestemt kategori eller av en bestemt type.

### Markedsføring og kundeengasjement

* Ikke-behandlede skjemainnsendinger for kundene dine.
* Dine chatsamtaler.
* Kundenes chatsamtaler med spesifikke vurderinger.
* Utsendelser med en bestemt åpningsfrekvens eller klikkfrekvens.
* Utsendelser med høy returfrekvens.

## Relatert innhokld

* [Legg til post som favoritt][11]
* [Opprett utvalg][2]
* [Rediger eller slett utvalg][5]
* [Utfør oppgaver ved å bruke utvalg][1]
* [Vis utvalg som diagrammer][3]

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
