---
uid: help-no-flow-update
title: Oppdater flyt
description: Oppdater flyt
keywords: flyt, markedsføring, rediger flyt
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
topic: howto
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Oppdater flyt

Det er nyttig å begynne med en enkel flyt og utvide den etter hvert som du overvåker ytelsen. Du kan også ønske å oppdatere en flyt mens du designer den.

For å gjøre endringer:

1. [Pause flyten][1].
1. Klikk på **Rediger**.
1. Gjør de nødvendige endringene.
1. Klikk på **Lagre**.
1. Start flyten på nytt.

> [!NOTE]
> Endringene du gjør på et trinn påvirker bare nye deltakere og aktive deltakere som ennå ikke har nådd det trinnet.

## Oppdater flytinnstillinger, suksesskriterier og/eller trigger

Det samme som når du [oppretter en flyt][2].

## Legg til trinn

Det samme som når du [oppretter en flyt][3].

## Oppdater trinninnstillinger

1. Klikk på et trinn i flytskjemaet for å åpne trinninnstillingene.
1. Avhengig av trinnets type, kan du:

    * Oppdatere egenskaper for nye aktiviteter.
    * Legge til e-postinnhold og/eller vedlegg.
    * Forlenge eller forkorte ventetiden.
    * Legge til eller fjerne handlinger.
    * Velge et statisk utvalg, et prosjekt eller en flyt å overføre deltakeren til.
    * Endre rekkefølgen på grener, gi nye navn til grener, legge til en gren.
    * Oppdatere vilkårene i en oppdeling.

1. Klikk på **Lagre**.

Du kan finne disse ressursene nyttige:

* [liste av tilgjengelige innstillinger for hvert trinn][6].
* [Del flyt][5]
* [Ventetid og Vent på hendelse][4]
* [Legg til innhold][7]
* [Opprett aktivitet][9]
* [Oppdater person][8]
* [Opprett utvalg][11]
* [Opprett skjema][10]

## Flytt, dupliser eller fjern trinn

* **Flytt:** Klikk på et trinn og dra det til en ny plassering.
* **Dupliser:** Pek på et trinn og klikk på **dupliser**-ikonet (<i class="ph ph-copy" aria-hidden="true"></i>). Dette oppretter et nytt trinn basert på det nåværende og legger det til som det neste trinnet. Bruk denne opsjonen for å gjenbruke et trinn i samme flyt.
* **Fjern:** Pek på et trinn og klikk på den røde X. Dette fjerner trinnet fra flyten (men ikke innholdet).

> [!NOTE]
> Når du dupliserer et e-posttrinn, opprettes også en **kopi av e-postinnholdet**. Du kan redigere dette nye flytinnholdet uavhengig av e-postinnholdet i trinnet som ble duplisert.
>
> Når du fjerner et e-posttrinn, fjernes bare trinnet fra flyten. E-postinnholdet verken fjernes eller slettes.

## Slett flyt

[Se *Kjør, pause og avslutt flyt*.][1]

## Feilsøking

Det er noen begrensninger når du redigerer en flyt etter at den er startet for å beskytte aktive deltakere (med andre ord: for å forhindre at du rotet det til).

### Kan ikke redigere flyt

* Du kan ikke redigere en kjørende flyt. Pause flyten og prøv igjen.
* Hvis **Rediger**-knappen fremdeles er grå, mangler du den nødvendige funksjonelle retten 'Flytadministrator'.

### Kan ikke flytte eller fjerne trinn

* Du kan ikke flytte eller fjerne et **Ventetid**, **Vent på hendelse**, eller **Del**-trinn hvis det er aktive deltakere på trinnet.

Gå til fanen **Deltakere** og sjekk kolonnen **Gjeldende trinn** for å finne et passende tidspunkt å pause og oppdatere flytkontrolltrinnet.

### Kan ikke fjerne gren

* Du kan ikke fjerne grenen 'Alle andre'.
* Du kan ikke fjerne en gren hvis det er aktive deltakere på den.

Gå til fanen **Flyt** for å sjekke om det er noen på grenen. Hvis ja, gå til fanen **Deltakere** for detaljer. Hvordan du håndterer disse deltakerne er opp til deg. Noen alternativer å vurdere:

* Legg deltakere til et statisk utvalg for oppfølging senere.
* Legg deltakere til flytens ekskluderingsliste.
* Fjern deltakere fra flyten ved å bruke **Oppgave**-menyen.
* Vent til grenen "tømmes". Du må kanskje oppdatere betingelsen til grenen for å hindre at nye deltakere kommer inn.

<!-- Referenced links -->
[1]: run-pause-end.md
[2]: create.md
[3]: create.md#add-step
[4]: create.md#wait
[5]: split.md
[6]: step-settings.md
[7]: content.md
[8]: define-flow-actions.md#update
[9]: define-flow-actions.md#create
[10]: ../../forms/learn/create.md
[11]: ../../../search-options/selection/learn/create/tutorial.yml
