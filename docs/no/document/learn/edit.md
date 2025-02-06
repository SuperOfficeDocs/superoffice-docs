---
uid: help-no-document-update
title: Redigere dokument
description: Redigere dokument
keywords: dokument
author: Bergfrid Dias
date: 10.08.2024
version: 10.3.10
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Redigere dokument

Redigering av dokumenter omfatter to ting:

* Redigering av dokumentegenskapene i skjermbildet Dokument.
* Redigering av selve dokumentfilen i programmet dokumentet ble opprettet i.

Du kan åpne et dokument i [redigeringsmodus eller i lesemodus][1]. Når du åpner dokumentet i redigeringsmodus, er det bare du som kan redigere det. Andre brukere kan åpne dokumentet i lesemodus. Hvis organisasjonen bruker et dokumentbibliotek som SharePoint, kan flere personer redigere et dokument samtidig.

## Redigere dokumentegenskaper i dialogboksen Dokument

**Denne funksjonen krever en lisens.**

Hvis du vil endre dokumentegenskaper, for eksempel prosjektet som dokumentet er knyttet til, bruker du dialogboksen Dokument:

1. Velg ønsket dokument.

2. Høyreklikk og velg **Dokument**. Hvis du dobbeltklikker på dokumentet, åpnes det direkte i det programmet det ble opprettet i.

3. [Gjør de nødvendige endringene][3].

4. Klikk på **Lagre**-knappen.

> [!NOTE]
> Du kan ikke redigere fullførte dokumenter før du har deaktivert **Utført**-statusen.

## Redigere dokumentinnhold

Følg instruksjonene nedenfor, avhengig av hvordan dokumenter håndteres i SuperOffice-installasjonen.

<!-- markdownlint-disable-file MD051 -->
### [Med SuperOffice WebTools](#tab/webtools)

1. Dobbeltklikk på det nødvendige dokumentet.

1. Hvis en dialogboks åpnes, klikker du på **Rediger**.

1. Gjør de nødvendige endringene.

1. Lagre dokumentet, og lukk tekstbehandlingsprogrammet.

1. (hvis det er aktuelt) I dialogboksen som vises, klikker du på **Ja** hvis du er ferdig med å redigere dokumentet. Klikk på **Nei** for å beholde dokumentet utsjekket.

    Denne dialogboksen vises bare hvis dette alternativet ble aktivert i SuperOffice WebTools.

1. Dokumentet sjekkes inn, og statusen settes til **Utført**.

### [Med SharePoint](#tab/sharepoint)

1. Dobbeltklikk på det nødvendige dokumentet. Dokumentet åpnes i en ny fane med det elektroniske tekstredigeringsprogrammet (Office Online).

    Hvis du vil bruke skrivebordsprogrammet for å redigere, kan du velge **Åpne i skrivebordsprogrammet** fra Office Online.

2. Rediger dokumentet.

3. Lukk fanen eller skrivebordsprogrammet. Dokumentet lagres automatisk i SharePoint.

### [Uten SuperOffice WebTools](#tab/no-webtools)

> [!NOTE]
> Denne fremgangsmåten beskriver hvordan du oppretter nye dokumenter hvis du bruker et skrivebordsprogram for tekstredigering. Selve prosessen kan være litt annerledes hvis du bruker et tekstbehandlingsprogram tilgjengelig på Internett (for eksempel Microsoft Office Online) og et dokumentbibliotek (for eksempel SharePoint).

1. Dobbeltklikk på det nødvendige dokumentet.

2. I dialogboksen **Dokument** klikker du på **Åpne**.

3. Hvis en dialogboks åpnes, klikker du på **Rediger**.

4. I dialogboksen **Filnedlasting** velger du **Åpne** eller **Lagre**. Deretter følger du trinn 5-9 fra prosedyren [opprett dokument uten WebTools][2].

***

### <a id="allow"></a>Nettlesersikkerhetsspørsmål ved åpning av filer

Når du får tilgang til og redigerer et dokument, fil eller e-post i SuperOffice, gir nettleseren din deg en *sikkerhetsspørsmål* angående nedlasting av filen.

* For å åpne filen må du velge knappen **Åpne**/**Tillat**.
* Velg **Alltid tillat** for å hoppe over spørsmålet neste gang.

Dialogboksen er litt annerledes i Chrome, Edge, Firefox og Safari.

**Chrome:** Velg **Åpne URL:SuperOffice-Extensions**.

![Chrome: Åpne URL:SuperOffice-Extensions knapp -screenshot][img5]

**Edge:** Velg **Åpne**.

![Edge: Åpne knapp -screenshot][img2]

**Firefox:** Velg **Åpne lenke**.

![Firefox: Åpne lenke knapp -screenshot][img3]

**Safari:** Velg **Alltid tillat** eller **Tillat**.

![Safari: Alltid tillat eller Tillat knapp -screenshot][img4]

## <a id="delete"></a>Slette dokumenter

### Fra aktivitetsfanen

1. Velg ønsket dokument i detaljkortet **Aktiviteter** på skjermbildene firma, person, dagbok, salg eller prosjekt.

2. Høyreklikk og velg **Slett**.

3. Bekreft eller avbryt slettingen i bekreftelsesdialogen.

### Fra dokumentdialogen

Når du ser et spesifikt dokument:

1. Klikk på **Oppgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) i **Dokument**-dialogen.
2. Velg **Slett**.
3. Bekreft eller avbryt slettingen i bekreftelsesdialogen.

## Feilsøking

Hvis du dobbeltklikker på et dokument og ingenting skjer, kan du prøve å høyreklikke på det og velge **Dokument**. Dette åpner dialogboksen **Dokument** . Klikk på **Åpne** og se om dokumentet åpnes nå.

### Hvordan vet jeg om jeg bruker SharePoint, SuperOffice WebTools eller ikke?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Aktuelle emner

* [Slik endrer du Fullført-statusen for en aktivitet][4]

<!-- Referenced links -->
[1]: lock.md
[2]: create.md
[3]: create.md#fields
[4]: ../../diary/learn/change-completed-status.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/webtools/webtools-edge-security-question.png
[img3]: ../../../media/loc/en/webtools/webtools-firefox-security-question.png
[img4]: ../../../media/loc/en/webtools/webtools-safari-security-question.png
[img5]: ../../../media/loc/en/webtools/webtools-chrome-security-question.png
