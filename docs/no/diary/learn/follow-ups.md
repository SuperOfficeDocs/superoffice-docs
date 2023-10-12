---
uid: help-no-follow-ups
title: Oppfølging
description: Oppfølging - Avtale, oppgave, telefonsamtale
author: Bergfrid Dias
so.date: 10.05.2023
keywords: dagbok, oppfølging, avtale, møte,  telefon, samtale
so.topic: concept
language: no
---

# Oppfølging

*Oppfølginger* er et samlebegrep for aktivitetene avtale, oppgave og samtale. Disse er nært knyttet til Dagbok-bildet fungerer stort sett på samme måte.

Åpne en tidligere registrert oppfølging ved å dobbeltklikke på den i dagboken eller i detaljkortet **Aktiviteter**.

## Generell informasjon

| Ikon | Egenskap | Beskrivelse |
|:-:|---|---|
| ![ikon][img9]| Eier | Hvem oppfølgingen tilhører. Den opprinnelige oppretteren eller den tilknyttede personen som oppfølgingen ble tildelt/delegerades til. |
| ![ikon][img3]| Tittel | En beskrivende etikett. Ytterligere detaljer legges til i agendaen. |
| (en farget prikk) | Type | En forhåndsdefinert liste over aktiviteter som for eksempel Møte (eksternt) og Telefonmøte. |
| ![ikon][img7], ![ikon][img8] | Firma / kontakt | Hvem oppfølgingen gjelder. |
| ![ikon][img10]| Tid og dato | Når oppfølgingen starter eller er forfalt. |
| ![ikon][img4]| Gjentakelse | Om og hvordan oppfølgingen gjentas. |
| (ingen ikon) | Tilgjengelighet | Ledig/opptatt. Påvirker konflikthåndtering. |
| ![ikon][img2] | Varsel | Om og når å varsle personen. |
| ![ikon][img5] | Salg | Et salg knyttet til oppfølgingen. |
| ![ikon][img6] | Prosjekt | Et prosjekt knyttet til oppfølgingen. |

## Opprett ny

Uansett hvor i SuperOffice CRM du er, kan du opprette en ny oppfølging ved å klikke på **Ny**-knappen i toppraden og deretter velge **Avtale**, **Oppgave**, eller **Samtale**.

> [!NOTE]
> Oppfølgninger opprettet fra dagboken er som standard avtaler. Du kan imidlertid endre typen før du lagrer.

## Finn dine oppfølginger

I Dagbok-bildet vises avtaler og telefonsamtaler på fanene **Dag**, **Uke**, **Måned**, og **Vis**, samt i sidepanelene **Dag**, **Måned**, **Neste dag** og **Uke**.

Detaljkortet **Aktiviteter** på skjermbildet Firma, Personer, Salg, Prosjekt, Dagbok viser alle oppfølginger, inkludert oppgaver.

## Oppfølgingstyper

| Type | Starttid | Sluttid | Varighet | Frist | Vises i | Beskrivelse | Eksempel |
|---|:-:|:-:|:-:|:-:|---|---|---|
| Avtale (møte) | &#10003; | &#10003; | Beregnet | | Kalender | Aktivitet med definert start- og sluttid | Eksternt møte med leverandør |
| Oppgave (To-do) | | | | &#10003; | Seksjon Aktiviteter | Oppfølging uten starttid | Påminnelse for oppgaver som forfaller til en bestemt tid |
| Samtale (oppfølging) | &#10003; | | &#10003; | | Seksjon Aktiviteter | Telefonsamtale | Innkommende samtale fra kunde |

## <a id="apt" /> Avtale

Avtaler er oppfølginger med definert start- og sluttid, for eksempel møter. De vises i eierens kalender.

En avtale kan være en enkelt hendelse eller en del av en gjentakende serie. Avtaler som involverer en ressurs og/eller ekstra deltakere kalles [invitasjoner][5] (eller gruppebestillinger).

Forfalte og fullførte avtaler vil vises i seksjonen **Aktiviteter**-fanen i tillegg til i kalenderen.

### Vanlige scenarioer

| Scenario | Ressurs | 2+ deltakere | Beskrivelse |
|---|:-:|:-:|---|
| Egen tid reservert | | | Du har satt av tid til å jobbe med noe alene |
| Egen tid og ressurs reservert | &#10003; | | Som ovenfor, pluss behov for rom eller utstyr |
| Møte med flere deltakere | &#10003; | &#10003; | Et møte, vanligvis også med en ressurs eller sted |

## <a id="task" />Oppgave

En *oppgave* er en oppfølging uten starttid. Den har vanligvis heller ingen varighet, men den har alltid en **frist**. Oppgaver brukes vanligvis for ting du må huske å gjøre innen en bestemt tid.

Som standard finner du oppgaver i dagbokens "to-do"-liste, hvor de kan krysses av når de er fullført. Hvis du angir et start- og sluttidspunkt for en oppgave, legges det inn i dagboken på riktig dag og klokkeslett.

## <a id="call" />Samtale

En *samtale* er en oppfølging som representerer en svært spesifikk handling - telefonsamtalen. For eksempel ønsker du å registrere et utgående telefonanrop.

Det er også en hybrid mellom en avtale og en oppgave:

* Når du først planlegger en samtale, befinner den seg i "to-do"-listen med en frist, akkurat som en oppgave.
* Når du utfører samtalen, blir den knyttet til et tidspunkt og ligner nå en avtale.
  * Starttiden blir gjeldende tidspunkt og dagens dato.
  * Standardvarigheten er 15 minutter.

## Standard varighet

Standard varighet for en avtale er én time og 15 minutter for en samtale. For å endre standardverdier:

1. Gå til ![ikon][img14] **Personlige innstillinger** og velg **Preferanser**.
1. Velg **Standardverdier**.
1. Skriv inn en verdi for én eller begge av disse verdiene og klikk **Lagre**.
    * **Varighet på ny avtale**
    * **Varighet på ny samtale**

## Aktuelt innhold

* [Opprett avtaler, oppgaver, samtaler][2]
* [Finne ut mer om aktiviteter][4]

<!-- Referenced links -->
<!-- Referenced links -->
[2]: create-follow-up.md
[4]: ../../learn/basics/activity.md
[5]: invitation/index.md

<!-- Referenced images -->
[img2]: ../../../../common/icons/diary-alarm.png
[img3]: ../../../../common/icons/title.png
[img4]: ../../../../common/icons/diary-recurring-transparent.png
[img5]: ../../../../common/icons/sale.png
[img6]: ../../../../common/icons/singlecolour/project.png
[img7]: ../../../../common/icons/singlecolour/contact.png
[img8]: ../../../../common/icons/person.png
[img9]: ../../../../common/icons/associate-current.png
[img10]: ../../../../common/icons/now.png
[img14]: ../../../media/icons/personal-settings-small.png
