---
uid: help-nl-email-filter
title: E-mailfilters
description: E-mailfilters
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: e-mail
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: nl
---

# E-mailfilters

Een e-mailfilter is een hulpmiddel dat wordt gebruikt om de inhoud van inkomende e-mail te analyseren en een verzoek te genereren dat is gebaseerd op deze inhoud.

U kunt ook geavanceerde regels toevoegen om e-mail van specifieke afzenders af te handelen. E-mailfilters worden vaak gebruikt in combinatie met webformulieren die het bedrijf heeft gepubliceerd en die een vooraf opgesteld e-mailbericht genereren dat in SuperOffice Service wordt geïmporteerd.

## Voorbeeld met betrekking tot inkomende e-mail van webformulieren

U kunt bijvoorbeeld reguliere expressies definiëren om informatie te extraheren die een klant via het formulier heeft ingediend. Op basis van een gedefinieerde set regels worden gegevens van het formulier toegevoegd aan de klantendatabase. Het verzoek dat op basis van de e-mail of het formulier wordt gegenereerd, wordt vervolgens in een specifieke categorie geplaatst waarna er een verzoekbehandelaar wordt geselecteerd. Vervolgens wordt het verzoek gesloten en ontvangt de klant een aangepaste ontvangstbevestiging op basis van een antwoordsjabloon. Er zijn dus veel verschillende opties voor de automatische afhandeling van inkomende e-mail.

* E-mailberichten die via een webformulier zijn ontvangen, hebben doorgaans een standaardafzenderadres. U kunt dit adres vervangen door het eigen e-mailadres van de klant.

* U kunt het telefoonnummer van de klant vergelijken met de informatie in de klantendatabase en op basis daarvan het verzoek aan de juiste klant koppelen.

* U kunt adresgegevens overschrijven als er een adreswijziging is.

* U kunt een ontvangstbevestiging met op maat gemaakte informatie verzenden wanneer een klant meer informatie over een bepaald product wil ontvangen en vervolgens het verzoek toewijzen aan de juiste subcategorie en verzoekbehandelaar.

## Kolommen in de lijst met filters

Het tabblad **E-mailfilters** bevat een lijst met bestaande e-mailfilters. Deze lijst bevat de volgende kolommen:

| Kolom | Beschrijving |
|---|---|
| Beschrijving | Een beschrijving van het e-mailfilter. |
| Prioriteit | De prioriteit van het e-mailfilter. Per e-mailbericht wordt slechts één filter ingeschakeld. Wanneer er meerdere filters zijn waarvan de zoekcriteria overeenkomen met een inkomend e-mailbericht, wordt het filter met de hoogste prioriteit ingeschakeld. |
| E-mailadressen | De adressen van de postbus waarop het filter van toepassing is. |
| Zoekreeks | De zoekreeks die wordt gebruikt door het e-mailfilter. |

## Eigenschappen voor gegenereerde verzoeken

* **Eigenaar instellen**: Als u dit selecteert kunt u de gebruiker selecteren die wordt toegewezen aan de e-mails die met dit filter worden verwerkt.

* **Categorie instellen**: Wanneer u deze optie inschakelt en een categorie selecteert, komen de e-mailberichten die met dit filter worden verwerkt in de opgegeven categorie terecht.

* **Verzoektype**: Als u hier controleert en een type selecteert, wordt e-mail die door dit filter wordt verwerkt, toegewezen aan het gespecificeerde [verzoektype][3]. (Alleen beschikbaar in pilot.)

* **Prioriteit instellen**: Wanneer u deze optie inschakelt en een prioriteit selecteert, worden de e-mailberichten die met dit filter worden verwerkt aan de opgegeven prioriteit toegewezen.

* **Toegangsniveau instellen**: Wanneer u deze optie inschakelt en in de keuzelijst een toegangsniveau selecteert, worden de e-mailberichten die met dit filter worden verwerkt aan het opgegeven toegangsniveau toegewezen. Als u **Extern** selecteert, is het gegenereerde verzoek toegankelijk in het SuperOffice Customer Centre.

* **Berichten instellen**: wanneer u deze optie inschakelt en een antwoordsjabloon selecteert, wordt het verzoekbericht opgemaakt in overeenstemming met de geselecteerde antwoordsjabloon en samengevoegd met alle gevonden reguliere expressies. Op die manier kan een formulier dat via e-mail wordt verzonden, overzichtelijker worden weergegeven. Dit bericht vervangt de oorspronkelijke e-mail.

* **Verzoek sluiten**: Wanneer u deze optie inschakelt, wordt het verzoek direct gesloten en de status gewijzigd in **Gesloten**.

* **Van-adres negeren**: Als deze optie is ingeschakeld, negeert SuperOffice Service het oorspronkelijke afzenderadres. Het verzoek wordt dan niet aan een persoon gekoppeld, tenzij andere regels in het e-mailfilter een koppeling naar een persoon maken.

* **E-mail blokkeren**: Als deze optie is ingeschakeld, wordt de e-mail niet geïmporteerd in SuperOffice Service. In plaats daarvan wordt het toegevoegd aan de lijst op het tabblad **Geblokkeerde e-mail**.

* **E-mail permanent verwijderen**: Als deze optie is ingeschakeld, wordt de e-mail permanent verwijderd.

    > [!NOTE]
    > Het is niet mogelijk e-mailberichten te herstellen die permanent zijn verwijderd.

* **Doorsturen naar**: Wanneer u deze optie inschakelt en een e-mailadres invoert, wordt het e-mailbericht naar dit adres doorgestuurd.

* **Informatie voor foutopsporing opnemen in bericht**: Wanneer u deze optie inschakelt, neemt het bericht informatie op voor foutopsporing die u kunt gebruiken om te controleren of het e-mailfilter correct werkt.

* **E-mail markeren als geretourneerd**: Wanneer u deze optie inschakelt, worden de e-mailberichten die met dit filter worden verwerkt, als geretourneerd gemarkeerd. Dit kan relevant zijn voor e-mailberichten afkomstig van postmaster, mailer-daemon, enzovoort.

## Wat wilt u nu doen?

* [E-mailfilters maken][1]
* [E-mailfilters verwijderen][2]

<!-- Referenced links -->
[1]: create-email-filter.md
[2]: delete-email-filter.md
[3]: ../../../../request/learn/type/index.md

<!-- Referenced images -->
