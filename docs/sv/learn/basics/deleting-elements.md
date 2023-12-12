---
uid: help-sv-basics-delete
title: Ta bort objekt
description: "Så här slår du samman, tar bort och återställer objekt."
author: SuperOffice RnD
so.date: 03.07.2023
keywords: ta bort, återställ, papperskorg
so.topic: howto
language: sv
---

# Ta bort och återställa objekt

För att du ska kunna vara effektiv när du arbetar med kunder och kontakter är det viktigt att du har en välorganiserad och "skräpfri" miljö. När du lägger till nya företag och kontakter ska du dubbelkolla att de inte har lagts till tidigare. Och naturligtvis, se till att du lägger till korrekt information om företag och kontakter. Ta även bort företag och kontakter som inte används och slå ihop dubbletter.

## Slå ihop företag och kontakter

Om du hittar duplicerad information ska du slå ihop den så snart som möjligt för att se till att det är lättare att hitta rätt företag och kontakt. Du kan också flytta en kontakt om den läggs till på fel företagskort. Detta gör du för att förhindra dubbletter i framtiden.

> [!NOTE]
> Den här funktionen kräver användarrättigheter, så kontakta administratören för att få tillräckliga funktionsrättigheter.

**Uppgifter:**

* [Slå ihop kontakter][4]
* [Flytta kontakt][5]
* [Slå ihop företag][1]

## Ta bort företag och kontakter

När du har lagt till fel eller duplicerad information kan det vara en bra idé att ta bort en kontakt. Det finns flera sätt att göra detta:

* [Ta bort ett företag och tillhörande data][2]
* [Ta bort en kontakt][3]
* [Massradera kontakter och/eller företag med urval][6]

När du ska ta bort en post i SuperOffice CRM öppnas dialogrutan **Ta bort händelse**, **Ta bort försäljning**, **Ta bort urval** och så vidare, beroende på vad du vill ta bort. I dialogrutan visas bland annat namnet på posten så att du kan kontrollera att du har valt rätt post.

När du har många kontakter eller företag som du måste ta bort är det bästa sättet att massradera dem att lägga till dem i ett nytt urval och använda Ta bort uppgifter på menyn Uppgift. Klicka på knappen Uppgift på markeringen och välj en av de önskade raderingsfunktionerna.

### Varför är knappen Ta bort inaktiverad (grå)?

Om knappen **Ta bort** är inaktiverad betyder det att du inte har behörighet att ta bort objektet.

Exempel:

* Du kan inte ta bort en kontakt som också är anställd i ett SuperOffice-företag.
* Du kan inte ta bort händelser, dokument, försäljningar, projekt osv. som inte tillhör dig, såvida du inte har tillräckliga användarbehörigheter.

## <a id="restore" />Återskapa borttagna företag och kontakter

När du har tagit bort något som inte var avsett att tas bort, för företag och kontakter, kan du fortfarande återställa det från papperskorgen. Detta gör det mindre skrämmande att ta bort, när du vet att du fortfarande har ett återställningsalternativ.

![Du kan återställa borttagna objekt från papperskorgen i menyn Personliga inställningar -screenshot][img3]

Borttagna företag och kontakter behålls som standard i papperskorgen i 14 dagar. Därefter tas de bort permanent.

Du har också möjlighet att återställa andra användares raderade företag och kontakter markera bara Visa borttagna företag för alla användare PÅ.

1. Välj ![ikon][img1] **Personliga inställningar** > **Papperskorg**.

2. I dialogrutan väljer du fliken **Företag** eller **Kontakt**. Företag och kontakter du tagit bort visas.

3. Valfritt: Välj **Visa borttagna företag/kontakter för alla användare**. Det här alternativet kräver funktionella behörigheter.

4. Välj de företag eller kontakter du vill återskapa.
    * Återskapande av ett företag återskapar också alla kontakter som är knutna till detta.
    * Återskapande av en kontakt för vilken företaget också blivit borttaget återskapar företaget och den valda kontakten.

    ![Använd Papperskorgen för att återskapa företag och kontakter -screenshot][img2]

5. Klicka på **Återskapa**. Företagen och kontakterna återskapas i SuperOffice.

## Knappar

| Knapp | Effekt |
|---|---|
| Ja | Bekräftar borttagning av en post i taget. |
| Ja till alla | Bekräftar borttagning av alla markerade poster. Om du till exempel har markerat fem poster så tas alla bort automatiskt när du väljer detta alternativ. |
| Nr | Avbryter borttagning av en post i taget. Dialogrutan stängs utan att någon post tas bort. |
| Avbryt | Avbryter borttagning för alla markerade poster. Dialogrutan stängs utan att någon post tas bort. |

* Du kan välja att inte visa denna dialogruta genom att: Markera **Visa inte den här dialogrutan igen** längst ned i dialogrutan för borttagning.
* Du kan välja att visa denna dialogruta igen genom att: Gå till ![ikon][img1] **Personliga inställningar** > **Inställningar** > **Funktioner** och sätt alternativet **Visa bekräftelsedialogruta** till **Nej**.

> [!NOTE]
> När du väljer att ta bort ett företag, urval eller projekt måste du alltid bekräfta borttagningen, och alternativet **Visa inte den här dialogrutan igen** är därför inte tillgängligt.

## Relaterat innehåll

* [Stoppa återkommande händelser][6]
* [Ta bort flera kontakter och företag samtidigt från ett urval][7]
* [Sökningar och urval][8]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md
[2]: ../../company/learn/delete.md
[3]: ../../contact/learn/delete.md
[4]: ../../contact/learn/merge-contacts.md
[5]: ../../contact/learn/move.md

[6]: ../../diary/learn/recurrence/stop.md
[7]: ../../search-options/selection/learn/howto/mass-delete.md
[8]: ../../search-options/selection/learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/personal-settings-small.png
[img2]: ../../../media/loc/en/learn/recycle-bin.png
[img3]: ../../../media/loc/en/learn/recycle-bin-personal-settings.png
