---
uid: help-nl-document-update
title: Documenten bewerken
description: Documenten bewerken
author: SuperOffice RnD
so.date: 12.06.2023
keywords: document
so.topic: howto
language: nl
---

# Documenten bewerken

Het bewerken van documenten omvat twee zaken:

* Bewerken van de documenteigenschappen in het documentscherm.
* Bewerken van het documentbestand zelf in de toepassing waarin het document is gemaakt.

U kunt een document openen in [bewerkingsmodus of in leesmodus][1]. Wanneer u een document opent in de bewerkingsmodus, kunt u alleen zelf het document bewerken. Andere gebruikers kunnen het document in leesmodus openen.

Als uw organisatie een documentbibliotheek zoals SharePoint gebruikt, kunnen meerdere mensen tegelijkertijd een document bewerken.

> [!NOTE]
> Voor deze functie is een licentie vereist.

Volg de onderstaande instructies, afhankelijk van hoe documenten worden beheerd in uw SuperOffice-installatie:

## Hoe weet ik of ik SharePoint, SuperOffice WebTools gebruik of niet?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Documenteigenschappen bewerken in het venster Document

Als u documenteigenschappen wilt wijzigen, zoals het project waaraan het document is gekoppeld, gebruikt u het scherm Document:

1. [Selecteer het gewenste document][2].
2. Klik met de rechtermuisknop en kies **Document**. Als u dubbelklikt op het document, wordt het document rechtstreeks geopend in de toepassing waarin het is gemaakt.
3. [Breng de gewenste wijzigingen aan][3].
4. Klik op de knop **Opslaan**.

## Documentinhoud bewerken met SharePoint-documenten

1. [Dubbelklik op het gewenste document][2]. Het document wordt geopend in een nieuw tabblad met het online tekstbewerkingsprogramma (Office Online).

    > [!NOTE]
    > Als u uw bewerkingsprogramma op uw bureaublad wilt gebruiken, kiest u **Openen in desktop-app** van Office Online.

2. Bewerk het document.

3. Sluit het tabblad of uw bureaublad-app. Het document wordt automatisch opgeslagen in SharePoint

## Documentinhoud bewerken - zonder SuperOffice Web Tools

> [!NOTE]
> In deze procedure wordt beschreven hoe u nieuwe documenten maakt als u een bureaubladtoepassing voor tekstbewerking gebruikt. Het werkelijke proces kan enigszins anders zijn als u een online tekstbewerkingsprogramma (zoals Microsoft Office Online) en een documentbibliotheek (zoals SharePoint) gebruikt.

1. [Dubbelklik op het gewenste document][2].
2. Klik in het dialoogvenster **Document** op **Openen**.
3. Als er een dialoogvenster wordt geopend, klikt u op **Bewerken**.
4. Selecteer in het dialoogvenster voor het downloaden van bestanden een van de volgende opties:
    * **Openen**: wanneer u klikt op de optie Openen, wordt het document geopend in de tekstbewerkingstoepassing. Typ de inhoud van het document en selecteer **Bestand** > **Opslaan als** om het op te slaan op de gewenste locatie op uw computer.
    * **Opslaan**: Wanneer u op de optie Opslaan klikt, wordt het dialoogvenster **Opslaan als** weergegeven. Geef aan op welke computer u het bestand wilt opslaan en sla het op. Open vervolgens het document, voer de gewenste tekst in en sla het document op.
5. Sluit het tekstverwerkingsprogramma.
6. Ga naar het dialoogvenster **Document**.

    > [!NOTE]
    > Als **Voltooid** is geselecteerd in het dialoogvenster **Document**, zijn de opties voor uploaden uitgeschakeld. Verwijder in dat geval het vinkje **Voltooid**.

7. Klik op de koppeling om het document te uploaden of gebruik Slepen en neerzetten om het document vanuit Windows Verkenner naar het dialoogvenster **Document** te verplaatsen.

    ![Een nieuw document maken -screenshot][img1]

8. Sluit het dialoogvenster **Document** door te klikken op **Opslaan**. Het document is aangemeld en de status is ingesteld op **Voltooid**.

## Documentinhoud bewerken - met SuperOffice Web Tools

1. [Dubbelklik op het gewenste document][2].
2. Als er een dialoogvenster wordt geopend, klikt u op **Bewerken**.
3. Sla het document op en sluit de tekstbewerkingstoepassing.
4. (indien van toepassing) Klik in het dialoogvenster dat wordt weergegeven, op **Ja** als u klaar bent met de bewerking van het document. Klik op **Nee** om het document afgemeld te houden.

    Dit dialoogvenster wordt alleen weergegeven als deze optie is geactiveerd in SuperOffice WebTools.

5. Het document is aangemeld en de status is ingesteld op **Voltooid**.

### <a id="allow" />Beveiligingsvraag van de browser bij het openen van bestanden

Wanneer u toegang krijgt tot en een document, bestand of e-mail bewerkt in SuperOffice, vraagt uw browser u om een *beveiligingsvraag* met betrekking tot het downloaden van het bestand.

* Om het bestand te openen, moet u de knop **Openen**/**Toestaan** selecteren.
* Selecteer **Altijd toestaan** om de vraag de volgende keer over te slaan.

De dialoog is enigszins verschillend in Chrome, Edge, Firefox en Safari.

**Chrome:** Selecteer **Openen URL:SuperOffice-Extensions**.

![Chrome: Openen URL:SuperOffice-Extensions -screenshot][img5]

**Edge:** Selecteer **Openen**.

![Edge: Openen -screenshot][img2]

**Firefox:** Selecteer **Link openen**.

![Firefox: Link openen -screenshot][img3]

**Safari:** Selecteer **Altijd toestaan** of **Toestaan**.

![Safari: Altijd toestaan of Toestaan -screenshot][img4]

## Probleemoplossing

Als u dubbelklikt op een document en er gebeurt niets, klikt u er met de rechtermuisknop op en selecteert u **Document**. Hiermee wordt het dialoogvenster **Document** geopend. Klik op **Openen** en kijk of het document nu wordt geopend.

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
