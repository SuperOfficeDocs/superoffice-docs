---
uid: help-nl-chat-channel-create
title: Een chatkanaal maken
description: Een chatkanaal maken
keywords: chatkanaal, opmaak van chat-widget, agent toevoegen, offline formulier, formulier voor chat, formulier na chat, transcript inschakelen
author: Bergfrid Dias
date: 09.25.2025
version: 10.5
content_type: howto
license: cep
category: Service
topic: chat
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/chat/learn/admin/channel-create
index: true
---

# Een chatkanaal maken

U kunt chatkanalen maken voor specifieke doelen, zoals technische ondersteuning, vragen over producten en verkoopondersteuning en aan elk kanaal de relevante agents toewijzen.

![Het Chatkanalen-scherm in Instellingen en onderhoud met het dialoogvenster Chatkanaal bewerken open -screenshot][img1]

## Stappen

1. Klik op <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> **Chatten** in de Navigator.

2. Klik op **Toevoegen** onder aan de lijst met chatkanalen.

3. Geef in het dialoogvenster de naam van het chatkanaal op. Dit moet een unieke naam zijn die wordt gebruikt om het onderwerp en de taal (bijvoorbeeld *Technische ondersteuning Nederland*) te identificeren. De naam wordt alleen intern gebruikt.

4. Vul de velden in de tabbladen in zoals hieronder wordt beschreven.

    Uw wijzigingen worden automatisch opgeslagen wanneer u naar een ander tabblad gaat.

5. Klik op **Opslaan** wanneer u klaar bent.

> [!NOTE]
> Velden met rode kaders zijn verplicht. Tabbladen met het pictogram <i class="ph ph-warning-circle" aria-label="Warning icon"></i> bevatten lege verplichte velden.

## Eigenschappen

| Eigenschap | Beschrijving |
|---|---|
| Taal | selecteer de taal van het chatvenster. |
| Badge-koptekst | typ een korte tekst die wordt weergegeven bij het chatpictogram op uw website. |
| Beschrijving | Leg het doel van dit chatkanaal uit. De tekst wordt alleen intern weergegeven. |
| Waarschuwing voor nieuwe chat | als er binnen de vastgestelde tijd geen agents antwoorden op een nieuwe chat, wordt er een melding verzonden naar agents met de status **Aanwezig**. Agents moeten ook de machtiging **Meldingen** hebben in het tabblad **Agents**. |
| Beheerderswaarschuwing voor nieuwe chat | Als er binnen de vastgestelde tijd geen agents antwoorden op een nieuwe chat, wordt er een melding verzonden naar de beheerder(s). Deze waarschuwing wordt alleen verzonden als er agenten zijn met de status **Aanwezig**. |
| Openingstijden inschakelen | Schakel deze optie in om openingstijden in te stellen voor specifieke weekdagen. U kunt ook uw tijdzone instellen en lunchuren toevoegen wanneer chat niet beschikbaar is. Klanten zien altijd hun lokale tijd in de chat. |

Het voorbeeld rechts geeft het chatvenster weer met de huidige instellingen.

## Opmaak van chat-widget

In het tabblad **Opmaak van chat-widget** kunt u de opmaak en tekst van het chatvenster opgeven die door de klanten worden gebruikt.

| Veld | Beschrijving |
|---|---|
| Thema | selecteer een thema voor het chatvenster. |
| Kleur | Selecteer de basiskleur van het chatvenster. Deze instelling zal de gedefinieerde kleur in het geselecteerde thema overschrijven. |
| Lettertype | selecteer het lettertype van het chatvenster. Deze instelling zal het gedefinieerde lettertype in het geselecteerde thema overschrijven. |
| Logo weergeven | selecteer deze optie om een afbeelding weer te geven in de koptekst van het chatvenster. Klik op de koppeling of sleep er een afbeeldingsbestand naartoe en zet het neer om een afbeelding toe te voegen. |
| Foto van agent weergeven | selecteer deze optie om een foto van de agent weer te geven in het chatvenster. Als een agent reageert op een nieuwe chat, wordt het logo en de tekst van de koptekst vervangen door de foto en de naam van de agent. |
| Koptekst | typ een korte welkomsttekst om weer te geven in het chatvenster. |
| Bericht | typ een kort bericht om weer te geven onder de koptekst. |
| Aangepast wachtrijbericht gebruiken | Selecteer deze optie om een klantbericht voor de wachtrij in te voeren. |

U kunt variabelen gebruiken om de wachttijd en positie in de wachtrij aan te geven:

* {cque} = Een getal dat de positie in de wachtrij aangeeft
* {cavw} = De gemiddelde wachttijd, in de indeling uu:mm

Het voorbeeld rechts geeft het chatvenster weer met de huidige instellingen.

## Agenten

In het tabblad **Agents** kunt u gebruikers toegang geven tot een chatkanaal en opgeven welke machtigingen ze hebben in een chat.

### Een agent toevoegen

1. klik op de lijst links van de knop **Toevoegen** en selecteer een gebruiker.
2. Klik op **Toevoegen**. De gebruiker is toegevoegd aan de lijst met agents en heeft toegang tot het geselecteerde chatkanaal.
3. Selecteer een of meer van de volgende machtigingen:
    * **Kan antwoorden**: de agent kan antwoorden op de binnenkomende chats in dit kanaal.
    * **Kennisgevingen**: De agent ontvangt meldingen als hij/zij aanwezig is.
    * **Kan meeluisteren**: de agent kan de lopende chatgesprekken van een andere agent openen en controleren.
    * **Beheerder**: de agent ontvangt waarschuwingen voor beheerders. Deze machtiging kan bij voorbeeld worden gebruikt voor teamleiders.
4. Herhaal stappen 1-3 voor elke agent die u wilt toevoegen.

## <a id="chatbot"></a>ChatBot

In het tabblad **ChatBot** kunt u de chatbot activeren. Wanneer een chat wordt gestart op een kanaal waar een chatbot actief is, wordt het script "on-new-chat-message" geactiveerd en wordt het bericht doorgegeven aan het script voor verwerking. Het script verzendt het bericht voor verwerking en ontvangt het bericht, plaatst de resultaten en markeert mogelijk het bericht voor overdracht aan een agent.

| Optie | Beschrijving |
|---|---|
| Chatbot inschakelen | selecteer deze optie om de chatbot te activeren. |
| Map voor Chatbot CRMScript | selecteer de map die de scripts voor de chatbot bevat. |
| Naam Chatbot | hoe wilt u uw chatbot noemen? |

## Offline-formulier

In het tabblad **Offline-formulier** kunt u een bericht typen dat wordt weergegeven aan de klant als er geen agents aanwezig zijn (bijvoorbeeld buiten uw openingstijden). U kunt de klant ook een verzoek laten verzenden.

| Veld | Beschrijving |
|---|---|
| Koptekst | typ een korte tekst om de klant te laten weten waarom er geen agents beschikbaar zijn. |
| Bericht | typ een bericht. Voorbeelden: "Onze openingstijden zijn van 8 uur 's morgens tot 6 uur 's avonds" of "Vul de velden hieronder in en we nemen zo spoedig mogelijk contact met u op". |
| Verzenden verzoek inschakelen | selecteer deze optie om de klant een verzoek te laten verzenden als de chat niet beschikbaar is. |
| Verzoekcategorie | selecteer de categorie die aan de verzoeken moet worden toegewezen. |
| Verzoekprioriteit | selecteer de prioriteit die aan de verzoeken moet worden toegewezen. |
| Verplichte velden om verzoek te verzenden | selecteer de gegevens die de klant moet opgeven om een verzoek te verzenden. |

Het voorbeeld rechts geeft het chatvenster weer met de huidige instellingen.

## Pre-chatformulier

In het tabblad **Pre-chatformulier** kunt u definiëren hoe klanten zich moeten identificeren (of niet) in de chat. U kunt ook de geautomatiseerde suggesties voor veelgestelde vragen inschakelen van SuperOffice.

| Veld | Beschrijving |
|---|---|
| Pre-chatsuggesties Veelgestelde vragen inschakelen | Als u suggesties voor veelgestelde vragen inschakelt, wordt de top 3 van veelgestelde vragen die passen bij het bericht van de klant voorafgaand aan de chat weergegeven in het chatvenster. De klant kan klikken op de koppeling voor veelgestelde vragen om alle veelgestelde vragen in SuperOffice Customer Centre weer te geven. Als geen van gesuggereerde veelgestelde vragen de vragen van de klant beantwoordt, kan deze ervoor kiezen een chat te starten. |
| Map voor Veelgestelde vragen | Selecteer de map die de veelgestelde vragen (en submappen met veelgestelde vragen) bevat die moeten worden weergegeven voor de klanten. Alleen de veelgestelde vragen die zijn gepubliceerd en die toegankelijk zijn voor iedereen (geen aanmelding vereist) worden weergegeven voor de klanten. |
| Pre-chatformulier inschakelen voor anonieme gebruikers | selecteer deze optie als de klanten zich moeten identificeren voordat ze de chat starten. Laat deze optie uitgeschakeld om de klanten direct met de chat te laten starten. |
| Bericht | typ een bericht voor de klant. Bijvoorbeeld: "Laat ons weten wie u bent en hoe we u kunnen helpen". |
| Vereiste velden om chat te initiëren | selecteer de gegevens die de klant moet opgeven om de chat te starten. |

Het voorbeeld rechts geeft het chatvenster weer met de huidige instellingen.

## Post-chatformulier

Wanneer de klant of de agent de chat beëindigt, kunt u een post-chatformulier weergeven met extra informatie en de optie om een transcriptie van de chat te ontvangen.

| Veld | Beschrijving |
|---|---|
| Post-chatformulier inschakelen | selecteer deze optie om het post-chatformulier weer te geven voor de klant wanneer de chat is beëindigd. |
| Koptekst | typ een korte koptekst. |
| Bericht | typ een kort bericht voor de klant. |
| Transcriptie inschakelen | selecteer deze optie om transcriptie in te schakelen. De klant kan een e-mailadres invoeren waar de transcriptie naartoe moet worden verzonden. De antwoordsjabloon voor de transcriptie is te vinden in SuperOffice. |

Het voorbeeld rechts geeft het chatvenster weer met de huidige instellingen.

## Veelgestelde vragen

### Kan ik een chatkanaal verwijderen?

Ja, maar zorg ervoor dat het chatkanaal niet wordt gebruikt op een website. Anders is het chatvenster zichtbaar, maar niet functioneel.

<!-- Referenced images -->
[img1]: ../../../media/loc/en/chat/admin-chat-channels.png
