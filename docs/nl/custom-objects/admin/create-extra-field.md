---
uid: help-nl-extra-fields-create
title: Extra velden toevoegen
description: Extra velden toevoegen
keywords: extra veld, aangepast veld
author: Bergfrid Dias
date: 04.09.2024
version: 10.3.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/custom-objects/learn/extra-field/create
index: true
---

# Extra velden toevoegen

Nadat u een [extra tabel][1] hebt gemaakt, moet u velden in de tabel instellen, zodat u vervolgens gegevens (vermeldingen) in de tabel, kunt invoeren. U kunt ook extra velden in de standaardtabellen toevoegen.

## Stappen

1. [!include[Ga naar Tabellen](includes/goto-tables.md)]

1. Blader naar uw gewenste tabel, wijs naar de tabelnaam en klik op **Nieuw veld**.

    ![Extra veld aanmaken -screenshot][img1]

1. Selecteer een type voor het nieuwe veld en klik op **OK**.

1. In het scherm **Veldeigenschappen**, voer gegevens in over het nieuwe veld.

    * Voer een *naam* in die als label wordt gebruikt.
    * Voer een *databaseveld* in dat begint met **x_** om het in het schema te identificeren.
    * Optioneel stel andere eigenschappen in. Het type (gespecificeerd in stap 3) bepaalt wat beschikbaar is. Zie details over de velden hieronder.

    > [!TIP]
    > Om een veld verplicht te maken, selecteer **Mag niet leeg zijn**.

1. Klik op **OK** om het nieuwe veld op te slaan (voert `alter table y_mynewtable add column x_mynewfield ...` uit).

1. Ga door met het toevoegen van meer velden.

1. Klik op **NetServer opnieuw starten** als u klaar bent. Als Travel is geactiveerd, ziet u ook een bericht dat er een nieuwe Travel-database moet worden gegenereerd.

## Veldeigenschappen

| Veld | Beschrijving |
|---|---|
| Mag niet leeg zijn | Als deze optie is aangevinkt, wordt dit veld verplicht. |
| Selecteren in keuzelijst | als het veld is gekoppeld aan een extra tabel, selecteert u deze optie om een lijst met tabelwaarden weer te geven. |
| Waarden uit de lijst kiezen | Als deze optie is ingeschakeld, wordt het veld een keuzelijst. De opties in de lijst zijn de tekenreeksen die in het tekstvak ingevuld worden. Er is één regel per optie. |
| Index maken | Geef op of het veld moet worden geïndexeerd. U vindt sneller gegevens in geïndexeerde velden. |
| Databaseveld | de naam die de kolom in de database zal hebben. Deze naam moet uniek zijn in deze tabel. Bovendien moet de kolomnaam een enkel woord zijn, met alleen onderstrepingstekens, letters van a tot z of cijfers en de naam moet beginnen met 'x_'. Kan alleen worden opgegeven wanneer het veld is gemaakt; **het kan later niet meer worden gewijzigd**. |
| Aantal decimalen | het aantal decimalen dat is toegestaan in een getal. |
| Standaardwaarde | De standaardwaarde wordt voor dit veld gebruikt. |
| Beschrijving | de standaardbeschrijving. |
| Waarde weergeven | Geef op of de waarde moet worden weergegeven. |
| Extern | Als deze optie is aangevinkt, is het veld beschikbaar via een Customer Centre. Alleen relevant voor standaardtabellen, omdat extra tabellen altijd worden weergegeven in Customer Centres. |
| Koptekst voor lijst | dit veld wordt gebruikt om een koptekst op te geven voor deze items wanneer ze worden weergegeven als 'sub-items' in een lijst. |
| Functieknoppen verbergen | (relaties) selecteer deze optie om de functie voor het toevoegen van nieuwe items aan de relatietabellen te verbergen. |
| Veld verbergen | Geef op of het veld moet worden weergegeven. |
| HTML-tags behouden | (tekst) selecteer deze optie om de HTML-tag in de tekst op te nemen. |
| Naam | de naam van het veld. |
| Aantal eenheden | (tijdspanne) voer het maximumaantal eenheden voor de 'grootste' geselecteerde tijdseenheid in. Bijvoorbeeld: Als u uren en minuten hebt geselecteerd en daarna '4' invoert, kan een maximum van 4 uur worden geselecteerd, terwijl minuten tot 60 gaan. Zo ook voor dagen en uren, er kunnen dan maximaal 4 dagen worden geselecteerd, terwijl u tot 24 uur kunt gaan. |
| Alleen leaf-knooppunten toestaan voor hiërarchische keuzelijsten | (extra tabelrelatie) geeft aan dat alleen knooppunten op het laagste niveau kunnen worden gekozen door de gebruiker. |
| Functie | geeft de positie aan van het veld tussen de andere velden in lijsten. |
| Zoekoperator | Selecteer de te gebruiken zoekoperator voor dit veld. |
| Weergeven in tabel | Als deze optie is ingeschakeld, wordt dit veld weergegeven als een kolom in schermen waarin verschillende vermeldingen in een tabel worden weergegeven. |
| Een-op-veel-relaties weergeven | Als u de veldtypen **Persoonsrelatie**, **Bedrijfsrelatie** of **Verzoekrelatie** hebt geselecteerd en een tabblad met gegevens uit deze tabel wilt weergeven in de persoons-, bedrijfs- of verzoekschermen, kunt u dit veld aanvinken. |
| Tabel | geeft het veld aan waarvan de tabel deel uitmaakt. |
| Targettabel | geeft aan welke tabel gebruikt moet worden. |
| Tekstgebied /hoogte | selecteer deze optie om de hoogte (aantal regels) van het tekstveld op te geven. |
| Type | Hier wordt het veldtype weergegeven dat u hebt geselecteerd. |
| Null-waarden nu bijwerken | Schakel deze optie in om alle null-waarden (lege velden) in de database te vervangen door de standaardwaarde. Deze bewerking kan een tijdje duren. |
| URL | voer de URL van de dynamische koppeling hier in. |
| Actieve gebruiker als standaardwaarde gebruiken | Als deze optie is ingeschakeld, wordt de waarde van het veld standaard ingesteld als de huidige gebruiker. |
| Huidige datum/tijd als standaardwaarde | Als deze optie is ingeschakeld, wordt de waarde van het veld standaard ingesteld als de huidige datum/tijd. |
| Dagen gebruiken / Uren gebruiken / Minuten gebruiken | selecteer de tijdseenheden die u wilt gebruiken in het veld met de tijdspanne. |
| Standaardwaarde gebruiken | Als deze optie is ingeschakeld, wordt aan het veld een standaardwaarde toegewezen, tenzij anders aangegeven. |
| Weergeven in relationele kiezers | als de huidige tabel een relatie heeft met een andere tabel (extra tabelrelatie), selecteert u deze optie om dit veld beschikbaar te maken als een zoekveld. Bijvoorbeeld: U hebt een extra tabel gemaakt met de naam 'Producten' met een extra tabelrelatie naar de tabel **Verzoeken**. Op deze manier kunt u producten zoeken en toevoegen op het tabblad **Extra velden** wanneer u nieuwe verzoeken maakt. Door **Weergeven in relationele kiezers** te selecteren voor specifieke velden in de tabel 'Producten' zijn deze velden beschikbaar als zoekvelden op het tabblad **Extra velden**. |

## Relatie toevoegen (vreemde sleutel, FK)

1. Klik op **Nieuw veld**.
1. Selecteer het relatie type voor de entiteit waarmee u wilt verbinden en klik op **OK**.

    > [!NOTE]
    > Beschikbaar vanaf versie 10.3.4 in pilot: Het selecteren van **Eén-op-veel-relaties weergeven** voegt een sectietabblad (archief) toe aan gerelateerde standaardentiteiten.

1. Stel veld eigenschappen in zoals hierboven beschreven.
1. Klik op **OK** om de relatie op te slaan.
1. Klik op **NetServer opnieuw starten** om de wijzigingen toe te passen.

Bijvoorbeeld, om alle binnenkomende verzoeken te verbinden met een specifieke verkoop, kunt u een extra veld van het type verkooprelatie toevoegen aan verzoeken ([ticket tabel][4]). Om verbonden verzoeken te tonen bij het bekijken van een verkoop in SuperOffice CRM, moet u een webpaneel bouwen.

<!-- Referenced links -->
[1]: create-extra-table.md
[4]: ../../../en/database/tables/ticket.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/custom-objects/create-extra-tables-and-fields.png
