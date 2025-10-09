---
uid: help-nl-customer-language-add
title: Klanttaal toevoegen
description: Meer informatie over het instellen van klanttalen vindt u in deze handleiding.
keywords: klanttaal, taal toevoegen, nieuwe klanttaal, taalcode
author: digitaldiina
date: 10.09.2025
version: 11.5
content_type: howto
category: localization
topic: language
audience: settings
audience_tooltip: Settings and maintenance
redirect_from: /nl/admin/options/learn/custlang/update
language: nl
index: true
---

# Klanttaal toevoegen

Op het scherm **Klanttalen** vindt u een lijst met de geïnstalleerde [klanttalen][2]. Vanuit dit scherm kunt u de taal van de klant configureren, waardoor het gemakkelijk is om met klanten in verschillende talen te communiceren.

Bijvoorbeeld:

* U kunt beschikken over meerdere taalversies van SuperOffice Customer Centre, Veelgestelde vragen en antwoordsjablonen.
* U kunt een taal opgeven voor een persoon, zodat deze persoon antwoorden automatisch in die taal ontvangt.
* [Verzoeken om ondersteuning van gebruikers kunnen worden ingedeeld][1] in verschillende groepen die kunnen verwijzen naar bepaalde afdelingen en talen.

U kunt 6 verschillende talen toevoegen. Als de taal die u wilt gebruiken niet beschikbaar is, neem dan contact met ons op en onze consultants kunnen u helpen de extra talen toe te voegen die u nodig hebt.

## Stappen

1. Ga naar Instellingen en onderhoud en selecteer <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Opties**.

2. Selecteer het tabblad **Klanttalen**.

3. Klik op de knop **Nieuwe klanttaal**. Het scherm **Eigenschappen klanttaal** wordt geopend.

    ![U kunt een nieuwe taal instellen in het dialoogvenster Eigenschappen klanttaal -screenshot][img1]

4. Voer in het veld **Naam** de naam in van de taal die u als label wilt gebruiken in taalselectievelden.

5. Voer in het veld **Taalcode** een korte code voor de relevante taal (of equivalent) in. Normaal gesproken worden internationale, twee-letterige afkortingen gebruikt (bijvoorbeeld DE, DK, EN, NL, NO en SE). Zie een volledige lijst aan het einde van deze pagina.

6. Voer in het veld **Virtueel domein** het domeinadres in dat toegang biedt tot het SuperOffice Customer Centre in de desbetreffende taal, bijvoorbeeld germany.liberty.com. U moet dergelijke domeinen vooraf instellen.

7. Voer in het veld **E-maildomeinen** een lijst met e-maildomeinen in (gescheiden door komma's), zoals: nl, no, se, co.uk. Wanneer een nieuwe persoon automatisch wordt geregistreerd (door een e-mailbericht te importeren) en het e-mailadres bevat een van deze domeinen, wordt automatisch de juiste taal voor die persoon ingesteld.

8. In het veld **Map voor Veelgestelde vragen** selecteert u welke map de bovenste map in de hiërarchie voor Veelgestelde vragen moet worden voor bezoekers van het SuperOffice Customer Centre in die specifieke taal. De hiërarchie voor Veelgestelde vragen kan dus worden opgesplitst in verschillende taalsecties en vervolgens per taal worden gefilterd. Dit levert betere zoekresultaten op en de gebruiker krijgt alleen de Veelgestelde vragen in de betreffende taal te zien.

9. Schakel de optie **Als standaard gebruiken** in als u deze taal als standaardtaal wilt instellen. Deze taal wordt dan gebruikt wanneer geen van de andere klanttalen aan de criteria voldoet of als er geen taal voor de klant is gedefinieerd.

10. Klik op **OK**. De klanttaal wordt gemaakt en u hebt de mogelijkheid om [Externe categorieën][1] te maken.

    > [!TIP]
    > Het is mogelijk om klanttaal te gebruiken voor andere doeleinden dan taal, als u slechts in één land activiteiten hebt bijvoorbeeld. U kunt bijvoorbeeld verschillende afdelingen, branches of bedrijfstakken maken, zoals bouw & constructie, badkamers, interieur en tuinen. Vervolgens kunnen het SuperOffice Customer Centre, de hiërarchie van de Veelgestelde vragen en de antwoordsjabloon de sector weerspiegelen die relevant is voor bepaalde klanten. De afkorting die wordt gebruikt voor de afdeling moet dan de naam van de map in de map/sjablonen weerspiegelen. Bijvoorbeeld: Bouw & Constructie = BC.

## Taalcodes

| Taal | Code |
|---|:-:|
| Chinees (vereenvoudigd) | CN |
| Tsjechisch | CZ |
| Deens | DA (niet DK) |
| Nederlands | NL |
| Engels | EN |
| Fins | FI |
| Frans | FR |
| Duits | DE |
| Duits (Zwitserland) | CH |
| Italiaans | IT |
| Koreaans | KO |
| Noors | NO |
| Pools | PL |
| Portugees (Brazilië) | BR |
| Russisch | RU |
| Spaans | ES |
| Zweeds | SE (niet SV) |
| Oekraïens | UK |
| Vietnamees | VI |

## Gerelateerde inhoud

* [Hoe SuperOffice de klanttaal voor nieuwe personen selecteert][2]

<!-- Referenced links -->
[1]: ../../request/admin/category/external-categories.md
[2]: ../learn/customer-languages.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/customer-centre-language.png
