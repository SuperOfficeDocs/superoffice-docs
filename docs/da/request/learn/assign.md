---
uid: help-da-request-assign
title: Tildelingsmetoder
description: Tildelingsmetoder for sager
keywords: automatisk fordeling, fordelingsmetode, tildelingsmetode, tildel sag, sag
author: Hanne Gunnarsson, Christian Mogensen, Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: da
---

# Automatiske tildelingsmetoder for sager

For at en sag skal være dit ansvar, skal dit navn fremgå i sagens **Ejer**-felt. Dette kan indstilles manuelt, f.eks. når [sagen oprettes][2]. Men det kan også være resultatet af automatisk tildeling. Sådan tildeling afhænger af den kategori, sagen tilhører, og den fordelingsmetode, der er angivet for denne kategori.

## Fordelingsmetoder

| Metode | Beskrivelse |
|---|---|
| Jævn fordeling | Fordeler sagerne ligeligt blandt medlemmerne af kategorien. |
| Vægtet fordeling | Fordeler sagerne ud fra de [vægtninger][3], der er angivet for medlemmerne af kategorien. |
| Til sagsbehandleren med færrest aktive sager | Fordeler nye sager til det kategorimedlem, der har færrest aktive sager. |
| Fordel ikke | Fordeler ikke sager til specifikke sagsbehandlere, men sætter alle sager i kø som **Ufordelt**. |

Lad os illustrere disse fordelingsmetoder med tre brugere og tre indkommende sager.

![Fordelingsmetoder for sager -screenshot][img1]

### Jævn fordeling

Fordeler sagerne jævnt mellem kategorimedlemmerne i en rundkørselsmåde.

![Jævn fordeling af sager -screenshot][img2]

### Vægtet fordeling

Fordeler sager baseret på specifikke vægtninger for hvert medlem af kategorien. For eksempel, hvis medlem A har en vægt på 1, medlem B har 2, og medlem C har 5, vil de over 8 sager blive tildelt proportionalt.

Sager tildeles probabilistisk baseret på deres vægtninger.

![Vægtet fordeling af sager][img3]

| Sag | Tilfældig værdi | Tildelt til |
|---|:-:|---|
| Første sag | 7 | Medlem C |
| Anden sag | 2 | Medlem B |
| Tredje sag | 5 | Medlem C |

![Vægtet fordeling af sager -screenshot][img4]

### Til sagsbehandleren med færrest aktive sager

Tildeler nye sager til medlemmet med færrest aktive sager.

| Sag | Betingelse | Tildelt til |
|---|---|---|
| Første sag | Medlemmerne B og C har færrest sager | Medlem C |
| Anden sag | Medlem B har færrest sager | Medlem B |
| Tredje sag | Alle medlemmer har samme antal sager | Medlem B |

![Fordeling til sagsbehandler med færrest aktive sager -screenshot][img5]

### Fordel ikke

Tildeler ikke sager til specifikke medlemmer. Alle sager placeres som standard i en kø.

![Ingen fordeling af sager -screenshot][img6]

**Hent næste sag i køen**: Hvis køsystemet er konfigureret for dit firma, kan du klikke på denne valgmulighed for at få den næste ufordelte sag i køen for den kategori, du tilhører.

## Angiv tildelingsmetode for kategori

En sagsbehander med kategoriadministrationsrettigheder kan angive fordelingsmetode for kategorier:

1. [!include[Go to](../../learn/includes/goto-sm.md)]
1. Vælg **Sager** > **Kategorier**.
1. Vælg den ønskede kategori.
1. Vælg fanen **Fordelingsmetode**.
1. Vælg de relevante indstillinger.
1. Klik på **OK**.

## Eksempel

<!-- markdownlint-disable-next-line MD034 -->
Lad os sige, at din virksomhed har oprettet én kategori for hver afdeling i virksomheden: Brugersupport, Salg, Konti osv. Du har desuden angivet, at alle e-mails, der sendes til support@company.com, automatisk skal havne i kategorien "Brugersupport". Alle de ansatte i brugersupportafdelingen er medlemmer af denne kategori. De har for denne kategori valgt tildelingsreglen **Jævn fordeling**. Dette indebærer, at alle medlemmerne af kategorien får lige mange sager, og at hvert medlem løbende får nye sager ind i skærmbilledet **Egne aktive sager**. Hvis de i stedet havde valgt fordelingsreglen **Fordel ikke**, skulle medlemmerne selv være gået i skærmbilledet **Ikke fordelte sager** for at [overtage ansvaret for sager][4].

## Relateret indhold

* [Behandl en sag][1]
* [Opret en sag][2]
* [Acceptér en sag][4]
* [Bed en anden sagsbehandler om hjælp (overførsel)][5]
* [Sådan konfigurerer du Hent næste sag i køen][6]

<!-- Referenced links -->
[1]: index.md
[2]: create.md
[3]: ../admin/category/create.md
[4]: accept.md
[5]: transfer.md
[6]: ../admin/next-in-queue.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/assign-requests.png
[img2]: ../../../media/loc/en/request/assign-requests-even.png
[img3]: ../../../media/loc/en/request/assign-requests-weighted-diagram.png
[img4]: ../../../media/loc/en/request/assign-requests-weighted.png
[img5]: ../../../media/loc/en/request/assign-requests-fewest.png
[img6]: ../../../media/loc/en/request/assign-requests-not.png
