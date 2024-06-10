---
uid: help-nl-screen-designer-edit-layout
title: Opmaak hoofdkaarten bewerken
description: In deze handleiding staat u hoe u een opmaak bewerkt.
keywords: schermontwerper, opmaak, veld, tabbladindeling
author: Bergfrid Dias
so.date: 06.11.2024
so.version: 10.3.7
so.topic: howto
language: nl
so.audience: settings
so.audience.tooltip: Settings and maintenance
---

# Opmaak bewerken - Hoofdkaarten

Wanneer u een [nieuwe opmaak hebt gemaakt][4], is het tijd om deze aan te passen aan de behoeften van de toegewezen gebruikersgroep(en). Als u een opmaak aanpast voor het verkoopteam, moet u een duidelijk plan hebben en weten wat de behoeften van het team zijn met betrekking tot de opmaak en de indeling van de tabbladen, velden, elementen en kolommen op de hoofdkaart. Welke informatie moet het eerst en gemakkelijkst te vinden zijn? Hebben ze alle velden en tabbladen nodig? Wat is de logische volgorde van de velden?

Personaliseer de opmaak van de hoofdkaarten en archieven om aan te sluiten bij de informatiebehoeften binnen uw organisatie. Wanneer u de opmaak van een hoofdkaart bewerkt, kunt u velden toevoegen en verwijderen of de volgorde aanpassen aan de behoeften van uw team. Eerst moet u weten welke informatie het belangrijkst is voor het team.

Bekijk deze video en ontdek hoe u de schermontwerper kunt gebruiken om uw schermen te configureren in SuperOffice CRM of volg de stapsgewijze handleiding hieronder (duur van de video - 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## Stappen

<!-- markdownlint-disable MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->
3. Klik op **Hoofdkaarten**.

4. Selecteer een opmaak in de lijst aan de linkerkant.

5. Klik onder de voorbeeldweergave op **Opmaak bewerken**.

6. Bewerk in het venster **Kaartopmaak bewerken** de opmaak zoals hieronder wordt beschreven.

7. Klik, nadat dit klaar is, op een van de volgende knoppen:

    * **Concept opslaan**: klik op deze knop als de opmaak nog niet is voltooid.
    * **Opslaan + Publiceren**: klik op deze knop om de opmaak naar de geselecteerde gebruikersgroepen te publiceren.
    * **Annuleren**: klik op deze knop om [alle wijzigingen te verwijderen](#undo-changes).
<!-- markdownlint-restore -->

## Bestaande velden in de opmaak bewerken

1. Selecteer het tabblad dat u wilt bewerken.

2. Bewerken van bestaande velden:

    * Verplaats velden door op het ![pictogram][img4] links van een veldlabel te klikken op en het veld naar een nieuwe positie te slepen. Zie [Velden](#fields) om een nieuw veld toe te voegen.

    * Verwijder velden door de muisaanwijzer boven een veld te houden en te klikken op het ![pictogram][img2]. Verwijderde velden kunnen opnieuw worden toegevoegd vanuit de sectie **Velden**. Verplichte velden kunnen niet worden verwijderd en de knop **Verwijderen** wordt niet weergegeven voor dergelijke velden. Zie [Velden](#fields).

    * Bewerk de opmaak van velden (zoals lettertype-indeling) en andere instellingen door op het veld te klikken. De sectie **Instellingen** wordt links in het venster geopend. Zie [Instellingen](#settings).

3. [Wijzig het aantal kolommen op een tabblad](#columns), vanuit de sectie **Tabbladindeling**.

4. Sla de wijzigingen op zoals hierboven beschreven.

![Verwijderen, toevoegen en verplaatsen van de verschillende velden in de lay-out -screenshot][img3]

## Nieuwe inhoud toevoegen aan een opmaak

1. Selecteer het tabblad dat u wilt bewerken of klik op ![pictogram][img5] **Toevoegen** om een [nieuw tabblad toe te voegen](#tabs).

2. Bewerk de opmaak door een van de volgende secties te selecteren:

    * **Velden**: sleep [velden](#fields) uit de lijst naar de opmaak. Velden kunnen in de kolommen en in de kop- en voettekst worden geplaatst.

    * **Elementen**: sleep verschillende elementen zoals labels, scheidingslijnen, koppelingen en knoppen naar de opmaak.

    * **Instellingen**: klik op een veld of element in de opmaak om de relevante instellingen te bewerken. De beschikbare instellingen kunnen variëren afhankelijk van het geselecteerde object. Zie [Instellingen](#settings).

    * **Tabbladindeling**: [selecteer hoeveel kolommen u op een tabblad wilt weergeven.](#columns)

3. Na aanpassen van de schermopmaak, klikt u op een van de volgende knoppen:

    * **Concept opslaan**: klik op deze knop als de opmaak nog niet is voltooid.
    * **Opslaan + Publiceren**: klik op deze knop om de opmaak naar de geselecteerde gebruikersgroepen te publiceren.
    * **Annuleren**: klik op deze knop om alle wijzigingen te verwijderen.

Vakjes met gestreepte lijnen in de opmaak geven aan waar u een veld kunt plaatsen:

![Vakjes met gestreepte lijnen -screenshot][img6]

Hieronder vindt u meer gedetailleerde beschrijvingen van de verschillende secties en functies.

## <a id="fields" />Velden

In de sectie **Velden** vindt u alle beschikbare gegevensvelden voor de geselecteerde schermopmaak. Gebruik de filterfunctie om specifieke velden te vinden.

* Sleep een veld uit de lijst naar een gesorteerd gebied op het geselecteerde tabblad.
* Om ervoor te zorgen dat een veld altijd zichtbaar is, ongeacht welk tabblad is geselecteerd, plaatst u het veld in de kop- of voettekst.
* U kunt hetzelfde veld op meerdere locaties plaatsen in de schermopmaak, indien relevant.
* Verplaats velden door op het ![pictogram][img4] links van een veldlabel te klikken op en het veld naar een nieuwe positie te slepen. Als u een veld naar een ander tabblad wilt verplaatsen, sleept u het veld naar de koptekst van het tabblad om het tabblad te openen en plaatst u het veld vervolgens in het geopende tabblad.
* Verwijder velden door de muisaanwijzer boven een veld te houden en te klikken op het ![pictogram][img2]. Verplichte velden kunnen niet worden verwijderd en de knop **Verwijderen** wordt niet weergegeven voor dergelijke velden.

**Beperkingen:**

* Verplichte velden kunnen niet worden verwijderd. Dit wordt gedefinieerd in het scherm [Velden][3].
* Sommige tabbladen, zoals **ERP** en **Opmerking**, kunnen niet worden bewerkt, omdat ze specifieke functies hebben.

## Elementen

In de sectie **Elementen** kunt u verschillende niet-gegevenselementen toevoegen, zoals labels, scheidingslijnen, koppelingen en knoppen.

## <a id="settings"/>Instellingen

Maak velden beter zichtbaar door het lettertype te veranderen in vet gedrukte en grote tekst. Maak ruimte voor meer velden door een kleiner lettertype te gebruiken. Bespaar schermruimte door labels te verbergen.

Klik op een veld of element in de opmaak om de instellingen ervan te bewerken. De beschikbare instelling is afhankelijk van het type veld of element.

## <a id="columns"/>Tabbladindeling

Standaard heeft een tabblad 2 kolommen, maar u kunt 1-4 kolommen gebruiken, afhankelijk van wat u nodig hebt. Gebruikers met breedbeeldschermen geven misschien de voorkeur aan meer kolommen om meer gegevens te kunnen bekijken en sorteren.

**Beperkingen:**

* Als u van 2-4 kolommen naar 1 kolom wijzigt, worden alle velden naar 1 kolom verplaatst.
* Het gebruik van 4 kolommen kan de zichtbaarheid van sommige velden beïnvloeden. U kunt overwegen om de labels van sommige velden te verbergen (zie [Instellingen](#settings)).
* Sommige tabbladen, zoals **ERP** en **Opmerking**, hebben geen kolominstelling, omdat ze specifieke functies hebben.
* Als een gebruiker niet beschikt over de schermgrootte die nodig is om alle kolommen te laten passen, zijn deze op elkaar gestapeld.

## <a id="tabs" />Tabbladen

Voeg meer tabbladen toe voor extra velden of verwijder irrelevante tabbladen.

**Om een code te verwijderen:**

1. Selecteer het tabblad en klik op **Taak** > **tabblad Verwijderen**.
2. Klik op **OK** in het dialoogvenster dat wordt weergegeven.

**U voegt als volgt een nieuw tabblad toe:**

1. Klik op ![pictogram][img5] **Toevoegen**. De sectie **Tabbladindeling** wordt naar de linkerkant geopend.
2. Vervang onder **Titel tabblad** de tekst **Nieuw tabblad** door de nieuwe naam voor het tabblad.
3. U kunt de naam van het tabblad ook in [andere talen][2] toevoegen door op ![pictogram][img1] te klikken.
4. Selecteer het aantal kolommen dat u in het nieuwe tabblad wilt gebruiken.

> [!TIP]
> Als u later de naam van het tabblad wilt wijzigen, selecteert u het tabblad en selecteert u **Tabbladindeling**.

**Beperkingen:**

* U kunt de naam van de standaardtabbladen niet wijzigen.
* U kunt een tabblad met verplichte velden niet verwijderen. Verplichte velden moeten eerst naar een ander tabblad worden verplaatst.
* Als er nog maar één tabblad resteert, kunt u dit niet verwijderen.

## <a id="undo-changes" />Wijzigingen ongedaan maken

Als u moet herstellen naar een eerdere versie van het scherm, kunt u de volgende opties openen via de knop **Taak**:

* **Herstellen naar fabrieksinstellingen**: met deze optie worden alle wijzigingen verwijderd en wordt de schermopmaak teruggezet naar de standaardopmaak van SuperOffice.
* **Concept verwijderen**: hiermee worden alle wijzigingen verwijderd en wordt de gepubliceerde versie van de schermopmaak teruggezet.

<!-- Referenced links -->
[2]: ../../../globalization-and-localization/learn/translate-fields.md
[3]: ../../../custom-objects/learn/udef.md
[4]: add-new-layout.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/az.png
[img2]: ../../../../../common/icons/delete-circle-red.png
[img4]: ../../../../media/icons/criteria-move.png
[img5]: ../../../../../common/icons/add-icon.png
[img3]: ../../../../media/loc/en/ui/edit-the-screen-layout-of-companies-and-contacts.png
[img6]: ../../../../media/loc/en/ui/screendesigner-field-place.png
