---
uid: help-nl-document-template-link
title: Een documentsjabloon toevoegen
description: In deze handleiding leert u hoe u een nieuwe documentsjabloon toevoegt aan SuperOffice CRM.
keywords: document, sjabloon, lijst
author: Bergfrid Dias
date: 07.12.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/admin/lists/learn/add-template
index: true
---

# Een documentsjabloon toevoegen

Als u nieuwe sjablonen maakt of een standaardsjabloon wijzigt en hebt opgeslagen onder een andere bestandsnaam, moet u de sjablonen koppelen met SuperOffice CRM, zodat het programma de sjablonen kan vinden wanneer u documenten opstelt in SuperOffice CRM.

Sjablonen worden weergegeven als items in de lijst **Document - Sjabloon** en u koppelt een sjabloon met SuperOffice CRM door de sjabloon als een item in te voeren in de lijst.

Bekijk deze video of volg de onderstaande stappen om te leren hoe u een documentsjabloon kunt toevoegen:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/FnhcmjP-TgE]

(videolengte - 2:30)

## Stappen

1. In Instellingen en onderhoud, klikken op de knop **Lijsten** in de Navigator (1).

1. Selecteer het tabblad **Items**, klik op de pijl en selecteer **Document - Sjabloon** (2).

1. Klik op **Toevoegen** (3).

    ![Documentsjabloon toevoegen -screenshot][img3]

1. Typ de gewenste naam voor het item in het veld **Naam** (1).

    ![Item in lijst bewerken -screenshot ][img2]

1. Als u wilt kunt u aangeven waar de documentsjabloon wordt opgeslagen in de lijst **Sjabloon opslaan in** (2).

1. U hebt nu twee opties:

    * Een nieuwe documentsjabloon uploaden:

        1. Klik op **Een bestaande documentsjabloonbestand kopiëren**.
        2. Klik op de lijst **Sjabloon** kopiëren.
        3. Selecteer de gewenste sjabloon in de lijst.

    * Een bestaande sjabloon kopiëren in SuperOffice:

        1. Selecteer **Een nieuw documentsjabloon uploaden vanaf schijf** (3).
        2. Klik op de knop **Uploaden**.
        3. Klik op **Bestand uploaden** in het dialoogvenster **Bestand uploaden**.
        4. Selecteer het gewenste bestand en klik op **Openen**. De naam van het bestand wordt weergegeven in het dialoogvenster **Item in lijst bewerken**.

1. Klik op **Opslaan** in het dialoogvenster **Item in lijst bewerken**. Het dialoogvenster wordt bijgewerkt.

1. Optioneel: Bewerk indien nodig de sjabloonnaam en klik op **Bewerken** om het sjabloonbestand zelf te bewerken.

1. Geef de vereiste informatie op in de tabbladen **Details** en **Talen**.

1. Klik op **Opslaan**. De sjabloon wordt als een afzonderlijk item toegevoegd aan de lijst **Items** en is nu beschikbaar in de CRM-client:

![New document -screenshot][img4]

![New document dialog -screenshot][img5]

> [!TIP]
> Herhaal deze procedure voor alle sjablonen die u wilt toevoegen.

## Tabblad Details

Geef de volgende informatie op op het tabblad **Details**:

1. Geef in het veld **Richting** op of de sjabloon uitgaand of binnenkomend is door te klikken op <i class="ph ph-caret-down" aria-label="Chevron"></i> en een keuze te maken in de keuzelijst.

2. Kies in het veld **Documenttype** de optie **Document** of **Fax** als sjabloontype.

3. In het veld **Document opgeslagen in** kunt u kiezen om het document op een andere plaats dan op de standaardplaats op te slaan.

4. Klik in het veld **Intentie** op <i class="ph ph-caret-down" aria-label="Chevron"></i> en selecteer een van de vooraf gedefinieerde opties in de lijst. Deze items worden gebruikt samen met statuscontroles (vereist een licentie voor [Sales Intelligence][4]).

    > [!TIP]
    > U kunt nieuwe opties maken en toevoegen aan de vooraf gedefinieerde opties door deze toe te voegen aan de lijst **Vervolgactiviteit - Intentie** in Instellingen en onderhoud.

5. Lokaal: Schakel de optie **Publiceren** in als u in het Dialoogvenster Document wilt kunnen opgeven dat de desbetreffende documentsjabloon beschikbaar moet zijn voor externe gebruikers.

6. Lokaal: Schakel de optie **Opslaan in database** in om op te geven of documenten die u maakt met deze sjabloon, worden opgeslagen in de documentdatabase. Als u deze optie hebt ingeschakeld, wordt het document weergegeven op het sectietabblad **Activiteiten**. Zo niet, wordt het document niet weergegeven in SuperOffice CRM nadat u het hebt gemaakt en kan het niet via het programma worden geopend.

7. Schakel de optie **Type offertedocument** in als het document beschikbaar moet zijn als een [offertesjabloon][2] of opdrachtbevestigingssjabloon. U selecteert het gewenste type offertedocument in de lijst hieronder.

    ![Item in lijst bewerken -screenshot][img8]

8. Geef met behulp van de sjabloonvariabelen de standaardinstelling op voor het veld **Onze referentie (standaard)** (5), bijvoorbeeld *auteur* voor de voor- en achternaam van de afzender, of {oref}

9. Typ zo nodig een beschrijving voor de sjabloon in het veld **Beschrijving**.

    > [!TIP]
    > U kunt de sjabloon rechtstreeks bewerken vanuit het dialoogvenster Item in lijst **bewerken** door te klikken op de knop **Bewerken**.

## Tabblad Talen

Hier kunt u vertaalde versies van de documentsjabloon toevoegen.

1. Klik op **Toevoegen**.

    ![Taal toevoegen -screenshot][img6]

1. Selecteer in het dialoogvenster **Item in lijst bewerken** de gewenste taal in de lijst **Taal toevoegen**.

1. Voeg het vertaalde documentsjabloon toe zoals hierboven beschreven.

    ![vertaalde documentsjabloon toevoegen -screenshot][img7]

1. Klik op **Toevoegen**. De taal is toegevoegd aan het tabblad **Talen**.

1. Herhaal de stappen hierboven om extra talen toe te voegen.

## Gerelateerde inhoud

* [Replace existing template][1]

<!-- Referenced links -->
[1]: update-template.md
[2]: ../learn/quote-templates.md
[4]: ../../../saint/learn/index.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/document/edit-list-item.png
[img3]: ../../../../media/loc/en/document/lists-add.png
[img4]: ../../../../media/loc/en/document/imagedmnmi.png
[img5]: ../../../../media/loc/en/document/image6r9sc.png
[img6]: ../../../../media/loc/en/document/language-add.png
[img7]: ../../../../media/loc/en/document/deutch-document-upload.png
[img8]: ../../../../media/loc/en/document/reference-item.png
