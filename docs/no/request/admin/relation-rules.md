---
uid: help-no-request-relation-rules
title: Relasjonsregler
description: Lær hvordan du konfigurerer relasjonsregler for å automatisere atferd ved opprettelse og lukking av saker basert på overordnet-underordnet-relasjoner i SuperOffice Service.
keywords: relasjonsregler, saksrelasjon, overordnet-underordnet, relasjonsregel, automatisering, lukke sak, fanen Relasjonsregler
author: digitaldiina
date: 04.08.2026
version: 11.12
content_type: howto
license: servicepremium
audience: settings
audience_tooltip: Settings and maintenance
language: no
index: true
---

# Relasjonsregler

Relasjonsregler definerer automatisk atferd som gjelder når saker opprettes eller lukkes, basert på overordnet-underordnet-relasjoner mellom bestemte sakstyper. De lar deg sikre konsistens i kundestøtteprosessen din — for eksempel ved å blokkere en overordnet sak fra å bli lukket før alle underordnede saker er løst, eller ved å oppfordre agenter til å lukke relaterte saker samlet.

> [!NOTE]
> Regler utløser automatiske handlinger kun i brukergrensesnittet for saker. API- og CRMScript-operasjoner påvirkes ikke.

## Hva er en relasjonsregel?

En relasjonsregel består av:

* **Betingelse:** hvilke sakstyper regelen gjelder for (kilde og mål).
* **Atferd:** hva som skjer automatisk når saker som oppfyller betingelsen opprettes eller lukkes.

## Hvor finner jeg relasjonsregler?

Velg **Saker** i navigatoren i **Innstillinger og vedlikehold**, og gå til fanen **Relasjonsregler**.

![Innstillinger og vedlikehold, Relasjonsregler -screenshot][img1]

[!include[Begrenset tilgang](../../learn/includes/note-insufficient-rights.md)]

## Innstillinger

### Betingelse

| Felt | Beskrivelse |
|---|---|
| Fra (kilde) | Én eller flere kildesakstyper. |
| Relasjon | Relasjonstypen (Overordnet eller Underordnet). |
| Til (mål) | Én eller flere målsakstyper. |

Oppsummeringslinjen under betingelsen bekrefter regelens fulle omfang på et klart språk. En advarsel vises hvis betingelsen overlapper med en eksisterende regel.

### Atferd: Ved opprettelse

| Alternativ | Beskrivelse |
|---|---|
| **Forutsetter at overordnet er angitt** | Forhindrer lagring av en ny sak med mindre en overordnet sak er angitt. Gjelder kun hvis feltet **Overordnet** er lagt til i saksskjermbildet i [Screen Designer][3]. |

### Atferd: Ved lukking

| Alternativ | Beskrivelse |
|---|---|
| **Forhindre at den overordnede saken lukkes før alle underordnede saker er lukket** | Blokkerer den overordnede saken fra å bli lukket mens underordnede saker fortsatt er åpne. |
| **Tilby å lukke overordnet sak når alle underordnede saker lukkes** | Når den siste underordnede saken lukkes, oppfordres agenten til å lukke den overordnede saken. |
| **Tilby å lukke underordnede saker og sende melding når overordnet sak lukkes** | Når den overordnede saken lukkes, oppfordres agenten til å lukke alle åpne underordnede saker og legge til et svarmelding i hver, som sendes til mottakerne. |

## Legg til relasjonsregel

1. Velg **Saker** i navigatoren i **Innstillinger og vedlikehold**, og gå til fanen **Relasjonsregler**.

1. Klikk på knappen **Legg til**.

    ![Legg til relasjonsregel -screenshot][img2]

1. Angi et **Navn på regel** og eventuelt en **Beskrivelse**.

1. I delen **Betingelse** velger du **Relasjon**-typen og deretter én eller flere sakstyper i feltene **Fra (kilde)** og **Til (mål)**. Oppsummeringslinjen under betingelsen bekrefter hva regelen gjelder for.

    > [!NOTE]
    > Hvis betingelsen overlapper med en eksisterende regel, vises en konfliktadvarsel. Juster sakstypene for å løse konflikten før du lagrer.

1. I delen **Atferd** merker du av alternativene du vil aktivere for **Ved opprettelse** og **Ved lukking**.

1. Klikk på **Lagre**.

## Rediger relasjonsregel

1. I fanen **Relasjonsregler** klikker du på regelen i listen til venstre.

1. Gjør endringene dine.

1. Klikk på **Lagre**.

## Slett relasjonsregel

1. I fanen **Relasjonsregler** velger du regelen i listen til venstre.

1. Klikk på knappen **Slett** nederst i listen.

## Eksempel: Insidenthåndtering

Et stort serviceavbrudd genererer flere individuelle problemrapporter fra berørte kunder. Hver kunderapport registreres som en underordnet sak knyttet til en felles insiden som den overordnede saken.

* **Forhindre at den overordnede saken lukkes før alle underordnede saker er lukket:** holder insidenten åpen til alle problemrapporter er håndtert, og sikrer at ingenting overses.

* **Tilby å lukke overordnet sak når alle underordnede saker lukkes:** når den siste problemrapporten er løst, oppfordres agenten til å lukke insidenten.

* **Tilby å lukke underordnede saker og sende melding når overordnet sak lukkes:** når insidenten er løst, kan agenten lukke alle gjenværende underordnede saker på én gang og svare direkte til hver berørte kunde om at problemet er løst.

## Relatert innhold

* [Saksrelasjoner][1]
* [Sakstyper][2]

<!-- Referenced links -->
[1]: ../learn/request-relations.md
[2]: type/index.md
[3]: ../../customization/screen-designer/admin/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/request/relation-rules.png
[img2]: ../../../../media/loc/en/request/add-relation-rule.png
