---
uid: help-da-document-create
title: Opret nyt dokument
description: Opret et nyt dokument direkte i SuperOffice CRM eller upload eksisterende, så du og dine kolleger altid har adgang til de nyeste dokumenter og versioner. Denne vejledning viser dig, hvordan du gør begge dele.
keywords: dokument
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
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
    > Hvis **Udført** er markeret på dialogboksen Dokument, er indstillingerne for upload deaktiveret. Fjern i så fald markeringen **Udført**.

8. Klik på linket for at uploade dokumentet eller trække og slippe dokumentet fra Windows Stifinder til dialogboksen **Dokument**.

9. Luk dialogboksen **Dokument** ved at klikke på **Gem**.

***

## <a id="fields"></a>Sådan indtastes information

> [!NOTE]
> Mange felter har en liste over foruddefinerede værdier, du kan vælge imellem. Klik på <i class="ph ph-caret-down" aria-label="Chevron"></i> for at udvide listen. Vælg derefter en værdi for det pågældende felt. Alternativt kan du begynde at skrive i feltet for at søge efter en bestemt værdi, f.eks. et firmanavn.

![Opret dokument fra skabelon (ny) -screenshot][img4]

**Trin:**

1. Vælg en [dokumentskabelon][5]. Vælg et sprog for skabelonen. Denne mulighed er kun tilgængelig, hvis den valgte skabelon indeholder oversatte versioner.

1. Vælg eventuelt en virksomhed eller person, som dokumentet vedrører.

1. Vælg eventuelt et projekt og/eller salg for at knytte det til dokumentet. Du kan vælge et hvilket som helst projekt/salg uanset hvilken virksomhed du valgte tidligere.

1. Indtast en dokumenttitel i **Emne**-feltet. Denne tekst vises i sektionsfaner og i andre dokumentlister.

1. Dagens **dato** er indstillet som standard. Skift eventuelt oprettelsesdatoen (klik for at åbne datovælgeren).

    > [!NOTE]
    > Du kan ikke ændre denne dato efter at have klikket på **Opret**-knappen (feltet bliver skrivebeskyttet).

1. Indtast referencer:

    * **Vores ref:** Indtast din egen reference. Standardposten for hver skabelon er defineret i Indstillinger og vedligeholdelse, men du kan også redigere indholdet af dette felt.
    * **Deres ref:** Indtast modtagerens reference fra deres kommunikation.

### Andre indstillinger (valgfrit)

* I fanen **Detaljer** indtastes en beskrivelse af dokumentet (eller nøgleord) for at lette fritekstsøgning.

* I fanen **Links** klikker du på **Tilføj link** for at [knytte dokumentet til andre aktiviteter][9].

* I fanen **Mere** angiver du eventuelle [brugerdefinerede felter][10], der er konfigureret i Indstillinger og vedligeholdelse.

## <a id="upload"></a>Upload af dokumenter

1. Klik på **Ny** > **Dokument** på toplinjen.

2. Træk og slip dokumentet fra Windows Stifinder til dialogboksen **Dokument**.

3. (valgfrit) Vælg afkrydsningsfeltet i footeren for at markere dokumentet som udført.

4. Indtast de ønskede oplysninger i felterne.

5. Klik på knappen **Opret** for at oprette det nye dokument i SuperOffice CRM. Dokumentet tilføjes til detaljekortet **Aktiviteter**.

## Relateret indhold

* [Redigering af dokumenter][1]
* [Indtjekning/udtjekning af dokumenter][3]
* [Arkivere en e-mail][8]
* [Send vedhæftede filer med e-mail fra SuperOffice][4]
* [Administrer dokumentskabeloner i Indstillinger og vedligeholdelse][6]

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
