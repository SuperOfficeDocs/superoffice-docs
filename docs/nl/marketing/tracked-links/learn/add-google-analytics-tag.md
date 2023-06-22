---
uid: help-nl-mailing-add-google-analytics
title: Uw Google Analytics-tag toevoegen aan een mailing
description: In deze handleiding leert u hoe u uw bezoekers kunt volgen.
author: Bergfrid Dias
so.date: 02.20.2023
keywords: Marketing
so.topic: howto
language: nl
---

# Uw Google Analytics-tag toevoegen aan een mailing

U kunt de mensen volgen die uw website bezoeken als gevolg van het lezen van uw mailings met behulp van de Google Analytics-functie in SuperOffice Marketing. Google Analytics-tracking moet worden ingesteld in de [eerste stap van voor elke mailing][1] die u maakt.

## Eisen

Als u de [functie Google Analytics][2] wilt gebruiken, heeft u een Google Analytics-account nodig dat is gekoppeld aan uw website.

[!include[Requirement](includes/req-marketing.md)]

## Stappen

1. Begin met het openen van de mailing die u wilt bijhouden met Google Analytics of maak een nieuwe mailing. Ga naar de eerste stap van de mailingwizard (Instellen). De koptekst **Tracking** bevindt zich in de rechterbenedenhoek. Hier kunt u de vakjes **Alle koppelingen traceren** en **Google Analytics gebruiken** aanvinken. Wanneer u Google Analytics gebruiken inschakelt, worden de tekstvelden van Google Analytics weergegeven.

    ![Vink het vakje voor Google Analytics aan en traceer alle koppelingen -screenshot][img1]

2. In de velden **Google Analytics traceren** is 'E-mail' vooraf gedefinieerd als het medium. Dit betekent dat getraceerde koppelingen in mailings die vanuit SuperOffice worden verzonden in Google Channel-rapporten kunnen worden gevonden onder **E-mails**in tegenstelling tot **Anders**.

3. Om een specifieke mailing als bron te identificeren, moeten ook de velden voor Bron en Campagne worden ingevuld.

    * In het veld **Bron** kunt u de bron van uw websiteverkeer toevoegen. Hier kunt u ervoor kiezen om gebruik te maken van de verschillende E-marketingabonnementen, zoals bijvoorbeeld Maandelijkse nieuwsbrief, Promotiemailing, etc.

    * In het veld **Campagne** kunt u de naam invoeren van de campagne die u uitvoert. Dit maakt het gemakkelijker om de resultaten van de mailing die u hebt verzonden bij te houden en te rapporteren. Hier kunt u campagnenamen invoeren, zoals bijvoorbeeld kerstverkoopcampagne of herfstverkoopcampagne, enzovoort.

4. Nadat u alle gegevens heeft ingesteld die u wilt gebruiken om uw mailing bij te houden in Google Analytics, kunt u de stappen van de mailingwizard volgen. Klik op **Volgende** om uw sjabloon te kiezen, inhoud toe te voegen, ontvangers toe te voegen en uw mailing te verzenden.

Alle koppelingen die u in de derde stap (Inhoud) toevoegt, worden automatisch bijgehouden omdat u de functie Google Analytics heeft ingeschakeld. Zodra uw ontvangers op de koppelingen naar uw website klikken, kunt u hun bezoeken aan uw website volgen in Google Analytics.

## De resultaten van uw mailing controleren in Google Analytics

U kunt de resultaten van uw mailings controleren door in te loggen op uw Google Analytics-account. Uw mailings moeten zichtbaar zijn in de Google Channel-rapporten onder E-mail.

> [!NOTE]
> Geef Google Analytics enige tijd om uw trackinginformatie te verwerken. Het kan 1-24 uur duren voordat uw mailingbron zich in uw rapporten heeft geregistreerd.

<!-- Referenced links -->
[1]: ../../mailing/learn/create/tutorial-email-mailing.yml
[2]: index.md#google

<!-- Referenced images -->
[img1]: media/google-analytics-tag.png
