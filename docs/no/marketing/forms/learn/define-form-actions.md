---
uid: help-no-form-actions
title: Definer skjemahandlinger
description: Definer skjemahandlinger
keywords: skjema, automatisering, skjemahandlinger, skjemainnsending
author: SuperOffice RnD
date: 05.24.2024
version: 10.3.5
topic: howto
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Definer skjemahandlinger

Å behandle 200 påmeldinger til arrangementet manuelt er tidkrevende og unødvendig. Automatiserte skjemahandlinger kan effektivisere denne prosessen.

Automatisering sparer tid som ellers ville blitt brukt på å håndtere svar. Når en person sender inn skjemaet, utfører systemet handlingene for deg!

![Definer skjemahandlinger -screenshot][img17]

## Tilgjengelige handlinger

### Varsle om innsendinger ved å opprette saker

Velg dette alternativet for å [opprette en sak][8] for hvert skjema som mottas. Skriv en tittel, og velg kategori og prioritet for saken.

Innsendte skjemaer vil være tilgjengelige i skjermbildet **Saker** og i detaljkortet **Saker** i skjermbildene Firma og Person i SuperOffice CRM.

### Hvordan skal en skjemainnsending behandles?

Her kan du definere om de innsendte skjemaene skal behandles automatisk.

* **Behandle alle innsendinger automatisk. Opprett ny kontakt dersom ingen treff ble funnet**: Alle skjemainnsendinger behandles automatisk. Det vil ikke bli varslet om innsendte skjemaer.

* **Manuelt hvis innsender er ukjent. Automatisk – hvis innsender er kjent**: Hvis e-postadressen som er oppgitt i skjemaet, samsvarer med en e-postadresse i SuperOffice, behandles skjemainnsendingen automatisk. Hvis ikke, behandles den manuelt. Du vil motta et varsel.

* **Manuelt for alle innsendinger**: Du vil motta et varsel for hvert innsendte skjema.

![icon][img11] [Hvordan behandle skjemainnsendinger][6].

### Hva skal skje når skjemaet behandles?

Her kan du velge handlinger som skal utføres når et skjema behandles (automatisk eller manuelt):

* **Legg til person i utvalg**: Hvis du valgte automatisk behandling ovenfor, bør du legge til et utvalg her for å holde oversikt over personer som er lagt til via dette skjemaet. Dette gjør det også enklere å fjerne irrelevante personer (og firmaer).

* **Legg til person på prosjekt**: Velg et prosjekt. Personer som sender inn dette skjemaet, blir lagt til i dette prosjektet.

* **Legg til interesse for person**: Velg en interesse. Denne interessen blir lagt til personer som sender dette skjemaet.

* **E-postsvar**: Velg et skjemasvar som du vil sende til personer når skjemaet deres behandles. [Slik oppretter du et skjemasvar][7].

* **Opprette sak**: Hvis du har lagt til et saksfelt i kategorien **Felt** må du også velge en standardkategori og prioritet for sakene som opprettes fra dette skjemaet. Innsendte skjemaer vil være tilgjengelige under **Saker** i SuperOffice Service og i detaljkortet **Saker** i skjermbildene firma og person i SuperOffice CRM.

* **Kjør CRMScript**: Velg et [CRMScript][9] eller en makro som skal kjøres når en skjemainnsending behandles.

* **Standard kategori** / **Standard bransje**: Velg en standard kategori og bransje for alle personer eller firmaer som legges til SuperOffice basert på innsendte skjemaer. Med dette alternativet kan du gruppere skjemainnleveringer og nye personer/firma til en bestemt kategori og/eller bransje.

    Hvis du for eksempel har et skjema for potensielle kunder, velger du potensielle kunder som kategori. Deretter kan du enkelt opprette utvalg basert på denne kategorien og/eller bransje.

> [!NOTE]
> Når du oppdaterer et skjema, må du huske at det kan brukes i flere utsendelser og/eller automatiserte flyter. Du bør forsikre deg om at det ikke er noen dupliserte eller motstridende handlinger.

## Hva vil du gjøre nå?

* [Publisere skjemaer][2]

<!-- Referenced links -->
[2]: publish.md
[6]: process-submissions.md
[7]: ../../mailing/learn/create/tutorial-form-mailing.yml
[8]: ../../../request/learn/create.md
[9]: ../../../../en/automation/crmscript/howto/marketing/forms.md

<!-- Referenced images -->
[img11]: ../../../../media/loc/en/marketing/form-notification.png
[img17]: ../../../../media/loc/en/marketing/contact-me-form-actions.png
