---
uid: help-nl-add-email-template
title: E-mailsjabloon toevoegen
description: E-mailsjabloon toevoegen
keywords: E-mail - Sjabloon lijst, e-mailsjabloon
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /nl/admin/lists/learn/email-template
  - /nl/admin/lists/learn/add-email-template
  - /nl/admin/lists/learn/create-email-template
  - /nl/email/admin/index
language: nl
---

# E-mailsjabloon toevoegen

Het is belangrijk voor het profiel van een organisatie dat e-mails een duidelijke en uniforme vormgeving hebben. Dit betekent dat alle uitgaande e-mails dezelfde lettertypen, opmaak, logo's, enzovoort moeten hebben. Door e-mailsjablonen speciaal voor uw organisatie te maken, zorgt u ervoor dat de contactpersonen van uw organisatie eenvoudig de correspondentie van uw organisatie herkennen. E-mailsjablonen worden ook gebruikt voor het verzenden van offertes, opdrachtbevestigingen en privacybevestigingen.

SuperOffice CRM wordt geleverd met een aantal standaardsjablonen die u direct kunt gebruiken nadat u het programma hebt geïnstalleerd.

U kunt ook uw eigen sjablonen maken. Dit doet u door [sjabloonvariabelen][2] in te voeren in de e-mailsjablonen. Deze zorgen ervoor dat informatie wordt opgehaald uit de bijbehorende velden in SuperOffice CRM wanneer u een e-mail schrijft met een sjabloon die u hebt gemaakt.

Sjablonen worden weergegeven als items in de lijst **E-mail - Sjabloon** en u kunt nieuwe sjablonen toevoegen aan SuperOffice CRM door deze als een item in te voeren in de lijst.

## Stappen

1. Selecteer <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lijsten** in de navigator.

1. Selecteer **E-mail - Sjabloon** in het dropdownmenu. Het tabblad **Items** toont alle bestaande bronnen.

1. Klik op **Toevoegen** om het dialoogvenster **Lijstitem bewerken** te openen.

1. Typ de gewenste naam voor het item in het veld **Sjabloonnaam**.

1. Selecteer in het veld **Sjabloontype** het type sjabloon dat u maakt. Selecteer **Normaal** als u wilt dat de sjabloon beschikbaar is in **Postvak IN**. U kunt de sjabloon ook beschikbaar stellen als een offertesjabloon, een [opdrachtbevestigingsjabloon][3] of een [privacybevestigingssjabloon][4].

1. Als u wilt kunt u aangeven waar de documentsjabloon wordt opgeslagen in de lijst **Sjabloon opslaan in**.

1. U hebt nu drie opties:

    * **Een nieuwe e-mailsjabloon maken**
    * **Een bestaand e-mail-sjabloonbestand kopiëren**.
        1. Klik op de lijst **Sjabloon** kopiëren.
        2. Selecteer de gewenste sjabloon in de lijst.
    * **Een nieuwe e-mailsjabloon uploaden vanaf een schijf (.md/.md)**
        1. Klik op de knop **Uploaden**.
        2. Klik op **Bestand uploaden** in het dialoogvenster **Bestand uploaden**.
        3. Selecteer het gewenste bestand en klik op **Openen**. De naam van het bestand wordt weergegeven in het dialoogvenster **Item in lijst bewerken**.

1. Klik op **Opslaan** in het dialoogvenster **Item in lijst bewerken**. Het dialoogvenster wordt bijgewerkt.

1. Optioneel: De sjabloonnaam bewerken, indien nodig.

1. Klik op **Bewerken** om het sjabloonbestand zelf te bewerken. Als u een nieuwe e-mailsjabloon hebt gemaakt, voegt u inhoud toe aan de sjabloon.

1. Geef de vereiste informatie op in de tabbladen **Details** en **Talen**.

1. Klik op **Opslaan**. De sjabloon wordt als een afzonderlijk item toegevoegd aan de lijst **Items**. Herhaal deze procedure voor alle sjablonen die u wilt toevoegen.

1. De e-mailsjabloon beschikbaar maken voor de gebruikersgroepen. Zie [Gebruikersgroepen filteren][7].

## Tabblad Details

Geef de volgende informatie op op het tabblad **Details**:

1. (optioneel) Bewerk de naam van de sjabloon in het veld **Naam**. U kunt [de sjabloonnaam ook in andere talen toevoegen][1] door op <i class="ph ph-translate" aria-label="Translate"></i> te klikken.

1. Voer in het veld **Onderwerp** de titel van de e-mail in. U kunt [het onderwerp ook in andere talen toevoegen][1] door op <i class="ph ph-translate" aria-label="Translate"></i> te klikken.

1. Selecteer **Handtekening gebruiken in nieuwe e-mail** om uw handtekening toe te voegen aan nieuwe e-mails. Als u geen persoonlijke handtekening hebt, wordt de systeemhandtekening gebruikt.

1. Selecteer **E-maildialoogvenster weergeven** om het dialoogvenster **Nieuwe e-mail** weer te geven wanneer u een nieuwe e-mail maakt op basis van deze sjabloon. In dit dialoogvenster kunt u gegevens invoeren zoals bedrijf, persoon en project. Dit is noodzakelijk als de e-mailsjabloon sjabloonvariabelen bevat.

1. Typ zo nodig een beschrijving voor de sjabloon in het veld **Beschrijving**.

1. Geef in het veld **Richting** op of de sjabloon binnenkomend of uitgaand is door te klikken op <i class="ph ph-caret-down" aria-label="Chevron"></i> en een keuze te maken in de keuzelijst. Selecteer **Uitgaand** als u wilt dat de sjabloon beschikbaar is in **Postvak IN**.

1. Klik in het veld **Intentie** op <i class="ph ph-caret-down" aria-label="Chevron"></i> en selecteer een van de vooraf gedefinieerde opties in de keuzelijst. Deze items worden gebruikt samen met statuscontroles (vereist een licentie voor [Sales Intelligence][5]).

    > [!TIP]
    > U kunt nieuwe opties maken en toevoegen aan de vooraf gedefinieerde opties door deze toe te voegen aan de lijst **Vervolgactiviteit - Intentie** in Instellingen en onderhoud.

1. In het veld **Document opgeslagen in** kunt u kiezen om het document op een andere plaats dan op de standaardplaats op te slaan.

1. Geef met behulp van de [sjabloonvariabelen][2] de standaardinstelling op voor het veld **Onze referentie**, bijvoorbeeld *auteur* voor de voor- en achternaam van de afzender.

> [!NOTE]
> U kunt de sjabloon rechtstreeks bewerken vanuit het dialoogvenster Item in lijst **bewerken** door te klikken op de knop **Bewerken**. Alleen htm/html-bestanden kunnen direct in deze editor worden bewerkt. Het bestandstype wordt weergegeven in het veld **Bestandsnaam** in het tabblad **Details**. Klik op de knop **Downloaden** om andere bestandstypen te downloaden en deze in de relevante toepassing te bewerken.

## Tabblad Talen

Hier kunt u vertaalde versies van de documentsjabloon toevoegen.

1. Klik op **Toev.**
1. Selecteer in het dialoogvenster **item in lijst bewerken** gewenste taal in de lijst **Taal toevoegen**.
1. Voeg het vertaalde documentsjabloon toe zoals hierboven beschreven.
1. Klik op **Toevoegen**. De taal is toegevoegd aan het tabblad **Talen**.
1. Herhaal de stappen hierboven om extra talen toe te voegen.

> [!TIP]
> Klik op het <i class="ph ph-translate" aria-label="Translate"></i> naast het relevante veld om [vertalingen][1] van de sjabloonnaam en het e-mailonderwerp toe te voegen.

## Gerelateerde inhoud

* [Offertesjablonen][6]

<!-- Referenced links -->
[1]: ../../localization/learn/translate-fields.md
[2]: ../../document/templates/learn/template-variables.md
[3]: ../../sale/admin/sale-type.md
[4]: ../../security/privacy/admin/add-source.md
[5]: ../../saint/learn/index.md
[6]: ../../document/templates/learn/quote-templates.md
[7]: ../../admin/lists/user-group-filtering.md
