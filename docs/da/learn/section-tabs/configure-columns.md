---
uid: help-da-section-tabs-configure
title: Ændre kolonnevisningen
description: Ændre kolonnevisningen
keywords: detaljekort, arkiv, kolonne
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da 
---

# Konfiguration af kolonner

Du kan tilpasse kolonnerne i detaljekortene, så de viser præcis de oplysninger, du har brug for. Du kan ændre, hvilke kolonner der skal vises i oversigterne, samt hvilken rækkefølge og bredde.

Ved at konfigurere kolonner kan du tilpasse viste oplysninger og arbejde med CRM-data på den måde, du har brug for. Lær, hvordan du konfigurerer kolonner med denne video, eller følg fremgangsmåden nedenfor:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IjlPSN-u0MA]

(videoens længde - 1:44)

## Ændring af kolonnernes rækkefølge

Hvis du vil ændre rækkefølgen af kolonnerne under et detaljekort, skal du klikke på og trække en kolonneoverskrift til en ny placering.

## Tilføj eller fjern kolonne

1. Gå til det detaljekort, du vil redigere.
2. Klik på <i class="ph ph-gear" aria-label="Gear"></i> til højre for kolonneoverskrifterne. Der vises en dialogboks.
3. Vælg eller fravælg de relevante kolonner. Brug felterne **Filtrer kolonner** til at filtrere de kolonner, der vises.
4. Klik på **OK**.

Hvis du vil nulstille kolonnerne til standardvisningen, skal du klikke på **Nulstil**.

## <a id="calculate"></a>Kolonneberegninger

Du kan udføre beregninger som sum, gennemsnit eller min/max på dato- og talfelter.

1. På detaljekortet skal du klikke på tandhjulssymbolet for at åbne indstillingerne.

2. I dialogen skal du gå til fanen **∑ Sum**.

3. Vælg de kolonner, du vil inkludere i beregningen. Du kan eventuelt **aktivere gruppering** for at organisere dataene.

    ![Detaljekort indstillinger - sum af beløb og aktiver gruppering -screenshot][img2]

4. Vælg den beregning, der skal udføres på hver kolonne. Tilgængelige muligheder afhænger af felttypen.

**Resultat:**

![Salg detaljekort - sum og gruppering af beløb -screenshot][img3]

> [!NOTE]
> Hvis din organisation bruger flere valutaer, skal du sikre dig, at du arbejder med sammenlignelige værdier i salgsberegningerne. Brug **basisvaluta** versionerne af felterne **Beløb** og **Vægtet beløb** for at sikre nøjagtighed.

![Salg detaljekort - sum af beløb for basisvaluta -screenshot][img5]

## Manuel justering af kolonnebredder

1. Hold musemarkøren over den lodrette streg foran eller bag en kolonneoverskrift. Musemarkøren ændres til en dobbelt lodret streg med pile.

1. Klik og hold museknappen nede, mens du trækker skillelinjen i den ønskede retning, alt efter om du vil øge eller reducere kolonnebredden. Kolonnerne har den valgte bredde, næste gang du åbner programmet.

> [!NOTE]
> Du kan ikke justere kolonnebredder manuelt, hvis **Tilpas kolonnebredde automatisk** er aktiv.

## Juster kolonnebredder automatisk

Du kan angive kolonnernes bredder, så de skal justeres automatisk i henhold til kolonnernes indhold. Når kolonner tilføjes eller fjernes, justeres alle kolonnebredder efter, så de passer bedst muligt hver gang. Hvis der er for mange kolonner til at kunne være på den tilgængelige plads, vises et horisontalt rullefelt.

1. Gå til det detaljekort, du vil redigere.
2. Klik på <i class="ph ph-gear" aria-label="Gear"></i> til højre for kolonneoverskrifterne. Der vises en dialogboks.
3. Vælg **Tilpas kolonnebredde automatisk**.
4. Klik på **OK**.

## Relateret indhold

* [Gruppelister][3]
* [Filtrer detaljekortene][1]
* [Eksport af et detaljekort][2]

<!-- Referenced links -->
[1]: filter.md
[2]: export-archives.md
[3]: group.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/learn/section-tab-sum-amount.png
[img3]: ../../../media/loc/en/learn/group-sales-by-status.png
[img5]: ../../../media/loc/en/sale/currency-adjusted-sale-amount-calculation.png
