---
uid: help-nl-contact-create
title: Nieuwe persoon maken
description: Hoe een persoon aanmaken in SuperOffice CRM.
keywords: persoon maken, contact toevoegen, interesses, tabblad interesses, contactafbeelding, voorkeurstaal, rechtsgrondslag, persoon, persoon
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Nieuwe persoon maken

U kunt op meerdere manieren een persoon toevoegen aan SuperOffice CRM:

* Vanuit de **bovenste balk** of het **scherm Bedrijf** (zie stappen hieronder).
* [Scan een visitekaartje][1] met de SuperOffice Mobile CRM-app.
* [Bulksgewijs personen importeren][2] (vereist beheerdersrechten).

## Stappen

1. **Open het scherm Persoon:**

    * Klik op **Nieuw** in de **bovenste balk** en selecteer **Persoon**.
    * Of ga naar het gewenste bedrijf in het **scherm Bedrijf**, selecteer het sectietabblad **Personen** en klik op de knop **Toevoegen**.

1. **Voer de essentiële contactgegevens in:**

    * Vul de **Voornaam** en/of **Achternaam** in (verplicht: minstens één moet ingevuld zijn).
    * Optioneel: Kies een aanhef (***Dhr./Mw.***).
    * Selecteer het **Bedrijf**:
      * Begin te typen om een bedrijf te zoeken of kies **(Geen selectie)** als de persoon niet aan een bedrijf is gekoppeld.
    * Optioneel: Voeg een **persoonafbeelding** toe door een afbeeldingsbestand naar het afbeeldingsveld te slepen of door met de rechtermuisknop een afbeelding te uploaden.

    ![Lege persoonskaart met de verplichte velden Voornaam en Achternaam gemarkeerd en optionele velden zoals Functie en Bedrijf. -screenshot][img1]

1. Vul de velden in het **tabblad Persoon** in.

    * Vul het veld **Land** in. Dit past automatisch het adresformaat voor dat land aan. Het standaardland is het land dat voor het bedrijf is geregistreerd.
    * Vul eventuele extra velden in, zoals **Mobiel** en **E-mail**.

1. Voeg aanvullende informatie toe op het **tabblad Details** (optioneel):

    * Voer belangrijke details in zoals **Functie**, **Geboortedatum** en **Voorkeurstaal**.
    * Voeg contact-specifieke communicatiedetails toe: **Website**, **Chat** en **Internettelefoon** (bijvoorbeeld Skype of Microsoft Teams).
    * Indien van toepassing, stel de **Serviceprioriteit** in en selecteer een **Onze servicemedewerker** (vereist een SuperOffice Service- of Klantencentrum-licentie).

    ![Tabblad Details met aanvullende velden -screenshot][img2]

1. Ga naar het **tabblad Interesses** om interesses en abonnementen in te stellen:

    * Vink de relevante interesses aan (deze worden beheerd in Instellingen en onderhoud).
    * Configureer **E-marketing/abonnementen** voor wettelijk toestemmingsbeheer bij e-mailcampagnes.

1. **Controleer privacy-instellingen:**

    * Klik onderaan de persoonskaart op **Rechtsgrondslag** om de [AVG-toestemming te bekijken of bij te werken][7] en privacygegevens te beheren. Klik op **Sluiten** wanneer u klaar bent.

1. **Markeren als voormalige werknemer** (optioneel):

    * Vink **Voormalige werknemer** aan als de persoon het bedrijf heeft verlaten. Voormalige werknemers worden niet weergegeven in contactlijsten of projecten.

1. Klik op **Opslaan** om de contactgegevens op te slaan.

De persoon wordt nu opgeslagen in de database en weergegeven op de persoonskaart. Als de persoon aan een bedrijf is gekoppeld, wordt deze weergegeven in het sectietabblad **Personen** in het scherm Bedrijf.

<!-- markdownlint-disable-file MD051 -->
## <a id="fields"></a>Belangrijke velden uitgelegd

De volgende velden zijn beschikbaar op de persoonskaart. Sommige worden automatisch ingevuld, terwijl andere handmatig moeten worden ingevoerd.

> [!NOTE]
> De velden en lay-out kunnen variëren op basis van [schermontwerp][9]-instellingen en andere UI-aanpassingen.

### [Tabblad Persoon](#tab/contacts)

**Basisgegevens:**

* **Voornaam** / **Achternaam**: Minstens één van deze velden moet worden ingevuld (verplicht).
* **Aanhef**: Optioneel. Kies **Dhr./Mw.** op basis van de voorkeur van de persoon.
* **Functie**: Voer de functie of het beroep van de persoon in (functie-omschrijving op visitekaartje of positie).

**Contactgegevens:**

* **E-mail**: Voeg meerdere e-mailadressen toe met beschrijvingen, zoals *Werk* of *Privé*.
* **Mobiel** / **Direct telefoonnummer**: Voeg meerdere telefoonnummers toe met labels, zoals *Mobiel* of *Werk*.
  * Druk op **TAB** of klik buiten de tabel om invoer op te slaan.

**Adresgegevens:**

* **Privéadres**: Vul de adresgegevens van de persoon in.
  * Het adresformaat wordt automatisch aangepast op basis van het veld **Land**.
* **Land**: Geeft het land van de persoon aan. Standaard wordt het land gebruikt dat is gekoppeld aan het bedrijf.
* **Gebruiken als postadres**: Vink dit veld aan als u wilt dat post naar het privé-adres van de persoon wordt gestuurd in plaats van naar het bedrijfsadres.

**Overgenomen velden:**

* **Onze persoon**: Standaard wordt uw naam automatisch ingevuld. Klik op de pijl om een andere medewerker uit uw organisatie te kiezen.
* **Categorie**: Selecteer een categorie uit een vooraf gedefinieerde lijst. Als de persoon aan een bedrijf is gekoppeld, wordt de bedrijfscategorie standaard gebruikt.
* **Branche**: Selecteer de relevante bedrijfstak. Dit veld neemt standaard de bedrijfstak van het gekoppelde bedrijf over.

**Systeemvelden:**

* **Nummer**: Wordt automatisch gegenereerd als het is geconfigureerd in **Instellingen en onderhoud**. U kunt dit veld handmatig aanpassen indien nodig.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Tabblad Details](#tab/details)

**Persoonlijke informatie:**

* **Positie:** Selecteer de functie van de persoon uit een vooraf gedefinieerde lijst (beheerd in **Instellingen en onderhoud**).
* **Geboortedatum:** Vul de geboortedatum van de persoon in.

**Communicatiegegevens:**

* **Website:** Voer een URL in voor de website van de persoon, LinkedIn-, Facebook- of andere sociale media-pagina's. Voeg een titel toe voor duidelijkheid.
* **Chat**: Voeg adressen toe voor chatapplicaties (zoals Microsoft Teams of Google Chat). Selecteer een serviceprovider uit de lijst.
* **Internettelefoon:** Voeg een VOIP-adres toe, zoals Skype of een andere internetgebaseerde telefoniedienst.
* **Direct fax:** Voer het faxnummer van de persoon in.

**Service-specifieke velden** *(vereist een SuperOffice Service- of Klantencentrum-licentie)*

* **Voorkeurstaal:** Selecteer de voorkeurstaal van de persoon voor alle antwoordsjablonen.
* **Ondersteuningsprioriteit:** Stel de prioriteit in voor nieuwe servicetickets (bijvoorbeeld Laag, Normaal, Hoog of aangepast). Indien niet ingesteld, wordt de standaard prioriteit van het bedrijf gebruikt.
* **Onze ondersteuningsmedewerker:** Kies een medewerker die verantwoordelijk is voor de aanvragen van deze persoon.

**Privévelden:**

* **Privé**: Voer persoonlijke telefoonnummers of contactgegevens in die niet aan het bedrijf zijn gekoppeld.

### [Tabblad Meer](#tab/more)

Voer eventuele [aangepaste velden][12] in die specifiek zijn voor uw CRM-configuratie.

### [Tabblad Interesses](#tab/interests)

**Interesses en abonnementen:**

* **Interesses**: Selecteer de interesses van de persoon door de relevante vakjes aan te vinken. Interesses worden gebruikt om gerichte selecties te maken, bijvoorbeeld voor mailings of campagnes.

  * Interesses worden vooraf gedefinieerd in **Instellingen en onderhoud**.
  * Een punt verschijnt naast de naam van het **tabblad Interesses** wanneer een of meer interesses zijn geselecteerd.

* **E-marketing/abonnementen**: Beheer de toestemming voor het verzenden van e-mailcampagnes.

  * Als de persoon toestemming heeft gegeven, activeer dan de optie **E-marketing** om de wettelijke toestemming voor mailings te bevestigen. Dit stelt de rechtsgrondslag automatisch in op **Rechtmatig belang**.
  * Geef de abonnementsopties op om te bepalen welke soorten e-marketing de persoon wil ontvangen.
  * Abonnementen kunnen ook door de persoon zelf worden beheerd via een klantenportal.

### [Tabblad Opmerking](#tab/note)

[Voeg vrije tekstnotities toe][5] over de persoon.

***

## <a id="interests-tab"></a>Interesses toevoegen

Interesses zijn handig voor het maken van gerichte selecties, zoals marketingcampagnes voor specifieke doelgroepen. Bijvoorbeeld, als u *referentieaccount* als interesse definieert, kunt u snel een selectie maken van alle referentieaccounts.

1. Ga naar het tabblad **Interesses**.

1. In de bewerkingsmodus vinkt u de relevante interesses aan. Beschikbare opties worden beheerd in **Instellingen en onderhoud**.

1. Wanneer u een of meer interesses selecteert, verschijnt er een punt naast de tabbladnaam.

1. Klik op **Opslaan** om de wijzigingen op te slaan.

## Tips

* U kunt meerdere telefoonnummers, e-mailadressen en andere contactgegevens toevoegen met beschrijvingen (bijvoorbeeld *Centrale*).

    Wanneer u op het e-mailadres van de persoon klikt in het tabblad **Persoon**, verschijnt een lijst waarin u een adres kunt kiezen. Er wordt vervolgens een leeg e-mailbericht geopend met het geselecteerde adres in het veld **Aan**.

* Gebruik het telefoonicoon om direct te bellen als uw systeem hiervoor is geconfigureerd.

* Als de persoon deel uitmaakt van een bedrijf, worden velden zoals **Categorie**, **Branche** en **Onze persoon** overgenomen van het bedrijf en kunnen deze niet worden bewerkt.

* Ga naar het [sectietabblad Relaties][8] om deze persoon te koppelen aan andere bedrijven of contactpersonen.

## Gerelateerde inhoud

* [Contactpersoon toevoegen als favoriet][4]
* [Scan een visitekaartje][1]

<!-- Referenced links -->
[1]: ../../../en/mobile/superoffice-mobile/contact/scan-business-card.md
[2]: ../../admin/import/index.md
[4]: ../../learn/basics/fav.md
[7]: ../../security/privacy/learn/edit-legal-base.md
[8]: ../../learn/basics/relations.md
[5]: ../../learn/basics/notes.md
[9]: ../../customization/screen-designer/admin/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/new-contact.png
[img2]: ../../../media/loc/en/contact/contact-details.png
