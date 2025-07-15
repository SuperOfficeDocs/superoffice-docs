---
uid: help-nl-email-filter-create
title: E-mailfilters maken
description: E-mailfilters maken
keywords: e-mail, e-mailfilter, filter
author: SuperOffice RnD
date: 07.17.2024
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# E-mailfilter maken

1. [!include[Go to email](../includes/goto-email.md)]

1. Selecteer het tabblad **E-mailfilters**.

1. Klik op **Nieuw e-mailfilter**. Het scherm **Eigenschappen voor e-mailfilter** wordt geopend.

1. Op het tabblad **Filter** kunt u opgeven welke e-mailberichten moeten worden gefilterd door de volgende informatie in te voeren:

    * **Beschrijving**: Voer een korte beschrijving van het e-mailfilter in.
    * **Prioriteit**: selecteer in deze keuzelijst de prioriteit van het filter. De waarde 100 geeft de hoogste prioriteit aan, de waarde 1 de laagste.
    * **Script**: Hier kunt u een [script of macro][1] selecteren dat door dit filter moet worden uitgevoerd.

1. Selecteer waarop het filter van toepassing is:

    * **Alle inkomende e-mail**: Als u deze optie selecteert, wordt het e-mailfilter gebruikt voor alle binnenkomende e-mails.
    * **E-mailberichten met deze inhoud**: Als u deze optie selecteert, wordt het e-mailfilter geactiveerd door e-mailberichten die de reguliere expressies (regexp) bevatten die zijn opgegeven in de velden rechts. U kunt kiezen tussen de e-mailkoptekst en/of de hoofdtekst van de e-mail.

1. Op het tabblad **Reguliere expressies zoeken** kunt u reguliere expressies definiëren voor het zoeken van tekst in e-mailberichten en deze vervolgens opslaan als variabelen. U kunt de waarde van een reguliere expressie toewijzen aan een variabele met de naam mijnVariabele door de volgende notatie te gebruiken: mijnVariabele = &lt;regexp&gt;.

1. In het tabblad **Koppelingen instellen** kunt u aangeven hoe inkomende e-mail aan een verzoek en/of een persoon wordt gekoppeld op basis van de inhoud van het e-mailbericht:
    * **Koppelen aan persoon**: Als u het gegenereerde verzoek wilt koppelen aan een persoon op basis van informatie uit de e-mail, selecteert u een van de contactvelden in de lijst en voert u vervolgens een reguliere expressie in die de waarde retourneert die de persoon identificeert.
    * **Koppelen aan verzoek**: Met deze optie kunt u het e-mailbericht aan een bestaand verzoek koppelen op basis van een reguliere expressie waarmee informatie uit het e-mailbericht wordt opgehaald.

1. Op het tabblad **Waarden instellen** kunt u waarden toevoegen of wijzigen voor personen, bedrijven en verzoeken op basis van de inhoud van het e-mailbericht:
    1. selecteer in de keuzelijst links het gewenste veld voor de persoon, het bedrijf of het verzoek.

    2. Voer in het veld aan de rechterkant een van de volgende opties in:
        * de reguliere expressie dat de op te geven waarde zoekt
        * een vaste waarde (moet worden voorafgegaan door =)

    3. Wanneer u de optie **Vervangen** selecteert, wordt een bestaande waarde vervangen door de gevonden waarde.

    4. Klik op **Toevoegen** om de waarde toe te voegen.

        > [!TIP]
        > U kunt een waarde weer verwijderen door deze te selecteren en op <i class="ph ph-x-circle" aria-label="Remove icon"></i> te klikken.

1. Op het tabblad **Eigenschappen instellen** kunt u de specifieke eigenschappen instellen voor verzoeken die worden gegenereerd door e-mails die voldoen aan het huidige filter:

1. Op het tabblad **E-mailantwoord** kunt u verschillende e-mailberichten maken die moeten worden verzonden wanneer het filter wordt geactiveerd. Hier kunt u de volgende informatie invoeren:
    * **Antwoordsjabloon verzenden**: Hier kunt u selecteren welke [antwoordsjabloon][2] moet worden verzonden als het filter wordt geactiveerd.
    * **... naar persoon**: Wanneer u deze optie inschakelt, wordt de geselecteerde antwoordsjabloon naar de persoon verzonden.
    * **... naar**: Wanneer u deze optie inschakelt, wordt de geselecteerde antwoordsjabloon verzonden naar het e-mailadres dat is opgegeven in het veld rechts.
    * **Items uit Veelgestelde vragen voorstellen vanuit**: Wanneer u deze optie inschakelt, zal het systeem op basis van de tekst in het inkomende e-mailbericht items voor [Veelgestelde vragen voorstellen][3]. De voorgestelde items zijn beschikbaar als sjabloonvariabelen en kunnen dus worden hergebruikt in de geselecteerde antwoordsjabloon. U kunt ook aangeven in welke tak van de boomstructuur voor Veelgestelde vragen moet worden gezocht door de map op te geven.
    * **Automatisch antwoord blokkeren**: Wanneer u deze optie inschakelt, wordt dit e-mailbericht niet automatisch beantwoord door het systeem.

1. In het tabblad **Postbussen** kunt u de postbussen selecteren waarop het filter van toepassing is.

1. Klik op **OK**. Het e-mailfilter wordt gemaakt.

<!-- Referenced links -->
[1]: ../../../../automation/crmscript/learn/index.md
[2]: ../../../../knowledge-base/learn/reply-templates/index.md
[3]: ../../../../knowledge-base/learn/reply-templates/create.md#faq
