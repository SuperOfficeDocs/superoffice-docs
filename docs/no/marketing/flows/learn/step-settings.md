---
uid: help-no-flow-step-settings
title: Trinninnstillinger
description: Oversikt over innstillinger for de ulike flyttrinnene.
keywords: flyt, markedsføring, automatisering, trinn, trinninnstilling, trinnfelt
author: Bergfrid Dias
date: 09.17.2024
version: 10.3.9
topic: reference
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Trinninnstillinger

> [!NOTE]
> Mange felt har en liste av forhåndsdefinerte verdier du kan velge fra. Klikk på <i class="ph ph-caret-down" aria-label="Chevron"></i> for å utvide listen. Deretter velger du en verdi for det feltet. Alternativt kan du begynne å skrive i feltet for å søke etter en spesifikk verdi, for eksempel et utvalgsnavn.

## Legg til i utvalg og/eller prosjekt

| Innstilling | Beskrivelse |
|---|---|
| Legg til person i statisk utvalg | Deltakeren blir medlem av det angitte statiske utvalget. |
| Legg til person som prosjektmedlem | Deltakeren blir medlem av det angitte prosjektet. |

## Opprett oppfølging

| Innstilling | Beskrivelse |
|---|---|
| Tittel | En beskrivende etikett. Ytterligere detaljer går i agendaen. |
| Type | En forhåndsdefinert liste av aktiviteter som møte (eksternt) og telefonsamtale. Tilgjengelige felt avhenger av den valgte oppfølgingstypen. |
| Prosjekt | Et prosjekt knyttet til oppfølgingen. |
| Dato | Når oppfølgingen starter eller forfaller.<br />**Oppgavedato:** Dette betyr en oppgave i brukerens sjekkliste.<br />**Møtedato:** Dette betyr en oppfølging i dagboken. "Første tilgjengelige" eller "Første tilgjengelige etter x dager/arbeidsdager/uker". |
| Tildel til | Eieren av oppfølgingen. Deltakerens "vår kontakt" eller "vår servicekontakt", eller en spesifikk navngitt medarbeider. |
| Agenda | Ytterligere detaljer om oppfølgingen, som en agenda, en beskrivelse, filer, bilder og lenker. Alternativer for tekst-formatering er tilgjengelige. |

## Opprett sak

| Innstilling | Beskrivelse |
|---|---|
| Tittel | Et beskrivende navn for saken. |
| Sakstype | Målretter et sett med attributter som trengs for en spesifikk prosess. Påvirker tilgjengelige statuser og prioriteter. |
| Status | Indikerer fasen for sakshåndtering (åpen eller lukket). |
| Kategori | Et sett med regler som definerer hvordan saker behandles. |
| Prioritet | Reflekterer viktigheten av saken. |
| Eier | Hvem sakenen skal tilordnes. |
| Melding | Innholdet i saken. Alternativer for tekst-formatering og malvariabler for person og firma er tilgjengelige. |

## Opprett salg

| Innstilling | Beskrivelse |
|---|---|
| Tittel | Et beskrivende navn på salget. Detaljer går i beskrivelsen. |
| Salgstype | En navngitt mengde informasjon om salgsprosessen. Påvirker standard salgstrinn og estimert salgsdato. Noen salgstyper er knyttet til en [salgsguide][14]. |
| Trinn | Salgets nåværende trinn (åpent, tapt, solgt). |
| Beløp | Forventet beløp for pipelinen. |
| Beskrivelse | En mer detaljert beskrivelse av salget. |
| Prosjekt | Et prosjekt knyttet til salget. |
| Dato | Den estimerte salgsdatoen. "Estimert etter salgstype" eller "Etter x dager/arbeidsdager/uker". |
| Eier | Personen ansvarlig for salget. Deltakerens "vår kontakt" eller "vår servicekontakt", eller en spesifikk navngitt medarbeider. |

## Avslutt flyt

Flytkontrolltrinnene **Del** og **Vent på hendelse** (og også Send SMS) har et alternativ **Avslutt flyt** for å trekke deltakere som ikke oppfyller en betingelse ut av flyten. Hvis valgt, kan deltakeren flyttes til en annen flyt og/eller legges til i et utvalg.

| Innstilling | Beskrivelse |
|---|---|
| Legg til en deltaker i en annen flyt etter at du har avsluttet | Personen blir **foreslått** som deltaker for den angitte flyten. Filtre bestemmer om de starter den flyten eller ikke. |
| Legg til en deltaker i et statisk utvalg etter at du har avsluttet | Personen blir medlem av det angitte utvalget. Du kan opprette et nytt utvalg fra trinninnstillingene. |

## Avsluttet

Deltakere som når trinnet **Avsluttet** har nådd slutten av flyten. Deltakeren kan ha fullført flyten med status = fullført eller fullført med suksess. Det skjer ingen flere handlinger med en deltaker i denne flyten når de når trinnet.

| Innstilling | Beskrivelse |
|---|-|
| Legg til i en annen flyt når et suksesskriterium er oppfylt | Fullført med suksess |
| Legg til i en annen flyt når ingen suksesskriterier er oppfylt | Fullført |

## Varsling på e-post

| Innstilling | Beskrivelse |
|---|---|
| Til | Mottakeren - "vår kontakt", "vår servicekontakt" eller en spesifikk e-postadresse. |
| Overskrift | Tekst for e-postens emnefelt. ekst for e-postens emnefelt. |
| Tekst | Skriv inn meldingen. |

Du kan tilpasse emne og melding med kontaktvariabler (samme som flettefelt i e-postredigereren).

## Varsling på SMS

| Innstilling | Beskrivelse |
|---|---|
| Til | Mottakeren - "vår kontakt", "vår tjenestekontakt" eller spesifikke kontakter. |
| Fra | Standardinnstillingen er flytinnstillingen "SMS-avsender". |
| Tekst | Skriv inn SMS-teksten. Du kan tilpasse meldingen med malvariabler (flettefelt). |

## Send e-post

| Innstilling | Beskrivelse |
|---|---|
| Opprett ny e-post for dette trinnet | Åpner e-postveiviseren. |
| Velg eksisterende e-post for dette trinnet | Se [Legg til innhold][1]. |
| Emne | Tekst for e-postens emnefelt. Du kan tilpasse emnet med malvariabler (flettefelt). |
| Vedlegg | Maks 25 MB totalt. |

## Send SMS

| Innstilling | Beskrivelse |
|---|---|
| Fra | Standardinnstillingen er flytinnstillingen "SMS-avsender". |
| Tekst | Skriv inn SMS-teksten. Du kan tilpasse meldingen med malvariabler (flettefelt). |
| Avslutt flyt hvis ingen mobiltelefon er registrert | Hva skal skje hvis personen ikke kan motta SMS? Hvis valgt, kan du legge dem til en annen flyt eller til et statisk utvalg etter avslutning. |

## Del

| Innstilling | Beskrivelse |
|---|---|
| Tittel | En kort beskrivende etikett. |
| Del opp basert på | Data/atferd å differensiere på. |
| Navn på gren | Et beskrivende navn på grenen som indikerer hvilke deltakere som beveger seg ned hvilken gren. |
| Alle andre | Grenen for å håndtere deltakere som ikke oppfyller betingelsene til noen av de andre grenene. |
| Avslutt flyt | Bestemmer om deltakere som havner i alle-andre-grenen skal avslutte flyten. Hvis valgt, kan du legge dem til en annen flyt eller til et statisk utvalg etter avslutning. Hvis ikke, kan du legge til flere trinn i denne grenen. |

De gjenværende feltene for å spesifisere greninnstillinger avhenger av hva forgreningen er basert på.

## Trigger

| Innstilling | Beskrivelse |
|---|---|
| En person kan bare starte denne flyten én gang | Om en person kan gjenregistreres i denne flyten. |
| Filter | Et sett med kriterier som må oppfylles for at en foreslått person skal tillates inn i flyten. Sjekkes bare én gang. |
| Ekskluderingsliste | Et statisk utvalg av personer som ikke vil bli lagt til i flyten, eller vil forlate flyten hvis de allerede deltar. |

## Oppdater person

Dette fungerer på samme måte som [masseoppdatering][10].

## Ventetid

| Innstilling | Beskrivelse |
|---|---|
| Antall dager/timer etter forrige trinn | **Varigheten** av pausen. Vent en bestemt tidsperiode. |
| Til en bestemt dato/klokkeslett | **Slutten** av pausen. Vent til en bestemt dato. |

## Vent på hendelse

| Innstilling | Beskrivelse |
|---|---|
| Vent i maksimalt tillatt ventetid | Hvor lenge å vente på en hvilken som helst handling (en tidsavbrudd). Standard: 7 dager. |
| Avslutt flyten dersom ingen handlinger utføres innen tidsavbrudd | Deltakere som ikke svarer, vil forlate flyten med status "dropout". Hvis sant, kan du legge dem til en annen flyt eller til et statisk utvalg etter avslutning. |

## Relatert innhold

* [Lær om aktiviteter][11]

<!-- Referenced links -->
[1]: content.md
[10]: ../../../learn/basics/bulk-update.md
[11]: ../../../learn/basics/activity.md
[14]: ../../../sale/learn/sales-guides.md
