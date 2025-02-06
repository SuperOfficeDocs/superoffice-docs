---
uid: help-no-blocked-email-addresses
title: Blokkerte e-postadresser
description: Finn ut hvordan du håndterer returnerte e-postmeldinger i denne veiledningen.
keywords: Markedsføring
author: SuperOffice RnD
date: 02.09.2024
version: 10
topic: howto
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Behandle returmeldinger

Det er mange årsaker til at e-postadresser returneres. Personene dine har byttet jobb, en e-postadresse er feilstavet, og til og med midlertidige feil i kundens infrastruktur er de typiske årsakene til at utsendelser returneres.

De første gangene du sender ut utsendelsen din, kan du få et stort antall returnerte e-poster. Det er gode nyheter, fordi det betyr at du kan oppdatere hver e-postadresse som er feilstavet eller ikke lenger i bruk. Å oppdatere de returnerte e-postadressene vil hjelpe deg med å øke suksessraten for fremtidige utsendelser.

Du kan administrere returmeldinger og blokkerte e-postmeldinger både for individuelle utsendelser og for ALLE utsendelser.

## Hvorfor returneres e-postmeldinger?

E-postmeldinger kan bli returnert på grunn av feil i e-postadresser, søppelpost-/spamfiltre, Internett-problemer eller fulle innbokser.

* Midlertidige problemer: leveringsforsinkelser, e-postserver midlertidig ikke tilgjengelig
* Permanente problemer: feil adresse, ukjent domene.

Midlertidig mislykkede e-postadresser blir ikke blokkert og blir ikke hoppet over i neste utsendelse.

> [!NOTE]
> For å forhindre feilstavede eller ugyldige e-postadresser validerer SuperOffice mottatte e-postadresser via chat og skjemaer. Valideringen utføres ved hjelp av DNS-oppslag og kontroll av grunnleggende e-postsyntaks.

Det finnes to typer returmeldinger:

En **hard retur** er når utsendelsen ikke kan leveres permanent, fordi e-postadressen ikke eksisterer, domenet ikke eksisterer (lenger), eller mottakerens e-postserver har blokkert leveringen. En oppdatering av e-postadressen løser problemet.

En **myk retur** oppstår når det er et midlertidig leveringsproblem. SuperOffice CRM vil prøve å sende utsendelsen på nytt flere ganger for å levere den når en e-post blir returnert. Det er først når e-posten ikke kan leveres etter flere forsøk, at den blir registrert som en hard retur.

Bruk filterknappene (Sendt, Returnert og Åpnet) til å [filtrere mottakerlisten][1]. Når du har valgt alle personene som utsendelsen ble returnert for, kan du samle dem i et utvalg eller prosjekt ved hjelp av handlingsmeny-knappen nederst til venstre.

![Filtrer de returnerte e-postene dine og velg hva du vil gjøre med dem -screenshot][img2]

## Slik reparerer du én enkelt e-postadresse

1. Velg e-postmeldingen i listen og klikk på **Åpne** i sidepanelet for å redigere personen.
2. Gå til fanen **Detaljer**.
3. Et advarselsikon (<i class="ph ph-warning" aria-hidden="true"></i>) ved siden av e-postadressen indikerer et problem. Hold musepekeren over ikonet for å vise årsaken til problemet.

> [!TIP]
> Klikk på en kolonne for å få tilgang til sorterings- og grupperingsfunksjonene.

## Blokkerte e-postadresser

E-postadresser som har blitt returnert på grunn av permanente feil eller har returnert flere ganger, blokkeres automatisk og vil bli hoppet over i fremtidige utsendelser.

> [!NOTE]
> Hvis en e-post returneres mer enn fem ganger, blokkeres den automatisk. Du kan justere denne innstillingen i den globale innstillingen **Antall godkjente returer før e-postadressen blir deaktivert** i Innstillinger og vedlikehold.

Alle blokkerte e-postadresser fra alle utsendelser er arkivert i fanen**Blokkerte e-postadresser**. Denne fanen gir en utmerket oversikt over e-postadresser som må rengjøres.

> [!TIP]
> Klikk på en kolonne for å få tilgang til sorterings- og grupperingsfunksjonene.

## Returalternativer

Hvis du vil håndtere flere e-postadresser, har du alternativer i knappen **Handlinger**.

### Eksportere

1. Velg e-postadressene du vil eksportere.
2. Velg **Handlinger** > **Eksporter**.
3. Velg et eksportformat. Eksportfilen vises nederst i nettleseren. Den finnes også i nedlastingsmappen.

### Kopier til et nytt utvalg

1. Velg e-postadressene du vil legge til et nytt utvalg.
2. Velg **Handlinger** > **Legg til i nytt utvalg**.
3. Skriv inn navnet på det nye utvalget og klikk på **OK**. Et nytt statisk utvalg opprettes med de valgte e-postadressene.

### Legg til et nytt prosjekt

1. Velg e-postadressene du vil legge til i et nytt prosjekt.
2. Velg **Handlinger** > **Legg til i nytt prosjekt**.
3. Skriv inn navnet på det nye prosjektet og klikk på **OK**. Et nytt prosjekt opprettes med de valgte e-postadressene.

### Legg til i eksisterende utvalg

1. Velg e-postadressene du vil legge til i et eksisterende utvalg.
2. Velg **Handlinger** > **Legg til i eksisterende utvalg**.
3. Begynn å skrive i søkefeltet for å finne det relevante utvalget.
4. Klikk på utvalget du vil bruke i resultatlisten.
5. Klikk på **OK**. De valgte e-postadressene legges til i utvalget.

### Legg til i eksisterende prosjekt

1. Velg e-postadressene du vil legge til i et eksisterende prosjekt.
2. Velg **Handlinger** > **Legg til i eksisterende prosjekt**.
3. Begynn å skrive i søkefeltet for å finne det relevante prosjektet.
4. Klikk på prosjektet du vil bruke i resultatlisten.
5. Klikk på **OK**. De valgte e-postadressene blir lagt til i prosjektet

### Slett valgte e-postadresser

Bruk dette alternativet til å slette e-postadresser permanent fra databasen.

1. Velg e-postadressene du vil slette.
2. Velg **Handlinger** > **Slett valgte e-postadresser**.
3. Klikk på **OK** for å bekrefte.

### Fjern returmerking

Bruk dette alternativet til å fjerne e-postadresser fra listen, slik at de kan brukes i utsendelser. Dette kan være relevant hvis returer skyldes feil konfigurasjon eller midlertidige tekniske årsaker, eller hvis du vet at disse e-postadressene er riktige og vil prøve å sende en gang til.

1. Velg e-postadressene du vil fjerne returmerkingen for.
2. Velg **Handlinger** > **Fjern returmerking**.
3. Klikk på **OK** for å bekrefte.

### Sett som tidligere ansatt

Bruk dette alternativet for å angi en person som tidligere ansatt.

1. Velg e-postadressene du vil slette.
2. Velg **Handlinger** > **Sett som tidligere ansatt** .
3. Klikk på **OK** for å bekrefte.

<!-- Referenced links -->
[1]: look-at-recipient-list.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/marketing/handle-bounced-emails.png
