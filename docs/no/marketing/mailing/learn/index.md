---
uid: help-no-mailing
title: Arbeide med utsendelser
description: Arbeide med utsendelser
keywords: Markedsføring, utsendelse
author: SuperOffice RnD, Jeanette Small Strøm
date: 02.12.2024
version: 10
topic: concept
language: no
audience: person
audience_tooltip: SuperOffice Marketing
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

## Betydningen av e-postlevering

E-postmarkedsføring er en kostnadseffektiv markedsføringsstrategi som kan resultere i [høy avkastning på investering][20]. Men for å få mest mulig ut av dette markedsføringsverktøyet, må e-postene dine komme frem til målgruppens innboks, ikke deres SPAM-mappe.

Forestille deg dette scenariet: du har nøye laget en e-postkampanje med førsteklasses innhold og design, trykket på send-knappen, og mottar lite til ingen respons. Åpningsraten din er skuffende og det er mange bounces, eller enda verre, du blir merket som spam.

**E-postlevering** er en stor sak fordi det bestemmer om e-postene dine faktisk kommer til abonnentenes innbokser eller ikke. Hvis de ikke blir levert, vil de ikke bli sett eller lest av målgruppen din, noe som betyr tapte sjanser og lavere suksess for e-postmarkedsføringskampanjene dine. Sjekk ut våre [beste praksiser][9].

## <a id="after"></a>Hvordan kan jeg følge opp utsendelsen?

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
[6]: ../../editor/learn/add-unsubscribe-link.md
[9]: ../../learn/best-practices.md
[8]: ../../recipients/learn/index.md
[11]: ../../recipients/learn/look-at-recipient-list.md
[12]: ../../recipients/learn/look-at-recipient-list.md#add-recipients
[13]: ../../recipients/learn/manage-bounces.md
[14]: ../../tracked-links/learn/explore-clicks.md
[7]: ../../tracked-links/learn/index.md
[5]: https://www.superoffice.co.uk/resources/articles/integrated-web-forms/
[20]: https://www.superoffice.com/blog/email-marketing-strategy/

<!-- Referenced images -->