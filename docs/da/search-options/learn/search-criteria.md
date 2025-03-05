---
uid: help-da-search-criteria
title: Brug af søgekriterier
description: Brug af søgekriterier
keywords: søge, kriterier, finde
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Brug af søgekriterier

Søgekriterier bruger du til at fortælle, hvad du leder efter, for eksempel "firmaer med adresse i Danmark". Søgekriterier bruges flere steder i SuperOffice CRM, blandt andet i skærmbilledet **Find**, og når du skal oprette udvalg. Men uanset hvad du skal bruge kriterierne til, arbejder du med dem på samme måde.

Overalt, hvor du kan tilføje søgekriterier, finder du en lis kriterieliste med de valgte søgekriterier.

Typiske søgninger er der for at hjælpe dig med at komme i gang og oprette din egen søgning efter CRM-data. Når du har valgt en typisk søgning, kan du tilføje og redigere søgekriterierne. Og når du har oprettet en nyttig søgning, som du gerne vil bruge igen, kan du gemme den som et udvalg.

Se denne video for at lære, hvordan du foretager en typisk søgning og ændrer den ved at tilføje nye søgekriterier, eller følg trin for trin-guiden nedenunder:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/gx-vXm-b_7g]

(videolængde – 3:01)

## Tilføjelse af søgekriterier

1. Gå til kriterielisten.
    * Klik på **Find** på toplinjen. Kriterielisten findes under fanen **Kriterier**.
    * Eller gå til det ønskede udvalg, og vælg fanen **Kriterier**.

2. Klik på knappen **Tilføj**.
    Der tilføjes en ny linje i kriterielisten, og der vises en liste med felter at vælge imellem.

3. Vælg det felt, som du vil søge efter oplysninger i. Du kan også [indtaste begyndelsen af navnet][2] i det ønskede felt. Der findes forskellige typer af felter:

    * [Tekststreng](#text)
    * [Ja/nej](#yes-no)
    * [Dato](#date)
    * [Antal](#number)
    * [Liste](#list)
    * [Status](#status)
    * [Tæller](#counter)

4. Vælg værdier for søgekriterierne i de forskellige felter på linjen.

5. Klik på **Tilføj** for at tilføje en ny linje, eller klik på **Eller** for at tilføje et nyt sæt kriterier.

## Typer af felter

### <a id="text"></a>Tekstfelt

Hvis søgefeltet er et tekstfelt (for eksempel et navnefelt), søges der efter den tekst eller de tal, du indtaster. Der vises en liste med følgende indstillinger:

[!include[Search criteria](includes/list-search-criteria.md)]

Vælg én af disse indstillinger, og indtast derefter søgekriterier i tekstfeltet til højre.

### <a id="yes-no"></a>Ja/Nej-felt

Hvis søgefeltet er et Ja/Nej-felt, for eksempel feltet **Ingen udsendelser** i skærmbilledet Firma, vises der to valgmulighedsknapper. Du kan vælge mellem **Ja** og **Nej**.

### <a id="date"></a>Datofelt

Hvis søgefeltet er et datofelt, for eksempel feltet **Dato** i dialogboksen **Dokument**, vises der en liste med følgende alternativer:

[!include[Search criteria](includes/list-date-criteria.md)]

Vælg det ønskede alternativ. Afhængigt af, hvad du vælger, udfyldes feltet automatisk med en dato eller et datointerval, eller du kan angive den ønskede dato. Du kan også vælge en dato i kalenderen, som vises, når du klikker på <i class="ph ph-caret-down" aria-label="Chevron"></i>.

### <a id="number"></a>Talfelt

Hvis søgefeltet indeholder talværdier, for eksempel feltet **Beløb** i skærmbilledet Salg, vises der en liste med følgende alternativer:

[!include[Search criteria](includes/table-number-criteria.md)]

Vælg den ønskede indstilling, og indtast den ønskede talværdi i tekstfeltet til højre.

### <a id="list"></a>Listefelt

Hvis feltet, du skal søge i, indeholder lister, for eksempel feltet **Branche** i skærmbilledet Firma, vises der en liste med indstillingerne **Er en af** og **Er ikke en af**.

Klik på feltet **Vælg elementer** for at få vist listen over værdier.

Hvis listen er lang, kan du skrive tekst i felterne **Søgekriterier** for at søge efter værdier.

Klik uden for listen for at lukke den.

### <a id="status"></a>Statusfelt

Hvis søgefeltet er et statusfelt, skal du blot vælge den ønskede status.

Statusserne oprettes og vedligeholdes i Indstillinger og vedligeholdelse.

Statusfelter er kun aktuelle, hvis du har købt licens til og aktiveret statusovervågning.

### <a id="counter"></a>Tællerfelt

[Tællere][3] kan for eksempel være antal salg i en periode eller datoen for det sidst gennemførte salg.

Tællerfelter kan findes under **Tællere (SAINT)** på listen over kriterier.

1. Til højre for felterne kan du klikke på linkene for at angive yderligere kriterier for tællerne. De tilgængelige indstillinger afhænger af den type post og tæller, du arbejder med.

    * **Saint-type**: Her kan du vælge den aktivitetstype, du vil søge efter.
    * **Status**: Her kan du vælge status for den post, du vil søge efter.
    * **Retning**: Her kan du vælge, om aktiviteten er ind- eller udgående.
    * **Beløbsklasse**: Her vælger du beløbsklassen for salget.
    * **Hensigt**: Her skal du vælge hensigten med aktiviteten.

1. Afhængigt af, hvad du har valgt ovenover, vises der en rullemenu for valg af datofelt eller talfelt. Disse rullemenuer fungerer som beskrevet nedenfor. Vælg den ønskede indstilling, og indtast den ønskede talværdi eller dato i tekstfeltet.

Tællerne oprettes og vedligeholdes i Indstillinger og vedligeholdelse. Tællerværdier er kun aktuelle, hvis du har købt licens til og aktiveret statusovervågning.

## Arbejde med søgekriterier

Kriterielisterne indeholder et sæt standardkriterier, som du kan redigere eller fjerne efter behov.

Når du åbner skærmbilledet **Søg**, indeholder det standardsøgekriterier eller de søgekriterier, du angav, sidst du brugte dialogboksen. Hvis du vil bruge andre søgekriterier end dem, der vises, har du følgende muligheder:

| Opgave | Trin |
|---|---|
| Flytte søgekriterier (en linje) | Klik og træk <i class="ph ph-equals" aria-label="="></i>. |
| Ændre et søgekriterium | Klik på det og vælg et andet på den liste, der vises. |
| Deaktivere et eller flere søgekriterier | Lad værdifeltet være tomt. |
| Deaktivere alle søgekriterierne | Klik **Ryd alle**. |
| Slette et søgekriterium | Klikke på <i class="ph ph-x-circle" aria-label="X"></i>. |
| Nulstille kriterielisten til standardkriterierne | Klik **Nulstil til standard**. |

> [!NOTE]
> At flytte søgekriterier op eller ned har ingen praktisk effekt på søgningen, men giver dig mulighed for at arrangere kriterierne i din foretrukne rækkefølge. Hvis nogle af kriterierne ikke bruges, men du stadig vil beholde dem, kan du flytte inaktive kriterier til bunden, hvis listen vises.
>
> Et deaktiveret søgekriterium bliver stående på kriterielisten og kan nemt og enkelt aktiveres igen.

## Relateret indhold

* [Brug skærmbilledet Søg][1]

<!-- Referenced links -->
[1]: find-screen.md
[2]: in-navigator.md
[3]: ../../saint/learn/index.md
