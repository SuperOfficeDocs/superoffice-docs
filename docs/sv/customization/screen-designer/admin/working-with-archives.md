---
uid: help-sv-screen-designer-archive
title: Arbeta med detaljkort (arkiv)
description: Skärmdesigner - arbeta med detaljkort (arkiv)
keywords: lägg till sektionsflik, ny sektionsflik, lägg till arkivflik, anpassa sektionsflik, sektionsfliklayout
author: Bergfrid Dias
date: 10.09.2025
version: 10.2.11
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: sv
index: true
redirect_from:
  - /sv/ui/screen-designer/learn/edit-layout-archives
  - /sv/customization/screen-designer/working-with-archives
---

# Arbeta med detaljkort (arkiv)

Du kan anpassa layouten genom att lägga till eller ta bort detaljkort (även kallade arkiv) på huvudkorten för företag, kontakt, försäljning, projekt och ärende.

Att anpassa detaljkort görs vanligtvis för att möta de specifika behoven hos olika användargrupper. Du kan skapa en layout som är skräddarsydd för en viss användargrupp och se till att flikarna visar relevant innehåll för den gruppen.

![Lägg till namnet på det nya detaljkortet och välj de användargrupper som det ska visas för -screenshot][img6]

## Förstå detaljkort

Detaljkort, som finns längst ner på de flesta SuperOffice CRM-skärmar, visar relaterade data som kontakter, aktiviteter, projekt och försäljningar. Även om vissa detaljkort, som säljguider och offerter, inte är arkiv, kommer vi för enkelhetens skull att referera till alla som arkiv eller arkivflikar.

När du skapar en ny layout för en användargrupp bör du överväga vilken data de behöver mest. Genom att anpassa arkiv kan du filtrera och prioritera information, vilket gör det lättare för användarna att hitta det de behöver.

## Lägg till arkiv

Du kan lägga till ett nytt detaljkort på vilken skärm som helst med ett detaljkortsområde. Beroende på vald skärm kan du lägga till en ny flik med innehåll av: dokument, bokning, produkt, projekt, projektmedlem, försäljning, säljintressent, ärende, kontakt och relation.

![Välj vilken typ av innehåll du vill visa på detaljkortet -screenshot][img5]

**Steg:**

1. Öppna Skärmdesignern.

1. Välj högst upp en skärm att anpassa och klicka på **Arkiv**.

1. Välj en layout från listan och klicka på **Redigera layout** under förhandsgranskningen.

1. Klicka på **Lägg till** för att öppna avsnittet **Flik**.

1. Ersätt "Ny flik" med arkivnamnet och ange en beskrivning för den nya layouten.

    Du kan också klicka på <i class="ph ph-translate" aria-label="Translate"></i> bredvid etiketten för att lägga till texten på andra språk.

1. Justera **Unikt namn för kortet** (soprotocol) vid behov.

1. Välj i avsnittet **Inställningar** vilken datatyp (innehåll) som ska visas i arkivet.

    Data är begränsade till den aktuella skärmen. Om du till exempel lägger till ett arkiv på Företagsskärmen visas endast data som är kopplade till det **aktuella** företaget.

1. Lägg till eller redigera kriterier under **Filter** för att förfina den visade datan. Dessa kriterier fungerar på samma sätt som [sökfiltren på **Sök**-skärmen][2] och i urval.

    Klicka på **Uppdatera förhandsgranskning** för att se den filtrerade datan.

1. (Valfritt) Använd **Avancerade alternativ** för att anpassa enkel- och dubbelklicksåtgärder. Som standard kommer ett enkelklick att välja en rad och ett dubbelklick att öppna en post/entitet i SuperOffice.

    > [!TIP]
    > Håll muspekaren över <i class="ph ph-info" aria-label="Info"></i> för exempel.

1. Dra arkivet till önskad position i förhandsgranskningen.

1. Välj **Spara utkast** eller **Spara + Publicera** för att spara dina ändringar. Klicka på **Avbryt** för att förkasta dina ändringar.

## Redigera befintligt arkiv

För att ändra ett befintligt detaljkort, välj det och uppdatera fälten och inställningarna i avsnitten **Flik** och **Inställningar**. Du kan även ändra flikens position genom att dra den.

### Begränsningar

* Standardflikar kan inte redigeras.

* Vissa flikar, såsom **Offert**, **Säljguide** och **Projektguide**, kan inte redigeras eftersom de har specifika funktioner.

## Ta bort ett arkiv

1. Välj arkivet eller detaljkortet.

1. Klicka på **Uppgift** > **Ta bort flik**.

1. Bekräfta genom att klicka på **OK**. Fliken kommer att döljas, men inte tas bort.

![Klicka på Uppgift och sedan Ta bort flik för att ta bort oönskade flikar i detaljkortet (arkiv) -screenshot][img1]

För att ångra dessa ändringar, klicka på **Återställ flikar**.

## Relaterat innehåll

* [Skapa ny layout][4]

<!-- Referenced links -->
[2]: ../../../search-options/learn/search-criteria.md
[4]: add-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/admin-screendesigner-edit-archive.png
[img5]: ../../../../media/loc/en/customization/admin-screendesigner-edit-archive-add-tab.png
[img6]: ../../../../media/loc/en/customization/admin-screendesigner-add-archive-layout.png
