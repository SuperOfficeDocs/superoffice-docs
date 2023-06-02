---
uid: help-no-document-create
title: Opprett nytt dokument
description: "Opprett et nytt dokument direkte i SuperOffice CRM, eller last opp eksisterende, for å sikre at du og kollegene dine alltid har tilgang til de nyeste dokumentene og versjonene. Denne veiledningen viser deg hvordan du gjør begge deler."
author: SuperOffice RnD
so.date: 02.10.2023
keywords: dokument
so.topic: howto
language: no
---

# Opprett nye dokumenter

> [!TIP]
> Har du allerede dokumentet? Se [Laste opp dokumenter][1].

Følg instruksjonene nedenfor, avhengig av hvordan dokumenter håndteres i SuperOffice-installasjonen:

> [!NOTE]
> Denne funksjonen krever en lisens.

## Hvordan vet jeg om jeg bruker SharePoint, SuperOffice WebTools eller ikke?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Opprette et nytt dokument med SharePoint Documents

1. Klikk på **Ny** > **Dokument** på toppraden.

2. [Fyll ut feltene med nødvendig informasjon][2].

3. Klikk på **Opprett**-knappen for å opprette det nye dokumentet basert på den valgte dokumentmalen. Dokumentet opprettes i SharePoint og åpnes i en ny fane med et online tekstbehandlingsprogram (Office Online).

    > [!NOTE]
    > Hvis du vil bruke skrivebordprogrammet for å redigere, kan du velge **Åpne i skrivebordsprogrammet** fra Office Online.

4. Skriv inn innholdet i dokumentet.

5. Lukk fanen eller skrivebordsprogrammet. Dokumentet lagres automatisk i SharePoint.

## Opprett et nytt dokument uten SuperOffice WebTools

Hvis du ikke har installert SuperOffice WebTools, må du laste ned dokumenter manuelt for å redigere dem. Etterpå må du laste opp de redigerte dokumentene til den sentrale serveren.

> [!NOTE]
> Denne fremgangsmåten beskriver hvordan du oppretter nye dokumenter hvis du bruker et skrivebordsprogram for tekstredigering. Selve prosessen kan være litt annerledes hvis du bruker et tekstbehandlingsprogram tilgjengelig på Internett (for eksempel Microsoft Office Online) og et dokumentbibliotek (for eksempel SharePoint).

1. Klikk på **Ny** > **Dokument** på toppraden.

2. [Fyll ut feltene med nødvendig informasjon][2].

3. Klikk på **Opprett**-knappen for å opprette det nye dokumentet basert på den valgte dokumentmalen. Dokumentet opprettes på serveren.

4. Klikk på **Åpne** og **Rediger**.

5. I dialogboksen **Filnedlasting** velger du en av følgende knapper:

    * **Åpne**: Når du klikker på **Åpne**, åpnes dokumentet i tekstbehandlingsprogrammet. Skriv inn ønsket innhold i dokumentet, og velg **Fil** > **Lagre som** for å lagre det på ønsket sted på PCen.

    * **Lagre**: Når du klikker på **Lagre**, vises dialogboksen **Lagre som**. Angi hvor på PC-en du vil lagre filen, og klikk deretter **Lagre** for å starte nedlastingen. Klikk på **Lukk** når nedlastingen er fullført. Åpne Windows Utforsker, og bla gjennom til dokumentet du nettopp lagret. Åpne dokumentet, skriv inn ønsket innhold, og lagre dokumentet.

6. Lukk tekstbehandlingsprogrammet.

7. Gå til skjermbildet Dokument.

    > [!NOTE]
    > Hvis ![icon][img1] **Fullført** er merket av på Dokument-skjermbildet, er opplastingsalternativene deaktivert. Fjern i så fall avmerkingen for **Utført**.

8. Klikk på koblingen for å laste opp dokumentet, eller dra og slipp dokumentet fra Windows Utforsker til dialogboksen **Dokument**.

    ![img2 -screenshot][Opprette nytt dokument]

9. Lukk dialogboksen **Dokument** ved å klikke på **Lagre**.

## Opprett et nytt dokument ved hjelp av SuperOffice WebTools

Med SuperOffice CRM kan du logge på fra en hvilken som helst PC ved hjelp av en nettleser, men dokumentene dine blir deretter lagret på den sentrale serveren. Nedlasting og opplasting av dokumenter håndteres automatisk av SuperOffice WebTools.

1. Klikk på **Ny** > **Dokument** på toppraden.

2. [Fyll ut feltene med nødvendig informasjon][2].

3. Klikk på **Opprett**-knappen for å opprette det nye dokumentet basert på den valgte dokumentmalen. Dialogboksen **Dokument** lukkes automatisk, og dokumentet åpnes i ditt standard tekstredigeringsprogram.

4. Skriv innholdet i dokumentet.

5. Lagre dokumentet, og lukk tekstbehandlingsprogrammet. Dokumentet lagres.

## Aktuelle emner

* [WebTools][3]
* [Sende e-postvedlegg fra SuperOffice][4]
* [Behandle dokumentmaler i Innstillinger og vedlikehold][5]

<!-- Referenced links -->
[1]: upload.md
[2]: screen/index.md
[3]: ../../webtools/learn/index.md
[4]: send-as-email.md
[5]:

<!-- Referenced images -->
[img1]: ../../../media/icons/followup-completed-small.png
[img2]: media/upload.png
