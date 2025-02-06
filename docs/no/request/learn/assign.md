---
uid: help-no-request-assign
title: Fordelingsmetode
description: Fordelingsmetoder for saker
keywords: sak
author: Hanne Gunnarsson, Christian Mogensen, Bergfrid Dias
date: 02.04.2025
version: 10.5
topic: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: no
---

# Automatiske fordelingsmetoder for saker

For at en sak skal være ditt ansvar, må navnet ditt stå i feltet **Eier** i saken. Dette kan angis manuelt, f.eks. når [saken opprettes][2]. Det kan imidlertid også være et resultat av automatisk fordeling av saker. Slik fordeling avhenger av hvilken kategori saken tilhører, og hvilken fordelingsmetode som er angitt for denne kategorien.

## Fordelingsmetode

| Metode | Beskrivelse |
|---|---|
| Jevn fordeling | Fordeler sakene likt blant medlemmene av kategorien. |
| Vektet fordeling | Fordeler sakene basert på [vekttallene][3] som er angitt for medlemmene av kategorien. |
| Til saksbehandleren med færrest aktive saker | Fordeler nye saker til det kategorimedlemmet som har færrest aktive saker. |
| Ikke fordel | Fordeler ikke saker til bestemte saksbehandlere, men legger alle saker i kø som **Ufordelte**. |

La oss illustrere disse fordelingsmetodene med tre brukere og tre innkommende saker.

![Request assignment methods -screenshot][img1]

### Jevn fordeling

Fordeler saker jevnt blant kategoriens medlemmer i en rundtur-rekkefølge.

![Request assignment methods, even -screenshot][img2]

### Vektet fordeling

Fordeler saker basert på spesifiserte vektinger for hvert medlem i kategorien. For eksempel, hvis medlem A har en vekt på 1, medlem B har 2, og medlem C har 5, vil de over 8 saker bli tildelt proporsjonalt.

Saker tildeles probabilistisk basert på deres vektinger.

![Request assignment methods, weighted][img3]

| Forespørsel | Tilfeldig verdi | Tildelt til |
|---|:-:|---|
| Første forespørsel | 7 | Medlem C |
| Andre forespørsel | 2 | Medlem B |
| Tredje forespørsel | 5 | Medlem C |

![Request assignment methods, weighted -screenshot][img4]

### Til saksbehandleren med færrest aktive saker

Tildeler nye saker til medlemmet med færrest aktive saker.

| Forespørsel | Betingelse | Tildelt til |
|---|---|---|
| Første forespørsel | Medlemmene B og C har færrest saker | Medlem C |
| Andre forespørsel | Medlem B har færrest saker | Medlem B |
| Tredje forespørsel | Alle medlemmer har samme antall saker | Medlem B |

![Request assignment methods, user with fewest open requests -screenshot][img5]

### Ikke fordel

Tildeler ikke saker til spesifikke medlemmer. Alle saker plasseres i en kø som standard.

![Request assignment methods, do not assign -screenshot][img6]

**Hent neste sak i køen**: Hvis køsystemet er satt opp for ditt firma, kan du klikke på dette for å hente den neste ufordelte saken i køen for kategorien du tilhører.

## Angi fordelingsmetode for kategori

En saksbehandler med administrasjonsrettigheter for kategorier kan angi fordelingsmetode for kategorier:

1. [!include[Go to](../../learn/includes/goto-sm.md)]
1. Velg **Saker** > **Kategorier**.
1. Velg ønsket kategori.
1. Velg fanen **Fordelingsmetode**.
1. Velg de ønskede alternativene.
1. Klikk på **OK**.

## Eksempel

<!-- markdownlint-disable-next-line MD034 -->
La oss si at firmaet ditt har opprettet én kategori for hver avdeling i firmaet: Brukerstøtte, Salg, Kontoer osv. Videre har du bestemt at alle e-postmeldinger som sendes til support@company.com, automatisk skal havne i kategorien Brukerstøtte. Alle de ansatte ved brukerstøtteavdelingen er medlemmer av denne kategorien. For denne kategorien har de valgt metoden **Jevn fordeling**. Dette innebærer at alle medlemmene av kategorien får like mange saker, og at hvert av medlemmene fortløpende får nye saker inn i bildet **Egne aktive saker**. Hvis de i stedet hadde valgt metoden **Ikke fordel**, måtte medlemmene selv ha gått inn i bildet **Ufordelte saker** for å [ta eierskap til nye saker][4].

## Hva vil du gjøre nå?

* [Behandle en sak][1]
* [Opprette en sak][2]
* [Godta en sak][4]
* [Be en annen saksbehandler om hjelp (overføring)][5]
* [Hvordan sette opp 'Hent neste sak i køen'][6]

<!-- Referenced links -->
[1]: index.md
[2]: create.md
[4]: accept.md
[5]: transfer.md
[6]: ../admin/next-in-queue.md
[3]: ../admin/category/create.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/assign-requests.png
[img2]: ../../../media/loc/en/request/assign-requests-even.png
[img3]: ../../../media/loc/en/request/assign-requests-weighted-diagram.png
[img4]: ../../../media/loc/en/request/assign-requests-weighted.png
[img5]: ../../../media/loc/en/request/assign-requests-fewest.png
[img6]: ../../../media/loc/en/request/assign-requests-not.png
