---
uid: help-no-mass-delete
title: Masseslette poster (permanent)
description: "I tråd med GDPR-kravene må du ha hjemmel for å lagre dataene til alle personene dine. Og når du ikke lenger har hjemmel for å gjøre det, må du fjerne dataene deres fra alle systemene dine."
author: Bergfrid Dias
date: 02.15.2023
keywords: utvalg, GDPR
topic: howto
language: no
---

# Masseslette poster (permanent)

I tråd med GDPR-kravene må du ha hjemmel for å lagre dataene til alle personene dine. Og når du ikke lenger har hjemmel for å gjøre det, må du fjerne dataene deres fra alle systemene dine.

Dette betyr at du ikke har lov til å lagre en persons informasjon for alltid. Som firma må du tenke på og kunne rettferdiggjøre – hvor lenge du vil beholde personopplysninger før du sletter eller gjennomgår dataene du lagrer.

Hvis du vil slette flere poster (personer, firmaer, salg, prosjekter og så videre), kan du opprette et utvalg av disse postene og slette dem i én operasjon.

> [!NOTE]
> Denne oppgaven er bare tilgjengelig for brukere med administratortilgang. Det er også en oppgave du bør tenke nøye på før du utfører, fordi den sletter alle valgte poster permanent, både fra utvalgskjermbildet og fra SuperOffice-databasen.

## Bestemme hvilke og når personopplysninger må slettes

Hvor lenge du kan beholde data avhenger av en rekke ting som er spesifikke for ditt firma og er blant de tingene du definerer som en del av personvernstrategien din.

Du kan for eksempel bestemme at du kan rettferdiggjøre lagring av personopplysninger om potensielle kunder i tre år, og personopplysningene til tapte kunder i fem år, eller noe lignende.

Kanskje du bestemmer at lagringstiden for personopplysninger vil være lenger for personer som samtykket til å motta markedsføringsinformasjon og for tapte kunder som fortsetter å stille supportspørsmål til firmaet.

Alle disse betingelsene og vilkårene må du tydeliggjøre og definere som en del av GDPR-strategien din. Det anbefales å søke juridisk rådgivning i slike saker for å sikre overholdelse.

Når du har fastslått hvilke regler som gjelder for firmaet ditt, kan du bruke utvalgsfunksjonaliteten og [SAINT-funksjonen][2] i SuperOffice CRM til å finne personene som skal slettes, og deretter masseslette alle personer du ikke vil beholde i systemet lenger.

## Finne personer som bør slettes eller gjennomgås med Utvalg

Utvalg er et verktøy for å finne data i CRM-databasen som passer til et bestemt sett med kriterier.

Hvis du sletter alle personer i en bestemt kundekategori, og som du ikke har vært i kontakt med i en viss periode, kan du holde databasen oppdatert.

Du kan for eksempel opprette utvalg av alle personer som er definert som:

* Potensielle kunder
* Registrert før en bestemt dato
* Som ikke har eksplisitte samtykker dokumentert
* Som ikke har hatt noen interaksjon med firmaet ditt i en gitt periode

Du kan søke etter og finne personer som oppfyller flere kriterier, eller du kan opprette flere utvalg og deretter søke etter dataene som er felles eller forskjellige, ved å opprette et kombinasjonsutvalg.

Utvalg er et veldig fleksibelt og kraftig verktøy, når du vet hvordan du bruker det.

## Bruk SuperOffice SAINT til å gå gjennom kontaktpersonene dine

Du kan også bruke SAINT som hjelp for å identifisere mulige personer som må slettes.

SAINT står for "SAles INTelligence" og fungerer ved å legge til noen smarte algoritmer til CRM-dataene dine.

Sagt på en enkel måte overvåker SuperOffice SAINT dataene du har lagret i CRM-løsningen, og varsler deg om ulike statuser eller handlingssaker du har definert som viktige. Dette kan være alt fra handlinger som ennå ikke har skjedd på et gitt tidspunkt, til verdier som er oppfylt eller ikke oppfylt, og som du ønsker å bli varslet om, slik at du kan utføre nødvendige handlinger.

SAINT kan også brukes til å overvåke kontaktinformasjon.

Dette betyr at du for eksempel kan bruke SAINT til å identifisere personer du ikke har hatt kontakt med i det hele tatt i en gitt periode. Da får du en liste over personer som du kanskje vil fjerne fra CRM-databasen eller behandle på en bestemt måte, basert på firmaets GDPR-policyer.

Her er mer informasjon om [hvordan du konfigurere et SAINT-utvalg][3].

Hvis SAINT er helt nytt for deg, kan det være nyttig å bruke en SuperOffice CRM-ekspert til å hjelpe deg med å komme i gang. Din lokale SuperOffice-kontakt kan hjelpe deg med dette.

## Masseredigering eller sletting av personer

Når du har opprettet en liste over alle personer som enten må oppdateres eller slettes, er det på tide å faktisk utføre de ønskede endringene.

For å utføre en masseredigering av for eksempel hjemmel eller lignende, velg [masseredigering][5] fra utvalgets **Oppgave**fane.

Hvis du vil masseslette personer fra et utvalg, kan du velge funksjonen **Slett alle personer** fra **Oppgave**-knappen nederst til høyre på hovedskjermbildet.

![Fra Oppgave-knappen på utvalgskjermen kan du masseslette firmaer og personer -screenshot][img2]

[!include[Open Selections](../includes/goto-selections.md)]

1. Gå til et utvalg. For eksempel [bruk Finn-skjermbildet][1].

1. Hvis du bare vil slette noen av medlemmene i utvalget, merker du dem av i medlemslisten.

1. Klikk på **Oppgave**-knappen og velg **Slett alle**.

    ![På utvalget klikker du på Oppgave-knappen og velger en av de ønskede Slett-funksjonene -screenshot][img1]

1. Når du blir spurt om du vil slette postene, klikker du på **Ja**.

1. Når du blir spurt om du virkelig vil slette postene fra databasen, klikker du på **Ja**.

[!include[Note about restore](../../../../learn/includes/note-restore.md)]

## Hva om du sletter personer med et uhell?

Det kan noen ganger være vanskelig å slette personer. Hvis en person eller et firma slettes ved en feiltakelse, kan du angre det ved hjelp av [Papirkurv][4].

Selv om en slettet person eller firma umiddelbart skjules for alle brukere, er de fortsatt tilgjengelige i papirkurven i opptil 14 dager, herfra kan du gjenopprette et firma eller en person som ble slettet ved en feiltakelse.

Du finner papirkurven i menyen Personlige preferanser. Du kan se alle personene du har slettet, men også alle personene som ble slettet av andre brukere.

![Du kan gjenopprette elementer du har slettet ved å åpne papirkurven i menyen Personlige innstillinger -screenshot][img3]

<!-- Referenced links -->
[1]: ../../../learn/find-screen.md
[2]: https://community.superoffice.com/no/learning/best-practices-tips/standard-crm/saint-proactive-customer-follow-up/
[3]: ../dynamic-selections.md#saint
[4]: ../../../../learn/basics/deleting-elements.md#restore
[5]: bulk-update.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/search-options/company-selection-task-delete.png
[img2]: ../../../../../media/loc/en/search-options/company-selection-task-delete.png
[img3]: ../../../../../media/loc/en/learn/recycle-bin-personal-settings.png
