---
uid: help-sv-updating-rules-for-duplicate-handling
title: Uppdatera regler för hantering av dubbletter
description: Uppdatera regler för hantering av dubbletter
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar för Windows-klient
content_type: howto
language: sv
client: win
deployment: onsite
---

# Uppdateringsregler för hantering av dubbletter

Du måste alltid ange regler för hantering av dubbletter under import.

1. [!include[How to open import](includes/open-import.md)]

2. Gör något av följande:

    * Klicka på ![ikonen][img1] bredvid fältet **Importbeskrivningsfil** och välj en importbeskrivningsfil i den dialogruta som öppnas. En importfil och tidigare valda inställningar infogas automatiskt.

    * [!include[Select file](includes/step-select-file.md)]

        Ange sedan [fälttilldelningen][1].

3. Innehållet i kolumnen **Tabell** under **Hantering av dubbletter** baseras på den angivna fälttilldelningen.

4. Under **Hantering av dubbletter** markerar du den rad som du vill ange en dubbletthanteringsregel för.

    > [!NOTE]
    > Vilka rader som visas under **Hantering av dubbletter** beror på vilka fält du har valt att importera till. Detta kan inte ändras, och du måste ange dubbletthanteringsregler för alla rader.

5. Klicka på knappen **Uppdatera**. Dialogrutan **Hantera dubbletter** för den valda datatypen öppnas.

6. Alla tillgängliga fält av den obligatoriska datatypen som du har definierat fälttilldelningar för visas under **När dessa fält överensstämmer**. Kontrollera vilka fält som måste ha identiskt innehåll för att posten ska betraktas som en dubblett. Detta kallas för en importnyckel.

7. Under **Gör följande** väljer du vad du vill göra om dubbletter upptäcks under importen:

    * **Uppdatera**: värdena i importfilen skriver över värdena i databasen. Välj det här alternativet om du anser att informationen i importfilen är mer aktuell än den som redan finns i databasen.
    * **Koppla**: alla nya poster läggs till, men för befintliga poster uppdateras endast de tomma fälten. Välj det här alternativet om du anser att informationen i databasen är mer aktuell än den i importfilen.
    * **Hoppa över**: alla nya poster läggs till, men de som redan finns i databasen behålls oförändrade.

    > [!NOTE]
    > Detta är standardalternativet för att återställa databasen, så att oönskade poster inte importeras med negativa konsekvenser.

    * **Infoga**: alla fält i importfilen importeras och ingen kontroll utförs för att se om de redan finns. Detta alternativ är särskilt relevant när du importerar till en tom databas. Du behöver inte ange importnycklar för det här alternativet.

8. Klicka på **OK**.

[!include[Save mapping](includes/tip-save-mapping.md)]

## Vad vill du göra nu?

* [Återställa regler för hantering av dubbletter][3]

<!-- Referenced links -->
[1]: field-mapping.md
[3]: resetting-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/search-icon-black.png
