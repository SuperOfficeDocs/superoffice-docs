---
uid: help-no-mailing-manage-subscriptions
title: Administrere e-postabonnementer
description: Med funksjonene for abonnementshåndtering i SuperOffice CRM kan du dokumentere hva slags innhold personene dine ønsker å motta fra deg.
keywords: markedsføring
author: Bergfrid Dias
date: 02.09.2024
version: 10
topic: concept
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Administrere e-postabonnementer

SuperOffice CRMs funksjonre for abonnementshåndteringr gir kontaktene dine muligheten til å spesifisere innholdet de ønsker å motta. Dette er knyttet til Samtykkehåndtering, da noen jurisdiksjoner krever dokumentert samtykke før e-markedsføringsmeldinger kan sendes.

Disse funksjonene forhindrer sending av e-markedsføringsmeldinger til de som ikke har samtykket, og sikrer at kontaktene dine beholder kontrollen over e-postsabonnementene sine. Fra det øyeblikket de legges til i SuperOffice-databasen din, kan kontaktene spesifisere sine e-postpreferanser. De kan også justere disse preferansene via avmeldingslenken i hver e-post.

Ved å gi kundene muligheten til å administrere abonnementene sine, kan du øke åpningsfrekvensen for e-postene dine og øke markedsføringssuksessen din.

## Interesser i SuperOffice CRM

Du kan registrere interesser (for eksempel "Månedlig nyhetsbrev") på personene. I stedet for å bruke avmelding kan du enkelt ved å lage en [kobling som fjerner den aktuelle interessen][5] hos  kunder som ikke ønsker å motta det. Samme metode kan brukes til å registrere interesser.

## Mållisten din

Når du [oppretter mållisten][1] for neste utsendelse, kan du gjøre et valg basert på abonnementstypen du skal bruke. Da vil SuperOffice CRM bare legge til personer som har sagt "ja" til denne typen abonnement.

## Velg abonnementstype

Det er flere måter å opprette mållisten på ved hjelp av et utvalg. Det betyr at du kanskje ikke alltid bruker en abonnementstype som utvalgskriterium. Når du gjør dette, er det lett å miste det faktum av syne at du har lagt folk som sa "nei" til å motta utsendelser, til mållisten din.

For å hindre at du sender utsendelser til personer som ikke ønsker å motta dem, vil veiviseren for utsendelser be deg om å legge til abonnementstypen du ønsker å sende i Trinn 1: Oppsett.

![Velg hvilken type utsendelse du sender ut i oppsettstrinnet. -screenshot][img1]

Når du har lagt til utsendelsestypen, kontrollerer SuperOffice CRM hver person du legger til som mottaker, for å se om de har gitt deg samtykke til å sende dem denne utsendelsen.

I trinn 4 i veiviseren for utsendelser, kalt Mottakere, kan du se nøyaktig hvem som har, og hvem som ikke har gitt deg samtykke. Når funksjonen Personvern for e-markedsføring er slått på, filtrerer SuperOffice CRM automatisk ut alle mottakere som ikke har meldt seg på, basert på samtykke til e-markedsføring og aktive abonnementer.

> [!TIP]
> Du har en avmerkingsboks for Overstyr samtykke og abonnement hvis det er svært viktig å sende utsendelsen til alle personer.

![Når du har lagt til mottakere på adresselisten, kan du sende uansett om de har gitt samtykke til den type utsendelse eller ikke. -screenshot][img2]

Hvis Personvern for e-markedsføring er slått AV, betyr det at SuperOffice CRM ignorerer samtykker og abonnementspreferanser når det sender utsendelsene dine. Hvis du vil aktivere Personvern for e-markedsføring, trenger du administratorrettigheter.

Du får vite med ved å se på videoen om hvordan du konfigurerer personverninnstillingene for GDPR i SuperOffice CRM.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/1e0ZIUwX3IY?list=PL9fefjwA0X290ZZ8bMUHWh_d6s3Y2P0Jr]

![I Innstillinger og vedlikehold kan du slå på funksjonen Personvern for e-markedsføring. -screenshot][img3]

## Bruk koblingen for avmelding

Noen ganger ombestemmer folk seg når det gjelder hvilke e-postmeldinger de ønsker å motta. Når dette skjer, bør de ha muligheten til å velge bort den typen utsendelse du har sendt dem. Derfor leveres alle SuperOffice CRM-e-postmaler med en avmeldingskobling.

> [!TIP]
> Hvis du vil sende e-postmeldingen for Administrere abonnement til en person, kan du se [Sende e-post om personvern][3].

Ved å klikke på denne koblingen kommer mottakerne til siden for abonnementsinnstillinger, der de kan velge hvilken type utsendelser de vil motta. Endringene personene dine gjør, lagres så snart de bekrefter de nye innstillingene.

![Velg utsendelsene du ønsker å motta, på siden for abonnementspreferanser. -screenshot][img4]

Kunden din har kontroll over utsendelsene de mottar, og du kan sikre at du bare sender utsendelsene dine til dem som er interessert.

Med SuperOffice CRM respekterer du personenes kommunikasjonspreferanser og sikrer at du overholder reglene i GDPR. Dermed vil du aldri risikere å få en bot på 20 000 000 euro.

## Relatert

* [GDPR og personvern][2]
* [Personvernerklæring for SuperOffice][4]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../security/privacy/learn/index.md
[3]: ../../../security/privacy/learn/send-privacy-confirmation-email.md
[4]: https://www.superoffice.com/company/privacy/
[5]: ../../tracked-links/learn/define-link-actions.md#interests

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/setup-type-drop-down.png
[img2]: ../../../../media/loc/en/marketing/recipients-content-status.png
[img3]: ../../../../media/loc/en/marketing/e-marketing-privacy-feature.png
[img4]: ../../../../media/loc/en/marketing/subscription-preferences-page.png
