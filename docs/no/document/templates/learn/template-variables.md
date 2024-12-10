---
uid: help-no-template-variables
title: Malvariabler
description: Med malvariabler kan du tilpasse og automatisere inntasting av kundedata
keywords: document, mal, variabel, malvariabler
author: Bergfrid Dias
date: 12.10.2024
version: 10.3
topic: concept
language: no
---

# Malvariabler

Malvariabler brukes til å sette inn data fra SuperOffice i e-poster, tilbud, møtevarsler, dokumentmaler og så videre. Du kan bruke malvariabler til å tilpasse og automatisere innlegging av kundedata (eller data fra person, salg og annet) i innholdet ditt og sette opp komplekse tilbud.

## Eksempel: Slik tilpasser du en e-post ved hjelp av malvariabler

I stedet for denne teksten:

"Kjære kunde. Vil du vite mer om hvordan vårt produkt kan hjelpe din bedrift med å skaffe nye kunder? Ring oss."

Kan du sende denne:

"Hei, Bård Vil du vite mer om hvordan vårt produkt kan hjelpe Bilbutikken AS med å skaffe nye kunder? Ring Kari Nordmann på SuperShop."

Teksten du skriver inn vil se slik ut:

"Hei **{atfn}**. Vil du vite mer om hvordan vårt produkt kan hjelpe **{name}** til å vinne nye kunder? Ring **{cont}** på **{onam}**stedet."

## Hvordan bruke malvariabler

* Hele variabelen må være formatert med samme skrifttype og skriftstørrelse, og du må bare bruke små bokstaver. Men hvis preferansen **Tillat store bokstaver i malvariabler** er aktivert, kan malvariabelen formateres.

* Du kan blande vanlig tekst og variabler i maldokumentet: For eksempel kan du skrive inn malvariabler som henter et firmanavn og adresse, skrive inn standardtekst for brødteksten i brevet og angi variabelen for personen vår for å avslutte brevet.

* Du kan også bruke fylltegn i maldokumentet (se nedenfor).

* Dato og klokkeslett i malvariabler styres av systemklokken på PC-en.

* I dokumenter med filtype .doc i Office 2003 og eldre må du bruke vinklede hakeparenteser – < > – rundt variabler i stedet for klammeparenteser – { } –.

### Eksempel: møtereferater (topptekst)

Dette er et eksempel på en topptekst i et møtereferat (dokument eller e-post).

**Mal:**

```text
{head}
Dato / sted: {sdat}, {city}
Til stede: {attn} ({name}), {auth} ({onam})
Forfall:
Møtesekretær: {auth} ({auem})
```

**Resultat:**

```text
Sommerkampanje - planlegging
Dato/sted: 15.01.2020, Oslo
Deltakere: Hans Olsen (Liberty Ltd.), Kari Nordmann (SuperShop)
Forfall:
Referent: Jonas Berg (jb@supershop.com)
```

## Smarte variabler fra firmakortet

Adressevariabler fra firmakortet er såkalte "smarte" malvariabler. Dette betyr at systemet velger adressedata i en bestemt rekkefølge:

1. Hvis alternativet **Bruk som postadresse** er aktivt for en person i firmaet, brukes personens adressedata.
2. Hvis alternativet ovenfor ikke er aktivt, brukes firmaets adressedata.
3. Hvis firmaets postadresse er tom, brukes firmaets gateadresse.

## Variabler for tilbudsmaler

Ved bruk av tilbud og produkter i SuperOffice må du sette opp tilbudsmaler. Malene for tilbudsdokumenter, tilbudsdetaljer og ordrebekreftelser er annerledes enn vanlige dokumentmaler, siden de bruker flettefelt ("merge fields") i tillegg til standard malvariabler.

### Eksempel: ordrebekreftelse (topptekst)

Malvariabler for tilbud og ordrebekreftelser kan brukes i forbindelse med et tilbud.

**Mal:**

```text
Ordredato: {sdat}
Ordrenummer: {qnum}
Leveringsbetingelser: {qdev}
Betalingsbetingelser: {qpev}
Ditt bestillingsnummer: {qpon}
Vår kontakt: {cont}
```

**Resultat:**

```text
Ordredato: 15.12.2019
Ordrenummer: 550012
Leveringsbetingelser: Levering inkludert
Betalingsbetingelser: 15 dager
Ditt bestillingsnummer: 70000882
Vår kontakt: Kari Nordmann
```

## Variabler for service- og markedsføringsmaler

Når du genererer e-postmaler for forespørsler og utsendelser (og meldingsmaler) i markedsføring, kan du tilpasse e-postmeldingen eller utsendelsen med malvariabler. Disse variablene er litt forskjellige fra de som brukes i dokumenter.

## Referanse

Referansen er gruppert etter område. [Gå til referanse][1]

<!-- Referenced links -->
[1]: ../variables/index.md

<!-- Referenced images -->
