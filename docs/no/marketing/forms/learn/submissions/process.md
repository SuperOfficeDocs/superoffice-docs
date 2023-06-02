---
uid: help-no-form-submissions-process
title: Behandle skjemainnsendinger
description: I denne veiledningen lærer du hvordan du behandler skjemainnsendinger manuelt.
author: SuperOffice RnD
so.date: 02.21.2023
keywords: Skjemaer
so.topic: howto
language: no
---

# Behandle skjemainnsendinger

Så snart skjemainnsendingene begynner å strømme inn, er det på tide å behandle dem. Skjemaer kan behandles automatisk, manuelt eller en kombinasjon av begge.

> [!NOTE]
> SuperOffice vil kontrollere og validere e-postadressen som er oppgitt i skjemaet for å sikre at det er et eksisterende domenenavn. Grunnleggende e-postadressesyntaks vil også bli sjekket.

Når du har konfigurert webskjemaet til å behandle alle innkommende innsendinger automatisk, trenger du ikke løfte en finger. SuperOffice CRM behandler dem for deg og oppretter en ny person når det ikke finnes en match i databasen.

* Når du behandler skjemainnsendinger manuelt, kan du forhindre duplikater ved å kontrollere om en person allerede er registrert i databasen eller ikke.

* Du kan også velge dette alternativet «Manuelt hvis innsender er ukjent. Automatisk hvis innsender er kjent». Deretter har du mer kontroll over personene som er lagt til i databasen via skjemainnsendinger.

Skjemainnsendinger med statusen **Innsendt** må behandles manuelt. Dette innebærer å gå gjennom innholdet i skjemaet og knytte innsenderen til en eksisterende eller ny person og/eller et firma i SuperOffice. Behandlede skjemaer er tilgjengelige på detaljkortet **Aktiviteter** i skjermbildene Firma og Person i SuperOffice CRM. Hvis du valgte å bli varslet ved Ny sak, vil de behandlede skjemaene være tilgjengelige på detaljkortet**Forespørselsseksjon**.

Se denne videoen (eller følg den trinnvise veiledningen nedenfor) for å lære hvordan du kan behandle et innsendt webskjema manuelt (videolengde – 4:30), eller følg trinnene nedenfor.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->

> [!Video https://www.youtube.com/embed/XtdkUwIXkww]

## Trinn

1. I SuperOffice Markedsføring:
    1. Åpne et skjema, og gå til kategorien **Skjemainnsendinger**, eller gå til fanen **Skjemainnsendinger** (i hovedskjermbildet **Markedsføring**).
    2. Nederst i listen over skjemainnsendinger fjerner du valget for alle filtre bortsett fra **Sendt inn**. Listen viser nå bare skjemainnsendinger som må behandles.

    I SuperOffice CRM: Gå til skjermbildet Person, søk etter den aktuelle personen og velg detaljkortet**Aktiviteter** .

2. Dobbeltklikk på en rad.

3. I vinduet **Skjemainnsending** ser du gjennom de innsendte dataene i detaljkortet **Data fra skjema**.

4. Gå til fanen **Handlinger** for å se handlingene som utføres i skjemadataene når du behandler skjemaet.

5. I sidepanelet **Innsender** må du koble innsenderen til en eksisterende eller ny person i SuperOffice.

6. Klikk på **Behandle**.

## Koble innsenderen til en person og et firma i SuperOffice

Når et skjema sendes inn, vil SuperOffice prøve å matche e-postadressen i skjemaet med eksisterende e-postadresser i SuperOffice for å knytte skjemainnsendingen til en eksisterende person. Hvis innsenderen finnes i SuperOffice, kan du vise kontaktinformasjon, saker, salg, oppfølging og tidligere registrerte chatsesjoner.

Hvis det ikke blir funnet en match, kan du prøve å finne riktig person eller opprette en ny person (og firma).

### Bruk foreslått person

Hvis SuperOffice finner matchende personer i databasen, er de oppført under **Denne personen kan være...**. Klikk på en person for å se aktuell informasjon og for å koble personen til denne skjemainnsendingen.

### Søke etter en person

Hvis SuperOffice ikke finner den riktige personen i databasen, kan du søke etter personen ved hjelp av søkefeltet. Her kan du også velge fra historikklisten og favorittene.

### Bytt person

Hvis du valgte feil person, klikker du på **Bytt person** nederst i sidepanelet for å søke etter en annen person.

### Opprett nytt firma og ny person

Hvis innsenderen ikke finnes i SuperOffice, kan du opprette en ny person og et nytt firma i sidepanelet.

1. Klikk på **Opprett nytt firma og ny person**. Noen felt fylles ut med informasjon kunden har oppgitt i skjemaet.
2. Fyll ut de aktuelle feltene.
3. Klikk på **Legg til**. Den nye personen og firmaet legges til i SuperOffice.
