---
uid: help-da-request-assign
title: Fordelingsmetoder
description: Tildelingsmetoder for sager
author: Hanne Gunnarsson
so.date: 02.14.2023
keywords: sag
so.topic: concept
so.audience: person
so.audience.tooltip: SuperOffice Service
language: da
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

[!include[Get next request in queue](includes/howto-get-next-request.md)]

### Angiv tildelingsmetode for kategori

En sagsbehander med kategoriadministrationsrettigheder kan angive fordelingsmetode for kategorier:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Vælg **Sager** > **Kategorier**.
1. Vælg den ønskede kategori.
1. Vælg fanen **Fordelingsmetode**.
1. Vælg de relevante indstillinger.
1. Klik på **OK**.

## Eksempel

Lad os sige, at din virksomhed har oprettet én kategori for hver afdeling i virksomheden: Brugersupport, Salg, Konti osv. Du har desuden angivet, at alle e-mails, der sendes til <support@company.com>, automatisk skal havne i kategorien "Brugersupport". Alle de ansatte i brugersupportafdelingen er medlemmer af denne kategori. De har for denne kategori valgt tildelingsreglen **Jævn fordeling**. Dette indebærer, at alle medlemmerne af kategorien får lige mange sager, og at hvert medlem løbende får nye sager ind i skærmbilledet **Egne aktive sager**. Hvis de i stedet havde valgt fordelingsreglen **Fordel ikke**, skulle medlemmerne selv være gået i skærmbilledet **Ikke fordelte sager** for at [overtage ansvaret for sager][4].

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
