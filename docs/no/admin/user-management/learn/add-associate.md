---
uid: help-no-user-add
title: Legge til bruker
description: I denne guiden lærer du hvordan du legger til en ny bruker i SuperOffice CRM.
author: SuperOffice RnD
date: 02.21.2023
keywords: bruker, medarbeider
topic: howto
audience: settings
audience_tooltip: Settings and maintenance

language: no
---

# Legge til brukere

Når SuperOffice CRM-løsningen er konfigurert og tilpasset, er det på tide å gi brukerne tilgang til CRM-løsningen.

Administratorer har ansvaret for å gi nye brukere en brukerplan, et brukernavn, et passord og brukergruppen brukeren tilhører. Du kan legge til brukere i SuperOffice CRM i Innstillinger og vedlikehold.

> [!NOTE]
> Hvis du oppga informasjon om brukerne da du bestilte SuperOffice CRM, trenger du ikke å legge til brukere. Brukerne skal ha fått påloggingsinformasjon fra SuperOffice via e-post. Kontroller om brukerne er i systemet ved hjelp av menyen Brukere i Innstillinger og vedlikehold.
>
> Denne prosedyren beskriver hvordan du legger til én bruker om gangen. Hvis du vil legge til flere brukere, kan du se [Importere brukere][1].

Følg trinnene eller se videoen nedenfor for å se hvordan du legger til en ny bruker i SuperOffice CRM (videolengde – 1.46):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/oLlfTrCAqCU]

## Legge til en ny SuperOffice CRM-bruker

1. Åpne skjermbildet Brukere.
2. Velg fanen **Medarbeidere**.
3. Klikk på **Legg til**-knappen under listen.
4. Skriv inn navnet og e-postadressen til den nye brukeren øverst på kortet.
5. Hvis mer enn ett eierfirma er tilgjengelig i SuperOffice-installasjonen, kan du velge dette under feltet **E-post**.
6. Skriv inn relevant informasjon i fanene **Detaljer** og **Lisenser**.

    ![Create user details -screenshot][img7]

7. Klikk på **Lagre**. Navnet på den nye brukeren vises nå i listen.

> [!TIP]
> Hvis aktive brukere trenger en annen brukerplan, kan du [tilordne brukerplaner][4] i Innstillinger og vedlikehold.

## Fanen Detaljer

I fanen **Detaljer** finner du følgende alternativer:

* **Bruker-ID**: I feltet **Bruker-ID** redigerer du den foreslåtte IDen for brukeren (hvis du ikke vil bruke den automatisk genererte IDen). Du kan ikke angi en bruker-ID som allerede finnes i databasen. Det er ingen begrensninger på hvilke tegn som kan brukes i bruker-IDen.

    > [!NOTE]
    > Bruker-ID-en bør ikke inneholde for mange tegn, siden den vises i ID-kolonnene i SuperOffice CRM, og plassen i disse kolonnene kan være begrenset.

* **Kallenavn**: Kallenavnet er navnet som er synlig for andre brukere av SuperOffice, og det brukes bare for SuperOffice Service-brukere. Du kan redigere det foreslåtte kallenavnet for brukeren (hvis du ikke vil bruke det automatisk genererte navnet).

* **Autentisering**: Hvis det finnes flere tilgjengelige autentiseringsmåter, kan du velge en her.

* **Brukernavn**: Skriv inn SuperOffice-brukernavnet. Dette bør være det samme navnet som i identitetsleverandørens system (hvis du bruker Office 365 eller Gmail til autentisering). Når du bruker SuperOffice til autentisering, fyller du bare inn e-postadressen din. Kontroller at e-postadressen er gyldig, siden den brukes til kontobekreftelse.

* **Rolle**: I listeboksen **Rolle** velger du hvilken [rolle][3] brukeren skal ha. Rollen bestemmer datatilgang og funksjonelle rettigheter for brukeren. Du kan ikke endre din egen rolle.

* **Brukerplan**: Velg den aktuelle brukerplanen for brukeren. Dette bestemmer hvilke SuperOffice-funksjoner brukeren kan få tilgang til.

* **Sluttet**: Hvis en bruker ikke lenger skal ha tilgang til SuperOffice, velger du dette alternativet for å fjerne brukerplanen og påloggingsrettighetene til brukeren.

* **Primærgruppe**: I listeboksen **Primærgruppe** velger du et av de forhåndsdefinerte alternativene for gruppetilhørighet. Gruppene defineres i **Lister**-bildet. Brukeren får tilgang til data som eies av andre brukere i samme primærgruppe. Tilgangsrettighetene (for eksempel skrive- og slettetilgang) for disse dataene er definert i den [rollen][3] brukeren tilhører. Se [Synlighet][2] hvis du vil ha mer informasjon om hvordan du deler data med primærgruppen din.

* **Andre grupper**: Klikk i feltet **Andre grupper**, og velg hvilke andre grupper brukeren skal tilhøre. Hvis listen inneholder mange grupper, begynner du å skrive inn et gruppenavn i søkefeltet for å filtrere listen.

* **SuperOffice Service-kategorier**: Disse kategoriene brukes til å gi brukerne tilgang til bestemte sakskategorier.

* **Service-kategorier fra brukergrupper**: Viser kategoriene brukeren får ved å være i en brukergruppe.

### Eksempel

[!include[Example](includes/example-grouping.md)]

## Lisenser-fanen

I **Lisenser**-fanen kan du velge lisenser i tillegg til de som er definert av den valgte brukerplanen.

**Confidential activities**: Aktiverer listen **Synlig for** for oppfølginger, dokumenter og salg, slik at [oppføringer blir synlige bare for][2] brukeren, brukerens primærgruppe eller alle.

## Kan logge inn

I den nedre delen av brukerkortet kan du aktivere eller deaktivere påloggingsrettighetene til den valgte brukeren ved å klikke på knappen **Kan logge inn**. Som standard aktiveres dette alternativet når du velger en brukerplan for brukeren.

## Rediger bruker/medarbeider

1. [!include[Click Users](includes/goto-users.md)]
2. Velg fanen **Medarbeidere**.
3. Merk ønsket bruker i oversikten over brukere.
4. Gjør endringene, og klikk deretter på **Lagre**.

## Relatert

* [Legge til anonym bruker eller systembruker (onsite)][5]

<!-- Referenced links -->
[1]: import-users.md
[2]: visibility.md
[3]: role/index.md
[4]: change-user-plan.md
[5]: other-users.md

<!-- Referenced images -->
[img7]: ../../../../media/loc/en/admin/selected-user-plan.png
