---
uid: help-no-follow-ups
title: Oppfølging
description: Oppfølging - Møte, oppgave, telefonsamtale
keywords: oppfølging, avtale, møte, oppgave, telefon, samtale, dagbok
author: Bergfrid Dias
date: 02.04.2025
version: 10.5.1
topic: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Oppfølging

*Oppfølging* er en samlebetegnelse for [møter](#meeting) og [oppgaver](#todo). En [telefonsamtale](#call) er en hybrid av de to. Disse aktivitetene er tett knyttet til dagboken og fungerer stort sett på samme måte.

Du kan åpne en eksisterende oppfølging ved å dobbeltklikke på den i dagboken eller i detaljkortet **Aktiviteter**.

## Generell informasjon

| Symbol | Egenskap | Beskrivelse |
|:-:|---|---|
| <i class="ph ph-user" aria-label="User"></i> | Eier | Hvem oppfølgingen tilhører. Den opprinnelige oppretteren eller brukeren som oppfølgingen er delegert til. |
| <i class="ph ph-text-align-left" aria-label="Align left"></i> | Tittel | En beskrivende etikett. Flere detaljer kan legges i agendaen. |
| (farget prikk) | Type | En forhåndsdefinert liste over aktiviteter, for eksempel **Møte (eksternt)** og **Telefonmøte**. |
| <i class="ph ph-buildings" aria-label="Company"></i>, <i class="ph ph-user-circle" aria-label="Contact"></i> | Firma / person | Hvem oppfølgingen gjelder. |
| <i class="ph ph-clock" aria-label="Clock"></i> | Tid og dato | Når oppfølgingen starter eller forfaller. |
| <i class="ph ph-arrows-clockwise" aria-label="Recurrence"></i> | Gjentakelse | Om og hvordan oppfølgingen gjentas. |
| (ingen ikon) | Tilgjengelighet | Ledig/opptatt-status. Påvirker konflikthåndtering. |
| <i class="ph ph-bell" aria-label="Bell"></i> | Varsel | Om og når brukeren skal varsles. |
| <i class="ph ph-currency-circle-dollar" aria-label="Sale"></i> | Salg | Et salg knyttet til oppfølgingen. |
| <i class="ph ph-clipboard-text" aria-label="Clipboard"></i> | Prosjekt | Et prosjekt knyttet til oppfølgingen. |
| <i class="ph ph-users" aria-label="Users"></i> | Deltakere | Personer invitert til oppfølgingen. |
| <i class="ph ph-chair" aria-label="Stol"></i></i> | Ressurs | Møterom, lokaler eller annet nødvendig utstyr. |
| <i class="ph ph-map-pin" aria-label="Pin"></i></i> | Sted | Lokasjon eller adresse der møtet finner sted. |

## Opprett ny oppfølging

Uansett hvor du befinner deg i SuperOffice CRM, kan du opprette en ny oppfølging ved å klikke på **Ny**-knappen i toppraden og velge **Møte**, **Oppgave**, eller **Oppfølging**.

> [!NOTE]
> Oppfølgninger opprettet fra dagboken er som standard møter. Du kan imidlertid endre typen før du lagrer.

## Finn dine oppfølginger

I dagboken vises møter og telefonsamtaler i fanene **Dag**, **Uke**, **Måned**, og **Oversikt**, samt i sidepanelene **Dag**, **Måned**, **Neste dag** og **Uke**.

Detaljkortet **Aktiviteter** (i skjermbildene Firma, Person, Salg, Prosjekt og Dagbok) viser alle oppfølginger, inkludert oppgaver.

## Oppfølgingstyper

| Type | Starttid | Sluttid | Varighet | Frist | Vises i | Beskrivelse | Eksempel |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Møte (avtale) | &#10003; | &#10003; | Beregnet | | Kalender | Aktivitet med definert start- og sluttid | Eksternt møte med leverandør |
| Oppgave | | | | &#10003; | Seksjon Aktiviteter | Oppfølging uten starttid | Påminnelse for oppgaver som forfaller til en bestemt tid |
| Oppfølging (samtale) | &#10003; | | &#10003; | | Seksjon Aktiviteter | Telefonsamtale | Innkommende samtale fra kunde |

## <a id="meeting"></a>Møte

Møter er aktiviteter med en definert start- og sluttid. De vises i eierens kalender.

Et møte kan være en enkeltstående hendelse eller en del av en gjentakende serie. Møter som involverer en ressurs og/eller flere deltakere kalles [invitasjoner][5].

Forfalte og utførte møter vil også være synlige i detaljkortet **Aktiviteter**.

### Vanlige scenarioer

| Scenario | Ressurs | 2+ deltakere | Beskrivelse |
|---|:-:|:-:|---|
| Egen tid reservert | | | Du har satt av tid til å jobbe med noe alene. |
| Egen tid og ressurs reservert | &#10003; | | Som ovenfor, men med behov for et møterom eller utstyr. |
| Møte med flere deltakere | &#10003; | &#10003; | En planlagt avtale med flere personer, vanligvis også med en ressurs eller et sted. |

## <a id="todo"></a>Oppgave

En *oppgave* er en oppfølging uten starttid. Den har normalt ingen varighet, men den har alltid en **frist**. Oppgaver brukes ofte til ting du må huske å gjøre innen en bestemt dato.

Som standard finner du oppgaver i dagbokens to-do-liste, hvor de kan hukes av når de er fullført. Hvis du angir en start- og sluttid for en oppgave, vil den også vises i dagboken på den angitte dagen.

## <a id="call"></a>Oppfølging (samtale)

En *samtale* representerer en svært spesifikk handling - telefonsamtalen - og kombinerer egenskaper fra både møter og oppgaver:

* Når du planlegger en samtale, opprettes den som en oppgave med en frist.
* Når samtalen gjennomføres, får den en starttid og ligner nå mer på et møte.
  * Starttidspunktet settes til nåværende klokkeslett.
  * Standard varighet er 15 minutter.

## Standard varighet

Standard varighet er **1 time for møter** og **15 minutter for telefonsamtaler**. For å endre standardverdier:

1. Gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige innstillinger** og velg **Preferanser**.
1. Velg **Standardverdier**.
1. Angi en ny verdi for én eller begge av følgende alternativer, og klikk **Lagre**:
    * **Varighet for ny avtale**
    * **Varighet for ny samtale**

## <a id="more-tab"></a>Mer-fanen

[Mer-fanen][12] viser eventuelle brukerdefinerte felt som er lagt til for oppfølgingen.

## Relatert innhold

* [Opprett en oppfølging][2]
* [Lær mer om aktiviteter][4]

<!-- Referenced links -->
[2]: create-follow-up.md
[4]: ../../learn/basics/activity.md
[5]: invitation/index.md
[12]: ../../custom-objects/learn/more-tab.md
