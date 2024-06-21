---
uid: help-no-form-submissions-process
title: Behandle skjemainnsendinger
description: I denne veiledningen lærer du hvordan du behandler skjemainnsendinger manuelt.
keywords: skjema, skjemainnsending, data fra skjema, skjemadata, innsender, innsendt, sendt inn
author: Bergfrid Dias
date: 03.07.2024
version: 10
topic: howto
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Behandle skjemainnsendinger

Så snart skjemainnsendingene begynner å strømme inn, er det på tide å behandle dem. Skjemaer kan behandles automatisk, manuelt eller en kombinasjon av begge deler. Dette er spesifisert som [skjemahandlinger][2].

Skjemainnsendinger med status **Innsendt** må behandles manuelt. Dette innebærer å gjennomgå skjemainnholdet og knytte innsenderen til en eksisterende eller ny kontakt og/eller bedrift i SuperOffice.

Den viktigste grunnen til å velge manuell behandling er å ha mer kontroll over kontaktene som legges til i databasen gjennom skjemainnsendinger. Spesifikt kan du forhindre duplikatkontakter ved å sjekke om en person allerede er registrert. SuperOffice validerer e-postadressen i skjemaet for å sikre at det er en gyldig domene. Grunnleggende e-postsyntaks blir også sjekket.

Når et skjema sendes inn, forsøker SuperOffice å knytte skjemaet til en eksisterende kontakt ved hjelp av den oppgitte e-postadressen.

* Hvis det finnes en match, kan du vise kontaktopplysninger, forespørsler, salg, oppfølginger og tidligere chat-sesjoner.
* Hvis ingen match blir funnet, søk etter riktig kontakt eller opprett en ny.

Se denne videoen (eller følg den trinnvise veiledningen nedenfor) for å lære hvordan du kan behandle et innsendt webskjema manuelt (videolengde – 4:30), eller følg trinnene nedenfor.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/XtdkUwIXkww]

## Trinn

### 1- Finn og åpne skjemainnsendingen

Gjør ett av følgende:

* Hvis du ble varslet av en servicesak, åpne saken og klikk på lenken.

* Hvis innsenderen er kjent, gå til skjermbildet Person, søk etter den relevante personen, og velg fanen **Aktiviteter**. Dobbeltklikk på raden med den ubehandlede skjemainnsendingen.

* I SuperOffice Marketing:

    1. Åpne et skjema og gå til fanen **Skjemainnsendinger**, eller gå til fanen **Skjemainnsendinger** i hovedskjermen for markedsføring.

    2. Nederst på listen over skjemainnsendinger, fjern alle filtre unntatt **Sendt inn**. Listen viser nå bare skjemainnsendinger som må behandles.

    3. Dobbeltklikk på raden med innsendingen du vil behandle.

### 2 - Gjennomgå og behandle data

I **Skjemainnlevering**-vinduet:

1. Velg fanen **Data fra skjema** og gjennomgå de innsendte dataene.

2. Velg fanen **Handlinger** for å se handlingene som utføres på skjemadataene når du behandler dem.

3. I sidepanelet for **Innsender**, knytt innsenderen til en eksisterende eller ny SuperOffice-person:

    * **Bruk foreslått person:** Hvis SuperOffice finner matchende personer, vises de under **Denne personen kan være...**. Klikk på en person for å knytte den til denne skjemainnsendingen.

    * **Søk etter person:** Hvis den riktige personen ikke finnes, bruk søkefeltet for å finne den. Du kan også velge fra historikklisten og favoritter.

    * **Bytt person:** Hvis du har valgt feil person, klikk på **Bytt person** for å søke på nytt.

    * **Opprett nytt firma og ny person:** Hvis innsenderen ikke finnes i SuperOffice, opprett en ny person og et nytt firma:

      1. Klikk på **Opprett nytt firma og ny person**. Noen felt er forhåndsutfylt med skjemadata.
      2. Fullfør relevante felt.
      3. Klikk på **Legg til** for å legge til den nye personen og det nye firmaet i SuperOffice.

4. Klikk på **Behandle**.

![Skjemainnsending, Data fra skjema -screenshot][img1]

## Aktuelt innhold

* [Spore skjemainnsendinger og vise statistikk][1]
* [Vise statistikk for utsendelse][4]

<!-- Referenced links -->
[1]: view-statistics.md
[2]: define-form-actions.md
[4]: ../../mailing/learn/view-statistics.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/form-submission-add-contact.png
