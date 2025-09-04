---
uid: help-nl-document-create
title: Nieuw document maken
description: Maak een nieuw document rechtstreeks in SuperOffice CRM of upload bestaande documenten, om ervoor te zorgen dat u en uw collega's altijd toegang hebben tot de nieuwste documenten en versies. Deze handleiding laat u zien hoe u beide kunt doen.
keywords: document
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from:
  - /nl/document/learn/upload
  - /nl/document/learn/screen/index
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
    > Als **Voltooid** is ingeschakeld in het dialoogvenster Document, zijn de uploadopties uitgeschakeld. Verwijder in dat geval het vinkje **Voltooid**.

8. Klik op de koppeling om het document te uploaden of gebruik Slepen en neerzetten om het document vanuit Windows Verkenner naar het dialoogvenster **Document** te verplaatsen.

9. Sluit het dialoogvenster **Document** door te klikken op **Opslaan**.

***

## <a id="fields"></a>Hoe informatie in te voeren

> [!NOTE]
> Veel velden hebben een lijst met vooraf gedefinieerde waarden waaruit u kunt kiezen. Klik op <i class="ph ph-caret-down" aria-label="Chevron"></i> om de lijst uit te vouwen. Selecteer vervolgens een waarde voor dat veld. Typ alternatief in het veld om te zoeken naar een specifieke waarde, zoals een bedrijfsnaam.

![Document maken vanuit sjabloon (Nieuw) -screenshot][img4]

**Stappen:**

1. Kies een [documentsjabloon][5]. Selecteer een taal voor de sjabloon. Deze optie is alleen beschikbaar als de geselecteerde sjabloon vertaalde versies bevat.

1. Selecteer eventueel een bedrijf of contactpersoon waarop het document betrekking heeft.

1. Selecteer eventueel een project en/of verkoop om het aan het document te koppelen. U kunt elk project/verkoop kiezen, ongeacht welk bedrijf u eerder heeft gekozen.

1. Voer een documenttitel in het veld **Onderwerp** in. Deze tekst wordt weergegeven in sectietabs en in andere documentenlijsten.

1. De **datum** van vandaag is standaard ingesteld. Wijzig eventueel de aanmaakdatum (klik om de datumkiezer te openen).

    > [!NOTE]
    > U kunt deze datum niet meer wijzigen nadat u op de knop **Opslaan** heeft geklikt (het veld wordt alleen-lezen).

1. Voer referenties in:

    * **Onze ref.:** Voer uw eigen referentie in. De standaardwaarde voor elke sjabloon wordt gedefinieerd in Instellingen en onderhoud, maar u kunt de inhoud van dit veld ook bewerken.
    * **Uw ref.:** Voer de referentie van de geadresseerde in hun communicatie in.

### Andere instellingen (optioneel)

* Voer in het tabblad **Details** een beschrijving van het document (of trefwoorden) in om vrijetextzoekopdrachten te vergemakkelijken.

* Klik in het tabblad **Links** op **Link toevoegen** om [het document aan andere activiteiten te koppelen][9].

* Stel in het tabblad **Meer** alle [gebruikersgedefinieerde velden][10] in die zijn geconfigureerd in Instellingen en onderhoud.

## <a id="upload"></a>Documenten uploaden

1. Klik op **Nieuw** > **Document** op de bovenste balk.

2. Gebruik slepen en neerzetten om het document te verplaatsen vanuit Windows Explorer naar het dialoogvenster **Document**.

3. (optioneel) Selecteer het selectievakje in de voettekst om het document als voltooid markeren.

4. [Typ de gewenste informatie in de verschillende velden.](#fields)

5. Klik op de knop **Maken** om een nieuw document te maken in SuperOffice CRM. Het document wordt toegevoegd aan het sectietabblad **Activiteiten**.

## Gerelateerde inhoud

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
[7]: ../../../../integrations/webtools/install.md
[8]: ../../../../integrations/mail-link/archive.md
[9]: ../../learn/basics/links.md
[10]: ../../custom-objects/learn/udef.md

<!-- Referenced images -->
[img4]: ../../../media/loc/en/document/create-document.png
