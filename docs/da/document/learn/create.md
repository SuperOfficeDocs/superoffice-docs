---
uid: help-da-document-create
title: Opret nyt dokument
description: "Opret et nyt dokument direkte i SuperOffice CRM eller upload eksisterende, så du og dine kolleger altid har adgang til de nyeste dokumenter og versioner. Denne vejledning viser dig, hvordan du gør begge dele."
keywords: dokument
author: Bergfrid Dias
date: 07.12.2024
topic: howto
language: da
---

# Oprettelse af nye dokumenter

> [!TIP]
> Har du allerede dokumentet? Se [Upload dokumenter][1].

Følg instruktionerne nedenfor, afhængigt af hvordan dokumenter administreres i din SuperOffice-installation:

> [!NOTE]
> Denne funktion kræver licens.

## Hvordan ved jeg, om jeg bruger SharePoint, SuperOffice WebTools eller ej?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Oprettelse af nyt dokument med SharePoint-dokumenter

1. Klik på **Ny** > **Dokument** på toplinjen.

2. [Indtast de ønskede oplysninger i felterne][2].

3. Klik på knappen **Opret** for at oprette det nye dokument ud fra den valgte dokumentskabelon. Dokumentet oprettes i SharePoint og åbnes på en ny fane med online-tekstredigeringsprogrammet (Office Online).

    Hvis du vil bruge dit redigeringsprogram på computeren, kan du vælge **Åbn i desktop-appen** fra Office Online.

4. Indtast indholdet af dokumentet.

5. Luk fanen eller din computerapp. Dokumentet gemmes automatisk i SharePoint.

## Oprettelse af nyt dokument uden SuperOffice Web Tools

Hvis du ikke har installeret SuperOffice Web Tools, skal du downloade dokumenter manuelt for at redigere dem. Derefter skal du uploade de redigerede dokumenter til den centrale server bagefter.

> [!NOTE]
> Denne procedure beskriver, hvordan du opretter nye dokumenter, hvis du bruger et tekstredigeringsprogram på computeren. Den faktiske proces kan være lidt anderledes, hvis du bruger et online tekstredigeringsværktøj (som Microsoft 365) og et dokumentbibliotek (som SharePoint).

1. Klik på **Ny** > **Dokument** på toplinjen.

2. [Indtast de ønskede oplysninger i felterne][2].

3. Klik på knappen **Opret** for at oprette det nye dokument ud fra den valgte dokumentskabelon. Dokumentet oprettes på serveren.

    ![Create document from template -screenshot][img3]

4. Klik på **Åbn** og **Rediger**.

5. Vælg en af følgende knapper i dialogboksen **Filoverførsel**:

    * **Aktiv**: Når du klikker på **Åbn**, åbnes dokumentet i tekstbehandlingsprogrammet. Skriv det ønskede indhold i dokumentet, og vælg **Filer** > **Gem** som for at gemme det på det ønskede sted på pc'en.

    * **Gem**: Når du klikker på **Gem**, vises dialogboksen **Gem som**. Angiv du, hvor på pc'en du vil gemme filen, og klikker derefter på Gem for at starte overførslen. Klik på **Luk**, når overførslen er færdig. Åbn Windows Stifinder, og find det dokument, du netop har gemt. Åbn dokumentet, skriv det ønskede indhold, og gem dokumentet.

    > [!NOTE]
    > Ændringer i dokumentet gemmes ikke automatisk i SuperOffice. Hvis du ønsker sådan adfærd, anbefaler vi at installere [SuperOffice WebTools][3].

6. Luk tekstbehandlingsprogrammet.

7. Gå til dialogboksen Dokument.

    > [!NOTE]
    > Hvis ![ikon][img1] **Udført** er markeret på dialogboksen Dokument, er indstillingerne for upload deaktiveret. Fjern i så fald markeringen **Udført**.

8. Klik på linket for at uploade dokumentet eller trække og slippe dokumentet fra Windows Stifinder til dialogboksen **Dokument**.

    ![Opret et nyt dokument -screenshot][img2]

9. Luk dialogboksen **Dokument** ved at klikke på **Gem**.

## Opret et nyt dokument ved hjælp af SuperOffice WebTools

Med SuperOffice CRM kan du logge på fra en hvilken som helst pc via en browser, men dine dokumenter vil da ligge gemt på den centrale server. Download og upload af dokumenter håndteres automatisk af SuperOffice Web Tools.

1. Klik på **Ny** > **Dokument** på toplinjen.

2. [Indtast de ønskede oplysninger i felterne][2].

3. Klik på knappen **Opret** for at oprette det nye dokument ud fra den valgte dokumentskabelon. Dialogboksen **Dokument** lukkes automatisk, og dokumentet åbnes i din standard-teksteditor.

4. Skriv indholdet i dokumentet.

5. Gem dokumentet, og luk tekstbehandlingsprogrammet. Dokumentet gemmes.

## Relaterede emner

* [WebTools][3]
* [Send vedhæftede filer med e-mail fra SuperOffice][4]
* [Administrer dokumentskabeloner i Indstillinger og vedligeholdelse][5]

<!-- Referenced links -->
[1]: upload.md
[2]: screen/index.md
[3]: ../../webtools/learn/install.md
[4]: send-as-email.md
[5]: ../templates/admin/link-template.md

<!-- Referenced images -->
[img1]: ../../../media/icons/followup-completed-small.png
[img2]: ../../../media/loc/en/document/upload.png
[img3]: ../../../media/loc/en/document/create-document.png
