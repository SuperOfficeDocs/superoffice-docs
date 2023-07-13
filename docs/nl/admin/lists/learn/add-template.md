---
uid: help-nl-add-template
title: Een sjabloon toevoegen
description: In deze handleiding leert u hoe u een nieuwe documentsjabloon toevoegt aan SuperOffice CRM.
author: SuperOffice RnD
so.date: 03.24.2023
keywords: document, sjabloon
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: nl
---

# Een documentsjabloon toevoegen

Om ervoor te zorgen dat iedereen in uw bedrijf dezelfde documenten gebruikt, kunt u uw eigen documentsjablonen voor verschillende bestandstypen maken en toevoegen. Gebruik de beschikbare sjabloonvariabelen om de invoer van klantgegevens in uw documenten te personaliseren en te automatiseren.

Als u nieuwe sjablonen maakt of een standaardsjabloon wijzigt en hebt opgeslagen onder een andere bestandsnaam, moet u de sjablonen koppelen met SuperOffice CRM, zodat het programma de sjablonen kan vinden wanneer u documenten opstelt in SuperOffice CRM. Nadat u de sjablonen hebt gekoppeld, kunt u heel eenvoudig brieven, faxen en andere documenten opstellen waarvoor u sjablonen hebt gemaakt met de [functie Document in SuperOffice CRM][5].

Bekijk deze video of volg de onderstaande stappen om te leren hoe u een documentsjabloon kunt toevoegen (videolengte - 2:30):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/FnhcmjP-TgE]

## Stappen

> [!TIP]
> Als u nieuwe sjablonen wilt toevoegen, kunt u eenvoudig een bestaand documentsjabloonbestand kopiëren en dit aanpassen aan uw wensen.

Sjablonen worden weergegeven als items in de lijst **Document - Sjabloon** en u koppelt een sjabloon met SuperOffice CRM door de sjabloon als een item in te voeren in de lijst.

[!include[Edit list item](includes/edit-list-item.md)] wanneer de items documentsjablonen zijn:

1. Typ de gewenste naam voor het item in het veld **Naam**.
2. Als u wilt kunt u aangeven waar de documentsjabloon wordt opgeslagen in de lijst **Sjabloon opslaan in**.
3. U hebt nu twee opties:

    * Een nieuwe documentsjabloon uploaden:

        1. Klik op **Een bestaande documentsjabloonbestand kopiëren**.
        2. Klik op de lijst **Sjabloon** kopiëren.
        3. Selecteer de gewenste sjabloon in de lijst.

    * Een bestaande sjabloon kopiëren in SuperOffice:

        1. Selecteer **Een nieuw documentsjabloon uploaden vanaf schijf**.
        2. Klik op de knop **Uploaden**.
        3. Klik op **Bestand uploaden** in het dialoogvenster **Bestand uploaden**.
        4. Selecteer het gewenste bestand en klik op **Openen**. De naam van het bestand wordt weergegeven in het dialoogvenster **Item in lijst bewerken**.

4. Klik op **Opslaan** in het dialoogvenster **Item in lijst bewerken**. Het dialoogvenster wordt bijgewerkt.
5. Optioneel: Bewerk indien nodig de sjabloonnaam en klik op **Bewerken** om het sjabloonbestand zelf te bewerken.
6. Geef de vereiste informatie op in de tabbladen **Details** en **Talen**.
7. Klik op **Opslaan**. De sjabloon wordt als een afzonderlijk item toegevoegd aan de lijst **Items**. Herhaal deze procedure voor alle sjablonen die u wilt toevoegen.

## Tabblad Details

Geef de volgende informatie op op het tabblad **Details**:

1. Geef in het veld **Richting** op of de sjabloon uitgaand of binnenkomend is door te klikken op de pijl ![pictogram][img1] en een keuze te maken in de keuzelijst.

2. Kies in het veld **Documenttype** de optie **Document** of **Fax** als sjabloontype.

3. In het veld **Document opgeslagen in** kunt u kiezen om het document op een andere plaats dan op de standaardplaats op te slaan.

4. Klik in het veld **Intentie** op ![pictogram][img1] en selecteer een van de vooraf gedefinieerde opties in de lijst. Deze items worden gebruikt samen met statuscontroles (vereist een licentie voor [Sales Intelligence][4]).

    > [!TIP]
    >U kunt nieuwe opties maken en toevoegen aan de vooraf gedefinieerde opties door deze toe te voegen aan de lijst **Vervolgactiviteit - Intentie** in Instellingen en onderhoud.

5. Lokaal: Schakel de optie **Publiceren** in als u in het Documentscherm wilt kunnen opgeven dat de desbetreffende documentsjabloon beschikbaar moet zijn voor externe gebruikers.

6. Lokaal: Schakel de optie **Opslaan in database** in om op te geven of documenten die u maakt met deze sjabloon, worden opgeslagen in de documentdatabase. Als u deze optie hebt ingeschakeld, wordt het document weergegeven op het sectietabblad **Activiteiten**. Zo niet, wordt het document niet weergegeven in SuperOffice CRM nadat u het hebt gemaakt en kan het niet via het programma worden geopend.

7. Schakel de optie **Type offertedocument** in als het document beschikbaar moet zijn als een offertesjabloon of orderbevestigingssjabloon. U selecteert het gewenste type offertedocument in de lijst hieronder.

    [!include[Link to quote template docs](includes/learn-quote-templates.md)]

8. Geef met behulp van de [sjabloonvariabelen][2] de standaardinstelling op voor het veld **Onze referentie (standaard)**, bijvoorbeeld *auteur* voor de voor- en achternaam van de afzender.

9. Typ zo nodig een beschrijving voor de sjabloon in het veld **Beschrijving**.

    > [!TIP]
    > U kunt de sjabloon rechtstreeks bewerken vanuit het dialoogvenster Item in lijst **bewerken** door te klikken op de knop **Bewerken**.

## Tabblad Talen

Hier kunt u vertaalde versies van de documentsjabloon toevoegen.

1. Klik op **Toev.**
2. Selecteer in het dialoogvenster **Item in lijst bewerken** de gewenste taal in de lijst **Taal toevoegen**.
3. Voeg het vertaalde documentsjabloon toe zoals hierboven beschreven.
4. Klik op **Toevoegen**. De taal is toegevoegd aan het tabblad **Talen**.
5. Herhaal de stappen hierboven om extra talen toe te voegen.

## Aanverwant

* [Hoe kan ik documentsjablonen uploaden en gebruiken?][3] \- Veelgestelde vragen
* [Bestaande sjabloon vervangen][1]

<!-- Referenced links -->
[2]: ../../../document/learn/template-variables.md
[5]: ../../../document/learn/index.md
[1]: replace-existing-template.md
[4]: ../../../sale/saint/learn/index.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-upload-and-use-document-templates-in-superoffice-crm/

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-down.png
