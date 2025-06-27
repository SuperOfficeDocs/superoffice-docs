---
uid: help-nl-resetting-rules-for-duplicate-handling
title: Regels voor verwerking van duplicaten opnieuw instellen
description: Regels voor verwerking van duplicaten opnieuw instellen
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client-instellingen
content_type: howto
language: nl
client: win
envir: onsite
---

# Een of alle regels voor verwerking van duplicaten opnieuw instellen

1. [!include[How to open import](includes/open-import.md)]

2. Voer een van de volgende handelingen uit:

    * Klik op het ![pictogram][img1] naast het veld **Importbeschrijvingsbestand** en selecteer een importbeschrijvingsbestand in het dialoogvenster dat wordt geopend. Een importbestand en de eerder geselecteerde instellingen worden automatisch ingevoegd.

    * [!include[Select file](includes/step-select-file.md)]

        Geef vervolgens de [veldtoewijzing][1] op. De inhoud in de kolom **Tabel** onder **Verwerking van duplicaten** is gebaseerd op de opgegeven veldtoewijzing.

3. Selecteer een van de volgende handelingen:

    * Een enkele regel verwijderen:

        1. Selecteer de gewenste rij onder **Verwerking van duplicaten**.
        2. Klik op de knop **Opnieuw instellen**. De geselecteerde rij heeft nu geen gegevens in de kolom **Sleutel** en de kolom **Actie** verandert in **Record overslaan**.

    * Alle regels verwijderen:

        1. Klik op de knop **Alles opnieuw instellen** onder **Verwerking van duplicaten**. Alle rijden zullen geen gegevens hebben in de kolom **Sleutel** en de kolom **Actie** voor elke rij zal veranderen in **Record overslaan**.

> [!NOTE]
> u kunt geen gegevens importeren zonder regels op te geven voor de verwerking van duplicaten voor alle gegevenstypen, tenzij u **Toch invoegen** kiest onder **Doe het volgende** in het dialoogvenster **Duplicaten verwerken**. Dat houdt in dat u nieuwe regels moet toevoegen voordat u de import begint als u regels opnieuw hebt ingesteld.

## Wat wilt u nu doen?

* [Regels voor verwerking van duplicaten bijwerken][2]

<!-- Referenced links -->
[1]: field-mapping.md
[2]: updating-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/nav-admin-import-active.png
