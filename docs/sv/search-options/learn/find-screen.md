---
uid: help-sv-find-screen
title: Fönstret Sök
description: Fönstret Sök
keywords: söka, sök
author: Bergfrid Dias
date: 08.25.2025
version: 11.3
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Fönstret Sök <i class="ph ph-list-magnifying-glass" aria-hidden="true"></i>

För att söka efter poster och data i SuperOffice CRM använder du fönstret **Sök**.

Det finns i princip inga gränser för vad du kan söka efter i SuperOffice CRM. I slutet av det här avsnittet har vi inkluderat exempel för att ge dig tips kring hur man söker.

> [!NOTE]
> Om du har licens för Developer Tools kan du söka efter produkter i befintliga offerter. Om du har licens för SuperOffice Service kan du söka efter ärenden.

## Steg

1. Klicka på <i class="ph ph-list-magnifying-glass" aria-hidden="true"></i> **Sök**-knappen på [toppraden][1].

1. Klicka på den typ av post du vill söka efter eller klicka på **Vanliga sökningar** för att visa en lista med fördefinierade sökningar. Fliken **Kriterier** öppnas.

1. Fönstret **Sök** innehåller fördefinierade sökkriterier, eller de sökkriterier som du använde senast. Gör något av följande:

    * Klicka på <i class="ph ph-x-circle" aria-label="X"></i> för att bort kriterier som du inte vill använda.
    * Klicka på knappen **Lägg till** för att lägga till nya sökkriterier. Då läggs en ny rad till i kriterielistan.

1. Välj i vilket fält du vill söka efter information i den första listrutan på linjen. Du kan även [skriva in början på namnet på önskat fält][2]. Det finns [flera typer av fält][3].

    Till exempel, välj **Kontakt** och **Efternamn** om du vill söka efter kontakter eller **Projekt** och **Arrangemangsdatum** för att söka efter projekt.

1. Välj värden för sökkriterierna i de nästa fälten på raden.

1. Du kan klicka på **Lägg till** under kriterielistan igen om du vill ange fler sökkriterier. En ny rad läggs till i kriterielistan och du upprepar steg 4 och 5.

1. Om du vill flytta sökkriterier, klickar du och drar <i class="ph ph-equals" aria-label="="></i>.

1. Klicka på **Eller** för att lägga till en annan uppsättning kriterier.

1. När du har angett och aktiverat önskade sökkriterier klickar du på knappen **Sök**. Fliken **Resultat** öppnas med resultaten som matchar sökkriterierna.

> [!TIP]
> Om du till exempel vill söka efter alla företag kan du använda procenttecknet (%) när du [lägger till sökkriterier][3] för **Företag**.

## <a id="or"></a>Bredda din sökning med funktionen ELLER

Med sökfunktionen kan du utföra en sökning genom att kombinera sökkriterier med värdeoperatorn "ELLER" mellan dem. På så sätt kan du söka efter två uppsättningar oberoende data och spara dem i ett urval.

Låt oss ta en titt på några praktiska exempel på hur du kan använda funktionen ELLER. Du kan söka efter alla kunder som köpte "Produkt A" och kunder som inte köpte "Produkt B" för att öka din korsförsäljning. Eller så kan du söka efter alla stora kunder med huvudkontor i Liverpool eller Manchester, så att du kan kontakta dem om ett kommande evenemang i en av dessa städer.

Titta på den här videon om du vill lära dig hur du skapar en sökning med funktionen ELLER:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/Z-fSLJSdp2k]

(videons längd – 4:08)

## <a id="results"></a>Arbeta med sökresultat

När du har följt ovanstående steg, och det visas sökresultat längst ned i fliken **Resultat**, har du flera möjligheter:

* **.Öppna posten:** Om du vill öppna en av posterna dubbelklickar du på den. Om du t.ex. dubbelklickar på en kontakt visas detaljkortet **Kontakter** med den aktuella kontakten markerad.

* **Visa en post i sidopanelen:** Använd [sidopanelen][4] för att snabbt bläddra igenom sökresultaten. Om du har sökt efter kontakt, väljer du **Kontakter** i listan högst upp i sidopanelen. Därefter kan du klicka på respektive kontakt i fliken **Kontakt** för att förhandsgranska dem.

* **Utföra uppgifter på sökresultaten:** Knappen **Uppgift** innehåller uppgifter som:

  * Skicka ett utskick och skapa aktiviteter
  * Hantera informationen i ditt urval
  * Skriv ut eller exportera dina data
  * Ta bort informationen i ditt urval från din CRM-databas

    ![En lista över möjliga uppgifter som du kan använda sökresultatet till -screenshot][img10]

    Vilka uppgifter som visas beror på vilken typ av poster som visas. [Läs mer][7]

* **Lägga till poster till ett urval:** Klicka på knappen **Spara som urval**. Se [Skapa urval][8].

* Markera poster, högerklicka och välj **Lägg till i urval**. Se [Lägga till medlemmar i statiska urval][9].

## <a id="ex1"></a>Exempel 1: söka efter lönsamma kunder

Säg att du har ansvar för säljavdelningen och att du ska hålla en presentation för resten av ledningen för att visa vad säljavdelningen har uppnått sedan sist. Du vill fokusera på lönsamma kunder (kunder som har genomfört stora affärer den senaste tiden).

1. Klicka på **Sök**-knappen.

1. Klicka på **Sök företag**.

1. [!include[Clear criteria](includes/clear-criteria.md)]

1. Klicka på **Lägg till**.

1. [!include[Select field](includes/select-field.md)]. Klicka först på **Försäljning** (<i class="ph ph-currency-circle-dollar" aria-hidden="true"></i>) och sedan **Belopp**.

1. I listrutan till höger om **Belopp** klickar du på <i class="ph ph-caret-down" aria-label="Chevron"></i> och väljer **>** (större än).

1. I det sista fältet på raden skriver du in minimibeloppet. Till exempel "100 000".

1. Du har nu angett att du vill söka efter företag med en försäljning på över 100 000 kr, men vi är inte färdiga. Vi vill också ange period.

1. Klicka på **Lägg till**.

1. [!include[Select field](includes/select-field.md)]. Klicka först på **Försäljning**, och sedan **Registreringsdatum**.

1. I den andra listrutan klickar du på pilen och sedan **Mellan**.

1. I den tredje listrutan anger du startdatum för önskad period och i den fjärde listrutan anger du slutdatum för önskad period.

1. Du har nu angett att du vill söka efter företag med en försäljning på över 100 000 under den period du angett. Men vi är inte färdiga ännu, vi vill även begränsa sökningen till försäljningar med statusen **Såld**.

1. Klicka på **Lägg till**.

1. I listan som visas skriver du "Status" för att snabbsöka i fältet.

1. I listan som visas väljer du **Försäljning** –**Status** (med försäljningsikonen framför).

1. I den andra listrutan väljer du **Är en av**.

1. Klicka i fältet **Välj objekt** till höger om fältet **Är en av** och välj **Såld**.

1. Du har nu angett att du vill söka efter företag med en försäljning över ett visst belopp under en viss period och med statusen **Såld**.

1. [!include[Click Find](includes/run-search.md)]

## <a id="ex2"></a>Exempel 2: söka efter kunder i Danmark som du har ansvaret för

Säg nu att du ska på en konferens i Danmark. När du ändå är där vill du passa på att besöka några kunder samtidigt. Du börjar planeringen genom att söka fram alla kunder i Danmark som du har ansvaret för.

1. Klicka på **Sök**-knappen.

1. Klicka på **Sök företag**.

1. [!include[Clear criteria](includes/clear-criteria.md)]

1. Klicka på **Lägg till**.

1. [!include[Select field](includes/select-field.md)]: Klicka först på **Företag** (<i class="ph ph-buildings" aria-hidden="true"></i>) och sedan **Land**.

1. I den andra listrutan väljer du **Är en av**.

1. Klicka i fältet **Välj objekt** till höger om fältet **Är en av** och välj **Danmark**.

1. Du har nu angett att du vill söka efter företag i Danmark, men vi är inte färdiga. Vi vill begränsa sökningen till företag i Danmark som du har ansvaret för.

1. Klicka på **Lägg till**.

1. Välj i vilket fält du vill söka efter information i listan som visas: Klicka först på **Företag**, och sedan **Vår kontakt**.

1. I den andra listrutan väljer du **Aktuell användare**. Ditt namn visas i det sista fältet på raden.

1. Du har nu angett att du vill söka efter företag i Danmark, som har dig som kontakt.

1. [!include[Click Find](includes/run-search.md)]

## <a id="ex3"></a>Exempel 3: söka efter sålda försäljningar

Säg att du är ansvarig för ett företag och vill ta reda på vilken typ av försäljningar som ni lyckas med, och varför, så att ni kan lära av det och lyckas med fler försäljningar. Du börjar med att söka efter försäljningar med statusen **Såld**.

1. Klicka på **Sök**-knappen.

1. Klicka på **Sök försäljning**.

1. [!include[Clear criteria](includes/clear-criteria.md)]

1. Klicka på **Lägg till**.

1. [!include[Select field](includes/select-field.md)]: Klicka först på **Försäljning** och sedan **Status**.

1. I den andra listrutan väljer du **Är en av**.

1. Klicka i fältet **Välj objekt** till höger om fältet **Är en av** och välj **Såld**. Du har nu angett att du vill söka efter slutförda försäljningar.

1. [!include[Click Find](includes/run-search.md)]

## <a id="ex4"></a>Exempel 4: söka efter projekt du har deltagit i under det senaste året

Säg nu att det börjar bli dags för löneförhandlingar och att du anser att du bör få bättre betalt för din insats. För att visa din chef hur ihärdig och allsidig du är vill du berätta för honom eller henne om de projekt du har deltagit i det senaste året.

1. Klicka på **Sök**-knappen.

1. Klicka på **Sök försäljning**.

1. [!include[Clear criteria](includes/clear-criteria.md)]

1. Klicka på **Lägg till**.

1. [!include[Select field](includes/select-field.md)]: Klicka först på <i class="ph ph-user-circle" aria-hidden="true"></i> **Kontakt** och sedan **Efternamn**.

1. I den andra listrutan väljer du **Är lika med**.

1. I det tredje fältet skriver du in ditt efternamn.

1. Du har nu angett att du vill söka efter projekt som du har deltagit i, men vi är inte färdiga. Vi vill också ange period.

1. Klicka på **Lägg till**.

1. [!include[Select field](includes/select-field.md)]: Klicka först på <i class="ph ph-clipboard-text" aria-hidden="true"></i> **Projekt** och sedan **Från-datum**.

1. I den andra listrutan väljer du **Efter**.

1. I den tredje listrutan anger du startdatum för önskad period.

1. Du har nu angett att du vill söka efter projekt som du har deltagit i från ett visst datum och fram till idag.

1. [!include[Click Find](includes/run-search.md)]

## <a id="ex5"></a>Exempel 5: söka efter genomförda marknadsföringsåtgärder

Säg nu att du är ansvarig för marknadsavdelningen och att ni ska ha en idédag om framtida marknadsföringsteknik. För att ha något att utgå ifrån vill du skapa en översikt över vilka händelser som är knutna till marknadsföring som ni har genomfört under det föregående kvartalet.

1. Klicka på **Sök**-knappen.

1. Klicka på **Sök försäljning**.

1. [!include[Clear criteria](includes/clear-criteria.md)]

1. Klicka på **Lägg till**.

1. [!include[Select field](includes/select-field.md)]: Klicka först på <i class="ph ph-calendar-blank" aria-hidden="true"></i> **Händelse** och sedan **Syfte**.

1. I den andra listrutan väljer du **Är en av**.

1. Klicka i fältet **Välj objekt** till höger om fältet **Är en av** och välj **Marknadsföring**.

1. Du har nu angett att du vill söka efter händelser kopplade till marknadsföring, men vi är inte färdiga. Vi vill också ange period.

1. Klicka på **Lägg till**.

1. [!include[Select field](includes/select-field.md)]. Klicka först på **Händelse**, och sedan **Slutdatum**.

1. I den andra listrutan väljer du **Föregående**.

1. I den tredje listrutan anger du 1.

1. I den fjärde listrutan väljer du **Kvartal**.

1. Du har nu angett att du vill söka efter händelser med marknadsföring som syfte under det föregående kvartalet, men vi är inte färdiga ännu. Vi vill också begränsa sökningen till slutförda händelser.

1. Klicka på **Lägg till**.

1. Välj i vilket fält du vill söka efter information i listan som visas. Klicka först på **Händelse** och sedan **Slutförd**.

1. Markera **Ja**. Du har nu angett att du vill söka efter händelser som har statusen **Slutförd**.

1. [!include[Click Find](includes/run-search.md)]

## Vad vill du göra nu?

* [Utföra uppgifter][7]
* [Använd fritextsökning][5]
* [Använda snabbsökning][2]
* [Använda historiklistan][6]
* [Använda sökkriterier][3]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/buttons-in-menu-bar.md
[4]: ../../learn/getting-started/main-screen/side-panel.md
[2]: in-navigator.md
[3]: search-criteria.md
[5]: freetext-search.md
[6]: ../../learn/basics/history.md
[7]: ../selection/learn/howto/index.md
[8]: ../selection/learn/create.md
[9]: ../selection/learn/add-remove-members-static.md

<!-- Referenced images -->
[img10]: ../../../media/loc/en/search-options/task-menu.png
