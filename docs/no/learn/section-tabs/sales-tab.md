---
uid: help-no-section-tab-sales
title: Salgsfanen
description: Lær hvordan du kan administrere og se salgsinformasjon i Salg-detaljkortet i SuperOffice CRM, inkludert å legge til salg, filtrere, og følge opp salgsaktiviteter for firmaer, personer og prosjekter.
keywords: Salgsfanen, Salg-fanen, detaljkortet Salg, detaljkort, salgsarkiv
author: Bergfrid Skaara Dias
date: 01.29.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Salgsfanen

Detaljkortet **Salg** i SuperOffice CRM lar brukere se og administrere [salgsinformasjon][1] relatert til spesifikke enheter, som firmaer, personer, prosjekter og dagbøker. Det viser en liste over alle salg som er tilknyttet en enhet, og gjør det enkelt å spore aktiviteter i kontekst og få dypere innsikt i salgsprestasjoner og kommende handlinger.

![Detaljkortet Salg -screenshot][img1]

## Tilgjengelighet av Salgsfanen

Detaljkortet **Salg** er tilgjengelig for:

| Enhet | Beskrivelse av detaljkortet |
|---|---|
| [Firma][9] | Viser alle salg tilknyttet firmaet. |
| [Person][10] | Viser salg tilknyttet personen, inkludert detaljer som status, beløp og neste steg. |
| [Dagbok][11] | Gir en oversikt over salg, med fokus på planlagte aktiviteter og salgsutvikling. |
| [Prosjekt][13] | Viser salg tilknyttet prosjektet, og fremhever relaterte aktiviteter og kommende oppfølgingspunkter. |

## <a id="columns"></a>Kolonner i Salgsfanen

Detaljkortet **Salg** inneholder følgende kolonner for å vise nøkkelinformasjon om hvert salg:

| Kolonne | Beskrivelse |
|---|---|
| Utført | Avkrysningsboks som viser om salget er fullført. En hake i boksen (<i class="ph ph-check" aria-hidden="true"></i>) betyr utført, mens en tom boks betyr at det fortsatt pågår. |
| Statusymbol | Viser nåværende [status for salget][4], som solgt, tapt eller utsatt. |
| Salgsdato | Dato tilknyttet salget, som kan være estimert, solgt eller tapt dato. |
| Beløp | Den økonomiske verdien av salget. |
| Fase | Nåværende stadium i salgsprosessen. |
| Neste aktivitet | Dato for neste planlagte oppfølging eller salgsaktivitet. Datoen viser den eldste oppfølgingen som ennå ikke er fullført. For å se mer detaljer eller identifisere hva den neste oppfølgingen er, dobbeltklikk på salget for å åpne Salgsskjermen. Oppfølgingen kan ses i detaljkortet **Aktiviteter** for salget. |
| Navn | Navn på salget. |
| Person | Personen som er tilknyttet salget. |
| Firma | Firmaet som salget er tilknyttet. |
| Bruker-ID | Brukeren som registrerte salget. |
| ERP-rabatt | Viser rabattinformasjon dersom SuperOffice CRM er koblet til et ERP-system. |

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## Se salg i Salgsfanen

1. Gå til den aktuelle skjermen, for eksempel Firma, Person, Prosjekt eller Dagbok.

1. Klikk på detaljkortet **Salg** for å se alle salg knyttet til enheten.

1. Dobbeltklikk på et salg i listen for å åpne Salgsskjermen og se detaljert informasjon.

### Filtrer salg

Du kan filtrere listen over salg etter dato, bruker eller gruppe ved å klikke på **Filter**-knappen (<i class="ph ph-funnel" aria-hidden="true"></i>). Dette hjelper deg med å fokusere på spesifikke salgsaktiviteter som trenger oppmerksomhet.

### Inkluder interessenter

For å inkludere salg der det gjeldende firmaet eller personen er involvert som en [interessent][3], merk av for **Ta med interessenter** nederst på detaljkortet. Dette gir en bredere oversikt over alle salgsaktiviteter relatert til enheten.

## Salgsassistent

Detaljkortet **Salg** fungerer som en **salgsassistent** for å hjelpe deg med å holde oversikt over pågående salgsaktiviteter. Det fungerer som en salgsorientert oppgaveliste, og gir en oppsummering av:

* **Ufullførte salg:** Alle pågående salg hvor salgsdatoen faller innenfor det definerte visningsområdet.

* **Planlagte salgsaktiviteter:** Alle salg med planlagte aktiviteter for et spesifikt antall dager fremover.

    > [!NOTE]
    > Antall dager fremover er brukerdefinert. For å endre denne innstillingen, gå til **Personlige innstillinger** > **Preferanser** > **Funksjoner** > **Vis dager fremover**.

* **Forfalte aktiviteter:** Alle salg med aktiviteter som har forfalt (sluttdato tidligere enn i dag). Disse salgene er markert i rødt for enkel identifikasjon.

* **Utsatte salg:** Hvis et salg er merket som [utsatt][4] og har en gjenåpningsdato, vil denne datoen overstyre datoen i feltet **Neste aktivitet** og bli vist i kolonnen **Neste aktivitet**.

Denne visningen hjelper brukerne med å holde oversikt over pågående handlinger, slik at ingenting faller mellom stolene, noe som forbedrer salgsstyringen.

## Legg til salg

For å legge til et nytt salg direkte fra detaljkortet **Salg**:

1. Velg **Legg til** for å åpne salgsopprettelsesdialogen.

1. Fyll inn salgsdetaljene: Fullfør de nødvendige feltene og klikk **Lagre**.

## Ytterligere tips

* **Rask navigering:** Bruk [Navigatoren][7] for å raskt bytte mellom ulike enheter og deres tilsvarende **Salg**-faner.

## Relatert innhold

* [Hvordan legge til et salg][2]
* [Administrere interessenter i salg][3]
* [Filtrer aktiviteter og salg][8]
* [Grupper kolonner og oppsummer beløp][5]

<!-- Referenced links -->
[1]: ../../sale/learn/index.md
[2]: ../../sale/learn/create.md
[3]: ../../sale/learn/stakeholders/index.md
[4]: ../../sale/learn/update.md#stalled
[5]: configure-columns.md#calculate
[7]: ../getting-started/main-screen/navigator.md
[8]: filter.md
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs
[11]: ../../diary/learn/index.md#section-tabs
[13]: ../../project/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/sale-detail.png
