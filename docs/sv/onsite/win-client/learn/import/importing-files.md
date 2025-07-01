---
uid: help-sv-importing-files
title: Importera filer
description: Importera filer
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar för Windows-klient
content_type: howto
language: sv
client: win
deployment: onsite
---

# Importera en datafil till SuperOffice-databasen

När du har säkerhetskopierat databasfilen, hittat rätt datafil och placerat den i en mapp där du enkelt kan hitta den igen (se [Importrutiner][1]) kan du starta själva importen.

> [!NOTE]
> Vissa program "låser" filer de öppnar så att andra program inte kan komma åt dem. Innan du påbörjar importen, kontrollera att varken importbeskrivningsfilen eller datafilen är öppna i något annat program (till exempel Excel).

**Steg:**

<!-- markdownlint-disable-file MD029 -->
1. [!include[How to open import](includes/open-import.md)]

[!include[Import description](includes/step-import-description.md)]
<!-- Include covers steps 2-3. Next line MUST be 4. -->

4. När du har valt en importbeskrivning och importfilen har hittats, fylls de andra fälten i automatiskt. Alternativt kan du [redigera någon av detaljerna i importbeskrivningen][3].

5. Det kan vara bra att kontrollera att innehållet i fälten stämmer överens med de fält du har valt. Kolumnen **Fält i fil** under **Fälttilldelning** visar innehållet i den första posten i datafilen som du importerar, medan kolumnen **Fält i SuperOffice CRM** visar fälten i SuperOffice-databasen som dessa data kommer importeras till. Klicka på knappen **Nästa** några gånger om du också vill kontrollera innehållet i några av de följande posterna.

    > [!NOTE]
    > Om fälten inte visas som de ska, måste du antingen ändra [fälttilldelningen][4] eller göra nödvändiga ändringar i importfilen.

6. Klicka på **Starta** för att starta importen. En förloppsindikator visas längst ned i fönstret.

> [!NOTE]
> Den tid som krävs för att importera data från importfilen till SuperOffice-databasen beror på databasens storlek och dataanslutningen (långsam eller snabb anslutning till databasservern). Du kan dock när som helst avbryta importen genom att klicka på knappen **Stopp** till höger om förloppsindikatorn.

<!-- Referenced links -->
[1]: import-routines.md
[3]: editing-import-descriptions.md
[4]: field-mapping.md

<!-- Referenced images -->
