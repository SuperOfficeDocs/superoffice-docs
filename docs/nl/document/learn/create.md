---
uid: help-nl-document-create
title: Nieuw document maken
description: "Maak een nieuw document rechtstreeks in SuperOffice CRM of upload bestaande documenten, om ervoor te zorgen dat u en uw collega's altijd toegang hebben tot de nieuwste documenten en versies. Deze handleiding laat u zien hoe u beide kunt doen."
keywords: document
author: Bergfrid Dias
date: 07.12.2024
topic: howto
language: nl
---

# Nieuwe documenten maken

> [!TIP]
> U hebt het document al? ZIe [Documenten uploaden][1].

Volg de onderstaande instructies, afhankelijk van hoe documenten worden beheerd in uw SuperOffice-installatie:

> [!NOTE]
> Voor deze functie is een licentie vereist.

## Hoe weet ik of ik SharePoint, SuperOffice WebTools gebruik of niet?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Een nieuw document maken met SharePoint-documenten

1. Klik op **Nieuw** > **Document** op de bovenste balk.

2. [Typ de gewenste informatie in de verschillende velden.][2]

3. Klik op de knop **Maken** om het nieuwe document te maken op basis van de geselecteerde documentsjabloon. Het document wordt gemaakt in SharePoint en geopend in een nieuw tabblad met de online-tekstbewerkingstoepassing (Office Online).

    Als u uw bewerkingsprogramma op uw bureaublad wilt gebruiken, kiest u **Openen in desktop-app** van Office Online.

4. Typ de inhoud van het document.

5. Sluit het tabblad of uw bureaublad-app. Het document wordt automatisch opgeslagen in SharePoint.

## Een nieuw document maken zonder SuperOffice Web Tools

Als u SuperOffice Web Tools niet hebt geïnstalleerd, moet u documenten handmatig downloaden om ze te bewerken. Daarna moet u de bewerkte documenten uploaden naar de centrale server.

> [!NOTE]
> In deze procedure wordt beschreven hoe u nieuwe documenten maakt als u een bureaubladtoepassing voor tekstbewerking gebruikt. Het werkelijke proces kan enigszins anders zijn als u een online tekstbewerkingsprogramma (zoals Microsoft 365) en een documentbibliotheek (zoals SharePoint) gebruikt.

1. Klik op **Nieuw** > **Document** op de bovenste balk.

2. [Typ de gewenste informatie in de verschillende velden.][2]

    ![Create document from template -screenshot][img3]

3. Klik op de knop **Maken** om het nieuwe document te maken op basis van de geselecteerde documentsjabloon. Het document wordt op de server gemaakt.

4. Klik op **Open** en **Bewerken**.

5. Selecteer in het dialoogvenster **Bestand downloaden** een van de volgende knoppen:

    * **Openen**: wanneer u op **Openen** klikt, wordt het document geopend in de tekstbewerkingstoepassing. Typ de inhoud van het document en selecteer **Bestand** > **Opslaan als** om het op te slaan op de gewenste locatie op uw computer.

    * **Opslaan**: wanneer u op **Opslaan** klikt, wordt het dialoogvenster **Opslaan als** weergegeven. Geef op waar op de computer u het bestand wilt opslaan. Vervolgens klikt u op **Opslaan** om het downloaden te starten. Klik op **Sluiten** wanneer het downloaden is voltooid. Open Windows Verkenner en blader naar het document dat u zojuist hebt opgeslagen. Open het document, voer de gewenste tekst in en sla het document op.

    > [!NOTE]
    > Wijzigingen in het document worden niet automatisch opgeslagen in SuperOffice. Als u dit gedrag wilt, raden we aan om [SuperOffice WebTools][3] te installeren.

6. Sluit het tekstbewerkingsprogramma.

7. Ga naar het scherm Document.

    > [!NOTE]
    > Als ![pictogram][img1] **Voltooid** is ingeschakeld in het documentscherm, zijn de uploadopties uitgeschakeld. Verwijder in dat geval het vinkje **Voltooid**.

8. Klik op de koppeling om het document te uploaden of gebruik Slepen en neerzetten om het document vanuit Windows Verkenner naar het dialoogvenster **Document** te verplaatsen.

    ![Een nieuw document maken -screenshot][img2]

9. Sluit het dialoogvenster **Document** door te klikken op **Opslaan**.

## Een nieuw document maken met SuperOffice Web Tools

Met SuperOffice CRMkunt u inloggen vanaf elke computer met een browser, maar uw documenten worden vervolgens opgeslagen op de centrale server. Downloaden en uploaden van documenten wordt automatisch afgehandeld door SuperOffice Web Tools.

1. Klik op **Nieuw** > **Document** op de bovenste balk.

2. [Typ de gewenste informatie in de verschillende velden.][2]

3. Klik op de knop **Maken** om het nieuwe document te maken op basis van de geselecteerde documentsjabloon. Het dialoogvenster **Document** wordt automatisch gesloten en het document wordt geopend in het standaard tekstbewerkingsprogramma.

4. Typ de inhoud van uw document.

5. Sla het document op en sluit de tekstbewerkingstoepassing. Het document wordt opgeslagen.

## Verwante onderwerpen

* [WebTools][3]
* [E-mailbijlagen verzenden vanuit SuperOffice][4]
* [Documentsjablonen beheren in Instellingen en onderhoud][5]

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
