---
uid: help-no-section-tabs-configure
title: Endre kolonnevisningen
description: Endre kolonnevisningen
keywords: detaljkort, arkiv, kolonne
author: Bergfrid Dias
date: 01.29.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Konfigurere kolonner

Du kan tilpasse kolonnene i detaljkortene for å vise nøyaktig den informasjonen du trenger. Du kan endre hvilke kolonner som vises, samt rekkefølge og bredde.

Ved å konfigurere kolonner kan du tilpasse vist informasjon og arbeide med CRM-data slik du trenger. Lær hvordan du konfigurerer kolonner med denne videoen, eller følg trinnene nedenfor:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IjlPSN-u0MA]

(videolengde - 1:44)

## Endre rekkefølge på kolonnene

Hvis du vil endre rekkefølgen på kolonnene i et detaljkort, klikker og drar du en kolonneoverskrift til en ny plassering.

## Legg til eller fjern kolonne

1. Gå til detaljkortet du vil redigere.
2. Klikk på <i class="ph ph-gear" aria-label="Gear"></i> til høyre for kolonneoverskriftene. En dialogboks åpnes.
3. Merk av eller fjern merket for de relevante kolonnene. Bruk feltene **filterkolonner** til å filtrere kolonnene som vises.
4. Klikk på **OK**.

Hvis du vil tilbakestille kolonnene til standardvisningen, klikker du **Tilbakestill**.

## <a id="calculate"></a>Kolonneberegninger

Du kan utføre beregninger som sum, gjennomsnitt eller min/maks på dato- og tallfelter.

1. På detaljkortet klikker du på tannhjulssymbolet for å åpne innstillingene.

2. Gå til fanen **∑ Sum** i dialogboksen.

3. Velg kolonnene du vil inkludere i beregningen. Du kan eventuelt **aktivere gruppering** for å organisere dataene.

    ![Detaljkortinnstillinger - sum av beløp og aktiver gruppering -screenshot][img2]

4. Velg hvilken beregning som skal utføres på hver kolonne. De tilgjengelige alternativene avhenger av felttypen.

**Resultat:**

![Detaljkortet for salg - sum og gruppering på beløp -screenshot][img3]

> [!NOTE]
> Hvis organisasjonen din bruker flere valutaer, må du sørge for at du arbeider med konsistente verdier i salgsberegningene. Bruk **basisvaluta**-versjonene av feltene **Beløp** og **Vektet beløp** for å sikre nøyaktighet.

![Detaljkortet for salg - sum av beløp for basisvaluta -screenshot][img5]

## Justere kolonnebredder manuelt

1. Hold musepekeren over den vertikale streken foran eller bak en kolonneoverskrift. Musepekeren endres til en dobbel vertikal strek med piler.

1. Klikk og hold museknappen nede mens du drar skillestreken i ønsket retning, alt etter om du vil øke eller redusere kolonnebredden. Kolonnene har den angitte bredden neste gang du åpner programmet.

> [!NOTE]
> Du kan ikke justere kolonnebredden manuelt hvis **Automatisk tilpassing av kolonnebredde** er aktiv.

## Justere kolonnebredder automatisk

Du kan angi at kolonnebredder skal justeres automatisk i henhold til innholdet i kolonnene. Når kolonner legges til eller fjernes, justeres alle kolonnebredder slik at de passer best mulig hver gang. Hvis det er for mange kolonner til å få plass på den tilgjengelige plassen, vises et vannrett rullefelt.

1. Gå til detaljkortet du vil redigere.
2. Klikk på <i class="ph ph-gear" aria-label="Gear"></i> til høyre for kolonneoverskriftene. En dialogboks åpnes.
3. Velg **Automatisk tilpasning av kolonnebredde**.
4. Klikk på **OK**.

## Aktuelle emner

* [Gruppelister][3]
* [Filtrer detaljkort][1]
* [Eksporter data fra detaljkort][2]

<!-- Referenced links -->
[1]: filter.md
[2]: export-archives.md
[3]: group.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/learn/section-tab-sum-amount.png
[img3]: ../../../media/loc/en/learn/group-sales-by-status.png
[img5]: ../../../media/loc/en/sale/currency-adjusted-sale-amount-calculation.png
