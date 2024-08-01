---
uid: help-no-document-create
title: Opprett nytt dokument
description: Opprett et nytt dokument direkte i SuperOffice CRM, eller last opp eksisterende, for å sikre at du og kollegene dine alltid har tilgang til de nyeste dokumentene og versjonene. Denne veiledningen viser deg hvordan du gjør begge deler.
keywords: dokument
author: Bergfrid Dias
date: 08.02.2024
topic: howto
language: no
audience: person
audience_tooltip: SuperOffice CRM
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

1. Klikk på **Ny** > **Dokument** på toppraden.

2. [Fyll ut feltene med nødvendig informasjon](#fields).

3. Klikk på **Opprett**-knappen for å opprette det nye dokumentet basert på den valgte [dokumentmalen][5]. Dialogboksen **Dokument** lukkes automatisk, og dokumentet åpnes i ditt standard tekstredigeringsprogram.

4. Skriv innholdet i dokumentet.

5. Lagre dokumentet, og lukk tekstbehandlingsprogrammet. Dokumentet lagres.

### [Med SharePoint Documents](#tab/sharepoint)

**Denne funksjonen krever en lisens.**

1. Klikk på **Ny** > **Dokument** på toppraden.

2. [Fyll ut feltene med nødvendig informasjon](#fields).

3. Klikk på **Opprett**-knappen for å opprette det nye dokumentet basert på den valgte [dokumentmalen][5]. Dokumentet opprettes i SharePoint og åpnes i en ny fane med et online tekstbehandlingsprogram (Office Online).

    Hvis du vil bruke skrivebordprogrammet for å redigere, kan du velge **Åpne i skrivebordsprogrammet** fra Office Online.

4. Skriv inn innholdet i dokumentet.

5. Lukk fanen eller skrivebordsprogrammet. Dokumentet lagres automatisk i SharePoint.

### [Uten SuperOffice WebTools](#tab/no-webtools)

Hvis du ikke har installert SuperOffice WebTools, må du laste ned dokumenter manuelt for å redigere dem. Etterpå må du laste opp de redigerte dokumentene til den sentrale serveren.

> [!NOTE]
> Denne fremgangsmåten beskriver hvordan du oppretter nye dokumenter hvis du bruker et skrivebordsprogram for tekstredigering. Selve prosessen kan være litt annerledes hvis du bruker et tekstbehandlingsprogram tilgjengelig på Internett (for eksempel Microsoft 365) og et dokumentbibliotek (for eksempel SharePoint).

1. Klikk på **Ny** > **Dokument** på toppraden.

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
    > Hvis ![icon][img1] **Fullført** er merket av på Dokument-dialogen, er opplastingsalternativene deaktivert. Fjern i så fall avmerkingen for **Utført**.

8. Klikk på koblingen for å laste opp dokumentet, eller dra og slipp dokumentet fra Windows Utforsker til dialogboksen **Dokument**.

    ![Opprette nytt dokument -screenshot][img2]

9. Lukk dialogboksen **Dokument** ved å klikke på **Lagre**.

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

## <a id="upload" />Last opp dokumenter

1. Klikk på **Ny** > **Dokument** på toppraden.

2. Dra og slipp dokumentet fra Windows Explorer til dialogboksen **Dokument**.

3. (valgfritt) Klikk på ![icon][img4] øverst til høyre for å sette dokumentet til **Fullført** ![icon][img1].

4. [Fyll ut feltene med nødvendig informasjon](#fields).

5. Klikk på **Opprett**-knappen for å opprette det nye dokumentet i SuperOffice CRM. Dokumentet legges til på detaljkortet **Aktiviteter**.

## Aktuelle emner

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
[9]: ../../diary/learn/linking-documents-to-follow-ups.md
[10]: ../../custom-objects/learn/udef.md

<!-- Referenced images -->
[img1]: ../../../media/icons/followup-completed-small.png
[img4]: ../../../media/icons/followup-not-completed-small.png
[img2]: ../../../media/loc/en/document/upload.png
[img3]: ../../../media/loc/en/document/create-document.png
[img5]: ../../../../common/icons/dropdown-icon.png
