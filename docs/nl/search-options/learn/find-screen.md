---
uid: help-nl-find-screen
title: Scherm zoeken
description: Scherm zoeken
keywords: zoeken
author: Bergfrid Dias
date: 08.25.2025
version: 11.3
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Het scherm Zoeken <i class="ph ph-list-magnifying-glass" aria-hidden="true"></i>

Gebruik het scherm **Zoeken** voor het zoeken in SuperOffice CRM naar records en gegevens.

Er zijn feitelijk geen beperkingen op waar u naar kunt zoeken in SuperOffice CRM. Aan het einde van deze sectie hebben we voorbeelden opgenomen om u tips te geven over het zoeken.

> [!NOTE]
> Als u een licentie hebt voor Developer Tools, kunt u naar producten zoeken in bestaande offerten. Als u een licentie hebt voor SuperOffice Service, kunt u naar verzoeken zoeken.

## Stappen

1. Klik op de knop <i class="ph ph-list-magnifying-glass" aria-hidden="true"></i> **Zoeken** op de [bovenste balk][1].

1. Klik op het type record dat u wilt zoeken of klik op **Typische zoekopdrachten** om een lijst met vooraf gedefinieerde zoekopdrachten weer te geven. Het tabblad **Criteria** wordt geopend.

1. Het scherm **Zoeken** bevat vooraf gedefinieerde zoekcriteria of de zoekcriteria die u de laatste keer hebt gebruikt. Voer een van de volgende handelingen uit:

    * Klik op <i class="ph ph-x-circle" aria-label="X"></i> als u de criteria wilt verwijderen die u niet wilt gebruiken.
    * Om een nieuw zoekcriterium toe te voegen, klikt u op de knop **Toevoegen**. Er wordt een nieuwe regel aan de criterialijst toegevoegd.

1. Selecteer in de eerste keuzelijst op de regel het veld waarin u naar informatie wilt zoeken. U kunt ook het [begin van de naam invoeren in het juiste veld][2]. Er zijn[verschillende typen velden][3].

    Selecteer bijvoorbeeld **Persoon**en **Achternaam** om te zoeken naar personen of **Project** en **Gebeurtenisdatum** om te zoeken naar projecten.

1. Selecteer waarden voor de zoekcriteria in de volgende velden op de regel.

1. U kunt nogmaals op de knop **Toevoegen** onder de criterialijst klikken om meer zoekcriteria op te geven. Er wordt een nieuwe regel aan de criterialijst toegevoegd en u kunt stappen 4 en 5 herhalen.

1. Klik <i class="ph ph-equals" aria-label="="></i> en sleep als u criteria wilt verplaatsen.

1. Klik op **Of** als u een andere set criteria wilt toevoegen.

1. Wanneer u alle gewenste zoekcriteria hebt opgegeven en geactiveerd, klikt u op de knop **Zoeken**. Het **tabblad Resultaten** opent met de resultaten die overeenkomen met de zoekcriteria.

> [!TIP]
> Als u bijvoorbeeld naar alle bedrijven wilt zoeken, kunt u het percentageteken (%) opgeven wanneer u [zoekcriteria invoert][3] voor **Bedrijf**.

## <a id="or"></a>Verbreed uw zoekopdracht met behulp van de OR-functie

Met de functie Zoeken kunt u een zoekopdracht uitvoeren door zoekcriteria te combineren met de waardeoperator "OR" ertussen. Op deze manier kunt u zoeken naar twee sets onafhankelijke gegevens en deze opslaan in één selectie.

Laten we eens kijken hoe u de OR-functie kunt gebruiken. U kunt zoeken naar alle klanten die "Product A" hebben gekocht en klanten die "Product B" niet hebben gekocht om uw cross-verkopen te stimuleren. Of u kunt zoeken naar alle grote klanten in Rotterdam of Eindhoven, zodat u contact met hen kunt opnemen over een aankomende gebeurtenis in een van deze steden.

Bekijk deze video om te zien hoe u een zoekopdracht maakt met de OF-functie:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/Z-fSLJSdp2k]

(duur van de video - 4:08)

## <a id="results"></a>Werken met zoekresultaten

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

## <a id="ex1"></a>Voorbeeld 1: zoeken naar winstgevende klanten

Als manager van een verkoopafdeling wilt u een presentatie geven voor de rest van het management waarin u presenteert wat u sinds de laatste vergadering hebt bereikt. U wilt zich richten op winstgevende klanten (klanten waar u onlangs veel aan hebt verkocht).

1. Klik op de knop **Zoeken**.

1. Klik op **Bedrijf zoeken**.

1. [!include[Clear criteria](includes/clear-criteria.md)]

1. Klik op **Toev.**

1. [!include[Select field](includes/select-field.md)]. Klik eerst op **Verkoop** (<i class="ph ph-currency-circle-dollar" aria-hidden="true"></i>) en vervolgens op **Bedrag**.

1. Klik in de keuzelijst rechts van **Bedrag** op <i class="ph ph-caret-down" aria-label="Chevron"></i> en selecteer **>** (groter dan).

1. Voer in het laatste veld op de regel het minimumbedrag in. Bijvoorbeeld, "100 000".

1. U hebt nu opgegeven dat u bedrijven wilt zoeken met verkopen boven het ingevoerde bedrag, maar u bent nog niet klaar. U wilt ook een periode opgeven.

1. Klik op **Toevoegen**.

1. [!include[Select field](includes/select-field.md)]. Klik eerst op **Verkoop** en vervolgens op **Geregistreerde datum**.

1. Klik in de tweede keuzelijst op de pijl en selecteer **Tussen**.

1. Geef in de derde keuzelijst de begindatum op van de gewenste periode en in de vierde keuzelijst de einddatum.

1. U hebt nu opgegeven dat u bedrijven wilt zoeken met verkopen boven 100.000 binnen de opgegeven periode. We willen de zoekopdracht echter ook beperken tot verkopen met de status **Verkocht**.

1. Klik op **Toev.**

1. Voer in de weergegeven lijst "Status" in om snel te zoeken in het veld.

1. Selecteer **Verkoop** - **Status** in de lijst die wordt weergegeven (met het verkooppictogram ervoor).

1. Selecteer in de tweede keuzelijst **Is een van**.

1. Klik op het veld **Items selecteren** rechts van het veld **Is een van** en selecteer **Verkocht**.

1. U hebt nu opgegeven dat u bedrijven wilt vinden met een omzet boven een bepaald bedrag binnen een bepaalde periode en met status **Verkocht**.

1. [!include[Click Find](includes/run-search.md)]

## <a id="ex2"></a>Voorbeeld 2: zoeken naar klanten in Denemarken waarvoor u verantwoordelijk bent

Stelt u zich voor dat u deelneemt aan een conferentie in Denemarken. Als u daar bent, wilt u van de gelegenheid gebruikmaken enkele klanten te bezoeken. U begint uw planning door alle klanten in Denemarken te zoeken waarvoor u verantwoordelijk bent.

1. Klik op de knop **Zoeken**.

1. Klik op **Bedrijf zoeken**.

1. [!include[Clear criteria](includes/clear-criteria.md)]

1. Klik op **Toev.**

1. [!include[Select field](includes/select-field.md)]: Klik eerst op **Bedrijf** (<i class="ph ph-buildings" aria-hidden="true"></i>) en vervolgens op **Land**.

1. Selecteer in de tweede keuzelijst **Is een van**.

1. Klik op het veld **Items selecteren** rechts van het veld **Is een van** en selecteer **Denemarken**.

1. U hebt nu opgegeven dat u bedrijven in Denemarken wilt zoeken, maar u bent nog niet helemaal klaar. U wilt de zoekopdracht beperken tot bedrijven in Denemarken waarvoor u verantwoordelijk bent.

1. Klik op **Toevoegen**.

1. [!include[Select field](includes/select-field.md)]: Klik eerst op **Bedrijf** en vervolgens op **Onze contactpersoon**.

1. Selecteer **Huidige gebruiker** in de tweede keuzelijst. Uw naam wordt weergegeven in het laatste veld op de regel.

1. U hebt nu opgegeven dat u bedrijven in Denemarken wilt zoeken waarvoor u de contactpersoon bent.

1. [!include[Click Find](includes/run-search.md)]

## <a id="ex3"></a>Voorbeeld 3: zoeken naar verkochte verkopen

Veronderstel, u bent manager van een bedrijf en wilt weten welke typen verkoop goed verlopen en waarom, met als doel meerdere hiervan te bewerkstelligen. U begint met het zoeken naar verkopen met de status **Verkocht**.

1. Klik op de knop **Zoeken**.

1. Klik op **Verkoop zoeken**.

1. [!include[Clear criteria](includes/clear-criteria.md)]

1. Klik op **Toev.**

1. [!include[Select field](includes/select-field.md)]: Klik eerst op **Verkoop** en vervolgens op **Status**.

1. Selecteer in de tweede keuzelijst **Is een van**.

1. Klik op het veld **Items selecteren** rechts van het veld **Is een van** en selecteer **Verkocht**. U hebt nu opgegeven dat u naar voltooide verkopen wilt zoeken.

1. [!include[Click Find](includes/run-search.md)]

## <a id="ex4"></a>Voorbeeld 4: zoeken naar projecten waaraan u het afgelopen jaar hebt deelgenomen

Stelt u zich voor dat de tijd voor uw betalingsoverzicht nadert en u denkt dat u beter betaald zou moeten worden voor uw inspanningen. U wilt uw baas laten zien hoe actief en veelzijdig u bent, en wilt hun daarom vertellen over de projecten waar u het afgelopen jaar bij betrokken bent geweest.

1. Klik op de knop **Zoeken**.

1. Klik op **Verkoop zoeken**.

1. [!include[Clear criteria](includes/clear-criteria.md)] gevens te wissen.

1. Klik op **Toev.**

1. [!include[Select field](includes/select-field.md)]: Klik eerst op <i class="ph ph-user-circle" aria-hidden="true"></i> **Persoon** en vervolgens op **Achternaam**.

1. Selecteer **Is gelijk aan** in de tweede keuzelijst.

1. Voer in het derde veld uw achternaam in.

1. U hebt nu opgegeven dat u projecten wilt zoeken waaraan u hebt deelgenomen, maar u bent nog niet klaar. U wilt ook een periode opgeven.

1. Klik op **Toevoegen**.

1. [!include[Select field](includes/select-field.md)]: Klik eerst op <i class="ph ph-clipboard-text" aria-hidden="true"></i> **Project** en vervolgens op **Datum vanaf**.

1. Selecteer **Na** in de tweede keuzelijst.

1. Voer in de derde keuzelijst de begindatum voor de gewenste periode in.

1. U hebt opgegeven dat u projecten wilt vinden waaraan u hebt deelgenomen, vanaf een bepaalde datum tot vandaag.

1. [!include[Click Find](includes/run-search.md)]

## <a id="ex5"></a>Voorbeeld 5: zoeken naar ondernomen marketinginitiatieven

Stelt u zich voor dat u manager van een marketingafdeling bent en wilt brainstormen over toekomstige marketinginitiatieven. Als basis hiervoor wilt u een overzicht ophalen van de marketinggerelateerde vervolgacties die u het afgelopen kwartaal hebt ondernomen.

1. Klik op de knop **Zoeken**.

1. Klik op **Verkoop zoeken**.

1. [!include[Clear criteria](includes/clear-criteria.md)]

1. Klik op **Toev.**

1. [!include[Select field](includes/select-field.md)]: Klik eerst op <i class="ph ph-calendar-blank" aria-hidden="true"></i> **Vervolgactiviteit** en vervolgens op **Intentie**.

1. Selecteer in de tweede keuzelijst **Is een van**.

1. Klik op het veld **Items selecteren** rechts van het veld **Is een van** en selecteer **Marketing**.

1. U hebt nu opgegeven dat u marketing-gerelateerde vervolgactiviteiten wilt zoeken, maar u bent nog niet helemaal klaar. U wilt ook een periode opgeven.

1. Klik op **Toevoegen**.

1. [!include[Select field](includes/select-field.md)]. Klik eerst op **Vervolgactiviteit** en vervolgens op **Einddatum**.

1. Selecteer **Vorige** in de tweede keuzelijst.

1. Voer 1 in de derde keuzelijst in.

1. Selecteer **Kwartaal (kwartalen)** in de vierde keuzelijst.

1. U hebt nu opgegeven dat u vervolgacties voor marketing in het vorige kwartaal wilt zoeken, maar u bent nog steeds niet helemaal klaar. We willen de zoekopdracht ook beperken tot voltooide vervolgactiviteiten.

1. Klik op **Toevoegen**.

1. Selecteer in de lijst die wordt weergegeven het veld waarin u naar gegevens wilt zoeken. Klik eerst op **Vervolgactiviteit** en vervolgens op **Voltooid**.

1. Selecteer **Ja**. U hebt nu opgegeven dat u wilt zoeken naar vervolgactiviteiten met de status **Voltooid**.

1. [!include[Click Find](includes/run-search.md)]

## Gerelateerde inhoud

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
[8]: ../selection/learn/create.md
[9]: ../selection/learn/add-remove-members-static.md

<!-- Referenced images -->
[img10]: ../../../media/loc/en/search-options/task-menu.png
