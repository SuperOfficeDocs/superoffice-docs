---
uid: help-no-flow-actions
title: Definer flythandlinger
description: Definer flythandlinger
keywords: flyt, markedsføring, flythandling, kjør skript
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: no
---

# Definer flythandlinger

## Tilgjengelige handlinger

* [Send melding](#send)
* [Oppdater deltaker](#update)
* [Opprett aktivitet](#create)
* [Interne handlinger](#internal)

> [!NOTE]
> Når du legger til eller oppdaterer flythandlinger, husk at skjemaer og sporingslenker også har handlinger. Du bør sørge for at det ikke finnes dupliserte eller motstridende handlinger. Vi anbefaler at du inkluderer alle handlinger på ett sted, enten i skjemaet eller i flyten.

## <a id="send"></a>Send melding

Ting å vurdere:

* Hvor ofte skal vi sende ny informasjon?
* Skal neste e-post baseres på engasjement, når en person fyller ut et skjema eller klikker en sporet lenke?
* Skal alle personer få det samme innholdet?

### Send e-post (utsendelse)

Et e-posttrinn brukes til å sende en e-post til en aktiv flytdeltaker. Du kan velge en allerede forberedt e-post eller legge til en ny.

1. Dra **Send e-post**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.

    > [!NOTE]
    > Når du legger til et e-posttrinn, må du angi e-postinnstillinger før du starter flyten. Du vil se et advarselsikon (som på skjermbildet nedenfor) hvis disse innstillingene mangler. Du kan fortsatt lagre flyten! Fortsett med å designe flyten og gå tilbake til e-postinnstillingene senere.

1. Velg ett av alternativene:

    * Opprett ny e-post for dette trinnet. Skriv inn et navn og klikk **Opprett**. Dette åpner veiviseren på **Mal**-trinnet.
    * Velg eksisterende e-post for dette trinnet. Klikk for å velge flytinnhold.

1. Angi **emnet** til e-posten. Malvariabler for person er tilgjengelige.

1. Eventuelt, legg til ett eller flere vedlegg (maks 25MB totalt).

![Legg til e-posttrinn i flyt -screenshot][img1]

> [!NOTE]
> Oppretting av ny e-post som flytinnhold er kun mulig fra flytgrensesnittet.

### Send SMS

Et SMS-trinn brukes til å sende en SMS til en aktiv flytdeltaker.

Flytdeltakere uten registrert telefonnummer kan enten hoppe over trinnet (fortsette til neste trinn), eller forlate flyten, avhengig av trinninnstillingene.

1. Dra **Send SMS**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.

1. Skriv inn avsender og SMS-teksten. Malvariabler for person er tilgjengelige.

1. Eventuelt, velg **Avslutt flyt hvis ingen mobiltelefon er registrert** og velg hvordan du vil håndtere personer som ikke kan motta SMS.

> [!TIP]
> Hvis du ønsker å sende kun én SMS, hold øye med telleren i nederste høyre hjørne. Hvis antall tegn overstiger 160, sendes meldingen som flere SMS-segmenter og ekstra kostnader kan påløpe. Vi anbefaler å holde meldingen kort og informativ.

## <a id="update"></a>Oppdater deltaker

* Oppdater person
* Legg til i utvalg/prosjekt
* Fjern fra utvalg/prosjekt

### Oppdater person

Bruk dette trinnet til å oppdatere relevante data på en person eller deres firma, før deltakeren flyttes til neste trinn i flyten.

1. Dra **Oppdater person**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.
1. Velg et felt å oppdatere i **Felt**-kolonnen. Du kan også skrive inn navnet i feltet. Etter hvert som du skriver inn hver bokstav, viser listen nedenfor relevante treff.
1. Velg en handling i **Handling**-kolonnen. De [tilgjengelige handlingene][11] avhenger av typen felt du valgte i forrige trinn.
1. Spesifiser nye verdier hvis aktuelt.
1. For å oppdatere flere felt, klikk **Legg til** og gjenta trinn 2-4.
1. Sørg for at alle feltene du ønsker å oppdatere - og kun de - har et avkrysningsmerke. Du kan klikke den røde X for å fjerne overflødige linjer.

![Oppdater persondata i flyt -screenshot][img2]

Dette fungerer på samme måte som [masseoppdatering][11].

### Legg til i utvalg/prosjekt

Hold oversikt over de som meldte seg på, var engasjert, eller for å følge opp senere. Personen legges til som medlem i det angitte utvalget og/eller prosjektet.

1. Dra **Legg til i utvalg/prosjekt**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.
1. Legg til person i statisk utvalg: velg et statisk personutvalg fra listen, eller klikk på **Ny** for å opprette et nytt.
1. Legg til person som prosjektmedlem: velg et prosjekt fra listen.

> [!TIP]
> Begynn å skrive for å søke i en liste.

### Fjern fra utvalg/prosjekt

Personen fjernes som medlem fra det angitte utvalget og/eller prosjektet.

Dette trinnet er likt **Legg til i utvalg/prosjekt**.

## <a id="create"></a>Opprett aktivitet

Flyten kan automatisk opprette en oppfølging, sak og/eller salg på personen i henhold til innstillingene. Ved å koble CRM-aktiviteter og varsler, kan organisasjonen bygge bro mellom markedsføring og salg. Oppretting av aktiviteter lar deg også fokusere på personer som er engasjerte.

### Opprett oppfølging

Eksempel: Sett opp en gratis konsultasjon på første tilgjengelige tid i vår kontakts kalender. De vil bli varslet i **Varsler**-panelet.

1. Dra **Opprett oppfølging**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.
1. Angi en tittel.
1. Velg en oppfølgingstype.
1. Angi en forfallsdato for en oppgave eller reserver første tilgjengelige tid for et møte.
1. Overfør til: velg hvem som skal følge opp deltakeren: "vår kontakt" eller "vår servicekontakt", eller en spesifikk navngitt medarbeider.
1. Eventuelt, angi annen informasjon. For detaljer, se [listen over trinninstillinger][1] og [hvordan opprette en oppfølging][12].

### Opprett sak

1. Dra **Opprett sak**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.
1. Angi en beskrivende **tittel**.
1. Velg en [sakstype][14], som vil påvirke standardverdier og tilgjengelige statuser og prioriteringer.
1. Velg [status][15], [kategori][16], og [prioritet][17].
1. **Eier:**
    * For å tildele saken til en spesifikk person, velg navnet du trenger.
    * **Automatisk tildelt:** Hvis du velger dette alternativet, tildeler systemet saken i samsvar med de gjeldende tildelingsreglene.
    * **Ikke tildelt:** Du kan også velge å ikke tildele saken. Medlemmene av den relevante kategorien blir da ansvarlige for å håndtere saken.
1. Skriv inn den faktiske meldingen du ønsker å legge til saken.

For detaljer, se [listen over trinninstillinger][1] og [hvordan opprette en sak][13].

### Opprett salg

Når deltakeren når dette trinnet, er personen moden og har vist tegn på å være en salgsmulighet.

1. Dra **Opprett salg**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.
1. Angi en beskrivende **tittel**.
1. Velg en salgstype, som vil påvirke standardverdier og tilgjengelige stadier.
1. Skriv inn nødvendig informasjon i de andre feltene.
1. Eier: Velg hvem som skal følge opp denne ledelsen: "vår kontakt" eller "vår servicekontakt", eller en spesifikk navngitt medarbeider.

    > [!NOTE]
    > Legg til en oppfølging også, for å varsle salgseieren om denne nye muligheten​.

For detaljer, se [listen over trinninnstillinger][1] og [hvordan du oppretter et salg][18].

## <a id="internal"></a>Interne handlinger

### Kjør skript

Kjør egendefinert forretningslogikk ved å utløse et CRMScript som en del av flyten.

1. Dra **Kjør skript**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.
1. Velg et [CRMScript][20] fra listen.

> [!NOTE]
> Deltakeren vil fortsette til neste trinn umiddelbart etter at skriptet er utløst, uten å vente på resultatet.

### Varsling på e-post

Send en varslingse-post til en spesifikk person som en del av flyten.

1. Dra **Varsling på e-post**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.
1. Angi mottakeren (**Til:**).
1. Skriv inn **emnet** for e-posten.
1. Skriv inn meldingen du ønsker å sende.

Malvariabler for person er tilgjengelige.

### Varsling på SMS

Send en varslingsSMS til en bestemt person som en del av flyten.

1. Dra **Varsling på SMS**-boksen fra trinnmenyen og slipp den i en tilgjengelig plass i flytskjemaet.
2. Angi mottakeren (**Til:**).
3. Skriv inn meldingen du ønsker å sende. Malvariabler for person er tilgjengelige.

Hvis det ikke er oppgitt et mobiltelefonnummer for de valgte kontaktene, vil ingen SMS bli mottatt i andre enden.

## Flythandling vs. skjemahandling

Flere handlingstyper er mulige både som skjemahandling og som flytrinn​.

En [skjemahandling][6] kan inkludere:

* Legge til en person i en utvalg og/eller et prosjekt
* Legge til interesse for en person
* Sette standardkategori og forretningsområde for nye personer og firma
* Opprette en sak
* Sende en skjemaresponsutsendelse til en person

## Flythandling vs. koblingshandling

En [koblingshandling][7] kan inkludere:

* Legge til en person i en utvalg og/eller et prosjekt
* Oppdatere interesser
* Legge til en verdi i et [ekstrafelt][19] på en person
* Opprette en sak
* Opprette en oppfølging

<!-- Referenced links -->
[1]: step-settings.md
[6]: ../../forms/learn/define-form-actions.md
[7]: ../../tracked-links/learn/define-link-actions.md
[11]: ../../../learn/basics/bulk-update.md
[12]: ../../../diary/learn/create-follow-up.md
[13]: ../../../request/learn/create.md
[14]: ../../../request/admin/type/index.md
[15]: ../../../request/admin/status/index.md
[16]: ../../../request/admin/category/index.md
[17]: ../../../request/admin/priority/index.md
[18]: ../../../sale/learn/create.md
[19]: ../../../custom-objects/learn/extra-field.md
[20]: ../../../automation/crmscript/learn/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-send-email-new.png
[img2]: ../../../../media/loc/en/marketing/flow-update-contact.png
