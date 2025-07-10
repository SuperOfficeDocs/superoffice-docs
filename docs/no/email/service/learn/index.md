---
uid: help-no-email-service
title: Service-e-poster
description: Service-e-poster
author: SuperOffice Product and Engineering
keywords: e-postkasse
date: 07.10.2025
version: 10.5
content_type: concept
category: service
topic: email
functional_right:
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: no
redirect_from:
  - /no/email/service/learn/index
  - /no/email/service/learn/screen/tab-inbox-for-email
  - /no/email/service/learn/screen/tab-outbox-for-email
  - /no/email/service/learn/screen/tab-blocked-email
  - /no/email/service/learn/screen/sms-inbox
  - /no/email/service/learn/screen/sms-outbox
---

# Service-e-poster

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

I **E-post**-skjermbildet kontrollerer du mekanismene som håndterer innkommende og utgående e-post . E-poster importeres av SuperOffice Service som regelmessig samler inn e-post fra en eller flere e-postkasser. Disse e-postmeldingene kan skannes av e-postfiltre som behandler e-postmeldinger basert på innhold og genererer saker. Utgående e-post (svar) fra systemet plasseres i utboksen og sendes regelmessig til en e-postserver som videresender meldingene. Importerte e-postmeldinger som er blokkert (av et filter), vises i fanen**Blokkert e-post** og må gjennomgås manuelt.

## E-postkasser

I fanen **E-postkasser** finner du en oversikt over de installerte e-postkassene. Denne listen inneholder følgende kolonner:

* **Adresse**: E-postkassens avsenderadresse.
* **Kategori**: Saker fra e-postkassen tilordnes til denne kategorien.
* **Prioritet**: Prioriteten som nye saker tilordnes når de registreres fra denne e-postkassen.
* **Videresendingsadresse**: Hvis du ikke bruker e-postfunksjonene i SuperOffice, videresendes e-poster til denne adressen.
* **Protokoll**: Protokollen som e-postkassen bruker.

### <a id="email-in"></a>Innboks for e-post

I fanen **Innboks for e-post** finner du en liste over e-postene i køen som skal leses inn. Følgende alternativer er også tilgjengelige fra knappen <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Eksporter**: Brukes til å eksportere listen til en fil. Du velge mellom disse formatene: Excel, HTML og ren tekst.

* **Slett**: Brukes til å slette de valgte e-postene.

    > [!NOTE]
    > Du kan ikke angre denne operasjonen.

Hvis du klikker en av meldingene i denne fanen, vises skjermbildet **Innkommende e-post** . Her finner du informasjon om den aktuelle meldingen. I feltet **Siste feilmelding** kan du se hva som forårsaket problemet, for eksempel om det er et problem med e-postadressen eller e-postserveren. Hvis du får en feilmelding fra SuperOffice Service, kan du klikke på **Importer med feilsøking** for å vise teknisk informasjon for å hjelpe brukerstøtten med feilsøking.

### <a id="email-out"></a>Utboks for e-post

I fanen **Utboks for e-post** er en liste over e-postene i køen som skal sendes ut.

Velg **Vis sendte e-postmeldinger** i nedre høyre hjørne for å vise også de siste e-postmeldingene.

Følgende alternativer er også tilgjengelige fra knappen <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Eksporter**: Brukes til å eksportere listen til en fil. Du velge mellom disse formatene: Excel, HTML og ren tekst.

* **Send**: Brukes til å sende de valgte e-postene på nytt bare hvis det var en feil med den automatiske utsendelsen.

* **Slett**: Brukes til å slette de valgte e-postene.

    > [!NOTE]
    > Du kan ikke angre denne operasjonen.

Hvis du klikker på en av meldingene i denne fanen, vises skjermbildet **Utgående e-post**. Her finner du informasjon om den aktuelle meldingen, f.eks. størrelse og hvem som opprettet den. Eventuelle feilmeldinger vises også.

### <a id="email-blocked"></a>Blokkert e-post

I fanen **Blokkert e-post** finner du en liste over innkommende e-poster blokkert av et e-postfilter. Klikk på en e-post for å vise innholdet. Hvis det ikke er nok plass til alle e-postene på én side, kan du klikke <i class="ph ph-arrow-right" aria-label="Arrow right"></i> for å navigere til neste side. Denne listen inneholder følgende kolonner:

* **Når**: Angir når e-posten ble blokkert.
* **E-postkasse**: Angir hvilken e-postkasse som importerte e-posten.
* **E-postfilter**: Angir hvilket e-postfilter som blokkerte e-posten.
* **E-postoverskrift**: Viser overskriften for meldingen.

Følgende alternativer er også tilgjengelige fra <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Eksporter**: Brukes til å eksportere listen til en fil. Du velge mellom disse formatene: Excel, HTML og ren tekst.
* **Importer**: Brukes til å importere de valgte e-postene. E-postfilteret som blokkerte e-posten, blir deretter ignorert, men andre e-postfiltre kan være aktivert.
* **Slett**: Brukes til å slette de valgte blokkerte e-postene.

### <a id="sms-in"></a>Innboks for SMS

> [!NOTE]
> Hvis denne fanen ikke er synlig, betyr dette at du ikke har SMS-modulen installert eller at SMS ikke er aktivert for lisensen du bruker. Ta kontakt med systemansvarlig hvis du ønsker mer informasjon.

**I SMS-innboks**-fanen er en liste over SMS-meldingene i køen som skal leses inn. Følgende alternativer er også tilgjengelige fra menyknappen:

* **Eksporter**: Brukes til å eksportere listen til en fil. Du velge mellom disse formatene: Excel, HTML og ren tekst.

* **Slett**: Brukes til å slette de valgte meldingene.

    > [!NOTE]
    > Du kan ikke angre denne operasjonen.

Klikk på en av meldingene i denne fanen for å vise informasjon om den valgte meldingen.

### <a id="sms-out"></a>Utboks for SMS

Fanen **Utboks for SMS** inneholder alle utgående SMS-er som ennå ikke er blitt sendt, eller som har forårsaket en feil.

> [!NOTE]
> Hvis denne fanen ikke er synlig, betyr dette at du ikke har SMS-modulen installert eller at SMS ikke er aktivert for lisensen du bruker. Ta kontakt med systemansvarlig hvis du ønsker mer informasjon.

Følgende alternativer er også tilgjengelige fra menyknappen:

* **Eksporter**: Brukes til å eksportere listen til en fil. Du velge mellom disse formatene: Excel, HTML og ren tekst.

* **Send**: Brukes til å sende de valgte meldingene på nytt bare hvis det var en feil med den automatiske utsendelsen.

* **Slett**: Brukes til å slette de valgte meldingene.

    > [!NOTE]
    > Du kan ikke angre denne operasjonen.

Hvis du klikker på en av meldingene i denne fanen, vil **Utgående SMS** vises. Her finner du informasjon om den aktuelle meldingen, f.eks. størrelse og hvem som opprettet den. Eventuelle feilmeldinger vises også.

## Relatert innhold

* [Opprette e-postkasser][1]
* [Slette e-postkasser][2]
* [E-postfiltre][3]

<!-- Referenced links -->
[1]: create-mailbox.md
[2]: delete-mailbox.md
[3]: email-filters/index.md

<!-- Referenced images -->
