---
uid: help-da-document-update
title: Redigering af dokumenter
description: Redigering af dokumenter
keywords: dokument
author: Bergfrid Dias
date: 08.02.2024
topic: howto
language: da
audience: person
audience_tooltip: SuperOffice CRM
---

# Redigering af dokumenter

Redigering af dokumenter omfatter to ting:

* Redigering af dokumentets egenskaber, i dialogboksen Dokument.
* Redigering af selve dokumentfilen i det program, som dokumentet er oprettet i.

Du kan åbne et dokument i [redigeringstilstand eller læsetilstand][1]. Når du åbner dokumentet i redigeringstilstand, er det kun dig, der kan redigere det. Andre brugere kan åbne dokumentet i læsetilstand. Hvis din organisation bruger et dokumentbibliotek som SharePoint, kan flere personer redigere et dokument samtidigt.

## Rediger dokumentegenskaber i dialogboksen Dokument

Hvis du vil ændre dokumentegenskaberne, f.eks. hvilket projekt dokumentet skal knyttes til, skal dette gøres via dialogboksen Dokument:

1. Marker det ønskede dokument.

2. Højreklik, og vælg **Dokument**. Hvis du dobbeltklikker på dokumentet, åbnes det direkte i det program, det er oprettet i.

3. [Foretag de nødvendige ændringer][3].

4. Klik på knappen **Gem**.

## Rediger dokumentindhold

Følg instruktionerne nedenfor, afhængigt af hvordan dokumenter administreres i din SuperOffice-installation.

<!-- markdownlint-disable-file MD051 -->
### [Med SuperOffice Web Tools](#tab/webtools)

1. Dobbeltklik på det ønskede dokument.

2. Hvis der åbnes en dialogboks, skal du klikke på **Rediger**.

3. Gem dokumentet, og luk tekstbehandlingsprogrammet.

4. (hvis det er aktuelt) I den dialogboks, der vises, skal du klikke på **Ja**, hvis du er færdig med at redigere dokumentet. Klik på **Nej** for at beholde dokumentet udtjekket.

    Denne dialogboks vises kun, hvis denne indstilling er aktiveret i SuperOffice WebTools.

5. Dokumentet tjekkes ind, og status sættes til **Udført**.

### [Med SharePoint](#tab/sharepoint)

**Denne funktion kræver licens.**

1. Dobbeltklik på det ønskede dokument. Dokumentet åbnes på en ny fane med online-tekstredigeringsprogrammet (Office Online).

    Hvis du vil bruge dit redigeringsprogram på computeren, kan du vælge **Åbn i desktop-appen** fra Office Online.

2. Rediger dokumentet.

3. Luk fanen eller din computerapp. Dokumentet gemmes automatisk i SharePoint

### [Uden SuperOffice Web Tools](#tab/no-webtools)

> [!NOTE]
> Denne procedure beskriver, hvordan du opretter nye dokumenter, hvis du bruger et tekstredigeringsprogram på computeren. Den faktiske proces kan være lidt anderledes, hvis du bruger et online tekstredigeringsværktøj (som Microsoft Office Online) og et dokumentbibliotek (som SharePoint).

1. Dobbeltklik på det ønskede dokument.

2. Klik på **Åbn** i dialogboksen **Dokument**.

3. Hvis der åbnes en dialogboks, skal du klikke på **Rediger**.

4. I dialogboksen **Filoverførsel** vælger du **Åbn** eller **Gem**. Derefter følger du trin 5-9 fra proceduren [opret dokument uden WebTools][2].

***

### <a id="allow" />Browser sikkerhedsspørgsmål ved åbning af filer

Når du får adgang til og redigerer et dokument, fil eller e-mail i SuperOffice, præsenterer din browser dig for et *sikkerhedsspørgsmål* vedrørende filoverførslen.

* For at åbne filen skal du vælge knappen **Åbn**/**Tillad**.
* Vælg **Altid tillad** for at springe spørgsmålet over næste gang.

Dialogboksen er lidt anderledes i Chrome, Edge, Firefox og Safari.

**Chrome:** Vælg **Åbn URL:SuperOffice-Extensions**.

![Chrome: Åbn URL:SuperOffice-Extensions -screenshot][img5]

**Edge:** Vælg **Åbn**.

![Edge: Åbn -screenshot][img2]

**Firefox:** Vælg **Åbn link**.

![Firefox: Åbn link -screenshot][img3]

**Safari:** Vælg **Altid tillad** eller **Tillad**.

![Safari: Altid tillad eller Tillad -screenshot][img4]

## <a id="delete" />Sletning af dokumenter

1. Vælg det ønskede dokument på detaljekortet **Aktiviteter** på skærmbillederne Firma, Person, Dagbog, Salg eller Projekt.
2. Klik på knappen **Slet** nederst for listen.
3. I dialogboksen **Slet dokument** skal du bekræfte eller annullere sletningen.

## Fejlfinding

Hvis du dobbeltklikker på et dokument, og der ikke sker noget, kan du prøve at højreklikke på det og vælge **Dokument**. Dette åbner dialogboksen **Dokument** . Klik på **Åbn**, og se, om dokumentet åbnes nu.

### Hvordan ved jeg, om jeg bruger SharePoint, SuperOffice WebTools eller ej?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

<!-- Referenced links -->
[1]: lock.md
[2]: create.md
[3]: screen/index.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/webtools/webtools-edge-security-question.png
[img3]: ../../../media/loc/en/webtools/webtools-firefox-security-question.png
[img4]: ../../../media/loc/en/webtools/webtools-safari-security-question.png
[img5]: ../../../media/loc/en/webtools/webtools-chrome-security-question.png
