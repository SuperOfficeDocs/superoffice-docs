---
uid: help-sv-bulk-update
title: Massredigering
description: Med massuppdatering kan du ändra information för en stor samling kontakter, aktiviteter, försäljningar, projekt med mera.
keywords: massredigering
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/search-options/selection/learn/howto/bulk-update
---

# Uppdatera flera poster (massuppdatering)

Med hjälp av uppgiften Massuppdatering kan du ändra värden i flera uppgifter av samma typ. Du kan utföra massredigeringen på alla eller utvalda poster på detaljkort (arkiv), urval och fönstret **Sök**. Du kan uppdatera vissa värden och rensa vissa värden. Den här uppgiften kan också användas för att ta bort flera poster.

> [!NOTE]
> Du behöver specifika behörigheter för att kunna använda massuppdatering. Dessa behörigheter tilldelas i Inställningar och underhåll.

## Steg

1. Öppna urvalet, detaljkortet (arkiv) eller sökresultaten (fönstret **Sök**) som innehåller uppgifterna du vill uppdatera.

2. Urval: Klicka på **Uppgift**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) och välj **Massredigering**.
    eller
    Välj de poster du vill uppdatera, högerklicka på dem och välj **Massredigering...**.
    Dialogrutan **Massredigering** öppnas. Längst ned i den här dialogrutan kan du se typ av uppgift och hur många uppgifter som ska uppdateras. Exempel: Antal kontakter i kö för massredigering: 7.

    > [!NOTE]
    > Om urvalet innehåller både företag och kontakter finns två flikar: **Företag** och **Kontakt**.

3. Välj ett fält som ska uppdateras i kolumnen **Fält**. Du kan även skriva in namnet i fältet. När du skriver in bokstäver visar listan nedan alla matchningar som är relevanta för de valda posterna.

4. Välj en åtgärd i kolumnen **Åtgärd**. Vilka åtgärder som är tillgängliga beror på typen av fält som du valde i föregående steg. Exempel:

    * **Välj**: Markera eller ta bort markering av kryssruta.
    * **Byta**: Ta bort markering av en markerad kryssruta och tvärtom.
    * **Sök och ersätt**: [Sök text och ersätt den](#search-and-replace).
    * **Regex**: Uppdatera med [reguljära uttryck](#regex).
    * **Ange**: Använd ett nytt värde i fältet.
    * **Radera**: Ta bort alla värden i fältet.
    * Åtgärder för listor: Välj eller ta bort enskilda eller flera olika värden för listfält.
    * Åtgärder för aktivitetslänkar: Lägg till, ta bort eller ersätt aktivitetslänkar eller ta bort alla aktivitetslänkar.

5. Om du vill lägga till flera fält som ska uppdateras klickar du på **Lägg till** och upprepar steg 3 och 4.

6. Se till att du markerar (<i class="ph ph-check" aria-hidden="true"></i>) fälten du vill uppdatera och ta bort markeringen på de fält du INTE VILL uppdatera.

7. Klicka på **Uppdatera**. Dialogrutan **Bekräfta** öppnas och visar en översikt över uppdateringarna.

8. Klicka på **Ja** för att implementera ändringarna i de valda posterna.

    > [!CAUTION]
    > När en uppdatering har tillämpats kan den inte ångras. Du kan dock stoppa uppdateringen medan den pågår. Poster som ännu inte har uppdaterats förblir oförändrade.

9. Klicka på **Logg** för att visa ändringsloggen. Om några poster inte uppdaterades registreras orsaken till detta i kolumnen **Orsak**.

10. Klicka på **Stäng**.

## <a id="search-and-replace"></a>Sök och ersätt

Med hjälp av åtgärden **Sök och ersätt** kan du hitta en viss text i ett fält och ersätta den.

1. Välj **Sök och ersätt** i kolumnen **Åtgärd**.
2. Skriv in texten som ska ersättas i **Sök**-fältet.
3. Skriv in ersättningstexten i **Ersätt med**-fältet.
4. Valfritt: Klicka på ett **Alternativ** och välj konfiguration om du vill skilja stora och små bokstäver och söka efter hela eller delar av ord.

## <a id="regex"></a>Reguljära uttryck

Med åtgärden **Regex** kan du använda reguljära uttryck för att uppdatera ett fält.

1. Välj **Regex** i **Åtgärd**-kolumnen.
2. Skriv in uttrycket i **Uttryck**-fältet.
3. Skriv in ersättningstexten i **Ersätt med**-fältet.
4. Valfritt: Klicka på **Alternativ** och välj Inställningar för det reguljära uttrycket.

## Exempel

## Uppdatera företagskategorier

Du vill kategorisera kunderna efter försäljningsbelopp. Skapa företagskategorier kallade "Kund A", "Kund B" och "Kund C" i SuperOffice CRM. För "Kund A" kan du skapa ett urval av företag som hade ett försäljningsbelopp på över 50 000 EUR i fjol. Använd **Massredigering** för att uppdatera kategorin för de här kunderna till "Kund A". Upprepa detta för de andra företagen.

## Uppdatera postnummer och ort för företag

Postnummer och postorter i Norge har förändrats. Använd **Massredigering** för att uppdatera adresser.

## Uppdatera kontakt

Du har upptäckt att fältet **Ställning** för kontakter sällan används. För att komma igång med uppgiften att fylla i det här fältet för alla kontakter vill du söka efter alla kontakter som har direktör i titeln. Skapa ett urval av alla kontakter som innehåller ordet "direktör" i **Titel**-fältet. Använd **Massredigering** för att ange **Ledning** för fältet **Ställning**.

## Uppdatera projekt

Du vill röja upp bland alla "gamla" projekt som inte har angetts som slutförda. Skapa ett urval av alla dina gamla projekt, till exempel alla projekt som går mer än 2 år bakåt i tiden och som inte har uppdaterats det senaste året. Använd **Massredigering** för att ställa in status **Slutförd** för de här projekten till **Ja**.

## Relaterat innhåll

* [Hur fyller jag i fälten "Rättslig grund", "Samtyckeskälla" och "Syfte" för flera kontakter samtidigt i SuperOffice CRM?][3]
* [Ta bort flera kontakter och företag samtidigt från ett urval][1]

<!-- Referenced links -->
[1]: ../../security/privacy/learn/mass-delete.md
[3]: ../../../en/security/privacy/learn/edit-legal-base.md#bulk
