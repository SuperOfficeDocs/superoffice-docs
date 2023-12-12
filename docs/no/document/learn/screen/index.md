---
uid: help-no-document-dialog
title: Dialogboks for dokument
description: Dialogboks for dokument
author: SuperOffice RnD
so.date: 06.29.2022
keywords: dokument
so.topic: concept
language: no
---

# Dialogboksen Dokument

Sentralt i dokumentfunksjonen står dialogboksen **Dokument**, som du kan åpne på forskjellige måter:

* Ved å velge **Ny** > **Dokument**.
* Ved å åpne et [Eksisterende dokument][1].

Dialogboksen består av en hovedseksjon med generell informasjon om dokumentet, og følgende faner med tilleggsinformasjon:

* Detaljer
* Koblinger
* Mer

## Hovedseksjon

Hovedseksjonen inneholder følgende grunnleggende informasjon om dokumentet:

### Dokumentmal

Klikk på pilen ![icon][img1] ved siden av typefeltet øverst i dialogboksen for å vise en liste over dokumentmaler du kan velge mellom. [!include[SM](../../../learn/includes/are-defined-sm.md)] Eller, start å skrive inn navnet for å søke etter en spesifik mal.

> [!NOTE]
> Når du [oppretter et dokument][5], åpnes malen i programmet det ble opprettet i. For eksempel åpnes DOCX-filer i Word.

### Firma

Her skriver du inn navnet på firmaet du skriver et dokument til. Du kan søke direkte fra dette feltet.

### Person

Hvis du klikker på pilen ved siden av dette feltet, får du frem en liste over personer som er registrert på firmaet.

### Prosjekt

Skriv inn navnet på prosjektet som dokumentet er knyttet til. Du kan søke direkte fra dette feltet.

### Salg

Skriv inn navnet på salget (hvis aktuelt) som dokumentet er knyttet til. Du kan søke direkte fra dette feltet.

### Skriv emne her

Skriv inn teksten som skal brukes som overskrift for dokumentet (teksten som vises i detaljkort og rapporter der dokumentet er oppført).

### Språk

Velg et språk for malen. Dette alternativet er bare tilgjengelig hvis den valgte malen omfatter oversatte versjoner.

### Dato

I dette feltet vises automatisk dagens dato. Hvis du klikker på pilen ved siden av **Dato**-feltet, får du opp en månedskalender der du kan velge ønsket dato.

> [!NOTE]
> Du kan bare endre datoen når du oppretter dokumentet. I redigeringsmodus får du ikke tilgang til dette feltet.

### Vår ref

Her kan du skrive inn din egen referanse. Standardoppføringen for hver mal er definert i Innstillinger og vedlikehold, men du kan også redigere innholdet i dette feltet.

### Din ref

Skriv inn adressatens referanse fra kommunikasjonen.

### Synlig for

Klikk på **Synlig for**-feltet for å vise en liste der du kan velge om dokumentet skal være synlig for alle brukere, privat (bare synlig for brukeren som er definert som eier), eller synlig for alle brukere i en av brukergruppene som eieren tilhører.

> [!NOTE]
> Hvis du angir synlighet til bare eier, vises dokumentet i kursiv på detaljkortet **Aktiviteter**.

### Sjekket ut for redigering

Hvis dokumentet er sjekket ut for redigering, vises ett av følgende ikoner:

![icon][img2] Dokumentet er for øyeblikket sjekket ut for redigering av deg.

![icon][img3] Dokumentet er for øyeblikket sjekket ut for redigering av en annen bruker.

> [!TIP]
> Hold musepekeren over et ikon for å vise informasjon om brukeren som sjekket ut dokumentet.

### Fullført

Som standard er dokumentet merket som fullført (![icon][img4]), men du kan fjerne denne avmerkingen hvis du ønsker det (![icon][img5]). Dokumentet vil da vises på detaljkortet **Aktiviteter** på dagbokskjermbildet til det er merket som fullført.

> [!NOTE]
> Du kan ikke redigere fullførte dokumenter før du har deaktivert **Utført**-statusen. [Slik endrer du Fullført-statusen for en aktivitet][7].

### Brukerdefinerte felt

[!include[3 udef](../../../learn/includes/more-udef.md)]

> [!NOTE]
> Brukergruppemedlemskap er definert i skjermbildet Brukere i Innstillinger og vedlikehold.

### Oppgave

Når du klikker på denne knappen, vises følgende alternativer:

* **Slett**: Sletter den gjeldende oppføringen.
* **Hjelp**: Åpner hjelpen for den aktive dialogboksen.
* **Kopier snarvei**: Kopierer en [snarvei til den aktive oppføringen][9].
* **Hent lagret versjon**: Velg dette alternativet for å [avbryte en utsjekking][4]. Hvis du for eksempel har sjekket ut dokumentet ved en feiltakelse og ikke kan sjekke det inn på nytt.

Under disse alternativene er det snarveier til andre relevante oppgaver som kan utføres på den aktive oppføringen. I Innstillinger og vedlikehold kan du også definere dine egne oppgaver og legge dem til under **Oppgave**-knappen.

## Fanen Detaljer

Fanen **Detaljer** inneholder detaljert informasjon om dokumentet.

* **Beskrivelse:** Her kan du legge inn en beskrivelse av dokumentet. Dette kan være nyttig i forbindelse med fritekstsøk.

* **Dokument:** Klikk på koblingen for å laste opp dokumentet, eller dra og slipp dokumentet fra Windows Utforsker til dialogboksen **Dokument**.

    Hvis du vil vite mer om dette, se [Opprett nye dokumenter][5] og [Rediger dokumenter][1].

**Publiser:** Merk av her hvis du vil at dokumentet skal være synlig for eksterne brukere i Audience (krever en egen lisens).

## Koblinger-fanen

Denne fanen inneholder informasjon om aktiviteter (dokumenter og oppfølginger) og salg som er tilknyttet det aktuelle dokumentet. Hvis det er registrert noe i denne fanen, vises det en prikk ved siden av **Koblinger**.

[Les mer om hvordan du legger til koblinger][2].

## Fanen Mer

Denne fanen viser alle [brukerdefinerte felt][3] som er konfigurert i Innstillinger og vedlikehold.

## Fanen www

[!include[About the www tab](../../../learn/includes/www-tab.md)]

<!-- Referenced links -->
[1]: ../edit.md
[4]: ../lock.md
[5]: ../create.md
[7]: ../../../diary/learn/change-completed-status.md
[9]: ../../../onsite/win-client/learn/creating-shortcuts-to-entries-in-crm.md
[2]: ../../../diary/learn/linking-documents-to-follow-ups.md
[3]: ../../../custom-objects/learn/udef/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/dropdown-icon.png
[img2]: ../../../../media/icons/document-lock-editing.png
[img3]: ../../../../media/icons/document-lock-locked.png
[img4]: ../../../../media/icons/followup-completed-small.png
[img5]: ../../../../media/icons/followup-not-completed-small.png
