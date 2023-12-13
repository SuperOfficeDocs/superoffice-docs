---
uid: help-no-document-update
title: Redigere dokumenter
description: Redigere dokumenter
author: SuperOffice RnD
so.date: 12.06.2023
keywords: dokument
so.topic: howto
language: no
---

# Redigere dokumenter

Redigering av dokumenter omfatter to ting:

* Redigering av dokumentegenskapene i skjermbildet Dokument.
* Redigering av selve dokumentfilen i programmet dokumentet ble opprettet i.

Du kan åpne et dokument i [redigeringsmodus eller i lesemodus][1]. Når du åpner dokumentet i redigeringsmodus, er det bare du som kan redigere det. Andre brukere kan åpne dokumentet i lesemodus.

Hvis organisasjonen bruker et dokumentbibliotek som SharePoint, kan flere personer redigere et dokument samtidig.

> [!NOTE]
> Denne funksjonen krever en lisens.

Følg instruksjonene nedenfor, avhengig av hvordan dokumenter håndteres i SuperOffice-installasjonen:

## Hvordan vet jeg om jeg bruker SharePoint, SuperOffice WebTools eller ikke?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Redigere dokumentegenskaper i skjermbildet Dokument

Hvis du vil endre dokumentegenskaper, for eksempel prosjektet som dokumentet er knyttet til, bruker du skjermbildet Dokument:

1. [Velg ønsket dokument][2].
2. Høyreklikk og velg **Dokument**. Hvis du dobbeltklikker på dokumentet, åpnes det direkte i det programmet det ble opprettet i.
3. [Gjør de nødvendige endringene][3].
4. Klikk på **Lagre**-knappen.

## Redigere dokumentinnhold ved hjelp av SharePoint Documents

1. [Dobbeltklikk på det nødvendige dokumentet][2]. Dokumentet åpnes i en ny fane med det elektroniske tekstredigeringsprogrammet (Office Online).

    > [!NOTE]
    > Hvis du vil bruke skrivebordsprogrammet for å redigere, kan du velge **Åpne i skrivebordsprogrammet** fra Office Online.

2. Rediger dokumentet.

3. Lukk fanen eller skrivebordsprogrammet. Dokumentet lagres automatisk i SharePoint

## Redigere dokumentinnhold – uten SuperOffice WebTools

> [!NOTE]
> Denne fremgangsmåten beskriver hvordan du oppretter nye dokumenter hvis du bruker et skrivebordsprogram for tekstredigering. Selve prosessen kan være litt annerledes hvis du bruker et tekstbehandlingsprogram tilgjengelig på Internett (for eksempel Microsoft Office Online) og et dokumentbibliotek (for eksempel SharePoint).

1. [Dobbeltklikk på det nødvendige dokumentet][2].
2. I dialogboksen **Dokument** klikker du på **Åpne**.
3. Hvis en dialogboks åpnes, klikker du på **Rediger**.
4. I dialogboksen for filnedlasting velger du ett av følgende alternativer:
    * **Åpne**: Når du velger alternativet for å åpne, åpnes dokumentet i tekstbehandlingsprogrammet. Skriv inn ønsket innhold i dokumentet, og velg **Fil** > **Lagre som** for å lagre det på ønsket sted på PCen.
    * **Lagre**: Når du velger alternativet for å lagre, vises dialogboksen **Lagre som**. Angi hvor på PCen du vil lagre filen, og lagre den. Deretter åpner du dokumentet, skriver inn ønsket innhold og lagrer det.
5. Lukk tekstbehandlingsprogrammet.
6. Gå til dialogboksen **Dokument**.

    > [!NOTE]
    > Hvis **Fullført** er valgt i **Dokument**-dialogboksen, er  opplastingsalternativene er deaktivert. Fjern i så fall avmerkingen for **Utført**.

7. Klikk på koblingen for å laste opp dokumentet, eller dra og slipp dokumentet fra Windows Utforsker til dialogboksen **Dokument**.

    ![Opprette nytt dokument -screenshot][img1]

8. Lukk dialogboksen **Dokument** ved å klikke på **Lagre**. Dokumentet sjekkes inn, og statusen settes til **Utført**.

## Redigere dokumentinnhold – ved hjelp av SuperOffice WebTools

1. [Dobbeltklikk på det nødvendige dokumentet][2].
2. Hvis en dialogboks åpnes, klikker du på **Rediger**.
3. Lagre dokumentet, og lukk tekstbehandlingsprogrammet.
4. (hvis det er aktuelt) I dialogboksen som vises, klikker du på **Ja** hvis du er ferdig med å redigere dokumentet. Klikk på **Nei** for å beholde dokumentet utsjekket.

    Denne dialogboksen vises bare hvis dette alternativet ble aktivert i SuperOffice WebTools.

5. Dokumentet sjekkes inn, og statusen settes til **Utført**.

### <a id="allow" />Nettlesersikkerhetsspørsmål ved åpning av filer

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

## Feilsøking

Hvis du dobbeltklikker på et dokument og ingenting skjer, kan du prøve å høyreklikke på det og velge **Dokument**. Dette åpner dialogboksen **Dokument** . Klikk på **Åpne** og se om dokumentet åpnes nå.

<!-- Referenced links -->
[1]: lock.md
[2]: open.md
[3]: screen/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/document/upload.png
[img2]: ../../../media/loc/en/webtools/webtools-edge-security-question.png
[img3]: ../../../media/loc/en/webtools/webtools-firefox-security-question.png
[img4]: ../../../media/loc/en/webtools/webtools-safari-security-question.png
[img5]: ../../../media/loc/en/webtools/webtools-chrome-security-question.png
