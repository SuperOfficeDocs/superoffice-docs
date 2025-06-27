---
uid: help-nl-creating-import-descriptions
title: Importbeschrijvingen maken
description: Importbeschrijvingen maken
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client-instellingen
content_type: howto
language: nl
client: win
envir: onsite
---

# Importbeschrijvingen maken

> [!NOTE]
> Als u het importbestand al hebt geüpload en alle velden en instellingen al hebt geconfigureerd, moet u op **Opslaan** klikken. Als u op **Nieuw** klikt, VERWIJDERT u alle instellingen die u hebt geconfigureerd voor het importbestand.

1. [!include[How to open import](includes/open-import.md)]

2. Klik op de knop **Nieuw** rechtsbovenaan in het scherm. De gegevens van het scherm **Import** worden gewist.

3. Geef een gegevensbestand op in het veld **Importbestand**.

4. Geef onder **Veldtoewijzing** op welke veld in het importbestand moeten worden toegewezen aan welk veld in de SuperOffice-database. (Zie [Veldtoewijzing][1].)

5. U kunt de volgende opties kiezen onder **Importinstellingen**:

    * **Bestand heeft een veldnamenrij**: schakel dit vakje in als het bestand begint met een veldnamenrij (een rij zonder feitelijke gegevens).
    * **Onbekende lijst-items toevoegen aan lijst**: schakel dit vakje in als u onbekende items wilt laten opnemen in bestaande lijsten in de SuperOffice-database. Als u dit vakje niet inschakelt, wordt het onbekende item niet geÃ¯mporteerd en blijft het betreffende veld in de SuperOffice-database leeg.
    * **Als leden toevoegen aan nieuwe selectie**: schakel dit vakje in als u gegevens van het type bedrijf of persoon importeert en u de bedrijven/personen die u importeert, wilt laten opnemen in een aparte selectie. In dat geval moet u ook een naam opgeven voor de selectie in het veld **Naam**.

    > [!NOTE]
    > Wanneer u **Als leden toevoegen aan nieuwe selectie** hebt gekozen, worden bedrijven en personen die betrokken zijn bij de import, toegevoegd aan een nieuwe selectie met de naam die u hebt opgegeven. Bedrijven en contactpersonen die niet meegenomen zijn bij de import (dus als u **Record overslaan** hebt gekozen in het dialoogvenster **Duplicaten verwerken**), worden niet toegevoegd aan de selectie, ook niet als zij wel voorkomen in het importbestand.

6. Als u meer [geavanceerde instellingen wilt opgeven voor de import][2], klikt u op de knop **Geavanceerd**.

7. Onder **Verwerking van duplicaten** geeft u regels op om rekening te houden met het bestaan van [duplicaten][3]. Dat wil zeggen, als dezelfde record bestaat in zowel het bestand dat u importeert als de database waarin u importeert.

8. Nadat u de vereiste opties hebt opgegeven, klikt u op **Opslaan**.

    > [!NOTE]
    > u kunt een bestand importeren zonder op de knop **Opslaan** te klikken, maar de wijzigingen worden dan niet opgeslagen voor later gebruik.

9. Typ de naam voor het nieuwe bestand in het dialoogvenster dat wordt geopend, kies de map waarin u het bestand wilt opslaan en klik op **Opslaan**.

> [!NOTE]
> U kunt ook een nieuwe importbeschrijving maken door [een bestaande beschrijving][4] te wijzigen en op te slaan onder een nieuwe naam.

<!-- Referenced links -->
[1]: field-mapping.md
[2]: specifying-advanced-import-settings.md
[3]: duplicates-import.md
[4]: editing-import-descriptions.md

<!-- Referenced images -->
