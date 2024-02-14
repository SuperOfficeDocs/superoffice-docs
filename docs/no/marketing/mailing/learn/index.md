---
uid: help-no-mailing
title: Arbeide med utsendelser
description: Arbeide med utsendelser
keywords: Markedsføring
author: SuperOffice RnD
so.date: 02.12.2024
so.version: 10
so.topic: concept
language: no
so.audience: user
so.audience.tooltip: SuperOffice Marketing
---

# Arbeide med utsendelser

En utsendelse håndteres vanligvis i to trinn:

* [Forberede og sende utsendelsen][1]
* [Oppfølging av fullført utsendelse](#after)

## Utsendelsestyper

* E-post
* SMS
* Dokument
* Skjemasvar

> [!NOTE]
> E-postutsendelser og skjemasvar er utsendelsestypen som har flest funksjoner. Funksjoner som [sporede koblinger][7] og [påmeldingskoblinger][6] er ikke tilgjengelige for utsendelse av SMS og dokumenter.

## Definer målet ditt

For å sikre at utsendelsen din blir en suksess, trenger du først og fremst å nå ut til de rette personene. Jo bedre du klarer å begrense målgruppen din, desto større er sjansen for at riktig budskap når riktig person.

Hva ønsker du å oppnå med utsendelsen din? Ønsker du å:

* Få flere salgsmuligheter?
* Selge flere nye produkter eller tjenester til kunder som du allerede har?
* Forbedre kundelojaliteten og beholde kundene?
* Informere om nye utviklinger, milepæler eller forslag?

SuperOffice CRM tilbyr mange måter å lage en solid [målliste][8] på. Du kan bruke utvalg, prosjekter eller en enkeltperson som er lagret i systemet. Alle personer som ennå ikke er tilgjengelige i SuperOffice CRM-databasen, kan legges til ved å importere en Excel-liste, forutsatt at de har gitt samtykke til å få tilsendt markedsføringsmeldinger fra firmaet ditt.

Du kan også bygge en adresseliste ved hjelp av [elektroniske webskjemaer][5]. Ikke bare kan du fange opp nye salgsmuligheter blant besøkende på websiden din som fyller ut et webskjema, men du kan også bruke webskjemaer til å invitere folk til å abonnere eller melde seg på forskjellige utsendelser.

Finn ut mer om hvordan du [oppretter og bruker webskjemaer i Marketing][4].

## Mottakere

Du kan legge til mottakere fra flere kilder.

> [!NOTE]
> Når du legger til mottakere, vil kun personer med gyldig e-postadresse (eller mobiltelefonnummer ved utsendelser av SMS) bli lagt til i listen **Mottakere**.

Importerte mottakere som IKKE finnes i SuperOffice-databasen, vil bare bestå av et navn og en e-postadresse (eller bare en e-postadresse). Det betyr at det bare er malvariablene **[[customer.name]]** og/eller **[[customer.email]]** som vil fungere for disse mottakerne. For å unngå tomme variabler i utsendelsene må du passe på at du [forhåndsviser utsendelsen][3] først.

## Knytte en utsendelse til utvalg eller prosjekt

Du kan knytte utsendelsen til et utvalg og/eller et prosjekt for å holde oversikt over alle utsendelser som er relatert til utvalgene og prosjektene dine. Utsendelsene står oppført i detaljkortet **Utsendelser** i **Utvalg** og i detaljkortet **Aktiviteter** i **Prosjekter** i SuperOffice CRM.

> [!NOTE]
> Hvis du legger til et utvalg eller prosjekt, legges eventuelle personer i utvalget eller prosjektet til som mottakere i utsendelsen. Hvis du legger til både et utvalg og et prosjekt, legges bare personer fra utvalget til som mottakere.

Eksempel: Hvis du sender ut flere utsendelser for å markedsføre et arrangement, kan du legge til disse utsendelsene i et utvalg kalt "Arrangement 2015", slik at du har en fullstendig liste over alle utsendelsene for dette arrangementet. Og hvis du oppretter et prosjekt for arrangementet, kan du på tilsvarende måte ha en liste over alle prosjektrelaterte utsendelser i detaljkortet **Aktiviteter**.

## <a id="after" />Hvordan kan jeg følge opp utsendelsen?

Etter at utsendelsen er sendt, er det alltid spennende å se hvor godt den har gjort det. Da ser du om alt det harde arbeidet ditt har lønnet seg. Det er også en flott mulighet til å kontrollere og forbedre kvaliteten på informasjonen som er registrert i CRM-databasen.

* [Vise statistikk][2] for utsendelsen og få informasjon om eventuelle problemer som har oppstått.
* [Legge til mottakere i utvalg og prosjekter][12] for videre behandling.
* [Kontrollere og korrigere e-postadresser som har forårsaket returer][11].
* Se [hvem som har klikket på de sporbare koblingene][14] du satte inn i meldingen.
* Administrere e-postadresser som ble returnert på grunn av permanente feil, eller som har blitt [returnert][13] flere ganger.

<!-- Referenced links -->
[1]: create/index.md
[3]: create/send-test-email.md
[2]: view-statistics.md
[4]: ../../forms/learn/create.md
[6]: ../../recipients/learn/add-unsubscribe-link.md
[8]: ../../recipients/learn/index.md
[11]: ../../recipients/learn/look-at-recipient-list.md
[12]: ../../recipients/learn/look-at-recipient-list.md#add-recipients
[13]: ../../recipients/learn/manage-bounces.md
[14]: ../../tracked-links/learn/explore-clicks.md
[7]: ../../tracked-links/learn/index.md
[5]: https://www.superoffice.co.uk/resources/articles/integrated-web-forms/

<!-- Referenced images -->