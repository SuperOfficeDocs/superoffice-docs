---
uid: help-no-template-variables
title: Malvariabler
description: Med malvariabler kan du tilpasse og automatisere inntasting av kundedata
author: SuperOffice RnD
so.date: 02.23.2023
keywords: dokument, mal, variabel
so.topic: concept
language: no
---

# Malvariabler

Malvariabler brukes til å sette inn data fra SuperOffice i e-poster, tilbud, møtevarsler, dokumentmaler og så videre. Du kan bruke malvariabler til å tilpasse og automatisere innlegging av kundedata (eller data fra person, salg og annet) i innholdet ditt og sette opp komplekse tilbud

> [!TIP]
> Se alle de ulike [malvariablene][2] du har for **firmakortet**.

## Eksempler

Her viser vi deg noen eksempler på hvordan du bruker malvariabler. Mange av eksemplene bruker standardmalene i SuperOffice.

### Slik tilpasser du en e-post ved hjelp av malvariabler

I stedet for denne teksten:

"Kjære kunde. Vil du vite mer om hvordan vårt produkt kan hjelpe din bedrift med å skaffe nye kunder? Ring oss."

Kan du sende denne:

"Hei, Bård Vil du vite mer om hvordan vårt produkt kan hjelpe Bilbutikken AS med å skaffe nye kunder? Ring Kari Nordmann på SuperShop."

Teksten du skriver inn vil se slik ut:

"Hei **{atfn}**. Vil du vite mer om hvordan vårt produkt kan hjelpe **{name}** til å vinne nye kunder? Ring **{cont}** på **{onam}**stedet."

### Signaturer

Dette er et eksempel på en signatur som kan brukes av alle i firmaet ditt.

```text
Med vennlig hilsen,
{auth}
{atit}
{onam}
Adresse: {opad}, {ozip} {ocit}
Telefon: {audp}
Mobiltelefon: {aupc}
{auem}
{owww} | Vennlig hilsen
Kari Nordmann
Salgssjef
SuperShop
Adresse: Storgata 12, 0655 Oslo
Phone: 22334455
Mobiltelefon: 99887766
kn@supershop.com
supershop.com
```

### Møtereferater (topptekst)

Dette er et eksempel på en topptekst i et møtereferat (dokument eller e-post).

```text
{head}
Dato / sted: {sdat}, {city}
Til stede: {attn} ({name}), {auth} ({onam})
Forfall:
Møtesekretær: {auth} ({auem})
Sommerkampanje - planlegging
Dato/sted: 15.01.2020, Oslo
Deltakere: Hans Olsen (Liberty Ltd.), Kari Nordmann (SuperShop)
Forfall:
Referent: Jonas Berg (jb@supershop.com)
```

### Ordrebekreftelse (topptekst)

Malvariabler for tilbud og ordrebekreftelser kan brukes i forbindelse med et tilbud.

```text
Ordredato: {sdat}
Ordrenummer: {qnum}
Leveringsbetingelser: {qdev}
Betalingsbetingelser: {qpev}
Ditt bestillingsnummer: {qpon}
Vår kontakt: {cont}
Ordredato: 15.12.2019
Ordrenummer: 550012
Leveringsbetingelser: Levering inkludert
Betalingsbetingelser: 15 dager
Ditt bestillingsnummer: 70000882
Vår kontakt: Kari Nordmann
```

## Hvordan bruke malvariabler

* I dokumenter med filtype .doc i Office 2003 og eldre må du bruke vinklede hakeparenteser – < > – rundt variabler i stedet for klammeparenteser – { } –.
* Hele variabelen må være formatert med samme skrifttype og skriftstørrelse, og du må bare bruke små bokstaver. Men hvis preferansen **Tillat store bokstaver i malvariabler** er aktivert, kan malvariabelen formateres.
* Du kan blande vanlig tekst og variabler i maldokumentet: For eksempel kan du skrive inn malvariabler som henter et firmanavn og adresse, skrive inn standardtekst for brødteksten i brevet og angi variabelen for personen vår for å avslutte brevet.
* Du kan også bruke fylltegn i maldokumentet (se nedenfor).
* Dato og klokkeslett i malvariabler styres av systemklokken på PC-en.

> [!TIP]
> Når du har opprettet et nytt maldokument, må du legge det til ved hjelp av skjermbildet **Lister** i Innstillinger og vedlikehold for å bruke det i SuperOffice CRM.

## Fylltegn

Noen ganger bør du bruke fylltegn i maler slik at et felts innhold eller formatering ikke endres eller slettes hvis innholdet i et felt er kortere enn lengden angitt av feltvariabelen.

Du bruker variabelen padd# for å angi fylltegnet som skal brukes. Erstatt #-tegnet med ANSI-koden for det tegnet du ønsker å bruke som fylltegn. Du finner vanligvis en liste over ANSI-koder i håndboken til programmet du lager maler for.

SuperOffice CRM har standardverdier for fylltegn for de mest brukte tekstbehandlings- og regnearkprogrammene. En myk bindestrek brukes vanligvis fordi den ikke vises på skjermen eller en utskrift. For programmer der oppsettet er ukjent, bruker SuperOffice CRM {padd32}, som er ANSI-koden for et mellomrom.

> [!TIP]
> Microsoft Word bruker {padd31} som fylltegn.

Hvis du ikke vil bruke fylltegn, bruker du malvariabelen {padd0}.

> [!NOTE]
> Dette fungerer bare for dokumentformater som er sekvensielle, for eksempel Notisblokk og AmiPro-maler uten grafikk.

Når du bruker {padd0} kan du skrive alle malvariablene uten tomme tegn mellom navnet på malvariabelen og den avsluttende variabelens skilletegn (}).

## Variabler fra firmakortet

> [!NOTE]
> Adressevariabler fra firmakortet er såkalte "smarte" malvariabler. Dette betyr at systemet velger adressedata i en bestemt rekkefølge. Variablene i **fet tekst** nedenfor (som for eksempel **adr** og **by**) er smarte malvariabler.

Når du bruker adressevariabler fra firmakortet, vil systemet velge adressedata i følgende rekkefølge:

1. Hvis alternativet **Bruk som postadresse** er aktivt for en person i firmaet, brukes personens adressedata.
2. Hvis alternativet ovenfor ikke er aktivt, brukes firmaets adressedata.
3. Hvis firmaets postadresse er tom, brukes firmaets gateadresse.

## Variabler for tilbudsmaler

Ved bruk av tilbud og produkter i SuperOffice må du sette opp tilbudsmaler og variablene finnes i en pdf som også viser hvordan man jobber med tilbudsmaler.

Malene for tilbudsdokumenter, tilbudsdetaljer og ordrebekreftelser er annerledes enn vanlige dokumentmaler, siden de bruker flettefelt ("mergefields") i tillegg til standard malvariabler.

## Variabler for service- og markedsføringsmaler

Når du genererer e-postmaler for forespørsler og utsendelser (og meldingsmaler) i markedsføring, kan du tilpasse e-postmeldingen eller utsendelsen med malvariabler. Disse variablene er litt forskjellige fra de som brukes i dokumenter.

## Referanse

Referansen er gruppert etter område. [Gå til referanse][1]

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/index.html
[2]:https://docs.superoffice.com/en/document/templates/variables/from-company-card.html

<!-- Referenced images -->
