---
uid: help-sv-selection-create
title: Skapa urval
description: Arbeta med dynamiska och statiska urval
keywords: skapa urval, spara som urval, urval
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/sale/saint/learn/using-status-monitors-in-dynamic-selections
  - /sv/search-options/selection/learn/create/copy
  - /sv/search-options/selection/learn/create/index
  - /sv/search-options/selection/learn/create/tutorial
---

# Skapa urval

Du börjar med en uppsättning kriterier från fönstret **Sök** genom att använda en vanlig sökning eller lägga till egna kriterier. Därifrån kan du spara resultatet som ett dynamiskt eller statiskt urval. Skillnaden mellan de två är ett urval som fortsätter att uppdatera antalet medlemmar (dynamiskt) eller ett urval som har frysta medlemmar med en ögonblicksbild av dagens medlemsurval (statiskt).

## Steg

1. Klicka på **Nytt** på toppraden och välj **Urval**.

1. I fönstret Sök klickar du på det alternativ under **Sök** som är relevant för den datatyp som du vill använda i ditt urval. Du kan också klicka på **Typiska sökningar** om du vill använda fördefinierade sökningar.

1. [Lägg till dina sökvillkor][9] på fliken **Kriterier**.

1. Klicka på **Sök**. Fliken **Resultat** visar de data som matchar dina kriterier.

1. För att spara resultaten i ett urval klickar du på **Spara som urval**. Om inte, förfina dina sökkriterier.

1. I dialogrutan **Spara som urval** väljer du typ:

    * **Dynamiskt urval:** Denna urvalstyp uppdateras alltid automatiskt med medlemmar som överensstämmer med urvalskriterierna.
    * **Statiskt urval:** Denna urvalstyp innehåller endast de medlemmar som du har lagt till manuellt.
    * **Lägg till i befintligt statiskt urval:** Spara resultatet i ett befintligt urval. Du kan manuellt lägga till eller ta bort medlemmar från urvalet senare.

1. Klicka på **Spara**.

1. Skriv in namnet på det nya urvalet där det står *Urvalsnamn*. Det här fältet måste fyllas i.

1. I fältet **Urval är** kan du byta till en annan typ av urval vid behov.

1. **Välja detaljer:**

    * **Ägare:** I fältet visas automatiskt den inloggade användaren.

        Efter att ett nytt urval har sparats, kan du ändra ägare genom att [redigera urvalet][6]. Det betyder i praktiken att du överför ägarskapet från dig själv till någon annan.

    * **Kategori:** Välj en urvalstyp. Dessa definieras under Inställningar och underhåll.

    * **Synlig för:** Välj om urvalet ska vara synligt för alla, privat (endast synligt för dem som är definierade som ägare) eller synligt för alla i den grupp som ägaren tillhör.

1. Lägg till en beskrivning för urvalet i fältet **Beskrivning** om det är relevant.

1. När du har definierat den allmänna informationen för urvalet klickar du på **Spara**.

## <a id="copy"></a>Kopiera ett urval

Du kan snabbt och enkelt skapa en exakt kopia av ett urval genom att välja uppgiften **Kopiera urvalet**.

Då skapas en kopia av urvalet med texten (kopia) bakom urvalsnamnet. Det vill säga att om du kopierar urvalet *Mitt statiska urval* så får kopian namnet *Mitt statiska urval (kopia)*.

1. [!include[Start](includes/steps-start-task.md)]

1. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Uppgift-knappen"></i> och välj **Kopiera urvalet**. Då skapas en kopia av urvalet.

1. Byt namn på det nya urvalet.

## Tips

* Om du försöker registrera ett urval med samma namn som ett befintligt urval öppnas [dialogrutan Dubbletter][8]. Den fungerar på samma sätt som för företag.

* Klicka på <i class="ph ph-star" aria-label="Star icon"></i> för att lägga till urvalet i [dina favoriter][7].

* Klicka på <i class="ph ph-gear" aria-label="Gear"></i> till höger om kolumnrubrikerna. Här kan du gruppera och filtrera poster och lägga till/ta bort kolumner. Dessa inställningar kan sparas för det aktiva urvalet genom att du väljer **Spara kolumner endast för markerat urval**.

* Markera **Slutfört** för att ange att urvalet är inaktivt. Om du vill att urvalet ska vara aktivt låter du kryssrutan stå tom.

* Med **SAINT** aktiverat (kräver Sales-Premium eller Service-Premium) kan du använda [statuslägen][14] som kriterier för att skapa dynamiska urval. Detta ger dig en översikt över företag, kontakter eller projekt som uppfyller specifika statuskriterier. SAINT-kriterierna finns under **Räknare (SAINT)** i [kriterielistan][9] i fönstret **Sök**.

## Relaterat innehåll

* [Kombinera urval][3]
* [Uppdatera urval][6]
* [Utföra uppgifter för urval][5]

<!-- Referenced links -->
[3]: combine.md
[7]: ../../../learn/basics/fav.md
[8]: ../../../learn/basics/duplicates.md
[5]: howto/index.md
[6]: update.md
[9]: ../../learn/search-criteria.md
[14]: ../../../saint/learn/index.md

<!-- Referenced images -->
