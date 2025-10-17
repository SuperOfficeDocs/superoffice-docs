---
uid: help-nl-preferences
title: Voorkeuren
description: Beheerders kunnen voorkeuren instellen voor verschillende functies in het systeem voor specifieke gebruikers, gebruikersgroepen of voor de gehele SuperOffice CRM (algemene voorkeuren).
keywords: instellingen, voorkeuren
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: concept
category: Settings and maintenance
topic: preferences
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: nl
redirect_from: 
  - /nl/admin/preferences/learn/index
  - /nl/admin/preferences/learn/global-preferences/system
---

# Voorkeuren <i class="ph ph-gear" aria-label="Gear icon"></i>

In het scherm Voorkeuren kunt u voorkeuren instellen voor het hele systeem (globaal), één database, één gebruikersgroep of een individuele gebruiker. Voorkeuren die alleen op algemeen (systeem)niveau kunnen worden ingesteld, zijn te vinden in het tabblad **[Algemene voorkeuren](#global)**.

Gebruikers kunnen de instellingen van [individuele voorkeuren][4] bewerken om ze voor eigen gebruik aan te passen door naar **Persoonlijke instellingen** (<i class="ph ph-user-circle" aria-hidden="true"></i>) > **Voorkeuren** in de bovenste balk te gaan. De voorkeuren die beschikbaar zijn voor de gebruiker, zijn afhankelijk van hetgeen is opgegeven in Instellingen en onderhoud.

Daarnaast kunt u [videovergaderingen][8] configureren op het tabblad **Videovergaderingen** en [documentbibliotheek][9] op het tabblad **Documentbibliotheek**.

## <a id="levels"></a>Niveaus voor voorkeursinstellingen

U kunt voorkeursinstellingen opgeven voor vier verschillende niveaus:

| Niveau | Beschrijving |
|---|---|
| Systeem | Algemene voorkeuren die gelden voor alle gebruikers in het systeem, inclusief alle satellieten, groepen en individuele gebruikers. |
| Database | Voorkeuren die gelden voor één specifieke database en alle groepen en gebruikers die zijn verbonden met deze database. |
| Groep | Voorkeuren die gelden voor alle gebruikers in een specifieke groep. |
| Gebruiker | Voorkeuren die zijn gekoppeld aan elke individuele gebruiker. |

U kunt verschillende waarden opgeven voor verschillende niveaus, zodat u bijvoorbeeld een bepaalde instelling hebt voor een gebruiker en een andere instelling voor de gebruikersgroep waartoe de betreffende persoon behoort. Het laagste niveau is altijd van toepassing.

> [!NOTE]
> niet alle niveaus zijn beschikbaar voor alle voorkeuren. Als een of meer van de opties zijn uitgeschakeld, kunt u deze niet kiezen voor de geselecteerde voorkeur.

U kunt in het veld **Actieve instellingen** kiezen welke instellingen u in de lijst wilt weergeven op basis van het niveau waarvoor ze zijn opgegeven. Welke niveaus worden weergegeven, is afhankelijk van de niveaus die u onder aan het veld inschakelt. U kunt deze selectievakjes gebruiken om één, twee of alle niveaus weer te geven.

> [!NOTE]
> instellingen op systeemniveau worden altijd weergegeven.

## <a id="global"></a>Algemene voorkeuren (voor het hele systeem)

Sommige voorkeuren kunnen alleen op algemeen niveau worden ingesteld:

* Statistieken
* Functies
* E-mail
* Marketing
* Gegroepeerde lijsten
* Mobile CRM
* Verkoop
* [SuperOffice Service-systeeminstellingen][1]
* Systeem
* Targets
* [Gegevens spiegelen][15]
* [SMS-configuratie][5]
* [SMTP][2] (alleen LOKAAL)
* [Wachtwoordbeleid Customer Centre][6]

### Algemene voorkeuren wijzigen

Als u deze voorkeuren wilt bewerken, gaat u naar het scherm **Voorkeuren** en selecteert u het tabblad **Algemene voorkeuren**.

* De verschillende voorkeuren zijn verdeeld in secties.
* Plaats de muisaanwijzer op een voorkeur om aanvullende informatie weer te geven.
* Klik op **Opslaan** om uw wijzigingen te implementeren.

## <a id="preferences-tab"></a>Tabblad Voorkeuren

In het tabblad **Voorkeuren** kunt u instellingen opgeven voor verschillende onderdelen van SuperOffice CRM. Voorbeelden zijn het aantal items dat wordt weergegeven in de historielijst, het standaardtype voor nieuwe vergaderingen en de standaardvaluta in het scherm Verkoop.

Boven aan het tabblad **Voorkeuren** kunt u de gewenste voorkeursgroep kiezen. De rest van het tabblad **Voorkeuren** is verdeeld in drie hoofdsecties: een lijst met alle voorkeuren, een beschrijvingsveld waarin de momenteel geselecteerde voorkeur wordt beschreven en een veld met de instellingen die voor die voorkeur zijn opgegeven.

### Lijst met voorkeuren

Links ziet u de lijst **Voorkeuren**, die alle voorkeuren bevat die zijn gedefinieerd voor de actieve groep met voorkeuren.

**Groepen van voorkeuren:**

* Persoon
* Standaardwaarden
* Agenda
* E-mail
* Dialoogvenster Filter
* Vrije-tekst zoekbewerking
* Functies
* Gegroepeerde lijsten
* In-app communicatie
* Marketing
* Meldingen via e-mail + pop-up + sms
* Verzoek
* Verkoop
* Sorteren
* Systeem
* Knopinfo
* Visuele effecten
* Webserver
* Web Services

> [!NOTE]
> Voorkeuren met actieve individuele instellingen worden met vette tekst weergegeven.

### Actieve instellingen

Het veld **Actieve instellingen** toont de instellingen voor de voorkeur die is geselecteerd in de lijst **Voorkeuren** met voor elke instelling de niveaus en de waarden. In dit veld kunt u bestaande instellingen bewerken en verwijderen en nieuwe instellingen toevoegen.

Het veld bestaat uit drie kolommen:

| Kolom | Beschrijving |
|---|---|
| Door | Geeft aan waarop de instelling van toepassing is (de naam van het systeem, de database, de groep of de gebruiker). Als het een individuele gebruiker betreft, wordt over deze gebruiker knopinfo weergegeven wanneer u de muisaanwijzer boven de initialen van de gebruiker in deze kolom houdt. |
| Niveau | Geeft aan op welk [niveau de instelling van toepassing is](#levels) (systeem, database, groep of gebruiker). |
| Waarde | geeft aan welke waarde is opgegeven voor deze instelling. |

De inhoud van deze kolommen wordt gedefinieerd in het dialoogvenster **Voorkeur toevoegen/bewerken**. [Voorkeursinstellingen toevoegen][3].

U kunt de rijen in de kolommen sorteren door op de gewenste kolomkop te klikken. Klik eenmaal op de kolomkop als u de sorteervolgorde wilt omdraaien.

<!-- Referenced links -->
[1]: service-settings.md
[2]: smtp.md
[3]: update.md
[4]: update.md#personal
[5]: sms.md
[6]: ../../customer-center/admin/password-policy.md
[8]: ../../diary/learn/video-meetings.md
[9]: ../../document/library/learn/index.md
[15]: ../../../en/online/mirroring/mirroring-task.md#options

<!-- Referenced images -->