---
uid: help-no-define-link-actions
title: Definere automatiske koblingshandlinger
description: I denne veiledningen lærer du hvordan du bruker koblinger i utsendelser til å automatisere handlinger.
keywords: Markedsføring
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: no
---

# Definer automatiske koblinghandlinger

Å oppdatere 500 kontaktkort manuelt er tidkrevende og unødvendig. Automatiserte koblinghandlinger kan effektivisere denne prosessen.

Her er hvordan automatiserte koblinghandlinger fungerer:

* En mottakers klikk på en handlingskobling kan automatisk legge dem til i et utvalg eller et prosjekt i SuperOffice CRM.
* SuperOffice CRM kan automatisk oppdatere relevant informasjon, som interesser, på personkortet.

Automatisering sparer tid som ellers ville blitt brukt på å håndtere svar. Når en leser klikker på en kobling i e-posten din, utfører systemet koblinghandlingene for deg!

Du kan utnytte den innsamlede informasjonen på flere måter:

* Generer et utvalg basert på hvem som klikket på en bestemt kobling, og send et målrettet svar til denne gruppen med en tilpasset melding.
* Planlegg oppfølgingsaktiviteter for teammedlemmene dine slik at de kan engasjere seg personlig med respondentene.
* Opprett service-saker slik at kundeserviceteamet ditt kan fange dem opp og undersøke saken.

![Definere koblingshandlingene -screenshot][img3]

## Tilgjengelige handlinger

Basert på målet og oppfordringen til handling i e-posten din, kan du oppdatere databasen din. Denne informasjonen kan forbedre segmenteringen eller hjelpe til med oppfølging av interesserte individer. Du kan velge mer enn en handling for en sporet kobling.

| Fane | Handling |
|---|---|
| [Respons](#response) | Legg til landingsside eller tilpasset tekst, eller åpne et skjema. |
| [Angi felt](#set-field) | Legg til en verdi i et [ekstrafelt][5] for kundekontakter |
| [Interesser](#interests) | Oppdater interesser. |
| [Utvalg/prosjekt](#selection) | Legg til/fjern kundekontakt fra et utvalg eller prosjekt. |
| [Oppfølging](#follow-up) | Opprett en oppfølging (oppgave eller møte) i SuperOffice CRM. |
| [Sak](#request) | Opprett ny sak. |
| [Skript](#script) | Kjør et skript. |

> [!NOTE]
> Når du oppdaterer en sporingslenke, må du huske at den kan brukes av flere utsendelser og/eller automatiserte flyter. Du bør forsikre deg om at det ikke er noen dupliserte eller motstridende handlinger.

## <a id="response"></a>Respons

Velg hva som skal skje når mottakeren klikker på koblingen.

* **Omdirigere til ny webside**: Skriv inn URL-en i det angitte feltet.
* Eller, **Vis tilpasset tekst**: Skriv inn teksten som skal vises. Klikk på ![ikon][img4] redigeringsknappen for å vise verktøylinjen for rik tekst.
* Eller, **Åpne skjema**: Velg navnet på skjemaet. Eventuelt, velg hvilke felter som skal forhåndsutfylles med kjente kontaktopplysninger.

## <a id="set-field"></a>Angi felt

I fanen **Angi felt** kan du sette en verdi som skal legges til i et ekstrafelt når mottakeren klikker på koblingen. Dette registrerer ytterligere kundeinformasjon.

Velg et felt og skriv inn en verdi.

## <a id="interests"></a>Interesser

Angi at et koblingklikk skal endre personens interesser. For eksempel, legg til interessen "Produktnyheter" hvis koblingen "Ja, hold meg informert om nye produkter" blir klikket på, eller fjern den hvis koblingen "Stopp abonnement" blir klikket på.

* **Angi interesse**: velg en interesse som skal legges til for personene når de klikker på koblingen.
* **Fjern interesse** velg en interesse som skal fjernes for personene når de klikker på koblingen.

[Hvordan lage et påmeldingsskjema for nyhetsbrev][1]

## <a id="selection"></a>Utvalg/Prosjekt

Spesifiser at mottakere som klikker på koblingen, vil bli lagt til eller fjernet fra utvalg eller prosjekter. Begynn å skrive et navn for å starte hurtigsøket.

## <a id="follow-up"></a>Oppfølging (møte/oppgave)

På fanen **Oppfølging** kan du sette et koblingklikk for å generere møter eller oppgaver i SuperOffice CRM. Velg oppfølgingstypen, gi en beskrivelse, knytt den til et prosjekt, velg oppgavetypen, tildel ansvar, og sett varigheten.
Aktiver denne funksjonen ved å velge **Oppfølging**.

[Hvordan opprette oppfølging][4]

> [!TIP]
> Som beskrivelse, skriv hvilken utsendelse det gjelder, hvilken kobling mottakeren klikket på, og eventuelt hvordan oppgaven eller møtet skal følges opp.
>
> Når du setter **Opprettet av** eller **Standardmottaker**, kan du klikke på **Velg aktiv bruker**-knappen (<i class="ph ph-user-circle" aria-hidden="true"></i>) for å velge deg selv.

## <a id="request"></a>Sak

På fanen **Sak** kan du sette et koblingklikk for å opprette en Service-sak. Merk av for å registrere en ny sak, gi en tittel, velg prioritet og kategori, og velg eieren. Du kan også velge **Automatisk tildelt** eller **Ufordelt**.

[Hvordan opprette en sak][3]

## <a id="script"></a>Skript

På fanen **Skript** kan du velge et CRMskript eller makro som skal kjøres når koblingen klikkes. Aktiver denne funksjonen ved å velge **Kjør skript**, og velg deretter det ønskede skriptet fra listen.

Variabler tilgjengelige i skriptet inkluderer custId, linkId, shipmentId, linkUrl, linkHits, og returnUrl.

[Hvordan opprette eller redigere et CRMScript][6]

<!-- Referenced links -->
[1]: ../../forms/learn/tutorial-sign-up.md
[3]: ../../../request/learn/create.md
[4]: ../../../diary/learn/create-follow-up.md
[5]: ../../../custom-objects/learn/extra-field.md
[6]: ../../../automation/crmscript/learn/create-script.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/marketing/link-properties-follow-up.png
[img4]: ../../../../media/icons/marketing-and-forms/side-panel-content-text.png
