---
uid: help-no-document-create
title: Opprett nytt dokument
description: Opprett et nytt dokument direkte i SuperOffice CRM, eller last opp eksisterende, for å sikre at du og kollegene dine alltid har tilgang til de nyeste dokumentene og versjonene. Denne veiledningen viser deg hvordan du gjør begge deler.
keywords: nytt dokument, legg til dokument, opprett dokument, WebTools, SharePoint, dokument
author: Bergfrid Dias
date: 02.05.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Opprett nye dokument

> [!TIP]
> Har du allerede dokumentet? Se [Laste opp dokumenter](#upload).

Følg instruksjonene nedenfor, avhengig av hvordan dokumenter håndteres i SuperOffice-installasjonen.

## Hvordan vet jeg om jeg bruker SharePoint, SuperOffice WebTools eller ikke?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

<!-- markdownlint-disable-file MD051 -->
## Trinn

### [Med SuperOffice WebTools](#tab/webtools)

Med SuperOffice CRM kan du logge på fra en hvilken som helst PC ved hjelp av en nettleser, men dokumentene dine blir deretter lagret på den sentrale serveren. Nedlasting og opplasting av dokumenter håndteres automatisk av SuperOffice WebTools.

1. Klikk **Ny** på toppraden og velg **Dokument**.

2. [Fyll ut feltene med nødvendig informasjon](#fields).

3. Klikk på **Opprett**-knappen for å opprette det nye dokumentet basert på den valgte [dokumentmalen][5]. Dialogboksen **Dokument** lukkes automatisk, og dokumentet åpnes i ditt standard tekstredigeringsprogram.

4. Skriv innholdet i dokumentet.

5. Lagre dokumentet, og lukk tekstbehandlingsprogrammet. Dokumentet lagres.

### [Med SharePoint Documents](#tab/sharepoint)

**Denne funksjonen krever en lisens.**

1. Klikk **Ny** på toppraden og velg **Dokument**.

2. [Fyll ut feltene med nødvendig informasjon](#fields).

3. Klikk på **Opprett**-knappen for å opprette det nye dokumentet basert på den valgte [dokumentmalen][5]. Dokumentet opprettes i SharePoint og åpnes i en ny fane med et online tekstbehandlingsprogram (Office Online).

    Hvis du vil bruke skrivebordprogrammet for å redigere, kan du velge **Åpne i skrivebordsprogrammet** fra Office Online.

4. Skriv inn innholdet i dokumentet.

5. Lukk fanen eller skrivebordsprogrammet. Dokumentet lagres automatisk i SharePoint.

### [Uten SuperOffice WebTools](#tab/no-webtools)

Hvis du ikke har installert SuperOffice WebTools, må du laste ned dokumenter manuelt for å redigere dem. Etterpå må du laste opp de redigerte dokumentene til den sentrale serveren.

> [!NOTE]
> Denne fremgangsmåten beskriver hvordan du oppretter nye dokumenter hvis du bruker et skrivebordsprogram for tekstredigering. Selve prosessen kan være litt annerledes hvis du bruker et tekstbehandlingsprogram tilgjengelig på Internett (for eksempel Microsoft 365) og et dokumentbibliotek (for eksempel SharePoint).

1. Klikk **Ny** på toppraden og velg **Dokument**

2. [Fyll ut feltene med nødvendig informasjon](#fields).

3. Klikk på **Opprett**-knappen for å opprette det nye dokumentet basert på den valgte [dokumentmalen][5]. Dokumentet opprettes på serveren.

4. Klikk på **Åpne** og **Rediger**.

5. I dialogboksen **Filnedlasting** velger du en av følgende knapper:

    * **Åpne**: Når du klikker på **Åpne**, åpnes dokumentet i tekstbehandlingsprogrammet. Skriv inn ønsket innhold i dokumentet, og velg **Fil** > **Lagre som** for å lagre det på ønsket sted på PCen.

    * **Lagre**: Når du klikker på **Lagre**, vises dialogboksen **Lagre som**. Angi hvor på PC-en du vil lagre filen, og klikk deretter **Lagre** for å starte nedlastingen. Klikk på **Lukk** når nedlastingen er fullført. Åpne Windows Utforsker, og bla gjennom til dokumentet du nettopp lagret. Åpne dokumentet, skriv inn ønsket innhold, og lagre dokumentet.

    > [!NOTE]
    > Endringer i dokumentet lagres ikke automatisk i SuperOffice. Hvis du ønsker slik oppførsel, anbefaler vi å installere [SuperOffice WebTools][7].

6. Lukk tekstbehandlingsprogrammet.

7. Gå til dialogboksen Dokument.

    > [!NOTE]
    > Hvis **Utført** er merket av på Dokument-dialogen, er opplastingsalternativene deaktivert. Fjern i så fall avmerkingen for **Utført**.

8. Klikk på koblingen for å laste opp dokumentet, eller dra og slipp dokumentet fra Windows Utforsker til dialogboksen **Dokument**.

9. Lukk dialogboksen **Dokument** ved å klikke på **Lagre**.

***

## <a id="fields"></a>Slik fyller du inn informasjon

> [!NOTE]
> Mange felt har en liste over forhåndsdefinerte verdier du kan velge fra. Klikk på <i class="ph ph-caret-down" aria-label="Chevron"></i> for å utvide listen. Velg deretter en verdi for det feltet. Alternativt kan du begynne å skrive i feltet for å søke etter en bestemt verdi, for eksempel et firmanavn.

![Opprett dokument fra mal (ny) -screenshot][img4]

**Trinn:**

1. Velg en [dokumentmal][5]. Velg et språk for malen. Dette feltet er bare tilgjengelig hvis den valgte malen inneholder oversatte versjoner.

1. Velg eventuelt et firma eller en person som dokumentet gjelder.

1. Velg eventuelt et prosjekt og/eller salg for å knytte det til dokumentet. Du kan velge et hvilket som helst prosjekt/salg uavhengig av hvilket firma du valgte tidligere.

1. Skriv inn en dokumenttittel i **Emne**-feltet. Denne teksten vises i detaljfaner og i andre dokumentlister.

1. Dagens **dato** er satt som standard. Endre eventuelt opprettelsesdatoen (klikk for å åpne datovelgeren).

    > [!NOTE]
    > Du kan ikke endre denne datoen etter å ha klikket på **Opprett**-knappen (feltet blir skrivebeskyttet).

1. Skriv inn referanser:

    * **Vår ref:** Skriv inn din egen referanse. Standardoppføringen for hver mal er definert i Innstillinger og vedlikehold, men du kan også redigere innholdet i dette feltet.
    * **Din ref:** Skriv inn mottakerens referanse fra deres kommunikasjon.

### Andre innstillinger (valgfritt)

* I fanen **Detaljer** skriver du inn en beskrivelse av dokumentet (eller nøkkelord) for å lette fritekstsøk.

* I fanen **Lenker** klikker du på **Legg til lenke** for å [knytte dokumentet til andre aktiviteter][9].

* I **Mer**-fanen, angi eventuelle [brukerdefinerte felt][10] konfigurert i Innstillinger og vedlikehold.

## <a id="upload"></a>Last opp dokumenter

1. Klikk **Ny** på toppraden og velg **Dokument**

2. Dra og slipp dokumentet fra Windows Explorer til dialogboksen **Dokument**.

3. (valgfritt) Velg avmerkingsboksen i footeren for å markere dokumentet som fullført.

4. [Fyll ut feltene med nødvendig informasjon](#fields).

5. Klikk på **Opprett**-knappen for å opprette det nye dokumentet i SuperOffice CRM. Dokumentet legges til på detaljkortet **Aktiviteter**.

## Relatert innhold

* [Redigere dokumenter][1]
* [Sjekke inn/ut dokumenter][3]
* [Arkivere en e-post][8]
* [Sende e-postvedlegg fra SuperOffice][4]
* [Behandle dokumentmaler i Innstillinger og vedlikehold][6]

<!-- Referenced links -->
[1]: edit.md
[3]: lock.md
[4]: send-as-email.md
[5]: ../templates/learn/index.md
[6]: ../templates/admin/link-template.md
[7]: ../../webtools/learn/install.md
[8]: ../../email/mail-link/learn/archive.md
[9]: ../../learn/basics/links.md
[10]: ../../custom-objects/learn/udef.md

<!-- Referenced images -->
[img4]: ../../../media/loc/en/document/create-document.png
