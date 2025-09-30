---
uid: help-de-mailing-google-analytics-tutorial
title: Anleitung - einfaches Google Analytics E-Mail-Tracking
description: Diese Anleitung wird erklären, wie Sie die Ergebnisse eines Mailings mit SuperOffice verfolgen und diese in Google Analytics zusammen mit all Ihren anderen Daten nachschlagen können.
keywords: Marketing, Mailing, Google Analytics, verfolgen, Überwachte Links, Tracking-ID, UTM, Kampagne, Newsletter
author: Alex Pelan
date: 09.26.2025
version: 10.5
content_type: tutorial
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: de
translation_type: MT
---

# Anleitung - einfaches Google Analytics E-Mail-Tracking

<!-- markdownlint-disable-next-line MD036 -->
*Blogbeitrag von Alex Pelan*

E-Mail-Marketing ist zu einem wichtigen Bestandteil der Marketingstrategien von Unternehmen geworden, aber es gibt unzählige Möglichkeiten, digitales Marketing heutzutage durchzuführen. E-Mail-Marketing ist nur ein Teil des großen Ganzen. Wenn man zum Beispiel die Ergebnisse einer Kampagne analysieren möchte, ist es hilfreich, Daten aus allen Marketingkanälen in einem System zu sammeln, um das Gesamtbild zu erhalten.

Diese Anleitung wird erklären, wie Sie die Ergebnisse eines Mailings mit SuperOffice verfolgen und diese in Google Analytics zusammen mit all Ihren anderen Daten nachschlagen können.

## Was wir tun werden

Wir werden ein Google Analytics-Konto einrichten. Erstellen von Links und verfolgten Links in SuperOffice, die Ergebnisse an Google Analytics senden. Dann schließlich diese Ergebnisse in Google Analytics anzeigen.

Um dieser Anleitung zu folgen, benötigen Sie eine bestehende Website mit einem Domainnamen.

## Einrichten eines Google Analytics-Kontos

Gehen Sie zu [analytics.google.com][1] und melden Sie sich an, um auf Google Analytics zuzugreifen. Wenn Sie ein neues Konto erstellen, geben Sie ihm einen passenden Kontonamen.

![Neues Google Analytics-Konto -screenshot][img2]

Als nächstes müssen Sie die Eigenschaft (Website) einrichten, so:

![Google Analytics - Einrichten Ihrer Eigenschaft -screenshot][img3]

Jetzt können Sie Ihren Tracking-Code abrufen. Kopieren Sie diesen und fügen Sie ihn in den Code jeder Seite ein, die Sie verfolgen möchten. Platzieren Sie ihn direkt vor dem abschließenden `</head >`-Tag.

![Google Analytics Tracking-ID -screenshot][img4]

Nachdem Sie den Code implementiert haben, geben Sie die URL Ihrer Website in Ihren Browser ein. Gehen Sie nun zurück zu **Google Analytics** > **Berichterstattung** > **Echtzeit** > **Übersicht**. Wenn Sie alles richtig gemacht haben, sollte das Widget Jetzt gerade 1 aktiven Benutzer anzeigen.

![Google Analytics - Übersicht -screenshot][img5]

## Erstellen von verfolgbaren Links in SuperOffice

Zuerst müssen Sie ein neues Mailing einrichten. In diesem Beispiel habe ich einen Newsletter erstellt, bei dem ich verfolgen möchte, wie viele Benutzer auf den Link Mehr lesen geklickt haben. Natürlich möchten wir diese Daten in Google Analytics sehen. Wir werden nur den Teil des Erstellens des Links durchgehen.

![SuperOffice Verfolgungslink -screenshot][img6]

Beim Erstellen des Links in SuperOffice fragen wir nach einer URL. Um sehen zu können, dass der Benutzer vom Newsletter kommt, müssen Sie einige relevante Parameter zur URL hinzufügen. Diese sind:

| Einstellung | UTM-Parameter | Erforderlich | Beschreibung |
|---|---|:-:|---|
| Kampagnenquelle | utm_source | X | Identifiziert eine Suchmaschine, den Namen des Newsletters oder eine andere Quelle. Beispiel: `utm_source=newsletter June 2015` |
| Kampagnenmedium | utm_medium | X | Identifiziert ein Medium wie E-Mail oder Kosten-pro-Klick. Beispiel: `utm_medium=email` |
| Kampagneninhalt | utm_content | | Wird für A/B-Tests und inhaltsbezogene Anzeigen verwendet. Verwenden Sie utm_content, um Anzeigen oder Links zu unterscheiden, die auf dieselbe URL verweisen. Beispiele: `utm_content=logolink`, `utm_content=textlink` |
| Kampagnenname | utm_campaign | | Wird für die Keyword-Analyse verwendet. Identifiziert eine spezifische Produktwerbung oder strategische Kampagne. Beispiel: `utm_campaign=newsletters` |

Die endgültige URL sollte so aussehen:

`http://www.somecorp.com/index.html?utm_source=newsletter%20june%202015&utm_medium=email&utm_content=textlink&utm__campaign=newsletters`

Denken Sie daran, dass URLs keine Leerzeichen verarbeiten, daher müssen Sie Leerzeichen in der URL durch %20 ersetzen. Probieren Sie [Google's URL-Builder][2] aus, um Ihnen beim Generieren dieser URLs zu helfen.

Die URL, die Sie erstellt oder mit dem URL-Builder generiert haben, fügen Sie in das URL-Feld für einen Link ein, wie unten gezeigt:

![URL -screenshot][img7]

Oder Sie können die gleiche URL in einen verfolgten Link einfügen, so:

![URL einfügen -screenshot][img8]

Jetzt sind wir bereit, den Newsletter zu versenden. Nachdem Sie den Newsletter versendet haben, gehen Sie zurück zu Google Analytics.

![Google Analytics -screenshot][img9]

Sie werden nun den Traffic sehen, der durch Ihren E-Mail-Newsletter generiert wurde. Wie Sie auf dem Bild sehen können, können Sie Statistiken für die Kampagne **Newsletter Juni 2015** sehen. Sie werden auch sehen, von welchem Medium diese Benutzer kommen und die Anzahl der Klicks für jedes Medium. Dies wird es uns ermöglichen zu vergleichen, welches Medium die meisten Klicks generiert.

Beginnen Sie mit der Erkundung der Möglichkeiten!

<!-- Referenced links -->
[1]: http://analytics.google.com
[2]: https://support.google.com/analytics/answer/1033867

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/marketing/new-account.png
[img3]: ../../../../media/loc/en/marketing/setting-up-property.png
[img4]: ../../../../media/loc/en/marketing/tracking-id.png
[img5]: ../../../../media/loc/en/marketing/overview-right-now.png
[img6]: ../../../../media/loc/en/marketing/so-trackable-links.png
[img7]: ../../../../media/loc/en/marketing/generated-link.png
[img8]: ../../../../media/loc/en/marketing/insert-url.png
[img9]: ../../../../media/loc/en/marketing/google-analytics.png
