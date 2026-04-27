---
uid: help-no-marketing-forms-field-restrictions
title: Begrensninger for skjemafelt
description: Lær hvordan du styrer hvilke felt som er tilgjengelige i skjemaer, og om skjemainnsendinger kan overskrive eksisterende data i disse feltene.
keywords: begrensninger for skjemafelt, skjema, felt, ikke tillat overskriving, overskriving, ikke vis i skjemaer
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: no
---

# Begrensninger for skjemafelt

Begrensninger for skjemafelt lar deg styre hvilke felt som er tilgjengelige i skjemaer, og om en skjemainnsending kan overskrive eksisterende data i disse feltene.

Som standard overskriver ikke skjemainnsendinger eksisterende data. Personen som bygger skjemaet, kan velge å aktivere overskriving for individuelle felt. Bruk feltbegrensninger til å fjerne dette alternativet fra sensitive felt, eller for å forhindre at et felt vises i skjemabyggeren i det hele tatt.

> [!CAUTION]
> Skjemaer på et nettsted kan fylles ut av alle. Å tillate overskriving innebærer risiko, inkludert utilsiktet datatap, uautoriserte endringer i sensitive felt og kompromittert dataintegritet gjennom feilaktige oppføringer. Håndter sensitive felt med forsiktighet.

## Slik administrerer du feltbegrensninger

Feltbegrensninger konfigureres i **Innstillinger og vedlikehold** og krever administratorrettigheter.

1. Gå til **Innstillinger og vedlikehold**.
1. Velg <i class="ph ph-bullseye" aria-hidden="true"></i> **Marketing** fra navigatoren.
1. Velg fanen **Begrensninger for skjemafelt**.

![Admin Marketing - Angi begrensninger for skjemafelt som er synlige i Marketing-skjemaer -screenshot][img1]

## Legg til en feltbegrensning

1. Velg et felt fra nedtrekkslisten i delen **Felt med begrensninger**.
1. Velg begrensningstypen for det feltet.
1. Velg **Lagre**.

Gjenta for å legge til begrensninger for flere felt.

## Begrensningsalternativer

* **Ikke tillat overskriving:** Overskrivingsalternativet fjernes fra dette feltet i alle skjemaer, inkludert skjemaer som allerede er publisert. Feltet er fortsatt tilgjengelig i skjemabyggeren og kan fortsatt legges til skjemaer, men innsendte data vil aldri overskrive eksisterende verdier.

* **Ikke vis i skjemaer:** Feltet fjernes helt fra skjemabyggeren og kan ikke legges til nye skjemaer. Eksisterende publiserte skjemaer som allerede inkluderer feltet, påvirkes ikke.

## Fjern en feltbegrensning

1. Finn feltet i listen **Felt med begrensninger**.
1. Velg fjern-ikonet (<i class="ph ph-x-circle" aria-hidden="true"></i>) ved siden av feltet.
1. Velg **Lagre**.

Fjerning av en begrensning gjenoppretter standard virkemåte. Feltet blir tilgjengelig i skjemabyggeren igjen, og skjemaeieren kan velge om overskriving skal tillates.

## Relatert innhold

* [Feltalternativer][1]
* [Opprette et nytt skjema][2]
* [Administrere skrifttyper for skjemaer][3]

<!-- Referenced links -->
[1]: ../learn/field-options.md
[2]: ../learn/create.md
[3]: manage-fonts.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/admin-marketing-form-field-restrictions.png
