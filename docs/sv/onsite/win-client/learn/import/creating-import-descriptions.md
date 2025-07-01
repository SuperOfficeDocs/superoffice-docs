---
uid: help-sv-creating-import-descriptions
title: Skapa importbeskrivningar
description: Skapa importbeskrivningar
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar för Windows-klient
content_type: howto
language: sv
platform: win
deployment: onsite
---

# Skapa importbeskrivningar

> [!NOTE]
> Om du redan har laddat upp importfilen och konfigurerat alla fält och inställningar, bör du klicka på **Spara**. Om du klickar på **Ny** kommer alla inställningar som du har gjort för importfilen att RADERAS.

1. [!include[How to open import](includes/open-import.md)]

2. Klicka på knappen **Ny** längst upp till höger i fönstret. Fönstret **Import** rensas.

3. Ange en datafil i fältet **Importera fil**.

4. Under **Fälttilldelning** anger du vilket fält i importfilen som ska tilldelas vilket fält i SuperOffice-databasen. (Se [Fälttilldelning][1].)

5. Under **Importinställningar** är följande alternativ tillgängliga:

    * **Fil har rubrikrad**: kontrollera att filen börjar med en rubrikrad (en rad som inte innehåller data).
    * **Lägg till okända förekomster på listan**: markera denna om du vill att okända poster ska inkluderas i befintliga listor i SuperOffice-databasen. Om det här alternativet är avmarkerat, importeras inte den okända posten, och det relevanta fältet i SuperOffice-databasen kommer lämnas tomt.
    * **Lägg till som medlemmar i nytt urval**: markera detta om du importerar företags- eller kontaktdatatypen och vill att de företag/kontakter som du importerar ska ingå i ett separat urval. I det här fallet måste du också ange ett namn för urvalet i fältet **Namn** .

    > [!NOTE]
    > Om du väljer **Lägg till som medlemmar i nytt urval**, kommer företag och kontakter som ingår i importen att läggas till i ett nytt urval med det namn du angav. Företag och kontakter som inte ingår (om du har valt **Hoppa över** i dialogrutan **Hantera dubbletter** ) läggs inte till i urvalet även om de finns i importfilen.

6. Om du vill ange mer [avancerade inställningar för importen][2], klickar du på knappen **Avancerat** .

7. Under **Hantering av dubbletter** kan du ange regler för hantering av förekomsten av [dubbletter][3]. Det vill säga att om samma post finns i både filen du importerar och databasen du importerar till.

8. När du har angett de önskade alternativen, klickar du på **Spara**.

    > [!NOTE]
    > Du kan utföra en import utan att klicka på knappen **Spara**, men dina ändringar sparas då inte för senare användning.

9. Ange namnet på den nya filen i dialogrutan, välj den mapp du vill spara den i och klicka på **Spara**.

> [!NOTE]
> Du kan också skapa en ny importbeskrivning genom att [ändra en befintlig beskrivning][4] och spara den med ett nytt namn.

<!-- Referenced links -->
[1]: field-mapping.md
[2]: specifying-advanced-import-settings.md
[3]: duplicates-import.md
[4]: editing-import-descriptions.md

<!-- Referenced images -->
