---
uid: help-nl-document-create
title: Nieuw document maken
description: Maak een nieuw document rechtstreeks in SuperOffice CRM of upload bestaande documenten, om ervoor te zorgen dat u en uw collega's altijd toegang hebben tot de nieuwste documenten en versies. Deze handleiding laat u zien hoe u beide kunt doen.
keywords: document
author: Bergfrid Dias
date: 07.12.2024
topic: howto
language: nl
audience: person
audience_tooltip: SuperOffice CRM
---

# Nieuwe documenten maken

> [!TIP]
> U hebt het document al? ZIe [Documenten uploaden](#upload).

Volg de onderstaande instructies, afhankelijk van hoe documenten worden beheerd in uw SuperOffice-installatie.

## Hoe weet ik of ik SharePoint, SuperOffice WebTools gebruik of niet?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

<!-- markdownlint-disable-file MD051 -->
## Stappen

### [Met SuperOffice Web Tools](#tab/webtools)

Met SuperOffice CRMkunt u inloggen vanaf elke computer met een browser, maar uw documenten worden vervolgens opgeslagen op de centrale server. Downloaden en uploaden van documenten wordt automatisch afgehandeld door SuperOffice Web Tools.

1. Klik op **Nieuw** > **Document** op de bovenste balk.

2. [Typ de gewenste informatie in de verschillende velden.](#fields)

3. Klik op de knop **Maken** om het nieuwe document te maken op basis van de geselecteerde [documentsjabloon][5]. Het dialoogvenster **Document** wordt automatisch gesloten en het document wordt geopend in het standaard tekstbewerkingsprogramma.

4. Typ de inhoud van uw document.

5. Sla het document op en sluit de tekstbewerkingstoepassing. Het document wordt opgeslagen.

### [Met SharePoint-documenten](#tab/sharepoint)

**Voor deze functie is een licentie vereist.**

1. Klik op **Nieuw** > **Document** op de bovenste balk.

2. [Typ de gewenste informatie in de verschillende velden.](#fields)

3. Klik op de knop **Maken** om het nieuwe document te maken op basis van de geselecteerde [documentsjabloon][5]. Het document wordt gemaakt in SharePoint en geopend in een nieuw tabblad met de online-tekstbewerkingstoepassing (Office Online).

    Als u uw bewerkingsprogramma op uw bureaublad wilt gebruiken, kiest u **Openen in desktop-app** van Office Online.

4. Typ de inhoud van het document.

5. Sluit het tabblad of uw bureaublad-app. Het document wordt automatisch opgeslagen in SharePoint.

### [Zonder SuperOffice Web Tools](#tab/no-webtools)

Als u SuperOffice Web Tools niet hebt geïnstalleerd, moet u documenten handmatig downloaden om ze te bewerken. Daarna moet u de bewerkte documenten uploaden naar de centrale server.

> [!NOTE]
> In deze procedure wordt beschreven hoe u nieuwe documenten maakt als u een bureaubladtoepassing voor tekstbewerking gebruikt. Het werkelijke proces kan enigszins anders zijn als u een online tekstbewerkingsprogramma (zoals Microsoft 365) en een documentbibliotheek (zoals SharePoint) gebruikt.

1. Klik op **Nieuw** > **Document** op de bovenste balk.

2. [Typ de gewenste informatie in de verschillende velden.](#fields)

3. Klik op de knop **Maken** om het nieuwe document te maken op basis van de geselecteerde [documentsjabloon][5]. Het document wordt op de server gemaakt.

4. Klik op **Open** en **Bewerken**.

5. Selecteer in het dialoogvenster **Bestand downloaden** een van de volgende knoppen:

    * **Openen**: wanneer u op **Openen** klikt, wordt het document geopend in de tekstbewerkingstoepassing. Typ de inhoud van het document en selecteer **Bestand** > **Opslaan als** om het op te slaan op de gewenste locatie op uw computer.

    * **Opslaan**: wanneer u op **Opslaan** klikt, wordt het dialoogvenster **Opslaan als** weergegeven. Geef op waar op de computer u het bestand wilt opslaan. Vervolgens klikt u op **Opslaan** om het downloaden te starten. Klik op **Sluiten** wanneer het downloaden is voltooid. Open Windows Verkenner en blader naar het document dat u zojuist hebt opgeslagen. Open het document, voer de gewenste tekst in en sla het document op.

    > [!NOTE]
    > Wijzigingen in het document worden niet automatisch opgeslagen in SuperOffice. Als u dit gedrag wilt, raden we aan om [SuperOffice WebTools][7] te installeren.

6. Sluit het tekstbewerkingsprogramma.

7. Ga naar het scherm Document.

    > [!NOTE]
    > Als ![pictogram][img1] **Voltooid** is ingeschakeld in het dialoogvenster Document, zijn de uploadopties uitgeschakeld. Verwijder in dat geval het vinkje **Voltooid**.

8. Klik op de koppeling om het document te uploaden of gebruik Slepen en neerzetten om het document vanuit Windows Verkenner naar het dialoogvenster **Document** te verplaatsen.

    ![Een nieuw document maken -screenshot][img2]

9. Sluit het dialoogvenster **Document** door te klikken op **Opslaan**.

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

## <a id="upload" />Documenten uploaden

1. Klik op **Nieuw** > **Document** op de bovenste balk.

2. Gebruik slepen en neerzetten om het document te verplaatsen vanuit Windows Explorer naar het dialoogvenster **Document**.

3. (optioneel) Klik op ![pictogram][img4] in de rechterbovenhoek om het document in te stellen als **Voltooid** ![pictogram][img1].

4. [Typ de gewenste informatie in de verschillende velden.](#fields)

5. Klik op de knop **Maken** om een nieuw document te maken in SuperOffice CRM. Het document wordt toegevoegd aan het sectietabblad **Activiteiten**.

## Verwante onderwerpen

* [Documenten bewerken][1]
* [Documenten aan/afmelden][3]
* [Een e-mail archiveren][8]
* [E-mailbijlagen verzenden vanuit SuperOffice][4]
* [Documentsjablonen beheren in Instellingen en onderhoud][6]

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
