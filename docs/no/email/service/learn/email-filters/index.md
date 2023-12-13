---
uid: help-no-email-filter
title: E-postfiltre
description: E-postfiltre
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: e-post
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: no
---

# E-postfiltre

Et e-postfilter er et verktøy som brukes til å analysere innholdet i innkommende e-post, og genererer en sak basert på dette innholdet.

Du kan også legge til avanserte regler for håndtering av e-post fra bestemte avsendere. E-postfiltre brukes ofte i forbindelse med nettskjemaer som firmaet har publisert og som genererer en e-postmelding i fast format som importeres til SuperOffice Service.

## Eksempel relatert til innkommende e-post fra nettskjemaer

Du kan for eksempel definere faste uttrykk for å trekke ut informasjon som en kunde har sendt inn ved hjelp av skjemaet. Basert på et definert regelsett legges data fra skjemaet inn i kundedatabasen. Saken generert fra e-posten / skjemaet blir deretter plassert i en bestemt kategori og en saksbehandler blir valgt. Deretter lukkes saken, og kunden mottar en tilpasset kvittering basert på en svarmal. Det er med andre ord mange alternativer for automatisk håndtering av innkommende e-post.

* E-post som mottas fra et webskjema, har vanligvis en standard avsenderadresse. Du kan erstatte denne adressen med kundens egen e-postadresse.

* Du kan sammenligne kundens telefonnummer med informasjonen i kundedatabasen og koble saken til riktig kunde basert på dette.

* Du kan overskrive adressedata hvis det skjer en adresseendring.

* Du kan sende kvittering med skreddersydd informasjon hvis en kunde ønsker mer informasjon om et bestemt produkt, samt fordele til riktig underkategori og saksbehandler.

## Kolonner i listen over filtre

Fanen **E-postfiltre** inneholder en liste over eksisterende e-postfiltre. Denne listen inneholder følgende kolonner:

| Kolonne | Beskrivelse |
|---|---|
| Beskrivelse | En beskrivelse av e-postfilteret. |
| Prioritet | E-postfilterets prioritet. Bare ett filter per e-post er aktivert. Hvis mer enn ett filter inneholder søkekriterier som samsvarer med en innkommende e-post, aktiveres filteret med høyest prioritet. |
| E-postadresser | Adressene til e-postkassen filteret gjelder for. |
| Søkestreng | Søkestrengen som e-postfilteret bruker. |

## Egenskaper for genererte saker

* **Angi eier**: Hvis merket av, kan du velge hvilken bruker som skal tildeles e-postmeldinger behandlet av dette filteret.

* **Angi kategori**: Hvis du merker av her og velger en kategori, vil e-post som behandles av dette filteret havne i den angitte kategorien.

* **Saksstype**: Hvis du sjekker her og velger en type, vil e-post som behandles av dette filteret bli tildelt den angitte [sakstypen][3]. (Tilgjengelig bare i pilot.)

* **Angi prioritet**: Hvis du merker av her og velger en prioritet, vil e-post behandlet av dette filteret bli tildelt den angitte prioriteten.

* **Angi tilgangsnivå**: Hvis du merker av her og velger et tilgangsnivå fra listen, vil e-post som behandles av dette filteret, bli tildelt det angitte tilgangsnivået. Hvis du velger **Ekstern,**, vil den genererte saken være tilgjengelig i SuperOffice kundesenter.

* **Sett opp melding**: Hvis du merker av her og velger en svarmal, vil saksmeldingen settes opp i henhold til den valgte malen, sammenslått med alle de faste uttrykkene som ble funnet. Du kan bruke dette til å presentere et skjema, som sendes på e-post, og er mye ryddigere. Denne meldingen vil erstatte den opprinnelige e-posten.

* **Avslutt sak**: Hvis merket av, lukkes saken umiddelbart og tilordnes statusen **Lukket**.

* **Ignorer avsenderadresse**: Hvis dette alternativet er valgt, ignorerer SuperOffice Service den opprinnelige avsenderadressen. Saken blir da ikke koblet til en person med mindre andre regler i e-postfilteret oppretter en kobling til en person.

* **Blokker e-post**: Hvis dette er valgt, importeres ikke e-posten til SuperOffice Service. Den legges i stedet til listen i fanen **Blokkert e-post**.

* **Slett e-post permanent**: Hvis merket av, slettes e-posten permanent.

    > [!NOTE]
    > Det er ikke mulig å gjenopprette e-postmeldinger som er slettet permanent.

* **Videresend til**: Hvis du merker av her og skriver inn en e-postadresse, blir e-posten videresendt til denne adressen.

* **Inkluder feilsøkingsinformasjon i meldingen**: Hvis dette alternativet er valgt, inneholder meldingen feilsøkingsdata som du kan bruke til å kontrollere at e-postfilteret fungerer som det skal.

* **Merk e-post som returnert**: Hvis dette er valgt, vil e-post som behandles av dette filteret bli merket som returnert. Dette kan være relevant for e-postmeldinger mottatt fra postmester, mailer-daemon og så videre.

## Hva vil du gjøre nå?

* [Opprette e-postfiltre][1]
* [Slette e-postfiltre][2]

<!-- Referenced links -->
[1]: create-email-filter.md
[2]: delete-email-filter.md
[3]: ../../../../request/learn/type/index.md

<!-- Referenced images -->
