---
uid: help-da-document-update
title: Redigering af dokumenter
description: Redigering af dokumenter
author: SuperOffice RnD
so.date: 12.06.2023
keywords: dokument
so.topic: howto
language: da
---

# Redigering af dokumenter

Redigering af dokumenter omfatter to ting:

* Redigering af dokumentets egenskaber, i skærmbilledet Dokument.
* Redigering af selve dokumentfilen i det program, som dokumentet er oprettet i.

Du kan åbne et dokument i [redigeringstilstand eller læsetilstand][1]. Når du åbner dokumentet i redigeringstilstand, er det kun dig, der kan redigere det. Andre brugere kan åbne dokumentet i læsetilstand.

Hvis din organisation bruger et dokumentbibliotek som SharePoint, kan flere personer redigere et dokument samtidigt.

> [!NOTE]
> Denne funktion kræver licens.

Følg instruktionerne nedenfor, afhængigt af hvordan dokumenter administreres i din SuperOffice-installation:

## Hvordan ved jeg, om jeg bruger SharePoint, SuperOffice WebTools eller ej?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Rediger dokumentegenskaber i skærmbilledet Dokument

Hvis du vil ændre dokumentegenskaberne, f.eks. hvilket projekt dokumentet skal knyttes til, skal dette gøres via skærmbilledet Dokument:

1. [Marker det ønskede dokument][2].
2. Højreklik, og vælg **Dokument**. Hvis du dobbeltklikker på dokumentet, åbnes det direkte i det program, det er oprettet i.
3. [Foretag de nødvendige ændringer][3].
4. Klik på knappen **Gem**.

## Rediger dokumentindhold ved hjælp af SharePoint-dokumenter

1. [Dobbeltklik på det ønskede dokument][2]. Dokumentet åbnes på en ny fane med online-tekstredigeringsprogrammet (Office Online).

    > [!NOTE]
    > Hvis du vil bruge dit redigeringsprogram på computeren, kan du vælge **Åbn i desktop-appen** fra Office Online.

2. Rediger dokumentet.

3. Luk fanen eller din computerapp. Dokumentet gemmes automatisk i SharePoint

## Redigering af indhold i dokumenter - uden SuperOffice Web Tools

> [!NOTE]
> Denne procedure beskriver, hvordan du opretter nye dokumenter, hvis du bruger et tekstredigeringsprogram på computeren. Den faktiske proces kan være lidt anderledes, hvis du bruger et online tekstredigeringsværktøj (som Microsoft Office Online) og et dokumentbibliotek (som SharePoint).

1. [Dobbeltklik på det ønskede dokument][2].
2. Klik på **Åbn** i dialogboksen **Dokument**.
3. Hvis der åbnes en dialogboks, skal du klikke på **Rediger**.
4. Vælg en af følgende indstillinger i dialogboksen Filoverførsel:
    * **Aktiv**: Når du vælger indstillingen for at åbne, åbnes dokumentet i tekstbehandlingsprogrammet. Skriv det ønskede indhold i dokumentet, og vælg **Filer** > **Gem** som for at gemme det på det ønskede sted på pc'en.
    * **Gem**: Når du vælger indstillingen for at gemme, vises dialogboksen **Gem som**. Angiv, hvor på pc'en du vil gemme filen, og gem den. Derefter åbner du dokumentet, skriver det ønskede indhold og gemmer det.
5. Luk tekstbehandlingsprogrammet.
6. Gå til dialogboksen **Dokument**.

    > [!NOTE]
    > Hvis **Udført** er markeret i dialogboksen **Dokument**, er alternativerne for upload deaktiveret. Fjern i så fald markeringen **Udført**.

7. Klik på linket for at uploade dokumentet eller trække og slippe dokumentet fra Windows Stifinder til dialogboksen **Dokument**.

    ![Opret et nyt dokument -screenshot][img1]

8. Luk dialogboksen **Dokument** ved at klikke på **Gem**. Dokumentet tjekkes ind, og status sættes til **Udført**.

## Redigering af indhold i dokumenter - med SuperOffice Web Tools

1. [Dobbeltklik på det ønskede dokument][2].
2. Hvis der åbnes en dialogboks, skal du klikke på **Rediger**.
3. Gem dokumentet, og luk tekstbehandlingsprogrammet.
4. (hvis det er aktuelt) I den dialogboks, der vises, skal du klikke på **Ja**, hvis du er færdig med at redigere dokumentet. Klik på **Nej** for at beholde dokumentet udtjekket.

    Denne dialogboks vises kun, hvis denne indstilling er aktiveret i SuperOffice WebTools.

5. Dokumentet tjekkes ind, og status sættes til **Udført**.

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

## Fejlfinding

Hvis du dobbeltklikker på et dokument, og der ikke sker noget, kan du prøve at højreklikke på det og vælge **Dokument**. Dette åbner dialogboksen **Dokument** . Klik på **Åbn**, og se, om dokumentet åbnes nu.

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
