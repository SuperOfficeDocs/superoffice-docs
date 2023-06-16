---
uid: help-no-request-assign
title: Fordelingsmetode
description: Fordelingsmetoder for saker
author: Hanne Gunnarsson
so.date: 02.14.2023
keywords: sak
so.topic: concept
so.audience: person
so.audience.tooltip: SuperOffice Service
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

[!include[Get next request in queue](includes/howto-get-next-request.md)]

### Angi fordelingsmetode for kategori

En saksbehandler med administrasjonsrettigheter for kategorier kan angi fordelingsmetode for kategorier:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Velg **Saker** > **Kategorier**.
1. Velg ønsket kategori.
1. Velg fanen **Fordelingsmetode**.
1. Velg de ønskede alternativene.
1. Klikk på **OK**.

## Eksempel

La oss si at firmaet ditt har opprettet én kategori for hver avdeling i firmaet: Brukerstøtte, Salg, Kontoer osv. Videre har du bestemt at alle e-postmeldinger som sendes til support@company.com, automatisk skal havne i kategorien Brukerstøtte. Alle de ansatte ved brukerstøtteavdelingen er medlemmer av denne kategorien. For denne kategorien har de valgt metoden **Jevn fordeling**. Dette innebærer at alle medlemmene av kategorien får like mange saker, og at hvert av medlemmene fortløpende får nye saker inn i bildet **Egne aktive saker**. Hvis de i stedet hadde valgt metoden **Ikke fordel**, måtte medlemmene selv ha gått inn i bildet **Ufordelte saker** for å [ta eierskap til nye saker][4].

## Hva vil du gjøre nå?

* [Behandle en sak][1]
* [Opprette en sak][2]
* [Godta en sak][4]
* [Be en annen saksbehandler om hjelp (overføring)][5]

<!-- Referenced links -->
[1]: ../index.md
[2]: create.md
[3]: ../category/create.md
[4]: accept.md
[5]: transfer.md

<!-- Referenced images -->
