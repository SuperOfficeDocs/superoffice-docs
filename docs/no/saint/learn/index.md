---
uid: help-no-saint
title: Sales Intelligence (SAINT)
description: I denne veiledningen lærer du hvordan SAINT kan utvikle salgs- og kundeprosessene dine, samt forbedre arbeidsflyten.
keywords: SAINT, statusovervåking
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from:
  - /no/sale/saint/learn/index
  - /no/sale/saint/learn/status-dialog
  - /no/saint/learn/status-dialog
---

# Sales Intelligence (SAINT)

Å være proaktiv betyr å kontrollere en forventet situasjon før den oppstår. Med SuperOffice Sales Intelligence (SAINT) får du muligheten til å følge opp kundene dine til rett tid og ha kontroll over alle typer scenarier. SAINT er utviklet for å overvåke databasen din og hjelpe deg med å være proaktiv og forutse hendelser som kan påvirke virksomheten din.

[!include[Requirement](../includes/note-saint-req.md)]

## Hva er SAINT og hva kan det gjøre

Overvåking og analyse av informasjonen i CRM-systemet gir innsikt i hva du kan gjøre for å forbedre virksomheten din. Med SuperOffice SAINT kan du få innsikt ved å søke etter informasjon som finnes og ikke finnes i SuperOffice CRM. For eksempel:

* Hvilke kunder har vi ikke fulgt opp de siste 6 månedene?
* Hvilke kunder har ikke kjøpt fra oss de siste 3 månedene?
* Finnes det kunder med for mange forespørsler de siste 6 ukene?
* Har dere fremtidige aktiviteter registrert på alle pågående prosjekter?

Disse spørsmålene er utgangspunktet for beslutningen om å handle. Ved å handle kan du forbedre eller rette opp den eksisterende situasjonen.

## Statuser

Hvis du har kjøpt en lisens for SAINT ("SAles INTelligence"), kan du spesifisere kriterier for statusovervåking av firmaer, personer og prosjekter i Innstillinger og vedlikehold. Statuser som genereres fra disse kriteriene kan visualiseres som et bilde som vises på firmakort, personkort eller prosjektkort. Du kan for eksempel vise et bilde av en varseltrekant på en kunde som har krevd mange salgsmøter, men som ikke har generert noen salg, eller et spindelvev på en kunde som ikke har vært kontaktet på over tre måneder. Dette gir en tydelig og umiddelbar indikasjon på bestemte statuser, det kan for eksempel være nyttig for en salgsmedarbeider.

## Et enkelt eksempel

Vårt imaginære firma Bridgecom selger datamaskiner, bærbare datamaskiner og kontorprogramvare. Som du vet, må alle datamaskiner oppdateres med ny programvare eller noen ganger byttes helt ut. Men teamet på Bridgecom sliter med å få oversikt over firmaer som trenger nye datamaskiner og programvareoppdatering. De skulle gjerne hatt en liste over firmaer som ikke har oppdatert datamaskinene sine de siste 2 årene. På denne måten vet de nøyaktig hvilke kunder de skal følge opp i begynnelsen av hver måned. Men hvordan finner du denne informasjonen?

Ved å bruke SAINT kan Bridgecom proaktivt søke etter alle kunder uten åpne eller fullførte salg som er registrert de siste 2 årene på kundekortet. SAINT-utvalget genererer en liste over disse kundene. Basert på den informasjonen som ikke finnes i kundedatabasen – nemlig at det ikke er registrert noe salg de siste 2 år.

Med denne oversikten kan Bridgecom bestemme hvordan de ønsker å følge opp kundene sine for å forbedre relasjonene og øke salget.

Med SuperOffice SAINT kan du analysere databasen for å få oversikt over kunder, salg, forespørsler og dokumenter. Dette kan gjøres i form av diagrammer og rapporter. Deretter kan personene som er ansvarlige for situasjonen du analyserte med SAINT, handle for å forbedre den eksisterende situasjonen.

### Firmaer/personer

| Navn på status | Kriterier | Forklaring | Oppgave |
|---|---|---|---|
| Dyr kunde | **Antall aktiviteter** av typen **Marketing** i perioden er høyt. **Antall salg** med status **Solgt** i perioden er lavt. | Du har hatt mye markedføringskommunikasjon med kunden, men det har ført til få eller ingen salg. | Planlegg et internmøte for å finne ut av hva som kan gjøres for å gjøre kunden lønnsom. |
| Forsømt kunde | **Antall aktiviteter** med retning **Utgående** i perioden er lavt. | Du har hatt svært lite kontakt med kunden. | Planlegg en samtale med kunden for å holde kundeforholdet ved like. |
| Sovende kunde | **Antall aktiviteter** med retning **Innkommende** i perioden er lavt eller null. **Antall aktiviteter** med retning **Utgående** i perioden er høyt. | Du prøver å komme i kontakt med kunden, men får lite eller ingen respons. | Avtal et møte med kunden for å finne ut hvorfor kunden ikke vil kommunisere. |

### Prosjekter

| Navn på status | Kriterier | Forklaring | Oppgave |
|---|---|---|---|
| Forsømt prosjekt | **Prosjektstatus** er satt til pågående. **Dato for siste aktivitet** (oppfølging) er eldre enn 14 dager. | Prosjektet er aktivt, men det har ikke vært noen aktiviteter de siste 2 ukene. | Planlegg et prosjektmøte for å få hjulene i gang. |
| Ulønnsomt prosjekt | **Antall salg** (fullførte) er lik null. **Prosjektstatus** er fullført eller stoppet. | Prosjektet er fullført, men ingenting ble solgt. | Planlegg et internmøte for å finne ut hvorfor ingen salg ble oppnådd. |

## Analyse

SAINT tilbyr både sanntids- og ad-hoc-analyse av kontinuerlig oppdaterte CRM-data. Begge metodene brukes for å sikre relevant og korrekt tilbakemelding. Alt starter med analysen.

Med SuperOffice SAINT kan du både søke etter elementer som finnes i databasen og søke etter elementer som mangler.

### Eksempel: søk etter manglende elementer

Du kan søke etter personer som ikke har hatt noen aktiviteter av en bestemt type (eller som ikke har uttrykt noen salgsrelaterte intensjoner) innenfor en bestemt periode. SAINT gir deg alle kunder uten en oppfølgingsaktivitet (åpen eller fullført) de siste 6 månedene.

![Skjermbilde for Saint-kriterier for å finne kunder uten oppfølging -screenshot][img2]

Å finne ut hva som ikke har skjedd, men som burde ha skjedd, er et eksempel på hvordan SuperOffice SAINT kan hjelpe deg å prestere i henhold til dine definerte regler eller intensjoner.

Hvis for eksempel den interne kvalitetsrutinen spesifiserer at en bestemt handling skal utføres på et bestemt stadium i et prosjekt, kan du bruke SAINT til å finne ut om denne regelen ble fulgt eller ikke. Eller hvis kundeprogrammet ditt sier at kunder i en bestemt kategori skal kontaktes ofte, kan SAINT hjelpe deg med å identifisere og liste opp kundene som ikke er fulgt opp som planlagt.

Dette er eksempler på den typen innsikt dine CRM-data og SAINT kan gi deg.

## Bevissthet

Når analysen er ferdig, må du trigge kollegene dine til å handle på resultatene.

SuperOffice SAINT bruker visuelle statusindikatorer på en kunde, potensiell kunde, et salg eller et prosjekt som vises som bakgrunnsbilde på kortet. Det er umulig for en ansatt å overse denne indikatoren. Brukeren ser umiddelbart at det er en mulighet, et problem eller noe som krever handling.

SAINT kan være gøy! Du kan bruke hvilket som helst bakgrunnsbilde, for eksempel:

* Et spindelvev for å symbolisere kundene som ikke er blitt fulgt opp,
* Et dollartegn for kunder med forfalte salg,
* En livbøye for kunder med for mange serviceforespørsler.

Fra et praktisk synspunkt kan SAINT gi en ansatt forslag til handlinger for en bestemt situasjon. De kan opprette en oppfølgingsaktivitet eller legge til kunden i et utvalg.

![Bruk en visuell indikator som et spindelvev for å varsle om at en kunde må følges opp -screenshot][img3]

SAINT-kriteriene som genererer analysene du bruker, blir automatisk søkbare "felt". Alle brukere kan bruke disse feltene til å lage en tilpasset liste med handlinger eller søk i SuperOffice Utvalg.

## Handling

Når bakgrunnsbildet (visuell statusindikator) på et person-/firmakort eller utvalg har gjort brukeren oppmerksom på at handling er nødvendig, kan de få tilgang til SAINT-valget. Dette utvalget inneholder alle kundene som må følges opp.

Ved hjelp av SAINT-utvalget ditt kan du iverksette tiltak i form av proaktive, personlige oppfølginger, personlige e-postkampanjer eller planlagte samtaler i dagbøkene til kundeansvarlige.

Når oppfølgingshandlingen er lagret i SuperOffice CRM, kan utvalget oppdateres for å gi en nøyaktig oversikt over den aktuelle situasjonen. Kundene du følger opp fjernes automatisk fra utvalget ditt.

## Jobbe med SAINT i brukergrensesnittet

Når du ser et statusbilde for et firma, en person eller et prosjekt, har du to alternativer:

* Hvis du holder musepekeren over bildet, vises det en infoboks der du kan se navnet på statusen samt en beskrivelse av den. Du får også informasjon om eventuelle andre statuser som gjelder for firmaet, personen eller prosjektet.

* Hvis du klikker på bildet, vises dialogboksen **Vis statuser**, der du kan se navnet på og beskrivelsen av statusen og utføre relevante oppgaver for firmaet, personen eller prosjektet.

> [!TIP]
> Du kan kombinere én eller flere av disse statusene som kriterier når du oppretter et dynamisk utvalg, og på denne måten få enkel oversikt over firmaer, personer eller prosjekter med statuser som oppfyller disse kriteriene.
>
> Hvis du trenger hjelp til å konfigurere SAINT for å komme videre i salgs- og kundeprosessene, anbefaler vi alltid å bruke en av våre dyktige konsulenter.

### <a id="dialog"></a>Dialogboksen Vis statuser

Dialogboksen **Vis statuser** vises når du klikker på et statusbilde på et firma-, person- eller prosjektkort. Dialogboksen inneholder følgende informasjon:

| Element | Beskrivelse |
|---|---|
| Navn | Navnet på statusen, definert i Innstillinger og vedlikehold. |
| Beskrivelse | En beskrivelse av statusen, definert i Innstillinger og vedlikehold. |
| Andre statuser | Her finner du en kobling til eventuelle andre statuser som gjelder for gjeldende firma, person eller prosjekt. Dette feltet vises bare hvis det finnes flere statuser for den aktuelle posten. |
| Opprett oppfølging | Brukes til å [opprette en ny oppfølging][1] for firmaet, personen eller prosjektet. Typen oppfølging som opprettes som standard, er definert i Innstillinger og vedlikehold. |
| Legg til i utvalg | Når du klikker på den, åpnes dialogboksen **Legg til i utvalg**, og du kan legge til gjeldende firma eller person i ønsket statisk utvalg. Dette alternativet kan bare brukes for statiske utvalg. [Slik bruker du statuser i dynamiske utvalg][2].|

## Aktuelt innhold

* [Konfigurer SAINT][5]
* [Hvordan SAINT lagrer tellere og statuser][4]
* [Bruk statusovervåking i dynamiske utvalg][2]

<!-- Referenced links -->
[1]: ../../diary/learn/create-follow-up.md
[2]: ../../search-options/selection/learn/create.md
[5]: ../admin/index.md
[4]: ../admin/index.md#database

<!-- Referenced images -->
[img2]: ../../../media/loc/en/saint/find-company-saint-criteria.png
[img3]: ../../../media/loc/en/saint/visualize-neglected-company.png
