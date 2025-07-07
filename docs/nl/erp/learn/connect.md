---
uid: help-nl-erp-connect-actor
title: Verbinding maken met ERP
description: Verbinding maken met ERP
keywords: verbinding met ERP, bedrijf koppelen aan ERP, contactpersoon koppelen aan ERP, project koppelen aan ERP, kan geen overeenkomst vinden in ERP, maken in ERP, actor maken, ERP-actor, ERP
author: SuperOffice RnD
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from:
  - /nl/admin/erp/learn/erp-connect
  - /nl/admin/erp/learn/erp-create-new-actor
---

# Verbinding maken met ERP

[!include[Requirement](../../includes/req-dev-tools.md)]

U kunt een SuperOffice-bedrijf koppelen aan een klant of leverancier in het ERP-systeem. Personen die zijn geregistreerd bij het SuperOffice-bedrijf kunnen vervolgens worden gekoppeld aan individuen in het ERP-systeem. Op dezelfde manier kunnen SuperOffice-projecten worden gekoppeld aan projecten in het ERP-systeem. De gegevens worden vervolgens gesynchroniseerd tussen SuperOffice en het ERP-systeem.

1. Ga naar het scherm **Bedrijf**, **Persoon** of **Project** en selecteer het tabblad **ERP**.

    Als het tabblad **ERP** al bedrijfs-, persoon- of projectgegevens bevat, bestaat er al een verbinding tussen SuperOffice en het ERP-systeem.

1. Klik op **Bewerken**. De opties zijn afhankelijk van of u een bedrijf, een persoon of een project bewerkt.
1. Bedrijf: Klik op **Klant** of **Leverancier**, afhankelijk van met welk type ERP-actor u het bedrijf wilt koppelen. U kunt slechts één actor per bedrijf kiezen.
    *Of* Project: Klik op **Project**.
    *Of* Persoon: Klik op **Persoon**.
1. Voer in het dialoogvenster **Verbinden met ERP** tekst in het zoekveld in en klik op **Zoeken**. U kunt ook op het zoekpictogram klikken (<i class="ph ph-magnifying-glass" aria-label="Zoek"></i>) om een [geavanceerde zoekopdracht][1] te starten.

    Als u zoekt met een leeg zoekveld, worden alle records in het ERP-systeem weergegeven.

1. Selecteer een item in de lijst met zoekresultaten. Als u geen resultaten krijgt, kunt u [een nieuwe actor aanmaken in het ERP-systeem](#create-actor) op basis van gegevens uit SuperOffice CRM.
1. Klik op **Verbinden**. Er verschijnt een dialoogvenster waarin de gegevens worden weergegeven die gesynchroniseerd zullen worden tussen SuperOffice CRM en het ERP-systeem. Welke gegevens hier zichtbaar zijn, is gedefinieerd in Instellingen en onderhoud.
1. Als de gegevens in beide systemen verschillen, selecteer dan de correcte gegevens.
    Bijvoorbeeld: als de straatadressen verschillen, selecteer dan het juiste adres. De andere gegevens worden overschreven.
1. Klik op **Verbinden**. U keert terug naar het tabblad **ERP** waar de gesynchroniseerde gegevens nu worden weergegeven.
1. Klik op **Opslaan**.

## <a id="create-actor"></a>Een actor maken in het ERP-systeem

Als een klant bijvoorbeeld niet bestaat in het ERP-systeem, kunt u deze aanmaken op basis van de gegevens uit SuperOffice.

> [!NOTE]
> De knop **Maken** is uitgeschakeld als SuperOffice geen toestemming heeft om actors aan te maken in het ERP-systeem.

1. In het dialoogvenster **Verbinding maken met ERP**, selecteer onderaan **Kan geen overeenkomst vinden in ERP** en klik op **Maken**. Het dialoogvenster **Maken in ERP** verschijnt.
1. Voer de vereiste gegevens in.
1. Klik op **Maken**. U keert terug naar het tabblad **ERP** waar de gesynchroniseerde gegevens nu worden weergegeven.
1. Klik op **Opslaan**.

## Gerelateerde inhoud

* [Synchronisatie uitschakelen][3]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[3]: disconnect.md

<!-- Referenced images -->
