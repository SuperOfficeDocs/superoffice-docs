---
uid: help-no-define-link-actions
title: Definere koblingshandlinger
description: I denne veiledningen lærer du hvordan du bruker koblinger i utsendelser til å automatisere handlinger.
author: SuperOffice RnD
so.date: 02.20.2023
keywords: Markedsføring
so.topic: howto
language: no
---

# Bruke koblinger til å automatisere ulike handlinger

[!include[Requirement](includes/req-marketing.md)]

Du kan jobbe raskere ved å behandle svarene du får fra en utsendelse, med automatiserte koblingshandlinger.

Tenk deg at utsendelsen din er en stor suksess. Over 500 personer åpnet meldingen din og klikket på koblingene du inkluderte. Oppgaven din nå er å behandle alle disse svarene fra mottakerne. Tenk hvor lang tid dette ville tatt hvis du måtte gjøre det manuelt.

I SuperOffice Marketing kan du legge til handlinger i koblingene. Disse handlingene utløses når mottakeren klikker på en kobling.

![Definere koblingshandlingene -screenshot][img3]

| Fane | Handling |
|---|---|
| Respons | Legg til landingsside eller tilpasset tekst. |
| Angi felt | Legg til en verdi i et ekstra felt for kundekontakter |
| Interesser | Oppdater interesser. |
| Utvalg/prosjekt
 | Legg til/fjern kundekontakt fra et utvalg/prosjekt. |
| Oppfølging | Opprett en oppfølging (oppgave eller møte) i SuperOffice CRM. |
| Sak | Opprett ny sak. |
| Skript | Kjør et skript. |

## Respons

* **Omdirigere til ny nettside**: Velg dette alternativet for å omdirigere mottakerne til en nettside når de klikker på koblingen. Skriv inn URL-adressen i feltet **URL til ny side**.

* **Vis tilpasset tekst**: Velg dette alternativet hvis du vil at den tilpassede teksten skal vises for mottakerne når de klikker på koblingen. Skriv inn teksten i feltet nedenfor.

## Oppdatere databasen

Avhengig av målet og den CTA du bruker i utsendelsen, kan du oppdatere informasjonen i databasen. Når en person klikker på koblingen i utsendelsen, gjør SuperOffice CRM ett av følgende:

* Gi et tilpasset svar eller omdirigere til webside,
* Legge til en person i et bestemt prosjekt eller utvalg,
* Oppdatere interessen til en person,
* Legge til informasjon i et felt på personkortet,
* Opprette en oppfølgingsaktivitet for en person,
* Opprette en kundeservice-sak for en person,
* Kjøre et skript.

Noe av denne informasjonen vil hjelpe deg med å segmentere databasen enda bedre, mens annen informasjon vil hjelpe deg med å følge opp personer som har vist interesse for meldingen.

## Angi felt

I fanen **Angi felt** kan du angi at en verdi skal legges til i et ekstra felt når mottakeren klikker på koblingen. Dette kan være nyttig hvis du vil registrere ekstra informasjon om kunder som klikker på koblingen.

Velg et felt i listeboksen **Angi ekstrafelt**, og fyll ut med en verdi i feltet **Verdi**.

## <a id="interests" />Interesser

Her kan du spesifisere at klikk på en kobling skal legge til eller fjerne interesser for personen. Du kan for eksempel legge til interessen "Produktnyheter" hvis mottakeren klikker på koblingen "Ja takk! Jeg vil vite mer om nye produkter". Alternativt kan du fjerne interessen "Produktnyheter" hvis brukeren klikker på koblingen "Stopp abonnement" i et nyhetsbrev.

* I listeboksen **Angi interesse** kan du velge en interesse som skal legges til på personene hvis de klikker på koblingen.
* I listeboksen **Fjern interesse** kan du velge en interesse som skal fjernes på personene hvis de klikker på koblingen.

Se også [Fjerne interesser i SuperOffice CRM][1].

## Utvalg/prosjekt

Her kan du angi at mottakere som klikker på koblingen, skal legges til eller fjernes fra utvalg i SuperOffice Service eller fra utvalg eller prosjekter i SuperOffice CRM. Skriv inn begynnelsen av et navn for å starte hurtigsøket.

## Oppfølging (oppgave/møte)

I fanen **Oppfølging** kan du angi at et klikk på en kobling skal generere oppgaver eller møter i SuperOffice CRM.

1. Merk av for **Oppfølging** for å aktivere denne funksjonen.

2. **Oppgave/Avtale**: Velg hvilken type oppfølging du vil opprette.

3. **Beskrivelse**: Angi en beskrivelse av oppfølging. Dette kan for eksempel være hvilken utsendelse det gjelder, hvilken kobling mottakeren har klikket på, og eventuelt hvordan oppgaven/møtet skal følges opp.

4. **Prosjekt**: Her velger du et prosjekt som oppfølgingen skal tilknyttes. Skriv inn begynnelsen av et navn for å starte hurtigsøket.

5. **Oppgave**: Velg påkrevd type.

6. **Opprettet av**: Velg hvilken bruker som skal være ansvarlig for oppfølgingen, eller klikk på knappen **Velg aktiv bruker**![ikon][img1] for å velge deg selv.

7. **Fordel til vår kontakt hvis tilgjengelig**: Merk av her hvis oppfølgingen skal tildeles "vår kontakt" for mottakeren (den kundeansvarlige).

8. **Standardmottaker**: Velg en standardmottaker som oppfølgingen skal tildeles, eller klikk på knappen **Velg aktiv bruker**![ikon][img1] for å velge deg selv.

9. **Varighet**: Klikk på knappen **Velg tidsperiode**![ikon][img2] ved siden av dette feltet for å angi varigheten for oppfølgingen.

## Sak

I fanen **Sak** kan du angi at en SuperOffice Service-sak skal opprettes for personer som klikker på en kobling.

1. **Opprett ny sak**: Merk av her for å registrere en ny sak når kunden klikker på koblingen.
2. **Tittel**: Her skriver du inn ønsket tittel på den nye saken.
3. **Prioritet**: Velg prioriteten saken vil ha.
4. **Kategori**: Velg ønsket kategori.
5. **Eier**: Velg ønsket eier for den nye saken. Du kan også velge **Automatisk tildelt** eller **Ufordelt**.

## Skript

I fanen **Skript** kan du velge et skript eller en makro som skal kjøres når mottakeren klikker på koblingen.

1. Velg **Kjør skript** for å aktivere denne funksjonen.
2. Klikk på listen **Skript** og velg ønsket skript fra listen som vises. Følgende variabler er tilgjengelige i skriptet: custId, linkId, shipmentId, linkUrl og linkHits. Du kan dessuten bruke variabelen returnUrl for å overstyre den angitte URL-adressen til koblingen.

## Eksempel

Manuell oppdatering av 500 personkort vil ta tid og er virkelig unødvendig. La oss i stedet automatisere denne prosessen ved hjelp av automatiserte koblingshandlinger.

Eksempler på automatiserte koblingshandlinger i bruk:

* Når en mottaker klikker på handlingskoblingen din, legger SuperOffice CRM automatisk ham eller henne til i et utvalg eller prosjekt.

* Alternativt kan SuperOffice CRM automatisk oppdatere relevant informasjon, for eksempel interesser, på personkortet.

Ved å automatisere disse oppgavene sparer du mye tid du ellers ville brukt på å håndtere svar. Når leseren klikker på en kobling i utsendelsen din, utfører systemet koblingshandlingene for deg!

Du kan bruke informasjonen du har samlet inn i denne utsendelsen, på flere måter:

* Generer et utvalg automatisk basert på personer som klikket på en bestemt kobling. Send deretter en målrettet oppfølgende utsendelse til denne gruppen med en skreddersydd melding.

* Legg til oppfølgingsaktiviteter i teammedlemmenes dagbøker, slik at de personlig kan følge opp personer som har svart.

* Generer service-saker slik at kundeserviceteamet ditt kan fange dem opp og undersøke saken.

<!-- Referenced links -->
[1]: ../../mailing/learn/create/add-unsubscribe-link.md#clear-interests

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-contact.png
[img2]: ../../../../../common/icons/pref-diary.png
[img3]: ../../../../media/loc/en/marketing/link-properties-follow-up.png
