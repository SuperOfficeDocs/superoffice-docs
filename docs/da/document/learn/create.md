---
uid: help-da-document-create
title: Opret nyt dokument
description: "Opret et nyt dokument direkte i SuperOffice CRM eller upload eksisterende, så du og dine kolleger altid har adgang til de nyeste dokumenter og versioner. Denne vejledning viser dig, hvordan du gør begge dele."
keywords: dokument
author: Bergfrid Dias
date: 08.02.2024
topic: howto
language: da
audience: person
audience_tooltip: SuperOffice CRM
---

# Oprettelse af nye dokumenter

> [!TIP]
> Har du allerede dokumentet? Se [Upload dokumenter](#upload).

Følg instruktionerne nedenfor, afhængigt af hvordan dokumenter administreres i din SuperOffice-installation.

## Hvordan ved jeg, om jeg bruger SharePoint, SuperOffice WebTools eller ej?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

<!-- markdownlint-disable-file MD051 -->
## Trin

### [Med SuperOffice WebTools](#tab/webtools)

Med SuperOffice CRM kan du logge på fra en hvilken som helst pc via en browser, men dine dokumenter vil da ligge gemt på den centrale server. Download og upload af dokumenter håndteres automatisk af SuperOffice Web Tools.

1. Klik på **Ny** > **Dokument** på toplinjen.

2. [Indtast de ønskede oplysninger i felterne](#fields).

3. Klik på knappen **Opret** for at oprette det nye dokument ud fra den valgte [dokumentskabelon][5]. Dialogboksen **Dokument** lukkes automatisk, og dokumentet åbnes i din standard-teksteditor.

4. Skriv indholdet i dokumentet.

5. Gem dokumentet, og luk tekstbehandlingsprogrammet. Dokumentet gemmes.

### [Med SharePoint-dokumenter](#tab/sharepoint)

**Denne funktion kræver licens.**

1. Klik på **Ny** > **Dokument** på toplinjen.

2. [Indtast de ønskede oplysninger i felterne](#fields).

3. Klik på knappen **Opret** for at oprette det nye dokument ud fra den valgte [dokumentskabelon][5]. Dokumentet oprettes i SharePoint og åbnes på en ny fane med online-tekstredigeringsprogrammet (Office Online).

    Hvis du vil bruge dit redigeringsprogram på computeren, kan du vælge **Åbn i desktop-appen** fra Office Online.

4. Indtast indholdet af dokumentet.

5. Luk fanen eller din computerapp. Dokumentet gemmes automatisk i SharePoint.

### [Uden SuperOffice Web Tools](#tab/no-webtools)

Hvis du ikke har installeret SuperOffice Web Tools, skal du downloade dokumenter manuelt for at redigere dem. Derefter skal du uploade de redigerede dokumenter til den centrale server bagefter.

> [!NOTE]
> Denne procedure beskriver, hvordan du opretter nye dokumenter, hvis du bruger et tekstredigeringsprogram på computeren. Den faktiske proces kan være lidt anderledes, hvis du bruger et online tekstredigeringsværktøj (som Microsoft 365) og et dokumentbibliotek (som SharePoint).

1. Klik på **Ny** > **Dokument** på toplinjen.

2. [Indtast de ønskede oplysninger i felterne](#fields).

3. Klik på knappen **Opret** for at oprette det nye dokument ud fra den valgte [dokumentskabelon][5]. Dokumentet oprettes på serveren.

4. Klik på **Åbn** og **Rediger**.

5. Vælg en af følgende knapper i dialogboksen **Filoverførsel**:

    * **Aktiv**: Når du klikker på **Åbn**, åbnes dokumentet i tekstbehandlingsprogrammet. Skriv det ønskede indhold i dokumentet, og vælg **Filer** > **Gem** som for at gemme det på det ønskede sted på pc'en.

    * **Gem**: Når du klikker på **Gem**, vises dialogboksen **Gem som**. Angiv du, hvor på pc'en du vil gemme filen, og klikker derefter på Gem for at starte overførslen. Klik på **Luk**, når overførslen er færdig. Åbn Windows Stifinder, og find det dokument, du netop har gemt. Åbn dokumentet, skriv det ønskede indhold, og gem dokumentet.

    > [!NOTE]
    > Ændringer i dokumentet gemmes ikke automatisk i SuperOffice. Hvis du ønsker sådan adfærd, anbefaler vi at installere [SuperOffice WebTools][7].

6. Luk tekstbehandlingsprogrammet.

7. Gå til dialogboksen Dokument.

    > [!NOTE]
    > Hvis ![ikon][img1] **Udført** er markeret på dialogboksen Dokument, er indstillingerne for upload deaktiveret. Fjern i så fald markeringen **Udført**.

8. Klik på linket for at uploade dokumentet eller trække og slippe dokumentet fra Windows Stifinder til dialogboksen **Dokument**.

    ![Opret et nyt dokument -screenshot][img2]

9. Luk dialogboksen **Dokument** ved at klikke på **Gem**.

***

## <a id="fields" />How to enter information

> [!NOTE]
> Many fields have a list of predefined values you can choose from. Click the arrow ![icon][img5] to expand the list. Then select a value for that field. Alternatively, start typing in the field to search for a specific value, such as a company name.

![Create document from template -screenshot][img3]

1. Choose a [document template][5]. Select a language for the template. This option is only available if the selected template includes translated versions.

1. Optionally, select a company or contact the document pertains to.

1. Optionally, select a project and/or sale to link it to the document. You can choose any project/sale regardless of which company you chose earlier.

1. Enter a document title in the **Subject** field. This text is shown in section tabs and in other lists of document.

1. Today's **date** is set by default. Optionally, change the creation date (click to open the date picker).

    > [!NOTE]
    > You cannot change this date after clicking the **Create** button (the field becomes read-only).

1. Enter references:

    * **Our ref:** Enter your own reference. The default entry for each template is defined in Settings and maintenance, but you can also edit the content of this field.
    * **Your ref:** Enter the addressee's reference from their communication.

### Other settings (optional)

* In the the **Details** tab, enter a description of the document (or keywords) to aid free-text searching.

* In the **Links** tab, click **Add link** to [link the document to other activities][9].

* In the **More** tab, set any [user-defined fields][10] configured in Settings and maintenance.

## <a id="upload" />Upload af dokumenter

1. Klik på **Ny** > **Dokument** på toplinjen.

2. Træk og slip dokumentet fra Windows Stifinder til dialogboksen **Dokument**.

3. (valgfrit) Klik på ![ikon][img4] i øverste højre hjørne for at angive dokumentet til **Fuldført** ![ikon][img1].

4. [Indtast de ønskede oplysninger i felterne][2].

5. Klik på knappen **Opret** for at oprette det nye dokument i SuperOffice CRM. Dokumentet tilføjes til detaljekortet **Aktiviteter**.

## Relaterede emner

* [Redigering af dokumenter][1]
* [Indtjekning/udtjekning af dokumenter][3]
* [Arkivere en e-mail][8]
* [Send vedhæftede filer med e-mail fra SuperOffice][4]
* [Administrer dokumentskabeloner i Indstillinger og vedligeholdelse][6]

<!-- Referenced links -->
[1]: edit.md
[2]: screen/index.md
[3]: lock.md
[4]: send-as-email.md
[5]: ../templates/learn/index.md
[6]: ../templates/admin/link-template.md
[7]: ../../webtools/learn/install.md
[8]: ../../email/mail-link/learn/archive.md
[9]: ../../diary/learn/linking-documents-to-follow-ups.md
[10]: ../../custom-objects/learn/udef.md

<!-- Referenced images -->
[img1]: ../../../media/icons/followup-completed-small.png
[img4]: ../../../media/icons/followup-not-completed-small.png
[img2]: ../../../media/loc/en/document/upload.png
[img3]: ../../../media/loc/en/document/create-document.png
[img5]: ../../../../common/icons/dropdown-icon.png
