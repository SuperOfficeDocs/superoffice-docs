---
uid: help-nl-updating-rules-for-duplicate-handling
title: Regels voor verwerking van duplicaten bijwerken
description: Regels voor verwerking van duplicaten bijwerken
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client-instellingen
content_type: howto
language: nl
client: win
envir: onsite
---

# Regels voor verwerking van duplicaten bijwerken

U moet altijd regels opgeven voor de manier waarop duplicaten worden verwerkt tijdens het importeren van gegevens.

1. [!include[How to open import](includes/open-import.md)]

2. Voer een van de volgende handelingen uit:

    * Klik op het ![pictogram][img1] naast het veld **Importbeschrijvingsbestand** en selecteer een importbeschrijvingsbestand in het dialoogvenster dat wordt geopend. Een importbestand en de eerder geselecteerde instellingen worden automatisch ingevoegd.

    * [!include[Select file](includes/step-select-file.md)]

        Geef vervolgens de [veldtoewijzing][1] op.

3. De inhoud in de kolom **Tabel** onder **Verwerking van duplicaten** is gebaseerd op de opgegeven veldtoewijzing.

4. Selecteer de rij waarvoor u een regel voor verwerking van duplicaten wilt opgeven onder **Verwerking van duplicaten**.

    > [!NOTE]
    > welke regels worden weergegeven onder **Verwerking van duplicaten**, hangt af van de gekozen velden die worden geÃ¯mporteerd. Dit kan niet worden gewijzigd en u moet de verwerking van duplicaten opgeven voor elke rij.

5. Klik op de knop **Bijwerken**. Het dialoogvenster **Duplicaten verwerken** voor het geselecteerde gegevenstype wordt geopend.

6. Alle beschikbare velden van het gewenste gegevenstype waarvoor u veldtoewijzingen hebt gedefinieerd, worden weergegeven onder **Wanneer deze velden overeenkomen**. Hier selecteert u het/de veld(en) die een identieke inhoud moeten hebben zodat een record wordt beschouwd als een duplicaat. Dit wordt een importsleutel genoemd.

7. Kies onder **Doe het volgende** wat er moet gebeuren als duplicaten worden ontdekt tijdens de import.

    * **Bijwerken bestaand**: de waarden in het importbestand overschrijven de waarden in de database. Kies deze optie als u denkt dat de gegevens in het importbestand recenter zijn dan de gegevens in de database.
    * **Alleen lege velden bijwerken**: alle nieuwe records worden toegevoegd, maar alleen de lege velden worden bijgewerkt voor bestaande records. Kies deze optie als u denkt dat de gegevens in de database recenter zijn dan de gegevens in het importbestand.
    * **Record overslaan**: alle nieuwe records worden toegevoegd, maar records die al voorkomen in de database worden onveranderd gehandhaafd.

    > [!NOTE]
    > dit is de standaardoptie voor het opnieuw instellen van de database, zodat ongewenste records niet worden geÃ¯mporteerd met alle consequenties van dien.

    * **Toch invoegen**: alle velden in het importbestand worden geïmporteerd en er wordt geen controle uitgevoerd of zij al bestaan. Deze optie is met name handig wanneer u importeert in een lege database. Voor deze optie hoeft u geen importsleutels op te geven.

8. Klik op **OK**.

[!include[Save mapping](includes/tip-save-mapping.md)]

## Wat wilt u nu doen?

* [Regels voor verwerking van duplicaten opnieuw instellen][3]

<!-- Referenced links -->
[1]: field-mapping.md
[3]: resetting-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/search-icon-black.png
