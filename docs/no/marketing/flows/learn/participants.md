---
uid: help-no-flow-participants
title: Flytdeltakere
description: En fullstendig oversikt over alle flytdeltakere.
keywords: flyt, markedsføring, deltaker, flytdeltaker, melde på, deltakerstatus
author: Bergfrid Dias
date: 05.24.2024
version: 10.3.5
topic: concept
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Flytdeltakere

## Trinn

For å vise listen over deltakere for en bestemt flyt:

1. Gå til **Markedsføring** > **Flyter**.
1. Klikk for å velge en flyt.
1. Velg fanen **Deltakere**.
1. Velg eventuelt hvordan listen skal grupperes.

![Liste over flytdeltakere -screenshot][img1]

Bruk tannhjulikonet (<i class="ph ph-gear" aria-hidden="true"></i>) i listens topptekst for å tilpasse kolonnene.

![Listen over flytdeltakere, tilpass kolonner -screenshot][img2]

## Deltakerstatus

| Status | Beskrivelse |
|---|---|
| Aktiv | Deltakeren er aktiv i flyten​. |
| Fullført | Deltakeren har fullført alle trinnene i flyten​. |
| Fullført med suksess | Deltakeren har fullført flyten og oppfylt suksesskriteriet. Inkludert i flytens suksessrate​. |
| Dropout | Deltakeren har trukket seg ut, alltid med en spesifisert avbruddsårsak. |
| Avbrutt | Deltakeren vil ikke fullføre flyten fordi en administrator avsluttet den. |

## <a id="logic"></a>Påmelding og progresjon gjennom flyten

Før hvert trinn vurderer SuperOffice CRM om deltakeren kan gå videre.

For alle trinnetyper:

1. Er deltakerens status *Aktiv*?
1. Oppfyller deltakeren det definerte suksesskriteriet?
1. Er personen merket som tidligere ansatt?
1. Er personen lagt til i unntakslisten?

​Ekstra for e-posttrinn:​

1. Er samtykket deres gyldig?​
1. Abonnerer personen på flytabonnementstypen?
1. Har personen registrert e-postadresse?​
1. Er e-postadressen allerede aktiv innenfor flyten?​
1. Er e-postadressen ublokkert?​

Ekstra for SMS-trinn:​

1. Har personen registrert et mobilnummer for SMS?

### Hvordan påvirker suksesskriterier påmelding

* Personer som allerede oppfyller suksesskriteriene vil fortsatt bli lagt til i flyten og telt som suksesser. Progresjonen gjennom flytrinnene avhenger av konfigurasjonen.

* Personer som oppfyller suksesskriteriene etter å ha fullført en flyt, vil ikke bli inkludert i flytens suksessrate, da dette skjedde etter deres aktive deltakelse.

### Hvilken gren følger en deltaker?

I et grensesnitt følger deltakerne den første (venstre) grenen der de oppfyller de spesifiserte betingelsene.

## Oppgaver

* Legg til i utvalg: Inkluderer deltakeren i et statisk utvalg.
* Legg til i flyt: Indikerer at denne personen er foreslått for påmelding i en annen flyt.
* Fjern fra flyt: Fjerner all registrering av deltakelsen til personen i gjeldende flyt.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-participants.png
[img2]: ../../../../media/loc/en/marketing/flow-participant-columns.png
