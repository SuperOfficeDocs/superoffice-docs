---
uid: help-da-request-assign
title: Fordelingsmetoder
description: Tildelingsmetoder for sager
keywords: sag
author: Hanne Gunnarsson, Christian Mogensen, Bergfrid Dias
date: 06.11.2024
version: 10
language: da
topic: concept
audience: person
audience_tooltip: SuperOffice Service
---

# Automatiske tildelingsmetoder for sager

Hvis en sag skal være dit ansvar, skal dit navn fremgå i sagens **Ejer**-felt. Dette kan gøres manuelt, f.eks. når [sagen oprettes][2]. Men det kan også være et resultat af automatisk tildeling af sagen. Sådanne opgaver afhænger af den kategori, sagen tilhører, og den opgavemetode, der er specificeret for denne kategori.

## Fordelingsmetoder

| Metode | Beskrivelse |
|---|---|
| Jævn fordeling | Fordeler sagerne ligeligt blandt medlemmerne af kategorien. |
| Vægtet fordeling | Fordeler sagerne ud fra de [vægtede tal][3], der er angivet for medlemmerne af kategorien. |
| Til sagsbehandleren med færrest aktive sager | Fordeler nye sager til det kategorimedlem, der har færrest aktive sager. |
| Fordel ikke | Fordeler ikke sager til bestemte sagsbehandlere, men sætter alle sager i kø som **Ufordelt**. |

Lad os illustrere disse tildelingsmetoder med tre brugere og tre indkommende sager.

![Request assignment methods -screenshot][img1]

### Jævn

Tildeler sager jævnt blandt kategorimedlemmerne i en rundkørselsmåde.

![Request assignment methods, even -screenshot][img2]

### Vægtet

Tildeler sager baseret på specifikke vægtninger for hvert medlem af kategorien. For eksempel, hvis medlem A har en vægt på 1, medlem B har 2, og medlem C har 5, vil de over 8 sager blive tildelt proportionalt.

sager tildeles probabilistisk baseret på deres vægtninger.

![Request assignment methods, weighted][img3]

| Sag | Tilfældig værdi | Tildelt til |
|---|:-:|---|
| Første sag | 7 | Medlem C |
| Anden sag | 2 | Medlem B |
| Tredje sag | 5 | Medlem C |

![Request assignment methods, weighted -screenshot][img4]

### Til sagsbehandleren med færrest aktive sager

Tildeler nye sager til medlemmet med færrest aktive sager.

| Sag | Betingelse | Tildelt til |
|---|---|---|
| Første sag | Medlemmerne B og C har færrest sager | Medlem C |
| Anden sag | Medlem B har færrest sager | Medlem B |
| Tredje sag | Alle medlemmer har samme antal sager | Medlem B |

![Request assignment methods, user with fewest open requests -screenshot][img5]

### Tildel ikke

Tildeler ikke sager til specifikke medlemmer. Alle sager placeres som standard i en kø.

![Request assignment methods, do not assign -screenshot][img6]

[!include[Get next request in queue](includes/howto-get-next-request.md)]

## Angiv tildelingsmetode for kategori

En sagsbehander med kategoriadministrationsrettigheder kan angive fordelingsmetode for kategorier:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Vælg **Sager** > **Kategorier**.
1. Vælg den ønskede kategori.
1. Vælg fanen **Fordelingsmetode**.
1. Vælg de relevante indstillinger.
1. Klik på **OK**.

## Eksempel

<!-- markdownlint-disable-next-line MD034 -->
Lad os sige, at din virksomhed har oprettet én kategori for hver afdeling i virksomheden: Brugersupport, Salg, Konti osv. Du har desuden angivet, at alle e-mails, der sendes til support@company.com, automatisk skal havne i kategorien "Brugersupport". Alle de ansatte i brugersupportafdelingen er medlemmer af denne kategori. De har for denne kategori valgt tildelingsreglen **Jævn fordeling**. Dette indebærer, at alle medlemmerne af kategorien får lige mange sager, og at hvert medlem løbende får nye sager ind i skærmbilledet **Egne aktive sager**. Hvis de i stedet havde valgt fordelingsreglen **Fordel ikke**, skulle medlemmerne selv være gået i skærmbilledet **Ikke fordelte sager** for at [overtage ansvaret for sager][4].

## Hvad vil du foretage dig nu?

* [Behandl en sag][1]
* [Opret en sag][2]
* [Acceptér en sag][4]
* [Bed en anden sagsbehandler om hjælp (overførsel)][5]

<!-- Referenced links -->
[1]: ../index.md
[2]: create.md
[3]: ../category/create.md
[4]: accept.md
[5]: transfer.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/request/assign-requests.png
[img2]: ../../../../media/loc/en/request/assign-requests-even.png
[img3]: ../../../../media/loc/en/request/assign-requests-weighted-diagram.png
[img4]: ../../../../media/loc/en/request/assign-requests-weighted.png
[img5]: ../../../../media/loc/en/request/assign-requests-fewest.png
[img6]: ../../../../media/loc/en/request/assign-requests-not.png
