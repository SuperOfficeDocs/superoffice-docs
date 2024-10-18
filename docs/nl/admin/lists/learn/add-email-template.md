---
uid: help-nl-add-email-template
title: E-mailsjabloon toevoegen
description: E-mailsjabloon toevoegen
author: SuperOffice RnD
date: 06.29.2022
keywords: Instellingen en onderhoud
topic: help
language: nl
---

# Een e-mailsjabloon toevoegen

E-mailsjablonen kunnen worden gebruikt om nieuwe e-mails te maken in het Postvak IN van SuperOffice en voor het verzenden van offertes, opdrachtbevestigingen en privacybevestigingen.

Sjablonen worden weergegeven als items in de lijst **E-mail - Sjabloon** en u kunt nieuwe sjablonen toevoegen aan SuperOffice CRM door deze als een item in te voeren in de lijst.

[!include[Edit list item](includes/edit-list-item.md)] wanneer de items e-mailsjablonen zijn:

1. Typ de gewenste naam voor het item in het veld **Sjabloonnaam**.

2. Selecteer in het veld **Sjabloontype** het type sjabloon dat u maakt. Selecteer **Normaal** als u wilt dat de sjabloon beschikbaar is in **Postvak IN**. U kunt de sjabloon ook beschikbaar stellen als een offertesjabloon, een [opdrachtbevestigingsjabloon][3] of een [privacybevestigingssjabloon][4].

3. Als u wilt kunt u aangeven waar de documentsjabloon wordt opgeslagen in de lijst **Sjabloon opslaan in**.

4. U hebt nu drie opties:

    * **Een nieuwe e-mailsjabloon maken**
    * **Een bestaand e-mail-sjabloonbestand kopiëren**.
        1. Klik op de lijst **Sjabloon** kopiëren.
        2. Selecteer de gewenste sjabloon in de lijst.
    * **Een nieuwe e-mailsjabloon uploaden vanaf een schijf (.md/.md)**
        1. Klik op de knop **Uploaden**.
        2. Klik op **Bestand uploaden** in het dialoogvenster **Bestand uploaden**.
        3. Selecteer het gewenste bestand en klik op **Openen**. De naam van het bestand wordt weergegeven in het dialoogvenster **Item in lijst bewerken**.

5. Klik op **Opslaan** in het dialoogvenster **Item in lijst bewerken**. Het dialoogvenster wordt bijgewerkt.

6. Optioneel: De sjabloonnaam bewerken, indien nodig.

7. Klik op **Bewerken** om het sjabloonbestand zelf te bewerken. Als u een nieuwe e-mailsjabloon hebt gemaakt, voegt u inhoud toe aan de sjabloon.

8. Geef de vereiste informatie op in de tabbladen **Details** en **Talen**.

9. Klik op **Opslaan**. De sjabloon wordt als een afzonderlijk item toegevoegd aan de lijst **Items**. Herhaal deze procedure voor alle sjablonen die u wilt toevoegen.

## Tabblad Details

Geef de volgende informatie op op het tabblad **Details**:

1. (optioneel) Bewerk de naam van de sjabloon in het veld **Naam**. U kunt [de sjabloonnaam ook in andere talen toevoegen][1] door op ![pictogram][img1] te klikken.

2. Voer in het veld **Onderwerp** de titel van de e-mail in. U kunt [het onderwerp ook in andere talen toevoegen][1] door op ![pictogram][img1] te klikken.

3. Selecteer **Handtekening gebruiken in nieuwe e-mail** om uw handtekening toe te voegen aan nieuwe e-mails. Als u geen persoonlijke handtekening hebt, wordt de systeemhandtekening gebruikt.

4. Selecteer **E-maildialoogvenster weergeven** om het dialoogvenster **Nieuwe e-mail** weer te geven wanneer u een nieuwe e-mail maakt op basis van deze sjabloon. In dit dialoogvenster kunt u gegevens invoeren zoals bedrijf, persoon en project. Dit is noodzakelijk als de e-mailsjabloon sjabloonvariabelen bevat.

5. Typ zo nodig een beschrijving voor de sjabloon in het veld **Beschrijving**.

6. Geef in het veld **Richting** op of de sjabloon binnenkomend of uitgaand is door te klikken op de pijl (![pictogram][img2]) en een keuze te maken in de keuzelijst. Selecteer **Uitgaand** als u wilt dat de sjabloon beschikbaar is in **Postvak IN**.

7. Klik in het veld **Intentie** op de pijl (![pictogram][img2]) en selecteer een van de vooraf gedefinieerde opties in de keuzelijst. Deze items worden gebruikt samen met statuscontroles (vereist een licentie voor [Sales Intelligence][5]).

    > [!TIP]
    > U kunt nieuwe opties maken en toevoegen aan de vooraf gedefinieerde opties door deze toe te voegen aan de lijst **Vervolgactiviteit - Intentie** in Instellingen en onderhoud.

8. In het veld **Document opgeslagen in** kunt u kiezen om het document op een andere plaats dan op de standaardplaats op te slaan.

9. Geef met behulp van de [sjabloonvariabelen][2] de standaardinstelling op voor het veld **Onze referentie**, bijvoorbeeld *auteur* voor de voor- en achternaam van de afzender.

> [!NOTE]
> U kunt de sjabloon rechtstreeks bewerken vanuit het dialoogvenster Item in lijst **bewerken** door te klikken op de knop **Bewerken**. Alleen htm/html-bestanden kunnen direct in deze editor worden bewerkt. Het bestandstype wordt weergegeven in het veld **Bestandsnaam** in het tabblad **Details**. Klik op de knop **Downloaden** om andere bestandstypen te downloaden en deze in de relevante toepassing te bewerken.

## Tabblad Talen

Hier kunt u vertaalde versies van de documentsjabloon toevoegen.

1. Klik op **Toev.**
2. Selecteer in het dialoogvenster **item in lijst bewerken** gewenste taal in de lijst **Taal toevoegen**.
3. Voeg het vertaalde documentsjabloon toe zoals hierboven beschreven.
4. Klik op **Toevoegen**. De taal is toegevoegd aan het tabblad **Talen**.
5. Herhaal de stappen hierboven om extra talen toe te voegen.

> [!TIP]
> Klik op het ![pictogram][img1] naast het relevante veld om [vertalingen][1] van de sjabloonnaam en het e-mailonderwerp toe te voegen.

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../document/templates/learn/template-variables.md
[3]: sale-type.md
[4]: privacy-source-add.md
[5]: ../../../saint/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/az.png
[img2]: ../../../../media/icons/arrow-down.png
