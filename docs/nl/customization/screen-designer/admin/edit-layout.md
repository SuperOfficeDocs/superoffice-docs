---
uid: help-nl-screen-designer-edit-layout
title: Opmaak hoofdkaarten bewerken
description: In deze handleiding staat u hoe u een opmaak bewerkt.
keywords: schermopmaak, opmaak bewerken, opmaak wijzigen, opmaak verwijderen, Terugzetten naar fabrieksinstellingen
author: Bergfrid Dias
date: 10.09.2025
version: 10.3.10
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: nl
index: true
redirect_from:
  - /nl/ui/screen-designer/learn/elements
  - /nl/customization/screen-designer/edit-layout
---

# Opmaak van een kaart bewerken

[!include[Vereiste](../../../includes/req-dev-tools.md)]

Wanneer u een [nieuwe opmaak heeft gemaakt][6], is het tijd om deze aan te passen. Personaliseer het opmaak voor de hoofdkaarten en archieven zodat het voldoet aan de informatiebehoeften van uw organisatie.

## Overwegingen

Voordat u een opmaak aanpast, moet u bepalen wie de beoogde gebruikers zijn.

* Wat hebben zij direct binnen handbereik nodig?
* Hebben zij alle standaardvelden en tabbladen nodig, of moet u iets verwijderen?
* Hebben ze extra tabbladen nodig?
* Wat is de logische volgorde van de velden?

> [!NOTE]
> U kunt het **standaardopmaak** bewerken, maar u kunt de standaardinstellingen voor de besturingselementen niet bewerken en u kunt het opmaak niet opnieuw toewijzen aan een gebruikersgroep.

Bekijk deze video en ontdek hoe u de schermontwerper kunt gebruiken om uw schermen te configureren in SuperOffice CRM of volg de stapsgewijze handleiding hieronder (duur van de video - 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## <a id="edit"></a>Kaartopmaak bewerken

1. Open de Schermontwerper.
2. Selecteer bovenaan een scherm of dialoogvenster dat u wilt aanpassen.
3. Selecteer een opmaak in de lijst aan de linkerkant.
4. Klik onder de voorbeeldweergave op **Opmaak bewerken**.
5. Werk door de tabbladen van het scherm in het scherm **Kaartopmaak bewerken**.

    * [Een veld toevoegen, bewerken, verplaatsen of verwijderen][1]
    * [Een koppeling of knop toevoegen][2]
    * [Informatie organiseren in logische groepen][4]
    * [Een tabblad toevoegen, verwijderen of herstellen][3]
    * [Het aantal kolommen in een tabblad wijzigen][5]<a id="columns"></a>

![Verwijder, voeg toe en verplaats de verschillende velden in de opmaak -screenshot][img3]

## <a id="save"></a>Opslaan, publiceren of annuleren

Nadat u een opmaak heeft bewerkt, klikt u op een van de volgende knoppen:

| Knop | Beschrijving |
|---|---|
| Concept opslaan | Slaat een niet-gepubliceerde versie van het opmaak op, die u later kunt hervatten met bewerken of laten beoordelen door iemand anders. |
| Opslaan + Publiceren | Past het opmaak toe op de geselecteerde gebruikersgroepen **of** verkoop-/project-/verzoek-/vervolgactiviteitstypen. |
| Annuleren | Verwerpt alle wijzigingen. |

## <a id="undo-changes"></a>Wijzigingen ongedaan maken

Als u moet terugkeren naar een eerdere versie van het scherm, kunt u de volgende opties openen vanuit de knop **Taak**:

* **Herstellen naar fabrieksinstellingen**: Deze optie verwerpt alle wijzigingen en herstelt het opmaak naar de standaardversie die door SuperOffice wordt geleverd.

* **Tabbladen herstellen**: Deze optie herstelt alle eerder verwijderde tabbladen.

* **Concept verwerpen**: Deze optie verwerpt alle niet-opgeslagen wijzigingen en herstelt het opmaak naar de meest recent gepubliceerde versie.

## <a id="delete"></a>Opmaak verwijderen

Wanneer een opmaak op basis van een gebruikersgroep wordt verwijderd, zien de gebruikers in die groep het standaard (systeem) opmaak.

Om een opmaak te verwijderen:

1. Selecteer het opmaak in de **Opmak**-lijst.
1. Klik op **Verwijderen**.

## Gerelateerde inhoud

* [Werken met sectietabbladen (archieven)][7]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: add-button.md
[3]: working-with-tabs.md
[4]: working-with-tabs.md#label
[5]: working-with-tabs.md#columns
[6]: add-layout.md
[7]: working-with-archives.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/customization/edit-the-screen-layout-of-companies-and-contacts.png
