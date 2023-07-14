---
uid: help-nl-find-screen
title: Scherm zoeken
description: Scherm zoeken
author: SuperOffice RnD
so.date: 05.25.2023
keywords: zoeken, zoeken
so.topic: howto
language: nl
---

# Het scherm Zoeken

Gebruik het scherm **Zoeken** voor het zoeken in SuperOffice CRM naar records en gegevens.

Er zijn feitelijk geen beperkingen op waar u naar kunt zoeken in SuperOffice CRM. Aan het einde van deze sectie hebben we voorbeelden opgenomen om u tips te geven over het zoeken.

> [!NOTE]
> Als u een licentie hebt voor SuperOffice Integration Server, kunt u naar producten zoeken in bestaande offerten. Als u een licentie hebt voor SuperOffice Service, kunt u naar verzoeken zoeken.

## Stappen

1. Klik op de knop **Zoeken** op de [bovenste balk][1].

    ![Zoeken][img2]

2. Klik op het type record dat u wilt zoeken of klik op **Typische zoekopdrachten** om een lijst met vooraf gedefinieerde zoekopdrachten weer te geven. Het tabblad **Criteria** wordt geopend.

3. Het scherm **Zoeken** bevat vooraf gedefinieerde zoekcriteria of de zoekcriteria die u de laatste keer hebt gebruikt. Voer een van de volgende handelingen uit:

    * Klik op ![pictogram][img3] als u de criteria wilt verwijderen die u niet wilt gebruiken.
    * Om een nieuw zoekcriterium toe te voegen, klikt u op de knop **Toevoegen**. Er wordt een nieuwe regel aan de criterialijst toegevoegd.

4. Selecteer in de eerste keuzelijst op de regel het veld waarin u naar informatie wilt zoeken. U kunt ook het [begin van de naam invoeren in het juiste veld][2]. Er zijn[verschillende typen velden][3].

    Selecteer bijvoorbeeld **Persoon**en **Achternaam** om te zoeken naar personen of **Project** en **Gebeurtenisdatum** om te zoeken naar projecten.

5. Selecteer waarden voor de zoekcriteria in de volgende velden op de regel.

6. U kunt nogmaals op de knop **Toevoegen** onder de criterialijst klikken om meer zoekcriteria op te geven. Er wordt een nieuwe regel aan de criterialijst toegevoegd en u kunt stappen 4 en 5 herhalen.

7. Klik en sleep als u criteria wilt verplaatsen ![pictogram][img4].

8. Klik op **Of** als u een andere set criteria wilt toevoegen.

9. Wanneer u alle gewenste zoekcriteria hebt opgegeven en geactiveerd, klikt u op de knop **Zoeken**. Het **tabblad Resultaten** opent met de resultaten die overeenkomen met de zoekcriteria.

> [!TIP]
> Als u bijvoorbeeld naar alle bedrijven wilt zoeken, kunt u het percentageteken (%) opgeven wanneer u [zoekcriteria invoert][3] voor **Bedrijf**.

## <a id="or" />Verbreed uw zoekopdracht met behulp van de OR-functie

Met de functie Zoeken kunt u een zoekopdracht uitvoeren door zoekcriteria te combineren met de waardeoperator "OR" ertussen. Op deze manier kunt u zoeken naar twee sets onafhankelijke gegevens en deze opslaan in één selectie.

Laten we eens kijken hoe u de OR-functie kunt gebruiken. U kunt zoeken naar alle klanten die "Product A" hebben gekocht en klanten die "Product B" niet hebben gekocht om uw cross-verkopen te stimuleren. Of u kunt zoeken naar alle grote klanten in Rotterdam of Eindhoven, zodat u contact met hen kunt opnemen over een aankomende gebeurtenis in een van deze steden.

Bekijk deze video om te zien hoe u een zoekopdracht maakt met de OF-functie (duur van de video - 4:08):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/Z-fSLJSdp2k]

## <a id="results" />Werken met zoekresultaten

Nadat de bovenstaande procedure gedaan is en de zoekresultaten in het tabblad **Resultaten** staan, hebt u verschillende opties:

* **Het record openen:** Als u een van de records wilt openen, dubbelklikt u erop. Als u bijvoorbeeld dubbelklikt op een persoon, wordt het sectietabblad **Personen** weergegeven met deze persoon gemarkeerd.

* **Een record weergeven in het zijpaneel:** Gebruik het [zijpaneel][4] om snel door de zoekresultaten te bladeren. Als u naar personen hebt gezocht, selecteert u **Personen** in de lijst boven aan het zijpaneel. U kunt vervolgens op een persoon in het tabblad **Resultaten** klikken om deze persoon weer te geven.

* **Taken uitvoeren op de zoekresultaten:** De knop **Taak** bevat taken zoals:

  * Een mailing versturen en activiteiten maken
  * De informatie in uw selectie beheren
  * Uw gegevens afdrukken of exporteren
  * De informatie in uw selectie uit uw CRM-database verwijderen

    ![Een lijst met mogelijke taken waarvoor u uw zoekresultaat kunt gebruiken -screenshot][img10]

    Het is afhankelijk van het weergegeven type records welke taken worden weergegeven. [Lees meer][7]

* **Records aan een selectie toevoegen:** Klik op de knop **Opslaan als selectie**. Zie [Selecties maken][8].

* Selecteer records, klik met de rechtermuisknop en selecteer **Toevoegen aan selectie**. Zie [Leden toevoegen aan statische selecties][9].

## <a id="ex1" />Voorbeeld 1: zoeken naar winstgevende klanten

Als manager van een verkoopafdeling wilt u een presentatie geven voor de rest van het management waarin u presenteert wat u sinds de laatste vergadering hebt bereikt. U wilt zich richten op winstgevende klanten (klanten waar u onlangs veel aan hebt verkocht).

1. Klik op de knop **Zoeken**.

2. Klik op **Bedrijf zoeken**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klik op **Toev.**

5. [!include[Select field](includes/select-field.md)]. Klik eerst op **Verkoop** ![pictogram][img5] en vervolgens op **Bedrag**.

6. Klik in de keuzelijst rechts van **Bedrag** op de pijl ![pictogram][img1] en selecteer **>** (groter dan).

7. Voer in het laatste veld op de regel het minimumbedrag in. Bijvoorbeeld, "100 000".

8. U hebt nu opgegeven dat u bedrijven wilt zoeken met verkopen boven het ingevoerde bedrag, maar u bent nog niet klaar. U wilt ook een periode opgeven.

9. Klik op **Toevoegen**.

10. [!include[Select field](includes/select-field.md)]. Klik eerst op **Verkoop** ![pictogram][img5] en vervolgens op **Geregistreerde datum**.

11. Klik in de tweede keuzelijst op de pijl ![pictogram][img1] en selecteer **Tussen**.

12. Geef in de derde keuzelijst de begindatum op van de gewenste periode en in de vierde keuzelijst de einddatum.

13. U hebt nu opgegeven dat u bedrijven wilt zoeken met verkopen boven 100.000 binnen de opgegeven periode. We willen de zoekopdracht echter ook beperken tot verkopen met de status **Verkocht**.

14. Klik op **Toev.**

15. Voer in de weergegeven lijst "Status" in om snel te zoeken in het veld.

16. Selecteer **Verkoop** - **Status** in de lijst die wordt weergegeven (met het verkooppictogram ![pictogram][img5] ervoor).

17. Selecteer in de tweede keuzelijst **Is een van**.

18. Klik op het veld **Items selecteren** rechts van het veld **Is een van** en selecteer **Verkocht**.

19. U hebt nu opgegeven dat u bedrijven wilt vinden met een omzet boven een bepaald bedrag binnen een bepaalde periode en met status **Verkocht**.

20. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

21. [!include[Explore results](includes/use-results.md)]

<!-- markdownlint-disable-next-line MD013 -->
## <a id="ex2" />Voorbeeld 2: zoeken naar klanten in Denemarken waarvoor u verantwoordelijk bent

Stelt u zich voor dat u deelneemt aan een conferentie in Denemarken. Als u daar bent, wilt u van de gelegenheid gebruikmaken enkele klanten te bezoeken. U begint uw planning door alle klanten in Denemarken te zoeken waarvoor u verantwoordelijk bent.

1. Klik op de knop **Zoeken**.

2. Klik op **Bedrijf zoeken**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klik op **Toev.**

5. [!include[Select field](includes/select-field.md)]: Klik eerst op **Bedrijf** ![pictogram][img6] en vervolgens op **Land**.

6. Selecteer in de tweede keuzelijst **Is een van**.

7. Klik op het veld **Items selecteren** rechts van het veld **Is een van** en selecteer **Denemarken**.

8. U hebt nu opgegeven dat u bedrijven in Denemarken wilt zoeken, maar u bent nog niet helemaal klaar. U wilt de zoekopdracht beperken tot bedrijven in Denemarken waarvoor u verantwoordelijk bent.

9. Klik op **Toevoegen**.

10. [!include[Select field](includes/select-field.md)]: Klik eerst op **Bedrijf** ![pictogram][img6] en vervolgens op **Onze contactpersoon**.

11. Selecteer **Huidige gebruiker** in de tweede keuzelijst. Uw naam wordt weergegeven in het laatste veld op de regel.

12. U hebt nu opgegeven dat u bedrijven in Denemarken wilt zoeken waarvoor u de contactpersoon bent.

13. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

14. [!include[Explore results](includes/use-results.md)]

## <a id="ex3" />Voorbeeld 3: zoeken naar verkochte verkopen

Veronderstel, u bent manager van een bedrijf en wilt weten welke typen verkoop goed verlopen en waarom, met als doel meerdere hiervan te bewerkstelligen. U begint met het zoeken naar verkopen met de status **Verkocht**.

1. Klik op de knop **Zoeken**.

2. Klik op **Verkoop zoeken**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klik op **Toev.**

5. [!include[Select field](includes/select-field.md)]: Klik eerst op **Verkoop** ![pictogram][img5] en vervolgens op **Status**.

6. Selecteer in de tweede keuzelijst **Is een van**.

7. Klik op het veld **Items selecteren** rechts van het veld **Is een van** en selecteer **Verkocht**. U hebt nu opgegeven dat u naar voltooide verkopen wilt zoeken.

8. [!include[Click Find](includes/run-search.md)]

9. [!include[Explore results](includes/use-results.md)]

<!-- markdownlint-disable-next-line MD013 -->
## <a id="ex4" />Voorbeeld 4: zoeken naar projecten waaraan u het afgelopen jaar hebt deelgenomen

Stelt u zich voor dat de tijd voor uw betalingsoverzicht nadert en u denkt dat u beter betaald zou moeten worden voor uw inspanningen. U wilt uw baas laten zien hoe actief en veelzijdig u bent, en wilt hun daarom vertellen over de projecten waar u het afgelopen jaar bij betrokken bent geweest.

1. Klik op de knop **Zoeken**.

2. Klik op **Verkoop zoeken**.

3. [!include[Clear criteria](includes/clear-criteria.md)] gevens te wissen.

4. Klik op **Toev.**

5. [!include[Select field](includes/select-field.md)]: Klik eerst op **Persoon** ![pictogram][img7] en vervolgens op **Achternaam**.

6. Selecteer **Is gelijk aan** in de tweede keuzelijst.

7. Voer in het derde veld uw achternaam in.

8. U hebt nu opgegeven dat u projecten wilt zoeken waaraan u hebt deelgenomen, maar u bent nog niet klaar. U wilt ook een periode opgeven.

9. Klik op **Toevoegen**.

10. [!include[Select field](includes/select-field.md)]: Klik eerst op **Project** ![pictogram][img8] en vervolgens op **Datum vanaf**.

11. Selecteer **Na** in de tweede keuzelijst.

12. Voer in de derde keuzelijst de begindatum voor de gewenste periode in.

13. U hebt opgegeven dat u projecten wilt vinden waaraan u hebt deelgenomen, vanaf een bepaalde datum tot vandaag.

14. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

15. [!include[Explore results](includes/use-results.md)]

## <a id="ex5" />Voorbeeld 5: zoeken naar ondernomen marketinginitiatieven

Stelt u zich voor dat u manager van een marketingafdeling bent en wilt brainstormen over toekomstige marketinginitiatieven. Als basis hiervoor wilt u een overzicht ophalen van de marketinggerelateerde vervolgacties die u het afgelopen kwartaal hebt ondernomen.

1. Klik op de knop **Zoeken**.

2. Klik op **Verkoop zoeken**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klik op **Toev.**

5. [!include[Select field](includes/select-field.md)]: Klik eerst op **Vervolgactiviteit** ![pictogram][img9] en vervolgens op **Intentie**.

6. Selecteer in de tweede keuzelijst **Is een van**.

7. Klik op het veld **Items selecteren** rechts van het veld **Is een van** en selecteer **Marketing**.

8. U hebt nu opgegeven dat u marketing-gerelateerde vervolgactiviteiten wilt zoeken, maar u bent nog niet helemaal klaar. U wilt ook een periode opgeven.

9. Klik op **Toevoegen**.

10. [!include[Select field](includes/select-field.md)]. Klik eerst op **Vervolgactiviteit** ![pictogram][img9] en vervolgens op **Einddatum**.

11. Selecteer **Vorige** in de tweede keuzelijst.

12. Voer 1 in de derde keuzelijst in.

13. Selecteer **Kwartaal (kwartalen)** in de vierde keuzelijst.

14. U hebt nu opgegeven dat u vervolgacties voor marketing in het vorige kwartaal wilt zoeken, maar u bent nog steeds niet helemaal klaar. We willen de zoekopdracht ook beperken tot voltooide vervolgactiviteiten.

15. Klik op **Toevoegen**.

16. Selecteer in de lijst die wordt weergegeven het veld waarin u naar gegevens wilt zoeken. Klik eerst op **Vervolgactiviteit** ![pictogram][img9] en vervolgens op **Voltooid**.

17. Selecteer **Ja**. U hebt nu opgegeven dat u wilt zoeken naar vervolgactiviteiten met de status **Voltooid**.

18. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

19. [!include[Explore results](includes/use-results.md)]

## Wat wilt u nu doen?

* [Taken uitvoeren][7]
* [Vrije-tekst zoekbewerking gebruiken][5]
* [Snel zoeken gebruiken][2]
* [De historielijst gebruiken][6]
* [Zoekcriteria gebruiken][3]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/buttons-in-menu-bar.md
[4]: ../../learn/getting-started/main-screen/side-panel.md
[2]: in-navigator.md
[3]: search-criteria.md
[5]: freetext-search.md
[6]: ../../learn/basics/history.md
[7]: ../selection/learn/howto/index.md
[8]: ../selection/learn/create/index.md
[9]: ../selection/learn/update/add-remove-members-static.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/dropdown-icon.png
[img2]: ../../../media/loc/en/learn/find.png
[img3]: ../../../../common/icons/delete-circle-red.png
[img4]: ../../../media/icons/criteria-move.png
[img5]: ../../../../common/icons/singlecolour/sale.png
[img6]: ../../../../common/icons/singlecolour/contact.png
[img7]: ../../../../common/icons/singlecolour/person.png
[img8]: ../../../../common/icons/singlecolour/project.png
[img9]: ../../../../common/icons/singlecolour/appointment.png
[img10]: ../../../media/loc/en/search-options/task-menu.png
