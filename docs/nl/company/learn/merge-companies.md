---
uid: help-nl-company-merge
title: Bedrijven samenvoegen
description: "Om efficiënt te kunnen werken met klanten en contacten, is het van vitaal belang om een omgeving 'zonder rommel' te hebben. Dit betekent ongebruikte bedrijven en contacten verwijderen en gedupliceerde bedrijven en personen samenvoegen."
author: SuperOffice RnD
so.date: 12.15.2022
keywords: bedrijf
so.topic: howto
language: nl
---

# Bedrijven samenvoegen

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

U kunt dubbele databaserecords van bedrijven samenvoegen. Contactpersonen en activiteiten worden verplaatst naar het doelbedrijf en het bronbedrijf wordt verwijderd.

Als twee bedrijven in uw klantendatabase besluiten te fuseren of als het ene bedrijf het andere heeft gekocht, kunt u deze bedrijven samenvoegen tot één bedrijf. Personen (en gerelateerde verzoeken), facturen en geregistreerde domeinen blijven behouden voor beide bedrijven.

## Stappen

[!include[Go to company](../../learn/includes/goto-company.md)]

1. Selecteer **Bedrijven beheren** in het menu ![pictogram][img3] **Taak** en klik vervolgens op **Bedrijven samenvoegen**.
    Het dialoogvenster **Bedrijven samenvoegen** wordt geopend. Het bronbedrijf staat bij **Van**.

1. Selecteer bij **Aan bedrijf** het bedrijf dat u wilt bijwerken met gegevens van het bronbedrijf. Begin in het veld te typen om naar een bedrijf te zoeken.

    > [!TIP]
    > Als u de bedrijven bij **Van** en bij **Naar** wilt omkeren, klikt u op de ![pictogram][img1] knop.

1. Bij **Gegevens van contactpersonen en bedrijf** kunt u kiezen uit:

    * Identieke contactpersonen samenvoegen. Als deze optie is geselecteerd, worden contactpersonen met identieke namen samengevoegd.

        > [!NOTE]
        > De namen moeten EXACT hetzelfde zijn, voornaam, tussenvoegsel en achternaam, om samengevoegd te worden.

    * **Vervang lege velden in \[target company\] door waarden van \[source company\]**. Als deze optie is geselecteerd, worden lege gegevensvelden in het bedrijf bij **Aan** bijgewerkt met gegevens van het bedrijf bij **Van**.

    [!include[Preview results](../../learn/includes/note-preview-results.md)]

1. Klik op **Samenvoegen**. Vervolgens gebeurt het volgende:

    * De bedrijven worden samengevoegd.
    * Contactpersonen worden verplaatst of samengevoegd.
    * Alle activiteiten worden verplaatst.
    * Projectlidmaatschappen en lidmaatschappen van statische selecties volgen het bedrijf.
    * Alle gegevens worden samengevoegd als u **Lege velden in &lt;target company&gt; vervangen met waarden uit &lt;source company&gt;** selecteert.
    * Het bronbedrijf wordt verwijderd.

![Dialoogvenster Bedrijven samenvoegen -screenshot][img4]

[Controleer in het dialoogvenster Bedrijven samenvoegen of u het juiste bedrijf selecteert in het veld Van EN in het veld T/m -screenshot][img5]

![Om extra informatie te krijgen voordat u de twee bedrijven samenvoegt, klikt u op de Info-knop op Resultaat weergeven -screenshot][img6]

> [!TIP]
> u kunt bedrijven ook samenvoegen in dynamische en statische selecties.

## Verwante onderwerpen

* [Contactpersonen samenvoegen][2]

<!-- Referenced links -->
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/info-ball.png
[img3]: ../../../media/icons/btn-menu.png
[img4]: ../../../media/loc/en/company/merge-companies.bmp
[img5]: ../../../media/loc/en/company/company-merge.png
[img6]: ../../../media/loc/en/company/company-merge-info.png
