---
uid: help-da-flow-update
title: Opdater flow
description: Opdater flow
keywords: Marketing, flow
author: Bergfrid Dias, Trude Lien Smedbråten
date: 06.14.2024
version: 10.3.5
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Opdater flow

Det er nyttigt at starte med en simpel flow og udvide den efter at have overvåget dens ydeevne. Du vil måske også opdatere et flow, mens du designer den.

For at foretage ændringer:

1. [Paus flowet][1].
2. Klik på **Rediger**.
3. Foretag de nødvendige ændringer.
4. Klik på **Gem**.
5. Genstart flowet.

> [!NOTE]
> Ændringer, du foretager i et trin, påvirker kun nye deltagere og aktive deltagere, der endnu ikke har nået det trin.

## Opdater flowindstillinger, succeskriterier og/eller trigger

Samme som ved [oprettelse af et flow][2].

## Tilføj trin

Samme som ved [oprettelse af et flow][3].

## Opdater trinindstillinger

1. Klik på et trin i flowdiagrammet for at åbne trinindstillingerne.
2. Afhængigt af trinets type kan du:

   * Opdater egenskaberne for nye aktiviteter.
   * Tilføj e-mailindhold og/eller vedhæftninger.
   * Forlæng eller forkort ventetiden.
   * Tilføj eller fjern handlinger.
   * Vælg et statisk udvalg, et projekt eller et flow at overføre deltageren til.
   * Ændre rækkefølgen af grene, omdøbe grene, tilføj en gren.
   * Opdatere betingelser i en opdeling.

3. Klik på **Gem**.

Du kan finde disse ressourcer nyttige:

* [Liste over tilgængelige indstillinger for hvert trin][6].
* [Opdel flow][5]
* [Ventetid og vent på handling][4]
* [Tilføj indhold][7]
* [Opret aktivitet][9]
* [Opdater person][8]
* [Opret udvalg][11]
* [Opret formular][10]

## Flyt, dupliker eller fjern trin

* **Flyt:** Klik på et trin og træk det til en ny placering.
* **Dupliker:** Peg på et trin og klik på **Dupliker**-ikonet (<i class="ph ph-copy" aria-hidden="true"></i>). Dette opretter et nyt trin baseret på det aktuelle og tilføjer det som det næste trin. Brug denne mulighed til at genbruge et trin i samme flow.
* **Fjern:** Peg på et trin og klik på det røde X. Dette fjerner trinnet fra flowet (men ikke dets indhold).

> [!NOTE]
> Når du duplikerer et e-mailtrin, opretter Floweditoren også en **kopi af e-mailindholdet**. Du kan redigere dette nye stykke flowindhold uafhængigt af e-mailindholdet i det trin, der blev duplikeret.
>
> Når du fjerner et e-mailtrin, fjernes kun trinnet fra flowet. E-mailindholdet fjernes eller slettes ikke.

## Slet flow

[Se *Kør, pause og afslut flow*][1]

## Fejlfinding

Der er et par begrænsninger, når du redigerer et flow efter, at den er kørt, for at beskytte aktive deltagere (med andre ord: for at forhindre, at du roder det til).

### Kan ikke redigere flow

* Du kan ikke redigere et flow der er i gang. Pause flowet og prøv igen.
* Hvis **Rediger**-knappen stadig er grå, har du ikke den nødvendige funktionelle ret 'Flowadministrator'.

### Kan ikke flytte eller fjerne trin

* Du kan ikke flytte eller fjerne et **Ventetid**, **Vent på handling** eller **Del** trin, hvis der er aktive deltagere i trinnet.

Gå til fanen **Deltagere** og tjek kolonnen **Aktuelt trin** for at finde et passende tidspunkt at pause og opdatere flowkontroltrinnet.

### Kan ikke fjerne gren

* Du kan ikke fjerne grenen 'Alle andre'.
* Du kan ikke fjerne en gren, hvis der er aktive deltagere på den.

Gå til fanen **Flow** for at kontrollere, om der er nogen på grenen. Hvis ja, gå til fanen **Deltagere** for detaljer. Hvordan man håndterer disse deltagere er op til dig. Nogle muligheder at overveje:

* Tilføj deltagere til et statisk udvalg for at følge op senere.
* Tilføj deltagere til flowets udelukkelsesliste.
* Fjern deltagere fra flowet ved hjælp af **Opgave**-menuen.
* Vent på, at grenen "tømmes". Du skal muligvis opdatere grenens betingelse for at forhindre, at nye deltagere kommer ind.

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
