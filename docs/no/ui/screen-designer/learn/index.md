---
uid: help-no-screen-designer
title: Skjermdesigner
description: Lær hvordan du konfigurerer skjermbilder i denne veiledningen.
keywords: Skjermdesigner, brukergrensesnitt, skjerm, layout, oppsett, tilpasning
author: Bergfrid Dias
date: 10.29.2024
version: 10.3.11
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Skjermdesigner <i class="ph ph-squares-four" aria-hidden="true"></i>

**Skjermdesigneren** i SuperOffice CRM lar deg tilpasse utformingen av hovedskjermbildene i applikasjonen, slik at brukergrensesnittet oppfyller de spesifikke behovene til ulike brukergrupper i organisasjonen din. Denne funksjonen erstatter det gamle [PageBuilder][9]-verktøyet og tilbyr en mer strømlinjeformet og fleksibel måte å konfigurere skjermene på – uten behov for koding.

![Skjermdesigner, firmakort, standard feltoppsett -screenshot][img5]

> [!NOTE]
> Denne funksjonen krever lisensen Developer Tools og funksjonsrettigheten "Feltadministrator".

## Hvorfor bruke Skjermdesigneren?

SuperOffice CRM kommer med standardlayouter for Person-, Firma-, Salgs-, Prosjekt- og Saks-skjermene og Oppfølgingsdialogen. Men ulike team har ofte forskjellige informasjonsbehov. Ved å bruke Skjermdesigneren kan du:

* Opprette tilpassede layouter skreddersydd til arbeidsflytene og prioriteringene til spesifikke brukergrupper (som salg, support, ledelse).

* Forbedre effektiviteten ved å gjøre det mulig for teamene dine å raskt få tilgang til informasjonen som er viktigst for dem.

* Fjerne unødvendige felt, legge til nye og organisere informasjon i logiske grupper ved hjelp av faner, kolonner og etiketter.

For eksempel, hvis salgsteamet ditt fokuserer på kundeinteraksjoner, kan du sørge for at kontaktinformasjon vises fremtredende, mens mindre relevante felt flyttes til sekundære faner.

## Hva kan jeg tilpasse?

Med Skjermdesigneren kan du:

* Endre standardlayout for skjermer for alle brukere eller opprette tilpassede layouter for spesifikke brukergrupper.

* Designe layouter som er optimalisert for spesifikke prosjekttyper, salgstyper, sakstyper, oppfølgingstyper, eller dokumentmaler.

* Skjule felt som aldri brukes.

* Fremheve nøkkeldata ved å formatere felt (for eksempel fet eller stor skrift).

* Legge til knapper og koblinger for å utløse automatiserte prosesser (CRMScript) eller eksterne oppslag.

* Organisere tilpassede felt i **Mer**-fanen eller andre tilpassede faner.

* Legge til, omorganisere eller fjerne faner etter behov.

## Hvilke skjermer kan jeg konfigurere?

Du kan tilpasse følgende skjermer og dialoger:

* Firma
* Person
* Salg
* Prosjekt
* Sak
* Oppfølgingsdialog
* Dokumentdialog

## Hvordan fungerer layouter?

Layouter i SuperOffice CRM styrer hvordan informasjon vises for brukerne. Standardlayout brukes på alle brukere, med mindre en tilpasset layout er opprettet og tilordnet en spesifikk brukergruppe.

* **Tilpassede layouter**: Lag layouter som er spesifikke for brukergruppenes unike behov.

* **Tilordning av layouter**: Layouter for salgs-, prosjekt- og saksskjermene kan ytterligere tilpasses ved å tilordne dem til spesifikke salgstyper, prosjekttyper og sakstyper. På samme måte kan Oppfølgingsdialogen tildeles oppfølgingstyper, og Dokumentdialogen kan tildeles dokumentmaler.

* **Layoutstatus**: En layout kan være et *utkast* eller *publisert*. Publiserte layouter er merket med de tildelte brukergruppene eller type.

![Skjermdesigner, layout med status utkast -screenshot][img3]

![Skjermdesigner layout med status publisert -screenshot][img4]

Listen **Layout** viser alle eksisterende layouter, inkludert en forhåndsvisning.

## Arbeide med Skjermdesigneren

For å begynne å tilpasse skjermer:

1. Åpne Skjermdesigneren ved å klikke på ![icon][img2], velge **Innstillinger og vedlikehold**, og deretter velge **Skjermdesigner** fra navigasjonsmenyen.

2. Dra og slipp felt i redigeringsverktøyet for å legge dem til layouten din.

3. Klikk på et felt for å flytte det eller oppdatere innstillingene. Tilgjengelige innstillinger avhenger av feltet som er valgt.

### Layoutkomponenter

* **Felt:** Viser alle datafelt som er tilgjengelige for den valgte skjermlayout. Bruk filtre for å finne spesifikke felt raskt.

* **Elementer:** Inneholder ikke-databaserte elementer som etiketter, skillelinjer, koblinger og knapper.

* **Innstillinger:** Lar deg tilpasse utseendet og oppførselen til det valgte feltet.

* **Fanearrangement:** Gir alternativer for å ordne felt og elementer i kolonner.

* **Faner:** Kan legges til, omorganiseres eller slettes for å organisere informasjon logisk.

> [!NOTE]
> Etter publisering av en layout må brukere i de tildelte gruppene logge ut og logge inn igjen for å se endringene.

## Hva hvis jeg ikke bruker Skjermdesigneren?

Hvis du ikke har lisens for utviklingsverktøy, organiserer **Mer**-fanen automatisk alle tilpassede felt i to kolonner. Dette standardoppsettet gir fortsatt et funksjonelt grensesnitt, men uten de avanserte tilpasningsmulighetene som er tilgjengelige gjennom Skjermdesigneren.

## Oppsummering

Ved å tilpasse layout med Skjermdesigneren kan du eliminere unødvendig informasjon, noe som gjør grensesnittet renere og mer effektivt for teamene dine. Hvis brukerstøtteteamet ditt for eksempel sjelden bruker firmaadressen, kan du flytte den til en sekundær fane og frigjøre plass til mer relevante felt.

## Relatert innhold

* [Legg til layout][2]
* [Rediger layout - hovedkort][1]
* [Arbeide med felt][4]
* [Arbeide med arkiver (detaljkort)][3]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: add-layout.md
[3]: working-with-archives.md
[4]: working-with-fields.md
[9]: ../../../../en/ui/web-app/pagebuilder/index.md

<!-- Referenced images -->
[img2]: ../../../../media/icons/btn-menu.png
[img3]: ../../../../media/loc/en/ui/status-draft.png
[img4]: ../../../../media/loc/en/ui/status-published.png
[img5]: ../../../../media/loc/en/ui/edit-card-layout-fields.png
